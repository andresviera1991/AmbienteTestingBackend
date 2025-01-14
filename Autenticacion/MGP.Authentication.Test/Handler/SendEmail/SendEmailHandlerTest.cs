using FluentValidation;
using MGP.Authentication.Application.UseCase.V1.Password.Reset;
using MGP.Authentication.Application.UseCase.V1.Password.ResetSendEmail;
using MGP.Authentication.CrossCutting.Exceptions;
using MGP.Authentication.CrossCutting.Helpers;
using MGP.Authentication.CrossCutting.Messages;
using MGP.Authentication.CrossCutting.MessagesManager;
using MGP.Authentication.Domain.Interfaces;
using MGP.Authentication.Persistance.DTOs;
using Moq;
using Xunit;

namespace MGP.Authentication.Test.Handler.SendEmail;

#pragma warning disable
public class SendEmailHandlerTest
{
    private readonly Mock<IPasswordService> _passwordService;
    private readonly Mock<IUserService> _userServiceMock;
    private readonly Mock<IValidator<ResetPasswordEmailRequest>> _validatorMock;

    private readonly MessageManager _messageManager;
    private readonly ResetPasswordEmailHandler _handler;

    public SendEmailHandlerTest()
    {
        _passwordService = new Mock<IPasswordService>();
        _userServiceMock = new Mock<IUserService>();

        _validatorMock = new Mock<IValidator<ResetPasswordEmailRequest>>();

        string testPath = Path.Combine(Directory.GetCurrentDirectory(), "testPath");
        if (!Directory.Exists(testPath)) { Directory.CreateDirectory(testPath); }
        _messageManager = new MessageManager(new ErrorMessagesProvider(testPath));

        _handler = new ResetPasswordEmailHandler(_userServiceMock.Object, _validatorMock.Object, _messageManager, _passwordService.Object);

    }

    [Fact]
    public async Task Handle_ShouldReturnSuccess_WhenValidationSucceeds()
    {
        //Arrange

        //1) Defino el request
        ResetPasswordEmailRequest sendEmailRequest = new ResetPasswordEmailRequest() { UserName = "44413552", EmailTypeEnum = CrossCutting.Enum.EmailType.RESET_PASSWORD };

        //2) Valido el request exitoso (Se proporcionan todos los parametros)
        _validatorMock.Setup(v => v.ValidateAsync(sendEmailRequest, It.IsAny<CancellationToken>())).ReturnsAsync(new FluentValidation.Results.ValidationResult());

        UserData userData = CreateUserData();

        //3) Obtengo el usuario
        _userServiceMock.Setup(s => s.GetUserByUserNameAsync(sendEmailRequest.UserName)).ReturnsAsync(userData);

        //Act
        var result = await _handler.Handle(sendEmailRequest, CancellationToken.None);

        //Assert
        Assert.Equal((int)Code.Success, result.Code);
    }

    [Fact]
    public async Task Handle_ShouldReturnBadRequest_WhenParametersAreMissing()
    {
        //Arrange

        //1) Defino el request
        ResetPasswordEmailRequest sendEmailRequest = new ResetPasswordEmailRequest() { UserName = "", EmailTypeEnum = CrossCutting.Enum.EmailType.RESET_PASSWORD };

        //2) Valido el request (no es valido)
        var validationResult = new FluentValidation.Results.ValidationResult
        {
            Errors = { new FluentValidation.Results.ValidationFailure("UserName", _messageManager.GetNotification(FunctionalMessages.NOT_NULL, nameof(ResetPasswordRequest.NewPassword))) }
        };

        _validatorMock.Setup(v => v.ValidateAsync(sendEmailRequest, It.IsAny<CancellationToken>())).ReturnsAsync(validationResult);

        // Act
        var result = await _handler.Handle(sendEmailRequest, CancellationToken.None);

        // Assert
        Assert.Equal((int)Code.BadRequest, result.Code);
    }

    [Fact]
    public async Task Handle_ShouldReturnNotFound_WhenUserDoesNotExists()
    {
        ///Arrange

        //1) Defino el request
        ResetPasswordEmailRequest sendEmailRequest = new ResetPasswordEmailRequest() { UserName = "44413552", EmailTypeEnum = CrossCutting.Enum.EmailType.RESET_PASSWORD };

        //2) Valido el request exitoso (Se proporcionan todos los parametros)
        _validatorMock.Setup(v => v.ValidateAsync(sendEmailRequest, It.IsAny<CancellationToken>())).ReturnsAsync(new FluentValidation.Results.ValidationResult());

        //3) Defino el LoginDat
        _userServiceMock.Setup(s => s.GetUserByUserNameAsync(sendEmailRequest.UserName)).Throws(new NotFoundException());

        var result = await _handler.Handle(sendEmailRequest, CancellationToken.None);

        Assert.Equal((int)Code.Success, result.Code);

    }

    [Fact]
    public async Task Handle_ShouldReturnServiceUnavailable_WhenServiceUnavailable()
    {
        ///Arrange

        //1) Defino el request
        ResetPasswordEmailRequest sendEmailRequest = new ResetPasswordEmailRequest() { UserName = "44413552", EmailTypeEnum = CrossCutting.Enum.EmailType.RESET_PASSWORD };

        //2) Valido el request exitoso (Se proporcionan todos los parametros)
        _validatorMock.Setup(v => v.ValidateAsync(sendEmailRequest, It.IsAny<CancellationToken>())).ReturnsAsync(new FluentValidation.Results.ValidationResult());

        //3) Defino el LoginDat
        _userServiceMock.Setup(s => s.GetUserByUserNameAsync(sendEmailRequest.UserName)).Throws(new Exception());

        var result = await _handler.Handle(sendEmailRequest, CancellationToken.None);

        Assert.Equal((int)Code.ServiceUnavailable, result.Code);

    }

    private UserData CreateUserData()
    {
        var addressData = new AddressData
        {
            Street = "Salta",
            StreetNumber = "2255",
            LocalityId = 155202,
            Floor = "1"
        };

        var phoneNumberData = new PhoneNumberData
        {
            Number = "1134452225"
        };

        var personData = new PersonData
        {
            Name = "Cristian",
            LastName = "Fernandez",
            DocumentNumber = "41139558",
            BirthDate = new DateTime(2006, 8, 2, 0, 0, 0, DateTimeKind.Utc),
            GenderId = 1,
            Address = addressData,
            PhoneNumber = phoneNumberData
        };

        var registerRequest = new UserData
        {
            Email = "cristian.fer.mel@gmail.com",
            Password = "Password_123",
            Person = personData,
        };

        return registerRequest;
    }
}
