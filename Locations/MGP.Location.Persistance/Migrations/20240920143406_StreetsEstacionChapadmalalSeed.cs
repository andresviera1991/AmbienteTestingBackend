using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MGP.Location.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class StreetsEstacionChapadmalalSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Street",
                columns: new[] { "Id", "Category", "EndHeightLeft", "EndHeightRight", "FullName", "LocalityId", "Name", "Source", "StartHeightLeft", "StartHeightRight" },
                values: new object[,]
                {
                    { 635710000005L, "CALLE", 0, 0, "CALLE 1, Buenos Aires, General Pueyrredón", 6357100L, "CALLE 1", "INDEC", 0, 0 },
                    { 635710000010L, "CALLE", 0, 0, "CALLE 10, Buenos Aires, General Pueyrredón", 6357100L, "CALLE 10", "INDEC", 0, 0 },
                    { 635710000015L, "CALLE", 0, 0, "CALLE 11, Buenos Aires, General Pueyrredón", 6357100L, "CALLE 11", "INDEC", 0, 0 },
                    { 635710000020L, "CALLE", 0, 0, "CALLE 12, Buenos Aires, General Pueyrredón", 6357100L, "CALLE 12", "INDEC", 0, 0 },
                    { 635710000025L, "CALLE", 0, 0, "CALLE 13, Buenos Aires, General Pueyrredón", 6357100L, "CALLE 13", "INDEC", 0, 0 },
                    { 635710000030L, "CALLE", 0, 0, "CALLE 14, Buenos Aires, General Pueyrredón", 6357100L, "CALLE 14", "INDEC", 0, 0 },
                    { 635710000035L, "CALLE", 0, 0, "CALLE 16, Buenos Aires, General Pueyrredón", 6357100L, "CALLE 16", "INDEC", 0, 0 },
                    { 635710000040L, "CALLE", 0, 0, "CALLE 18, Buenos Aires, General Pueyrredón", 6357100L, "CALLE 18", "INDEC", 0, 0 },
                    { 635710000045L, "CALLE", 0, 0, "CALLE 2, Buenos Aires, General Pueyrredón", 6357100L, "CALLE 2", "INDEC", 0, 0 },
                    { 635710000050L, "CALLE", 0, 0, "CALLE 20, Buenos Aires, General Pueyrredón", 6357100L, "CALLE 20", "INDEC", 0, 0 },
                    { 635710000055L, "CALLE", 0, 0, "CALLE 22, Buenos Aires, General Pueyrredón", 6357100L, "CALLE 22", "INDEC", 0, 0 },
                    { 635710000060L, "CALLE", 0, 0, "CALLE 24, Buenos Aires, General Pueyrredón", 6357100L, "CALLE 24", "INDEC", 0, 0 },
                    { 635710000065L, "CALLE", 0, 0, "CALLE 26, Buenos Aires, General Pueyrredón", 6357100L, "CALLE 26", "INDEC", 0, 0 },
                    { 635710000070L, "CALLE", 0, 0, "CALLE 28, Buenos Aires, General Pueyrredón", 6357100L, "CALLE 28", "INDEC", 0, 0 },
                    { 635710000075L, "CALLE", 0, 0, "CALLE 3, Buenos Aires, General Pueyrredón", 6357100L, "CALLE 3", "INDEC", 0, 0 },
                    { 635710000080L, "CALLE", 0, 0, "CALLE 30, Buenos Aires, General Pueyrredón", 6357100L, "CALLE 30", "INDEC", 0, 0 },
                    { 635710000085L, "CALLE", 0, 0, "CALLE 32, Buenos Aires, General Pueyrredón", 6357100L, "CALLE 32", "INDEC", 0, 0 },
                    { 635710000090L, "CALLE", 0, 0, "CALLE 34, Buenos Aires, General Pueyrredón", 6357100L, "CALLE 34", "INDEC", 0, 0 },
                    { 635710000095L, "CALLE", 0, 0, "CALLE 4, Buenos Aires, General Pueyrredón", 6357100L, "CALLE 4", "INDEC", 0, 0 },
                    { 635710000100L, "CALLE", 0, 0, "CALLE 5, Buenos Aires, General Pueyrredón", 6357100L, "CALLE 5", "INDEC", 0, 0 },
                    { 635710000105L, "CALLE", 0, 0, "CALLE 6, Buenos Aires, General Pueyrredón", 6357100L, "CALLE 6", "INDEC", 0, 0 },
                    { 635710000110L, "CALLE", 0, 0, "CALLE 7, Buenos Aires, General Pueyrredón", 6357100L, "CALLE 7", "INDEC", 0, 0 },
                    { 635710000115L, "CALLE", 0, 0, "CALLE 8, Buenos Aires, General Pueyrredón", 6357100L, "CALLE 8", "INDEC", 0, 0 },
                    { 635710000120L, "CALLE", 0, 0, "CALLE 9, Buenos Aires, General Pueyrredón", 6357100L, "CALLE 9", "INDEC", 0, 0 },
                    { 635710000125L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357100L, "CALLE SN", "INDEC", 0, 0 },
                    { 635710000130L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357100L, "CALLE SN", "INDEC", 0, 0 },
                    { 635710000135L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357100L, "CALLE SN", "INDEC", 0, 0 },
                    { 635710000140L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357100L, "CALLE SN", "INDEC", 0, 0 },
                    { 635710000145L, "CALLE", 0, 0, "D DOMINGUEZ, Buenos Aires, General Pueyrredón", 6357100L, "D DOMINGUEZ", "INDEC", 0, 0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635710000005L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635710000010L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635710000015L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635710000020L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635710000025L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635710000030L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635710000035L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635710000040L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635710000045L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635710000050L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635710000055L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635710000060L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635710000065L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635710000070L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635710000075L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635710000080L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635710000085L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635710000090L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635710000095L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635710000100L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635710000105L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635710000110L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635710000115L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635710000120L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635710000125L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635710000130L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635710000135L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635710000140L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635710000145L);
        }
    }
}
