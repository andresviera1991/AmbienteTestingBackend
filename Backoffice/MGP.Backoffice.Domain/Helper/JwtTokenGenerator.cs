using MGP.Backoffice.Domain.Interfaces;
using MGP.Backoffice.Domain.Models;
using MGP.Backoffice.Persistence.Data.Tables;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace MGP.Backoffice.Domain.Helper
{
    public class JwtTokenGenerator : IJwtTokenGenerator
    {
        private readonly IJwtSettings _jwtAccessTokenSettings;
        private readonly IJwtSettings _jwtRefreshTokenSettings;

        public JwtTokenGenerator(IOptions<JwtAccessTokenSettings> jwtAccessTokenSettings,
                                IOptions<JwtRefreshTokenSettings> jwtRefreshTokenSettings)
        {
            _jwtAccessTokenSettings = jwtAccessTokenSettings.Value;
            _jwtRefreshTokenSettings = jwtRefreshTokenSettings.Value;
        }

        public async Task<TokenResponse> GenerateSessionTokenAsync(User user, Role role)
        {
            var accessTokenKey = Encoding.ASCII.GetBytes(_jwtAccessTokenSettings.SecretKey);
            var refreshTokenKey = Encoding.ASCII.GetBytes(_jwtRefreshTokenSettings.SecretKey);

            var claimsAccess = new[]
            {
                new Claim("EmployeeId", user.Id.ToString()),
                new Claim("Name", user.FirstName),
                new Claim("IsEmployee", true.ToString()),
                new Claim("Role", role?.Name ?? string.Empty),
                new Claim("RoleId", role?.Id.ToString() ?? string.Empty),
                new Claim("Area", user.Area?.Name ?? string.Empty),
                new Claim("AreaId", user.Area?.Id.ToString() ?? string.Empty),
                new Claim("Email", user.Email),
            };

            var claimsRefresh = new[]
            {
                new Claim("AgentId", user.Id.ToString()),
                new Claim("IsEmployee", true.ToString()),
            };

            string accessToken = await GenerateToken(claimsAccess, DateTime.UtcNow.AddHours(5), accessTokenKey, _jwtAccessTokenSettings);
            string refreshToken = await GenerateToken(claimsRefresh, DateTime.UtcNow.AddHours(10), refreshTokenKey, _jwtAccessTokenSettings);

            TokenResponse tokens = new()
            {
                AccessToken = accessToken,
                RefreshToken = refreshToken,
            };
            return tokens;
        }



        private static Task<string> GenerateToken(IEnumerable<Claim> claims, DateTime dateTime, byte[] key, IJwtSettings settings)
        {

            var tokenHandler = new JwtSecurityTokenHandler();

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                Expires = dateTime,
                Issuer = settings.Issuer,
                Audience = settings.Audience,
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            return Task.FromResult(tokenHandler.WriteToken(token));
        }
    }
}
