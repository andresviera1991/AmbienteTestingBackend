using MGP.Authentication.Domain.Helper;
using Xunit;
namespace MGP.Authentication.Test.Service;

public class EncryptionServiceTest
{
    private readonly EncryptionService _encryptionService;

    public EncryptionServiceTest()
    {
        _encryptionService = new EncryptionService();
    }

    [Fact]
    public void Handle_ShouldHashPassword_WhenPasswordIsProvided()
    {
        // Arrange
        string password = "password";
        string hashedPassword = _encryptionService.HashPassword(password);

        // Act
        var isMatch = _encryptionService.VerifyPassword(hashedPassword, password);

        // Assert
        Assert.True(isMatch, "The password should match the hashed password.");
    }
}
