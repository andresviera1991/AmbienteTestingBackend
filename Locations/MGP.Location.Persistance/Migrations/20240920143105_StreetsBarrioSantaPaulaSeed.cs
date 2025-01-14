using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MGP.Location.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class StreetsBarrioSantaPaulaSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Street",
                columns: new[] { "Id", "Category", "EndHeightLeft", "EndHeightRight", "FullName", "LocalityId", "Name", "Source", "StartHeightLeft", "StartHeightRight" },
                values: new object[,]
                {
                    { 635706000005L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357060L, "CALLE SN", "INDEC", 0, 0 },
                    { 635706000010L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357060L, "CALLE SN", "INDEC", 0, 0 },
                    { 635706000015L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357060L, "CALLE SN", "INDEC", 0, 0 },
                    { 635706000020L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357060L, "CALLE SN", "INDEC", 0, 0 },
                    { 635706000025L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357060L, "CALLE SN", "INDEC", 0, 0 },
                    { 635706000030L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357060L, "CALLE SN", "INDEC", 0, 0 },
                    { 635706000035L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357060L, "CALLE SN", "INDEC", 0, 0 },
                    { 635706000040L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357060L, "CALLE SN", "INDEC", 0, 0 },
                    { 635706000045L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357060L, "CALLE SN", "INDEC", 0, 0 },
                    { 635706000050L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357060L, "CALLE SN", "INDEC", 0, 0 },
                    { 635706000055L, "RUTA", 0, 0, "RUTA NACIONAL 226, Buenos Aires, General Pueyrredón", 6357060L, "RUTA NACIONAL 226", "INDEC", 0, 0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635706000005L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635706000010L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635706000015L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635706000020L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635706000025L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635706000030L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635706000035L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635706000040L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635706000045L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635706000050L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635706000055L);
        }
    }
}
