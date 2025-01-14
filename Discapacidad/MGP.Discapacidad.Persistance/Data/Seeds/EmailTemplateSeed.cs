using MGP.Discapacidad.Persistance.Data.Tables;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;

namespace MGP.Discapacidad.Persistance.Data.Seeds;

public class EmailTemplateSeed : IEntityTypeConfiguration<EmailTemplate>
{
    public void Configure(EntityTypeBuilder<EmailTemplate> builder)
    {
        builder.HasData(new EmailTemplate
        {
            Id = 1,
            Name = "Template de Creación de CUD",
            CreationDate = DateTime.UtcNow,
            EmailHtml = @"<!DOCTYPE html><html><head><meta charset='UTF-8'><style>body {font-family: Arial, sans-serif;color: #333;background-color: #f4f4f4;margin: 0;padding: 0;}.container {width: 100%;max-width: 600px;margin: auto;padding: 20px;background: #fff;border-radius: 8px;box-shadow: 0 2px 4px rgba(0, 0, 0, 0.1);}h1 {color: #0056b3;}.button {display: inline-block;padding: 10px 20px;font-size: 16px;color: #fff;background-color: #007bff;text-decoration: none;border-radius: 5px;margin-top: 20px;}.footer {margin-top: 20px;font-size: 14px;color: #777;text-align: center;}</style></head><body><div class='container'><h1>Solicitud de CUD</h1><p><strong>ESPERÁ QUE TE CONTACTE UN OPERADOR POR CORREO ELECTRÓNICO PARA ENVIARTE LA PLANILLA QUE CORRESPONDA E INDICARTE LOS ESTUDIOS QUE TENÉS QUE PRESENTAR. RECORDÁ QUE TANTO LOS ESTUDIOS COMO LAS PLANILLAS NO DEBEN SUPERAR LOS 12 MESES DE ANTIGÜEDAD. TENÉ EN CUENTA QUE LA RESPUESTA PUEDE DEMORAR HASTA 72 HORAS HÁBILES.</strong></p><p>Si no solicitaste este trámite, por favor ignora este mensaje.</p><div class='footer'><p>&copy; 2024 MDQ Digital. Todos los derechos reservados.</p></div></div></body></html>"
        },
        new EmailTemplate
        {
            Id = 2,
            Name = "Template de Creación de SUBE",
            CreationDate = DateTime.UtcNow,
            EmailHtml = @"<!DOCTYPE html><html><head><meta charset='UTF-8'><style>body {font-family: Arial, sans-serif;color: #333;background-color: #f4f4f4;margin: 0;padding: 0;}.container {width: 100%;max-width: 600px;margin: auto;padding: 20px;background: #fff;border-radius: 8px;box-shadow: 0 2px 4px rgba(0, 0, 0, 0.1);}h1 {color: #0056b3;}.button {display: inline-block;padding: 10px 20px;font-size: 16px;color: #fff;background-color: #007bff;text-decoration: none;border-radius: 5px;margin-top: 20px;}.footer {margin-top: 20px;font-size: 14px;color: #777;text-align: center;}</style></head><body><div class='container'><h1>Solicitud de Tarjeta Sube</h1><p><strong>ESPERÁ QUE TE CONTACTE UN OPERADOR. TENÉ EN CUENTA QUE LA RESPUESTA PUEDE DEMORAR HASTA 72 HORAS HÁBILES.</strong></p><p>Si no solicitaste este trámite, por favor ignora este mensaje.</p><div class='footer'><p>&copy; 2024 MDQ Digital. Todos los derechos reservados.</p></div></div></body></html>"
        },
        new EmailTemplate
        {
            Id = 3,
            Name = "Template de Creación de Parking",
            CreationDate = DateTime.UtcNow,
            EmailHtml = @"<!DOCTYPE html><html><head><meta charset='UTF-8'><style>body {font-family: Arial, sans-serif;color: #333;background-color: #f4f4f4;margin: 0;padding: 0;}.container {width: 100%;max-width: 600px;margin: auto;padding: 20px;background: #fff;border-radius: 8px;box-shadow: 0 2px 4px rgba(0, 0, 0, 0.1);}h1 {color: #0056b3;}.button {display: inline-block;padding: 10px 20px;font-size: 16px;color: #fff;background-color: #007bff;text-decoration: none;border-radius: 5px;margin-top: 20px;}.footer {margin-top: 20px;font-size: 14px;color: #777;text-align: center;}</style></head><body><div class='container'><h1>Solicitud de Estacionamiento</h1><p><strong>ESPERÁ QUE TE CONTACTE UN OPERADOR POR CHAT. TENÉ EN CUENTA QUE LA RESPUESTA PUEDE DEMORAR HASTA 72 HORAS HÁBILES.</strong></p><p>Si no solicitaste este trámite, por favor ignora este mensaje.</p><div class='footer'><p>&copy; 2024 MDQ Digital. Todos los derechos reservados.</p></div></div></body></html>"
        },
        new EmailTemplate
        {
            Id = 4,
            Name = "Nueva Actividad en Ticket",
            CreationDate = DateTime.UtcNow,
            EmailHtml = @"<!DOCTYPE html><html><head><meta charset='UTF-8'><style>body {font-family: Arial, sans-serif;color: #333;background-color: #f4f4f4;margin: 0;padding: 0;}.container {width: 100%;max-width: 600px;margin: auto;padding: 20px;background: #fff;border-radius: 8px;box-shadow: 0 2px 4px rgba(0, 0, 0, 0.1);}h1 {color: #0056b3;}.button {display: inline-block;padding: 10px 20px;font-size: 16px;color: #fff;background-color: #007bff;text-decoration: none;border-radius: 5px;margin-top: 20px;}.footer {margin-top: 20px;font-size: 14px;color: #777;text-align: center;}</style></head><body><div class='container'><h1>HAY NOVEDADES DEL TRAMITE</h1><p><strong>Ingresá a MDQ Digital con tus credenciales para ver el estado de tu tramite: <a href='http://localhost:5173/' class='button'>Acceder</a></strong></p><p>Si no solicitaste este trámite, por favor ignora este mensaje.</p><div class='footer'><p>&copy; 2024 MDQ Digital. Todos los derechos reservados.</p></div></div></body></html>"
        });
    }
}