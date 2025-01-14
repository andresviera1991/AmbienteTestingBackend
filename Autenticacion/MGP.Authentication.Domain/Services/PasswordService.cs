using MGP.Authentication.CrossCutting.Enum;
using MGP.Authentication.CrossCutting.Exceptions;
using MGP.Authentication.Domain.Interfaces;
using MGP.Authentication.Domain.Models;
using MGP.Authentication.Persistance.DTOs;
using MGP.Authentication.Persistance.Interface;
using System;
using System.Text.Json;
using System.Threading.Tasks;
namespace MGP.Authentication.Domain.Services;

public class PasswordService : IPasswordService
{
    private readonly IPasswordRepository _passwordRepository;
    private readonly IUserRepository _userRepository;
    private readonly IEmailService _emailService;
    private readonly IAuditService _auditService;
    private readonly IJwtValidator _jwtValidator;
    private readonly IEncryptionService _encryptionService;
    private readonly IJwtTokenGenerator _jwtTokenGenerator;

    public PasswordService(IJwtValidator jwtTokenValidator,
                           IPasswordRepository resetPasswordRepository,
                           IEncryptionService encryptionService,
                           IUserRepository userRepository,
                           IAuditService auditService,
                           IEmailService emailService,
                           IJwtTokenGenerator jwtTokenGenerator)
    {
        _jwtValidator = jwtTokenValidator;
        _passwordRepository = resetPasswordRepository;
        _encryptionService = encryptionService;
        _userRepository = userRepository;
        _auditService = auditService;
        _emailService = emailService;
        _jwtTokenGenerator = jwtTokenGenerator;
    }

    public async Task ChangePasswordAsync(ChangePasswordData request)
    {
        var user = await _userRepository.GetUserByIdAsync(request.UserId);

        if (!_encryptionService.VerifyPassword(user.Password, request.CurrentPassword))
        {
            throw new IncorrectCredentialException();
        }

        if (_encryptionService.VerifyPassword(user.Password, request.NewPassword))
        {
            throw new SamePasswordException();
        }

        var newPasswordHashed = _encryptionService.HashPassword(request.NewPassword);

        user.Password = newPasswordHashed;
        await _passwordRepository.SaveChangePasswordAsync();

        await _auditService.SendAudit(new AuditData(
            request.UserId,
            "PATCH",
            "User",
            request.UserId.ToString(),
            JsonSerializer.Serialize(new { Password = request.CurrentPassword }),
            JsonSerializer.Serialize(new { Password = request.NewPassword })
        ));

    }

    public async Task ResetPasswordAsync(string token, string newPassword)
    {
        TokenInformation tokenInformation = await _jwtValidator.ValidateEmailTokenAsync(token);

        var user = await _userRepository.GetUserByIdAsync(tokenInformation.UserId);

        if (_encryptionService.VerifyPassword(user.Password, newPassword))
        {
            throw new SamePasswordException();
        }

        newPassword = _encryptionService.HashPassword(newPassword);
        await _passwordRepository.ResetPasswordAsync(tokenInformation.UserId, newPassword);

        await _auditService.SendAudit(new AuditData(
            tokenInformation.UserId,
            "PATCH",
            "User",
            tokenInformation.UserId.ToString(),
            "",
            JsonSerializer.Serialize(new { newPassword })
        ));
    }

    public async Task SendEmailResetPasswordAsync(Guid id, string email, string v, EmailTemplateType resetPassword)
    {

        string token = await _jwtTokenGenerator.GenerateEmailTokenAsync(id);
        var emailBody = (await _emailService.GetEmailTemplateAsync(EmailTemplateType.RESET_PASSWORD)).Replace("{token}", token);
        await _emailService.SendEmailAsync(email, "Reseteo de Contraseña", emailBody);

    }

    public async Task<bool> ValidateTokenAsync(string token)
    {
        TokenInformation tokenInformation = await _jwtValidator.ValidateEmailTokenAsync(token);
        return await _passwordRepository.UserExistsAsync(tokenInformation.UserId);
    }


}
