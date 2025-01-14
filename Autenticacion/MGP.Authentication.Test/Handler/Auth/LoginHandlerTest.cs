using AutoMapper;
using FluentValidation;
using MGP.Authentication.Application.UseCase.V1.Authentication.Login;
using MGP.Authentication.CrossCutting.Exceptions;
using MGP.Authentication.CrossCutting.Helpers;
using MGP.Authentication.CrossCutting.Messages;
using MGP.Authentication.CrossCutting.MessagesManager;
using MGP.Authentication.Domain.Interfaces;
using MGP.Authentication.Domain.Models;
using MGP.Authentication.Persistance.DTOs;
using Moq;
using Xunit;

namespace MGP.Authentication.Test.Handler.Auth;

#pragma warning disable
public class LoginHandlerTest
{
    private readonly Mock<ILoginService> _loginServiceMock;
    private readonly Mock<IValidator<LoginRequest>> _validatorMock;
    private readonly Mock<IMapper> _mapperMock;
    private readonly MessageManager _messageManager;
    private readonly LoginHandler _handler;

    public LoginHandlerTest()
    {
        _loginServiceMock = new Mock<ILoginService>();
        _validatorMock = new Mock<IValidator<LoginRequest>>();
        _mapperMock = new Mock<IMapper>();

        string testPath = Path.Combine(Directory.GetCurrentDirectory(), "testPath");
        if (!Directory.Exists(testPath)) { Directory.CreateDirectory(testPath); }
        _messageManager = new MessageManager(new ErrorMessagesProvider(testPath));

        _handler = new LoginHandler(_loginServiceMock.Object, _validatorMock.Object, _mapperMock.Object, _messageManager);

    }

    [Fact]
    public async Task Handle_ShouldReturnSuccess_WhenValidationSucceeds()
    {
        //Arrange

        //1) Defino el request
        LoginRequest loginRequest = new LoginRequest() { UserName = "44413552", Password = "Password_123" };

        //2) Valido el request exitoso (Se proporcionan todos los parametros)
        _validatorMock.Setup(v => v.ValidateAsync(loginRequest, It.IsAny<CancellationToken>())).ReturnsAsync(new FluentValidation.Results.ValidationResult());

        //3) Defino el LoginData
        LoginData loginData = new LoginData() { UserName = "44413552", Password = "Password_123" };

        //4) Mapear de LoginRequest a Login Data para el servicio
        _mapperMock.Setup(m => m.Map<LoginData>(loginRequest)).Returns(loginData);

        //5) Defino una respuesta simulada desde el servicio
        TokenResponse tokens = new TokenResponse() { AccessToken = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9...", RefreshToken = "eyJhJdfg34shjdijswH7HiH7I9JI..." };

        //6) Consumo el servicio de login
        _loginServiceMock.Setup(s => s.LoginAsync(loginData)).ReturnsAsync(tokens);

        //Act
        var result = await _handler.Handle(loginRequest, CancellationToken.None);

        //Assert
        Assert.Equal((int)Code.Success, result.Code);
        Assert.Equal(tokens.AccessToken, result.Data.AccessToken);
        Assert.Equal(tokens.RefreshToken, result.Data.RefreshToken);
        Assert.Null(result.Message);

    }

    [Fact]
    public async Task Handle_ShouldReturnBadRequest_WhenParametersAreMissing()
    {
        //Arrange

        //1) Defino el request
        var loginRequest = new LoginRequest { UserName = "44413552", Password = "" };

        //2) Valido el request (no es valido)
        var validationResult = new FluentValidation.Results.ValidationResult
        {
            Errors = { new FluentValidation.Results.ValidationFailure("Password", _messageManager.GetNotification(FunctionalMessages.NOT_NULL, nameof(LoginRequest.Password))) }
        };

        _validatorMock.Setup(v => v.ValidateAsync(loginRequest, It.IsAny<CancellationToken>())).ReturnsAsync(validationResult);

        // Act
        var result = await _handler.Handle(loginRequest, CancellationToken.None);

        // Assert
        Assert.Equal((int)Code.BadRequest, result.Code);
    }

    [Fact]
    public async Task Handle_ShouldReturnNotFound_WhenUserDoesNotExists()
    {
        ///Arrange

        //1) Defino el request
        var loginRequest = new LoginRequest { UserName = "41139455", Password = "Password_123" };

        //2) Valido el request exitoso (Se proporcionan todos los parametros)
        _validatorMock.Setup(v => v.ValidateAsync(loginRequest, It.IsAny<CancellationToken>())).ReturnsAsync(new FluentValidation.Results.ValidationResult());

        //3) Defino el LoginData
        LoginData loginData = new LoginData() { UserName = "41139455", Password = "Password_123" };

        //4) Mapear de LoginRequest a Login Data para el servicio
        _mapperMock.Setup(m => m.Map<LoginData>(loginRequest)).Returns(loginData);

        //6) Consumo el servicio de login, da un NotFoundException
        _loginServiceMock.Setup(s => s.LoginAsync(loginData)).Throws(new NotFoundException());

        //Act
        var result = await _handler.Handle(loginRequest, CancellationToken.None);

        //Assert
        Assert.Equal((int)Code.NotFound, result.Code);

    }

    [Fact]
    public async Task Handle_ShouldReturnUnauthorized_WhenUserNotActivate()
    {
        ///Arrange

        //1) Defino el request
        var loginRequest = new LoginRequest { UserName = "41139455", Password = "Password_123" };

        //2) Valido el request exitoso (Se proporcionan todos los parametros)
        _validatorMock.Setup(v => v.ValidateAsync(loginRequest, It.IsAny<CancellationToken>())).ReturnsAsync(new FluentValidation.Results.ValidationResult());

        //3) Defino el LoginData
        LoginData loginData = new LoginData() { UserName = "41139455", Password = "Password_123" };

        //4) Mapear de LoginRequest a Login Data para el servicio
        _mapperMock.Setup(m => m.Map<LoginData>(loginRequest)).Returns(loginData);

        //5) Consumo el servicio de login
        _loginServiceMock.Setup(s => s.LoginAsync(loginData)).Throws(new UserNotActivatedException());

        //act
        var result = await _handler.Handle(loginRequest, CancellationToken.None);

        //Assert
        Assert.Equal((int)Code.Unauthorized, result.Code);
    }

    [Fact]
    public async Task Handle_ShouldReturnLocked_WhenUserDisable()
    {
        ///Arrange

        //1) Defino el request
        var loginRequest = new LoginRequest { UserName = "41139455", Password = "Password_123" };

        //2) Valido el request exitoso (Se proporcionan todos los parametros)
        _validatorMock.Setup(v => v.ValidateAsync(loginRequest, It.IsAny<CancellationToken>())).ReturnsAsync(new FluentValidation.Results.ValidationResult());

        //3) Defino el LoginData
        LoginData loginData = new LoginData() { UserName = "41139455", Password = "Password_123" };

        //4) Mapear de LoginRequest a Login Data para el servicio
        _mapperMock.Setup(m => m.Map<LoginData>(loginRequest)).Returns(loginData);

        //5) Consumo el servicio de login
        _loginServiceMock.Setup(s => s.LoginAsync(loginData)).Throws(new UserDisabledException());

        //Act
        var result = await _handler.Handle(loginRequest, CancellationToken.None);

        //Assert
        Assert.Equal((int)Code.Unauthorized, result.Code);

    }

    [Fact]
    public async Task Handle_ShouldReturnServiceUnavailable_WhenServiceUnavailable()
    {
        ///Arrange
        //1) Defino el request
        var loginRequest = new LoginRequest { UserName = "41139455", Password = "Password_123" };

        //2) Valido el request exitoso (Se proporcionan todos los parametros)
        _validatorMock.Setup(v => v.ValidateAsync(loginRequest, It.IsAny<CancellationToken>())).ReturnsAsync(new FluentValidation.Results.ValidationResult());

        //3) Defino el LoginData
        LoginData loginData = new LoginData() { UserName = "41139455", Password = "Password_123" };

        //4) Mapear de LoginRequest a Login Data para el servicio
        _mapperMock.Setup(m => m.Map<LoginData>(loginRequest)).Returns(loginData);

        //5) Consumo el servicio de login
        _loginServiceMock.Setup(s => s.LoginAsync(loginData)).Throws(new Exception());

        //Act
        var result = await _handler.Handle(loginRequest, CancellationToken.None);

        //Assert
        Assert.Equal((int)Code.ServiceUnavailable, result.Code);

    }
}
