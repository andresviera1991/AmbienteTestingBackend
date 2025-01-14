using MGP.Backoffice.Persistance.Data.Tables;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace MGP.Backoffice.Persistance.Data.Seeds;

public class EmailTemplateSeed : IEntityTypeConfiguration<EmailTemplate>
{
    public void Configure(EntityTypeBuilder<EmailTemplate> builder)
    {
        builder.HasData(new EmailTemplate
        {
            Id = 1,
            Name = "Template de Solicitud de Acceso al Sistema",
            CreationDate = DateTime.UtcNow,
            EmailHtml = @"<!DOCTYPE html><html><head><meta charset='UTF-8'><style>body {font-family: Arial, sans-serif;color: #333;background-color: #f4f4f4;margin: 0;padding: 0;} .container {width: 100%;max-width: 600px;margin: auto;padding: 20px;background: #fff;border-radius: 8px;box-shadow: 0 2px 4px rgba(0, 0, 0, 0.1);} h1 {color: #0056b3;} .button {display: inline-block;padding: 10px 20px;font-size: 16px;color: #fff;background-color: #007bff;text-decoration: none;border-radius: 5px;margin-top: 20px;} .footer {margin-top: 20px;font-size: 14px;color: #777;text-align: center;}</style></head><body><div class='container'><h1>¡Hola!</h1><p>Se ha solicitado la creación de un nuevo usuario </p><p> Nombre y Apellido: {firstName} {lastName}</p> <p>Legajo: {employeeNumber} </p><p>Recuerde iniciar sesión para validar usuario y asignar area y rol correspondiente.</p><div class='footer'><p>&copy; 2024 MDQ Digital. Todos los derechos reservados.</p></div></div></body></html>"
        },
        new EmailTemplate
        {
            Id = 2,
            Name = "Template de Envio de Credenciales",
            CreationDate = DateTime.UtcNow,
            EmailHtml = @"<!DOCTYPE html><html><head><meta charset='UTF-8'><style>body {font-family: Arial, sans-serif;color: #333;background-color: #f4f4f4;margin: 0;padding: 0;}.container {width: 100%;max-width: 600px;margin: auto;padding: 20px;background: #fff;border-radius: 8px;box-shadow: 0 2px 4px rgba(0, 0, 0, 0.1);}h1 {color: #0056b3;}.button {display: inline-block;padding: 10px 20px;font-size: 16px;color: #fff;background-color: #007bff;text-decoration: none;border-radius: 5px;margin-top: 20px;}.footer {margin-top: 20px;font-size: 14px;color: #777;text-align: center;}</style></head><body><div class='container'><h1>¡Hola!</h1><p>Gracias por ser parte de <strong>MDQ Digital</strong>. <p>Nombre de Usuario: {userName}</p> <p>Contraseña temporal: {password}</p>  <strong>Te recomendamos modificar la contraseña luego del primer acceso! </strong> <div class='footer'><p>&copy; 2024 MDQ Digital. Todos los derechos reservados.</p></div></div></body></html>"
        },
        new EmailTemplate
        {
            Id = 3,
            Name = "Template de Solicitud de Reseteo de Contraseña",
            CreationDate = DateTime.UtcNow,
            EmailHtml = @"<!DOCTYPE html><html><head><meta charset='UTF-8'><style>body {font-family: Arial, sans-serif;color: #333;background-color: #f4f4f4;margin: 0;padding: 0;} .container {width: 100%;max-width: 600px;margin: auto;padding: 20px;background: #fff;border-radius: 8px;box-shadow: 0 2px 4px rgba(0, 0, 0, 0.1);} h1 {color: #0056b3;} .button {display: inline-block;padding: 10px 20px;font-size: 16px;color: #fff;background-color: #007bff;text-decoration: none;border-radius: 5px;margin-top: 20px;} .footer {margin-top: 20px;font-size: 14px;color: #777;text-align: center;}</style></head><body><div class='container'><h1>¡Hola!</h1><p><strong>MDQ Digital</strong>. </p><p>El empleado: {employeeNumber}</p><p>Solicito el reseteo de su contraseña.</p><div class='footer'><p>&copy; 2024 MDQ Digital. Todos los derechos reservados.</p></div></div></body></html>"
        });
    }
}