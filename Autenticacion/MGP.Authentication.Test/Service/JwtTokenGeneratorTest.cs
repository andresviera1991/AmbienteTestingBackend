using MGP.Authentication.Domain.Helper;
using MGP.Authentication.Persistance.Data.Tables;
using Microsoft.Extensions.Options;
using Moq;
using Xunit;
namespace MGP.Authentication.Test.Service;
#pragma warning disable
public class JwtTokenGeneratorTest
{

    public class JwtTokenGeneratorTests
    {
        private readonly Mock<IOptions<JwtAccessTokenSettings>> _mockJwtAccessTokenSettings;
        private readonly Mock<IOptions<JwtRefreshTokenSettings>> _mockJwtRefreshTokenSettings;
        private readonly Mock<IOptions<JwtEmailTokenSettings>> _mockJwtEmailTokenSettings;

        private readonly JwtTokenGenerator _jwtTokenGenerator;

        public JwtTokenGeneratorTests()
        {
            _mockJwtAccessTokenSettings = new Mock<IOptions<JwtAccessTokenSettings>>();
            _mockJwtRefreshTokenSettings = new Mock<IOptions<JwtRefreshTokenSettings>>();
            _mockJwtEmailTokenSettings = new Mock<IOptions<JwtEmailTokenSettings>>();

            _mockJwtAccessTokenSettings.Setup(x => x.Value).Returns(new JwtAccessTokenSettings
            {
                SecretKey = "access-3e4f476dd2d55545fee39c2e646aeeba8a5b9ec99f56eb087a994ca6b67c8ff9-key",
            });

            _mockJwtRefreshTokenSettings.Setup(x => x.Value).Returns(new JwtRefreshTokenSettings
            {
                SecretKey = "3e4f476dd2d55545fee39c2e646aeeba8a5b9ec99f56eb087a994ca6b67c8ff9-secret-key",
            });

            _mockJwtEmailTokenSettings.Setup(x => x.Value).Returns(new JwtEmailTokenSettings
            {
                SecretKey = "email-secret-key-3e4f476dd2d55545fee39c2e646aeeba8a5b9ec99f56eb087a994ca6b67c8ff9",
            });

            _jwtTokenGenerator = new JwtTokenGenerator(
                _mockJwtAccessTokenSettings.Object,
                _mockJwtRefreshTokenSettings.Object,
                _mockJwtEmailTokenSettings.Object
            );
        }

        [Fact]
        public async Task Handle_ShouldReturnSessionTokens_WhenUserIsCorrect()
        {
            //Arrange

            //1) Defino el User
            var user = CreateUser();

            //2) Genero los token
            var result = await _jwtTokenGenerator.GenerateSessionTokenAsync(user);

            Assert.NotNull(result);

        }

        [Fact]
        public async Task Handle_ShouldEmailToken_WhenUserIdIsProvider()
        {
            //Arrange

            //1) Defino el User
            var userId = Guid.Parse("d0ae6982-5885-4054-b6c1-a33f1a0d996a");

            //2) Genero los token
            var result = await _jwtTokenGenerator.GenerateEmailTokenAsync(userId);

            Assert.NotNull(result);

        }

        private User CreateUser()
        {

            var registerRequest = new User
            {
                Email = "cristian.fer.mel@gmail.com",
                Password = "Password_123",
                Person = null,
            };

            return registerRequest;
        }

    }
}
