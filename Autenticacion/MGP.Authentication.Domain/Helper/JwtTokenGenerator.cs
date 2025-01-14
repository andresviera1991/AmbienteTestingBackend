using MGP.Authentication.Domain.Interfaces;
using MGP.Authentication.Domain.Models;
using MGP.Authentication.Persistance.Data.Tables;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace MGP.Authentication.Domain.Helper
{
    public class JwtTokenGenerator : IJwtTokenGenerator
    {
        private readonly IJwtSettings _jwtAccessTokenSettings;
        private readonly IJwtSettings _jwtEmailTokenSettings;
        private readonly IJwtSettings _jwtRefreshTokenSettings;
        public JwtTokenGenerator(IOptions<JwtAccessTokenSettings> jwtAccessTokenSettings,
                                IOptions<JwtRefreshTokenSettings> jwtRefreshTokenSettings,
                                IOptions<JwtEmailTokenSettings> jwtEmailTokenSettings)
        {
            _jwtAccessTokenSettings = jwtAccessTokenSettings.Value;
            _jwtRefreshTokenSettings = jwtRefreshTokenSettings.Value;
            _jwtEmailTokenSettings = jwtEmailTokenSettings.Value;
        }

        public async Task<TokenResponse> GenerateSessionTokenAsync(User user)
        {
            var accessTokenKey = Encoding.ASCII.GetBytes(_jwtAccessTokenSettings.SecretKey);
            var refreshTokenKey = Encoding.ASCII.GetBytes(_jwtRefreshTokenSettings.SecretKey);

            var claims = new[]
            {
                 new Claim("UserId", user.Id.ToString()),
                 new Claim("IsNeighbor", true.ToString()),
                 new Claim("Email", user.Email.ToString()),
            };

            string accessToken = await GenerateToken(claims, DateTime.UtcNow.AddHours(5), accessTokenKey, _jwtAccessTokenSettings);
            string refreshToken = await GenerateToken(claims, DateTime.UtcNow.AddHours(10), refreshTokenKey, _jwtAccessTokenSettings);

            TokenResponse tokens = new()
            {
                AccessToken = accessToken,
                RefreshToken = refreshToken,
                UserId = user.Id
            };

            return tokens;
        }

        public async Task<string> GenerateEmailTokenAsync(Guid userId)
        {
            var key = Encoding.ASCII.GetBytes(_jwtEmailTokenSettings.SecretKey);

            var claimsEmailToken = new[]
            {
                 new Claim("UserId", userId.ToString()),
            };

            return await GenerateToken(claimsEmailToken, DateTime.UtcNow.AddYears(5), key, _jwtEmailTokenSettings);
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
