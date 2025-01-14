using MGP.Authentication.CrossCutting.Enum;
using MGP.Authentication.CrossCutting.Exceptions;
using MGP.Authentication.Domain.Interfaces;
using MGP.Authentication.Persistance.Interface;
using System;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
namespace MGP.Authentication.Domain.Services;

public class EmailService : IEmailService
{
    private readonly IEmailRepository _emailRepository;

    public EmailService(IEmailRepository emailRepository)
    {
        _emailRepository = emailRepository;
    }

    public async Task<string> GetEmailTemplateAsync(EmailTemplateType emailTemplate)
    {
        return await _emailRepository.GetEmailTemplateAsync(emailTemplate);
    }

    public async Task SendEmailAsync(string email, string subject, string bodyEmail)
    {
        try
        {
            var fromAddress = new MailAddress(Environment.GetEnvironmentVariable("MY_EMAIL"), "Municipio General Pueyrredon");
            string fromPassword = Environment.GetEnvironmentVariable("MY_PASSWORD");
            var toAddress = new MailAddress(email);

            var smtp = new SmtpClient
            {
                Host = "mail.avalith.net",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword),
                UseDefaultCredentials = false,
                Timeout = 10000
            };

            using var message = new MailMessage(fromAddress, toAddress)
            {
                Subject = subject,
                Body = bodyEmail,
                IsBodyHtml = true
            };

            await smtp.SendMailAsync(message);
        }
        catch (Exception)
        {
            throw new EmailException();
        }
    }
}
