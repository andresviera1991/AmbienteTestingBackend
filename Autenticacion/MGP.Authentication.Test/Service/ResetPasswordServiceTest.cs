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

public class ResetPasswordServiceTest
{
    private readonly Mock<IPasswordRepository> _resetPasswordRepositoryMock;
    private readonly Mock<IUserRepository> _userRepository;
    private readonly Mock<IJwtValidator> _jwtValidatorMock;
    private readonly Mock<IEncryptionService> _encryptionServiceMock;
    private readonly PasswordService _resetPasswordService;
    private readonly Mock<IAuditService> _auditServiceMock;
    private readonly Mock<IEmailService> _emailServiceMock;
    private readonly Mock<IJwtTokenGenerator> _jwtTokenGeneratorMock;


    public ResetPasswordServiceTest()
    {
        _resetPasswordRepositoryMock = new Mock<IPasswordRepository>();

        _emailServiceMock = new Mock<IEmailService>();
        _jwtValidatorMock = new Mock<IJwtValidator>();
        _encryptionServiceMock = new Mock<IEncryptionService>();
        _userRepository = new Mock<IUserRepository>();
        _auditServiceMock = new Mock<IAuditService>();
        _jwtTokenGeneratorMock = new Mock<IJwtTokenGenerator>();

        _resetPasswordService = new PasswordService(_jwtValidatorMock.Object, _resetPasswordRepositoryMock.Object, _encryptionServiceMock.Object, _userRepository.Object, _auditServiceMock.Object, _emailServiceMock.Object, _jwtTokenGeneratorMock.Object);
    }

    #region Change Password
    [Fact]
    public async Task Service_ShouldChangePassword_WhenTokenIsValid()
    {
        //Arrange
        //1) Creo el token y el password
        ChangePasswordData data = new ChangePasswordData()
        {
            UserId = Guid.NewGuid(),
            CurrentPassword = "password_123",
            NewPassword = "newPassword"
        };

        //2) Creo un usuario
        var user = CreateUser();

        //3) Llamo al usuario
        _userRepository.Setup(v => v.GetUserByIdAsync(data.UserId)).ReturnsAsync(user);

        //4) Verifico password
        _encryptionServiceMock.Setup(e => e.VerifyPassword(user.Password, data.CurrentPassword)).Returns(true);
        _encryptionServiceMock.Setup(e => e.VerifyPassword(user.Password, data.NewPassword)).Returns(false);

        //5) Defino el hash password
        string hashPassword = "#$%&/UYHGR$%&YTGDSEYUIUT&/I%$YRE";

        //6) Creo el hash
        _encryptionServiceMock.Setup(e => e.HashPassword(data.NewPassword)).Returns(hashPassword);

        //7) Guardo la pass nueva
        _resetPasswordRepositoryMock.Setup(r => r.SaveChangePasswordAsync());

        //Act
        await _resetPasswordService.ChangePasswordAsync(data);

        //Assert
        Assert.Equal(hashPassword, user.Password);
        _resetPasswordRepositoryMock.Verify(r => r.SaveChangePasswordAsync(), Times.Once);
    }

    [Fact]
    public async Task Service_ShouldThrowIncorrectCredentialException_WhenCredentialsAreInvalid()
    {
        //Arrange
        //1) Creo el token y el password
        ChangePasswordData data = new ChangePasswordData()
        {
            UserId = Guid.NewGuid(),
            CurrentPassword = "password_123",
            NewPassword = "newPassword"
        };

        //2) Creo un usuario
        var user = CreateUser();

        //3) Llamo al usuario
        _userRepository.Setup(v => v.GetUserByIdAsync(data.UserId)).ReturnsAsync(user);

        //4) Verifico password
        _encryptionServiceMock.Setup(e => e.VerifyPassword(user.Password, data.CurrentPassword)).Throws(new IncorrectCredentialException());

        //3) Act y exception
        var exception = await Assert.ThrowsAsync<IncorrectCredentialException>(async () =>
        {
            await _resetPasswordService.ChangePasswordAsync(data);
        });

        //Assert
        Assert.NotNull(exception);

    }

    [Fact]
    public async Task Service_ShouldThrowSamePasswordException_WhenPasswordIsTheSame()
    {
        //Arrange
        //1) Creo el token y el password
        ChangePasswordData data = new ChangePasswordData()
        {
            UserId = Guid.NewGuid(),
            CurrentPassword = "password_123",
            NewPassword = "newPassword"
        };

        //2) Creo un usuario
        var user = CreateUser();

        //3) Llamo al usuario
        _userRepository.Setup(v => v.GetUserByIdAsync(data.UserId)).ReturnsAsync(user);

        //4) Verifico password
        _encryptionServiceMock.Setup(e => e.VerifyPassword(user.Password, data.CurrentPassword)).Returns(true);
        _encryptionServiceMock.Setup(e => e.VerifyPassword(user.Password, data.NewPassword)).Throws(new SamePasswordException());

        //3) Act y exception
        var exception = await Assert.ThrowsAsync<SamePasswordException>(async () =>
        {
            await _resetPasswordService.ChangePasswordAsync(data);
        });

        //Assert
        Assert.NotNull(exception);

    }

    #endregion

    #region Reset Password
    [Fact]
    public async Task Service_ShouldResetPassword_WhenTokenIsValid()
    {
        //Arrange
        //1) Creo el token y el password
        string token = "eyJhJdfg34shjdijswH7HiH7I9JI...";
        string password = "NewPassword";

        //2) Defino el token information
        TokenInformation tokenInformation = new TokenInformation() { ExpirationDate = DateTime.Now, UserId = Guid.Parse("c419729e-2e4e-43e2-94fe-147e46a73fcf") };

        //3) LLamo a user
        _userRepository.Setup(u => u.GetUserByIdAsync(tokenInformation.UserId)).ReturnsAsync(CreateUser());

        //4) Llamo al metodo que valida el token y devuelve un UserId. 
        _jwtValidatorMock.Setup(v => v.ValidateEmailTokenAsync(token)).ReturnsAsync(tokenInformation);

        //5) defino un password hasheado para envíar al metodod:
        string hashPassword = "$2a$11$X09Jv5SBw4dgF6/UUNBYO.gG6Gsa/.qWbBolBfEydHF2tvkvtuQ0O";

        //6) llamo al metodo y devuelvo el password codificado
        _encryptionServiceMock.Setup(e => e.HashPassword(password)).Returns(hashPassword);

        //7) llamo al metodo de repositorio de reset password
        _resetPasswordRepositoryMock.Setup(r => r.ResetPasswordAsync(tokenInformation.UserId, hashPassword));


        //Act
        await _resetPasswordService.ResetPasswordAsync(token, password);

        //Assert
        _jwtValidatorMock.Verify(v => v.ValidateEmailTokenAsync(token), Times.Once);
        _encryptionServiceMock.Verify(l => l.HashPassword(password), Times.Once);
    }

    [Fact]
    public async Task Service_ShouldThrowSamePasswordException_WhenNewPasswordIsInvalid()
    {
        //Arrange
        //1) Creo el token y el password
        string token = "eyJhJdfg34shjdijswH7HiH7I9JI...";
        string newPassword = "Password_123";

        //2) Defino el token information
        TokenInformation tokenInformation = new TokenInformation() { ExpirationDate = DateTime.Now, UserId = Guid.Parse("c419729e-2e4e-43e2-94fe-147e46a73fcf") };

        //3) Devuelvo el token information
        _jwtValidatorMock.Setup(j => j.ValidateEmailTokenAsync(token)).ReturnsAsync(tokenInformation);

        //4) Defino el user
        User user = CreateUser();

        //5) LLamo a user
        _userRepository.Setup(u => u.GetUserByIdAsync(tokenInformation.UserId)).ReturnsAsync(user);

        //6) valido las password
        _encryptionServiceMock.Setup(e => e.VerifyPassword(user.Password, newPassword)).Returns(true);

        //7) Act y exception
        var exception = await Assert.ThrowsAsync<SamePasswordException>(async () =>
        {
            await _resetPasswordService.ResetPasswordAsync(token, newPassword);
        });

        //Assert
        Assert.NotNull(exception);
    }
    [Fact]
    public async Task Service_ShouldThrowInvalidToken_WhenTokenIsInvalid()
    {
        //Arrange
        //1) Creo el token y el password
        string token = "eyJhJdfg34shjdijswH7HiH7I9JI...";
        string password = "NewPassword";

        //2) Lanzo la exception
        _jwtValidatorMock.Setup(v => v.ValidateEmailTokenAsync(token)).Throws(new SecurityTokenExpiredException());

        //3) Act y exception
        var exception = await Assert.ThrowsAsync<SecurityTokenExpiredException>(async () =>
        {
            await _resetPasswordService.ResetPasswordAsync(token, password);
        });

        //Assert
        Assert.NotNull(exception);

    }

    [Fact]
    public async Task Service_ShouldThrowNotFoundException_WhenTokenUerNotExist()
    {
        //Arrange
        //1) Creo el token y el password
        string token = "eyJhJdfg34shjdijswH7HiH7I9JI...";
        string password = "NewPassword";

        //2) Defino el token information
        TokenInformation tokenInformation = new TokenInformation() { ExpirationDate = DateTime.Now, UserId = Guid.Parse("c419729e-2e4e-43e2-94fe-147e46a73fcf") };

        //3) LLamo a user
        _userRepository.Setup(u => u.GetUserByIdAsync(tokenInformation.UserId)).ReturnsAsync(CreateUser());

        //4) Llamo al metodo que valida el token y devuelve un UserId. 
        _jwtValidatorMock.Setup(v => v.ValidateEmailTokenAsync(token)).ReturnsAsync(tokenInformation);

        //5) defino un password hasheado para envíar al metodod:
        string hashPassword = "$2a$11$X09Jv5SBw4dgF6/UUNBYO.gG6Gsa/.qWbBolBfEydHF2tvkvtuQ0O";

        //6) llamo al metodo y devuelvo el password codificado
        _encryptionServiceMock.Setup(e => e.HashPassword(password)).Returns(hashPassword);

        //7) Llamo al metodo que guarda el password
        _resetPasswordRepositoryMock.Setup(r => r.ResetPasswordAsync(tokenInformation.UserId, hashPassword)).Throws(new NotFoundException());

        //8) Act y exception
        var exception = await Assert.ThrowsAsync<NotFoundException>(async () =>
        {
            await _resetPasswordService.ResetPasswordAsync(token, password);
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
