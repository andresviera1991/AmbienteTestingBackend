using MGP.Authentication.CrossCutting.Exceptions;
using MGP.Authentication.Domain.Interfaces;
using MGP.Authentication.Domain.Models;
using MGP.Authentication.Domain.Services;
using MGP.Authentication.Persistance.Data.Tables;
using MGP.Authentication.Persistance.DTOs;
using MGP.Authentication.Persistance.Interface;
using Microsoft.IdentityModel.Tokens;
using Moq;
using Xunit;

namespace MGP.Authentication.Test.Service;

#pragma warning disable

public class LoginServiceTest
{
    private readonly Mock<ILoginRepository> _loginRepositoryMock;
    private readonly Mock<IJwtValidator> _jwtValidatorMock;
    private readonly Mock<IJwtTokenGenerator> _jwtTokenGeneratorMock;
    private readonly Mock<IEncryptionService> _encryptionServiceMock;
    private readonly Mock<IEmailService> _emailService;
    private readonly LoginService _loginService;

    public LoginServiceTest()
    {
        _loginRepositoryMock = new Mock<ILoginRepository>();
        _jwtTokenGeneratorMock = new Mock<IJwtTokenGenerator>();
        _encryptionServiceMock = new Mock<IEncryptionService>();
        _jwtValidatorMock = new Mock<IJwtValidator>();
        _emailService = new Mock<IEmailService>();
        _loginService = new LoginService(_loginRepositoryMock.Object, _jwtTokenGeneratorMock.Object, _jwtValidatorMock.Object, _encryptionServiceMock.Object, _emailService.Object);
    }

    #region LOGIN

    [Fact]
    public async Task Service_ShouldReturnTokens_WhenCredentialsAreValid()
    {
        //Arrange

        //1) Defino el LoginData
        LoginData loginData = new LoginData() { UserName = "44413552", Password = "Password_123" };

        //2) Defino la respuesta del GetUserByUserName
        User user = CreateUser();

        //3) Llamo al metodo
        _loginRepositoryMock.Setup(l => l.GetUserByUserNameAsync(loginData.UserName)).ReturnsAsync(user);

        //4) Verifico el password, me devuelve true
        _encryptionServiceMock.Setup(e => e.VerifyPassword(user.Password, loginData.Password)).Returns(true);

        //5) Reseteo los intentos fallidos
        _loginRepositoryMock.Setup(l => l.ResetFailedLoginAsync(user));

        //6) Genero los token de respuesta
        TokenResponse tokenResponse = new TokenResponse() { AccessToken = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9...", RefreshToken = "eyJhJdfg34shjdijswH7HiH7I9JI..." };

        //7) llamo al metodo de generación de token
        _jwtTokenGeneratorMock.Setup(t => t.GenerateSessionTokenAsync(user)).ReturnsAsync(tokenResponse);

        //Act
        var result = await _loginService.LoginAsync(loginData);

        //Assert
        Assert.Equal(result.AccessToken, tokenResponse.AccessToken);
        Assert.Equal(result.RefreshToken, tokenResponse.RefreshToken);

    }

    [Fact]
    public async Task Service_ShouldReturnNotFoundException_WhenUserNotExist()
    {
        //Arrange

        //1) Defino el LoginData
        LoginData loginData = new LoginData() { UserName = "44413552", Password = "Password_123" };

        //2) Llamo al metodo
        _loginRepositoryMock.Setup(l => l.GetUserByUserNameAsync(loginData.UserName)).Throws(new NotFoundException());

        //3) Act y espero la exception
        var exception = await Assert.ThrowsAsync<NotFoundException>(async () =>
        {
            await _loginService.LoginAsync(loginData);
        });

        //Assert
        Assert.NotNull(exception);

    }

    [Fact]
    public async Task Service_ShouldReturnUserNotActivatedException_WhenUserIsNotActive()
    {
        //Arrange

        //1) Defino el LoginData
        LoginData loginData = new LoginData() { UserName = "44413552", Password = "Password_123" };

        //2) Defino la respuesta del GetUserByUserName
        User user = CreateUser();
        user.UserStatusId = 2;

        //3) Llamo al metodo
        _loginRepositoryMock.Setup(l => l.GetUserByUserNameAsync(loginData.UserName)).ReturnsAsync(user);

        //4) Act y espero la exception
        var exception = await Assert.ThrowsAsync<UserNotActivatedException>(async () =>
        {
            await _loginService.LoginAsync(loginData);
        });

        //Assert
        Assert.NotNull(exception);

    }

    [Fact]
    public void Service_ShouldReturnUserDisableException_WhenUserIsDisable()
    {
        //Arrange

        //1) Defino el LoginData
        LoginData loginData = new LoginData() { UserName = "44413552", Password = "Password_123" };

        //2) Defino la respuesta del GetUserByUserName
        User user = CreateUser();
        user.UserStatusId = 3;

        //3) Llamo al metodo
        _loginRepositoryMock.Setup(l => l.GetUserByUserNameAsync(loginData.UserName)).ReturnsAsync(user);

        //4) Act y espero la exception
        var exception = Assert.ThrowsAsync<UserDisabledException>(async () =>
        {
            await _loginService.LoginAsync(loginData);
        });

        //Assert
        Assert.NotNull(exception);

    }

    [Fact]
    public async Task Service_ShouldReturnUserNotFoundException_WhenPasswordIsIncorrect()
    {
        //Arrange

        //1) Defino el LoginData
        LoginData loginData = new LoginData() { UserName = "44413552", Password = "Password_123" };

        //2) Defino la respuesta del GetUserByUserName
        User user = CreateUser();

        //3) Llamo al metodo
        _loginRepositoryMock.Setup(l => l.GetUserByUserNameAsync(loginData.UserName)).ReturnsAsync(user);

        //4) Verifico el password, me devuelve true
        _encryptionServiceMock.Setup(e => e.VerifyPassword(user.Password, loginData.Password)).Returns(false);

        //5) Reseteo los intentos fallidos
        _loginRepositoryMock.Setup(l => l.ResetFailedLoginAsync(user));

        //6) Act y exception
        var exception = await Assert.ThrowsAsync<IncorrectCredentialException>(async () =>
        {
            await _loginService.LoginAsync(loginData);
        });

        //Assert
        Assert.NotNull(exception);

    }

    [Fact]
    public async Task Service_ShouldReturnUserDisableException_WhenFailedLoginAttemptsIsThree()

    {
        //Arrange

        //1) Defino el LoginData
        LoginData loginData = new LoginData() { UserName = "44413552", Password = "Password_123" };

        //2) Defino la respuesta del GetUserByUserName
        User user = CreateUser();

        //3) Llamo al metodo
        _loginRepositoryMock.Setup(l => l.GetUserByUserNameAsync(loginData.UserName)).ReturnsAsync(user);

        //4) Verifico el password, me devuelve true
        _encryptionServiceMock.Setup(e => e.VerifyPassword(user.Password, loginData.Password)).Returns(false);

        //5) Reseteo los intentos fallidos
        _loginRepositoryMock.Setup(l => l.IncrementFailedLoginsAsync(user)).Throws(new UserDisabledException());

        //6) Act y exception
        var exception = await Assert.ThrowsAsync<UserDisabledException>(async () =>
        {
            await _loginService.LoginAsync(loginData);
        });

        //Assert
        Assert.NotNull(exception);

    }

    #endregion

    #region LOGOUT

    [Fact]
    public async Task Service_ShouldReturnVoid_WhenRefreshTokenIsValid()
    {
        //Arrange

        //1) Defino el LogoutData
        string refreshToken = "eyJhJdfg34shjdijswH7HiH7I9JI...";

        //2) Creo el token information
        TokenInformation tokenInformation = new TokenInformation() { ExpirationDate = DateTime.Now, UserId = Guid.NewGuid() };

        //3) Llamo al metodo que valida el token, devuelve el tokenInformation
        _jwtValidatorMock.Setup(v => v.ValidateRefreshTokenAsync(refreshToken)).ReturnsAsync(tokenInformation);

        //4) Llamo al metodo para revocar el token. Si no da error, debería seguir la ejecución. 
        _loginRepositoryMock.Setup(l => l.RevokeRefreshSessionTokenAsync(refreshToken, tokenInformation.UserId, tokenInformation.ExpirationDate));

        //Act
        await _loginService.LogoutAsync(refreshToken);

        //Assert
        _jwtValidatorMock.Verify(v => v.ValidateRefreshTokenAsync(refreshToken), Times.Once);
        _loginRepositoryMock.Verify(l => l.RevokeRefreshSessionTokenAsync(refreshToken, tokenInformation.UserId, tokenInformation.ExpirationDate), Times.Once);

    }

    [Fact]
    public async Task Service_ShoudlReturnInvalidTokenException_WhenTokenIsInvalid()
    {
        //Arrange

        //1) Proveo un refreshToken invalid.  
        string refreshToken = "eyJhJdfg34shjdijswH7HiH7I9JI...";

        //2) Llamo al metodo que valida el token y devuelvo una excpetion
        _jwtValidatorMock.Setup(v => v.ValidateRefreshTokenAsync(refreshToken)).Throws(new SecurityTokenExpiredException());

        //3) Act y exception
        var exception = await Assert.ThrowsAsync<SecurityTokenExpiredException>(async () =>
        {
            await _loginService.LogoutAsync(refreshToken);
        });

        //Assert
        Assert.NotNull(exception);

    }

    [Fact]
    public async Task Service_ShoudlReturnInvalidRefreshTokenException_WhenTokenAlreadyExistInDatabase()
    {
        //Arrange

        //1) Proveo un refreshToken invalid.  
        string refreshToken = "eyJhJdfg34shjdijswH7HiH7I9JI...";

        //2) Creo el token information
        TokenInformation tokenInformation = new TokenInformation() { ExpirationDate = DateTime.Now, UserId = Guid.NewGuid() };

        //3) Llamo al metodo para revocar el token. Si no da error, debería seguir la ejecución. 
        _jwtValidatorMock.Setup(v => v.ValidateRefreshTokenAsync(refreshToken)).ReturnsAsync(tokenInformation);

        //4) Llamo al metodo para revocar el token. Arroja exception debido a token refresh existente en la tabla de tokens revocados<
        _loginRepositoryMock.Setup(l => l.RevokeRefreshSessionTokenAsync(refreshToken, tokenInformation.UserId, tokenInformation.ExpirationDate)).Throws(new InvalidRefreshTokenException());

        //5) Act y exception
        var exception = await Assert.ThrowsAsync<InvalidRefreshTokenException>(async () =>
        {
            await _loginService.LogoutAsync(refreshToken);
        });

        //Assert
        Assert.NotNull(exception);

    }

    #endregion

    #region NEW TOKENS
    [Fact]
    public async Task Service_ShouldReturnTokens_WhenRefreshTokenIsValid()
    {
        //Arrange

        //1) Defino el LogoutData
        string refreshToken = "eyJhJdfg34shjdijswH7HiH7I9JI...";

        //2) Creo el token information
        TokenInformation tokenInformation = new TokenInformation() { ExpirationDate = DateTime.Now, UserId = Guid.NewGuid() };

        //3) Llamo al metodo que valida el token, devuelve el tokenInformation
        _jwtValidatorMock.Setup(v => v.ValidateRefreshTokenAsync(refreshToken)).ReturnsAsync(tokenInformation);

        //4) Llamo al metodo para revocar el token. Si no da error, debería seguir la ejecución. 
        _loginRepositoryMock.Setup(l => l.RevokeRefreshSessionTokenAsync(refreshToken, tokenInformation.UserId, tokenInformation.ExpirationDate));

        //5) Creo el usuario para enviar los tokens
        User user = CreateUser();

        //6) Obtengo el usuario
        _loginRepositoryMock.Setup(u => u.GetUserByUserIdAsync(tokenInformation.UserId)).ReturnsAsync(user);

        //7) Defino el token respnse
        TokenResponse tokenResponse = new TokenResponse() { AccessToken = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9...", RefreshToken = "eyJhJdfg34shjdijswH7HiH7I9JI..." };

        //8) Devuelvo el token response en la consulta
        _jwtTokenGeneratorMock.Setup(t => t.GenerateSessionTokenAsync(user)).ReturnsAsync(tokenResponse);

        //Act
        var result = await _loginService.CreateNewSessionTokenAsync(refreshToken);

        //Assert
        _jwtValidatorMock.Verify(v => v.ValidateRefreshTokenAsync(refreshToken), Times.Once);
        _loginRepositoryMock.Verify(l => l.RevokeRefreshSessionTokenAsync(refreshToken, tokenInformation.UserId, tokenInformation.ExpirationDate), Times.Once);
        Assert.Equal(tokenResponse.AccessToken, result.AccessToken);
        Assert.Equal(tokenResponse.RefreshToken, result.RefreshToken);
    }

    [Fact]
    public async Task Service_ShoudlReturnNotFoundException_WhenUserNotExisits()
    {
        //Arrange

        //1) Proveo un refreshToken invalid.  
        string refreshToken = "eyJhJdfg34shjdijswH7HiH7I9JI...";

        //2) Creo el token information
        TokenInformation tokenInformation = new TokenInformation() { ExpirationDate = DateTime.Now, UserId = Guid.NewGuid() };

        //3) Llamo al metodo para revocar el token. Si no da error, debería seguir la ejecución. 
        _jwtValidatorMock.Setup(v => v.ValidateRefreshTokenAsync(refreshToken)).ReturnsAsync(tokenInformation);

        //4) Llamo al metodo para revocar el token.
        _loginRepositoryMock.Setup(l => l.RevokeRefreshSessionTokenAsync(refreshToken, tokenInformation.UserId, tokenInformation.ExpirationDate));

        //5) Obtengo el Usuario a partir del token, pero el usuario no existe. Da un not found exception
        _loginRepositoryMock.Setup(l => l.GetUserByUserIdAsync(tokenInformation.UserId)).Throws(new NotFoundException());

        //6) Act y exception
        var exception = await Assert.ThrowsAsync<NotFoundException>(async () =>
        {
            await _loginService.CreateNewSessionTokenAsync(refreshToken);
        });

        //Assert
        Assert.NotNull(exception);

    }


    #endregion

    private User CreateUser()
    {

        var person = new Person
        {
            Name = "Cristian",
            LastName = "Fernandez",
            DocumentNumber = "41139558",
            BirthDate = new DateTime(2006, 8, 2, 0, 0, 0, DateTimeKind.Utc),
            GenderId = 1,
            Address = null,
            PhoneNumber = null
        };

        var user = new User
        {

            Email = "cristian.fer.mel@gmail.com",
            Password = "Password_123",
            UserStatusId = 1,
            Person = person,
        };

        return user;
    }

}
