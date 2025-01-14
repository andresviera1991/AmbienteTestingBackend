using MGP.Authentication.CrossCutting.Enum;
using MGP.Authentication.CrossCutting.Exceptions;
using MGP.Authentication.Domain.Interfaces;
using MGP.Authentication.Domain.Models;
using MGP.Authentication.Persistance.Data.Enum;
using MGP.Authentication.Persistance.Data.Tables;
using MGP.Authentication.Persistance.DTOs;
using MGP.Authentication.Persistance.Interface;
using System.Threading.Tasks;

namespace MGP.Authentication.Domain.Services
{
    public class LoginService : ILoginService
    {
        private readonly ILoginRepository _loginRepository;
        private readonly IJwtTokenGenerator _jwtTokenGenerator;
        private readonly IEncryptionService _encryptionService;
        private readonly IJwtValidator _jwtValidator;
        private readonly IEmailService _emailService;

        public LoginService(ILoginRepository loginRepository,
                            IJwtTokenGenerator jwtTokenGenerator,
                            IJwtValidator jwtValidator,
                            IEncryptionService encryptionService,
                            IEmailService emailService)
        {
            _loginRepository = loginRepository;
            _jwtTokenGenerator = jwtTokenGenerator;
            _jwtValidator = jwtValidator;
            _encryptionService = encryptionService;
            _emailService = emailService;
        }

        public async Task<TokenResponse> LoginAsync(LoginData userData)
        {
            User user = await _loginRepository.GetUserByUserNameAsync(userData.UserName);

            switch (user.UserStatusId)
            {
                case (int)UserStatusType.USER_INACTIVE:
                    await SendEmailValidor(user);
                    throw new UserNotActivatedException();
                case (int)UserStatusType.USER_DISABLED:
                    throw new UserDisabledException();
                case (int)UserStatusType.USER_DELETED:
                    throw new UserDeletedException();
                default:
                    break;
            }

            if (!_encryptionService.VerifyPassword(user.Password, userData.Password))
            {
                await _loginRepository.IncrementFailedLoginsAsync(user);
                throw new IncorrectCredentialException();
            }

            await _loginRepository.ResetFailedLoginAsync(user);

            return await _jwtTokenGenerator.GenerateSessionTokenAsync(user);
        }

        private async Task SendEmailValidor(User user)
        {
            string token = await _jwtTokenGenerator.GenerateEmailTokenAsync(user.Id);
            var emailBody = (await _emailService.GetEmailTemplateAsync(EmailTemplateType.VALIDATE_USER)).Replace("{token}", token);
            await _emailService.SendEmailAsync(user.Email, "Validacion de usuario", emailBody);
        }

        public async Task LogoutAsync(string refreshToken)
        {
            TokenInformation tokenInformation = await _jwtValidator.ValidateRefreshTokenAsync(refreshToken);
            await _loginRepository.RevokeRefreshSessionTokenAsync(refreshToken, tokenInformation.UserId, tokenInformation.ExpirationDate);
        }

        public async Task<TokenResponse> CreateNewSessionTokenAsync(string refreshToken)
        {
            TokenInformation tokenInformation = await _jwtValidator.ValidateRefreshTokenAsync(refreshToken);
            await _loginRepository.RevokeRefreshSessionTokenAsync(refreshToken, tokenInformation.UserId, tokenInformation.ExpirationDate);
            User user = await _loginRepository.GetUserByUserIdAsync(tokenInformation.UserId);
            return await _jwtTokenGenerator.GenerateSessionTokenAsync(user);
        }
    }
}
