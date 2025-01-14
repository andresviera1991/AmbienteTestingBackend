using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MGP.Backoffice.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class FirstMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Area",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "timestamp(0) with time zone", precision: 0, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp(0) with time zone", precision: 0, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Area", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EmailTemplates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    EmailHtml = table.Column<string>(type: "text", nullable: true),
                    Name = table.Column<string>(type: "text", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "timestamp(0) with time zone", precision: 0, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp(0) with time zone", precision: 0, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmailTemplates", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Menu",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ParentMenuId = table.Column<int>(type: "integer", nullable: true),
                    Label = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Icon = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    Url = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    Order = table.Column<int>(type: "integer", nullable: false),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "timestamp(0) with time zone", precision: 0, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp(0) with time zone", precision: 0, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menu", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Menu_Menu_ParentMenuId",
                        column: x => x.ParentMenuId,
                        principalTable: "Menu",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RevokedRefreshSessionToken",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    RefreshToken = table.Column<string>(type: "text", nullable: false),
                    AgentId = table.Column<Guid>(type: "uuid", nullable: false),
                    ExpirationDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "timestamp(0) with time zone", precision: 0, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp(0) with time zone", precision: 0, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RevokedRefreshSessionToken", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "timestamp(0) with time zone", precision: 0, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp(0) with time zone", precision: 0, nullable: true),
                    Name = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserStatus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "timestamp(0) with time zone", precision: 0, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp(0) with time zone", precision: 0, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TicketType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    AreaId = table.Column<int>(type: "integer", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "timestamp(0) with time zone", precision: 0, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp(0) with time zone", precision: 0, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TicketType", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TicketType_Area_AreaId",
                        column: x => x.AreaId,
                        principalTable: "Area",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MenuByAreaAndRole",
                columns: table => new
                {
                    RoleId = table.Column<Guid>(type: "uuid", nullable: false),
                    MenuId = table.Column<int>(type: "integer", nullable: false),
                    AreaId = table.Column<int>(type: "integer", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "timestamp(0) with time zone", precision: 0, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp(0) with time zone", precision: 0, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuByAreaAndRole", x => new { x.RoleId, x.MenuId, x.AreaId });
                    table.ForeignKey(
                        name: "FK_MenuByAreaAndRole_Area_AreaId",
                        column: x => x.AreaId,
                        principalTable: "Area",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MenuByAreaAndRole_Menu_MenuId",
                        column: x => x.MenuId,
                        principalTable: "Menu",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MenuByAreaAndRole_Role_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RoleId = table.Column<Guid>(type: "uuid", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RoleClaims_Role_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    EmployeeNumber = table.Column<string>(type: "text", nullable: true),
                    FirstName = table.Column<string>(type: "text", nullable: true),
                    LastName = table.Column<string>(type: "text", nullable: true),
                    DocumentNumber = table.Column<string>(type: "text", nullable: true),
                    UserStatusId = table.Column<int>(type: "integer", nullable: false),
                    AreaId = table.Column<int>(type: "integer", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "timestamp(0) with time zone", precision: 0, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp(0) with time zone", precision: 0, nullable: true),
                    QueuePosition = table.Column<int>(type: "integer", nullable: false),
                    UserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    PasswordHash = table.Column<string>(type: "text", nullable: true),
                    SecurityStamp = table.Column<string>(type: "text", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true),
                    PhoneNumber = table.Column<string>(type: "text", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                    table.ForeignKey(
                        name: "FK_User_Area_AreaId",
                        column: x => x.AreaId,
                        principalTable: "Area",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_User_UserStatus_UserStatusId",
                        column: x => x.UserStatusId,
                        principalTable: "UserStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AgentLeave",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    StartDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    EndDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    AgentId = table.Column<Guid>(type: "uuid", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "timestamp(0) with time zone", precision: 0, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp(0) with time zone", precision: 0, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AgentLeave", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AgentLeave_User_AgentId",
                        column: x => x.AgentId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AgentTicketType",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    AgentId = table.Column<Guid>(type: "uuid", nullable: false),
                    TicketTypeId = table.Column<int>(type: "integer", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "timestamp(0) with time zone", precision: 0, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp(0) with time zone", precision: 0, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AgentTicketType", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AgentTicketType_TicketType_TicketTypeId",
                        column: x => x.TicketTypeId,
                        principalTable: "TicketType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AgentTicketType_User_AgentId",
                        column: x => x.AgentId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Claims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Claims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Claims_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Logins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    ProviderKey = table.Column<string>(type: "text", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "text", nullable: true),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Logins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_Logins_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Value = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_Tokens_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    RoleId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_UserRoles_Role_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRoles_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Area",
                columns: new[] { "Id", "CreationDate", "ModifiedDate", "Name" },
                values: new object[] { 1, new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(475), null, "DISCAPACIDAD" });

            migrationBuilder.InsertData(
                table: "EmailTemplates",
                columns: new[] { "Id", "CreationDate", "EmailHtml", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(651), "<!DOCTYPE html><html><head><meta charset='UTF-8'><style>body {font-family: Arial, sans-serif;color: #333;background-color: #f4f4f4;margin: 0;padding: 0;} .container {width: 100%;max-width: 600px;margin: auto;padding: 20px;background: #fff;border-radius: 8px;box-shadow: 0 2px 4px rgba(0, 0, 0, 0.1);} h1 {color: #0056b3;} .button {display: inline-block;padding: 10px 20px;font-size: 16px;color: #fff;background-color: #007bff;text-decoration: none;border-radius: 5px;margin-top: 20px;} .footer {margin-top: 20px;font-size: 14px;color: #777;text-align: center;}</style></head><body><div class='container'><h1>¡Hola!</h1><p>Se ha solicitado la creación de un nuevo usuario </p><p> Nombre y Apellido: {firstName} {lastName}</p> <p>Legajo: {employeeNumber} </p><p>Recuerde iniciar sesión para validar usuario y asignar area y rol correspondiente.</p><div class='footer'><p>&copy; 2024 MDQ Digital. Todos los derechos reservados.</p></div></div></body></html>", null, "Template de Solicitud de Acceso al Sistema" },
                    { 2, new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(652), "<!DOCTYPE html><html><head><meta charset='UTF-8'><style>body {font-family: Arial, sans-serif;color: #333;background-color: #f4f4f4;margin: 0;padding: 0;}.container {width: 100%;max-width: 600px;margin: auto;padding: 20px;background: #fff;border-radius: 8px;box-shadow: 0 2px 4px rgba(0, 0, 0, 0.1);}h1 {color: #0056b3;}.button {display: inline-block;padding: 10px 20px;font-size: 16px;color: #fff;background-color: #007bff;text-decoration: none;border-radius: 5px;margin-top: 20px;}.footer {margin-top: 20px;font-size: 14px;color: #777;text-align: center;}</style></head><body><div class='container'><h1>¡Hola!</h1><p>Gracias por ser parte de <strong>MDQ Digital</strong>. <p>Nombre de Usuario: {userName}</p> <p>Contraseña temporal: {password}</p>  <strong>Te recomendamos modificar la contraseña luego del primer acceso! </strong> <div class='footer'><p>&copy; 2024 MDQ Digital. Todos los derechos reservados.</p></div></div></body></html>", null, "Template de Envio de Credenciales" },
                    { 3, new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(654), "<!DOCTYPE html><html><head><meta charset='UTF-8'><style>body {font-family: Arial, sans-serif;color: #333;background-color: #f4f4f4;margin: 0;padding: 0;} .container {width: 100%;max-width: 600px;margin: auto;padding: 20px;background: #fff;border-radius: 8px;box-shadow: 0 2px 4px rgba(0, 0, 0, 0.1);} h1 {color: #0056b3;} .button {display: inline-block;padding: 10px 20px;font-size: 16px;color: #fff;background-color: #007bff;text-decoration: none;border-radius: 5px;margin-top: 20px;} .footer {margin-top: 20px;font-size: 14px;color: #777;text-align: center;}</style></head><body><div class='container'><h1>¡Hola!</h1><p><strong>MDQ Digital</strong>. </p><p>El empleado: {employeeNumber}</p><p>Solicito el reseteo de su contraseña.</p><div class='footer'><p>&copy; 2024 MDQ Digital. Todos los derechos reservados.</p></div></div></body></html>", null, "Template de Solicitud de Reseteo de Contraseña" }
                });

            migrationBuilder.InsertData(
                table: "Menu",
                columns: new[] { "Id", "CreationDate", "Icon", "IsActive", "Label", "ModifiedDate", "Name", "Order", "ParentMenuId", "Url" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(1446), "null", true, "Mis Tramites", null, "null", 1, null, "null" },
                    { 26, new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(1522), "null", true, "Todos los Tramites", null, "null", 2, null, "null" }
                });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "CreationDate", "ModifiedDate", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000001"), null, new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(7359), null, "ADMIN", "ADMIN" },
                    { new Guid("00000000-0000-0000-0000-000000000002"), null, new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(7383), null, "AGENTE", "AGENTE" },
                    { new Guid("00000000-0000-0000-0000-000000000003"), null, new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(7386), null, "SUPERVISOR", "SUPERVISOR" }
                });

            migrationBuilder.InsertData(
                table: "UserStatus",
                columns: new[] { "Id", "CreationDate", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(6925), null, "ACTIVO" },
                    { 2, new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(6927), null, "INACTIVO" },
                    { 3, new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(6928), null, "BLOQUEADO" },
                    { 4, new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(6929), null, "ELIMINADO" },
                    { 5, new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(6930), null, "SOLICITA BLANQUEO DE CONTRASEÑA" },
                    { 6, new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(6931), null, "SOLICITA ACCESO A CUENTA" }
                });

            migrationBuilder.InsertData(
                table: "Menu",
                columns: new[] { "Id", "CreationDate", "Icon", "IsActive", "Label", "ModifiedDate", "Name", "Order", "ParentMenuId", "Url" },
                values: new object[,]
                {
                    { 2, new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(1449), "null", true, "CUD", null, "null", 1, 1, "null" },
                    { 10, new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(1471), "null", true, "SUBE", null, "null", 1, 1, "null" },
                    { 19, new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(1502), "null", true, "Espacio de estacionamiento", null, "null", 1, 1, "null" },
                    { 27, new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(1524), "null", true, "CUD", null, "null", 1, 26, "null" },
                    { 35, new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(1546), "null", true, "SUBE", null, "null", 1, 26, "null" },
                    { 44, new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(1636), "null", true, "Espacio de Estacionamiento", null, "null", 1, 26, "null" }
                });

            migrationBuilder.InsertData(
                table: "MenuByAreaAndRole",
                columns: new[] { "AreaId", "MenuId", "RoleId", "CreationDate", "ModifiedDate" },
                values: new object[,]
                {
                    { 1, 1, new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(841), null },
                    { 1, 26, new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(904), null },
                    { 1, 26, new Guid("00000000-0000-0000-0000-000000000003"), new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(1012), null }
                });

            migrationBuilder.InsertData(
                table: "TicketType",
                columns: new[] { "Id", "AreaId", "CreationDate", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(1897), null, "CUD" },
                    { 2, 1, new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(1898), null, "SUBE" },
                    { 3, 1, new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(1899), null, "PARKING" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "AreaId", "ConcurrencyStamp", "CreationDate", "DocumentNumber", "Email", "EmailConfirmed", "EmployeeNumber", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "ModifiedDate", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "QueuePosition", "SecurityStamp", "TwoFactorEnabled", "UserName", "UserStatusId" },
                values: new object[,]
                {
                    { new Guid("18d14490-91c1-4ba6-843c-9b501d187049"), 0, 1, "d837d926-6935-4a9c-8ab9-9d8edd1f5dcf", new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(5987), "41139455", "cristian.fer.mel@gmail.com", false, "882536", "John", "Supervisor", false, null, null, "CRISTIAN.FER.MEL@GMAIL.COM", "41139455", "AQAAAAIAAYagAAAAECaxMkXFEcpSvk45sqf5io8dB1O8858sxcYP2ISQR2MfUcxLdeJf4wlEebFyvspT9A==", null, false, 0, "XWDC3VQU5TCMCIJBNHECVHJYLL3OTI34", false, "41139455", 1 },
                    { new Guid("18d14490-91c1-4ba6-843c-9b501d187050"), 0, 1, "d837d926-6935-4a9c-8ab9-9d8edd1f5dcf", new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(5994), "17027227", "c.fernandez.melian@hotmail.com", false, "882537", "John", "Agente Uno", false, null, null, "c.fernandez.melian@hotmail.com", "17027227", "AQAAAAIAAYagAAAAECaxMkXFEcpSvk45sqf5io8dB1O8858sxcYP2ISQR2MfUcxLdeJf4wlEebFyvspT9A==", null, false, 0, "XWDC3VQU5TCMCIJBNHECVHJYLL3OTI34", false, "17027227", 1 },
                    { new Guid("18d14490-91c1-4ba6-843c-9b501d187051"), 0, 1, "d837d926-6935-4a9c-8ab9-9d8edd1f5dcf", new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(6001), "21004652", "leandro.gomez.pae@gmail.com", false, "882538", "John", "Agente Dos", false, null, null, "leandro.gomez.pae@gmail.com", "21004652", "AQAAAAIAAYagAAAAECaxMkXFEcpSvk45sqf5io8dB1O8858sxcYP2ISQR2MfUcxLdeJf4wlEebFyvspT9A==", null, false, 0, "XWDC3VQU5TCMCIJBNHECVHJYLL3OTI34", false, "21004652", 1 },
                    { new Guid("ab76bc84-45e2-4ce5-bcc5-9d6a5aa4e21b"), 0, null, null, new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(5969), "44413552", "cristian.fernandez@avalith.net", false, "123456", "admin", "admin", false, null, null, "CRISTIAN.FERNANDEZ@AVALITH.NET", "44413552", "AQAAAAIAAYagAAAAECaxMkXFEcpSvk45sqf5io8dB1O8858sxcYP2ISQR2MfUcxLdeJf4wlEebFyvspT9A==", null, false, 0, "6df4f47c-f703-4764-bdff-81a3d2c021d0", false, "44413552", 1 }
                });

            migrationBuilder.InsertData(
                table: "AgentTicketType",
                columns: new[] { "Id", "AgentId", "CreationDate", "ModifiedDate", "TicketTypeId" },
                values: new object[,]
                {
                    { new Guid("ab76bc84-45e2-4ce5-bcc5-9d6a5aa4e17a"), new Guid("18d14490-91c1-4ba6-843c-9b501d187050"), new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(117), null, 1 },
                    { new Guid("ab76bc84-45e2-4ce5-bcc5-9d6a5aa4e17b"), new Guid("18d14490-91c1-4ba6-843c-9b501d187050"), new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(123), null, 2 },
                    { new Guid("ab76bc84-45e2-4ce5-bcc5-9d6a5aa4e17c"), new Guid("18d14490-91c1-4ba6-843c-9b501d187051"), new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(126), null, 1 },
                    { new Guid("ab76bc84-45e2-4ce5-bcc5-9d6a5aa4e17d"), new Guid("18d14490-91c1-4ba6-843c-9b501d187051"), new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(128), null, 2 },
                    { new Guid("ab76bc84-45e2-4ce5-bcc5-9d6a5aa4e17e"), new Guid("18d14490-91c1-4ba6-843c-9b501d187051"), new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(130), null, 3 }
                });

            migrationBuilder.InsertData(
                table: "Menu",
                columns: new[] { "Id", "CreationDate", "Icon", "IsActive", "Label", "ModifiedDate", "Name", "Order", "ParentMenuId", "Url" },
                values: new object[,]
                {
                    { 3, new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(1451), "null", true, "Nuevos", null, "null", 1, 2, "/search-by?TicketStatusId=1&AssignedToMe=true&ServiceName=DISCAPACIDAD&TicketTypeId=1" },
                    { 4, new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(1453), "null", true, "En proceso", null, "null", 1, 2, "null" },
                    { 7, new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(1459), "null", true, "Cerrado", null, "null", 1, 2, "/search-by?TicketStatusId=8&AssignedToMe=true&ServiceName=DISCAPACIDAD&TicketTypeId=1" },
                    { 8, new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(1467), "null", true, "Cancelado", null, "null", 1, 2, "/search-by?TicketStatusId=8&AssignedToMe=true&ServiceName=DISCAPACIDAD&TicketTypeId=1" },
                    { 9, new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(1469), "null", true, "Acceso SNR", null, "null", 1, 2, "null" },
                    { 11, new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(1473), "null", true, "Nuevos", null, "null", 1, 10, "/search-by?TicketStatusId=1&AssignedToMe=true&ServiceName=DISCAPACIDAD&TicketTypeId=2" },
                    { 12, new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(1480), "null", true, "En proceso", null, "null", 1, 10, "null" },
                    { 15, new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(1488), "null", true, "Cerrado", null, "null", 1, 10, "null" },
                    { 16, new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(1496), "null", true, "Cancelado", null, "null", 1, 10, "/search-by?TicketStatusId=8&AssignedToMe=true&ServiceName=DISCAPACIDAD&TicketTypeId=2" },
                    { 17, new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(1498), "null", true, "Acceso UTE", null, "null", 1, 10, "null" },
                    { 18, new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(1500), "null", true, "Acceso Sube", null, "null", 1, 10, "null" },
                    { 20, new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(1503), "null", true, "Nuevos", null, "null", 1, 19, "/search-by?TicketStatusId=1&AssignedToMe=true&ServiceName=DISCAPACIDAD&TicketTypeId=3" },
                    { 21, new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(1505), "null", true, "En proceso", null, "null", 1, 19, "null" },
                    { 24, new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(1512), "null", true, "Cerrado", null, "null", 1, 19, "null" },
                    { 25, new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(1520), "null", true, "Cancelado", null, "null", 1, 19, "/search-by?TicketStatusId=8&AssignedToMe=true&ServiceName=DISCAPACIDAD&TicketTypeId=3" },
                    { 28, new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(1526), "null", true, "Nuevo", null, "null", 1, 27, "/search-by?TicketStatusId=1&ServiceName=DISCAPACIDAD&TicketTypeId=1" },
                    { 29, new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(1528), "null", true, "En proceso", null, "null", 1, 27, "null" },
                    { 32, new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(1534), "null", true, "Cerrado", null, "null", 1, 27, "null" },
                    { 33, new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(1542), "null", true, "Cancelado", null, "null", 1, 27, "/search-by?TicketStatusId=8&ServiceName=DISCAPACIDAD&TicketTypeId=1" },
                    { 34, new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(1543), "null", true, "Acceso SNR", null, "null", 1, 27, "null" },
                    { 36, new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(1548), "null", true, "Nuevos", null, "null", 1, 35, "/search-by?TicketStatusId=1&ServiceName=DISCAPACIDAD&TicketTypeId=2" },
                    { 37, new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(1550), "null", true, "En proceso", null, "null", 1, 35, "null" },
                    { 40, new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(1617), "null", true, "Cerrado", null, "null", 1, 35, "null" },
                    { 41, new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(1625), "null", true, "Cancelado", null, "null", 1, 35, "/search-by?TicketStatusId=8&ServiceName=DISCAPACIDAD&TicketTypeId=2" },
                    { 42, new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(1627), "null", true, "Acceso UTE", null, "null", 1, 35, "null" },
                    { 43, new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(1629), "null", true, "Acceso SUBE", null, "null", 1, 35, "null" },
                    { 45, new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(1638), "null", true, "Nuevos", null, "null", 1, 44, "/search-by?TicketStatusId=1&ServiceName=DISCAPACIDAD&TicketTypeId=3" },
                    { 46, new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(1640), "null", true, "En proceso", null, "null", 1, 44, "null" }
                });

            migrationBuilder.InsertData(
                table: "MenuByAreaAndRole",
                columns: new[] { "AreaId", "MenuId", "RoleId", "CreationDate", "ModifiedDate" },
                values: new object[,]
                {
                    { 1, 2, new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(845), null },
                    { 1, 10, new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(871), null },
                    { 1, 19, new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(890), null },
                    { 1, 27, new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(907), null },
                    { 1, 35, new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(923), null },
                    { 1, 44, new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(993), null },
                    { 1, 27, new Guid("00000000-0000-0000-0000-000000000003"), new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(1014), null },
                    { 1, 35, new Guid("00000000-0000-0000-0000-000000000003"), new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(1029), null },
                    { 1, 44, new Guid("00000000-0000-0000-0000-000000000003"), new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(1047), null }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000003"), new Guid("18d14490-91c1-4ba6-843c-9b501d187049") },
                    { new Guid("00000000-0000-0000-0000-000000000002"), new Guid("18d14490-91c1-4ba6-843c-9b501d187050") },
                    { new Guid("00000000-0000-0000-0000-000000000002"), new Guid("18d14490-91c1-4ba6-843c-9b501d187051") },
                    { new Guid("00000000-0000-0000-0000-000000000001"), new Guid("ab76bc84-45e2-4ce5-bcc5-9d6a5aa4e21b") }
                });

            migrationBuilder.InsertData(
                table: "Menu",
                columns: new[] { "Id", "CreationDate", "Icon", "IsActive", "Label", "ModifiedDate", "Name", "Order", "ParentMenuId", "Url" },
                values: new object[,]
                {
                    { 5, new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(1455), "null", true, "Vecino", null, "null", 1, 4, "/search-by?TicketStatusId=2&AssignedToMe=true&ServiceName=DISCAPACIDAD&TicketTypeId=1" },
                    { 6, new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(1457), "null", true, "Agente", null, "null", 1, 4, "/search-by?TicketStatusId=3&AssignedToMe=true&ServiceName=DISCAPACIDAD&TicketTypeId=1" },
                    { 13, new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(1482), "null", true, "Vecino", null, "null", 1, 12, "/search-by?TicketStatusId=2&AssignedToMe=true&ServiceName=DISCAPACIDAD&TicketTypeId=2" },
                    { 14, new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(1485), "null", true, "Agente", null, "null", 1, 12, "/search-by?TicketStatusId=3&AssignedToMe=true&ServiceName=DISCAPACIDAD&TicketTypeId=2" },
                    { 22, new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(1507), "null", true, "Vecino", null, "null", 1, 21, "/search-by?TicketStatusId=2&AssignedToMe=true&ServiceName=DISCAPACIDAD&TicketTypeId=3" },
                    { 23, new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(1510), "null", true, "Agente", null, "null", 1, 21, "/search-by?TicketStatusId=3&AssignedToMe=true&ServiceName=DISCAPACIDAD&TicketTypeId=3" },
                    { 30, new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(1530), "null", true, "Vecino", null, "null", 1, 29, "/search-by?TicketStatusId=2&ServiceName=DISCAPACIDAD&TicketTypeId=1" },
                    { 31, new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(1532), "null", true, "Agente", null, "null", 1, 29, "/search-by?TicketStatusId=3&ServiceName=DISCAPACIDAD&TicketTypeId=1" },
                    { 38, new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(1558), "null", true, "Vecino", null, "null", 1, 37, "/search-by?TicketStatusId=2&ServiceName=DISCAPACIDAD&TicketTypeId=2" },
                    { 39, new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(1615), "null", true, "Agente", null, "null", 1, 37, "/search-by?TicketStatusId=3&ServiceName=DISCAPACIDAD&TicketTypeId=2" },
                    { 47, new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(1641), "null", true, "Vecino", null, "null", 1, 46, "/search-by?TicketStatusId=2&ServiceName=DISCAPACIDAD&TicketTypeId=3" },
                    { 48, new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(1643), "null", true, "Agente", null, "null", 1, 46, "/search-by?TicketStatusId=3&ServiceName=DISCAPACIDAD&TicketTypeId=3" },
                    { 49, new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(1645), "null", true, "Cerrado", null, "null", 1, 46, "null" },
                    { 50, new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(1653), "null", true, "Cancelado", null, "null", 1, 46, "/search-by?TicketStatusId=8&ServiceName=DISCAPACIDAD&TicketTypeId=3" },
                    { 51, new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(1461), "null", true, "Falta de Respuesta", null, "null", 1, 7, "/search-by?TicketStatusId=5&AssignedToMe=true&ServiceName=DISCAPACIDAD&TicketTypeId=1" },
                    { 52, new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(1463), "null", true, "Cerrado Otorgado", null, "null", 1, 7, "/search-by?TicketStatusId=6&AssignedToMe=true&ServiceName=DISCAPACIDAD&TicketTypeId=1" },
                    { 53, new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(1465), "null", true, "Cerrado Denegado", null, "null", 1, 7, "/search-by?TicketStatusId=7&AssignedToMe=true&ServiceName=DISCAPACIDAD&TicketTypeId=1" },
                    { 54, new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(1490), "null", true, "Falta de Respuesta", null, "null", 1, 15, "/search-by?TicketStatusId=5&AssignedToMe=true&ServiceName=DISCAPACIDAD&TicketTypeId=2" },
                    { 55, new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(1492), "null", true, "Cerrado Otorgado", null, "null", 1, 15, "/search-by?TicketStatusId=6&AssignedToMe=true&ServiceName=DISCAPACIDAD&TicketTypeId=2" },
                    { 56, new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(1494), "null", true, "Cerrado Denegado", null, "null", 1, 15, "/search-by?TicketStatusId=7&AssignedToMe=true&ServiceName=DISCAPACIDAD&TicketTypeId=2" },
                    { 57, new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(1514), "null", true, "Falta de Respuesta", null, "null", 1, 24, "/search-by?TicketStatusId=5&AssignedToMe=true&ServiceName=DISCAPACIDAD&TicketTypeId=3" },
                    { 58, new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(1516), "null", true, "Cerrado Otorgado", null, "null", 1, 24, "/search-by?TicketStatusId=6&AssignedToMe=true&ServiceName=DISCAPACIDAD&TicketTypeId=3" },
                    { 59, new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(1518), "null", true, "Cerrado Denegado", null, "null", 1, 24, "/search-by?TicketStatusId=7&AssignedToMe=true&ServiceName=DISCAPACIDAD&TicketTypeId=3" },
                    { 60, new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(1536), "null", true, "Falta de Respuesta", null, "null", 1, 32, "/search-by?TicketStatusId=5&ServiceName=DISCAPACIDAD&TicketTypeId=1" },
                    { 61, new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(1538), "null", true, "Cerrado Otorgado", null, "null", 1, 32, "/search-by?TicketStatusId=6&ServiceName=DISCAPACIDAD&TicketTypeId=1" },
                    { 62, new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(1540), "null", true, "Cerrado Denegado", null, "null", 1, 32, "/search-by?TicketStatusId=7&ServiceName=DISCAPACIDAD&TicketTypeId=1" },
                    { 63, new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(1619), "null", true, "Falta de Respuesta", null, "null", 1, 40, "/search-by?TicketStatusId=5&ServiceName=DISCAPACIDAD&TicketTypeId=2" },
                    { 64, new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(1621), "null", true, "Cerrado Otorgado", null, "null", 1, 40, "/search-by?TicketStatusId=6&ServiceName=DISCAPACIDAD&TicketTypeId=2" },
                    { 65, new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(1623), "null", true, "Cerrado Denegado", null, "null", 1, 40, "/search-by?TicketStatusId=7&ServiceName=DISCAPACIDAD&TicketTypeId=2" }
                });

            migrationBuilder.InsertData(
                table: "MenuByAreaAndRole",
                columns: new[] { "AreaId", "MenuId", "RoleId", "CreationDate", "ModifiedDate" },
                values: new object[,]
                {
                    { 1, 3, new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(847), null },
                    { 1, 4, new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(855), null },
                    { 1, 7, new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(862), null },
                    { 1, 8, new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(867), null },
                    { 1, 9, new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(869), null },
                    { 1, 11, new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(873), null },
                    { 1, 12, new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(876), null },
                    { 1, 15, new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(881), null },
                    { 1, 16, new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(883), null },
                    { 1, 17, new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(887), null },
                    { 1, 18, new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(889), null },
                    { 1, 20, new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(892), null },
                    { 1, 21, new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(894), null },
                    { 1, 24, new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(900), null },
                    { 1, 25, new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(901), null },
                    { 1, 28, new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(909), null },
                    { 1, 29, new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(911), null },
                    { 1, 32, new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(917), null },
                    { 1, 33, new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(919), null },
                    { 1, 34, new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(921), null },
                    { 1, 36, new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(925), null },
                    { 1, 37, new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(932), null },
                    { 1, 40, new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(984), null },
                    { 1, 41, new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(986), null },
                    { 1, 42, new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(988), null },
                    { 1, 43, new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(992), null },
                    { 1, 45, new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(995), null },
                    { 1, 46, new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(997), null },
                    { 1, 28, new Guid("00000000-0000-0000-0000-000000000003"), new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(1016), null },
                    { 1, 29, new Guid("00000000-0000-0000-0000-000000000003"), new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(1017), null },
                    { 1, 32, new Guid("00000000-0000-0000-0000-000000000003"), new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(1024), null },
                    { 1, 33, new Guid("00000000-0000-0000-0000-000000000003"), new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(1026), null },
                    { 1, 34, new Guid("00000000-0000-0000-0000-000000000003"), new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(1028), null },
                    { 1, 36, new Guid("00000000-0000-0000-0000-000000000003"), new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(1031), null },
                    { 1, 37, new Guid("00000000-0000-0000-0000-000000000003"), new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(1033), null },
                    { 1, 40, new Guid("00000000-0000-0000-0000-000000000003"), new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(1038), null },
                    { 1, 41, new Guid("00000000-0000-0000-0000-000000000003"), new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(1040), null },
                    { 1, 42, new Guid("00000000-0000-0000-0000-000000000003"), new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(1042), null },
                    { 1, 43, new Guid("00000000-0000-0000-0000-000000000003"), new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(1043), null },
                    { 1, 45, new Guid("00000000-0000-0000-0000-000000000003"), new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(1049), null },
                    { 1, 46, new Guid("00000000-0000-0000-0000-000000000003"), new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(1051), null }
                });

            migrationBuilder.InsertData(
                table: "Menu",
                columns: new[] { "Id", "CreationDate", "Icon", "IsActive", "Label", "ModifiedDate", "Name", "Order", "ParentMenuId", "Url" },
                values: new object[,]
                {
                    { 66, new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(1647), "null", true, "Falta de Respuesta", null, "null", 1, 49, "/search-by?TicketStatusId=5&ServiceName=DISCAPACIDAD&TicketTypeId=3" },
                    { 67, new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(1649), "null", true, "Cerrado Otorgado", null, "null", 1, 49, "/search-by?TicketStatusId=6&ServiceName=DISCAPACIDAD&TicketTypeId=3" },
                    { 68, new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(1651), "null", true, "Cerrado Denegado", null, "null", 1, 49, "/search-by?TicketStatusId=7&ServiceName=DISCAPACIDAD&TicketTypeId=3" }
                });

            migrationBuilder.InsertData(
                table: "MenuByAreaAndRole",
                columns: new[] { "AreaId", "MenuId", "RoleId", "CreationDate", "ModifiedDate" },
                values: new object[,]
                {
                    { 1, 5, new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(858), null },
                    { 1, 6, new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(860), null },
                    { 1, 13, new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(878), null },
                    { 1, 14, new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(879), null },
                    { 1, 22, new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(896), null },
                    { 1, 23, new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(898), null },
                    { 1, 30, new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(914), null },
                    { 1, 31, new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(916), null },
                    { 1, 38, new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(934), null },
                    { 1, 39, new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(936), null },
                    { 1, 47, new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(999), null },
                    { 1, 48, new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(1001), null },
                    { 1, 49, new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(1003), null },
                    { 1, 50, new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(1004), null },
                    { 1, 51, new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(1096), null },
                    { 1, 52, new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(1098), null },
                    { 1, 53, new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(1101), null },
                    { 1, 54, new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(1102), null },
                    { 1, 55, new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(1104), null },
                    { 1, 56, new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(1106), null },
                    { 1, 57, new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(1108), null },
                    { 1, 58, new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(1109), null },
                    { 1, 59, new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(1113), null },
                    { 1, 60, new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(1115), null },
                    { 1, 61, new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(1116), null },
                    { 1, 62, new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(1118), null },
                    { 1, 63, new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(1120), null },
                    { 1, 64, new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(1121), null },
                    { 1, 65, new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(1123), null },
                    { 1, 30, new Guid("00000000-0000-0000-0000-000000000003"), new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(1019), null },
                    { 1, 31, new Guid("00000000-0000-0000-0000-000000000003"), new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(1022), null },
                    { 1, 38, new Guid("00000000-0000-0000-0000-000000000003"), new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(1035), null },
                    { 1, 39, new Guid("00000000-0000-0000-0000-000000000003"), new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(1036), null },
                    { 1, 47, new Guid("00000000-0000-0000-0000-000000000003"), new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(1052), null },
                    { 1, 48, new Guid("00000000-0000-0000-0000-000000000003"), new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(1054), null },
                    { 1, 49, new Guid("00000000-0000-0000-0000-000000000003"), new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(1056), null },
                    { 1, 50, new Guid("00000000-0000-0000-0000-000000000003"), new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(1057), null },
                    { 1, 51, new Guid("00000000-0000-0000-0000-000000000003"), new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(1059), null },
                    { 1, 52, new Guid("00000000-0000-0000-0000-000000000003"), new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(1061), null },
                    { 1, 53, new Guid("00000000-0000-0000-0000-000000000003"), new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(1062), null },
                    { 1, 54, new Guid("00000000-0000-0000-0000-000000000003"), new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(1064), null },
                    { 1, 55, new Guid("00000000-0000-0000-0000-000000000003"), new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(1066), null },
                    { 1, 56, new Guid("00000000-0000-0000-0000-000000000003"), new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(1068), null },
                    { 1, 57, new Guid("00000000-0000-0000-0000-000000000003"), new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(1071), null },
                    { 1, 58, new Guid("00000000-0000-0000-0000-000000000003"), new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(1072), null },
                    { 1, 59, new Guid("00000000-0000-0000-0000-000000000003"), new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(1074), null },
                    { 1, 60, new Guid("00000000-0000-0000-0000-000000000003"), new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(1076), null },
                    { 1, 61, new Guid("00000000-0000-0000-0000-000000000003"), new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(1078), null },
                    { 1, 62, new Guid("00000000-0000-0000-0000-000000000003"), new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(1079), null },
                    { 1, 63, new Guid("00000000-0000-0000-0000-000000000003"), new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(1081), null },
                    { 1, 64, new Guid("00000000-0000-0000-0000-000000000003"), new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(1083), null },
                    { 1, 65, new Guid("00000000-0000-0000-0000-000000000003"), new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(1090), null },
                    { 1, 66, new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(1126), null },
                    { 1, 67, new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(1128), null },
                    { 1, 68, new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(1129), null },
                    { 1, 66, new Guid("00000000-0000-0000-0000-000000000003"), new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(1091), null },
                    { 1, 67, new Guid("00000000-0000-0000-0000-000000000003"), new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(1093), null },
                    { 1, 68, new Guid("00000000-0000-0000-0000-000000000003"), new DateTime(2024, 12, 19, 15, 20, 54, 887, DateTimeKind.Utc).AddTicks(1095), null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AgentLeave_AgentId",
                table: "AgentLeave",
                column: "AgentId");

            migrationBuilder.CreateIndex(
                name: "IX_AgentTicketType_AgentId",
                table: "AgentTicketType",
                column: "AgentId");

            migrationBuilder.CreateIndex(
                name: "IX_AgentTicketType_TicketTypeId",
                table: "AgentTicketType",
                column: "TicketTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Area_Name",
                table: "Area",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Claims_UserId",
                table: "Claims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Logins_UserId",
                table: "Logins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Menu_ParentMenuId",
                table: "Menu",
                column: "ParentMenuId");

            migrationBuilder.CreateIndex(
                name: "IX_MenuByAreaAndRole_AreaId",
                table: "MenuByAreaAndRole",
                column: "AreaId");

            migrationBuilder.CreateIndex(
                name: "IX_MenuByAreaAndRole_MenuId",
                table: "MenuByAreaAndRole",
                column: "MenuId");

            migrationBuilder.CreateIndex(
                name: "IX_Role_Name",
                table: "Role",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "Role",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_RoleClaims_RoleId",
                table: "RoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_TicketType_AreaId",
                table: "TicketType",
                column: "AreaId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "User",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "IX_User_AreaId",
                table: "User",
                column: "AreaId");

            migrationBuilder.CreateIndex(
                name: "IX_User_DocumentNumber",
                table: "User",
                column: "DocumentNumber",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_User_Email",
                table: "User",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_User_EmployeeNumber",
                table: "User",
                column: "EmployeeNumber",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_User_UserName",
                table: "User",
                column: "UserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_User_UserStatusId",
                table: "User",
                column: "UserStatusId");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "User",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_RoleId",
                table: "UserRoles",
                column: "RoleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AgentLeave");

            migrationBuilder.DropTable(
                name: "AgentTicketType");

            migrationBuilder.DropTable(
                name: "Claims");

            migrationBuilder.DropTable(
                name: "EmailTemplates");

            migrationBuilder.DropTable(
                name: "Logins");

            migrationBuilder.DropTable(
                name: "MenuByAreaAndRole");

            migrationBuilder.DropTable(
                name: "RevokedRefreshSessionToken");

            migrationBuilder.DropTable(
                name: "RoleClaims");

            migrationBuilder.DropTable(
                name: "Tokens");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "TicketType");

            migrationBuilder.DropTable(
                name: "Menu");

            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Area");

            migrationBuilder.DropTable(
                name: "UserStatus");
        }
    }
}
