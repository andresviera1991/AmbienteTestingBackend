using FluentValidation;
using MGP.Backoffice.Application.UseCase.V1.Auth.Logout;
using MGP.Backoffice.CrossCutting.Helpers;
using MGP.Backoffice.CrossCutting.Messages;
using MGP.Backoffice.CrossCutting.MessagesManager;
using MGP.Backoffice.Domain.Interface;
using Microsoft.IdentityModel.Tokens;
using Moq;
using Xunit;

namespace MGP.Backoffice.Test.Handler
{
    public class LogoutHandlerTest
    {
        private readonly Mock<ILoginService> _loginServiceMock;
        private readonly Mock<IValidator<LogoutRequest>> _validatorMock;
        private readonly MessageManager _messageManager;
        private readonly LogoutHandler _handler;

        public LogoutHandlerTest()
        {
            _loginServiceMock = new Mock<ILoginService>();
            _validatorMock = new Mock<IValidator<LogoutRequest>>();

            string testPath = Path.Combine(Directory.GetCurrentDirectory(), "testPath");
            if (!Directory.Exists(testPath)) { Directory.CreateDirectory(testPath); }
            _messageManager = new MessageManager(new ErrorMessagesProvider(testPath));

            _handler = new LogoutHandler(_loginServiceMock.Object, _validatorMock.Object, _messageManager);

        }

        [Fact]
        public async Task Handle_ShouldReturnSuccess_WhenValidationSucceeds()
        {
            //Arrange

            //1) Defino el request
            LogoutRequest logoutRequest = new LogoutRequest() { RefreshToken = "eyJhJdfg34shjdijswH7HiH7I9JI..." };

            //2) Valido el request exitoso (Se proporcionan todos los parametros)
            _validatorMock.Setup(v => v.ValidateAsync(logoutRequest, It.IsAny<CancellationToken>())).ReturnsAsync(new FluentValidation.Results.ValidationResult());

            //3) Consumo el servicio de login
            _loginServiceMock.Setup(s => s.LogoutAsync(logoutRequest.RefreshToken));

            //Act
            var result = await _handler.Handle(logoutRequest, CancellationToken.None);

            //Assert
            Assert.Equal((int)Code.Success, result.Code);
            Assert.Null(result.Message);
        }

        [Fact]
        public async Task Handle_ShouldReturnBadRequest_WhenParametersAreMissing()
        {
            //Arrange

            //1) Defino el request
            LogoutRequest loginRequest = new LogoutRequest { RefreshToken = "" };

            //2) Valido el request (no es valido)
            var validationResult = new FluentValidation.Results.ValidationResult
            {
                Errors = { new FluentValidation.Results.ValidationFailure("Refresh Token", _messageManager.GetNotification(FunctionalErrors.NOT_NULL, nameof(LogoutRequest.RefreshToken))) }
            };

            _validatorMock.Setup(v => v.ValidateAsync(loginRequest, It.IsAny<CancellationToken>())).ReturnsAsync(validationResult);

            //Act
            var result = await _handler.Handle(loginRequest, CancellationToken.None);

            //Assert
            Assert.Equal((int)Code.BadRequest, result.Code);
        }

        [Fact]
        public async Task Handle_ShouldReturnUnauthorized_WhenTokenIsInvalid()
        {
            //Arrange

            //1) Defino el request
            LogoutRequest logoutRequest = new LogoutRequest() { RefreshToken = "eyJhJdfg34shjdijswH7HiH7I9JI..." };

            //2) Valido el request exitoso (Se proporcionan todos los parametros)
            _validatorMock.Setup(v => v.ValidateAsync(logoutRequest, It.IsAny<CancellationToken>())).ReturnsAsync(new FluentValidation.Results.ValidationResult());

            //3) El servicio devuelve una exception de token invalido
            _loginServiceMock.Setup(s => s.LogoutAsync(logoutRequest.RefreshToken)).Throws(new SecurityTokenExpiredException());

            //Act
            var result = await _handler.Handle(logoutRequest, CancellationToken.None);

            //Assert
            Assert.Equal((int)Code.Unauthorized, result.Code);
        }

        [Fact]
        public async Task Handle_ShouldReturnServiceUnavailable_WhenSeviceUnavailable()
        {
            //Arrange

            //1) Defino el request
            LogoutRequest logoutRequest = new LogoutRequest() { RefreshToken = "eyJhJdfg34shjdijswH7HiH7I9JI..." };

            //2) Valido el request exitoso (Se proporcionan todos los parametros)
            _validatorMock.Setup(v => v.ValidateAsync(logoutRequest, It.IsAny<CancellationToken>())).ReturnsAsync(new FluentValidation.Results.ValidationResult());

            //3) El servicio devuelve una exception de token invalido
            _loginServiceMock.Setup(s => s.LogoutAsync(logoutRequest.RefreshToken)).Throws(new Exception());

            //Act
            var result = await _handler.Handle(logoutRequest, CancellationToken.None);

            //Assert
            Assert.Equal((int)Code.ServiceUnavailable, result.Code);
        }
    }
}
