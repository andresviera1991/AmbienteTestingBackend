using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using MGP.Discapacidad.Persistance.Data.Tables;
using System;
namespace MGP.Discapacidad.Persistance.Data.Seeds;
public class DocumentTypeSeed : IEntityTypeConfiguration<DocumentType>
{
    public void Configure(EntityTypeBuilder<DocumentType> builder)
    {
        builder.HasData(
            new DocumentType
            {
                Id = 1,
                Name = "DNI Frente",
                CreationDate = DateTime.UtcNow
            },
            new DocumentType
            {
                Id = 2,
                Name = "DNI Dorso",
                CreationDate = DateTime.UtcNow
            },
            new DocumentType
            {
                Id = 3,
                Name = "DNI Frente/Madre/Tutor",
                CreationDate = DateTime.UtcNow
            },
            new DocumentType
            {
                Id = 4,
                Name = "DNI Dorso/Madre/Tutor",
                CreationDate = DateTime.UtcNow
            },
            new DocumentType
            {
                Id = 5,
                Name = "Recibo de Haberes",
                CreationDate = DateTime.UtcNow
            },
            new DocumentType
            {
                Id = 6,
                Name = "Carnet Obra Social/Mutual/Prepaga",
                CreationDate = DateTime.UtcNow
            },
            new DocumentType
            {
                Id = 7,
                Name = "Planilla Oficial",
                CreationDate = DateTime.UtcNow
            },
            new DocumentType
            {
                Id = 8,
                Name = "Historia Clínica",
                CreationDate = DateTime.UtcNow
            },
            new DocumentType
            {
                Id = 9,
                Name = "Estudio Complementario",
                CreationDate = DateTime.UtcNow
            },
            new DocumentType
            {
                Id = 10,
                Name = "CUD",
                CreationDate = DateTime.UtcNow
            },
            new DocumentType
            {
                Id = 11,
                Name = "Certificado de Extravio CUD",
                CreationDate = DateTime.UtcNow
            },
            new DocumentType
            {
                Id = 12,
                Name = "Escritura del Domicilio / Contrato de Alquiler / Aval del Consorcio",
                CreationDate = DateTime.UtcNow
            },
            new DocumentType
            {
                Id = 13,
                Name = "Licencia de Conducir",
                CreationDate = DateTime.UtcNow
            },
            new DocumentType
            {
                Id = 14,
                Name = "Certificado de Cobertura del Seguro Automotor",
                CreationDate = DateTime.UtcNow
            },
            new DocumentType
            {
                Id = 15,
                Name = "Cédula del Vehículo",
                CreationDate = DateTime.UtcNow
            },
            new DocumentType
            {
                Id = 16,
                Name = "Croquis que Demarque el Frente de la Propiedad (Foto o Plano)",
                CreationDate = DateTime.UtcNow
            },
            new DocumentType
            {
                Id = 17,
                Name = "Foto 4x4",
                CreationDate = DateTime.UtcNow
            },
            new DocumentType
            {
                Id = 18,
                Name = "Certificado Extendido",
                CreationDate = DateTime.UtcNow
            },
            new DocumentType
            {
                Id = 19,
                Name = "Denuncia",
                CreationDate = DateTime.UtcNow
            },
            new DocumentType
            {
                Id = 20,
                Name = "DNI Conductor Frente",
                CreationDate = DateTime.UtcNow
            },
            new DocumentType
            {
                Id = 21,
                Name = "DNI Conductor Dorso",
                CreationDate = DateTime.UtcNow
            }
        );
    }
}