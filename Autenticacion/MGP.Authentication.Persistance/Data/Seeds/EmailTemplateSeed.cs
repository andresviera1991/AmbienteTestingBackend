using MGP.Authentication.Persistance.Data.Tables;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;

namespace MGP.Authentication.Persistance.Data.Seeds;

public class EmailTemplateSeed : IEntityTypeConfiguration<EmailTemplate>
{
    public void Configure(EntityTypeBuilder<EmailTemplate> builder)
    {
        builder.HasData(new EmailTemplate
        {
            Id = 1,
            Description = "Template de Validación de Usuario",
            CreationDate = DateTime.UtcNow,
            EmailHtml = @"<!DOCTYPE html><html><head><meta charset='UTF-8'><style>body {font-family: Arial, sans-serif;color: #333;background-color: #f4f4f4;margin: 0;padding: 0;}.container {width: 100%;max-width: 600px;margin: auto;padding: 20px;background: #fff;border-radius: 8px;box-shadow: 0 2px 4px rgba(0, 0, 0, 0.1);}h1 {color: #0056b3;}.button {display: inline-block;padding: 10px 20px;font-size: 16px;color: #fff;background-color: #007bff;text-decoration: none;border-radius: 5px;margin-top: 20px;}.footer {margin-top: 20px;font-size: 14px;color: #777;text-align: center;}</style></head><body><div class='container'><h1>¡Hola!</h1><p>Gracias por ser parte de <strong>MDQ Digital</strong>. Para continuar accede al siguiente link</p><a href='http://localhost:5173/cuenta-exitosa/cuenta/confirmar?token={token}' class='button'>Validar</a><p>Si no solicitaste este trámite, por favor ignora este mensaje.</p><div class='footer'><p>&copy; 2024 MDQ Digital. Todos los derechos reservados.</p></div></div></body></html>"
        },
        new EmailTemplate
        {
            Id = 2,
            Description = "Template de Reseteo de Contraseña",
            CreationDate = DateTime.UtcNow,
            EmailHtml = @"<!DOCTYPE html><html><head><meta charset='UTF-8'><style>body {font-family: Arial, sans-serif;color: #333;background-color: #f4f4f4;margin: 0;padding: 0;}.container {width: 100%;max-width: 600px;margin: auto;padding: 20px;background: #fff;border-radius: 8px;box-shadow: 0 2px 4px rgba(0, 0, 0, 0.1);}h1 {color: #0056b3;}.button {display: inline-block;padding: 10px 20px;font-size: 16px;color: #fff;background-color: #007bff;text-decoration: none;border-radius: 5px;margin-top: 20px;}.footer {margin-top: 20px;font-size: 14px;color: #777;text-align: center;}</style></head><body><div class='container'><h1>¡Hola!</h1><p><strong>Solicitaste el reseteo de tu contraseña</strong></p>Para continuar accede al siguiente link</p><a href='http://localhost:5173/account/resetpassword?token={token}' class='button'>Cambiar Password</a><p>Si no solicitaste este trámite, por favor ignora este mensaje.</p><div class='footer'><p>&copy; 2024 MDQ Digital. Todos los derechos reservados.</p></div></div></body></html>"
        });
    }
}