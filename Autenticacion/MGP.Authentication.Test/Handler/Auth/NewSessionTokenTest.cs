using FluentValidation;
using MGP.Authentication.Application.UseCase.V1.Authentication.RefreshSessionToken;
using MGP.Authentication.CrossCutting.Helpers;
using MGP.Authentication.CrossCutting.Messages;
using MGP.Authentication.CrossCutting.MessagesManager;
using MGP.Authentication.Domain.Interfaces;
using MGP.Authentication.Domain.Models;
using Microsoft.IdentityModel.Tokens;
using Moq;
using Xunit;

namespace MGP.Authentication.Test.Handler.Auth;

public class NewSessionTokenTest
{
    private readonly Mock<ILoginService> _loginServiceMock;
    private readonly Mock<IValidator<NewSessionTokenRequest>> _validatorMock;
    private readonly MessageManager _messageManager;
    private readonly NewSessionTokenHandler _handler;

    public NewSessionTokenTest()
    {
        _loginServiceMock = new Mock<ILoginService>();
        _validatorMock = new Mock<IValidator<NewSessionTokenRequest>>();

        string testPath = Path.Combine(Directory.GetCurrentDirectory(), "testPath");
        if (!Directory.Exists(testPath)) { Directory.CreateDirectory(testPath); }
        _messageManager = new MessageManager(new ErrorMessagesProvider(testPath));

        _handler = new NewSessionTokenHandler(_loginServiceMock.Object, _validatorMock.Object, _messageManager);

    }

    [Fact]
    public async Task Handle_ShouldReturnSuccess_WhenValidationSucceeds()
    {
        //Arrange

        //1) Defino el request
        NewSessionTokenRequest newSessionTokenRequest = new NewSessionTokenRequest() { RefreshToken = "eyJhJdfg34shjdijswH7HiH7I9JI..." };

        //2) Valido el request exitoso (Se proporcionan todos los parametros)
        _validatorMock.Setup(v => v.ValidateAsync(newSessionTokenRequest, It.IsAny<CancellationToken>())).ReturnsAsync(new FluentValidation.Results.ValidationResult());

        //3) Simulo la respuesta de los tokens
        TokenResponse tokens = new TokenResponse() { AccessToken = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9...", RefreshToken = "eyJhJdfg34shjdijswH7HiH7I9JI..." };

        //4) Llamo al metodo y devuelvo los tokens
        _loginServiceMock.Setup(s => s.CreateNewSessionTokenAsync(newSessionTokenRequest.RefreshToken)).ReturnsAsync(tokens);

        //Act
        var result = await _handler.Handle(newSessionTokenRequest, CancellationToken.None);

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
        NewSessionTokenRequest newSessionTokenRequest = new NewSessionTokenRequest() { RefreshToken = "" };

        //2) Valido el request(no es valido)
        var validationResult = new FluentValidation.Results.ValidationResult
        {
            Errors = { new FluentValidation.Results.ValidationFailure("Refresh Token", _messageManager.GetNotification(FunctionalMessages.NOT_NULL, nameof(NewSessionTokenRequest.RefreshToken))) }
        };

        _validatorMock.Setup(v => v.ValidateAsync(newSessionTokenRequest, It.IsAny<CancellationToken>())).ReturnsAsync(validationResult);

        //Act
        var result = await _handler.Handle(newSessionTokenRequest, CancellationToken.None);

        //Assert
        Assert.Equal((int)Code.BadRequest, result.Code);
    }

    [Fact]
    public async Task Handle_ShouldReturnUnauthorized_WhenTokenIsInvalid()
    {
        ///Arrange

        //1) Defino el request
        NewSessionTokenRequest newSessionTokenRequest = new NewSessionTokenRequest() { RefreshToken = "eyJhJdfg34shjdijswH7HiH7I9JI..." };

        //2) Valido el request exitoso (Se proporcionan todos los parametros)
        _validatorMock.Setup(v => v.ValidateAsync(newSessionTokenRequest, It.IsAny<CancellationToken>())).ReturnsAsync(new FluentValidation.Results.ValidationResult());

        //3) Consumo el servicio de login y arrojo Invalid Token
        _loginServiceMock.Setup(s => s.CreateNewSessionTokenAsync(newSessionTokenRequest.RefreshToken)).Throws(new SecurityTokenExpiredException());

        //Act
        var result = await _handler.Handle(newSessionTokenRequest, CancellationToken.None);

        //Assert
        Assert.Equal((int)Code.Unauthorized, result.Code);

    }

    [Fact]
    public async Task Handle_ShouldReturnServiceUnavailable_WhenServiceUnavailable()
    {
        ///Arrange

        //1) Defino el request
        NewSessionTokenRequest newSessionTokenRequest = new NewSessionTokenRequest() { RefreshToken = "eyJhJdfg34shjdijswH7HiH7I9JI..." };

        //2) Valido el request exitoso (Se proporcionan todos los parametros)
        _validatorMock.Setup(v => v.ValidateAsync(newSessionTokenRequest, It.IsAny<CancellationToken>())).ReturnsAsync(new FluentValidation.Results.ValidationResult());

        //3) Consumo el servicio y arrojo exception
        _loginServiceMock.Setup(s => s.CreateNewSessionTokenAsync(newSessionTokenRequest.RefreshToken)).Throws(new Exception());

        //Act
        var result = await _handler.Handle(newSessionTokenRequest, CancellationToken.None);

        //Assert
        Assert.Equal((int)Code.ServiceUnavailable, result.Code);

    }
}
