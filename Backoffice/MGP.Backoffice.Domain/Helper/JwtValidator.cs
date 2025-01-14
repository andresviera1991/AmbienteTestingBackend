using MGP.Backoffice.Domain.Interface;
using MGP.Backoffice.Domain.Interfaces;
using MGP.Backoffice.Domain.Models;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Text;

namespace MGP.Backoffice.Domain.Helper
{
    public class JwtValidator : IJwtValidator
    {
        public readonly IJwtSettings _jwtAccessTokenSettings;
        public readonly IJwtSettings _jwtRefreshTokenSettings;

        public JwtValidator(IOptions<JwtAccessTokenSettings> jwtAccessTokenSettings,
            IOptions<JwtRefreshTokenSettings> jwtRefreshTokenSettings)
        {
            _jwtAccessTokenSettings = jwtAccessTokenSettings.Value;
            _jwtRefreshTokenSettings = jwtRefreshTokenSettings.Value;
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
            var agentId = Guid.Parse(principal.Claims.FirstOrDefault(c => c.Type == "AgentId")?.Value);
            var expirationClaim = principal.Claims.FirstOrDefault(c => c.Type == JwtRegisteredClaimNames.Exp)?.Value;
            var expirationDate = DateTimeOffset.FromUnixTimeSeconds(long.Parse(expirationClaim)).UtcDateTime;

            return new TokenInformation
            {
                AgentId = agentId,
                ExpirationDate = expirationDate
            };


        }
    }
}
