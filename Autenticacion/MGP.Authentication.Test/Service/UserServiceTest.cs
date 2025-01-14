using AutoMapper;
using Confluent.Kafka;
using MGP.Authentication.CrossCutting.Exceptions;
using MGP.Authentication.Domain.Interfaces;
using MGP.Authentication.Domain.Models;
using MGP.Authentication.Domain.Services;
using MGP.Authentication.Persistance.Data.Tables;
using MGP.Authentication.Persistance.DTOs;
using MGP.Authentication.Persistance.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using Moq;
using Xunit;

namespace MGP.Authentication.Test.Service;

#pragma warning disable
public class UserServiceTest
{
    private readonly Mock<ILogger<UserService>> _loggerMock;
    private readonly Mock<ILogger<ParentService>> _loggerParentMock;
    private readonly Mock<IUserRepository> _userRepositoryMock;
    private readonly Mock<IParentRepository> _parentRepositoryMock;
    private readonly IParentService _parentServiceMock;
    private readonly Mock<IJwtValidator> _jwtValidatorMock;
    private readonly Mock<IEncryptionService> _encryptionServiceMock;
    private readonly Mock<IMapper> _mapperMock;
    private readonly Mock<IProducer<Null, string>> _producerMock;
    private readonly Mock<IJwtTokenGenerator> _jwtTokenGeneratorMock;
    private readonly Mock<IEmailService> _emailService;
    private readonly IAuditService _auditService;
    private readonly IParentService _parentService;
    private readonly UserService _userService;

    public UserServiceTest()
    {
        _loggerMock = new Mock<ILogger<UserService>>();
        _loggerParentMock = new Mock<ILogger<ParentService>>();
        _userRepositoryMock = new Mock<IUserRepository>();
        _parentRepositoryMock = new Mock<IParentRepository>();
        _emailService = new Mock<IEmailService>();
        _jwtTokenGeneratorMock = new Mock<IJwtTokenGenerator>();
        _mapperMock = new Mock<IMapper>();
        _jwtValidatorMock = new Mock<IJwtValidator>();
        _producerMock = new Mock<IProducer<Null, string>>();
        _auditService = new AuditService(_producerMock.Object);
        _parentService = new ParentService(_loggerParentMock.Object, _parentRepositoryMock.Object, _mapperMock.Object, _auditService);

        _encryptionServiceMock = new Mock<IEncryptionService>();

        _userService = new UserService(_loggerMock.Object,
                                       _userRepositoryMock.Object,
                                       _parentService,
                                       _mapperMock.Object,
                                       _jwtValidatorMock.Object,
                                       _encryptionServiceMock.Object,
                                       _auditService,
                                       _emailService.Object,
                                       _jwtTokenGeneratorMock.Object);
    }

    #region GET USER BY USER NAME
    [Fact]
    public async Task Service_ShouldReturnUserData_WhenUserIsFound()
    {
        //Arrange

        //1) Defino el LoginData
        string userName = "44413552";

        //2) Defino la respuesta del GetUserByUserName
        User user = CreateUser();

        //3) Llamo al metodo que devuela el usuario
        _userRepositoryMock.Setup(l => l.GetUserByUserNameAsync(userName)).ReturnsAsync(user);
        //4) Creo el user data
        UserData userData = CreateUserData();

        //4) Mapeo a UserData
        _mapperMock.Setup(m => m.Map<UserData>(user)).Returns(userData);

        //Act
        var result = await _userService.GetUserByUserNameAsync(userName);

        //Assert
        Assert.Equal(result.Email, userData.Email);
        Assert.IsType<UserData>(result);
    }

    [Fact]
    public async Task Service_ShouldNotFoundException_WhenUserNotFound()
    {
        //Arrange

        //1) Defino el LoginData
        string userName = "44413552";

        //2) Llamo al metodo que devuela el usuario y devuelve user not found
        _userRepositoryMock.Setup(l => l.GetUserByUserNameAsync(userName)).Throws(new NotFoundException());
        //3) Act y exception
        var exception = await Assert.ThrowsAsync<NotFoundException>(async () =>
        {
            await _userService.GetUserByUserNameAsync(userName);
        });

        //Assert
        Assert.NotNull(exception);
    }

    #endregion

    #region GET USER BY ID
    [Fact]
    public async Task Service_ShouldReturnUserData_WhenUserIsFound_GetByIdAsync()
    {
        //Arrange

        //1) Defino Id
        Guid userId = Guid.NewGuid();

        //2) Defino la respuesta del GetUserByUserName
        User user = CreateUser();

        //3) Llamo al metodo que devuela el usuario
        _userRepositoryMock.Setup(l => l.GetUserByIdAsync(userId)).Returns(Task.FromResult(user));

        //4) Creo el user data
        UserData userData = CreateUserData();

        //4) Mapeo a UserData
        _mapperMock.Setup(m => m.Map<UserData>(user)).Returns(userData);

        //Act
        var result = await _userService.GetUserByIdAsync(userId);

        //Assert
        Assert.Equal(result, userData);
        Assert.IsType<UserData>(result);
    }

    [Fact]
    public void Service_ShouldNotFoundException_WhenUserNotFound_GetById()
    {
        //Arrange

        //1) Defino Id
        Guid userId = Guid.NewGuid();

        //2) Llamo al metodo que devuela el usuario y devuelve user not found
        _userRepositoryMock.Setup(l => l.GetUserByIdAsync(userId)).Throws(new NotFoundException());

        //3) Act y exception
        var exception = Assert.ThrowsAsync<NotFoundException>(async () =>
        {
            await _userService.GetUserByIdAsync(userId);
        });

        //Assert
        Assert.NotNull(exception);
    }

    #endregion

    #region REGISTER
    [Fact]
    public async Task Service_ShouldReturnUserId_WhenRegisterIsSuccesfuly()
    {
        //1) Defino el USERDATA
        UserData userData = CreateUserData();

        //2) Defino la contraseña hasheada
        string password = "$2a$11$ghSYIkJXGYZ9b7EsvBaD9.TBRXYE8pGnzophd4O.iq9jkt1L2Mm6S";

        //3) Realizar la encriptacion
        _encryptionServiceMock.Setup(e => e.HashPassword(userData.Password)).Returns(password);

        //4) Creo el usuario para el mapeo
        User user = CreateUser();

        //5) Mapeo a User desde UserData
        _mapperMock.Setup(p => p.Map<User>(userData)).Returns(user);

        //6) Defino la respuesta, userId
        Guid userId = Guid.NewGuid();

        //7) LLamo al metodo register y devuelvo el ID
        _userRepositoryMock.Setup(u => u.RegisterAsync(user, false)).ReturnsAsync(new User() { Id = userId });

        //Act 
        var result = await _userService.RegisterAsync(userData);

        //Assert
        Assert.Equal(result, userId);
    }

    [Fact]
    public async Task Service_ShouldReturnDbUpdateException_WhenUserAlreadyExist()
    {
        //1) Defino el USERDATA
        UserData userData = CreateUserData();

        //2) Defino la contraseña hasheada
        string password = "$2a$11$ghSYIkJXGYZ9b7EsvBaD9.TBRXYE8pGnzophd4O.iq9jkt1L2Mm6S";

        //3) Realizar la encriptacion
        _encryptionServiceMock.Setup(e => e.HashPassword(userData.Password)).Returns(password);

        //4) Creo el usuario para el mapeo
        User user = CreateUser();

        //5) Mapeo a User desde UserData
        _mapperMock.Setup(p => p.Map<User>(userData)).Returns(user);

        //7) LLamo al metodo register y devuelvo el ID
        _userRepositoryMock.Setup(u => u.RegisterAsync(user, false)).Throws(new DbUpdateException());

        //8) Act y exception
        var exception = await Assert.ThrowsAsync<DbUpdateException>(async () =>
        {
            await _userService.RegisterAsync(userData);
        });

        //Assert
        Assert.NotNull(exception);
    }

    #endregion

    #region VALIDATE USER
    [Fact]
    public async Task Service_ShouldValidateUser_WhenTokenIsValid()
    {
        //1) Proveo el token
        string token = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJJZ...";

        //2) Defino el Token Information
        TokenInformation tokenInformation = new TokenInformation() { ExpirationDate = DateTime.Now, UserId = Guid.Parse("560a2131-9295-4e28-aa66-1fc59a8c5d36") };

        //3) Valida el token y devuelve la info
        _jwtValidatorMock.Setup(v => v.ValidateEmailTokenAsync(token)).ReturnsAsync(tokenInformation);

        //4) Valida el usuario y no arroja ninguna exception
        _userRepositoryMock.Setup(u => u.ValidateUserAsync(tokenInformation.UserId));

        //Act
        await _userService.ValidateUserAsync(token);

        //Assert
        _jwtValidatorMock.Verify(v => v.ValidateEmailTokenAsync(token), Times.Once);
        _userRepositoryMock.Verify(l => l.ValidateUserAsync(tokenInformation.UserId), Times.Once);

    }

    [Fact]
    public async Task Service_ShouldReturnInvalidTokenException_WhenTokenIsInvalid()
    {
        //Arrange

        //1) Proveo el token
        string token = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJJZ...";

        //3) Valida el token y da exception
        _jwtValidatorMock.Setup(v => v.ValidateEmailTokenAsync(token)).Throws(new SecurityTokenExpiredException());

        //3) Act y exception
        var exception = await Assert.ThrowsAsync<SecurityTokenExpiredException>(async () =>
        {
            await _userService.ValidateUserAsync(token);
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
    private UserData CreateUserData()
    {

        var person = new PersonData
        {
            Name = "Cristian",
            LastName = "Fernandez",
            DocumentNumber = "41139558",
            BirthDate = new DateTime(2006, 8, 2, 0, 0, 0, DateTimeKind.Utc),
            GenderId = 1,
            Address = null,
            PhoneNumber = null
        };

        var user = new UserData
        {

            Email = "cristian.fer.mel@gmail.com",
            Password = "Password_123",

            Person = person,
        };

        return user;
    }

}