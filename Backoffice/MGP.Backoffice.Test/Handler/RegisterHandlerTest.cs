using AutoMapper;
using FluentValidation;
using MGP.Backoffice.Application.UseCase.V1.Auth.Register;
using MGP.Backoffice.CrossCutting.Helpers;
using MGP.Backoffice.CrossCutting.Messages;
using MGP.Backoffice.CrossCutting.MessagesManager;
using MGP.Backoffice.Domain.DTOs;
using MGP.Backoffice.Domain.Interface;
using MGP.Backoffice.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Moq;
using Xunit;

namespace MGP.Backoffice.Test.Handler
{
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
            RegisterRequestData userData = new RegisterRequestData()
            {
                Email = "cristian.fer.mel@gmail.com",
            };

            //4) Mapear de RegisterRequest a User Data para el servicio
            _mapperMock.Setup(m => m.Map<RegisterRequestData>(registerRequest)).Returns(userData);

            //5) Defino una respuesta simulada desde el servicio
            Guid userId = Guid.NewGuid();

            //6) Consumo el servicio de register y devuelvo el ID
            _registerServiceMock.Setup(s => s.RegisterAsync(userData)).ReturnsAsync(true);

            //7) Mockeo el servicio de email
            _emailServiceMock.Setup(e => e.SendEmailAsync(userData.Email, "account/register", "Validacion de usuario"));

            //Act
            var result = await _handler.Handle(registerRequest, CancellationToken.None);

            //Assert
            Assert.Equal((int)Code.Created, result.Code);

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
                Errors = { new FluentValidation.Results.ValidationFailure("Email", _messageManager.GetNotification(FunctionalErrors.NOT_NULL, nameof(RegisterRequest.Email))) }
            };

            _validatorMock.Setup(v => v.ValidateAsync(registerRequest, It.IsAny<CancellationToken>())).ReturnsAsync(validationResult);

            // Act
            var result = await _handler.Handle(registerRequest, CancellationToken.None);

            // Assert
            Assert.Equal((int)Code.ServiceUnavailable, result.Code);
        }

        [Fact]
        public async Task Handle_ShouldReturnConflict_WhenAlreadyExist()
        {

            //1) Defino el request
            RegisterRequest registerRequest = CreateRegisterRequest();

            //2) Valido el request exitoso (Se proporcionan todos los parametros)
            _validatorMock.Setup(v => v.ValidateAsync(registerRequest, It.IsAny<CancellationToken>())).ReturnsAsync(new FluentValidation.Results.ValidationResult());

            //3) Defino el userData
            RegisterRequestData userData = new RegisterRequestData()
            {
                Email = "cristian.fer.mel@gmail.com",
            };

            //4) Mapear de registerRequest a User Data para el servicio
            _mapperMock.Setup(m => m.Map<RegisterRequestData>(registerRequest)).Returns(userData);

            //6) Consumo el servicio de login y arrojo exception DbUpdateException
            _registerServiceMock.Setup(s => s.RegisterAsync(userData)).Throws(new DbUpdateException());

            //Act
            var result = await _handler.Handle(registerRequest, CancellationToken.None);

            //Assert
            Assert.Equal((int)Code.BadRequest, result.Code);

        }

        [Fact]
        public async Task Handle_ShouldReturnServiceUnavailable_WhenServiceUnavailable()
        {
            //1) Defino el request
            RegisterRequest registerRequest = CreateRegisterRequest();

            //2) Valido el request exitoso (Se proporcionan todos los parametros)
            _validatorMock.Setup(v => v.ValidateAsync(registerRequest, It.IsAny<CancellationToken>())).ReturnsAsync(new FluentValidation.Results.ValidationResult());

            //3) Defino el userData
            RegisterRequestData userData = new RegisterRequestData()
            {
                Email = "cristian.fer.mel@gmail.com",
            };

            //4) Mapear de requestRegister a User Data para el servicio
            _mapperMock.Setup(m => m.Map<RegisterRequestData>(registerRequest)).Returns(userData);

            //6) Consumo el servicio de Register y arrojo exception
            _registerServiceMock.Setup(s => s.RegisterAsync(userData)).Throws(new Exception());

            //Act
            var result = await _handler.Handle(registerRequest, CancellationToken.None);

            //Assert
            Assert.Equal((int)Code.ServiceUnavailable, result.Code);

        }

        private RegisterRequest CreateRegisterRequest()
        {

            var registerRequest = new RegisterRequest
            {
                Email = "cristian.fer.mel@gmail.com"
            };

            return registerRequest;
        }
    }
}
