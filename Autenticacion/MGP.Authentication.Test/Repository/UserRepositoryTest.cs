using MGP.Authentication.CrossCutting.Exceptions;
using MGP.Authentication.Persistance;
using MGP.Authentication.Persistance.Data.Enum;
using MGP.Authentication.Persistance.Data.Tables;
using Microsoft.EntityFrameworkCore;
using Xunit;

namespace MGP.Authentication.Test.Repository;

#pragma warning disable
public class UserRepositoryTest
{
    private readonly UserRepository _userRepository;
    private readonly MyDbContext _dbContext;

    public UserRepositoryTest()
    {
        var options = new DbContextOptionsBuilder<MyDbContext>()
            .UseInMemoryDatabase(databaseName: "TestUserDatabase")
            .Options;

        _dbContext = new MyDbContext(options);
        _userRepository = new UserRepository(_dbContext);

        _dbContext.Database.EnsureDeleted();
        SeedTestData();
    }

    #region CREATE USER
    [Fact]
    public async Task CreateUser_ShouldReturnUserId_WhenUserIsCorrect()
    {
        //Arrange
        var user = CreateUserToCreate();

        //Act
        var userRegistered = await _userRepository.RegisterAsync(user);

        //Assert
        var getUser = _userRepository.GetUserByIdAsync(userRegistered.Id);
        Assert.NotNull(getUser);
    }

    [Fact]
    public async Task CreateUser_ShouldThrowDbUpdateException_WhenUserAlreadyExist()
    {
        //Arrange
        var user = CreateUserToCreate();
        user.UserName = "44413552";

        var exception = await Assert.ThrowsAsync<InvalidOperationException>(async () =>
        {
            await _userRepository.RegisterAsync(user); 
            await _userRepository.RegisterAsync(user); //UserName repeat
        });
        //Assert
        Assert.NotNull(exception);
    }

    #endregion

    #region GET USER BY ID
    [Fact]
    public async Task GetUserByIdAsync_ShouldReturnUser_WhenUserExists()
    {
        // Act
        var user = await _userRepository.GetUserByIdAsync(Guid.Parse("f5bbe838-3f8a-4ccc-9047-107db02c4a78"));

        // Assert
        Assert.NotNull(user);
        Assert.Equal("44413552", user.UserName);
    }

    [Fact]
    public async Task ShouldThrowsNotFoundException_WhenUserIdNotExists()
    {
        // Act
        var exception = await Assert.ThrowsAsync<NotFoundException>(async () =>
        {
            await _userRepository.GetUserByIdAsync(Guid.Parse("f5bbe838-3f8a-4ccc-9047-107db02c4a80"));
        });

        // Assert
        Assert.NotNull(exception);
    }

    #endregion

    #region VALIDATE USER
    [Fact]
    public async Task ValidateUserAsync_WhenUserUserStatusChange()
    {
        //Arrange
        var userToCreate = CreateUserToCreate(); //Inicia Inactive
        var userRegistered = await _userRepository.RegisterAsync(userToCreate);

        //Act
        await _userRepository.ValidateUserAsync(userRegistered.Id);

        //Assert
        var user = await _userRepository.GetUserByIdAsync(userRegistered.Id);
        Assert.Equal((int)UserStatusType.USER_ACTIVE, user.UserStatusId);
    }

    #endregion

    private void SeedTestData()
    {
        var address = new Address()
        {
            CreationDate = DateTime.Now,
            Street = "Salta",
            StreetNumber = "2020",
            LocalityId = 6,
        };

        var phoneNumber = new PhoneNumber()
        {
            CreationDate = DateTime.Now,
            Number = "1155223636",
        };

        var person = new Person
        {
            Name = "Cristian",
            LastName = "Fernandez",
            DocumentNumber = "44413552",
            BirthDate = new DateTime(2006, 8, 2, 0, 0, 0, DateTimeKind.Utc),
            GenderId = 1,
            PhoneNumber = phoneNumber,
            Address = address
        };

        var user = new User
        {
            Id = Guid.Parse("f5bbe838-3f8a-4ccc-9047-107db02c4a78"),
            UserName = "44413552",
            Email = "cristian.fer.mel@gmail.com",
            Password = "Password_123",
            UserStatusId = 1,
            Person = person,
            LevelId = 1,

        };

        _dbContext.Set<User>().Add(user);
        _dbContext.SaveChanges();
    }

    private User CreateUserToUpdate()
    {
        var address = new Address()
        {
            CreationDate = DateTime.Now,
            Street = "Salta",
            StreetNumber = "500", // Modifico numero de calle
            LocalityId = 6,
        };

        var person = new Person
        {
            Name = "Cristian",
            LastName = "Melian", // Modifico apellido
            DocumentNumber = "41139558",
            BirthDate = new DateTime(2006, 8, 2, 0, 0, 0, DateTimeKind.Utc),
            GenderId = 1,
            PhoneNumber = null,
            Address = address
        };

        var user = new User
        {
            Id = Guid.Parse("f5bbe838-3f8a-4ccc-9047-107db02c4a78"),
            UserName = "44413552",
            Email = "cristian.fer.mel@gmail.com",
            Password = "Password_123",
            UserStatusId = 1,
            Person = person,
            LevelId = 1,
        };

        return user;
    }

    private User CreateUserToCreate()
    {
        var address = new Address()
        {
            Street = "Salta",
            StreetNumber = "500", // Modifico numero de calle
            LocalityId = 6,
        };

        var phoneNumber = new PhoneNumber()
        {
            Number = "44885965",
        };

        var person = new Person
        {
            Name = "Cristian",
            LastName = "Melian",
            DocumentNumber = "41139455",
            BirthDate = new DateTime(2006, 8, 2, 0, 0, 0, DateTimeKind.Utc),
            GenderId = 1,
            PhoneNumber = phoneNumber,
            Address = address
        };

        var user = new User
        {
            UserName = "41139455",
            Email = "cristian.fer.mel@gmail.com",
            Password = "Password_123",
            Person = person,
        };

        return user;
    }

}
