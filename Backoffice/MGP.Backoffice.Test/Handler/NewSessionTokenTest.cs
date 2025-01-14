using FluentValidation;
using MGP.Backoffice.Application.UseCase.V1.Auth.NewTokens;
using MGP.Backoffice.CrossCutting.Helpers;
using MGP.Backoffice.CrossCutting.Messages;
using MGP.Backoffice.CrossCutting.MessagesManager;
using MGP.Backoffice.Domain.Interface;
using MGP.Backoffice.Domain.Models;
using Microsoft.IdentityModel.Tokens;
using Moq;
using Xunit;

namespace MGP.Backoffice.Test.Handler
{
    public class NewSessionTokenTest
    {
        private readonly Mock<ILoginService> _loginServiceMock;
        private readonly Mock<IValidator<NewTokensRequest>> _validatorMock;
        private readonly MessageManager _messageManager;
        private readonly NewTokensHandler _handler;

        public NewSessionTokenTest()
        {
            _loginServiceMock = new Mock<ILoginService>();
            _validatorMock = new Mock<IValidator<NewTokensRequest>>();

            string testPath = Path.Combine(Directory.GetCurrentDirectory(), "testPath");
            if (!Directory.Exists(testPath)) { Directory.CreateDirectory(testPath); }
            _messageManager = new MessageManager(new ErrorMessagesProvider(testPath));

            _handler = new NewTokensHandler(_loginServiceMock.Object, _validatorMock.Object, _messageManager);

        }

        [Fact]
        public async Task Handle_ShouldReturnSuccess_WhenValidationSucceeds()
        {
            //Arrange

            //1) Defino el request
            NewTokensRequest NewTokensRequest = new NewTokensRequest() { RefreshToken = "eyJhJdfg34shjdijswH7HiH7I9JI..." };

            //2) Valido el request exitoso (Se proporcionan todos los parametros)
            _validatorMock.Setup(v => v.ValidateAsync(NewTokensRequest, It.IsAny<CancellationToken>())).ReturnsAsync(new FluentValidation.Results.ValidationResult());

            //3) Simulo la respuesta de los tokens
            TokenResponse tokens = new TokenResponse() { AccessToken = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9...", RefreshToken = "eyJhJdfg34shjdijswH7HiH7I9JI..." };

            //5) Llamo al metodo y devuelvo los tokens
            _loginServiceMock.Setup(s => s.CreateNewSessionTokens(NewTokensRequest.RefreshToken)).ReturnsAsync(tokens);

            //Act
            var result = await _handler.Handle(NewTokensRequest, CancellationToken.None);

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
            NewTokensRequest NewTokensRequest = new NewTokensRequest() { RefreshToken = "" };

            //2) Valido el request(no es valido)
            var validationResult = new FluentValidation.Results.ValidationResult
            {
                Errors = { new FluentValidation.Results.ValidationFailure("Refresh Token", _messageManager.GetNotification(FunctionalErrors.NOT_NULL, nameof(NewTokensRequest.RefreshToken))) }
            };

            _validatorMock.Setup(v => v.ValidateAsync(NewTokensRequest, It.IsAny<CancellationToken>())).ReturnsAsync(validationResult);

            //Act
            var result = await _handler.Handle(NewTokensRequest, CancellationToken.None);

            //Assert
            Assert.Equal((int)Code.BadRequest, result.Code);
        }

        [Fact]
        public async Task Handle_ShouldReturnUnauthorized_WhenTokenIsInvalid()
        {
            ///Arrange

            //1) Defino el request
            NewTokensRequest NewTokensRequest = new NewTokensRequest() { RefreshToken = "eyJhJdfg34shjdijswH7HiH7I9JI..." };

            //2) Valido el request exitoso (Se proporcionan todos los parametros)
            _validatorMock.Setup(v => v.ValidateAsync(NewTokensRequest, It.IsAny<CancellationToken>())).ReturnsAsync(new FluentValidation.Results.ValidationResult());

            //3) Consumo el servicio de login y arrojo Invalid Token
            _loginServiceMock.Setup(s => s.CreateNewSessionTokens(NewTokensRequest.RefreshToken)).Throws(new SecurityTokenExpiredException());

            //Act
            var result = await _handler.Handle(NewTokensRequest, CancellationToken.None);

            //Assert
            Assert.Equal((int)Code.Unauthorized, result.Code);

        }

        [Fact]
        public async Task Handle_ShouldReturnServiceUnavailable_WhenServiceUnavailable()
        {
            ///Arrange

            //1) Defino el request
            NewTokensRequest NewTokensRequest = new NewTokensRequest() { RefreshToken = "eyJhJdfg34shjdijswH7HiH7I9JI..." };

            //2) Valido el request exitoso (Se proporcionan todos los parametros)
            _validatorMock.Setup(v => v.ValidateAsync(NewTokensRequest, It.IsAny<CancellationToken>())).ReturnsAsync(new FluentValidation.Results.ValidationResult());

            //3) Consumo el servicio y arrojo exception
            _loginServiceMock.Setup(s => s.CreateNewSessionTokens(NewTokensRequest.RefreshToken)).Throws(new Exception());

            //Act
            var result = await _handler.Handle(NewTokensRequest, CancellationToken.None);

            //Assert
            Assert.Equal((int)Code.ServiceUnavailable, result.Code);

        }
    }
}
