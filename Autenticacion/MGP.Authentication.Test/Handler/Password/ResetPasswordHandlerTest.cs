using FluentValidation;
using MGP.Authentication.Application.UseCase.V1.Password.Reset;
using MGP.Authentication.CrossCutting.Exceptions;
using MGP.Authentication.CrossCutting.Helpers;
using MGP.Authentication.CrossCutting.Messages;
using MGP.Authentication.CrossCutting.MessagesManager;
using MGP.Authentication.Domain.Interfaces;
using Microsoft.IdentityModel.Tokens;
using Moq;
using Xunit;
namespace MGP.Authentication.Test.Handler.Password;

public class ResetPasswordHandlerTest
{
    private readonly Mock<IPasswordService> _loginServiceMock;
    private readonly Mock<IValidator<ResetPasswordRequest>> _validatorMock;
    private readonly MessageManager _messageManager;
    private readonly ResetPasswordHandler _handler;

    public ResetPasswordHandlerTest()
    {
        _loginServiceMock = new Mock<IPasswordService>();
        _validatorMock = new Mock<IValidator<ResetPasswordRequest>>();

        string testPath = Path.Combine(Directory.GetCurrentDirectory(), "testPath");
        if (!Directory.Exists(testPath)) { Directory.CreateDirectory(testPath); }
        _messageManager = new MessageManager(new ErrorMessagesProvider(testPath));

        _handler = new ResetPasswordHandler(_loginServiceMock.Object, _validatorMock.Object, _messageManager);

    }

    [Fact]
    public async Task Handle_ShouldReturnSuccess_WhenValidationSucceeds()
    {
        //Arrange

        //1) Defino el request
        ResetPasswordRequest resetPasswordRequest = new ResetPasswordRequest() { Token = "eyJhJdfg34shjdijswH7HiH7I9JI", NewPassword = "NewPassword" };

        //2) Valido el request exitoso (Se proporcionan todos los parametros)
        _validatorMock.Setup(v => v.ValidateAsync(resetPasswordRequest, It.IsAny<CancellationToken>())).ReturnsAsync(new FluentValidation.Results.ValidationResult());

        //3) Consumo el servicio de login
        _loginServiceMock.Setup(s => s.ResetPasswordAsync(resetPasswordRequest.Token, resetPasswordRequest.NewPassword));

        //Act
        var result = await _handler.Handle(resetPasswordRequest, CancellationToken.None);

        //Assert
        Assert.Equal((int)Code.Success, result.Code);
        Assert.Null(result.Message);
    }

    [Fact]
    public async Task Handle_ShouldReturnBadRequest_WhenParametersAreMissing()
    {
        //Arrange

        //1) Defino el request
        ResetPasswordRequest resetPasswordRequest = new ResetPasswordRequest() { Token = "eyJhJdfg34shjdijswH7HiH7I9JI", NewPassword = "" };

        //2) Valido el request (no es valido)
        var validationResult = new FluentValidation.Results.ValidationResult
        {
            Errors = { new FluentValidation.Results.ValidationFailure("New Password", _messageManager.GetNotification(FunctionalMessages.NOT_NULL, nameof(ResetPasswordRequest.NewPassword))) }
        };

        _validatorMock.Setup(v => v.ValidateAsync(resetPasswordRequest, It.IsAny<CancellationToken>())).ReturnsAsync(validationResult);

        // Act
        var result = await _handler.Handle(resetPasswordRequest, CancellationToken.None);

        // Assert
        Assert.Equal((int)Code.BadRequest, result.Code);
    }

    [Fact]
    public async Task Handle_ShouldReturnNotFound_WhenUserDoesNotExists()
    {
        ///Arrange

        //1) Defino el request
        ResetPasswordRequest resetPasswordRequest = new ResetPasswordRequest() { Token = "eyJhJdfg34shjdijswH7HiH7I9JI", NewPassword = "NewPassword" };

        //2) Valido el request exitoso (Se proporcionan todos los parametros)
        _validatorMock.Setup(v => v.ValidateAsync(resetPasswordRequest, It.IsAny<CancellationToken>())).ReturnsAsync(new FluentValidation.Results.ValidationResult());

        //3) llamo al service, pero devuelve una exception de usuario inexistente
        _loginServiceMock.Setup(s => s.ResetPasswordAsync(resetPasswordRequest.Token, resetPasswordRequest.NewPassword)).Throws(new NotFoundException());

        //Act
        var result = await _handler.Handle(resetPasswordRequest, CancellationToken.None);

        //Assert
        Assert.Equal((int)Code.NotFound, result.Code);

    }

    [Fact]
    public async Task Handle_ShouldReturnUnauthorized_WhenTokenIsInvalid()
    {
        ///Arrange

        //1) Defino el request
        ResetPasswordRequest resetPasswordRequest = new ResetPasswordRequest() { Token = "eyJhJdfg34shjdijswH7HiH7I9JI", NewPassword = "NewPassword" };

        //2) Valido el request exitoso (Se proporcionan todos los parametros)
        _validatorMock.Setup(v => v.ValidateAsync(resetPasswordRequest, It.IsAny<CancellationToken>())).ReturnsAsync(new FluentValidation.Results.ValidationResult());

        //3) llamo al service, pero devuelve una exception de token invalido
        _loginServiceMock.Setup(s => s.ResetPasswordAsync(resetPasswordRequest.Token, resetPasswordRequest.NewPassword)).Throws(new SecurityTokenExpiredException());

        //Act
        var result = await _handler.Handle(resetPasswordRequest, CancellationToken.None);

        //Assert
        Assert.Equal((int)Code.Unauthorized, result.Code);

    }

    [Fact]
    public async Task Handle_ShouldReturnServiceUnavailabled_WhenServiceUnavailable()
    {
        ///Arrange

        //1) Defino el request
        ResetPasswordRequest resetPasswordRequest = new ResetPasswordRequest() { Token = "eyJhJdfg34shjdijswH7HiH7I9JI", NewPassword = "NewPassword" };

        //2) Valido el request exitoso (Se proporcionan todos los parametros)
        _validatorMock.Setup(v => v.ValidateAsync(resetPasswordRequest, It.IsAny<CancellationToken>())).ReturnsAsync(new FluentValidation.Results.ValidationResult());

        //3) llamo al service, pero devuelve una exception de servicio no disponible
        _loginServiceMock.Setup(s => s.ResetPasswordAsync(resetPasswordRequest.Token, resetPasswordRequest.NewPassword)).Throws(new Exception());

        //Act
        var result = await _handler.Handle(resetPasswordRequest, CancellationToken.None);

        //Assert
        Assert.Equal((int)Code.ServiceUnavailable, result.Code);
    }
}
