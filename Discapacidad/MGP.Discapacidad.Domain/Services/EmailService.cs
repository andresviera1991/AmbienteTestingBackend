using MGP.Discapacidad.Domain.interfaces;
using System.Net.Mail;
using System;
using System.Threading.Tasks;
using System.Net;
using MGP.Discapacidad.CrossCutting.Excepciones;
using MGP.Discapacidad.Persistance.Interface;
using MGP.Discapacidad.CrossCutting.Enum;
namespace MGP.Discapacidad.Domain.Services;

public class EmailService : IEmailService
{

    private readonly IEmailRepository _emailRepository;

    public EmailService(IEmailRepository emailRepository)
    {
        _emailRepository = emailRepository;
    }

    public async Task<string> GetEmailTemplateAsync(EmailTemplateEnum emailTemplate)
    {
        return await _emailRepository.GetEmailTemplateAsync(emailTemplate);
    }

    public async Task SendEmailHandlerAsync(string email, string subject, string emailBody)
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
                Body = emailBody,
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
