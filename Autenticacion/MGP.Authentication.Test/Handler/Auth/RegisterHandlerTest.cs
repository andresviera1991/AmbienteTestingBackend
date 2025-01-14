using AutoMapper;
using FluentValidation;
using MGP.Authentication.Application.UseCase.V1.Authentication.Register;
using MGP.Authentication.CrossCutting.Helpers;
using MGP.Authentication.CrossCutting.Messages;
using MGP.Authentication.CrossCutting.MessagesManager;
using MGP.Authentication.Domain.Interfaces;
using MGP.Authentication.Persistance.DTOs;
using Microsoft.EntityFrameworkCore;
using Moq;
using Xunit;
namespace MGP.Authentication.Test.Handler.Auth;

#pragma warning disable
public class RegisterHandlerTest
{

    private readonly Mock<IUserService> _registerServiceMock;
    private readonly Mock<IEmailService> _emailServiceMock;
    private readonly Mock<IValidator<RegisterRequest>> _validatorMock;
    private readonly Mock<IMapper> _mapperMock;
    private readonly MessageManager _messageManager;
    private readonly RegisterHandler _handler;

    public RegisterHandlerTest()
    {
        _registerServiceMock = new Mock<IUserService>();
        _validatorMock = new Mock<IValidator<RegisterRequest>>();
        _mapperMock = new Mock<IMapper>();
        _emailServiceMock = new Mock<IEmailService>();

        string testPath = Path.Combine(Directory.GetCurrentDirectory(), "testPath");
        if (!Directory.Exists(testPath)) { Directory.CreateDirectory(testPath); }
        _messageManager = new MessageManager(new ErrorMessagesProvider(testPath));

        _handler = new RegisterHandler(_registerServiceMock.Object, _validatorMock.Object, _mapperMock.Object, _messageManager);
    }

    [Fact]
    public async Task Handle_ShouldReturnSuccess_WhenValidationSucceeds()
    {
        //Arrange

        //1) Defino el request
        RegisterRequest registerRequest = CreateRegisterRequest();

        //2) Valido el request exitoso (Se proporcionan todos los parametros)
        _validatorMock.Setup(v => v.ValidateAsync(registerRequest, It.IsAny<CancellationToken>())).ReturnsAsync(new FluentValidation.Results.ValidationResult());

        //3) Defino el UserData
        UserData userData = new UserData()
        {
            Email = "cristian.fer.mel@gmail.com",
            Password = "Password_123",
            Person = registerRequest.Person,
        };

        //4) Mapear de RegisterRequest a User Data para el servicio
        _mapperMock.Setup(m => m.Map<UserData>(registerRequest)).Returns(userData);

        //5) Defino una respuesta simulada desde el servicio
        Guid userId = Guid.NewGuid();

        //6) Consumo el servicio de register y devuelvo el ID
        _registerServiceMock.Setup(s => s.RegisterAsync(userData)).ReturnsAsync(userId);

        //Act
        var result = await _handler.Handle(registerRequest, CancellationToken.None);

        //Assert
        Assert.Equal((int)Code.Created, result.Code);
        Assert.Equal(userId, result.Data.UserId);

    }

    [Fact]
    public async Task Handle_ShouldReturnBadRequest_WhenParametersAreMissing()
    {
        //Arrange

        //1) Defino el request
        RegisterRequest registerRequest = CreateRegisterRequest();
        registerRequest.Email = ""; // Is Empty

        //2) Se simula el request invalido por falta de parametro Email
        var validationResult = new FluentValidation.Results.ValidationResult
        {
            Errors = { new FluentValidation.Results.ValidationFailure("Email", _messageManager.GetNotification(FunctionalMessages.NOT_NULL, nameof(RegisterRequest.Email))) }
        };

        _validatorMock.Setup(v => v.ValidateAsync(registerRequest, It.IsAny<CancellationToken>())).ReturnsAsync(validationResult);

        // Act
        var result = await _handler.Handle(registerRequest, CancellationToken.None);

        // Assert
        Assert.Equal((int)Code.BadRequest, result.Code);
    }

    [Fact]
    public async Task Handle_ShouldReturnConflict_WhenAlreadyExist()
    {

        //1) Defino el request
        RegisterRequest registerRequest = CreateRegisterRequest();

        //2) Valido el request exitoso (Se proporcionan todos los parametros)
        _validatorMock.Setup(v => v.ValidateAsync(registerRequest, It.IsAny<CancellationToken>())).ReturnsAsync(new FluentValidation.Results.ValidationResult());

        //3) Defino el userData
        UserData userData = new UserData()
        {
            Email = "cristian.fer.mel@gmail.com",
            Password = "Password_123",
            Person = registerRequest.Person,
        };

        //4) Mapear de registerRequest a User Data para el servicio
        _mapperMock.Setup(m => m.Map<UserData>(registerRequest)).Returns(userData);

        //6) Consumo el servicio de login y arrojo exception DbUpdateException
        _registerServiceMock.Setup(s => s.RegisterAsync(userData)).Throws(new DbUpdateException());

        //Act
        var result = await _handler.Handle(registerRequest, CancellationToken.None);

        //Assert
        Assert.Equal((int)Code.Conflict, result.Code);

    }

    [Fact]
    public async Task Handle_ShouldReturnServiceUnavailable_WhenServiceUnavailable()
    {
        //1) Defino el request
        RegisterRequest registerRequest = CreateRegisterRequest();

        //2) Valido el request exitoso (Se proporcionan todos los parametros)
        _validatorMock.Setup(v => v.ValidateAsync(registerRequest, It.IsAny<CancellationToken>())).ReturnsAsync(new FluentValidation.Results.ValidationResult());

        //3) Defino el userData
        UserData userData = new UserData()
        {
            Email = "cristian.fer.mel@gmail.com",
            Password = "Password_123",
            Person = registerRequest.Person,
        };

        //4) Mapear de requestRegister a User Data para el servicio
        _mapperMock.Setup(m => m.Map<UserData>(registerRequest)).Returns(userData);

        //6) Consumo el servicio de Register y arrojo exception
        _registerServiceMock.Setup(s => s.RegisterAsync(userData)).Throws(new Exception());

        //Act
        var result = await _handler.Handle(registerRequest, CancellationToken.None);

        //Assert
        Assert.Equal((int)Code.ServiceUnavailable, result.Code);

    }

    private RegisterRequest CreateRegisterRequest()
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

        var registerRequest = new RegisterRequest
        {
            Email = "cristian.fer.mel@gmail.com",
            Password = "Password_123",
            Person = personData,
        };

        return registerRequest;
    }
}
