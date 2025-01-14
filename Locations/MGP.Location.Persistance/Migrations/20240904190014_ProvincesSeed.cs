using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MGP.Location.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class ProvincesSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Province",
                columns: new[] { "Id", "Category", "CentroidLat", "CentroidLon", "FullName", "IsoId", "IsoName", "Name", "Source" },
                values: new object[,]
                {
                    { 2, "Ciudad Autónoma", -34.614442065430097, -58.445876325091596, "Ciudad Autónoma de Buenos Aires", "AR-C", "Ciudad Autónoma de Buenos Aires", "Ciudad Autónoma de Buenos Aires", "IGN" },
                    { 6, "Provincia", -36.677392076082299, -60.5584771084959, "Provincia de Buenos Aires", "AR-B", "Buenos Aires", "Buenos Aires", "IGN" },
                    { 10, "Provincia", -27.3359537960762, -66.947897245129496, "Provincia de Catamarca", "AR-K", "Catamarca", "Catamarca", "IGN" },
                    { 14, "Provincia", -32.144799387385902, -63.801973466573003, "Provincia de Córdoba", "AR-X", "Córdoba", "Córdoba", "IGN" },
                    { 18, "Provincia", -28.7742044813623, -57.801081860333099, "Provincia de Corrientes", "AR-W", "Corrientes", "Corrientes", "IGN" },
                    { 22, "Provincia", -26.386987183586701, -60.765116260356002, "Provincia del Chaco", "AR-H", "Chaco", "Chaco", "IGN" },
                    { 26, "Provincia", -43.788627138908303, -68.526736333981802, "Provincia del Chubut", "AR-U", "Chubut", "Chubut", "IGN" },
                    { 30, "Provincia", -32.058927893855802, -59.201262616496003, "Provincia de Entre Ríos", "AR-E", "Entre Ríos", "Entre Ríos", "IGN" },
                    { 34, "Provincia", -24.895087176148099, -59.932190112164697, "Provincia de Formosa", "AR-P", "Formosa", "Formosa", "IGN" },
                    { 38, "Provincia", -23.319975061658301, -65.764423919292, "Provincia de Jujuy", "AR-Y", "Jujuy", "Jujuy", "IGN" },
                    { 42, "Provincia", -37.1350652212898, -65.447643999021295, "Provincia de La Pampa", "AR-L", "La Pampa", "La Pampa", "IGN" },
                    { 46, "Provincia", -29.6849372775783, -67.181757581448693, "Provincia de La Rioja", "AR-F", "La Rioja", "La Rioja", "IGN" },
                    { 50, "Provincia", -34.630388706716602, -68.582945601986694, "Provincia de Mendoza", "AR-M", "Mendoza", "Mendoza", "IGN" },
                    { 54, "Provincia", -26.875302598903399, -54.651570562721901, "Provincia de Misiones", "AR-N", "Misiones", "Misiones", "IGN" },
                    { 58, "Provincia", -38.641982862667298, -70.119897223731797, "Provincia del Neuquén", "AR-Q", "Neuquén", "Neuquén", "IGN" },
                    { 62, "Provincia", -40.405079630635903, -67.229675799603598, "Provincia de Río Negro", "AR-R", "Río Negro", "Río Negro", "IGN" },
                    { 66, "Provincia", -24.299283895720102, -64.814158657434604, "Provincia de Salta", "AR-A", "Salta", "Salta", "IGN" },
                    { 70, "Provincia", -30.865660701509601, -68.888159707177607, "Provincia de San Juan", "AR-J", "San Juan", "San Juan", "IGN" },
                    { 74, "Provincia", -33.7611035381154, -66.025231271402106, "Provincia de San Luis", "AR-D", "San Luis", "San Luis", "IGN" },
                    { 78, "Provincia", -48.815547183052701, -69.955761914491305, "Provincia de Santa Cruz", "AR-Z", "Santa Cruz", "Santa Cruz", "IGN" },
                    { 82, "Provincia", -30.708822709152798, -60.950687276970598, "Provincia de Santa Fe", "AR-S", "Santa Fe", "Santa Fe", "IGN" },
                    { 86, "Provincia", -27.783431881752101, -63.252626885646201, "Provincia de Santiago del Estero", "AR-G", "Santiago del Estero", "Santiago del Estero", "IGN" },
                    { 90, "Provincia", -26.948283501723001, -65.364765580368299, "Provincia de Tucumán", "AR-T", "Tucumán", "Tucumán", "IGN" },
                    { 94, "Provincia", -82.521134521154494, -50.7428606764691, "Provincia de Tierra del Fuego, Antártida e Islas del Atlántico Sur", "AR-V", "Tierra del Fuego", "Tierra del Fuego, Antártida e Islas del Atlántico Sur", "IGN" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Province",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Province",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Province",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Province",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Province",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Province",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Province",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Province",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Province",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Province",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Province",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Province",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Province",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Province",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Province",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Province",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Province",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Province",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Province",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Province",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Province",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Province",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Province",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Province",
                keyColumn: "Id",
                keyValue: 94);
        }
    }
}
