using MGP.Authentication.Persistance.Data.Tables;
using MGP.Authentication.Persistance;
using Microsoft.EntityFrameworkCore;
using Xunit;
using MGP.Authentication.CrossCutting.Exceptions;

namespace MGP.Authentication.Test.Repository;

public class PasswordRepositoryTest
{
    private readonly PasswordRepository _passwordRepository;
    private readonly UserRepository _userRepository;

    private readonly MyDbContext _dbContext;

    public PasswordRepositoryTest()
    {
        var options = new DbContextOptionsBuilder<MyDbContext>()
            .UseInMemoryDatabase(databaseName: "TestPasswordDatabase")
            .Options;

        _dbContext = new MyDbContext(options);

        _dbContext.Database.EnsureDeleted();
        _dbContext.Database.EnsureCreated(); 

        _passwordRepository = new PasswordRepository(_dbContext);
        _userRepository = new UserRepository(_dbContext);

        SeedTestData();
    }

    #region RESET PASSWORD 
    [Fact]
    public async Task ResetPasswordAsync_WhenUserExists()
    {
        //Arrange
        string newPassword = "NewPassword";
        Guid userId = Guid.Parse("f5bbe838-3f8a-4ccc-9047-107db02c4a64");

        //Act
        await _passwordRepository.ResetPasswordAsync(userId, newPassword);

        //Assert
        var user = await _userRepository.GetUserByIdAsync(userId);

        Assert.Equal(user.Password, newPassword);

    }

    [Fact]
    public async Task ResetPasswordAsync_ShouldThrowNotFoundException_WhenUserNotExists()
    {
        //Arrange
        string newPassword = "NewPassword";
        Guid userId = Guid.Parse("f5bbe838-3f8a-4ccc-9047-107db02c4a60");

        var exception = await Assert.ThrowsAsync<NotFoundException>(async () =>
        {
            await _passwordRepository.ResetPasswordAsync(userId, newPassword);

        });

        //Assert
        Assert.NotNull(exception);
    }

    #endregion

    #region VERIFY USER
    [Fact]
    public async Task UserExistsAsync_ShouldReturnTrue_WhenUserExists()
    {
        //Arrange
        Guid userId = Guid.Parse("f5bbe838-3f8a-4ccc-9047-107db02c4a64");

        //Act
        var exist = await _passwordRepository.UserExistsAsync(userId);

        //Assert
        Assert.True(exist);

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
            Id = Guid.Parse("f5bbe838-3f8a-4ccc-9047-107db02c4a64"),
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
