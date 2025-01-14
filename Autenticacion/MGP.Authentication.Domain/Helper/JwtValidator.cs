using MGP.Authentication.Domain.Interfaces;
using MGP.Authentication.Domain.Models;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MGP.Authentication.Domain.Helper
{
    public class JwtValidator : IJwtValidator
    {
        public readonly IJwtSettings _jwtEmailTokenSettings;
        public readonly IJwtSettings _jwtAccessTokenSettings;
        public readonly IJwtSettings _jwtRefreshTokenSettings;

        public JwtValidator(IOptions<JwtEmailTokenSettings> jwtEmailTokenSettings, 
            IOptions<JwtAccessTokenSettings> jwtAccessTokenSettings,
            IOptions<JwtRefreshTokenSettings> jwtRefreshTokenSettings)
        {
            _jwtEmailTokenSettings = jwtEmailTokenSettings.Value;
            _jwtAccessTokenSettings = jwtAccessTokenSettings.Value;
            _jwtRefreshTokenSettings = jwtRefreshTokenSettings.Value;   
        }

        public async Task<TokenInformation> ValidateEmailTokenAsync(string token)
        {
            return await ValidateToken(token, _jwtEmailTokenSettings);
        }

        public async Task<TokenInformation> ValidateRefreshTokenAsync(string token)
        {
            return await ValidateToken(token, _jwtRefreshTokenSettings);
        }

        private static async Task<TokenInformation> ValidateToken(string token, IJwtSettings settings)
        {
            var key = Encoding.ASCII.GetBytes(settings.SecretKey);
            var tokenHandler = new JwtSecurityTokenHandler();

            var validationParameters = new TokenValidationParameters
            {
                ValidIssuer = settings.Issuer,
                ValidAudience = settings.Audience,
                ValidateLifetime = true,
                ClockSkew = TimeSpan.Zero,
                IssuerSigningKey = new SymmetricSecurityKey(key)
            };

            var validationResult = await tokenHandler.ValidateTokenAsync(token, validationParameters);

            if (!validationResult.IsValid)
            {
                throw validationResult.Exception;
            }

            var principal = validationResult.ClaimsIdentity;
            Guid userId = Guid.Parse(principal.Claims.FirstOrDefault(c => c.Type == "UserId")?.Value);
            var expirationClaim = principal.Claims.FirstOrDefault(c => c.Type == JwtRegisteredClaimNames.Exp)?.Value;
            var expirationDate = DateTimeOffset.FromUnixTimeSeconds(long.Parse(expirationClaim)).UtcDateTime;

            return new TokenInformation
            {
                UserId = userId,
                ExpirationDate = expirationDate
            };


        }
    }
}
