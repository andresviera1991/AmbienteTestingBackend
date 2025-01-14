using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MGP.Audit.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Audit",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    Action = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: false),
                    Timestamp = table.Column<DateTime>(type: "timestamp(0) with time zone", precision: 0, nullable: false),
                    EntityType = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: false),
                    EntityId = table.Column<string>(type: "text", nullable: false),
                    OldValue = table.Column<string>(type: "character varying(2000)", maxLength: 2000, nullable: true),
                    NewValue = table.Column<string>(type: "character varying(2000)", maxLength: 2000, nullable: true),
                    MicroserviceName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Audit", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Audit_Id",
                table: "Audit",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Audit_UserId",
                table: "Audit",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Audit");
        }
    }
}
