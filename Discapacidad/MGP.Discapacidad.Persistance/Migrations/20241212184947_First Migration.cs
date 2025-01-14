using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MGP.Discapacidad.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class FirstMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CardPickupLocationsOptions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: false),
                    CreationDate = table.Column<DateTime>(type: "timestamp(0) with time zone", precision: 0, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp(0) with time zone", precision: 0, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CardPickupLocationsOptions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CertificateExpansionOption",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: false),
                    CreationDate = table.Column<DateTime>(type: "timestamp(0) with time zone", precision: 0, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp(0) with time zone", precision: 0, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CertificateExpansionOption", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ChatMessage",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    TicketId = table.Column<Guid>(type: "uuid", nullable: false),
                    AgentFullName = table.Column<string>(type: "text", nullable: true),
                    Message = table.Column<string>(type: "character varying(1000)", maxLength: 1000, nullable: false),
                    SentAt = table.Column<DateTime>(type: "timestamp(0) with time zone", precision: 0, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChatMessage", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DocumentStatus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: false),
                    CreationDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocumentStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DocumentType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: false),
                    CreationDate = table.Column<DateTime>(type: "timestamp(0) with time zone", precision: 0, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp(0) with time zone", precision: 0, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocumentType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EmailTemplates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    EmailHtml = table.Column<string>(type: "text", nullable: true),
                    Name = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: false),
                    CreationDate = table.Column<DateTime>(type: "timestamp(0) with time zone", precision: 0, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp(0) with time zone", precision: 0, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmailTemplates", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SignatureOption",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: false),
                    CreationDate = table.Column<DateTime>(type: "timestamp(0) with time zone", precision: 0, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp(0) with time zone", precision: 0, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SignatureOption", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TicketStatus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: false),
                    CreationDate = table.Column<DateTime>(type: "timestamp(0) with time zone", precision: 0, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp(0) with time zone", precision: 0, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TicketStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TicketType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: false),
                    CreationDate = table.Column<DateTime>(type: "timestamp(0) with time zone", precision: 0, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp(0) with time zone", precision: 0, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TicketType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DocumentTemplate",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    DocumentPath = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: false),
                    Information = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: false),
                    Status = table.Column<bool>(type: "boolean", nullable: false),
                    TicketTypeId = table.Column<int>(type: "integer", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "timestamp(0) with time zone", precision: 0, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp(0) with time zone", precision: 0, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocumentTemplate", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DocumentTemplate_TicketType_TicketTypeId",
                        column: x => x.TicketTypeId,
                        principalTable: "TicketType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ticket",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    TicketCode = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: false),
                    AgentId = table.Column<Guid>(type: "uuid", nullable: true),
                    AssignedAgentId = table.Column<Guid>(type: "uuid", nullable: true),
                    GDECode = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    TicketStatusId = table.Column<int>(type: "integer", nullable: false),
                    TicketTypeId = table.Column<int>(type: "integer", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "timestamp(0) with time zone", precision: 0, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp(0) with time zone", precision: 0, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ticket", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ticket_TicketStatus_TicketStatusId",
                        column: x => x.TicketStatusId,
                        principalTable: "TicketStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ticket_TicketType_TicketTypeId",
                        column: x => x.TicketTypeId,
                        principalTable: "TicketType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Document",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    DocumentImage = table.Column<string>(type: "text", nullable: false),
                    TicketId = table.Column<Guid>(type: "uuid", nullable: false),
                    DocumentStatusId = table.Column<int>(type: "integer", nullable: false),
                    DocumentTypeId = table.Column<int>(type: "integer", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "timestamp(0) with time zone", precision: 0, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp(0) with time zone", precision: 0, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Document", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Document_DocumentStatus_DocumentStatusId",
                        column: x => x.DocumentStatusId,
                        principalTable: "DocumentStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Document_DocumentType_DocumentTypeId",
                        column: x => x.DocumentTypeId,
                        principalTable: "DocumentType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Document_Ticket_TicketId",
                        column: x => x.TicketId,
                        principalTable: "Ticket",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TicketCud",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    CertificateExpansionOptionsId = table.Column<int>(type: "integer", nullable: false),
                    Certificate = table.Column<bool>(type: "boolean", nullable: false),
                    ExpiredCertificate = table.Column<bool>(type: "boolean", nullable: false),
                    LostCertificate = table.Column<bool>(type: "boolean", nullable: false),
                    HealthInsurance = table.Column<bool>(type: "boolean", nullable: false),
                    PaySlip = table.Column<bool>(type: "boolean", nullable: false),
                    SignatureOptionId = table.Column<int>(type: "integer", nullable: false),
                    DocumentComplete = table.Column<bool>(type: "boolean", nullable: false),
                    MedicalCommitteDate = table.Column<DateTime>(type: "timestamp(0) with time zone", precision: 0, nullable: true),
                    CreationDate = table.Column<DateTime>(type: "timestamp(0) with time zone", precision: 0, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp(0) with time zone", precision: 0, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TicketCud", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TicketCud_CertificateExpansionOption_CertificateExpansionOp~",
                        column: x => x.CertificateExpansionOptionsId,
                        principalTable: "CertificateExpansionOption",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TicketCud_SignatureOption_SignatureOptionId",
                        column: x => x.SignatureOptionId,
                        principalTable: "SignatureOption",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TicketCud_Ticket_Id",
                        column: x => x.Id,
                        principalTable: "Ticket",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TicketParking",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "timestamp(0) with time zone", precision: 0, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp(0) with time zone", precision: 0, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TicketParking", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TicketParking_Ticket_Id",
                        column: x => x.Id,
                        principalTable: "Ticket",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TicketSube",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    CardPickupId = table.Column<int>(type: "integer", nullable: false),
                    CudCertificateNumber = table.Column<string>(type: "text", nullable: false),
                    CudExpirationDate = table.Column<DateTime>(type: "timestamp(0) with time zone", precision: 0, nullable: false),
                    CreationDate = table.Column<DateTime>(type: "timestamp(0) with time zone", precision: 0, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp(0) with time zone", precision: 0, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TicketSube", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TicketSube_CardPickupLocationsOptions_CardPickupId",
                        column: x => x.CardPickupId,
                        principalTable: "CardPickupLocationsOptions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TicketSube_Ticket_Id",
                        column: x => x.Id,
                        principalTable: "Ticket",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "CardPickupLocationsOptions",
                columns: new[] { "Id", "CreationDate", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 12, 12, 18, 49, 46, 538, DateTimeKind.Utc).AddTicks(8044), null, "Delegación Puerto - AYOLAS 3670" },
                    { 2, new DateTime(2024, 12, 12, 18, 49, 46, 538, DateTimeKind.Utc).AddTicks(8048), null, "Sede Discapacidad - Pescadores 567" },
                    { 3, new DateTime(2024, 12, 12, 18, 49, 46, 538, DateTimeKind.Utc).AddTicks(8049), null, "Delegación Sierra de Los Padres - Padre Luis Varetto 251" }
                });

            migrationBuilder.InsertData(
                table: "CertificateExpansionOption",
                columns: new[] { "Id", "CreationDate", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 12, 12, 18, 49, 46, 538, DateTimeKind.Utc).AddTicks(8323), null, "No amplía" },
                    { 2, new DateTime(2024, 12, 12, 18, 49, 46, 538, DateTimeKind.Utc).AddTicks(8325), null, "Agravamiento de Patología" },
                    { 3, new DateTime(2024, 12, 12, 18, 49, 46, 538, DateTimeKind.Utc).AddTicks(8326), null, "Nueva Patología" }
                });

            migrationBuilder.InsertData(
                table: "DocumentStatus",
                columns: new[] { "Id", "CreationDate", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 12, 12, 18, 49, 46, 538, DateTimeKind.Utc).AddTicks(9950), null, "En espera de validación" },
                    { 2, new DateTime(2024, 12, 12, 18, 49, 46, 538, DateTimeKind.Utc).AddTicks(9951), null, "Valido" },
                    { 3, new DateTime(2024, 12, 12, 18, 49, 46, 538, DateTimeKind.Utc).AddTicks(9952), null, "Invalido" },
                    { 4, new DateTime(2024, 12, 12, 18, 49, 46, 538, DateTimeKind.Utc).AddTicks(9953), null, "Eliminado" }
                });

            migrationBuilder.InsertData(
                table: "DocumentType",
                columns: new[] { "Id", "CreationDate", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 12, 12, 18, 49, 46, 539, DateTimeKind.Utc).AddTicks(167), null, "DNI Frente" },
                    { 2, new DateTime(2024, 12, 12, 18, 49, 46, 539, DateTimeKind.Utc).AddTicks(168), null, "DNI Dorso" },
                    { 3, new DateTime(2024, 12, 12, 18, 49, 46, 539, DateTimeKind.Utc).AddTicks(169), null, "DNI Frente/Madre/Tutor" },
                    { 4, new DateTime(2024, 12, 12, 18, 49, 46, 539, DateTimeKind.Utc).AddTicks(170), null, "DNI Dorso/Madre/Tutor" },
                    { 5, new DateTime(2024, 12, 12, 18, 49, 46, 539, DateTimeKind.Utc).AddTicks(171), null, "Recibo de Haberes" },
                    { 6, new DateTime(2024, 12, 12, 18, 49, 46, 539, DateTimeKind.Utc).AddTicks(172), null, "Carnet Obra Social/Mutual/Prepaga" },
                    { 7, new DateTime(2024, 12, 12, 18, 49, 46, 539, DateTimeKind.Utc).AddTicks(173), null, "Planilla Oficial" },
                    { 8, new DateTime(2024, 12, 12, 18, 49, 46, 539, DateTimeKind.Utc).AddTicks(174), null, "Historia Clínica" },
                    { 9, new DateTime(2024, 12, 12, 18, 49, 46, 539, DateTimeKind.Utc).AddTicks(175), null, "Estudio Complementario" },
                    { 10, new DateTime(2024, 12, 12, 18, 49, 46, 539, DateTimeKind.Utc).AddTicks(175), null, "CUD" },
                    { 11, new DateTime(2024, 12, 12, 18, 49, 46, 539, DateTimeKind.Utc).AddTicks(176), null, "Certificado de Extravio CUD" },
                    { 12, new DateTime(2024, 12, 12, 18, 49, 46, 539, DateTimeKind.Utc).AddTicks(177), null, "Escritura del Domicilio / Contrato de Alquiler / Aval del Consorcio" },
                    { 13, new DateTime(2024, 12, 12, 18, 49, 46, 539, DateTimeKind.Utc).AddTicks(178), null, "Licencia de Conducir" },
                    { 14, new DateTime(2024, 12, 12, 18, 49, 46, 539, DateTimeKind.Utc).AddTicks(179), null, "Certificado de Cobertura del Seguro Automotor" },
                    { 15, new DateTime(2024, 12, 12, 18, 49, 46, 539, DateTimeKind.Utc).AddTicks(180), null, "Cédula del Vehículo" },
                    { 16, new DateTime(2024, 12, 12, 18, 49, 46, 539, DateTimeKind.Utc).AddTicks(181), null, "Croquis que Demarque el Frente de la Propiedad (Foto o Plano)" },
                    { 17, new DateTime(2024, 12, 12, 18, 49, 46, 539, DateTimeKind.Utc).AddTicks(182), null, "Foto 4x4" },
                    { 18, new DateTime(2024, 12, 12, 18, 49, 46, 539, DateTimeKind.Utc).AddTicks(182), null, "Certificado Extendido" },
                    { 19, new DateTime(2024, 12, 12, 18, 49, 46, 539, DateTimeKind.Utc).AddTicks(183), null, "Denuncia" },
                    { 20, new DateTime(2024, 12, 12, 18, 49, 46, 539, DateTimeKind.Utc).AddTicks(184), null, "DNI Conductor Frente" },
                    { 21, new DateTime(2024, 12, 12, 18, 49, 46, 539, DateTimeKind.Utc).AddTicks(185), null, "DNI Conductor Dorso" }
                });

            migrationBuilder.InsertData(
                table: "EmailTemplates",
                columns: new[] { "Id", "CreationDate", "EmailHtml", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 12, 12, 18, 49, 46, 539, DateTimeKind.Utc).AddTicks(361), "<!DOCTYPE html><html><head><meta charset='UTF-8'><style>body {font-family: Arial, sans-serif;color: #333;background-color: #f4f4f4;margin: 0;padding: 0;}.container {width: 100%;max-width: 600px;margin: auto;padding: 20px;background: #fff;border-radius: 8px;box-shadow: 0 2px 4px rgba(0, 0, 0, 0.1);}h1 {color: #0056b3;}.button {display: inline-block;padding: 10px 20px;font-size: 16px;color: #fff;background-color: #007bff;text-decoration: none;border-radius: 5px;margin-top: 20px;}.footer {margin-top: 20px;font-size: 14px;color: #777;text-align: center;}</style></head><body><div class='container'><h1>Solicitud de CUD</h1><p><strong>ESPERÁ QUE TE CONTACTE UN OPERADOR POR CORREO ELECTRÓNICO PARA ENVIARTE LA PLANILLA QUE CORRESPONDA E INDICARTE LOS ESTUDIOS QUE TENÉS QUE PRESENTAR. RECORDÁ QUE TANTO LOS ESTUDIOS COMO LAS PLANILLAS NO DEBEN SUPERAR LOS 12 MESES DE ANTIGÜEDAD. TENÉ EN CUENTA QUE LA RESPUESTA PUEDE DEMORAR HASTA 72 HORAS HÁBILES.</strong></p><p>Si no solicitaste este trámite, por favor ignora este mensaje.</p><div class='footer'><p>&copy; 2024 MDQ Digital. Todos los derechos reservados.</p></div></div></body></html>", null, "Template de Creación de CUD" },
                    { 2, new DateTime(2024, 12, 12, 18, 49, 46, 539, DateTimeKind.Utc).AddTicks(362), "<!DOCTYPE html><html><head><meta charset='UTF-8'><style>body {font-family: Arial, sans-serif;color: #333;background-color: #f4f4f4;margin: 0;padding: 0;}.container {width: 100%;max-width: 600px;margin: auto;padding: 20px;background: #fff;border-radius: 8px;box-shadow: 0 2px 4px rgba(0, 0, 0, 0.1);}h1 {color: #0056b3;}.button {display: inline-block;padding: 10px 20px;font-size: 16px;color: #fff;background-color: #007bff;text-decoration: none;border-radius: 5px;margin-top: 20px;}.footer {margin-top: 20px;font-size: 14px;color: #777;text-align: center;}</style></head><body><div class='container'><h1>Solicitud de Tarjeta Sube</h1><p><strong>ESPERÁ QUE TE CONTACTE UN OPERADOR. TENÉ EN CUENTA QUE LA RESPUESTA PUEDE DEMORAR HASTA 72 HORAS HÁBILES.</strong></p><p>Si no solicitaste este trámite, por favor ignora este mensaje.</p><div class='footer'><p>&copy; 2024 MDQ Digital. Todos los derechos reservados.</p></div></div></body></html>", null, "Template de Creación de SUBE" },
                    { 3, new DateTime(2024, 12, 12, 18, 49, 46, 539, DateTimeKind.Utc).AddTicks(363), "<!DOCTYPE html><html><head><meta charset='UTF-8'><style>body {font-family: Arial, sans-serif;color: #333;background-color: #f4f4f4;margin: 0;padding: 0;}.container {width: 100%;max-width: 600px;margin: auto;padding: 20px;background: #fff;border-radius: 8px;box-shadow: 0 2px 4px rgba(0, 0, 0, 0.1);}h1 {color: #0056b3;}.button {display: inline-block;padding: 10px 20px;font-size: 16px;color: #fff;background-color: #007bff;text-decoration: none;border-radius: 5px;margin-top: 20px;}.footer {margin-top: 20px;font-size: 14px;color: #777;text-align: center;}</style></head><body><div class='container'><h1>Solicitud de Estacionamiento</h1><p><strong>ESPERÁ QUE TE CONTACTE UN OPERADOR POR CHAT. TENÉ EN CUENTA QUE LA RESPUESTA PUEDE DEMORAR HASTA 72 HORAS HÁBILES.</strong></p><p>Si no solicitaste este trámite, por favor ignora este mensaje.</p><div class='footer'><p>&copy; 2024 MDQ Digital. Todos los derechos reservados.</p></div></div></body></html>", null, "Template de Creación de Parking" },
                    { 4, new DateTime(2024, 12, 12, 18, 49, 46, 539, DateTimeKind.Utc).AddTicks(364), "<!DOCTYPE html><html><head><meta charset='UTF-8'><style>body {font-family: Arial, sans-serif;color: #333;background-color: #f4f4f4;margin: 0;padding: 0;}.container {width: 100%;max-width: 600px;margin: auto;padding: 20px;background: #fff;border-radius: 8px;box-shadow: 0 2px 4px rgba(0, 0, 0, 0.1);}h1 {color: #0056b3;}.button {display: inline-block;padding: 10px 20px;font-size: 16px;color: #fff;background-color: #007bff;text-decoration: none;border-radius: 5px;margin-top: 20px;}.footer {margin-top: 20px;font-size: 14px;color: #777;text-align: center;}</style></head><body><div class='container'><h1>HAY NOVEDADES DEL TRAMITE</h1><p><strong>Ingresá a MDQ Digital con tus credenciales para ver el estado de tu tramite: <a href='http://localhost:5173/' class='button'>Acceder</a></strong></p><p>Si no solicitaste este trámite, por favor ignora este mensaje.</p><div class='footer'><p>&copy; 2024 MDQ Digital. Todos los derechos reservados.</p></div></div></body></html>", null, "Nueva Actividad en Ticket" }
                });

            migrationBuilder.InsertData(
                table: "SignatureOption",
                columns: new[] { "Id", "CreationDate", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 12, 12, 18, 49, 46, 539, DateTimeKind.Utc).AddTicks(488), null, "Firma realizada por la persona misma" },
                    { 2, new DateTime(2024, 12, 12, 18, 49, 46, 539, DateTimeKind.Utc).AddTicks(489), null, "Firma realizada conjuntamente con otra persona" },
                    { 3, new DateTime(2024, 12, 12, 18, 49, 46, 539, DateTimeKind.Utc).AddTicks(490), null, "Firma realizada por un tercero" }
                });

            migrationBuilder.InsertData(
                table: "TicketStatus",
                columns: new[] { "Id", "CreationDate", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 12, 12, 18, 49, 46, 539, DateTimeKind.Utc).AddTicks(613), null, "Nuevo" },
                    { 2, new DateTime(2024, 12, 12, 18, 49, 46, 539, DateTimeKind.Utc).AddTicks(614), null, "En Proceso - Vecino" },
                    { 3, new DateTime(2024, 12, 12, 18, 49, 46, 539, DateTimeKind.Utc).AddTicks(615), null, "En Proceso - Agente" },
                    { 4, new DateTime(2024, 12, 12, 18, 49, 46, 539, DateTimeKind.Utc).AddTicks(658), null, "Esperando Resolución" },
                    { 5, new DateTime(2024, 12, 12, 18, 49, 46, 539, DateTimeKind.Utc).AddTicks(659), null, "Cerrado por falta de Respuesta" },
                    { 6, new DateTime(2024, 12, 12, 18, 49, 46, 539, DateTimeKind.Utc).AddTicks(660), null, "Cerrado Otorgado" },
                    { 7, new DateTime(2024, 12, 12, 18, 49, 46, 539, DateTimeKind.Utc).AddTicks(660), null, "Cerrado denegado" },
                    { 8, new DateTime(2024, 12, 12, 18, 49, 46, 539, DateTimeKind.Utc).AddTicks(661), null, "Cancelado" }
                });

            migrationBuilder.InsertData(
                table: "TicketType",
                columns: new[] { "Id", "CreationDate", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 12, 12, 18, 49, 46, 539, DateTimeKind.Utc).AddTicks(776), null, "CUD" },
                    { 2, new DateTime(2024, 12, 12, 18, 49, 46, 539, DateTimeKind.Utc).AddTicks(777), null, "SUBE" },
                    { 3, new DateTime(2024, 12, 12, 18, 49, 46, 539, DateTimeKind.Utc).AddTicks(778), null, "ESTACIONAMIENTO" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ChatMessage_TicketId",
                table: "ChatMessage",
                column: "TicketId");

            migrationBuilder.CreateIndex(
                name: "IX_Document_DocumentStatusId",
                table: "Document",
                column: "DocumentStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Document_DocumentTypeId",
                table: "Document",
                column: "DocumentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Document_TicketId",
                table: "Document",
                column: "TicketId");

            migrationBuilder.CreateIndex(
                name: "IX_DocumentTemplate_Name",
                table: "DocumentTemplate",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DocumentTemplate_TicketTypeId",
                table: "DocumentTemplate",
                column: "TicketTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_TicketCode",
                table: "Ticket",
                column: "TicketCode",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_TicketStatusId",
                table: "Ticket",
                column: "TicketStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_TicketTypeId",
                table: "Ticket",
                column: "TicketTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_UserId",
                table: "Ticket",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_TicketCud_CertificateExpansionOptionsId",
                table: "TicketCud",
                column: "CertificateExpansionOptionsId");

            migrationBuilder.CreateIndex(
                name: "IX_TicketCud_SignatureOptionId",
                table: "TicketCud",
                column: "SignatureOptionId");

            migrationBuilder.CreateIndex(
                name: "IX_TicketSube_CardPickupId",
                table: "TicketSube",
                column: "CardPickupId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChatMessage");

            migrationBuilder.DropTable(
                name: "Document");

            migrationBuilder.DropTable(
                name: "DocumentTemplate");

            migrationBuilder.DropTable(
                name: "EmailTemplates");

            migrationBuilder.DropTable(
                name: "TicketCud");

            migrationBuilder.DropTable(
                name: "TicketParking");

            migrationBuilder.DropTable(
                name: "TicketSube");

            migrationBuilder.DropTable(
                name: "DocumentStatus");

            migrationBuilder.DropTable(
                name: "DocumentType");

            migrationBuilder.DropTable(
                name: "CertificateExpansionOption");

            migrationBuilder.DropTable(
                name: "SignatureOption");

            migrationBuilder.DropTable(
                name: "CardPickupLocationsOptions");

            migrationBuilder.DropTable(
                name: "Ticket");

            migrationBuilder.DropTable(
                name: "TicketStatus");

            migrationBuilder.DropTable(
                name: "TicketType");
        }
    }
}
