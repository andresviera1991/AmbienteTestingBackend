using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MGP.Location.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class StreetsStructure : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Street",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: false),
                    FullName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: false),
                    Source = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: false),
                    Category = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: false),
                    EndHeightRight = table.Column<int>(type: "integer", nullable: false),
                    EndHeightLeft = table.Column<int>(type: "integer", nullable: false),
                    StartHeightRight = table.Column<int>(type: "integer", nullable: false),
                    StartHeightLeft = table.Column<int>(type: "integer", nullable: false),
                    LocalityId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Street", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Street_Locality_LocalityId",
                        column: x => x.LocalityId,
                        principalTable: "Locality",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Street_LocalityId",
                table: "Street",
                column: "LocalityId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Street");
        }
    }
}
