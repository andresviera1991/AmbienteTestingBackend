using Microsoft.AspNetCore.Identity;
using MGP.Backoffice.Domain.Interfaces;
using MGP.Backoffice.Domain.Models;
using MGP.Backoffice.Persistance.DTOs;
using MGP.Backoffice.Persistence.Data.Tables;
using MGP.Backoffice.Domain.Interface;
using MGP.Backoffice.CrossCutting.Exceptions;
using MGP.Backoffice.Persistance.Interfaces;
using MGP.Backoffice.CrossCutting.Enum;

namespace MGP.Backoffice.Domain
{
    public class LoginService : ILoginService
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly RoleManager<Role> _roleManager;
        private readonly ILoginRepository _loginRepository;
        private readonly IUserRepository _userRepository;
        private readonly IJwtValidator _jwtValidator;
        private readonly IJwtTokenGenerator _jwtTokenGenerator;
        private readonly IUserService _userService;
        private readonly IEmailService _emailService;
        private const int RESETREQUEST = 5;
        private const string DISCAPACIDAD = "DISCAPACIDAD";
        private const string ADMIN = "ADMIN";

        public LoginService(UserManager<User> userManager,
                            SignInManager<User> signInManager,
                            IJwtTokenGenerator jwtTokenGenerator,
                            IUserRepository userRepository,
                            IJwtValidator jwtValidator,
                            ILoginRepository loginRepository,
                            RoleManager<Role> roleManager,
                            IUserService userService,
                            IEmailService emailService)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _jwtTokenGenerator = jwtTokenGenerator;
            _userRepository = userRepository;
            _jwtValidator = jwtValidator;
            _loginRepository = loginRepository;
            _roleManager = roleManager;
            _userService = userService;
            _emailService = emailService;
        }

        public async Task<TokenResponse> CreateNewSessionTokens(string refreshToken)
        {
            TokenInformation tokenInformation = await _jwtValidator.ValidateRefreshTokenAsync(refreshToken);
            await _loginRepository.RevokeRefreshSessionTokenAsync(refreshToken, tokenInformation.AgentId, tokenInformation.ExpirationDate);

            User user = await _userRepository.GetUserAsync(tokenInformation.AgentId);

            return await CreateTokenAsync(user);

        }
        public async Task<TokenResponse> LoginAsync(LoginData userData)
        {
            User user = await _userRepository.GetUserAsync(userData.UserName);

            if (user == null || await _userManager.IsLockedOutAsync(user))
            {
                throw new UserDisabledException();
            }

            if (user.UserStatusId == (int)UserStatusEnum.DELETED)
            {
                throw new UserDeletedException();
            }

            if (user.UserStatusId == (int)UserStatusEnum.INACTIVE)
            {
                throw new UserDisabledException();
            }

            var signInResult = await _signInManager.PasswordSignInAsync(user, userData.Password, false, lockoutOnFailure: true);

            if (!signInResult.Succeeded)
            {
                throw new IncorrectCredentialException();
            }

            return await CreateTokenAsync(user);

        }

        private async Task<TokenResponse> CreateTokenAsync(User user)
        {
            IList<string> listRole = await _userManager.GetRolesAsync(user);
            var role = await _roleManager.FindByNameAsync(listRole.FirstOrDefault());
            return await _jwtTokenGenerator.GenerateSessionTokenAsync(user, role);
        }

        public async Task LogoutAsync(string refreshToken)
        {
            TokenInformation tokenInformation = await _jwtValidator.ValidateRefreshTokenAsync(refreshToken);
            await _loginRepository.RevokeRefreshSessionTokenAsync(refreshToken, tokenInformation.AgentId, tokenInformation.ExpirationDate);
        }

        public async Task ChangePasswordAsync(ChangePasswordData changePasswordData)
        {
            var user = await _userManager.FindByIdAsync(changePasswordData.AgentId.ToString()) ?? throw new NotFoundException();
            var result = await _userManager.ChangePasswordAsync(user, changePasswordData.CurrentPassword, changePasswordData.NewPassword);

            if (!result.Succeeded)
            {
                throw new ChangePasswordException(result.Errors);
            }
        }

        public async Task ResetPasswordAsync(string employeeNumber)
        {
            var user = await _userRepository.GetUserbyEmployeeNumberAsync(employeeNumber) ?? throw new NotFoundException();
            user.UserStatusId = (int)UserStatusEnum.PASSWORD_RESET_REQUESTED;
            var result = await _userManager.UpdateAsync(user);

            if (!result.Succeeded)
            {
                throw new ChangePasswordException(result.Errors);
            }
            await SendEmailResetPasswordAsync(employeeNumber);
        }

        private async Task SendEmailResetPasswordAsync(string employeeNumber)
        {
            var users = await _userService.ListAgentsByFilters(new ListAgentByFiltersData() {Role = ADMIN, PageNumber = 1, PageSize = 1 });
            var bodyEmail = (await _emailService.GetEmailTemplateAsync(EmailTemplateEnum.RESET_PASSWORD)).Replace("{employeeNumber}", employeeNumber);

            foreach (var user in users)
            {
                await _emailService.SendEmailAsync(user.Email, "Solicitud de Reseteo de Contraseña", bodyEmail);
            }
        }
    }
}