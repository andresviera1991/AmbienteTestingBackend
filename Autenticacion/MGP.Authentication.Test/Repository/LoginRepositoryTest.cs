using MGP.Authentication.Persistance.Data.Tables;
using MGP.Authentication.Persistance;
using Microsoft.EntityFrameworkCore;
using Xunit;
using MGP.Authentication.CrossCutting.Exceptions;
namespace MGP.Authentication.Test.Repository;

#pragma warning disable
public class LoginRepositoryTest
{
    private readonly LoginRepository _loginRepository;
    private readonly MyDbContext _dbContext;

    public LoginRepositoryTest()
    {
        var options = new DbContextOptionsBuilder<MyDbContext>()
            .UseInMemoryDatabase(databaseName: "TestLoginDatabase")
            .Options;

        _dbContext = new MyDbContext(options);

        _dbContext.Database.EnsureDeleted();
        _dbContext.Database.EnsureCreated();

        _loginRepository = new LoginRepository(_dbContext);

        SeedTestData();
    }

    #region GET USER BY ID
    [Fact]
    public async Task GetUserByIdAsync_ShouldReturnUser_WhenUserExists()
    {
        // Act
        var user = await _loginRepository.GetUserByUserIdAsync(Guid.Parse("f5bbe838-3f8a-4ccc-9047-107db02c4a78"));

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
            await _loginRepository.GetUserByUserIdAsync(Guid.Parse("f5bbe838-3f8a-4ccc-9047-107db02c4a79"));
        });

        // Assert
        Assert.NotNull(exception);
    }

    #endregion

    #region GET USER BY USER NAME
    [Fact]
    public async Task GetUserByUserNameAsync_ShouldReturnUser_WhenUserExists()
    {
        // Act
        var user = await _loginRepository.GetUserByUserNameAsync("44413552");

        // Assert
        Assert.NotNull(user);
        Assert.Equal("44413552", user.UserName);
    }

    [Fact]
    public async Task ShouldThrowsNotFoundException_WhenUserNameNotExists()
    {
        // Act
        var exception = await Assert.ThrowsAsync<NotFoundException>(async () =>
        {
            await _loginRepository.GetUserByUserNameAsync("44413553");
        });

        // Assert
        Assert.NotNull(exception);
    }

    #endregion

    #region INCREMENT FAILED LOGIN
    [Fact]
    public async Task IncrementFailedLoginAsync_WhenPasswordIsIncorrect()
    {
        // Act
        var user = await _loginRepository.GetUserByUserNameAsync("44413552");

        //Act
        await _loginRepository.IncrementFailedLoginsAsync(user);

        var getUser = await _loginRepository.GetUserByUserNameAsync("44413552");

        Assert.Equal(1, getUser.FailedLoginAttempts);

    }

    [Fact]
    public async Task IncrementFailedLoginAsync_ShouldThrowUserDisabledException_WhenFailedAttemptsAreThree()
    {
        // Act
        var user = await _loginRepository.GetUserByUserNameAsync("44413552");
        user.FailedLoginAttempts = 3;
        //Act
        var exception = await Assert.ThrowsAsync<UserDisabledException>(async () =>
        {
            await _loginRepository.IncrementFailedLoginsAsync(user);
        });

        Assert.NotNull(exception);

    }

    #endregion

    #region RESET FAILED LOGIN
    [Fact]
    public async Task ResetFailedLogin_WhenCredentialsAreCorrect()
    {
        // Assert
        var user = await _loginRepository.GetUserByUserNameAsync("44413552");

        //Act
        await _loginRepository.ResetFailedLoginAsync(user);
        var getUser = await _loginRepository.GetUserByUserNameAsync("44413552");

        //Assert
        Assert.Equal(0, getUser.FailedLoginAttempts);
    }


    #endregion

    #region REVOKED REFRESH TOKEN
    [Fact]
    public async Task RevokedRefreshTokenAsync_WhenRefreshTokenIsValid()
    {
        //Arrange
        string refreshToken = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJJZCI6ImY1YmJlk1MzcxMDIsI...";
        Guid userId = Guid.Parse("f5bbe838-3f8a-4ccc-9047-107db02c4a78");
        DateTime dateOfExpiration = DateTime.UtcNow;

        //Act
        await _loginRepository.RevokeRefreshSessionTokenAsync(refreshToken, userId, dateOfExpiration);

        //Assert
        RevokedRefreshToken revoked = await _dbContext.Set<RevokedRefreshToken>().Where(r => r.UserId == userId).SingleOrDefaultAsync();
        
        Assert.NotNull(revoked);
        Assert.Equal(revoked.RefreshToken, refreshToken);
    }

    [Fact]
    public async Task RevokedRefreshTokenAsync_ShouldThrowsInvalidRefreshTokenException_WhenRefreshTokenIsInvalid()
    {
        //Arrange
        string refreshToken = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJJZCI6ImY1YmJlk1MzcxMDIsI...";
        Guid userId = Guid.Parse("f5bbe838-3f8a-4ccc-9047-107db02c4a78");
        DateTime dateOfExpiration = DateTime.UtcNow;

        //Act
        await _loginRepository.RevokeRefreshSessionTokenAsync(refreshToken, userId, dateOfExpiration);

        var exception = await Assert.ThrowsAsync<InvalidRefreshTokenException>(async () =>
        {
            await _loginRepository.RevokeRefreshSessionTokenAsync(refreshToken, userId, dateOfExpiration);
        });

        //Assert
        Assert.NotNull(exception);


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
}
