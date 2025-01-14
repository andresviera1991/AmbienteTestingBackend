using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MGP.Authentication.Persistance.Data.Migrations
{
    /// <inheritdoc />
    public partial class FirstMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Street = table.Column<string>(type: "text", nullable: false),
                    StreetNumber = table.Column<string>(type: "text", nullable: false),
                    Floor = table.Column<string>(type: "text", nullable: true),
                    Apartment = table.Column<string>(type: "text", nullable: true),
                    BetweenStreetOne = table.Column<string>(type: "text", nullable: true),
                    BetweenStreetTwo = table.Column<string>(type: "text", nullable: true),
                    LocalityId = table.Column<int>(type: "integer", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "timestamp(0) with time zone", precision: 0, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp(0) with time zone", precision: 0, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EmailTemplates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    EmailHtml = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: false),
                    CreationDate = table.Column<DateTime>(type: "timestamp(0) with time zone", precision: 0, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp(0) with time zone", precision: 0, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmailTemplates", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Gender",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Description = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: false),
                    CreationDate = table.Column<DateTime>(type: "timestamp(0) with time zone", precision: 0, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp(0) with time zone", precision: 0, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gender", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PhoneNumber",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Number = table.Column<string>(type: "text", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "timestamp(0) with time zone", precision: 0, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp(0) with time zone", precision: 0, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhoneNumber", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RevokedRefreshToken",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    RefreshToken = table.Column<string>(type: "text", nullable: false),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    ExpirationDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "timestamp(0) with time zone", precision: 0, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp(0) with time zone", precision: 0, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RevokedRefreshToken", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserLevel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Description = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: false),
                    CreationDate = table.Column<DateTime>(type: "timestamp(0) with time zone", precision: 0, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp(0) with time zone", precision: 0, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLevel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserStatus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Description = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: false),
                    CreationDate = table.Column<DateTime>(type: "timestamp(0) with time zone", precision: 0, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp(0) with time zone", precision: 0, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Person",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    DocumentNumber = table.Column<string>(type: "character varying(8)", maxLength: 8, nullable: false),
                    Name = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: false),
                    LastName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: false),
                    GenderId = table.Column<int>(type: "integer", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "date", nullable: false),
                    Resident = table.Column<bool>(type: "boolean", nullable: false),
                    AddressId = table.Column<Guid>(type: "uuid", nullable: true),
                    PhoneNumberId = table.Column<Guid>(type: "uuid", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "timestamp(0) with time zone", precision: 0, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp(0) with time zone", precision: 0, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Person_Address_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Address",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Person_Gender_GenderId",
                        column: x => x.GenderId,
                        principalTable: "Gender",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Person_PhoneNumber_PhoneNumberId",
                        column: x => x.PhoneNumberId,
                        principalTable: "PhoneNumber",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Parent",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    DocumentNumber = table.Column<string>(type: "character varying(8)", maxLength: 8, nullable: false),
                    Name = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: false),
                    LastName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: false),
                    PersonId = table.Column<Guid>(type: "uuid", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "timestamp(0) with time zone", precision: 0, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp(0) with time zone", precision: 0, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parent", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Parent_Person_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    UserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: false),
                    Password = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: false),
                    Email = table.Column<string>(type: "text", nullable: true),
                    PersonId = table.Column<Guid>(type: "uuid", nullable: false),
                    UserStatusId = table.Column<int>(type: "integer", nullable: false),
                    LevelId = table.Column<int>(type: "integer", nullable: false),
                    FailedLoginAttempts = table.Column<int>(type: "integer", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "timestamp(0) with time zone", precision: 0, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp(0) with time zone", precision: 0, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                    table.ForeignKey(
                        name: "FK_User_Person_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_User_UserLevel_LevelId",
                        column: x => x.LevelId,
                        principalTable: "UserLevel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_User_UserStatus_UserStatusId",
                        column: x => x.UserStatusId,
                        principalTable: "UserStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "EmailTemplates",
                columns: new[] { "Id", "CreationDate", "Description", "EmailHtml", "ModifiedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 12, 10, 13, 23, 27, 271, DateTimeKind.Utc).AddTicks(3165), "Template de Validación de Usuario", "<!DOCTYPE html><html><head><meta charset='UTF-8'><style>body {font-family: Arial, sans-serif;color: #333;background-color: #f4f4f4;margin: 0;padding: 0;}.container {width: 100%;max-width: 600px;margin: auto;padding: 20px;background: #fff;border-radius: 8px;box-shadow: 0 2px 4px rgba(0, 0, 0, 0.1);}h1 {color: #0056b3;}.button {display: inline-block;padding: 10px 20px;font-size: 16px;color: #fff;background-color: #007bff;text-decoration: none;border-radius: 5px;margin-top: 20px;}.footer {margin-top: 20px;font-size: 14px;color: #777;text-align: center;}</style></head><body><div class='container'><h1>¡Hola!</h1><p>Gracias por ser parte de <strong>MDQ Digital</strong>. Para continuar accede al siguiente link</p><a href='http://localhost:5173/cuenta-exitosa/cuenta/confirmar?token={token}' class='button'>Validar</a><p>Si no solicitaste este trámite, por favor ignora este mensaje.</p><div class='footer'><p>&copy; 2024 MDQ Digital. Todos los derechos reservados.</p></div></div></body></html>", null },
                    { 2, new DateTime(2024, 12, 10, 13, 23, 27, 271, DateTimeKind.Utc).AddTicks(3168), "Template de Reseteo de Contraseña", "<!DOCTYPE html><html><head><meta charset='UTF-8'><style>body {font-family: Arial, sans-serif;color: #333;background-color: #f4f4f4;margin: 0;padding: 0;}.container {width: 100%;max-width: 600px;margin: auto;padding: 20px;background: #fff;border-radius: 8px;box-shadow: 0 2px 4px rgba(0, 0, 0, 0.1);}h1 {color: #0056b3;}.button {display: inline-block;padding: 10px 20px;font-size: 16px;color: #fff;background-color: #007bff;text-decoration: none;border-radius: 5px;margin-top: 20px;}.footer {margin-top: 20px;font-size: 14px;color: #777;text-align: center;}</style></head><body><div class='container'><h1>¡Hola!</h1><p><strong>Solicitaste el reseteo de tu contraseña</strong></p>Para continuar accede al siguiente link</p><a href='http://localhost:5173/account/resetpassword?token={token}' class='button'>Cambiar Password</a><p>Si no solicitaste este trámite, por favor ignora este mensaje.</p><div class='footer'><p>&copy; 2024 MDQ Digital. Todos los derechos reservados.</p></div></div></body></html>", null }
                });

            migrationBuilder.InsertData(
                table: "Gender",
                columns: new[] { "Id", "CreationDate", "Description", "ModifiedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 12, 10, 13, 23, 27, 271, DateTimeKind.Utc).AddTicks(3331), "Masculino", null },
                    { 2, new DateTime(2024, 12, 10, 13, 23, 27, 271, DateTimeKind.Utc).AddTicks(3333), "Femenino", null },
                    { 3, new DateTime(2024, 12, 10, 13, 23, 27, 271, DateTimeKind.Utc).AddTicks(3334), "Otro", null }
                });

            migrationBuilder.InsertData(
                table: "UserLevel",
                columns: new[] { "Id", "CreationDate", "Description", "ModifiedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 12, 10, 13, 23, 27, 271, DateTimeKind.Utc).AddTicks(3437), "Nivel 0", null },
                    { 2, new DateTime(2024, 12, 10, 13, 23, 27, 271, DateTimeKind.Utc).AddTicks(3438), "Nivel 1", null },
                    { 3, new DateTime(2024, 12, 10, 13, 23, 27, 271, DateTimeKind.Utc).AddTicks(3439), "Nivel 2", null }
                });

            migrationBuilder.InsertData(
                table: "UserStatus",
                columns: new[] { "Id", "CreationDate", "Description", "ModifiedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 12, 10, 13, 23, 27, 271, DateTimeKind.Utc).AddTicks(3539), "Activo", null },
                    { 2, new DateTime(2024, 12, 10, 13, 23, 27, 271, DateTimeKind.Utc).AddTicks(3542), "Inactivo", null },
                    { 3, new DateTime(2024, 12, 10, 13, 23, 27, 271, DateTimeKind.Utc).AddTicks(3543), "Bloqueado", null },
                    { 4, new DateTime(2024, 12, 10, 13, 23, 27, 271, DateTimeKind.Utc).AddTicks(3549), "Eliminado", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Parent_PersonId",
                table: "Parent",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Person_AddressId",
                table: "Person",
                column: "AddressId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Person_DocumentNumber",
                table: "Person",
                column: "DocumentNumber",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Person_FullName",
                table: "Person",
                columns: new[] { "Name", "LastName" });

            migrationBuilder.CreateIndex(
                name: "IX_Person_GenderId",
                table: "Person",
                column: "GenderId");

            migrationBuilder.CreateIndex(
                name: "IX_Person_PhoneNumberId",
                table: "Person",
                column: "PhoneNumberId");

            migrationBuilder.CreateIndex(
                name: "IX_RevokedRefreshToken_RefreshToken",
                table: "RevokedRefreshToken",
                column: "RefreshToken");

            migrationBuilder.CreateIndex(
                name: "IX_User_LevelId",
                table: "User",
                column: "LevelId");

            migrationBuilder.CreateIndex(
                name: "IX_User_PersonId",
                table: "User",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_User_UserName",
                table: "User",
                column: "UserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_User_UserStatusId",
                table: "User",
                column: "UserStatusId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmailTemplates");

            migrationBuilder.DropTable(
                name: "Parent");

            migrationBuilder.DropTable(
                name: "RevokedRefreshToken");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Person");

            migrationBuilder.DropTable(
                name: "UserLevel");

            migrationBuilder.DropTable(
                name: "UserStatus");

            migrationBuilder.DropTable(
                name: "Address");

            migrationBuilder.DropTable(
                name: "Gender");

            migrationBuilder.DropTable(
                name: "PhoneNumber");
        }
    }
}
