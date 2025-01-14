using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MGP.Location.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class StreetsSierraDeLosPadresSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Street",
                columns: new[] { "Id", "Category", "EndHeightLeft", "EndHeightRight", "FullName", "LocalityId", "Name", "Source", "StartHeightLeft", "StartHeightRight" },
                values: new object[,]
                {
                    { 635712000005L, "CALLE", 0, 0, "ABEL, Buenos Aires, General Pueyrredón", 6357120L, "ABEL", "INDEC", 0, 0 },
                    { 635712000010L, "CALLE", 0, 0, "ADOLFO, Buenos Aires, General Pueyrredón", 6357120L, "ADOLFO", "INDEC", 0, 0 },
                    { 635712000015L, "CALLE", 0, 0, "ADRIANA, Buenos Aires, General Pueyrredón", 6357120L, "ADRIANA", "INDEC", 0, 0 },
                    { 635712000020L, "CALLE", 0, 0, "ALDO, Buenos Aires, General Pueyrredón", 6357120L, "ALDO", "INDEC", 0, 0 },
                    { 635712000025L, "CALLE", 0, 0, "ALICIA, Buenos Aires, General Pueyrredón", 6357120L, "ALICIA", "INDEC", 0, 0 },
                    { 635712000030L, "CALLE", 0, 0, "ANALIA, Buenos Aires, General Pueyrredón", 6357120L, "ANALIA", "INDEC", 0, 0 },
                    { 635712000035L, "CALLE", 0, 0, "ANGEL, Buenos Aires, General Pueyrredón", 6357120L, "ANGEL", "INDEC", 0, 0 },
                    { 635712000040L, "CALLE", 0, 0, "ANGELA, Buenos Aires, General Pueyrredón", 6357120L, "ANGELA", "INDEC", 0, 0 },
                    { 635712000045L, "CALLE", 0, 0, "ARGENTINA, Buenos Aires, General Pueyrredón", 6357120L, "ARGENTINA", "INDEC", 0, 0 },
                    { 635712000050L, "CALLE", 0, 0, "ARMANDO, Buenos Aires, General Pueyrredón", 6357120L, "ARMANDO", "INDEC", 0, 0 },
                    { 635712000055L, "CALLE", 0, 0, "ARTURO, Buenos Aires, General Pueyrredón", 6357120L, "ARTURO", "INDEC", 0, 0 },
                    { 635712000060L, "AV", 0, 0, "AV DEL VALLE, Buenos Aires, General Pueyrredón", 6357120L, "AV DEL VALLE", "INDEC", 0, 0 },
                    { 635712000065L, "AV", 0, 0, "AV LIA, Buenos Aires, General Pueyrredón", 6357120L, "AV LIA", "INDEC", 0, 0 },
                    { 635712000070L, "AV", 0, 0, "AV RIO COLORADO, Buenos Aires, General Pueyrredón", 6357120L, "AV RIO COLORADO", "INDEC", 0, 0 },
                    { 635712000075L, "CALLE", 0, 0, "BAUTISTA, Buenos Aires, General Pueyrredón", 6357120L, "BAUTISTA", "INDEC", 0, 0 },
                    { 635712000080L, "CALLE", 0, 0, "BEATRIZ, Buenos Aires, General Pueyrredón", 6357120L, "BEATRIZ", "INDEC", 0, 0 },
                    { 635712000085L, "CALLE", 0, 0, "BORDEU JUAN MANUEL, Buenos Aires, General Pueyrredón", 6357120L, "BORDEU JUAN MANUEL", "INDEC", 0, 0 },
                    { 635712000090L, "CALLE", 0, 0, "BRAULIO, Buenos Aires, General Pueyrredón", 6357120L, "BRAULIO", "INDEC", 0, 0 },
                    { 635712000095L, "CALLE", 0, 0, "BRIGIDA, Buenos Aires, General Pueyrredón", 6357120L, "BRIGIDA", "INDEC", 0, 0 },
                    { 635712000100L, "CALLE", 0, 0, "BRUNO, Buenos Aires, General Pueyrredón", 6357120L, "BRUNO", "INDEC", 0, 0 },
                    { 635712000105L, "CALLE", 0, 0, "CALLE 1, Buenos Aires, General Pueyrredón", 6357120L, "CALLE 1", "INDEC", 0, 0 },
                    { 635712000110L, "CALLE", 0, 0, "CALLE 10, Buenos Aires, General Pueyrredón", 6357120L, "CALLE 10", "INDEC", 0, 0 },
                    { 635712000115L, "CALLE", 0, 0, "CALLE 10 - ARROYO SECO, Buenos Aires, General Pueyrredón", 6357120L, "CALLE 10 - ARROYO SECO", "INDEC", 0, 0 },
                    { 635712000120L, "CALLE", 0, 0, "CALLE 10 B, Buenos Aires, General Pueyrredón", 6357120L, "CALLE 10 B", "INDEC", 0, 0 },
                    { 635712000125L, "CALLE", 0, 0, "CALLE 11, Buenos Aires, General Pueyrredón", 6357120L, "CALLE 11", "INDEC", 0, 0 },
                    { 635712000130L, "CALLE", 0, 0, "CALLE 12, Buenos Aires, General Pueyrredón", 6357120L, "CALLE 12", "INDEC", 0, 0 },
                    { 635712000135L, "CALLE", 0, 0, "CALLE 14, Buenos Aires, General Pueyrredón", 6357120L, "CALLE 14", "INDEC", 0, 0 },
                    { 635712000140L, "CALLE", 0, 0, "CALLE 14 - EL TREBOL, Buenos Aires, General Pueyrredón", 6357120L, "CALLE 14 - EL TREBOL", "INDEC", 0, 0 },
                    { 635712000145L, "CALLE", 0, 0, "CALLE 15, Buenos Aires, General Pueyrredón", 6357120L, "CALLE 15", "INDEC", 0, 0 },
                    { 635712000150L, "CALLE", 0, 0, "CALLE 2, Buenos Aires, General Pueyrredón", 6357120L, "CALLE 2", "INDEC", 0, 0 },
                    { 635712000155L, "CALLE", 0, 0, "CALLE 2 C, Buenos Aires, General Pueyrredón", 6357120L, "CALLE 2 C", "INDEC", 0, 0 },
                    { 635712000160L, "CALLE", 0, 0, "CALLE 3, Buenos Aires, General Pueyrredón", 6357120L, "CALLE 3", "INDEC", 0, 0 },
                    { 635712000165L, "CALLE", 0, 0, "CALLE 3 B, Buenos Aires, General Pueyrredón", 6357120L, "CALLE 3 B", "INDEC", 0, 0 },
                    { 635712000170L, "CALLE", 0, 0, "CALLE 4, Buenos Aires, General Pueyrredón", 6357120L, "CALLE 4", "INDEC", 0, 0 },
                    { 635712000175L, "CALLE", 0, 0, "CALLE 4 - COSTA ALEGRE, Buenos Aires, General Pueyrredón", 6357120L, "CALLE 4 - COSTA ALEGRE", "INDEC", 0, 0 },
                    { 635712000180L, "CALLE", 0, 0, "CALLE 4 C, Buenos Aires, General Pueyrredón", 6357120L, "CALLE 4 C", "INDEC", 0, 0 },
                    { 635712000185L, "CALLE", 0, 0, "CALLE 5, Buenos Aires, General Pueyrredón", 6357120L, "CALLE 5", "INDEC", 0, 0 },
                    { 635712000190L, "CALLE", 0, 0, "CALLE 5 B, Buenos Aires, General Pueyrredón", 6357120L, "CALLE 5 B", "INDEC", 0, 0 },
                    { 635712000195L, "CALLE", 0, 0, "CALLE 6, Buenos Aires, General Pueyrredón", 6357120L, "CALLE 6", "INDEC", 0, 0 },
                    { 635712000200L, "CALLE", 0, 0, "CALLE 6 - ARROYO SECO, Buenos Aires, General Pueyrredón", 6357120L, "CALLE 6 - ARROYO SECO", "INDEC", 0, 0 },
                    { 635712000205L, "CALLE", 0, 0, "CALLE 6 B, Buenos Aires, General Pueyrredón", 6357120L, "CALLE 6 B", "INDEC", 0, 0 },
                    { 635712000210L, "CALLE", 0, 0, "CALLE 6 C, Buenos Aires, General Pueyrredón", 6357120L, "CALLE 6 C", "INDEC", 0, 0 },
                    { 635712000215L, "CALLE", 0, 0, "CALLE 7, Buenos Aires, General Pueyrredón", 6357120L, "CALLE 7", "INDEC", 0, 0 },
                    { 635712000220L, "CALLE", 0, 0, "CALLE 8, Buenos Aires, General Pueyrredón", 6357120L, "CALLE 8", "INDEC", 0, 0 },
                    { 635712000225L, "CALLE", 0, 0, "CALLE 8 - ARROYO SECO, Buenos Aires, General Pueyrredón", 6357120L, "CALLE 8 - ARROYO SECO", "INDEC", 0, 0 },
                    { 635712000230L, "CALLE", 0, 0, "CALLE 8 B, Buenos Aires, General Pueyrredón", 6357120L, "CALLE 8 B", "INDEC", 0, 0 },
                    { 635712000235L, "CALLE", 0, 0, "CALLE 9, Buenos Aires, General Pueyrredón", 6357120L, "CALLE 9", "INDEC", 0, 0 },
                    { 635712000240L, "CALLE", 0, 0, "CALLE N 1, Buenos Aires, General Pueyrredón", 6357120L, "CALLE N 1", "INDEC", 0, 0 },
                    { 635712000245L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357120L, "CALLE SN", "INDEC", 0, 0 },
                    { 635712000250L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357120L, "CALLE SN", "INDEC", 0, 0 },
                    { 635712000255L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357120L, "CALLE SN", "INDEC", 0, 0 },
                    { 635712000260L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357120L, "CALLE SN", "INDEC", 0, 0 },
                    { 635712000265L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357120L, "CALLE SN", "INDEC", 0, 0 },
                    { 635712000270L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357120L, "CALLE SN", "INDEC", 0, 0 },
                    { 635712000275L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357120L, "CALLE SN", "INDEC", 0, 0 },
                    { 635712000280L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357120L, "CALLE SN", "INDEC", 0, 0 },
                    { 635712000285L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357120L, "CALLE SN", "INDEC", 0, 0 },
                    { 635712000290L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357120L, "CALLE SN", "INDEC", 0, 0 },
                    { 635712000295L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357120L, "CALLE SN", "INDEC", 0, 0 },
                    { 635712000300L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357120L, "CALLE SN", "INDEC", 0, 0 },
                    { 635712000305L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357120L, "CALLE SN", "INDEC", 0, 0 },
                    { 635712000310L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357120L, "CALLE SN", "INDEC", 0, 0 },
                    { 635712000315L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357120L, "CALLE SN", "INDEC", 0, 0 },
                    { 635712000320L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357120L, "CALLE SN", "INDEC", 0, 0 },
                    { 635712000325L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357120L, "CALLE SN", "INDEC", 0, 0 },
                    { 635712000330L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357120L, "CALLE SN", "INDEC", 0, 0 },
                    { 635712000335L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357120L, "CALLE SN", "INDEC", 0, 0 },
                    { 635712000340L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357120L, "CALLE SN", "INDEC", 0, 0 },
                    { 635712000345L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357120L, "CALLE SN", "INDEC", 0, 0 },
                    { 635712000350L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357120L, "CALLE SN", "INDEC", 0, 0 },
                    { 635712000353L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357120L, "CALLE SN", "INDEC", 0, 0 },
                    { 635712000355L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357120L, "CALLE SN", "INDEC", 0, 0 },
                    { 635712000360L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357120L, "CALLE SN", "INDEC", 0, 0 },
                    { 635712000365L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357120L, "CALLE SN", "INDEC", 0, 0 },
                    { 635712000370L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357120L, "CALLE SN", "INDEC", 0, 0 },
                    { 635712000375L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357120L, "CALLE SN", "INDEC", 0, 0 },
                    { 635712000380L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357120L, "CALLE SN", "INDEC", 0, 0 },
                    { 635712000385L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357120L, "CALLE SN", "INDEC", 0, 0 },
                    { 635712000390L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357120L, "CALLE SN", "INDEC", 0, 0 },
                    { 635712000395L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357120L, "CALLE SN", "INDEC", 0, 0 },
                    { 635712000400L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357120L, "CALLE SN", "INDEC", 0, 0 },
                    { 635712000405L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357120L, "CALLE SN", "INDEC", 0, 0 },
                    { 635712000410L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357120L, "CALLE SN", "INDEC", 0, 0 },
                    { 635712000415L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357120L, "CALLE SN", "INDEC", 0, 0 },
                    { 635712000420L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357120L, "CALLE SN", "INDEC", 0, 0 },
                    { 635712000425L, "CALLE", 0, 0, "CAMILO, Buenos Aires, General Pueyrredón", 6357120L, "CAMILO", "INDEC", 0, 0 },
                    { 635712000430L, "CALLE", 0, 0, "CARLOS, Buenos Aires, General Pueyrredón", 6357120L, "CARLOS", "INDEC", 0, 0 },
                    { 635712000435L, "CALLE", 0, 0, "CECILIA, Buenos Aires, General Pueyrredón", 6357120L, "CECILIA", "INDEC", 0, 0 },
                    { 635712000440L, "CALLE", 0, 0, "CIRCUITO GRAL SAN MARTIN, Buenos Aires, General Pueyrredón", 6357120L, "CIRCUITO GRAL SAN MARTIN", "INDEC", 0, 0 },
                    { 635712000445L, "CALLE", 0, 0, "CIRCUITO GRAL SAN MARTIN, Buenos Aires, General Pueyrredón", 6357120L, "CIRCUITO GRAL SAN MARTIN", "INDEC", 0, 0 },
                    { 635712000450L, "CALLE", 0, 0, "CIUDAD DE ROMA, Buenos Aires, General Pueyrredón", 6357120L, "CIUDAD DE ROMA", "INDEC", 0, 0 },
                    { 635712000455L, "CALLE", 0, 0, "COLECTORA, Buenos Aires, General Pueyrredón", 6357120L, "COLECTORA", "INDEC", 0, 0 },
                    { 635712000460L, "CALLE", 0, 0, "DAMIAN, Buenos Aires, General Pueyrredón", 6357120L, "DAMIAN", "INDEC", 0, 0 },
                    { 635712000465L, "CALLE", 0, 0, "DANIELA, Buenos Aires, General Pueyrredón", 6357120L, "DANIELA", "INDEC", 0, 0 },
                    { 635712000470L, "CALLE", 0, 0, "DE LA REDUCCION, Buenos Aires, General Pueyrredón", 6357120L, "DE LA REDUCCION", "INDEC", 0, 0 },
                    { 635712000475L, "CALLE", 0, 0, "DE LOS PELEGRINOS, Buenos Aires, General Pueyrredón", 6357120L, "DE LOS PELEGRINOS", "INDEC", 0, 0 },
                    { 635712000480L, "CALLE", 0, 0, "DEL PUEBLO PAMPA, Buenos Aires, General Pueyrredón", 6357120L, "DEL PUEBLO PAMPA", "INDEC", 0, 0 },
                    { 635712000485L, "CALLE", 0, 0, "DIAG 13, Buenos Aires, General Pueyrredón", 6357120L, "DIAG 13", "INDEC", 0, 0 },
                    { 635712000490L, "CALLE", 0, 0, "DIEGO, Buenos Aires, General Pueyrredón", 6357120L, "DIEGO", "INDEC", 0, 0 },
                    { 635712000495L, "CALLE", 0, 0, "DOMINGO, Buenos Aires, General Pueyrredón", 6357120L, "DOMINGO", "INDEC", 0, 0 },
                    { 635712000500L, "CALLE", 0, 0, "DOROTEA, Buenos Aires, General Pueyrredón", 6357120L, "DOROTEA", "INDEC", 0, 0 },
                    { 635712000505L, "CALLE", 0, 0, "EDUARDO, Buenos Aires, General Pueyrredón", 6357120L, "EDUARDO", "INDEC", 0, 0 },
                    { 635712000510L, "CALLE", 0, 0, "EL CERRO, Buenos Aires, General Pueyrredón", 6357120L, "EL CERRO", "INDEC", 0, 0 },
                    { 635712000515L, "CALLE", 0, 0, "EL ESTRIBO, Buenos Aires, General Pueyrredón", 6357120L, "EL ESTRIBO", "INDEC", 0, 0 },
                    { 635712000520L, "CALLE", 0, 0, "EL LAZO, Buenos Aires, General Pueyrredón", 6357120L, "EL LAZO", "INDEC", 0, 0 },
                    { 635712000525L, "CALLE", 0, 0, "EL MANANTIAL, Buenos Aires, General Pueyrredón", 6357120L, "EL MANANTIAL", "INDEC", 0, 0 },
                    { 635712000530L, "CALLE", 0, 0, "EL MIRADOR, Buenos Aires, General Pueyrredón", 6357120L, "EL MIRADOR", "INDEC", 0, 0 },
                    { 635712000535L, "CALLE", 0, 0, "EL MONTE, Buenos Aires, General Pueyrredón", 6357120L, "EL MONTE", "INDEC", 0, 0 },
                    { 635712000540L, "CALLE", 0, 0, "EL RECADO, Buenos Aires, General Pueyrredón", 6357120L, "EL RECADO", "INDEC", 0, 0 },
                    { 635712000545L, "CALLE", 0, 0, "EL REMANSO, Buenos Aires, General Pueyrredón", 6357120L, "EL REMANSO", "INDEC", 0, 0 },
                    { 635712000550L, "CALLE", 0, 0, "EL VOLCAN, Buenos Aires, General Pueyrredón", 6357120L, "EL VOLCAN", "INDEC", 0, 0 },
                    { 635712000555L, "CALLE", 0, 0, "ELENA, Buenos Aires, General Pueyrredón", 6357120L, "ELENA", "INDEC", 0, 0 },
                    { 635712000560L, "CALLE", 0, 0, "ELINA, Buenos Aires, General Pueyrredón", 6357120L, "ELINA", "INDEC", 0, 0 },
                    { 635712000565L, "CALLE", 0, 0, "ELISA, Buenos Aires, General Pueyrredón", 6357120L, "ELISA", "INDEC", 0, 0 },
                    { 635712000570L, "CALLE", 0, 0, "ELSA, Buenos Aires, General Pueyrredón", 6357120L, "ELSA", "INDEC", 0, 0 },
                    { 635712000575L, "CALLE", 0, 0, "EMILIO, Buenos Aires, General Pueyrredón", 6357120L, "EMILIO", "INDEC", 0, 0 },
                    { 635712000580L, "CALLE", 0, 0, "ENRIQUE, Buenos Aires, General Pueyrredón", 6357120L, "ENRIQUE", "INDEC", 0, 0 },
                    { 635712000585L, "CALLE", 0, 0, "ESTELA, Buenos Aires, General Pueyrredón", 6357120L, "ESTELA", "INDEC", 0, 0 },
                    { 635712000590L, "CALLE", 0, 0, "ESTER, Buenos Aires, General Pueyrredón", 6357120L, "ESTER", "INDEC", 0, 0 },
                    { 635712000595L, "CALLE", 0, 0, "EUGENIA, Buenos Aires, General Pueyrredón", 6357120L, "EUGENIA", "INDEC", 0, 0 },
                    { 635712000600L, "CALLE", 0, 0, "EVA, Buenos Aires, General Pueyrredón", 6357120L, "EVA", "INDEC", 0, 0 },
                    { 635712000605L, "CALLE", 0, 0, "EVARISTO, Buenos Aires, General Pueyrredón", 6357120L, "EVARISTO", "INDEC", 0, 0 },
                    { 635712000610L, "CALLE", 0, 0, "EVELINA, Buenos Aires, General Pueyrredón", 6357120L, "EVELINA", "INDEC", 0, 0 },
                    { 635712000615L, "CALLE", 0, 0, "FABIAN, Buenos Aires, General Pueyrredón", 6357120L, "FABIAN", "INDEC", 0, 0 },
                    { 635712000620L, "CALLE", 0, 0, "FAUSTINO, Buenos Aires, General Pueyrredón", 6357120L, "FAUSTINO", "INDEC", 0, 0 },
                    { 635712000625L, "CALLE", 0, 0, "FELIPE, Buenos Aires, General Pueyrredón", 6357120L, "FELIPE", "INDEC", 0, 0 },
                    { 635712000630L, "CALLE", 0, 0, "FELIX, Buenos Aires, General Pueyrredón", 6357120L, "FELIX", "INDEC", 0, 0 },
                    { 635712000635L, "CALLE", 0, 0, "FLORENCIA, Buenos Aires, General Pueyrredón", 6357120L, "FLORENCIA", "INDEC", 0, 0 },
                    { 635712000640L, "CALLE", 0, 0, "FLORENCIO, Buenos Aires, General Pueyrredón", 6357120L, "FLORENCIO", "INDEC", 0, 0 },
                    { 635712000645L, "CALLE", 0, 0, "FRANCA, Buenos Aires, General Pueyrredón", 6357120L, "FRANCA", "INDEC", 0, 0 },
                    { 635712000650L, "CALLE", 0, 0, "FRANCISCA, Buenos Aires, General Pueyrredón", 6357120L, "FRANCISCA", "INDEC", 0, 0 },
                    { 635712000655L, "CALLE", 0, 0, "FRANCISCO, Buenos Aires, General Pueyrredón", 6357120L, "FRANCISCO", "INDEC", 0, 0 },
                    { 635712000660L, "CALLE", 0, 0, "GABRIEL, Buenos Aires, General Pueyrredón", 6357120L, "GABRIEL", "INDEC", 0, 0 },
                    { 635712000665L, "CALLE", 0, 0, "GERTRUDIS, Buenos Aires, General Pueyrredón", 6357120L, "GERTRUDIS", "INDEC", 0, 0 },
                    { 635712000670L, "CALLE", 0, 0, "GRACIELA, Buenos Aires, General Pueyrredón", 6357120L, "GRACIELA", "INDEC", 0, 0 },
                    { 635712000675L, "CALLE", 0, 0, "GRAL SAN MARTIN, Buenos Aires, General Pueyrredón", 6357120L, "GRAL SAN MARTIN", "INDEC", 0, 0 },
                    { 635712000680L, "CALLE", 0, 0, "GREGORIO, Buenos Aires, General Pueyrredón", 6357120L, "GREGORIO", "INDEC", 0, 0 },
                    { 635712000685L, "CALLE", 0, 0, "GUILLERMO, Buenos Aires, General Pueyrredón", 6357120L, "GUILLERMO", "INDEC", 0, 0 },
                    { 635712000690L, "CALLE", 0, 0, "HECTOR, Buenos Aires, General Pueyrredón", 6357120L, "HECTOR", "INDEC", 0, 0 },
                    { 635712000695L, "CALLE", 0, 0, "HELMER URANGA, Buenos Aires, General Pueyrredón", 6357120L, "HELMER URANGA", "INDEC", 0, 0 },
                    { 635712000705L, "CALLE", 0, 0, "HIGINIO, Buenos Aires, General Pueyrredón", 6357120L, "HIGINIO", "INDEC", 0, 0 },
                    { 635712000710L, "CALLE", 0, 0, "HILARIO, Buenos Aires, General Pueyrredón", 6357120L, "HILARIO", "INDEC", 0, 0 },
                    { 635712000715L, "CALLE", 0, 0, "HILDA, Buenos Aires, General Pueyrredón", 6357120L, "HILDA", "INDEC", 0, 0 },
                    { 635712000720L, "CALLE", 0, 0, "HIPOLITO, Buenos Aires, General Pueyrredón", 6357120L, "HIPOLITO", "INDEC", 0, 0 },
                    { 635712000725L, "CALLE", 0, 0, "HUGO, Buenos Aires, General Pueyrredón", 6357120L, "HUGO", "INDEC", 0, 0 },
                    { 635712000730L, "CALLE", 0, 0, "IGNACIO, Buenos Aires, General Pueyrredón", 6357120L, "IGNACIO", "INDEC", 0, 0 },
                    { 635712000735L, "CALLE", 0, 0, "INDIOS ARAUCANOS, Buenos Aires, General Pueyrredón", 6357120L, "INDIOS ARAUCANOS", "INDEC", 0, 0 },
                    { 635712000740L, "CALLE", 0, 0, "INES, Buenos Aires, General Pueyrredón", 6357120L, "INES", "INDEC", 0, 0 },
                    { 635712000745L, "CALLE", 0, 0, "IRENE, Buenos Aires, General Pueyrredón", 6357120L, "IRENE", "INDEC", 0, 0 },
                    { 635712000750L, "CALLE", 0, 0, "ISABEL, Buenos Aires, General Pueyrredón", 6357120L, "ISABEL", "INDEC", 0, 0 },
                    { 635712000755L, "CALLE", 0, 0, "ISIDORO, Buenos Aires, General Pueyrredón", 6357120L, "ISIDORO", "INDEC", 0, 0 },
                    { 635712000760L, "CALLE", 0, 0, "JACINTO, Buenos Aires, General Pueyrredón", 6357120L, "JACINTO", "INDEC", 0, 0 },
                    { 635712000765L, "CALLE", 0, 0, "JOAQUIN, Buenos Aires, General Pueyrredón", 6357120L, "JOAQUIN", "INDEC", 0, 0 },
                    { 635712000770L, "CALLE", 0, 0, "JORGE, Buenos Aires, General Pueyrredón", 6357120L, "JORGE", "INDEC", 0, 0 },
                    { 635712000775L, "CALLE", 0, 0, "JOSE, Buenos Aires, General Pueyrredón", 6357120L, "JOSE", "INDEC", 0, 0 },
                    { 635712000780L, "CALLE", 0, 0, "JOSEFINA, Buenos Aires, General Pueyrredón", 6357120L, "JOSEFINA", "INDEC", 0, 0 },
                    { 635712000785L, "CALLE", 0, 0, "JUAN, Buenos Aires, General Pueyrredón", 6357120L, "JUAN", "INDEC", 0, 0 },
                    { 635712000790L, "CALLE", 0, 0, "JUAN MANUEL BORDEU, Buenos Aires, General Pueyrredón", 6357120L, "JUAN MANUEL BORDEU", "INDEC", 0, 0 },
                    { 635712000795L, "CALLE", 0, 0, "JULIAN, Buenos Aires, General Pueyrredón", 6357120L, "JULIAN", "INDEC", 0, 0 },
                    { 635712000800L, "CALLE", 0, 0, "JULIO, Buenos Aires, General Pueyrredón", 6357120L, "JULIO", "INDEC", 0, 0 },
                    { 635712000805L, "CALLE", 0, 0, "JUSTA, Buenos Aires, General Pueyrredón", 6357120L, "JUSTA", "INDEC", 0, 0 },
                    { 635712000810L, "CALLE", 0, 0, "JUSTO, Buenos Aires, General Pueyrredón", 6357120L, "JUSTO", "INDEC", 0, 0 },
                    { 635712000815L, "CALLE", 0, 0, "LA COLINA, Buenos Aires, General Pueyrredón", 6357120L, "LA COLINA", "INDEC", 0, 0 },
                    { 635712000820L, "CALLE", 0, 0, "LA CUESTA, Buenos Aires, General Pueyrredón", 6357120L, "LA CUESTA", "INDEC", 0, 0 },
                    { 635712000825L, "CALLE", 0, 0, "LA LAGUNA, Buenos Aires, General Pueyrredón", 6357120L, "LA LAGUNA", "INDEC", 0, 0 },
                    { 635712000830L, "CALLE", 0, 0, "LA LOMADA, Buenos Aires, General Pueyrredón", 6357120L, "LA LOMADA", "INDEC", 0, 0 },
                    { 635712000835L, "CALLE", 0, 0, "LA QUEBRADA, Buenos Aires, General Pueyrredón", 6357120L, "LA QUEBRADA", "INDEC", 0, 0 },
                    { 635712000840L, "CALLE", 0, 0, "LA SERRANITA, Buenos Aires, General Pueyrredón", 6357120L, "LA SERRANITA", "INDEC", 0, 0 },
                    { 635712000845L, "CALLE", 0, 0, "LA TROPILLA, Buenos Aires, General Pueyrredón", 6357120L, "LA TROPILLA", "INDEC", 0, 0 },
                    { 635712000850L, "CALLE", 0, 0, "LA VAGUADA, Buenos Aires, General Pueyrredón", 6357120L, "LA VAGUADA", "INDEC", 0, 0 },
                    { 635712000855L, "CALLE", 0, 0, "LAS AZALEAS, Buenos Aires, General Pueyrredón", 6357120L, "LAS AZALEAS", "INDEC", 0, 0 },
                    { 635712000860L, "CALLE", 0, 0, "LAS FRESAS, Buenos Aires, General Pueyrredón", 6357120L, "LAS FRESAS", "INDEC", 0, 0 },
                    { 635712000865L, "CALLE", 0, 0, "LAS GROSELLAS, Buenos Aires, General Pueyrredón", 6357120L, "LAS GROSELLAS", "INDEC", 0, 0 },
                    { 635712000870L, "CALLE", 0, 0, "LAS HAYAS, Buenos Aires, General Pueyrredón", 6357120L, "LAS HAYAS", "INDEC", 0, 0 },
                    { 635712000875L, "CALLE", 0, 0, "LAURA, Buenos Aires, General Pueyrredón", 6357120L, "LAURA", "INDEC", 0, 0 },
                    { 635712000880L, "CALLE", 0, 0, "LETICIA, Buenos Aires, General Pueyrredón", 6357120L, "LETICIA", "INDEC", 0, 0 },
                    { 635712000885L, "CALLE", 0, 0, "LIDIA, Buenos Aires, General Pueyrredón", 6357120L, "LIDIA", "INDEC", 0, 0 },
                    { 635712000890L, "CALLE", 0, 0, "LILIANA, Buenos Aires, General Pueyrredón", 6357120L, "LILIANA", "INDEC", 0, 0 },
                    { 635712000895L, "CALLE", 0, 0, "LOS ALMENDROS, Buenos Aires, General Pueyrredón", 6357120L, "LOS ALMENDROS", "INDEC", 0, 0 },
                    { 635712000900L, "CALLE", 0, 0, "LOS ARCES, Buenos Aires, General Pueyrredón", 6357120L, "LOS ARCES", "INDEC", 0, 0 },
                    { 635712000905L, "CALLE", 0, 0, "LOS AVELLANOS, Buenos Aires, General Pueyrredón", 6357120L, "LOS AVELLANOS", "INDEC", 0, 0 },
                    { 635712000910L, "CALLE", 0, 0, "LOS CASTANOS, Buenos Aires, General Pueyrredón", 6357120L, "LOS CASTANOS", "INDEC", 0, 0 },
                    { 635712000915L, "CALLE", 0, 0, "LOS CHIMANGOS, Buenos Aires, General Pueyrredón", 6357120L, "LOS CHIMANGOS", "INDEC", 0, 0 },
                    { 635712000920L, "CALLE", 0, 0, "LOS CIRUELOS, Buenos Aires, General Pueyrredón", 6357120L, "LOS CIRUELOS", "INDEC", 0, 0 },
                    { 635712000925L, "CALLE", 0, 0, "LOS HALCONES, Buenos Aires, General Pueyrredón", 6357120L, "LOS HALCONES", "INDEC", 0, 0 },
                    { 635712000930L, "CALLE", 0, 0, "LOS INCIENSOS, Buenos Aires, General Pueyrredón", 6357120L, "LOS INCIENSOS", "INDEC", 0, 0 },
                    { 635712000935L, "CALLE", 0, 0, "LOS JESUITAS, Buenos Aires, General Pueyrredón", 6357120L, "LOS JESUITAS", "INDEC", 0, 0 },
                    { 635712000940L, "CALLE", 0, 0, "LOS MIMBRES, Buenos Aires, General Pueyrredón", 6357120L, "LOS MIMBRES", "INDEC", 0, 0 },
                    { 635712000945L, "CALLE", 0, 0, "LOS MIRLOS, Buenos Aires, General Pueyrredón", 6357120L, "LOS MIRLOS", "INDEC", 0, 0 },
                    { 635712000950L, "CALLE", 0, 0, "LOS OLIVARES, Buenos Aires, General Pueyrredón", 6357120L, "LOS OLIVARES", "INDEC", 0, 0 },
                    { 635712000955L, "CALLE", 0, 0, "LOS PENASCOS, Buenos Aires, General Pueyrredón", 6357120L, "LOS PENASCOS", "INDEC", 0, 0 },
                    { 635712000960L, "CALLE", 0, 0, "LOS PERALES, Buenos Aires, General Pueyrredón", 6357120L, "LOS PERALES", "INDEC", 0, 0 },
                    { 635712000965L, "CALLE", 0, 0, "LOS ZORZALES, Buenos Aires, General Pueyrredón", 6357120L, "LOS ZORZALES", "INDEC", 0, 0 },
                    { 635712000970L, "CALLE", 0, 0, "LUCIANO, Buenos Aires, General Pueyrredón", 6357120L, "LUCIANO", "INDEC", 0, 0 },
                    { 635712000975L, "CALLE", 0, 0, "LUCIO, Buenos Aires, General Pueyrredón", 6357120L, "LUCIO", "INDEC", 0, 0 },
                    { 635712000980L, "CALLE", 0, 0, "LUIS, Buenos Aires, General Pueyrredón", 6357120L, "LUIS", "INDEC", 0, 0 },
                    { 635712000985L, "CALLE", 0, 0, "LUIS VARETTO PADRE, Buenos Aires, General Pueyrredón", 6357120L, "LUIS VARETTO PADRE", "INDEC", 0, 0 },
                    { 635712000990L, "CALLE", 0, 0, "LUISA, Buenos Aires, General Pueyrredón", 6357120L, "LUISA", "INDEC", 0, 0 },
                    { 635712000995L, "CALLE", 0, 0, "MAGDALENA, Buenos Aires, General Pueyrredón", 6357120L, "MAGDALENA", "INDEC", 0, 0 },
                    { 635712001000L, "CALLE", 0, 0, "MARCELA, Buenos Aires, General Pueyrredón", 6357120L, "MARCELA", "INDEC", 0, 0 },
                    { 635712001005L, "CALLE", 0, 0, "MARCOS, Buenos Aires, General Pueyrredón", 6357120L, "MARCOS", "INDEC", 0, 0 },
                    { 635712001010L, "CALLE", 0, 0, "MARGARITA, Buenos Aires, General Pueyrredón", 6357120L, "MARGARITA", "INDEC", 0, 0 },
                    { 635712001015L, "CALLE", 0, 0, "MARIA, Buenos Aires, General Pueyrredón", 6357120L, "MARIA", "INDEC", 0, 0 },
                    { 635712001020L, "CALLE", 0, 0, "MARIANA, Buenos Aires, General Pueyrredón", 6357120L, "MARIANA", "INDEC", 0, 0 },
                    { 635712001025L, "CALLE", 0, 0, "MARIANO, Buenos Aires, General Pueyrredón", 6357120L, "MARIANO", "INDEC", 0, 0 },
                    { 635712001030L, "CALLE", 0, 0, "MARIO, Buenos Aires, General Pueyrredón", 6357120L, "MARIO", "INDEC", 0, 0 },
                    { 635712001035L, "CALLE", 0, 0, "MARTA, Buenos Aires, General Pueyrredón", 6357120L, "MARTA", "INDEC", 0, 0 },
                    { 635712001040L, "CALLE", 0, 0, "MARTIN, Buenos Aires, General Pueyrredón", 6357120L, "MARTIN", "INDEC", 0, 0 },
                    { 635712001045L, "CALLE", 0, 0, "MATILDE, Buenos Aires, General Pueyrredón", 6357120L, "MATILDE", "INDEC", 0, 0 },
                    { 635712001050L, "CALLE", 0, 0, "MAURO, Buenos Aires, General Pueyrredón", 6357120L, "MAURO", "INDEC", 0, 0 },
                    { 635712001060L, "CALLE", 0, 0, "MIGUEL, Buenos Aires, General Pueyrredón", 6357120L, "MIGUEL", "INDEC", 0, 0 },
                    { 635712001065L, "CALLE", 0, 0, "MIRTA, Buenos Aires, General Pueyrredón", 6357120L, "MIRTA", "INDEC", 0, 0 },
                    { 635712001070L, "CALLE", 0, 0, "NARCISO, Buenos Aires, General Pueyrredón", 6357120L, "NARCISO", "INDEC", 0, 0 },
                    { 635712001075L, "CALLE", 0, 0, "NATIVIDAD, Buenos Aires, General Pueyrredón", 6357120L, "NATIVIDAD", "INDEC", 0, 0 },
                    { 635712001080L, "CALLE", 0, 0, "NESTOR, Buenos Aires, General Pueyrredón", 6357120L, "NESTOR", "INDEC", 0, 0 },
                    { 635712001085L, "CALLE", 0, 0, "NOEMI, Buenos Aires, General Pueyrredón", 6357120L, "NOEMI", "INDEC", 0, 0 },
                    { 635712001090L, "CALLE", 0, 0, "NUESTRA SENORA DE LA CONCEPCION, Buenos Aires, General Pueyrredón", 6357120L, "NUESTRA SENORA DE LA CONCEPCION", "INDEC", 0, 0 },
                    { 635712001095L, "CALLE", 0, 0, "NUESTRA SENORA DE LOS DESAMPARADOS, Buenos Aires, General Pueyrredón", 6357120L, "NUESTRA SENORA DE LOS DESAMPARADOS", "INDEC", 0, 0 },
                    { 635712001100L, "CALLE", 0, 0, "OFELIA, Buenos Aires, General Pueyrredón", 6357120L, "OFELIA", "INDEC", 0, 0 },
                    { 635712001105L, "CALLE", 0, 0, "OLGA, Buenos Aires, General Pueyrredón", 6357120L, "OLGA", "INDEC", 0, 0 },
                    { 635712001110L, "CALLE", 0, 0, "OSCAR, Buenos Aires, General Pueyrredón", 6357120L, "OSCAR", "INDEC", 0, 0 },
                    { 635712001115L, "CALLE", 0, 0, "OSVALDO, Buenos Aires, General Pueyrredón", 6357120L, "OSVALDO", "INDEC", 0, 0 },
                    { 635712001120L, "CALLE", 0, 0, "OVIDIO, Buenos Aires, General Pueyrredón", 6357120L, "OVIDIO", "INDEC", 0, 0 },
                    { 635712001125L, "CALLE", 0, 0, "PABLO, Buenos Aires, General Pueyrredón", 6357120L, "PABLO", "INDEC", 0, 0 },
                    { 635712001130L, "CALLE", 0, 0, "PADRE BERNARDO NUSDORFFER, Buenos Aires, General Pueyrredón", 6357120L, "PADRE BERNARDO NUSDORFFER", "INDEC", 0, 0 },
                    { 635712001135L, "CALLE", 0, 0, "PADRE GUILLERMO FURLONG, Buenos Aires, General Pueyrredón", 6357120L, "PADRE GUILLERMO FURLONG", "INDEC", 0, 0 },
                    { 635712001140L, "CALLE", 0, 0, "PADRE MANUEL QUERINI, Buenos Aires, General Pueyrredón", 6357120L, "PADRE MANUEL QUERINI", "INDEC", 0, 0 },
                    { 635712001145L, "CALLE", 0, 0, "PASCUAL, Buenos Aires, General Pueyrredón", 6357120L, "PASCUAL", "INDEC", 0, 0 },
                    { 635712001150L, "CALLE", 0, 0, "PATRICIA, Buenos Aires, General Pueyrredón", 6357120L, "PATRICIA", "INDEC", 0, 0 },
                    { 635712001155L, "CALLE", 0, 0, "PAULA, Buenos Aires, General Pueyrredón", 6357120L, "PAULA", "INDEC", 0, 0 },
                    { 635712001160L, "CALLE", 0, 0, "PIERINA, Buenos Aires, General Pueyrredón", 6357120L, "PIERINA", "INDEC", 0, 0 },
                    { 635712001165L, "CALLE", 0, 0, "PRAXEDES, Buenos Aires, General Pueyrredón", 6357120L, "PRAXEDES", "INDEC", 0, 0 },
                    { 635712001170L, "CALLE", 0, 0, "RAMON ITURRIOZ, Buenos Aires, General Pueyrredón", 6357120L, "RAMON ITURRIOZ", "INDEC", 0, 0 },
                    { 635712001175L, "CALLE", 0, 0, "RANQUEL, Buenos Aires, General Pueyrredón", 6357120L, "RANQUEL", "INDEC", 0, 0 },
                    { 635712001180L, "CALLE", 0, 0, "RICARDO, Buenos Aires, General Pueyrredón", 6357120L, "RICARDO", "INDEC", 0, 0 },
                    { 635712001185L, "CALLE", 0, 0, "RIO AGUAPEY, Buenos Aires, General Pueyrredón", 6357120L, "RIO AGUAPEY", "INDEC", 0, 0 },
                    { 635712001190L, "CALLE", 0, 0, "RIO ATUEL, Buenos Aires, General Pueyrredón", 6357120L, "RIO ATUEL", "INDEC", 0, 0 },
                    { 635712001195L, "CALLE", 0, 0, "RIO BELEN, Buenos Aires, General Pueyrredón", 6357120L, "RIO BELEN", "INDEC", 0, 0 },
                    { 635712001200L, "CALLE", 0, 0, "RIO BERMEJO, Buenos Aires, General Pueyrredón", 6357120L, "RIO BERMEJO", "INDEC", 0, 0 },
                    { 635712001205L, "CALLE", 0, 0, "RIO BLANCO, Buenos Aires, General Pueyrredón", 6357120L, "RIO BLANCO", "INDEC", 0, 0 },
                    { 635712001210L, "CALLE", 0, 0, "RIO CALCHAQUI, Buenos Aires, General Pueyrredón", 6357120L, "RIO CALCHAQUI", "INDEC", 0, 0 },
                    { 635712001215L, "CALLE", 0, 0, "RIO CANDELARIA, Buenos Aires, General Pueyrredón", 6357120L, "RIO CANDELARIA", "INDEC", 0, 0 },
                    { 635712001220L, "CALLE", 0, 0, "RIO CARCARANA, Buenos Aires, General Pueyrredón", 6357120L, "RIO CARCARANA", "INDEC", 0, 0 },
                    { 635712001225L, "CALLE", 0, 0, "RIO CEBALLOS, Buenos Aires, General Pueyrredón", 6357120L, "RIO CEBALLOS", "INDEC", 0, 0 },
                    { 635712001230L, "CALLE", 0, 0, "RIO CORCOVADO, Buenos Aires, General Pueyrredón", 6357120L, "RIO CORCOVADO", "INDEC", 0, 0 },
                    { 635712001235L, "CALLE", 0, 0, "RIO CURACO, Buenos Aires, General Pueyrredón", 6357120L, "RIO CURACO", "INDEC", 0, 0 },
                    { 635712001240L, "CALLE", 0, 0, "RIO DULCE, Buenos Aires, General Pueyrredón", 6357120L, "RIO DULCE", "INDEC", 0, 0 },
                    { 635712001245L, "CALLE", 0, 0, "RIO FELICIANO, Buenos Aires, General Pueyrredón", 6357120L, "RIO FELICIANO", "INDEC", 0, 0 },
                    { 635712001250L, "CALLE", 0, 0, "RIO GUALEGUAY, Buenos Aires, General Pueyrredón", 6357120L, "RIO GUALEGUAY", "INDEC", 0, 0 },
                    { 635712001255L, "CALLE", 0, 0, "RIO JACHAL, Buenos Aires, General Pueyrredón", 6357120L, "RIO JACHAL", "INDEC", 0, 0 },
                    { 635712001260L, "CALLE", 0, 0, "RIO LAS LAJAS, Buenos Aires, General Pueyrredón", 6357120L, "RIO LAS LAJAS", "INDEC", 0, 0 },
                    { 635712001265L, "CALLE", 0, 0, "RIO LIMAY, Buenos Aires, General Pueyrredón", 6357120L, "RIO LIMAY", "INDEC", 0, 0 },
                    { 635712001270L, "CALLE", 0, 0, "RIO LULES, Buenos Aires, General Pueyrredón", 6357120L, "RIO LULES", "INDEC", 0, 0 },
                    { 635712001275L, "CALLE", 0, 0, "RIO MIRAFLORES, Buenos Aires, General Pueyrredón", 6357120L, "RIO MIRAFLORES", "INDEC", 0, 0 },
                    { 635712001280L, "CALLE", 0, 0, "RIO NEGRO, Buenos Aires, General Pueyrredón", 6357120L, "RIO NEGRO", "INDEC", 0, 0 },
                    { 635712001285L, "CALLE", 0, 0, "RIO PARANA, Buenos Aires, General Pueyrredón", 6357120L, "RIO PARANA", "INDEC", 0, 0 },
                    { 635712001290L, "CALLE", 0, 0, "RIO PILCOMAYO, Buenos Aires, General Pueyrredón", 6357120L, "RIO PILCOMAYO", "INDEC", 0, 0 },
                    { 635712001295L, "CALLE", 0, 0, "RIO PINTO, Buenos Aires, General Pueyrredón", 6357120L, "RIO PINTO", "INDEC", 0, 0 },
                    { 635712001300L, "CALLE", 0, 0, "RIO SAMBOROMBON, Buenos Aires, General Pueyrredón", 6357120L, "RIO SAMBOROMBON", "INDEC", 0, 0 },
                    { 635712001305L, "CALLE", 0, 0, "RIO SUQUIA, Buenos Aires, General Pueyrredón", 6357120L, "RIO SUQUIA", "INDEC", 0, 0 },
                    { 635712001310L, "CALLE", 0, 0, "RIO TELUCO, Buenos Aires, General Pueyrredón", 6357120L, "RIO TELUCO", "INDEC", 0, 0 },
                    { 635712001315L, "CALLE", 0, 0, "RIO TERCERO, Buenos Aires, General Pueyrredón", 6357120L, "RIO TERCERO", "INDEC", 0, 0 },
                    { 635712001320L, "CALLE", 0, 0, "RIO TUPUNGATO, Buenos Aires, General Pueyrredón", 6357120L, "RIO TUPUNGATO", "INDEC", 0, 0 },
                    { 635712001325L, "CALLE", 0, 0, "RITA, Buenos Aires, General Pueyrredón", 6357120L, "RITA", "INDEC", 0, 0 },
                    { 635712001330L, "CALLE", 0, 0, "ROBERTO, Buenos Aires, General Pueyrredón", 6357120L, "ROBERTO", "INDEC", 0, 0 },
                    { 635712001335L, "CALLE", 0, 0, "RODOLFO, Buenos Aires, General Pueyrredón", 6357120L, "RODOLFO", "INDEC", 0, 0 },
                    { 635712001340L, "CALLE", 0, 0, "ROSA, Buenos Aires, General Pueyrredón", 6357120L, "ROSA", "INDEC", 0, 0 },
                    { 635712001345L, "CALLE", 0, 0, "ROSANA, Buenos Aires, General Pueyrredón", 6357120L, "ROSANA", "INDEC", 0, 0 },
                    { 635712001350L, "CALLE", 0, 0, "ROTONDA, Buenos Aires, General Pueyrredón", 6357120L, "ROTONDA", "INDEC", 0, 0 },
                    { 635712001355L, "RUTA", 0, 0, "RUTA NACIONAL 226, Buenos Aires, General Pueyrredón", 6357120L, "RUTA NACIONAL 226", "INDEC", 0, 0 },
                    { 635712001360L, "CALLE", 0, 0, "SIERRA DE PUAN, Buenos Aires, General Pueyrredón", 6357120L, "SIERRA DE PUAN", "INDEC", 0, 0 },
                    { 635712001365L, "CALLE", 0, 0, "SILVIA, Buenos Aires, General Pueyrredón", 6357120L, "SILVIA", "INDEC", 0, 0 },
                    { 635712001375L, "CALLE", 0, 0, "SUSANA, Buenos Aires, General Pueyrredón", 6357120L, "SUSANA", "INDEC", 0, 0 },
                    { 635712001380L, "CALLE", 0, 0, "TERESA, Buenos Aires, General Pueyrredón", 6357120L, "TERESA", "INDEC", 0, 0 },
                    { 635712001385L, "CALLE", 0, 0, "VALENTINA, Buenos Aires, General Pueyrredón", 6357120L, "VALENTINA", "INDEC", 0, 0 },
                    { 635712001390L, "CALLE", 0, 0, "VALLE VERDE, Buenos Aires, General Pueyrredón", 6357120L, "VALLE VERDE", "INDEC", 0, 0 },
                    { 635712001395L, "CALLE", 0, 0, "VECINOS UNIDOS, Buenos Aires, General Pueyrredón", 6357120L, "VECINOS UNIDOS", "INDEC", 0, 0 },
                    { 635712001405L, "CALLE", 0, 0, "VICTOR, Buenos Aires, General Pueyrredón", 6357120L, "VICTOR", "INDEC", 0, 0 },
                    { 635712001410L, "CALLE", 0, 0, "WALTER, Buenos Aires, General Pueyrredón", 6357120L, "WALTER", "INDEC", 0, 0 },
                    { 635712001415L, "CALLE", 0, 0, "YOLANDA, Buenos Aires, General Pueyrredón", 6357120L, "YOLANDA", "INDEC", 0, 0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000005L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000010L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000015L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000020L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000025L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000030L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000035L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000040L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000045L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000050L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000055L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000060L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000065L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000070L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000075L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000080L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000085L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000090L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000095L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000100L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000105L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000110L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000115L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000120L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000125L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000130L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000135L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000140L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000145L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000150L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000155L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000160L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000165L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000170L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000175L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000180L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000185L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000190L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000195L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000200L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000205L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000210L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000215L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000220L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000225L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000230L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000235L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000240L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000245L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000250L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000255L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000260L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000265L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000270L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000275L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000280L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000285L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000290L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000295L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000300L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000305L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000310L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000315L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000320L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000325L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000330L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000335L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000340L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000345L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000350L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000353L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000355L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000360L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000365L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000370L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000375L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000380L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000385L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000390L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000395L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000400L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000405L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000410L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000415L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000420L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000425L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000430L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000435L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000440L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000445L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000450L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000455L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000460L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000465L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000470L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000475L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000480L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000485L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000490L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000495L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000500L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000505L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000510L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000515L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000520L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000525L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000530L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000535L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000540L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000545L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000550L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000555L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000560L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000565L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000570L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000575L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000580L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000585L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000590L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000595L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000600L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000605L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000610L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000615L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000620L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000625L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000630L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000635L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000640L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000645L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000650L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000655L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000660L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000665L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000670L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000675L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000680L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000685L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000690L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000695L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000705L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000710L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000715L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000720L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000725L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000730L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000735L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000740L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000745L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000750L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000755L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000760L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000765L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000770L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000775L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000780L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000785L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000790L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000795L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000800L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000805L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000810L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000815L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000820L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000825L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000830L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000835L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000840L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000845L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000850L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000855L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000860L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000865L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000870L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000875L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000880L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000885L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000890L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000895L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000900L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000905L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000910L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000915L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000920L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000925L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000930L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000935L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000940L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000945L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000950L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000955L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000960L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000965L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000970L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000975L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000980L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000985L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000990L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712000995L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712001000L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712001005L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712001010L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712001015L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712001020L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712001025L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712001030L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712001035L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712001040L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712001045L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712001050L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712001060L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712001065L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712001070L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712001075L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712001080L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712001085L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712001090L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712001095L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712001100L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712001105L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712001110L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712001115L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712001120L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712001125L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712001130L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712001135L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712001140L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712001145L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712001150L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712001155L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712001160L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712001165L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712001170L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712001175L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712001180L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712001185L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712001190L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712001195L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712001200L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712001205L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712001210L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712001215L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712001220L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712001225L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712001230L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712001235L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712001240L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712001245L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712001250L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712001255L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712001260L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712001265L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712001270L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712001275L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712001280L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712001285L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712001290L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712001295L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712001300L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712001305L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712001310L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712001315L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712001320L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712001325L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712001330L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712001335L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712001340L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712001345L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712001350L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712001355L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712001360L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712001365L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712001375L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712001380L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712001385L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712001390L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712001395L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712001405L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712001410L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635712001415L);
        }
    }
}
