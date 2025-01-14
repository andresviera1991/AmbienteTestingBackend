using FluentValidation;
using MGP.Authentication.Application.UseCase.V1.Authentication.RefreshSessionToken;
using MGP.Authentication.Application.UseCase.V1.Authentication.ValidateUser;
using MGP.Authentication.CrossCutting.Helpers;
using MGP.Authentication.CrossCutting.Messages;
using MGP.Authentication.CrossCutting.MessagesManager;
using MGP.Authentication.Domain.Interfaces;
using Microsoft.IdentityModel.Tokens;
using Moq;
using Xunit;
namespace MGP.Authentication.Test.Handler.Auth;

public class ValidateRegisterHandlerTest
{
    private readonly Mock<IUserService> _userServiceMock;
    private readonly Mock<IValidator<ValidateRegisterRequest>> _validatorMock;
    private readonly MessageManager _messageManager;
    private readonly ValidateRegisterHandler _handler;

    public ValidateRegisterHandlerTest()
    {
        _userServiceMock = new Mock<IUserService>();
        _validatorMock = new Mock<IValidator<ValidateRegisterRequest>>();

        string testPath = Path.Combine(Directory.GetCurrentDirectory(), "testPath");
        if (!Directory.Exists(testPath)) { Directory.CreateDirectory(testPath); }
        _messageManager = new MessageManager(new ErrorMessagesProvider(testPath));

        _handler = new ValidateRegisterHandler(_userServiceMock.Object, _validatorMock.Object, _messageManager);

    }

    [Fact]
    public async Task Handle_ShouldReturnSuccess_WhenValidationSucceeds()
    {
        //Arrange

        //1) Defino el request
        ValidateRegisterRequest validateRegisterRequest = new ValidateRegisterRequest() { Token = "eyJhJdfg34shjdijswH7HiH7I9JI..." };

        //2) Valido el request exitoso (Se proporcionan todos los parametros)
        _validatorMock.Setup(v => v.ValidateAsync(validateRegisterRequest, It.IsAny<CancellationToken>())).ReturnsAsync(new FluentValidation.Results.ValidationResult());

        //3) paso el token al servicio, no arroja exception
        _userServiceMock.Setup(s => s.ValidateUserAsync(validateRegisterRequest.Token));

        //Act
        var result = await _handler.Handle(validateRegisterRequest, CancellationToken.None);

        //Assert
        Assert.Equal((int)Code.Created, result.Code);
        Assert.Null(result.Message);

    }

    [Fact]
    public async Task Handle_ShouldReturnBadRequest_WhenParametersAreMissing()
    {
        //Arrange
        //1) Defino el request
        ValidateRegisterRequest validateRegisterRequest = new ValidateRegisterRequest() { Token = "eyJhJdfg34shjdijswH7HiH7I9JI..." };

        //2) Valido el request(no es valido)
        var validationResult = new FluentValidation.Results.ValidationResult
        {
            Errors = { new FluentValidation.Results.ValidationFailure("Refresh Token", _messageManager.GetNotification(FunctionalMessages.NOT_NULL, nameof(NewSessionTokenRequest.RefreshToken))) }
        };

        _validatorMock.Setup(v => v.ValidateAsync(validateRegisterRequest, It.IsAny<CancellationToken>())).ReturnsAsync(validationResult);

        //Act
        var result = await _handler.Handle(validateRegisterRequest, CancellationToken.None);

        //Assert
        Assert.Equal((int)Code.BadRequest, result.Code);
    }

    [Fact]
    public async Task Handle_ShouldReturnUnauthorized_WhenTokenIsInvalid()
    {
        //1) Defino el request
        ValidateRegisterRequest validateRegisterRequest = new ValidateRegisterRequest() { Token = "eyJhJdfg34shjdijswH7HiH7I9JI..." };

        //2) Valido el request exitoso (Se proporcionan todos los parametros)
        _validatorMock.Setup(v => v.ValidateAsync(validateRegisterRequest, It.IsAny<CancellationToken>())).ReturnsAsync(new FluentValidation.Results.ValidationResult());

        //5) Defino una respuesta simulada desde el servicio, invalid token
        _userServiceMock.Setup(s => s.ValidateUserAsync(validateRegisterRequest.Token)).Throws(new SecurityTokenExpiredException());

        //Act
        var result = await _handler.Handle(validateRegisterRequest, CancellationToken.None);

        //Assert
        Assert.Equal((int)Code.Unauthorized, result.Code);

    }

    [Fact]
    public async Task Handle_ShouldReturnServiceUnavailable_WhenServiceUnavailable()
    {
        ///Arrange

        //1) Defino el request
        ValidateRegisterRequest validateRegisterRequest = new ValidateRegisterRequest() { Token = "eyJhJdfg34shjdijswH7HiH7I9JI..." };

        //2) Valido el request exitoso (Se proporcionan todos los parametros)
        _validatorMock.Setup(v => v.ValidateAsync(validateRegisterRequest, It.IsAny<CancellationToken>())).ReturnsAsync(new FluentValidation.Results.ValidationResult());

        //3) Consumo el servicio de user, arrojo una exception
        _userServiceMock.Setup(s => s.ValidateUserAsync(validateRegisterRequest.Token)).Throws(new Exception());

        //Act
        var result = await _handler.Handle(validateRegisterRequest, CancellationToken.None);

        //Assert
        Assert.Equal((int)Code.ServiceUnavailable, result.Code);

    }
}
