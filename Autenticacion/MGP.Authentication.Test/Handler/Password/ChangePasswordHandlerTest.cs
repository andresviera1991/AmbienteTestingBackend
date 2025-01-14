using AutoMapper;
using FluentValidation;
using MGP.Authentication.Application.UseCase.V1.Password.Change;
using MGP.Authentication.CrossCutting.Exceptions;
using MGP.Authentication.CrossCutting.Helpers;
using MGP.Authentication.CrossCutting.Messages;
using MGP.Authentication.CrossCutting.MessagesManager;
using MGP.Authentication.Domain.Interfaces;
using MGP.Authentication.Persistance.DTOs;
using Moq;
using Xunit;
namespace MGP.Authentication.Test.Handler.Password;

public class ChangePasswordHanlderTest
{
    private readonly Mock<IPasswordService> _passwordServiceMock;
    private readonly Mock<IValidator<ChangePasswordRequest>> _validatorMock;
    private readonly MessageManager _messageManager;
    private readonly Mock<IMapper> _mapperMock;
    private readonly ChangePasswordHandler _handler;

    public ChangePasswordHanlderTest()
    {
        _passwordServiceMock = new Mock<IPasswordService>();
        _validatorMock = new Mock<IValidator<ChangePasswordRequest>>();

        string testPath = Path.Combine(Directory.GetCurrentDirectory(), "testPath");
        if (!Directory.Exists(testPath)) { Directory.CreateDirectory(testPath); }
        _messageManager = new MessageManager(new ErrorMessagesProvider(testPath));

        _mapperMock = new Mock<IMapper>();

        _handler = new ChangePasswordHandler(_passwordServiceMock.Object, _messageManager, _validatorMock.Object, _mapperMock.Object);
    }

    [Fact]
    public async Task Handle_ShouldReturnSuccess_WhenValidationSucceeds()
    {
        //Arrange

        //1) Defino el request
        ChangePasswordRequest resetPasswordRequest = new ChangePasswordRequest() { UserId = Guid.NewGuid(), NewPassword = "NewPassword" , CurrentPassword = "password_123"};

        //2) Valido el request exitoso (Se proporcionan todos los parametros)
        _validatorMock.Setup(v => v.ValidateAsync(resetPasswordRequest, It.IsAny<CancellationToken>())).ReturnsAsync(new FluentValidation.Results.ValidationResult());

        ChangePasswordData changePasswordData = new ChangePasswordData()
        {
            UserId = resetPasswordRequest.UserId,
            NewPassword = resetPasswordRequest.NewPassword,
            CurrentPassword = resetPasswordRequest.CurrentPassword
        };

        //3) Mockeo de request a data
        _mapperMock.Setup(m => m.Map<ChangePasswordData>(resetPasswordRequest)).Returns(changePasswordData);

        //4) llamo al metodo change
        _passwordServiceMock.Setup(p => p.ChangePasswordAsync(changePasswordData));

        //Act
        var result = await _handler.Handle(resetPasswordRequest, CancellationToken.None);

        //Assert
        Assert.Equal((int)Code.Success, result.Code);
        Assert.Null(result.Message);
    }

    [Fact]
    public async Task Handle_ShouldThrowParameterNotProviderException_WhenNewPasswordIsEmpty()
    {
        //Arrange

        //1) Defino el request
        ChangePasswordRequest changePasswordRequest = new ChangePasswordRequest() { UserId = Guid.NewGuid(), NewPassword = "", CurrentPassword = "password_123" };

        //2) Valido el request (no es valido)
        var validationResult = new FluentValidation.Results.ValidationResult
        {
            Errors = { new FluentValidation.Results.ValidationFailure("New Password", _messageManager.GetNotification(FunctionalMessages.NOT_NULL, nameof(ChangePasswordRequest.NewPassword))) }
        };

        _validatorMock.Setup(v => v.ValidateAsync(changePasswordRequest, It.IsAny<CancellationToken>())).ReturnsAsync(validationResult);

        // Act
        var result = await _handler.Handle(changePasswordRequest, CancellationToken.None);

        // Assert
        Assert.Equal((int)Code.BadRequest, result.Code);
    }

    [Fact]
    public async Task Handle_ShouldThrowSamePasswordException_WhenNewPasswordIsEqual()
    {
        //Arrange

        //1) Defino el request
        ChangePasswordRequest changePasswordRequest = new ChangePasswordRequest() { UserId = Guid.NewGuid(), NewPassword = "", CurrentPassword = "password_123" };

        //2) Valido el request (no es valido)
        _validatorMock.Setup(v => v.ValidateAsync(changePasswordRequest, It.IsAny<CancellationToken>())).ReturnsAsync(new FluentValidation.Results.ValidationResult());

        ChangePasswordData changePasswordData = new ChangePasswordData()
        {
            UserId = changePasswordRequest.UserId,
            NewPassword = changePasswordRequest.NewPassword,
            CurrentPassword = changePasswordRequest.CurrentPassword
        };

        //3) Mapeo a change password data
        _mapperMock.Setup(m => m.Map<ChangePasswordData>(changePasswordRequest)).Returns(changePasswordData);

        //3) llamo al metodo y devuelve un same password async
        _passwordServiceMock.Setup(p => p.ChangePasswordAsync(changePasswordData)).Throws(new SamePasswordException());

        // Act
        var result = await _handler.Handle(changePasswordRequest, CancellationToken.None);

        // Assert
        Assert.Equal((int)Code.BadRequest, result.Code);
    }

    [Fact]
    public async Task Handle_ShouldThrowIncorrectCredentialException_WhenNewPasswordIsInvalid()
    {
        //Arrange

        //1) Defino el request
        ChangePasswordRequest changePasswordRequest = new ChangePasswordRequest() { UserId = Guid.NewGuid(), NewPassword = "", CurrentPassword = "password_123" };

        //2) Valido el request (no es valido)
        _validatorMock.Setup(v => v.ValidateAsync(changePasswordRequest, It.IsAny<CancellationToken>())).ReturnsAsync(new FluentValidation.Results.ValidationResult());

        ChangePasswordData changePasswordData = new ChangePasswordData()
        {
            UserId = changePasswordRequest.UserId,
            NewPassword = changePasswordRequest.NewPassword,
            CurrentPassword = changePasswordRequest.CurrentPassword
        };

        //3) Mapeo a change password data
        _mapperMock.Setup(m => m.Map<ChangePasswordData>(changePasswordRequest)).Returns(changePasswordData);

        //4) llamo al metodo y devuelve un same password async
        _passwordServiceMock.Setup(p => p.ChangePasswordAsync(changePasswordData)).Throws(new IncorrectCredentialException());

        // Act
        var result = await _handler.Handle(changePasswordRequest, CancellationToken.None);

        // Assert
        Assert.Equal((int)Code.BadRequest, result.Code);
    }

    [Fact]
    public async Task Handle_ShouldThrowException_WhenOtherError()
    {
        //Arrange

        //1) Defino el request
        ChangePasswordRequest changePasswordRequest = new ChangePasswordRequest() { UserId = Guid.NewGuid(), NewPassword = "", CurrentPassword = "password_123" };

        //2) Valido el request (no es valido)
        _validatorMock.Setup(v => v.ValidateAsync(changePasswordRequest, It.IsAny<CancellationToken>())).ReturnsAsync(new FluentValidation.Results.ValidationResult());

        ChangePasswordData changePasswordData = new ChangePasswordData()
        {
            UserId = changePasswordRequest.UserId,
            NewPassword = changePasswordRequest.NewPassword,
            CurrentPassword = changePasswordRequest.CurrentPassword
        };

        //3) Mapeo a change password data
        _mapperMock.Setup(m => m.Map<ChangePasswordData>(changePasswordRequest)).Returns(changePasswordData);

        //3) llamo al metodo y devuelve un same password async
        _passwordServiceMock.Setup(p => p.ChangePasswordAsync(changePasswordData)).Throws(new Exception());

        // Act
        var result = await _handler.Handle(changePasswordRequest, CancellationToken.None);

        // Assert
        Assert.Equal((int)Code.ServiceUnavailable, result.Code);
    }

}
