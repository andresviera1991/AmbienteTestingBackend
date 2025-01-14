using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MGP.Location.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class StreetsSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Street",
                columns: new[] { "Id", "Category", "EndHeightLeft", "EndHeightRight", "FullName", "LocalityId", "Name", "Source", "StartHeightLeft", "StartHeightRight" },
                values: new object[,]
                {
                    { 635711000005L, "CALLE", 0, 0, "1 - TRINIDAD, Buenos Aires, General Pueyrredón", 6357110L, "1 - TRINIDAD", "INDEC", 0, 0 },
                    { 635711000010L, "CALLE", 0, 0, "10 - LA TRINIDAD, Buenos Aires, General Pueyrredón", 6357110L, "10 - LA TRINIDAD", "INDEC", 0, 0 },
                    { 635711000015L, "CALLE", 0, 0, "11 - TRINIDAD, Buenos Aires, General Pueyrredón", 6357110L, "11 - TRINIDAD", "INDEC", 0, 0 },
                    { 635711000020L, "CALLE", 0, 0, "12 - LA TRINIDAD, Buenos Aires, General Pueyrredón", 6357110L, "12 - LA TRINIDAD", "INDEC", 0, 0 },
                    { 635711000025L, "CALLE", 89999, 11198, "12 DE OCTUBRE, Buenos Aires, General Pueyrredón", 6357110L, "12 DE OCTUBRE", "INDEC", 0, 0 },
                    { 635711000030L, "CALLE", 0, 0, "13 - TRINIDAD, Buenos Aires, General Pueyrredón", 6357110L, "13 - TRINIDAD", "INDEC", 0, 0 },
                    { 635711000035L, "CALLE", 0, 0, "15 - LA TRINIDAD, Buenos Aires, General Pueyrredón", 6357110L, "15 - LA TRINIDAD", "INDEC", 0, 0 },
                    { 635711000040L, "CALLE", 0, 0, "17 - LA TRINIDAD, Buenos Aires, General Pueyrredón", 6357110L, "17 - LA TRINIDAD", "INDEC", 0, 0 },
                    { 635711000045L, "CALLE", 0, 0, "201 BIS, Buenos Aires, General Pueyrredón", 6357110L, "201 BIS", "INDEC", 0, 0 },
                    { 635711000050L, "CALLE", 0, 0, "203 BIS, Buenos Aires, General Pueyrredón", 6357110L, "203 BIS", "INDEC", 0, 0 },
                    { 635711000055L, "CALLE", 0, 0, "234 - BO V DE LUJAN, Buenos Aires, General Pueyrredón", 6357110L, "234 - BO V DE LUJAN", "INDEC", 0, 0 },
                    { 635711000060L, "AV", 0, 0, "250 - SAN JORGE JOSE, Buenos Aires, General Pueyrredón", 6357110L, "250 - SAN JORGE JOSE", "INDEC", 0, 0 },
                    { 635711000065L, "CALLE", 0, 0, "3 - TRINIDAD, Buenos Aires, General Pueyrredón", 6357110L, "3 - TRINIDAD", "INDEC", 0, 0 },
                    { 635711000070L, "CALLE", 0, 0, "5 - TRINIDAD, Buenos Aires, General Pueyrredón", 6357110L, "5 - TRINIDAD", "INDEC", 0, 0 },
                    { 635711000075L, "CALLE", 0, 0, "6 - LA TRINIDAD, Buenos Aires, General Pueyrredón", 6357110L, "6 - LA TRINIDAD", "INDEC", 0, 0 },
                    { 635711000080L, "CALLE", 0, 0, "7 - TRINIDAD, Buenos Aires, General Pueyrredón", 6357110L, "7 - TRINIDAD", "INDEC", 0, 0 },
                    { 635711000085L, "CALLE", 0, 0, "8 - LA TRINIDAD, Buenos Aires, General Pueyrredón", 6357110L, "8 - LA TRINIDAD", "INDEC", 0, 0 },
                    { 635711000090L, "CALLE", 0, 0, "9 - TRINIDAD, Buenos Aires, General Pueyrredón", 6357110L, "9 - TRINIDAD", "INDEC", 0, 0 },
                    { 635711000095L, "CALLE", 0, 0, "9 DE JUILO, Buenos Aires, General Pueyrredón", 6357110L, "9 DE JUILO", "INDEC", 0, 0 },
                    { 635711000100L, "CALLE", 0, 0, "A DEL SOLAR, Buenos Aires, General Pueyrredón", 6357110L, "A DEL SOLAR", "INDEC", 0, 0 },
                    { 635711000105L, "CALLE", 0, 0, "A TAPIA, Buenos Aires, General Pueyrredón", 6357110L, "A TAPIA", "INDEC", 0, 0 },
                    { 635711000110L, "CALLE", 3399, 3398, "A VALENTINI, Buenos Aires, General Pueyrredón", 6357110L, "A VALENTINI", "INDEC", 3201, 3200 },
                    { 635711000115L, "CALLE", 3299, 3498, "A GALEANA, Buenos Aires, General Pueyrredón", 6357110L, "A GALEANA", "INDEC", 0, 0 },
                    { 635711000120L, "CALLE", 0, 0, "ABETOS, Buenos Aires, General Pueyrredón", 6357110L, "ABETOS", "INDEC", 0, 0 },
                    { 635711000125L, "CALLE", 43999, 5198, "ABIGAIL BURTHABURU, Buenos Aires, General Pueyrredón", 6357110L, "ABIGAIL BURTHABURU", "INDEC", 0, 0 },
                    { 635711000130L, "CALLE", 0, 0, "ACACIAS, Buenos Aires, General Pueyrredón", 6357110L, "ACACIAS", "INDEC", 0, 0 },
                    { 635711000135L, "CALLE", 3399, 3498, "AGUA BLANCA, Buenos Aires, General Pueyrredón", 6357110L, "AGUA BLANCA", "INDEC", 0, 0 },
                    { 635711000140L, "CALLE", 0, 0, "AGUATERO, Buenos Aires, General Pueyrredón", 6357110L, "AGUATERO", "INDEC", 0, 0 },
                    { 635711000145L, "CALLE", 0, 0, "AGUSTIN MAGALDI, Buenos Aires, General Pueyrredón", 6357110L, "AGUSTIN MAGALDI", "INDEC", 0, 0 },
                    { 635711000150L, "CALLE", 0, 0, "AGUSTIN VILERT, Buenos Aires, General Pueyrredón", 6357110L, "AGUSTIN VILERT", "INDEC", 0, 0 },
                    { 635711000155L, "CALLE", 0, 0, "ALAMO, Buenos Aires, General Pueyrredón", 6357110L, "ALAMO", "INDEC", 0, 0 },
                    { 635711000160L, "CALLE", 8898, 8899, "ALAMOS, Buenos Aires, General Pueyrredón", 6357110L, "ALAMOS", "INDEC", 8500, 0 },
                    { 635711000165L, "CALLE", 0, 0, "ALBERTO GARAGIOLA, Buenos Aires, General Pueyrredón", 6357110L, "ALBERTO GARAGIOLA", "INDEC", 0, 0 },
                    { 635711000170L, "CALLE", 0, 0, "ALFREDO LEPERA, Buenos Aires, General Pueyrredón", 6357110L, "ALFREDO LEPERA", "INDEC", 0, 0 },
                    { 635711000175L, "CALLE", 0, 0, "ALFREDO MARTINEZ BAYA, Buenos Aires, General Pueyrredón", 6357110L, "ALFREDO MARTINEZ BAYA", "INDEC", 0, 0 },
                    { 635711000180L, "CALLE", 98, 99, "ALGARROBOS, Buenos Aires, General Pueyrredón", 6357110L, "ALGARROBOS", "INDEC", 1, 1 },
                    { 635711000185L, "CALLE", 9500, 9499, "ALICOA MOREAU DE JUSTO, Buenos Aires, General Pueyrredón", 6357110L, "ALICOA MOREAU DE JUSTO", "INDEC", 8702, 8701 },
                    { 635711000190L, "CALLE", 0, 0, "ALIPI, Buenos Aires, General Pueyrredón", 6357110L, "ALIPI", "INDEC", 0, 0 },
                    { 635711000195L, "CALLE", 8098, 1999, "ALMONACID, Buenos Aires, General Pueyrredón", 6357110L, "ALMONACID", "INDEC", 0, 0 },
                    { 635711000200L, "CALLE", 0, 0, "ALVAREZ, Buenos Aires, General Pueyrredón", 6357110L, "ALVAREZ", "INDEC", 0, 0 },
                    { 635711000205L, "CALLE", 5999, 5998, "ALVAREZ CONDARCO, Buenos Aires, General Pueyrredón", 6357110L, "ALVAREZ CONDARCO", "INDEC", 0, 0 },
                    { 635711000210L, "CALLE", 0, 0, "ALVARO, Buenos Aires, General Pueyrredón", 6357110L, "ALVARO", "INDEC", 0, 0 },
                    { 635711000215L, "CALLE", 0, 0, "AMADEO COUREL, Buenos Aires, General Pueyrredón", 6357110L, "AMADEO COUREL", "INDEC", 0, 0 },
                    { 635711000220L, "CALLE", 0, 0, "AMADO BOND PLAND, Buenos Aires, General Pueyrredón", 6357110L, "AMADO BOND PLAND", "INDEC", 0, 0 },
                    { 635711000225L, "CALLE", 0, 0, "AMBROSETTI JUAN B, Buenos Aires, General Pueyrredón", 6357110L, "AMBROSETTI JUAN B", "INDEC", 0, 0 },
                    { 635711000230L, "CALLE", 599, 598, "AMEGHINO, Buenos Aires, General Pueyrredón", 6357110L, "AMEGHINO", "INDEC", 201, 200 },
                    { 635711000235L, "CALLE", 5999, 5998, "ANCHORENA, Buenos Aires, General Pueyrredón", 6357110L, "ANCHORENA", "INDEC", 0, 0 },
                    { 635711000240L, "CALLE", 0, 0, "ANGEL VARGAS, Buenos Aires, General Pueyrredón", 6357110L, "ANGEL VARGAS", "INDEC", 0, 0 },
                    { 635711000245L, "CALLE", 0, 0, "ANGELINA PAGANO, Buenos Aires, General Pueyrredón", 6357110L, "ANGELINA PAGANO", "INDEC", 0, 0 },
                    { 635711000250L, "CALLE", 0, 0, "ANTONIO M DIAZ, Buenos Aires, General Pueyrredón", 6357110L, "ANTONIO M DIAZ", "INDEC", 0, 0 },
                    { 635711000255L, "CALLE", 0, 0, "ANTONIO SPINELLI, Buenos Aires, General Pueyrredón", 6357110L, "ANTONIO SPINELLI", "INDEC", 0, 0 },
                    { 635711000260L, "CALLE", 0, 0, "ANTONIO STROPATO, Buenos Aires, General Pueyrredón", 6357110L, "ANTONIO STROPATO", "INDEC", 0, 0 },
                    { 635711000265L, "CALLE", 0, 0, "ARANA Y GOIRI, Buenos Aires, General Pueyrredón", 6357110L, "ARANA Y GOIRI", "INDEC", 0, 0 },
                    { 635711000270L, "CALLE", 11899, 11898, "ARANA Y GOITI, Buenos Aires, General Pueyrredón", 6357110L, "ARANA Y GOITI", "INDEC", 0, 0 },
                    { 635711000275L, "CALLE", 0, 0, "ARDILES, Buenos Aires, General Pueyrredón", 6357110L, "ARDILES", "INDEC", 0, 0 },
                    { 635711000280L, "CALLE", 0, 6898, "ARMANDO CHULAK, Buenos Aires, General Pueyrredón", 6357110L, "ARMANDO CHULAK", "INDEC", 0, 0 },
                    { 635711000285L, "CALLE", 0, 0, "AROMO, Buenos Aires, General Pueyrredón", 6357110L, "AROMO", "INDEC", 0, 0 },
                    { 635711000290L, "CALLE", 5598, 0, "AROMOS, Buenos Aires, General Pueyrredón", 6357110L, "AROMOS", "INDEC", 0, 0 },
                    { 635711000295L, "CALLE", 0, 0, "ARQCEDRON, Buenos Aires, General Pueyrredón", 6357110L, "ARQCEDRON", "INDEC", 0, 0 },
                    { 635711000300L, "CALLE", 4999, 0, "ARROYO CORRIENTES, Buenos Aires, General Pueyrredón", 6357110L, "ARROYO CORRIENTES", "INDEC", 0, 0 },
                    { 635711000305L, "CALLE", 0, 0, "ASTOR PIAZZOLLA, Buenos Aires, General Pueyrredón", 6357110L, "ASTOR PIAZZOLLA", "INDEC", 0, 0 },
                    { 635711000310L, "CALLE", 0, 0, "ATAHUALPA, Buenos Aires, General Pueyrredón", 6357110L, "ATAHUALPA", "INDEC", 0, 0 },
                    { 635711000315L, "CALLE", 3999, 3848, "AUTOPISTA MAR DEL PLATA JORGE NEWBERY, Buenos Aires, General Pueyrredón", 6357110L, "AUTOPISTA MAR DEL PLATA JORGE NEWBERY", "INDEC", 0, 0 },
                    { 635711000320L, "AV", 0, 299, "AV 10 DE FEBRERO, Buenos Aires, General Pueyrredón", 6357110L, "AV 10 DE FEBRERO", "INDEC", 0, 0 },
                    { 635711000325L, "AV", 3198, 3099, "AV 150 - JACINTO PERALTA RAMOS, Buenos Aires, General Pueyrredón", 6357110L, "AV 150 - JACINTO PERALTA RAMOS", "INDEC", 0, 0 },
                    { 635711000330L, "AV", 4498, 4499, "AV 150 INDEPENDENCIA, Buenos Aires, General Pueyrredón", 6357110L, "AV 150 INDEPENDENCIA", "INDEC", 0, 0 },
                    { 635711000335L, "AV", 4698, 3200, "AV 186 - POLONIA, Buenos Aires, General Pueyrredón", 6357110L, "AV 186 - POLONIA", "INDEC", 0, 0 },
                    { 635711000340L, "AV", 4198, 4199, "AV 188 - JARA, Buenos Aires, General Pueyrredón", 6357110L, "AV 188 - JARA", "INDEC", 0, 0 },
                    { 635711000345L, "AV", 8999, 9498, "AV 199 - CONSTITUCION, Buenos Aires, General Pueyrredón", 6357110L, "AV 199 - CONSTITUCION", "INDEC", 0, 0 },
                    { 635711000350L, "AV", 6215, 3899, "AV 210 - CHAMPAGNAT, Buenos Aires, General Pueyrredón", 6357110L, "AV 210 - CHAMPAGNAT", "INDEC", 0, 0 },
                    { 635711000355L, "AV", 3198, 600, "AV 210 - TETAMANTI, Buenos Aires, General Pueyrredón", 6357110L, "AV 210 - TETAMANTI", "INDEC", 0, 0 },
                    { 635711000360L, "AV", 3698, 3699, "AV 234 - ARTURO ALIO, Buenos Aires, General Pueyrredón", 6357110L, "AV 234 - ARTURO ALIO", "INDEC", 50, 0 },
                    { 635711000365L, "AV", 10499, 10748, "AV 239 - LIBERTAD, Buenos Aires, General Pueyrredón", 6357110L, "AV 239 - LIBERTAD", "INDEC", 0, 0 },
                    { 635711000370L, "AV", 10899, 10598, "AV 251 - PEDRO LURO, Buenos Aires, General Pueyrredón", 6357110L, "AV 251 - PEDRO LURO", "INDEC", 0, 0 },
                    { 635711000375L, "AV", 8998, 10999, "AV 263 - COLON, Buenos Aires, General Pueyrredón", 6357110L, "AV 263 - COLON", "INDEC", 0, 0 },
                    { 635711000380L, "AV", 10198, 199, "AV 282 - ALBERT SCHWEITZER, Buenos Aires, General Pueyrredón", 6357110L, "AV 282 - ALBERT SCHWEITZER", "INDEC", 0, 0 },
                    { 635711000385L, "AV", 2198, 2199, "AV 282 - FERMIN ERREA, Buenos Aires, General Pueyrredón", 6357110L, "AV 282 - FERMIN ERREA", "INDEC", 0, 0 },
                    { 635711000390L, "AV", 3999, 3998, "AV 303 - JUAN JOSE PASO, Buenos Aires, General Pueyrredón", 6357110L, "AV 303 - JUAN JOSE PASO", "INDEC", 0, 0 },
                    { 635711000395L, "AV", 55996, 11898, "AV 345 - VERTIZ, Buenos Aires, General Pueyrredón", 6357110L, "AV 345 - VERTIZ", "INDEC", 0, 0 },
                    { 635711000400L, "AV", 9399, 8398, "AV 361 - F DE LA PLAZA, Buenos Aires, General Pueyrredón", 6357110L, "AV 361 - F DE LA PLAZA", "INDEC", 0, 0 },
                    { 635711000405L, "AV", 10969, 9100, "AV 385 - MARIO BRAVO, Buenos Aires, General Pueyrredón", 6357110L, "AV 385 - MARIO BRAVO", "INDEC", 0, 0 },
                    { 635711000410L, "AV", 3199, 3198, "AV 66 - CERVANTES SAAVEDRA, Buenos Aires, General Pueyrredón", 6357110L, "AV 66 - CERVANTES SAAVEDRA", "INDEC", 0, 0 },
                    { 635711000415L, "AV", 3198, 3099, "AV 90 - THOMAS ALVA EDISON, Buenos Aires, General Pueyrredón", 6357110L, "AV 90 - THOMAS ALVA EDISON", "INDEC", 0, 0 },
                    { 635711000420L, "AV", 4299, 4598, "AV ANTARTIDA ARGENTINA, Buenos Aires, General Pueyrredón", 6357110L, "AV ANTARTIDA ARGENTINA", "INDEC", 0, 0 },
                    { 635711000425L, "AV", 2699, 6698, "AV CAMET FELIX, Buenos Aires, General Pueyrredón", 6357110L, "AV CAMET FELIX", "INDEC", 0, 0 },
                    { 635711000430L, "AV", 0, 0, "AV CANOSA AMERICO R, Buenos Aires, General Pueyrredón", 6357110L, "AV CANOSA AMERICO R", "INDEC", 0, 0 },
                    { 635711000435L, "AV", 1899, 1898, "AV CARLOS GARDEL, Buenos Aires, General Pueyrredón", 6357110L, "AV CARLOS GARDEL", "INDEC", 0, 0 },
                    { 635711000440L, "AV", 6599, 6598, "AV CIRCUNVALACION MEYRELLES, Buenos Aires, General Pueyrredón", 6357110L, "AV CIRCUNVALACION MEYRELLES", "INDEC", 5801, 0 },
                    { 635711000445L, "AV", 0, 0, "AV DE LA HERRADURA, Buenos Aires, General Pueyrredón", 6357110L, "AV DE LA HERRADURA", "INDEC", 0, 0 },
                    { 635711000450L, "AV", 898, 8999, "AV DE LA TORRE, Buenos Aires, General Pueyrredón", 6357110L, "AV DE LA TORRE", "INDEC", 0, 0 },
                    { 635711000455L, "AV", 1098, 998, "AV DE LAS OLIMPIADAS, Buenos Aires, General Pueyrredón", 6357110L, "AV DE LAS OLIMPIADAS", "INDEC", 0, 0 },
                    { 635711000460L, "AV", 0, 0, "AV DE LOS JUBILADOS, Buenos Aires, General Pueyrredón", 6357110L, "AV DE LOS JUBILADOS", "INDEC", 0, 0 },
                    { 635711000465L, "AV", 0, 0, "AV DE LOS PESCADORES, Buenos Aires, General Pueyrredón", 6357110L, "AV DE LOS PESCADORES", "INDEC", 0, 0 },
                    { 635711000470L, "AV", 5475, 4499, "AV DE LOS TRABAJADORES, Buenos Aires, General Pueyrredón", 6357110L, "AV DE LOS TRABAJADORES", "INDEC", 0, 0 },
                    { 635711000475L, "AV", 0, 0, "AV DORREGO, Buenos Aires, General Pueyrredón", 6357110L, "AV DORREGO", "INDEC", 0, 0 },
                    { 635711000480L, "AV", 0, 399, "AV HARAS TARANTINO, Buenos Aires, General Pueyrredón", 6357110L, "AV HARAS TARANTINO", "INDEC", 0, 0 },
                    { 635711000485L, "AV", 0, 0, "AV HIPODROMO, Buenos Aires, General Pueyrredón", 6357110L, "AV HIPODROMO", "INDEC", 0, 0 },
                    { 635711000490L, "AV", 2499, 2498, "AV INGENIERO DELLA PAOLERA, Buenos Aires, General Pueyrredón", 6357110L, "AV INGENIERO DELLA PAOLERA", "INDEC", 0, 0 },
                    { 635711000495L, "AV", 0, 0, "AV ISLA SOLEDAD, Buenos Aires, General Pueyrredón", 6357110L, "AV ISLA SOLEDAD", "INDEC", 0, 0 },
                    { 635711000500L, "AV", 8999, 85898, "AV JUAN B JUSTO, Buenos Aires, General Pueyrredón", 6357110L, "AV JUAN B JUSTO", "INDEC", 0, 0 },
                    { 635711000505L, "AV", 1198, 5388, "AV LOS PLATANOS, Buenos Aires, General Pueyrredón", 6357110L, "AV LOS PLATANOS", "INDEC", 0, 0 },
                    { 635711000510L, "AV", 0, 0, "AV LURO, Buenos Aires, General Pueyrredón", 6357110L, "AV LURO", "INDEC", 0, 0 },
                    { 635711000515L, "AV", 0, 0, "AV MONSENOR ZABALA, Buenos Aires, General Pueyrredón", 6357110L, "AV MONSENOR ZABALA", "INDEC", 0, 0 },
                    { 635711000520L, "AV", 0, 0, "AV PERITO MORENO, Buenos Aires, General Pueyrredón", 6357110L, "AV PERITO MORENO", "INDEC", 0, 0 },
                    { 635711000525L, "AV", 198, 0, "AV PRESIDENTE PERON, Buenos Aires, General Pueyrredón", 6357110L, "AV PRESIDENTE PERON", "INDEC", 0, 0 },
                    { 635711000530L, "AV", 0, 0, "AV SALVADOR VIVAS, Buenos Aires, General Pueyrredón", 6357110L, "AV SALVADOR VIVAS", "INDEC", 0, 0 },
                    { 635711000535L, "AV", 3698, 3699, "AV TEJEDOR CARLOS, Buenos Aires, General Pueyrredón", 6357110L, "AV TEJEDOR CARLOS", "INDEC", 0, 0 },
                    { 635711000540L, "CALLE", 0, 0, "AVELLANEDA, Buenos Aires, General Pueyrredón", 6357110L, "AVELLANEDA", "INDEC", 0, 0 },
                    { 635711000545L, "CALLE", 0, 0, "AYELEP, Buenos Aires, General Pueyrredón", 6357110L, "AYELEP", "INDEC", 0, 0 },
                    { 635711000550L, "CALLE", 72988, 72999, "AYOLAS, Buenos Aires, General Pueyrredón", 6357110L, "AYOLAS", "INDEC", 0, 0 },
                    { 635711000555L, "CALLE", 0, 0, "AZARA, Buenos Aires, General Pueyrredón", 6357110L, "AZARA", "INDEC", 0, 0 },
                    { 635711000560L, "CALLE", 0, 0, "AZARA F, Buenos Aires, General Pueyrredón", 6357110L, "AZARA F", "INDEC", 0, 0 },
                    { 635711000565L, "CALLE", 0, 0, "AZUCENA MAIZANI, Buenos Aires, General Pueyrredón", 6357110L, "AZUCENA MAIZANI", "INDEC", 0, 0 },
                    { 635711000570L, "CALLE", 0, 0, "B BALERDI, Buenos Aires, General Pueyrredón", 6357110L, "B BALERDI", "INDEC", 0, 0 },
                    { 635711000575L, "CALLE", 0, 0, "B LYNCH, Buenos Aires, General Pueyrredón", 6357110L, "B LYNCH", "INDEC", 0, 0 },
                    { 635711000580L, "CALLE", 0, 0, "B BALERDI, Buenos Aires, General Pueyrredón", 6357110L, "B BALERDI", "INDEC", 0, 0 },
                    { 635711000585L, "CALLE", 0, 0, "BAHIA SAN BLAS, Buenos Aires, General Pueyrredón", 6357110L, "BAHIA SAN BLAS", "INDEC", 0, 0 },
                    { 635711000590L, "CALLE", 0, 0, "BAHIA THETIS, Buenos Aires, General Pueyrredón", 6357110L, "BAHIA THETIS", "INDEC", 0, 0 },
                    { 635711000595L, "CALLE", 6499, 6498, "BAIGORRITA, Buenos Aires, General Pueyrredón", 6357110L, "BAIGORRITA", "INDEC", 0, 0 },
                    { 635711000600L, "CALLE", 0, 0, "BALCARCE, Buenos Aires, General Pueyrredón", 6357110L, "BALCARCE", "INDEC", 0, 0 },
                    { 635711000605L, "CALLE", 0, 0, "BANUELOS, Buenos Aires, General Pueyrredón", 6357110L, "BANUELOS", "INDEC", 0, 0 },
                    { 635711000610L, "CALLE", 0, 0, "BASSI, Buenos Aires, General Pueyrredón", 6357110L, "BASSI", "INDEC", 0, 0 },
                    { 635711000615L, "CALLE", 3499, 3988, "BAUTISTA, Buenos Aires, General Pueyrredón", 6357110L, "BAUTISTA", "INDEC", 0, 0 },
                    { 635711000620L, "CALLE", 2, 55798, "BELTRAN, Buenos Aires, General Pueyrredón", 6357110L, "BELTRAN", "INDEC", 0, 0 },
                    { 635711000625L, "CALLE", 0, 0, "BENITO LYNCH, Buenos Aires, General Pueyrredón", 6357110L, "BENITO LYNCH", "INDEC", 0, 0 },
                    { 635711000630L, "CALLE", 0, 0, "BIGUA, Buenos Aires, General Pueyrredón", 6357110L, "BIGUA", "INDEC", 0, 0 },
                    { 635711000635L, "CALLE", 0, 0, "BLANCO, Buenos Aires, General Pueyrredón", 6357110L, "BLANCO", "INDEC", 0, 0 },
                    { 635711000640L, "CALLE", 0, 0, "BORMIDA, Buenos Aires, General Pueyrredón", 6357110L, "BORMIDA", "INDEC", 0, 0 },
                    { 635711000645L, "CALLE", 9399, 9498, "BOSQUE GRANDE, Buenos Aires, General Pueyrredón", 6357110L, "BOSQUE GRANDE", "INDEC", 0, 9001 },
                    { 635711000650L, "CALLE", 9499, 9498, "BOUCHARD, Buenos Aires, General Pueyrredón", 6357110L, "BOUCHARD", "INDEC", 1500, 1501 },
                    { 635711000655L, "CALLE", 0, 0, "BOULEVARD BOSQUE NORTE, Buenos Aires, General Pueyrredón", 6357110L, "BOULEVARD BOSQUE NORTE", "INDEC", 0, 0 },
                    { 635711000660L, "CALLE", 0, 0, "BOULEVARD DEL BOSQUE, Buenos Aires, General Pueyrredón", 6357110L, "BOULEVARD DEL BOSQUE", "INDEC", 0, 0 },
                    { 635711000665L, "CALLE", 0, 0, "BRAGADAO BIS, Buenos Aires, General Pueyrredón", 6357110L, "BRAGADAO BIS", "INDEC", 0, 0 },
                    { 635711000670L, "CALLE", 0, 0, "BROCHERO, Buenos Aires, General Pueyrredón", 6357110L, "BROCHERO", "INDEC", 0, 0 },
                    { 635711000675L, "CALLE", 1498, 5999, "BULEVARD MARITIMO P P RAMOS, Buenos Aires, General Pueyrredón", 6357110L, "BULEVARD MARITIMO P P RAMOS", "INDEC", 0, 0 },
                    { 635711000680L, "CALLE", 0, 0, "BUQUE PESQUERO SAN FRANCISCO, Buenos Aires, General Pueyrredón", 6357110L, "BUQUE PESQUERO SAN FRANCISCO", "INDEC", 0, 0 },
                    { 635711000685L, "CALLE", 0, 0, "BV DEL BOSQUE, Buenos Aires, General Pueyrredón", 6357110L, "BV DEL BOSQUE", "INDEC", 0, 0 },
                    { 635711000690L, "CALLE", 0, 0, "BVARD DEL BOSQUE, Buenos Aires, General Pueyrredón", 6357110L, "BVARD DEL BOSQUE", "INDEC", 0, 0 },
                    { 635711000695L, "CALLE", 0, 0, "C 0 BIS, Buenos Aires, General Pueyrredón", 6357110L, "C 0 BIS", "INDEC", 0, 0 },
                    { 635711000700L, "CALLE", 0, 0, "C 10, Buenos Aires, General Pueyrredón", 6357110L, "C 10", "INDEC", 0, 0 },
                    { 635711000705L, "CALLE", 3098, 3199, "C 100 - ALVEAR DE BOSCH, Buenos Aires, General Pueyrredón", 6357110L, "C 100 - ALVEAR DE BOSCH", "INDEC", 0, 0 },
                    { 635711000710L, "CALLE", 4998, 4999, "C 100 - GRL RIVAS, Buenos Aires, General Pueyrredón", 6357110L, "C 100 - GRL RIVAS", "INDEC", 0, 2301 },
                    { 635711000715L, "CALLE", 3198, 3199, "C 102 - DON ORIONE, Buenos Aires, General Pueyrredón", 6357110L, "C 102 - DON ORIONE", "INDEC", 0, 0 },
                    { 635711000720L, "CALLE", 4998, 4999, "C 102 - LAVALLE, Buenos Aires, General Pueyrredón", 6357110L, "C 102 - LAVALLE", "INDEC", 0, 2201 },
                    { 635711000725L, "CALLE", 3198, 3199, "C 104 - LANZILOTA, Buenos Aires, General Pueyrredón", 6357110L, "C 104 - LANZILOTA", "INDEC", 0, 0 },
                    { 635711000730L, "CALLE", 33992, 44984, "C 104 - PAUNERO, Buenos Aires, General Pueyrredón", 6357110L, "C 104 - PAUNERO", "INDEC", 2101, 2100 },
                    { 635711000735L, "CALLE", 3198, 3199, "C 106 - JURAMENTO, Buenos Aires, General Pueyrredón", 6357110L, "C 106 - JURAMENTO", "INDEC", 0, 0 },
                    { 635711000740L, "CALLE", 4998, 4999, "C 106 - MENDOZA, Buenos Aires, General Pueyrredón", 6357110L, "C 106 - MENDOZA", "INDEC", 2001, 2001 },
                    { 635711000745L, "CALLE", 3198, 3199, "C 108 - ALEJANDRO KORN, Buenos Aires, General Pueyrredón", 6357110L, "C 108 - ALEJANDRO KORN", "INDEC", 0, 0 },
                    { 635711000750L, "CALLE", 4998, 4899, "C 108 - VIAMONTE, Buenos Aires, General Pueyrredón", 6357110L, "C 108 - VIAMONTE", "INDEC", 1900, 0 },
                    { 635711000755L, "CALLE", 0, 0, "C 11, Buenos Aires, General Pueyrredón", 6357110L, "C 11", "INDEC", 0, 0 },
                    { 635711000760L, "CALLE", 4998, 4899, "C 110 - ALVEAR, Buenos Aires, General Pueyrredón", 6357110L, "C 110 - ALVEAR", "INDEC", 0, 0 },
                    { 635711000765L, "CALLE", 3198, 3199, "C 110 - HERNANDEZ, Buenos Aires, General Pueyrredón", 6357110L, "C 110 - HERNANDEZ", "INDEC", 0, 0 },
                    { 635711000770L, "CALLE", 2898, 2899, "C 112 - ALVEAR, Buenos Aires, General Pueyrredón", 6357110L, "C 112 - ALVEAR", "INDEC", 0, 0 },
                    { 635711000775L, "CALLE", 4898, 4899, "C 112 - GUEMES, Buenos Aires, General Pueyrredón", 6357110L, "C 112 - GUEMES", "INDEC", 0, 0 },
                    { 635711000780L, "CALLE", 3198, 3199, "C 114 - CERRITO, Buenos Aires, General Pueyrredón", 6357110L, "C 114 - CERRITO", "INDEC", 0, 0 },
                    { 635711000785L, "CALLE", 4898, 4899, "C 114 - OLAVARRIA, Buenos Aires, General Pueyrredón", 6357110L, "C 114 - OLAVARRIA", "INDEC", 0, 0 },
                    { 635711000790L, "CALLE", 4898, 4899, "C 116 - ALSINA, Buenos Aires, General Pueyrredón", 6357110L, "C 116 - ALSINA", "INDEC", 0, 0 },
                    { 635711000795L, "CALLE", 3198, 3199, "C 116 - JOSE MARTI, Buenos Aires, General Pueyrredón", 6357110L, "C 116 - JOSE MARTI", "INDEC", 0, 0 },
                    { 635711000800L, "CALLE", 7399, 7398, "C 117 - J ZACAGNINI, Buenos Aires, General Pueyrredón", 6357110L, "C 117 - J ZACAGNINI", "INDEC", 0, 0 },
                    { 635711000805L, "CALLE", 3198, 3199, "C 118 - GIANELLI, Buenos Aires, General Pueyrredón", 6357110L, "C 118 - GIANELLI", "INDEC", 0, 0 },
                    { 635711000810L, "CALLE", 4898, 4799, "C 118 - SARMIENTO, Buenos Aires, General Pueyrredón", 6357110L, "C 118 - SARMIENTO", "INDEC", 0, 0 },
                    { 635711000815L, "CALLE", 0, 0, "C 12, Buenos Aires, General Pueyrredón", 6357110L, "C 12", "INDEC", 0, 0 },
                    { 635711000820L, "CALLE", 0, 0, "C 12 BIS, Buenos Aires, General Pueyrredón", 6357110L, "C 12 BIS", "INDEC", 0, 0 },
                    { 635711000825L, "CALLE", 4798, 4799, "C 120 - LAS HERAS, Buenos Aires, General Pueyrredón", 6357110L, "C 120 - LAS HERAS", "INDEC", 0, 0 },
                    { 635711000830L, "CALLE", 3198, 3199, "C 120 - SANTA CECILIA, Buenos Aires, General Pueyrredón", 6357110L, "C 120 - SANTA CECILIA", "INDEC", 0, 0 },
                    { 635711000835L, "CALLE", 3198, 3199, "C 122 - FLEMMING, Buenos Aires, General Pueyrredón", 6357110L, "C 122 - FLEMMING", "INDEC", 0, 1 },
                    { 635711000840L, "CALLE", 4798, 4799, "C 122 - LAMADRID, Buenos Aires, General Pueyrredón", 6357110L, "C 122 - LAMADRID", "INDEC", 0, 0 },
                    { 635711000845L, "CALLE", 3198, 3199, "C 124 - LUIS AGOTE, Buenos Aires, General Pueyrredón", 6357110L, "C 124 - LUIS AGOTE", "INDEC", 0, 0 },
                    { 635711000850L, "CALLE", 4698, 4699, "C 124 - ARENALES, Buenos Aires, General Pueyrredón", 6357110L, "C 124 - ARENALES", "INDEC", 0, 0 },
                    { 635711000855L, "CALLE", 3198, 3199, "C 126 - GALICIA, Buenos Aires, General Pueyrredón", 6357110L, "C 126 - GALICIA", "INDEC", 0, 0 },
                    { 635711000860L, "CALLE", 4798, 4799, "C 126 - TUCUMAN, Buenos Aires, General Pueyrredón", 6357110L, "C 126 - TUCUMAN", "INDEC", 2200, 2201 },
                    { 635711000865L, "CALLE", 4798, 4699, "C 128 - BUENOS AIRES, Buenos Aires, General Pueyrredón", 6357110L, "C 128 - BUENOS AIRES", "INDEC", 0, 0 },
                    { 635711000870L, "CALLE", 3198, 3199, "C 128 - ESTEBAN ECHEVERRIA, Buenos Aires, General Pueyrredón", 6357110L, "C 128 - ESTEBAN ECHEVERRIA", "INDEC", 0, 1 },
                    { 635711000875L, "CALLE", 4698, 4699, "C 130 - ENTRE RIOS, Buenos Aires, General Pueyrredón", 6357110L, "C 130 - ENTRE RIOS", "INDEC", 0, 0 },
                    { 635711000880L, "CALLE", 3198, 3199, "C 130 - ROQUE SAENZ PENA, Buenos Aires, General Pueyrredón", 6357110L, "C 130 - ROQUE SAENZ PENA", "INDEC", 0, 0 },
                    { 635711000885L, "CALLE", 4698, 4699, "C 132 - CORRIENTES, Buenos Aires, General Pueyrredón", 6357110L, "C 132 - CORRIENTES", "INDEC", 0, 1501 },
                    { 635711000890L, "CALLE", 3198, 3199, "C 132 - GRL M SAVIO, Buenos Aires, General Pueyrredón", 6357110L, "C 132 - GRL M SAVIO", "INDEC", 0, 0 },
                    { 635711000895L, "CALLE", 10098, 3099, "C 134 - GRL R DE RIEGO, Buenos Aires, General Pueyrredón", 6357110L, "C 134 - GRL R DE RIEGO", "INDEC", 0, 0 },
                    { 635711000900L, "CALLE", 4698, 4699, "C 134 - SANTA FE, Buenos Aires, General Pueyrredón", 6357110L, "C 134 - SANTA FE", "INDEC", 1200, 0 },
                    { 635711000905L, "CALLE", 3098, 3199, "C 136 - MATEOTTI, Buenos Aires, General Pueyrredón", 6357110L, "C 136 - MATEOTTI", "INDEC", 0, 0 },
                    { 635711000910L, "CALLE", 4698, 4699, "C 136 - SANTIAGO DEL ESTERO, Buenos Aires, General Pueyrredón", 6357110L, "C 136 - SANTIAGO DEL ESTERO", "INDEC", 0, 0 },
                    { 635711000915L, "CALLE", 4698, 4651, "C 138 - CORDOBA, Buenos Aires, General Pueyrredón", 6357110L, "C 138 - CORDOBA", "INDEC", 0, 0 },
                    { 635711000920L, "CALLE", 3198, 47996, "C 138 - TALCAHUANO, Buenos Aires, General Pueyrredón", 6357110L, "C 138 - TALCAHUANO", "INDEC", 0, 0 },
                    { 635711000925L, "CALLE", 0, 0, "C 14, Buenos Aires, General Pueyrredón", 6357110L, "C 14", "INDEC", 0, 0 },
                    { 635711000930L, "CALLE", 5698, 3099, "C 140 - LUIS DELLEPIANE, Buenos Aires, General Pueyrredón", 6357110L, "C 140 - LUIS DELLEPIANE", "INDEC", 0, 0 },
                    { 635711000935L, "CALLE", 4650, 4599, "C 140 - SAN LUIS, Buenos Aires, General Pueyrredón", 6357110L, "C 140 - SAN LUIS", "INDEC", 0, 0 },
                    { 635711000940L, "CALLE", 3198, 3199, "C 142 - ANTONIO VALENTINI, Buenos Aires, General Pueyrredón", 6357110L, "C 142 - ANTONIO VALENTINI", "INDEC", 0, 0 },
                    { 635711000945L, "CALLE", 4598, 4599, "C 142 - BARTOLOME MITRE, Buenos Aires, General Pueyrredón", 6357110L, "C 142 - BARTOLOME MITRE", "INDEC", 0, 0 },
                    { 635711000950L, "CALLE", 3098, 2999, "C 144 - AMBROSIO BESTOSO, Buenos Aires, General Pueyrredón", 6357110L, "C 144 - AMBROSIO BESTOSO", "INDEC", 0, 0 },
                    { 635711000955L, "CALLE", 4598, 4599, "C 144 - HIPOLITO YRIGOYEN, Buenos Aires, General Pueyrredón", 6357110L, "C 144 - HIPOLITO YRIGOYEN", "INDEC", 0, 0 },
                    { 635711000960L, "CALLE", 3198, 3199, "C 146 - JUANA MANSO, Buenos Aires, General Pueyrredón", 6357110L, "C 146 - JUANA MANSO", "INDEC", 0, 0 },
                    { 635711000965L, "CALLE", 17978, 4599, "C 146 - LA RIOJA, Buenos Aires, General Pueyrredón", 6357110L, "C 146 - LA RIOJA", "INDEC", 0, 0 },
                    { 635711000970L, "CALLE", 5099, 5098, "C 147 - CURA BROCHERO, Buenos Aires, General Pueyrredón", 6357110L, "C 147 - CURA BROCHERO", "INDEC", 0, 0 },
                    { 635711000975L, "CALLE", 4598, 4499, "C 148 - CATAMARCA, Buenos Aires, General Pueyrredón", 6357110L, "C 148 - CATAMARCA", "INDEC", 0, 0 },
                    { 635711000980L, "CALLE", 5698, 6099, "C 148 - F SANCHEZ, Buenos Aires, General Pueyrredón", 6357110L, "C 148 - F SANCHEZ", "INDEC", 0, 0 },
                    { 635711000985L, "CALLE", 5199, 5198, "C 149 - FRAY LUIS BELTRAN, Buenos Aires, General Pueyrredón", 6357110L, "C 149 - FRAY LUIS BELTRAN", "INDEC", 0, 0 },
                    { 635711000990L, "CALLE", 4299, 4298, "C 152 - C VILLAR, Buenos Aires, General Pueyrredón", 6357110L, "C 152 - C VILLAR", "INDEC", 0, 0 },
                    { 635711000995L, "CALLE", 4498, 4399, "C 152 - SALTA, Buenos Aires, General Pueyrredón", 6357110L, "C 152 - SALTA", "INDEC", 0, 0 },
                    { 635711001000L, "CALLE", 53999, 5998, "C 153 - F DE ARANA, Buenos Aires, General Pueyrredón", 6357110L, "C 153 - F DE ARANA", "INDEC", 0, 0 },
                    { 635711001005L, "CALLE", 2798, 6999, "C 154 - GONZALES CHAVES, Buenos Aires, General Pueyrredón", 6357110L, "C 154 - GONZALES CHAVES", "INDEC", 0, 0 },
                    { 635711001010L, "CALLE", 4398, 4399, "C 154 - JUJUY, Buenos Aires, General Pueyrredón", 6357110L, "C 154 - JUJUY", "INDEC", 0, 1 },
                    { 635711001015L, "CALLE", 35799, 5998, "C 155 - GODOY CRUZ, Buenos Aires, General Pueyrredón", 6357110L, "C 155 - GODOY CRUZ", "INDEC", 0, 0 },
                    { 635711001020L, "CALLE", 2798, 2799, "C 156 - CIUDAD DE DOLORES, Buenos Aires, General Pueyrredón", 6357110L, "C 156 - CIUDAD DE DOLORES", "INDEC", 0, 0 },
                    { 635711001025L, "CALLE", 4498, 4499, "C 156 - ESPANA, Buenos Aires, General Pueyrredón", 6357110L, "C 156 - ESPANA", "INDEC", 100, 0 },
                    { 635711001030L, "CALLE", 4999, 5098, "C 157 - FERRE, Buenos Aires, General Pueyrredón", 6357110L, "C 157 - FERRE", "INDEC", 0, 0 },
                    { 635711001035L, "CALLE", 1898, 1899, "C 1570 - QUINQUELA MARTIN, Buenos Aires, General Pueyrredón", 6357110L, "C 1570 - QUINQUELA MARTIN", "INDEC", 1100, 1101 },
                    { 635711001040L, "CALLE", 4498, 4399, "C 158 - 20 - DE SEPTIEMBRE, Buenos Aires, General Pueyrredón", 6357110L, "C 158 - 20 - DE SEPTIEMBRE", "INDEC", 0, 0 },
                    { 635711001045L, "CALLE", 2798, 2799, "C 158 - DR M CASTEX, Buenos Aires, General Pueyrredón", 6357110L, "C 158 - DR M CASTEX", "INDEC", 0, 0 },
                    { 635711001050L, "CALLE", 5799, 5798, "C 159 - CASEROS, Buenos Aires, General Pueyrredón", 6357110L, "C 159 - CASEROS", "INDEC", 4501, 500 },
                    { 635711001055L, "CALLE", 5199, 14898, "C 159 - ESTANISLAO ZEBALLOS, Buenos Aires, General Pueyrredón", 6357110L, "C 159 - ESTANISLAO ZEBALLOS", "INDEC", 0, 0 },
                    { 635711001060L, "CALLE", 0, 0, "C 16, Buenos Aires, General Pueyrredón", 6357110L, "C 16", "INDEC", 0, 0 },
                    { 635711001065L, "CALLE", 4399, 4398, "C 160 - 14 DE JULIO, Buenos Aires, General Pueyrredón", 6357110L, "C 160 - 14 DE JULIO", "INDEC", 0, 0 },
                    { 635711001070L, "CALLE", 2798, 2799, "C 160 - MONSENOR RAU, Buenos Aires, General Pueyrredón", 6357110L, "C 160 - MONSENOR RAU", "INDEC", 0, 0 },
                    { 635711001075L, "CALLE", 5398, 5399, "C 161 - ANCHORENA, Buenos Aires, General Pueyrredón", 6357110L, "C 161 - ANCHORENA", "INDEC", 0, 0 },
                    { 635711001080L, "CALLE", 4399, 4398, "C 162 - DORREGO, Buenos Aires, General Pueyrredón", 6357110L, "C 162 - DORREGO", "INDEC", 0, 0 },
                    { 635711001085L, "CALLE", 2798, 1999, "C 162 - FRIULLI, Buenos Aires, General Pueyrredón", 6357110L, "C 162 - FRIULLI", "INDEC", 0, 0 },
                    { 635711001090L, "CALLE", 4898, 5199, "C 163 - GRL MANSILLA, Buenos Aires, General Pueyrredón", 6357110L, "C 163 - GRL MANSILLA", "INDEC", 0, 0 },
                    { 635711001095L, "CALLE", 2398, 2399, "C 164 - CNL CELESTINO VIDAL, Buenos Aires, General Pueyrredón", 6357110L, "C 164 - CNL CELESTINO VIDAL", "INDEC", 0, 0 },
                    { 635711001100L, "CALLE", 4399, 4398, "C 164 - GUIDO, Buenos Aires, General Pueyrredón", 6357110L, "C 164 - GUIDO", "INDEC", 0, 0 },
                    { 635711001105L, "CALLE", 5098, 4998, "C 165 - VUELTA DE OBLIGADO, Buenos Aires, General Pueyrredón", 6357110L, "C 165 - VUELTA DE OBLIGADO", "INDEC", 0, 0 },
                    { 635711001110L, "CALLE", 3699, 4398, "C 166 - DEAN FUNES, Buenos Aires, General Pueyrredón", 6357110L, "C 166 - DEAN FUNES", "INDEC", 0, 0 },
                    { 635711001115L, "CALLE", 7198, 1999, "C 166 - UDINE, Buenos Aires, General Pueyrredón", 6357110L, "C 166 - UDINE", "INDEC", 0, 0 },
                    { 635711001120L, "CALLE", 5199, 5798, "C 167 - CHAPEAUROUGE, Buenos Aires, General Pueyrredón", 6357110L, "C 167 - CHAPEAUROUGE", "INDEC", 0, 4500 },
                    { 635711001125L, "CALLE", 4200, 4099, "C 168 - OLAZABAL, Buenos Aires, General Pueyrredón", 6357110L, "C 168 - OLAZABAL", "INDEC", 0, 0 },
                    { 635711001130L, "CALLE", 1698, 1699, "C 170 - PATAGONES, Buenos Aires, General Pueyrredón", 6357110L, "C 170 - PATAGONES", "INDEC", 0, 0 },
                    { 635711001135L, "CALLE", 4199, 4298, "C 170 - SAN JUAN, Buenos Aires, General Pueyrredón", 6357110L, "C 170 - SAN JUAN", "INDEC", 1, 0 },
                    { 635711001140L, "CALLE", 1798, 1699, "C 172 - BLAS PARERA, Buenos Aires, General Pueyrredón", 6357110L, "C 172 - BLAS PARERA", "INDEC", 0, 0 },
                    { 635711001145L, "CALLE", 3399, 3298, "C 172 - LA PAMPA, Buenos Aires, General Pueyrredón", 6357110L, "C 172 - LA PAMPA", "INDEC", 1, 0 },
                    { 635711001150L, "CALLE", 7399, 7398, "C 173 - MARIE CURIE, Buenos Aires, General Pueyrredón", 6357110L, "C 173 - MARIE CURIE", "INDEC", 0, 0 },
                    { 635711001155L, "CALLE", 4298, 4299, "C 174 - CHACO, Buenos Aires, General Pueyrredón", 6357110L, "C 174 - CHACO", "INDEC", 1, 0 },
                    { 635711001160L, "CALLE", 1998, 2099, "C 174 - LIBRES DEL SUD, Buenos Aires, General Pueyrredón", 6357110L, "C 174 - LIBRES DEL SUD", "INDEC", 0, 0 },
                    { 635711001165L, "CALLE", 3198, 3199, "C 174 - RCA DE CUBA, Buenos Aires, General Pueyrredón", 6357110L, "C 174 - RCA DE CUBA", "INDEC", 0, 0 },
                    { 635711001170L, "CALLE", 7299, 14898, "C 175 - J M ESTRADA, Buenos Aires, General Pueyrredón", 6357110L, "C 175 - J M ESTRADA", "INDEC", 0, 0 },
                    { 635711001175L, "CALLE", 2798, 5899, "C 176 - DE LOS INMIGRANTES, Buenos Aires, General Pueyrredón", 6357110L, "C 176 - DE LOS INMIGRANTES", "INDEC", 0, 0 },
                    { 635711001180L, "CALLE", 2398, 2399, "C 176 - FRAY MAMERTO ESQUIU, Buenos Aires, General Pueyrredón", 6357110L, "C 176 - FRAY MAMERTO ESQUIU", "INDEC", 0, 0 },
                    { 635711001185L, "CALLE", 3398, 3399, "C 176 - MISIONES, Buenos Aires, General Pueyrredón", 6357110L, "C 176 - MISIONES", "INDEC", 1, 0 },
                    { 635711001190L, "CALLE", 8098, 8099, "C 177 - J A AGUIRRE, Buenos Aires, General Pueyrredón", 6357110L, "C 177 - J A AGUIRRE", "INDEC", 0, 0 },
                    { 635711001195L, "CALLE", 2698, 49999, "C 178 - INT J CAMUSO, Buenos Aires, General Pueyrredón", 6357110L, "C 178 - INT J CAMUSO", "INDEC", 0, 0 },
                    { 635711001200L, "CALLE", 4198, 4199, "C 178 - ITALIA, Buenos Aires, General Pueyrredón", 6357110L, "C 178 - ITALIA", "INDEC", 0, 0 },
                    { 635711001205L, "CALLE", 2698, 2799, "C 178 - PASTEUR, Buenos Aires, General Pueyrredón", 6357110L, "C 178 - PASTEUR", "INDEC", 0, 0 },
                    { 635711001210L, "CALLE", 7999, 8098, "C 179 - A ALICE, Buenos Aires, General Pueyrredón", 6357110L, "C 179 - A ALICE", "INDEC", 0, 0 },
                    { 635711001215L, "CALLE", 0, 0, "C 18, Buenos Aires, General Pueyrredón", 6357110L, "C 18", "INDEC", 0, 0 },
                    { 635711001220L, "CALLE", 2998, 3099, "C 180 - MANUELA PEDRAZA, Buenos Aires, General Pueyrredón", 6357110L, "C 180 - MANUELA PEDRAZA", "INDEC", 0, 0 },
                    { 635711001225L, "CALLE", 4198, 4199, "C 180 - NEUQUEN, Buenos Aires, General Pueyrredón", 6357110L, "C 180 - NEUQUEN", "INDEC", 0, 0 },
                    { 635711001230L, "CALLE", 2798, 2799, "C 180 - OSVALDO MAGNASCO, Buenos Aires, General Pueyrredón", 6357110L, "C 180 - OSVALDO MAGNASCO", "INDEC", 0, 0 },
                    { 635711001235L, "CALLE", 7899, 7998, "C 181 - ALFONSINA STORNI, Buenos Aires, General Pueyrredón", 6357110L, "C 181 - ALFONSINA STORNI", "INDEC", 0, 0 },
                    { 635711001240L, "CALLE", 2799, 2798, "C 182 - CEFERINO NAMUNCURA, Buenos Aires, General Pueyrredón", 6357110L, "C 182 - CEFERINO NAMUNCURA", "INDEC", 0, 0 },
                    { 635711001245L, "CALLE", 3098, 3099, "C 182 - CHUBUT, Buenos Aires, General Pueyrredón", 6357110L, "C 182 - CHUBUT", "INDEC", 0, 0 },
                    { 635711001250L, "CALLE", 4198, 4199, "C 182 - DON BOSCO, Buenos Aires, General Pueyrredón", 6357110L, "C 182 - DON BOSCO", "INDEC", 0, 0 },
                    { 635711001255L, "CALLE", 7999, 7998, "C 183 - P MUGABURU, Buenos Aires, General Pueyrredón", 6357110L, "C 183 - P MUGABURU", "INDEC", 0, 0 },
                    { 635711001260L, "CALLE", 4198, 4999, "C 184 - FRANCIA, Buenos Aires, General Pueyrredón", 6357110L, "C 184 - FRANCIA", "INDEC", 0, 0 },
                    { 635711001265L, "CALLE", 4698, 2798, "C 184 - H BRUMANA, Buenos Aires, General Pueyrredón", 6357110L, "C 184 - H BRUMANA", "INDEC", 0, 0 },
                    { 635711001270L, "CALLE", 7999, 58798, "C 185 - M SAGASTIZABAL, Buenos Aires, General Pueyrredón", 6357110L, "C 185 - M SAGASTIZABAL", "INDEC", 0, 0 },
                    { 635711001275L, "CALLE", 8098, 7999, "C 187 - J ACEVEDO, Buenos Aires, General Pueyrredón", 6357110L, "C 187 - J ACEVEDO", "INDEC", 0, 0 },
                    { 635711001280L, "CALLE", 4198, 4199, "C 188 - 1 DE MAYO, Buenos Aires, General Pueyrredón", 6357110L, "C 188 - 1 DE MAYO", "INDEC", 0, 1 },
                    { 635711001285L, "CALLE", 2798, 2799, "C 188 - C C CERETTI, Buenos Aires, General Pueyrredón", 6357110L, "C 188 - C C CERETTI", "INDEC", 0, 0 },
                    { 635711001290L, "CALLE", 8199, 7998, "C 189 - C DAPROTIS, Buenos Aires, General Pueyrredón", 6357110L, "C 189 - C DAPROTIS", "INDEC", 0, 0 },
                    { 635711001295L, "CALLE", 3598, 3599, "C 189 - VICENTE LOPEZ Y PLANES, Buenos Aires, General Pueyrredón", 6357110L, "C 189 - VICENTE LOPEZ Y PLANES", "INDEC", 0, 0 },
                    { 635711001300L, "CALLE", 0, 0, "C 19, Buenos Aires, General Pueyrredón", 6357110L, "C 19", "INDEC", 0, 0 },
                    { 635711001305L, "CALLE", 2998, 2598, "C 190 - BELISARIO ROLDAN, Buenos Aires, General Pueyrredón", 6357110L, "C 190 - BELISARIO ROLDAN", "INDEC", 0, 0 },
                    { 635711001310L, "CALLE", 2798, 12996, "C 190 - INT G GUERRICO, Buenos Aires, General Pueyrredón", 6357110L, "C 190 - INT G GUERRICO", "INDEC", 0, 501 },
                    { 635711001315L, "CALLE", 4198, 5199, "C 190 - MARCONI, Buenos Aires, General Pueyrredón", 6357110L, "C 190 - MARCONI", "INDEC", 0, 1 },
                    { 635711001320L, "CALLE", 8099, 7898, "C 191 - J MARIANI, Buenos Aires, General Pueyrredón", 6357110L, "C 191 - J MARIANI", "INDEC", 0, 0 },
                    { 635711001325L, "CALLE", 2598, 2599, "C 192 - ARTIGAS, Buenos Aires, General Pueyrredón", 6357110L, "C 192 - ARTIGAS", "INDEC", 0, 0 },
                    { 635711001330L, "CALLE", 699, 598, "C 192 - FITTE, Buenos Aires, General Pueyrredón", 6357110L, "C 192 - FITTE", "INDEC", 1, 0 },
                    { 635711001335L, "CALLE", 2798, 3300, "C 192 - INT R INDA, Buenos Aires, General Pueyrredón", 6357110L, "C 192 - INT R INDA", "INDEC", 0, 0 },
                    { 635711001340L, "CALLE", 5298, 4199, "C 192 - URUGUAY, Buenos Aires, General Pueyrredón", 6357110L, "C 192 - URUGUAY", "INDEC", 0, 1 },
                    { 635711001345L, "CALLE", 7899, 7998, "C 193 - J LIJO LOPEZ, Buenos Aires, General Pueyrredón", 6357110L, "C 193 - J LIJO LOPEZ", "INDEC", 0, 0 },
                    { 635711001350L, "CALLE", 500, 0, "C 194, Buenos Aires, General Pueyrredón", 6357110L, "C 194", "INDEC", 0, 0 },
                    { 635711001355L, "CALLE", 4198, 2999, "C 194 - CHILE, Buenos Aires, General Pueyrredón", 6357110L, "C 194 - CHILE", "INDEC", 0, 0 },
                    { 635711001360L, "CALLE", 699, 999, "C 194 - DE LOS RESERVISTAS, Buenos Aires, General Pueyrredón", 6357110L, "C 194 - DE LOS RESERVISTAS", "INDEC", 0, 0 },
                    { 635711001365L, "CALLE", 2999, 2998, "C 194 - INT F MARTINEZ DE HOZ, Buenos Aires, General Pueyrredón", 6357110L, "C 194 - INT F MARTINEZ DE HOZ", "INDEC", 0, 0 },
                    { 635711001370L, "CALLE", 8399, 8398, "C 195 - ARAGON, Buenos Aires, General Pueyrredón", 6357110L, "C 195 - ARAGON", "INDEC", 0, 0 },
                    { 635711001375L, "CALLE", 3098, 3099, "C 196 - INT J B GONI, Buenos Aires, General Pueyrredón", 6357110L, "C 196 - INT J B GONI", "INDEC", 0, 0 },
                    { 635711001380L, "CALLE", 699, 698, "C 196 - LABARDEN, Buenos Aires, General Pueyrredón", 6357110L, "C 196 - LABARDEN", "INDEC", 1, 0 },
                    { 635711001385L, "CALLE", 3799, 7798, "C 196 - MEJICO, Buenos Aires, General Pueyrredón", 6357110L, "C 196 - MEJICO", "INDEC", 0, 0 },
                    { 635711001390L, "CALLE", 8398, 8399, "C 197 - CATALUNA, Buenos Aires, General Pueyrredón", 6357110L, "C 197 - CATALUNA", "INDEC", 0, 0 },
                    { 635711001395L, "CALLE", 699, 698, "C 198 - LOBERIA, Buenos Aires, General Pueyrredón", 6357110L, "C 198 - LOBERIA", "INDEC", 0, 0 },
                    { 635711001400L, "CALLE", 3000, 3000, "C 198 - PERU, Buenos Aires, General Pueyrredón", 6357110L, "C 198 - PERU", "INDEC", 0, 0 },
                    { 635711001405L, "CALLE", 12983, 4799, "C 198 - REFORMA UNIVERSITARIA, Buenos Aires, General Pueyrredón", 6357110L, "C 198 - REFORMA UNIVERSITARIA", "INDEC", 0, 0 },
                    { 635711001410L, "CALLE", 0, 0, "C 2 BIS, Buenos Aires, General Pueyrredón", 6357110L, "C 2 BIS", "INDEC", 0, 0 },
                    { 635711001415L, "CALLE", 0, 0, "C 20, Buenos Aires, General Pueyrredón", 6357110L, "C 20", "INDEC", 0, 0 },
                    { 635711001420L, "CALLE", 44989, 5198, "C 20 - INT GRL RACEDO, Buenos Aires, General Pueyrredón", 6357110L, "C 20 - INT GRL RACEDO", "INDEC", 0, 0 },
                    { 635711001425L, "CALLE", 16983, 3199, "C 200 - INT E PERALTA RAMOS, Buenos Aires, General Pueyrredón", 6357110L, "C 200 - INT E PERALTA RAMOS", "INDEC", 0, 0 },
                    { 635711001430L, "CALLE", 699, 698, "C 200 - SAN CAYETANO, Buenos Aires, General Pueyrredón", 6357110L, "C 200 - SAN CAYETANO", "INDEC", 0, 0 },
                    { 635711001435L, "CALLE", 3000, 3099, "C 200 - TIERRA DEL FUEGO, Buenos Aires, General Pueyrredón", 6357110L, "C 200 - TIERRA DEL FUEGO", "INDEC", 0, 0 },
                    { 635711001440L, "CALLE", 3798, 0, "C 200 TIERRA DEL FUEGO, Buenos Aires, General Pueyrredón", 6357110L, "C 200 TIERRA DEL FUEGO", "INDEC", 0, 0 },
                    { 635711001445L, "CALLE", 9299, 8198, "C 201 - VALENCIA, Buenos Aires, General Pueyrredón", 6357110L, "C 201 - VALENCIA", "INDEC", 0, 0 },
                    { 635711001450L, "CALLE", 5898, 58896, "C 202 - INT D'HEGUILOR, Buenos Aires, General Pueyrredón", 6357110L, "C 202 - INT D'HEGUILOR", "INDEC", 0, 0 },
                    { 635711001455L, "CALLE", 2999, 2598, "C 202 - J ORTEGA Y GASSET, Buenos Aires, General Pueyrredón", 6357110L, "C 202 - J ORTEGA Y GASSET", "INDEC", 0, 0 },
                    { 635711001460L, "CALLE", 598, 699, "C 202 - JUAN FERNANDEZ, Buenos Aires, General Pueyrredón", 6357110L, "C 202 - JUAN FERNANDEZ", "INDEC", 0, 0 },
                    { 635711001465L, "CALLE", 3498, 3999, "C 202 - TEODORO BRONZINI, Buenos Aires, General Pueyrredón", 6357110L, "C 202 - TEODORO BRONZINI", "INDEC", 0, 0 },
                    { 635711001470L, "CALLE", 8199, 8198, "C 203 - JUSTO L DE GOMARA, Buenos Aires, General Pueyrredón", 6357110L, "C 203 - JUSTO L DE GOMARA", "INDEC", 0, 0 },
                    { 635711001475L, "CALLE", 698, 699, "C 204 - FINOCHIETTO, Buenos Aires, General Pueyrredón", 6357110L, "C 204 - FINOCHIETTO", "INDEC", 0, 0 },
                    { 635711001480L, "CALLE", 6999, 3199, "C 204 - INT A MAC GAUL, Buenos Aires, General Pueyrredón", 6357110L, "C 204 - INT A MAC GAUL", "INDEC", 0, 0 },
                    { 635711001485L, "CALLE", 3998, 3999, "C 204 - MALVINAS, Buenos Aires, General Pueyrredón", 6357110L, "C 204 - MALVINAS", "INDEC", 0, 0 },
                    { 635711001490L, "CALLE", 2198, 2199, "C 204 - OLEGARIO ANDRADE, Buenos Aires, General Pueyrredón", 6357110L, "C 204 - OLEGARIO ANDRADE", "INDEC", 0, 1 },
                    { 635711001495L, "CALLE", 8798, 8098, "C 205 - CONCEPCION ARENAL, Buenos Aires, General Pueyrredón", 6357110L, "C 205 - CONCEPCION ARENAL", "INDEC", 0, 0 },
                    { 635711001500L, "CALLE", 698, 1899, "C 206 - CANESA, Buenos Aires, General Pueyrredón", 6357110L, "C 206 - CANESA", "INDEC", 0, 0 },
                    { 635711001505L, "CALLE", 2298, 2999, "C 206 - G DAIREAUX, Buenos Aires, General Pueyrredón", 6357110L, "C 206 - G DAIREAUX", "INDEC", 0, 1 },
                    { 635711001510L, "CALLE", 19835, 3199, "C 206 - INT A VIGNOLO, Buenos Aires, General Pueyrredón", 6357110L, "C 206 - INT A VIGNOLO", "INDEC", 0, 0 },
                    { 635711001515L, "CALLE", 3998, 3999, "C 206 - JUNCAL, Buenos Aires, General Pueyrredón", 6357110L, "C 206 - JUNCAL", "INDEC", 0, 1 },
                    { 635711001520L, "CALLE", 7999, 7998, "C 207 - F ACOSTA, Buenos Aires, General Pueyrredón", 6357110L, "C 207 - F ACOSTA", "INDEC", 0, 0 },
                    { 635711001525L, "CALLE", 3198, 3199, "C 208 - INT O OLAZAR, Buenos Aires, General Pueyrredón", 6357110L, "C 208 - INT O OLAZAR", "INDEC", 0, 0 },
                    { 635711001530L, "CALLE", 2099, 2098, "C 208 - RICARDO ROJAS, Buenos Aires, General Pueyrredón", 6357110L, "C 208 - RICARDO ROJAS", "INDEC", 0, 0 },
                    { 635711001535L, "CALLE", 1898, 1899, "C 208 - SCARDATTI, Buenos Aires, General Pueyrredón", 6357110L, "C 208 - SCARDATTI", "INDEC", 0, 0 },
                    { 635711001540L, "CALLE", 5199, 3998, "C 208 - V MONTES, Buenos Aires, General Pueyrredón", 6357110L, "C 208 - V MONTES", "INDEC", 0, 0 },
                    { 635711001545L, "CALLE", 7798, 7798, "C 209 - JUAN PENA, Buenos Aires, General Pueyrredón", 6357110L, "C 209 - JUAN PENA", "INDEC", 0, 0 },
                    { 635711001550L, "CALLE", 0, 0, "C 21, Buenos Aires, General Pueyrredón", 6357110L, "C 21", "INDEC", 0, 0 },
                    { 635711001555L, "CALLE", 1798, 1799, "C 210 - ECHEGARAY, Buenos Aires, General Pueyrredón", 6357110L, "C 210 - ECHEGARAY", "INDEC", 0, 0 },
                    { 635711001560L, "CALLE", 2599, 2698, "C 210 - JOAQUIN V GONZALEZ, Buenos Aires, General Pueyrredón", 6357110L, "C 210 - JOAQUIN V GONZALEZ", "INDEC", 0, 0 },
                    { 635711001565L, "AV", 0, 599, "C 210 AV V TETAMANTI, Buenos Aires, General Pueyrredón", 6357110L, "C 210 AV V TETAMANTI", "INDEC", 0, 101 },
                    { 635711001570L, "CALLE", 7799, 7798, "C 211 - PADRE J CARDIEL, Buenos Aires, General Pueyrredón", 6357110L, "C 211 - PADRE J CARDIEL", "INDEC", 0, 0 },
                    { 635711001575L, "CALLE", 1898, 1899, "C 212 - JAURETCHE, Buenos Aires, General Pueyrredón", 6357110L, "C 212 - JAURETCHE", "INDEC", 0, 0 },
                    { 635711001580L, "CALLE", 2199, 2198, "C 212 - JOSE M GORRITI, Buenos Aires, General Pueyrredón", 6357110L, "C 212 - JOSE M GORRITI", "INDEC", 0, 0 },
                    { 635711001585L, "CALLE", 3898, 3899, "C 212 - MARIANO ACOSTA, Buenos Aires, General Pueyrredón", 6357110L, "C 212 - MARIANO ACOSTA", "INDEC", 0, 0 },
                    { 635711001590L, "CALLE", 3899, 3898, "C 214 - BAHIA BLANCA, Buenos Aires, General Pueyrredón", 6357110L, "C 214 - BAHIA BLANCA", "INDEC", 0, 0 },
                    { 635711001595L, "CALLE", 2299, 2999, "C 214 - MIGUEL DE UNAMUNO, Buenos Aires, General Pueyrredón", 6357110L, "C 214 - MIGUEL DE UNAMUNO", "INDEC", 0, 0 },
                    { 635711001600L, "CALLE", 10098, 7699, "C 215 - MATIAS STROBEL, Buenos Aires, General Pueyrredón", 6357110L, "C 215 - MATIAS STROBEL", "INDEC", 0, 0 },
                    { 635711001605L, "CALLE", 1898, 1899, "C 216 - JUAN DE DIOS FILIBERTO, Buenos Aires, General Pueyrredón", 6357110L, "C 216 - JUAN DE DIOS FILIBERTO", "INDEC", 1100, 1101 },
                    { 635711001610L, "CALLE", 2199, 2198, "C 216 - REMOLCADOR GUARANI, Buenos Aires, General Pueyrredón", 6357110L, "C 216 - REMOLCADOR GUARANI", "INDEC", 0, 0 },
                    { 635711001615L, "CALLE", 3898, 3899, "C 216 - S E BORDABEHERE, Buenos Aires, General Pueyrredón", 6357110L, "C 216 - S E BORDABEHERE", "INDEC", 1, 0 },
                    { 635711001620L, "CALLE", 2599, 2198, "C 218 - PROF DR MONTES CARBALLO, Buenos Aires, General Pueyrredón", 6357110L, "C 218 - PROF DR MONTES CARBALLO", "INDEC", 0, 0 },
                    { 635711001625L, "CALLE", 3898, 3899, "C 218 - TRES ARROYOS, Buenos Aires, General Pueyrredón", 6357110L, "C 218 - TRES ARROYOS", "INDEC", 0, 0 },
                    { 635711001630L, "CALLE", 9999, 7898, "C 219 - RIO NEGRO, Buenos Aires, General Pueyrredón", 6357110L, "C 219 - RIO NEGRO", "INDEC", 0, 0 },
                    { 635711001635L, "CALLE", 0, 0, "C 22, Buenos Aires, General Pueyrredón", 6357110L, "C 22", "INDEC", 0, 0 },
                    { 635711001640L, "CALLE", 5198, 5199, "C 22 - THAMES, Buenos Aires, General Pueyrredón", 6357110L, "C 22 - THAMES", "INDEC", 0, 0 },
                    { 635711001645L, "CALLE", 14999, 1898, "C 220 - CIUDAD DE BRAGADO, Buenos Aires, General Pueyrredón", 6357110L, "C 220 - CIUDAD DE BRAGADO", "INDEC", 1101, 1100 },
                    { 635711001650L, "CALLE", 3398, 3399, "C 220 - RCA DEL LIBANO, Buenos Aires, General Pueyrredón", 6357110L, "C 220 - RCA DEL LIBANO", "INDEC", 0, 0 },
                    { 635711001655L, "CALLE", 1899, 1898, "C 220 -TORRES DE VERA Y ARAGON, Buenos Aires, General Pueyrredón", 6357110L, "C 220 -TORRES DE VERA Y ARAGON", "INDEC", 0, 0 },
                    { 635711001660L, "CALLE", 0, 0, "C 220 BIS, Buenos Aires, General Pueyrredón", 6357110L, "C 220 BIS", "INDEC", 0, 0 },
                    { 635711001665L, "CALLE", 7878, 7879, "C 221 - SANTA CRUZ, Buenos Aires, General Pueyrredón", 6357110L, "C 221 - SANTA CRUZ", "INDEC", 0, 0 },
                    { 635711001670L, "CALLE", 1898, 1899, "C 222 - CIUDAD DE LAS FLORES, Buenos Aires, General Pueyrredón", 6357110L, "C 222 - CIUDAD DE LAS FLORES", "INDEC", 1100, 0 },
                    { 635711001675L, "CALLE", 2199, 2198, "C 222 - MARTINEZ ZUVIRIA, Buenos Aires, General Pueyrredón", 6357110L, "C 222 - MARTINEZ ZUVIRIA", "INDEC", 0, 0 },
                    { 635711001680L, "CALLE", 10598, 9099, "C 223 - BERUTI, Buenos Aires, General Pueyrredón", 6357110L, "C 223 - BERUTI", "INDEC", 0, 0 },
                    { 635711001685L, "CALLE", 3398, 3399, "C 224 - DAVID ORTEGA, Buenos Aires, General Pueyrredón", 6357110L, "C 224 - DAVID ORTEGA", "INDEC", 0, 1 },
                    { 635711001690L, "CALLE", 2598, 2599, "C 224 - SAN JOSE DE CALASANZ, Buenos Aires, General Pueyrredón", 6357110L, "C 224 - SAN JOSE DE CALASANZ", "INDEC", 0, 0 },
                    { 635711001695L, "CALLE", 1898, 1799, "C 224 - YAPEYU, Buenos Aires, General Pueyrredón", 6357110L, "C 224 - YAPEYU", "INDEC", 0, 0 },
                    { 635711001700L, "CALLE", 9798, 9499, "C 225 - FRENCH, Buenos Aires, General Pueyrredón", 6357110L, "C 225 - FRENCH", "INDEC", 0, 0 },
                    { 635711001705L, "CALLE", 3798, 3799, "C 226 - ESTADO DE ISRAEL, Buenos Aires, General Pueyrredón", 6357110L, "C 226 - ESTADO DE ISRAEL", "INDEC", 0, 0 },
                    { 635711001710L, "CALLE", 2499, 2499, "C 226 - JUAN BAUTISTA DE LA SALLE, Buenos Aires, General Pueyrredón", 6357110L, "C 226 - JUAN BAUTISTA DE LA SALLE", "INDEC", 0, 0 },
                    { 635711001715L, "CALLE", 1898, 1899, "C 226 - JUANA AZURDUY, Buenos Aires, General Pueyrredón", 6357110L, "C 226 - JUANA AZURDUY", "INDEC", 0, 0 },
                    { 635711001720L, "CALLE", 77799, 9798, "C 227 - BRANDSEN, Buenos Aires, General Pueyrredón", 6357110L, "C 227 - BRANDSEN", "INDEC", 0, 0 },
                    { 635711001725L, "CALLE", 1898, 1899, "C 228, Buenos Aires, General Pueyrredón", 6357110L, "C 228", "INDEC", 0, 0 },
                    { 635711001730L, "CALLE", 2299, 2198, "C 228 - BELGICA, Buenos Aires, General Pueyrredón", 6357110L, "C 228 - BELGICA", "INDEC", 0, 0 },
                    { 635711001735L, "CALLE", 3798, 3799, "C 228 - REMEDIOS DE ESCALADA, Buenos Aires, General Pueyrredón", 6357110L, "C 228 - REMEDIOS DE ESCALADA", "INDEC", 0, 1 },
                    { 635711001740L, "CALLE", 9798, 77699, "C 229 - NECOCHEA, Buenos Aires, General Pueyrredón", 6357110L, "C 229 - NECOCHEA", "INDEC", 0, 0 },
                    { 635711001745L, "CALLE", 0, 0, "C 23, Buenos Aires, General Pueyrredón", 6357110L, "C 23", "INDEC", 0, 0 },
                    { 635711001750L, "CALLE", 1899, 1898, "C 230 - ERNESTO CHE GUEVARA, Buenos Aires, General Pueyrredón", 6357110L, "C 230 - ERNESTO CHE GUEVARA", "INDEC", 0, 0 },
                    { 635711001755L, "CALLE", 2499, 2498, "C 230 - FUNES DE MILLAN, Buenos Aires, General Pueyrredón", 6357110L, "C 230 - FUNES DE MILLAN", "INDEC", 0, 0 },
                    { 635711001760L, "CALLE", 3798, 3799, "C 230 - PAULA ALBARRACIN, Buenos Aires, General Pueyrredón", 6357110L, "C 230 - PAULA ALBARRACIN", "INDEC", 1, 0 },
                    { 635711001765L, "CALLE", 8998, 9799, "C 231 - ITUZAINGO, Buenos Aires, General Pueyrredón", 6357110L, "C 231 - ITUZAINGO", "INDEC", 0, 0 },
                    { 635711001770L, "CALLE", 1898, 1899, "C 232, Buenos Aires, General Pueyrredón", 6357110L, "C 232", "INDEC", 1100, 1101 },
                    { 635711001775L, "CALLE", 3798, 3799, "C 232 - GRECIA, Buenos Aires, General Pueyrredón", 6357110L, "C 232 - GRECIA", "INDEC", 0, 0 },
                    { 635711001780L, "CALLE", 2499, 2398, "C 232 - PIRAN, Buenos Aires, General Pueyrredón", 6357110L, "C 232 - PIRAN", "INDEC", 0, 0 },
                    { 635711001785L, "CALLE", 8998, 8999, "C 233 - AYACUCHO, Buenos Aires, General Pueyrredón", 6357110L, "C 233 - AYACUCHO", "INDEC", 0, 0 },
                    { 635711001790L, "CALLE", 10499, 10499, "C 235 - CHACABUCO, Buenos Aires, General Pueyrredón", 6357110L, "C 235 - CHACABUCO", "INDEC", 0, 0 },
                    { 635711001795L, "CALLE", 7498, 2198, "C 236 - PELAYO, Buenos Aires, General Pueyrredón", 6357110L, "C 236 - PELAYO", "INDEC", 200, 0 },
                    { 635711001800L, "CALLE", 3398, 3399, "C 236 - ARMENIA, Buenos Aires, General Pueyrredón", 6357110L, "C 236 - ARMENIA", "INDEC", 1, 0 },
                    { 635711001805L, "CALLE", 10598, 10599, "C 237 - MAIPU, Buenos Aires, General Pueyrredón", 6357110L, "C 237 - MAIPU", "INDEC", 0, 0 },
                    { 635711001810L, "CALLE", 2098, 2099, "C 238 - JOVELLANOS, Buenos Aires, General Pueyrredón", 6357110L, "C 238 - JOVELLANOS", "INDEC", 0, 0 },
                    { 635711001815L, "CALLE", 3398, 3399, "C 238 - TERMAS DE RIO HONDO, Buenos Aires, General Pueyrredón", 6357110L, "C 238 - TERMAS DE RIO HONDO", "INDEC", 0, 1 },
                    { 635711001820L, "CALLE", 0, 0, "C 24, Buenos Aires, General Pueyrredón", 6357110L, "C 24", "INDEC", 0, 0 },
                    { 635711001825L, "CALLE", 5098, 5098, "C 24 - SERRANO, Buenos Aires, General Pueyrredón", 6357110L, "C 24 - SERRANO", "INDEC", 0, 0 },
                    { 635711001830L, "CALLE", 2998, 2999, "C 240 - ARRUE, Buenos Aires, General Pueyrredón", 6357110L, "C 240 - ARRUE", "INDEC", 0, 1 },
                    { 635711001835L, "CALLE", 1928, 1899, "C 240 - ASTURIAS, Buenos Aires, General Pueyrredón", 6357110L, "C 240 - ASTURIAS", "INDEC", 0, 0 },
                    { 635711001840L, "CALLE", 77898, 10749, "C 241 - BALCARCE, Buenos Aires, General Pueyrredón", 6357110L, "C 241 - BALCARCE", "INDEC", 0, 0 },
                    { 635711001845L, "CALLE", 3598, 3599, "C 242 - C SUAREZ, Buenos Aires, General Pueyrredón", 6357110L, "C 242 - C SUAREZ", "INDEC", 0, 0 },
                    { 635711001850L, "CALLE", 1898, 1899, "C 242 - RIZZUTO, Buenos Aires, General Pueyrredón", 6357110L, "C 242 - RIZZUTO", "INDEC", 0, 0 },
                    { 635711001855L, "CALLE", 10799, 10798, "C 243 - 11 DE SEPTIEMBRE, Buenos Aires, General Pueyrredón", 6357110L, "C 243 - 11 DE SEPTIEMBRE", "INDEC", 0, 0 },
                    { 635711001860L, "CALLE", 2998, 2999, "C 244 - C M CALAZA, Buenos Aires, General Pueyrredón", 6357110L, "C 244 - C M CALAZA", "INDEC", 0, 0 },
                    { 635711001865L, "CALLE", 1799, 1798, "C 244 - LUZURIAGA, Buenos Aires, General Pueyrredón", 6357110L, "C 244 - LUZURIAGA", "INDEC", 0, 0 },
                    { 635711001870L, "CALLE", 10799, 37987, "C 245 - 3 DE FEBRERO, Buenos Aires, General Pueyrredón", 6357110L, "C 245 - 3 DE FEBRERO", "INDEC", 2301, 2300 },
                    { 635711001875L, "CALLE", 2998, 2999, "C 246 - C RAUCH, Buenos Aires, General Pueyrredón", 6357110L, "C 246 - C RAUCH", "INDEC", 0, 0 },
                    { 635711001880L, "CALLE", 2099, 1599, "C 246 - LORENZINI, Buenos Aires, General Pueyrredón", 6357110L, "C 246 - LORENZINI", "INDEC", 0, 0 },
                    { 635711001885L, "CALLE", 10799, 10798, "C 247 - 9 DE JULIO, Buenos Aires, General Pueyrredón", 6357110L, "C 247 - 9 DE JULIO", "INDEC", 0, 0 },
                    { 635711001890L, "CALLE", 8098, 1599, "C 248 - L CANDELARIA, Buenos Aires, General Pueyrredón", 6357110L, "C 248 - L CANDELARIA", "INDEC", 0, 0 },
                    { 635711001895L, "CALLE", 10799, 10798, "C 249 - 25 DE MAYO, Buenos Aires, General Pueyrredón", 6357110L, "C 249 - 25 DE MAYO", "INDEC", 0, 0 },
                    { 635711001900L, "CALLE", 0, 0, "C 25 - VOLCAN COPAHUE, Buenos Aires, General Pueyrredón", 6357110L, "C 25 - VOLCAN COPAHUE", "INDEC", 0, 0 },
                    { 635711001905L, "CALLE", 8198, 1399, "C 250 - BRADLEY, Buenos Aires, General Pueyrredón", 6357110L, "C 250 - BRADLEY", "INDEC", 0, 0 },
                    { 635711001910L, "CALLE", 3598, 3099, "C 251 - JUAN N CZETZ, Buenos Aires, General Pueyrredón", 6357110L, "C 251 - JUAN N CZETZ", "INDEC", 0, 0 },
                    { 635711001915L, "CALLE", 2198, 2199, "C 252 - ANGEL GARDELLA, Buenos Aires, General Pueyrredón", 6357110L, "C 252 - ANGEL GARDELLA", "INDEC", 0, 0 },
                    { 635711001920L, "CALLE", 2998, 2999, "C 252 - CNL J ACOSTA, Buenos Aires, General Pueyrredón", 6357110L, "C 252 - CNL J ACOSTA", "INDEC", 0, 0 },
                    { 635711001925L, "CALLE", 1699, 1498, "C 252 - PEDRO ZANNI, Buenos Aires, General Pueyrredón", 6357110L, "C 252 - PEDRO ZANNI", "INDEC", 0, 0 },
                    { 635711001930L, "CALLE", 2998, 2999, "C 253 - M CHILABERT, Buenos Aires, General Pueyrredón", 6357110L, "C 253 - M CHILABERT", "INDEC", 0, 0 },
                    { 635711001935L, "CALLE", 10698, 39998, "C 253 - SAN MARTIN, Buenos Aires, General Pueyrredón", 6357110L, "C 253 - SAN MARTIN", "INDEC", 0, 0 },
                    { 635711001940L, "CALLE", 999, 0, "C 254 - NUESTRA SRA DEL PILAR, Buenos Aires, General Pueyrredón", 6357110L, "C 254 - NUESTRA SRA DEL PILAR", "INDEC", 701, 0 },
                    { 635711001945L, "CALLE", 2999, 2998, "C 254 - TANDIL, Buenos Aires, General Pueyrredón", 6357110L, "C 254 - TANDIL", "INDEC", 0, 0 },
                    { 635711001950L, "CALLE", 10699, 10898, "C 255 - RIVADAVIA, Buenos Aires, General Pueyrredón", 6357110L, "C 255 - RIVADAVIA", "INDEC", 0, 0 },
                    { 635711001955L, "CALLE", 0, 0, "C 256 - LEOPOLDO MENDEZ, Buenos Aires, General Pueyrredón", 6357110L, "C 256 - LEOPOLDO MENDEZ", "INDEC", 0, 0 },
                    { 635711001960L, "CALLE", 2498, 5999, "C 256 - PIGUE, Buenos Aires, General Pueyrredón", 6357110L, "C 256 - PIGUE", "INDEC", 0, 0 },
                    { 635711001965L, "CALLE", 10999, 10899, "C 257 - BELGRANO, Buenos Aires, General Pueyrredón", 6357110L, "C 257 - BELGRANO", "INDEC", 0, 0 },
                    { 635711001970L, "CALLE", 2498, 2599, "C 258 - BOLIVIA, Buenos Aires, General Pueyrredón", 6357110L, "C 258 - BOLIVIA", "INDEC", 0, 0 },
                    { 635711001975L, "CALLE", 998, 899, "C 258 - COUREL, Buenos Aires, General Pueyrredón", 6357110L, "C 258 - COUREL", "INDEC", 0, 0 },
                    { 635711001980L, "CALLE", 10999, 10998, "C 259 - MORENO, Buenos Aires, General Pueyrredón", 6357110L, "C 259 - MORENO", "INDEC", 0, 0 },
                    { 635711001985L, "CALLE", 0, 0, "C 26, Buenos Aires, General Pueyrredón", 6357110L, "C 26", "INDEC", 0, 0 },
                    { 635711001990L, "CALLE", 4999, 4998, "C 26 - SANTA MARIA DE ORO, Buenos Aires, General Pueyrredón", 6357110L, "C 26 - SANTA MARIA DE ORO", "INDEC", 0, 0 },
                    { 635711001995L, "CALLE", 2598, 8999, "C 260 - BRASIL, Buenos Aires, General Pueyrredón", 6357110L, "C 260 - BRASIL", "INDEC", 0, 0 },
                    { 635711002000L, "CALLE", 10999, 10998, "C 261 - BOLIVAR, Buenos Aires, General Pueyrredón", 6357110L, "C 261 - BOLIVAR", "INDEC", 0, 0 },
                    { 635711002005L, "CALLE", 2598, 2599, "C 262 - PARAGUAY, Buenos Aires, General Pueyrredón", 6357110L, "C 262 - PARAGUAY", "INDEC", 0, 0 },
                    { 635711002010L, "CALLE", 998, 999, "C 262 - RODRIGUEZ, Buenos Aires, General Pueyrredón", 6357110L, "C 262 - RODRIGUEZ", "INDEC", 0, 0 },
                    { 635711002015L, "CALLE", 2599, 2599, "C 264 - DR G BAILEY, Buenos Aires, General Pueyrredón", 6357110L, "C 264 - DR G BAILEY", "INDEC", 0, 0 },
                    { 635711002020L, "CALLE", 1298, 1299, "C 264 - FAGNANI, Buenos Aires, General Pueyrredón", 6357110L, "C 264 - FAGNANI", "INDEC", 0, 0 },
                    { 635711002025L, "CALLE", 8899, 8998, "C 265 - ALMTE BROWN, Buenos Aires, General Pueyrredón", 6357110L, "C 265 - ALMTE BROWN", "INDEC", 0, 0 },
                    { 635711002030L, "CALLE", 2199, 3498, "C 266 - LEGUIZAMON, Buenos Aires, General Pueyrredón", 6357110L, "C 266 - LEGUIZAMON", "INDEC", 0, 0 },
                    { 635711002035L, "CALLE", 895, 1298, "C 266 - STAGNANI, Buenos Aires, General Pueyrredón", 6357110L, "C 266 - STAGNANI", "INDEC", 0, 0 },
                    { 635711002040L, "CALLE", 8998, 8999, "C 267 - FALUCHO, Buenos Aires, General Pueyrredón", 6357110L, "C 267 - FALUCHO", "INDEC", 0, 0 },
                    { 635711002045L, "CALLE", 2199, 2198, "C 268 - WILDE, Buenos Aires, General Pueyrredón", 6357110L, "C 268 - WILDE", "INDEC", 0, 0 },
                    { 635711002050L, "CALLE", 8998, 8999, "C 269 - GASCON, Buenos Aires, General Pueyrredón", 6357110L, "C 269 - GASCON", "INDEC", 0, 0 },
                    { 635711002055L, "CALLE", 0, 0, "C 27, Buenos Aires, General Pueyrredón", 6357110L, "C 27", "INDEC", 0, 0 },
                    { 635711002060L, "CALLE", 2198, 2199, "C 270 - CANADA, Buenos Aires, General Pueyrredón", 6357110L, "C 270 - CANADA", "INDEC", 0, 0 },
                    { 635711002065L, "CALLE", 8998, 27987, "C 271 - ALBERTI, Buenos Aires, General Pueyrredón", 6357110L, "C 271 - ALBERTI", "INDEC", 0, 0 },
                    { 635711002070L, "CALLE", 2199, 2198, "C 272 - RCA ARABE SIRIA, Buenos Aires, General Pueyrredón", 6357110L, "C 272 - RCA ARABE SIRIA", "INDEC", 0, 0 },
                    { 635711002075L, "CALLE", 7998, 7999, "C 273 - RAWSON, Buenos Aires, General Pueyrredón", 6357110L, "C 273 - RAWSON", "INDEC", 0, 0 },
                    { 635711002080L, "CALLE", 2198, 2199, "C 274 - DANTE ALIGHIERI, Buenos Aires, General Pueyrredón", 6357110L, "C 274 - DANTE ALIGHIERI", "INDEC", 0, 0 },
                    { 635711002085L, "CALLE", 8398, 8399, "C 275 - GARAY, Buenos Aires, General Pueyrredón", 6357110L, "C 275 - GARAY", "INDEC", 0, 0 },
                    { 635711002090L, "CALLE", 1599, 1598, "C 276 - ECUADOR, Buenos Aires, General Pueyrredón", 6357110L, "C 276 - ECUADOR", "INDEC", 0, 0 },
                    { 635711002095L, "CALLE", 44498, 8399, "C 277 - CASTELLI, Buenos Aires, General Pueyrredón", 6357110L, "C 277 - CASTELLI", "INDEC", 0, 0 },
                    { 635711002100L, "CALLE", 1599, 1598, "C 278 - COLOMBIA, Buenos Aires, General Pueyrredón", 6357110L, "C 278 - COLOMBIA", "INDEC", 0, 0 },
                    { 635711002105L, "CALLE", 199, 0, "C 278 - JOSE R BALET, Buenos Aires, General Pueyrredón", 6357110L, "C 278 - JOSE R BALET", "INDEC", 0, 0 },
                    { 635711002110L, "CALLE", 8999, 8999, "C 279 - ALVARADO, Buenos Aires, General Pueyrredón", 6357110L, "C 279 - ALVARADO", "INDEC", 0, 0 },
                    { 635711002115L, "CALLE", 0, 0, "C 28, Buenos Aires, General Pueyrredón", 6357110L, "C 28", "INDEC", 0, 0 },
                    { 635711002120L, "CALLE", 5299, 5198, "C 28 - BUSTAMANTE, Buenos Aires, General Pueyrredón", 6357110L, "C 28 - BUSTAMANTE", "INDEC", 0, 0 },
                    { 635711002125L, "CALLE", 198, 199, "C 280 - M A CASTELLANO, Buenos Aires, General Pueyrredón", 6357110L, "C 280 - M A CASTELLANO", "INDEC", 0, 0 },
                    { 635711002130L, "CALLE", 1599, 1598, "C 280 - VENEZUELA, Buenos Aires, General Pueyrredón", 6357110L, "C 280 - VENEZUELA", "INDEC", 0, 0 },
                    { 635711002135L, "CALLE", 7599, 7599, "C 281 - AVELLANEDA, Buenos Aires, General Pueyrredón", 6357110L, "C 281 - AVELLANEDA", "INDEC", 0, 0 },
                    { 635711002140L, "CALLE", 7799, 7698, "C 283 - SAN LORENZO, Buenos Aires, General Pueyrredón", 6357110L, "C 283 - SAN LORENZO", "INDEC", 0, 0 },
                    { 635711002145L, "CALLE", 2199, 2198, "C 284 - GUYANA, Buenos Aires, General Pueyrredón", 6357110L, "C 284 - GUYANA", "INDEC", 0, 0 },
                    { 635711002150L, "CALLE", 7799, 7798, "C 285 - GRL ROCA, Buenos Aires, General Pueyrredón", 6357110L, "C 285 - GRL ROCA", "INDEC", 0, 0 },
                    { 635711002155L, "CALLE", 1799, 1798, "C 286 - TRINIDAD Y TOBAGO, Buenos Aires, General Pueyrredón", 6357110L, "C 286 - TRINIDAD Y TOBAGO", "INDEC", 0, 0 },
                    { 635711002160L, "CALLE", 7599, 7598, "C 287 - RODRIGUEZ PENA, Buenos Aires, General Pueyrredón", 6357110L, "C 287 - RODRIGUEZ PENA", "INDEC", 0, 0 },
                    { 635711002165L, "CALLE", 1798, 1899, "C 288 - ROSARIO, Buenos Aires, General Pueyrredón", 6357110L, "C 288 - ROSARIO", "INDEC", 0, 0 },
                    { 635711002170L, "CALLE", 7399, 7398, "C 289 - PRIMERA JUNTA, Buenos Aires, General Pueyrredón", 6357110L, "C 289 - PRIMERA JUNTA", "INDEC", 0, 0 },
                    { 635711002175L, "CALLE", 0, 0, "C 29, Buenos Aires, General Pueyrredón", 6357110L, "C 29", "INDEC", 0, 0 },
                    { 635711002180L, "CALLE", 1998, 1999, "C 290 - MADARIAGA, Buenos Aires, General Pueyrredón", 6357110L, "C 290 - MADARIAGA", "INDEC", 0, 0 },
                    { 635711002185L, "CALLE", 7999, 7398, "C 291 - SAAVEDRA, Buenos Aires, General Pueyrredón", 6357110L, "C 291 - SAAVEDRA", "INDEC", 0, 0 },
                    { 635711002190L, "CALLE", 0, 0, "C 292 - ESPERANTO, Buenos Aires, General Pueyrredón", 6357110L, "C 292 - ESPERANTO", "INDEC", 0, 0 },
                    { 635711002195L, "CALLE", 7399, 7398, "C 293 - QUINTANA, Buenos Aires, General Pueyrredón", 6357110L, "C 293 - QUINTANA", "INDEC", 1, 0 },
                    { 635711002200L, "CALLE", 2199, 2198, "C 294 - ANGELELLI, Buenos Aires, General Pueyrredón", 6357110L, "C 294 - ANGELELLI", "INDEC", 0, 0 },
                    { 635711002205L, "CALLE", 6599, 6598, "C 295 - MATHEU, Buenos Aires, General Pueyrredón", 6357110L, "C 295 - MATHEU", "INDEC", 0, 0 },
                    { 635711002210L, "CALLE", 2199, 2198, "C 296 - AMAYA, Buenos Aires, General Pueyrredón", 6357110L, "C 296 - AMAYA", "INDEC", 0, 0 },
                    { 635711002215L, "CALLE", 6198, 6199, "C 297 - FORMOSA, Buenos Aires, General Pueyrredón", 6357110L, "C 297 - FORMOSA", "INDEC", 0, 0 },
                    { 635711002220L, "CALLE", 5299, 5298, "C 299 - ALMAFUERTE, Buenos Aires, General Pueyrredón", 6357110L, "C 299 - ALMAFUERTE", "INDEC", 0, 0 },
                    { 635711002225L, "CALLE", 0, 0, "C 30, Buenos Aires, General Pueyrredón", 6357110L, "C 30", "INDEC", 0, 0 },
                    { 635711002230L, "CALLE", 47398, 32499, "C 30 - A SAENZ, Buenos Aires, General Pueyrredón", 6357110L, "C 30 - A SAENZ", "INDEC", 0, 0 },
                    { 635711002235L, "CALLE", 3499, 4198, "C 30 - BIS - JOSE ALONSO, Buenos Aires, General Pueyrredón", 6357110L, "C 30 - BIS - JOSE ALONSO", "INDEC", 0, 0 },
                    { 635711002240L, "CALLE", 5198, 5199, "C 301 - LAPRIDA, Buenos Aires, General Pueyrredón", 6357110L, "C 301 - LAPRIDA", "INDEC", 701, 700 },
                    { 635711002245L, "CALLE", 3998, 3999, "C 306 - VIEYTES, Buenos Aires, General Pueyrredón", 6357110L, "C 306 - VIEYTES", "INDEC", 0, 0 },
                    { 635711002250L, "CALLE", 3599, 3598, "C 307 - LARREA, Buenos Aires, General Pueyrredón", 6357110L, "C 307 - LARREA", "INDEC", 0, 0 },
                    { 635711002255L, "CALLE", 3998, 3099, "C 309 - AZCUENAGA, Buenos Aires, General Pueyrredón", 6357110L, "C 309 - AZCUENAGA", "INDEC", 200, 0 },
                    { 635711002260L, "CALLE", 2598, 2599, "C 311 - PRINGLES, Buenos Aires, General Pueyrredón", 6357110L, "C 311 - PRINGLES", "INDEC", 200, 201 },
                    { 635711002265L, "CALLE", 2099, 2098, "C 313 - O'HIGGINS, Buenos Aires, General Pueyrredón", 6357110L, "C 313 - O'HIGGINS", "INDEC", 201, 0 },
                    { 635711002270L, "CALLE", 1599, 1598, "C 315 - MARTIN RODRIGUEZ, Buenos Aires, General Pueyrredón", 6357110L, "C 315 - MARTIN RODRIGUEZ", "INDEC", 0, 200 },
                    { 635711002275L, "CALLE", 1198, 1199, "C 317 - VICENTE LOPEZ, Buenos Aires, General Pueyrredón", 6357110L, "C 317 - VICENTE LOPEZ", "INDEC", 100, 201 },
                    { 635711002280L, "CALLE", 0, 0, "C 32, Buenos Aires, General Pueyrredón", 6357110L, "C 32", "INDEC", 0, 0 },
                    { 635711002285L, "CALLE", 4799, 35800, "C 32 - C RODRIGUEZ, Buenos Aires, General Pueyrredón", 6357110L, "C 32 - C RODRIGUEZ", "INDEC", 0, 0 },
                    { 635711002290L, "CALLE", 48999, 44989, "C 34 - PACHECO DE MELO, Buenos Aires, General Pueyrredón", 6357110L, "C 34 - PACHECO DE MELO", "INDEC", 0, 0 },
                    { 635711002295L, "CALLE", 11899, 82696, "C 347 - AZOPARDO, Buenos Aires, General Pueyrredón", 6357110L, "C 347 - AZOPARDO", "INDEC", 0, 0 },
                    { 635711002300L, "CALLE", 11899, 11899, "C 349 - BOUCHARD, Buenos Aires, General Pueyrredón", 6357110L, "C 349 - BOUCHARD", "INDEC", 0, 0 },
                    { 635711002305L, "CALLE", 11898, 11899, "C 351 - ROSALES, Buenos Aires, General Pueyrredón", 6357110L, "C 351 - ROSALES", "INDEC", 0, 0 },
                    { 635711002310L, "CALLE", 89989, 11899, "C 353 - T DEL FOURNIER, Buenos Aires, General Pueyrredón", 6357110L, "C 353 - T DEL FOURNIER", "INDEC", 0, 0 },
                    { 635711002315L, "CALLE", 11899, 11899, "C 355 - SOLER, Buenos Aires, General Pueyrredón", 6357110L, "C 355 - SOLER", "INDEC", 0, 0 },
                    { 635711002320L, "CALLE", 84199, 89198, "C 357 - S DE ARANA Y GOIRI, Buenos Aires, General Pueyrredón", 6357110L, "C 357 - S DE ARANA Y GOIRI", "INDEC", 0, 0 },
                    { 635711002325L, "CALLE", 90998, 9499, "C 359 - EDUARDO G CARASA, Buenos Aires, General Pueyrredón", 6357110L, "C 359 - EDUARDO G CARASA", "INDEC", 0, 0 },
                    { 635711002330L, "CALLE", 5099, 39898, "C 36 - P MEDRANO, Buenos Aires, General Pueyrredón", 6357110L, "C 36 - P MEDRANO", "INDEC", 0, 0 },
                    { 635711002335L, "CALLE", 8399, 8398, "C 363 - MOISES LEBENSHON, Buenos Aires, General Pueyrredón", 6357110L, "C 363 - MOISES LEBENSHON", "INDEC", 0, 0 },
                    { 635711002340L, "CALLE", 8698, 8699, "C 365 - PUAN, Buenos Aires, General Pueyrredón", 6357110L, "C 365 - PUAN", "INDEC", 0, 0 },
                    { 635711002345L, "CALLE", 9999, 24989, "C 367 - NAPOLES, Buenos Aires, General Pueyrredón", 6357110L, "C 367 - NAPOLES", "INDEC", 0, 0 },
                    { 635711002350L, "CALLE", 8999, 9098, "C 369 - GENOVA, Buenos Aires, General Pueyrredón", 6357110L, "C 369 - GENOVA", "INDEC", 0, 0 },
                    { 635711002355L, "CALLE", 0, 0, "C 37, Buenos Aires, General Pueyrredón", 6357110L, "C 37", "INDEC", 0, 0 },
                    { 635711002360L, "CALLE", 9099, 9098, "C 371 - SICILIA, Buenos Aires, General Pueyrredón", 6357110L, "C 371 - SICILIA", "INDEC", 0, 0 },
                    { 635711002365L, "CALLE", 9298, 9299, "C 373 - CALABRIA, Buenos Aires, General Pueyrredón", 6357110L, "C 373 - CALABRIA", "INDEC", 0, 0 },
                    { 635711002370L, "CALLE", 9499, 9498, "C 375 - GUTENBERG, Buenos Aires, General Pueyrredón", 6357110L, "C 375 - GUTENBERG", "INDEC", 0, 0 },
                    { 635711002375L, "CALLE", 9499, 9498, "C 377 - WILLIAM MORRIS, Buenos Aires, General Pueyrredón", 6357110L, "C 377 - WILLIAM MORRIS", "INDEC", 0, 0 },
                    { 635711002380L, "CALLE", 9499, 9498, "C 379 - RICARDO GUIRALDES, Buenos Aires, General Pueyrredón", 6357110L, "C 379 - RICARDO GUIRALDES", "INDEC", 0, 0 },
                    { 635711002385L, "CALLE", 3799, 5198, "C 38 - DE LA MAZA, Buenos Aires, General Pueyrredón", 6357110L, "C 38 - DE LA MAZA", "INDEC", 0, 0 },
                    { 635711002390L, "CALLE", 9498, 9499, "C 381 - GARCIA LORCA, Buenos Aires, General Pueyrredón", 6357110L, "C 381 - GARCIA LORCA", "INDEC", 0, 0 },
                    { 635711002395L, "CALLE", 9498, 9499, "C 383 - B LYNCH, Buenos Aires, General Pueyrredón", 6357110L, "C 383 - B LYNCH", "INDEC", 0, 0 },
                    { 635711002400L, "CALLE", 798, 899, "C 4, Buenos Aires, General Pueyrredón", 6357110L, "C 4", "INDEC", 0, 0 },
                    { 635711002405L, "CALLE", 0, 0, "C 4 BIS, Buenos Aires, General Pueyrredón", 6357110L, "C 4 BIS", "INDEC", 0, 0 },
                    { 635711002410L, "CALLE", 3799, 3798, "C 40 - MALABIA, Buenos Aires, General Pueyrredón", 6357110L, "C 40 - MALABIA", "INDEC", 320, 0 },
                    { 635711002415L, "CALLE", 0, 0, "C 413, Buenos Aires, General Pueyrredón", 6357110L, "C 413", "INDEC", 0, 0 },
                    { 635711002420L, "CALLE", 0, 0, "C 415, Buenos Aires, General Pueyrredón", 6357110L, "C 415", "INDEC", 0, 0 },
                    { 635711002425L, "CALLE", 37983, 3799, "C 42 - MONSENOR MIGUEL DE ANDREA, Buenos Aires, General Pueyrredón", 6357110L, "C 42 - MONSENOR MIGUEL DE ANDREA", "INDEC", 0, 0 },
                    { 635711002430L, "CALLE", 0, 0, "C 427, Buenos Aires, General Pueyrredón", 6357110L, "C 427", "INDEC", 0, 0 },
                    { 635711002435L, "CALLE", 0, 0, "C 427 - BIS, Buenos Aires, General Pueyrredón", 6357110L, "C 427 - BIS", "INDEC", 0, 0 },
                    { 635711002440L, "CALLE", 0, 0, "C 429, Buenos Aires, General Pueyrredón", 6357110L, "C 429", "INDEC", 0, 0 },
                    { 635711002445L, "CALLE", 0, 0, "C 429 BIS, Buenos Aires, General Pueyrredón", 6357110L, "C 429 BIS", "INDEC", 0, 0 },
                    { 635711002450L, "CALLE", 0, 0, "C 431, Buenos Aires, General Pueyrredón", 6357110L, "C 431", "INDEC", 0, 0 },
                    { 635711002455L, "CALLE", 0, 0, "C 431 BIS, Buenos Aires, General Pueyrredón", 6357110L, "C 431 BIS", "INDEC", 0, 0 },
                    { 635711002460L, "CALLE", 0, 0, "C 433, Buenos Aires, General Pueyrredón", 6357110L, "C 433", "INDEC", 0, 0 },
                    { 635711002465L, "CALLE", 0, 0, "C 433 BIS, Buenos Aires, General Pueyrredón", 6357110L, "C 433 BIS", "INDEC", 0, 0 },
                    { 635711002470L, "CALLE", 0, 399, "C 435, Buenos Aires, General Pueyrredón", 6357110L, "C 435", "INDEC", 0, 0 },
                    { 635711002475L, "CALLE", 399, 398, "C 437, Buenos Aires, General Pueyrredón", 6357110L, "C 437", "INDEC", 0, 0 },
                    { 635711002480L, "CALLE", 398, 399, "C 439, Buenos Aires, General Pueyrredón", 6357110L, "C 439", "INDEC", 0, 0 },
                    { 635711002485L, "CALLE", 3798, 3799, "C 44 - DARRAGUEIRA, Buenos Aires, General Pueyrredón", 6357110L, "C 44 - DARRAGUEIRA", "INDEC", 0, 2701 },
                    { 635711002490L, "CALLE", 399, 378, "C 441, Buenos Aires, General Pueyrredón", 6357110L, "C 441", "INDEC", 0, 0 },
                    { 635711002495L, "CALLE", 398, 399, "C 443, Buenos Aires, General Pueyrredón", 6357110L, "C 443", "INDEC", 0, 0 },
                    { 635711002500L, "CALLE", 398, 398, "C 445, Buenos Aires, General Pueyrredón", 6357110L, "C 445", "INDEC", 0, 0 },
                    { 635711002505L, "CALLE", 398, 399, "C 447, Buenos Aires, General Pueyrredón", 6357110L, "C 447", "INDEC", 0, 0 },
                    { 635711002510L, "CALLE", 399, 398, "C 449, Buenos Aires, General Pueyrredón", 6357110L, "C 449", "INDEC", 0, 0 },
                    { 635711002515L, "CALLE", 398, 399, "C 451, Buenos Aires, General Pueyrredón", 6357110L, "C 451", "INDEC", 0, 0 },
                    { 635711002520L, "CALLE", 0, 398, "C 453, Buenos Aires, General Pueyrredón", 6357110L, "C 453", "INDEC", 0, 0 },
                    { 635711002525L, "CALLE", 0, 0, "C 455, Buenos Aires, General Pueyrredón", 6357110L, "C 455", "INDEC", 0, 0 },
                    { 635711002530L, "CALLE", 0, 0, "C 457, Buenos Aires, General Pueyrredón", 6357110L, "C 457", "INDEC", 0, 0 },
                    { 635711002535L, "CALLE", 0, 0, "C 459, Buenos Aires, General Pueyrredón", 6357110L, "C 459", "INDEC", 0, 0 },
                    { 635711002540L, "CALLE", 3799, 3798, "C 46 - COLOMBRES, Buenos Aires, General Pueyrredón", 6357110L, "C 46 - COLOMBRES", "INDEC", 0, 0 },
                    { 635711002545L, "CALLE", 0, 0, "C 461, Buenos Aires, General Pueyrredón", 6357110L, "C 461", "INDEC", 0, 0 },
                    { 635711002550L, "CALLE", 0, 0, "C 463, Buenos Aires, General Pueyrredón", 6357110L, "C 463", "INDEC", 0, 0 },
                    { 635711002555L, "CALLE", 0, 0, "C 465, Buenos Aires, General Pueyrredón", 6357110L, "C 465", "INDEC", 0, 0 },
                    { 635711002560L, "CALLE", 0, 0, "C 467, Buenos Aires, General Pueyrredón", 6357110L, "C 467", "INDEC", 0, 0 },
                    { 635711002565L, "CALLE", 0, 0, "C 469, Buenos Aires, General Pueyrredón", 6357110L, "C 469", "INDEC", 0, 0 },
                    { 635711002570L, "CALLE", 0, 0, "C 471, Buenos Aires, General Pueyrredón", 6357110L, "C 471", "INDEC", 0, 0 },
                    { 635711002575L, "CALLE", 0, 0, "C 473, Buenos Aires, General Pueyrredón", 6357110L, "C 473", "INDEC", 0, 0 },
                    { 635711002580L, "CALLE", 0, 0, "C 475, Buenos Aires, General Pueyrredón", 6357110L, "C 475", "INDEC", 0, 0 },
                    { 635711002585L, "CALLE", 0, 0, "C 477, Buenos Aires, General Pueyrredón", 6357110L, "C 477", "INDEC", 0, 0 },
                    { 635711002590L, "CALLE", 0, 0, "C 479, Buenos Aires, General Pueyrredón", 6357110L, "C 479", "INDEC", 0, 0 },
                    { 635711002595L, "CALLE", 3799, 3698, "C 48 - CASTRO BARROS, Buenos Aires, General Pueyrredón", 6357110L, "C 48 - CASTRO BARROS", "INDEC", 0, 0 },
                    { 635711002600L, "CALLE", 0, 0, "C 481, Buenos Aires, General Pueyrredón", 6357110L, "C 481", "INDEC", 0, 0 },
                    { 635711002605L, "CALLE", 0, 0, "C 483, Buenos Aires, General Pueyrredón", 6357110L, "C 483", "INDEC", 0, 0 },
                    { 635711002610L, "CALLE", 0, 0, "C 485, Buenos Aires, General Pueyrredón", 6357110L, "C 485", "INDEC", 0, 0 },
                    { 635711002615L, "CALLE", 0, 0, "C 487, Buenos Aires, General Pueyrredón", 6357110L, "C 487", "INDEC", 0, 0 },
                    { 635711002620L, "CALLE", 0, 0, "C 489, Buenos Aires, General Pueyrredón", 6357110L, "C 489", "INDEC", 0, 0 },
                    { 635711002625L, "CALLE", 0, 0, "C 491, Buenos Aires, General Pueyrredón", 6357110L, "C 491", "INDEC", 0, 0 },
                    { 635711002630L, "CALLE", 0, 0, "C 493, Buenos Aires, General Pueyrredón", 6357110L, "C 493", "INDEC", 0, 0 },
                    { 635711002635L, "CALLE", 0, 0, "C 495, Buenos Aires, General Pueyrredón", 6357110L, "C 495", "INDEC", 0, 0 },
                    { 635711002640L, "CALLE", 0, 0, "C 497, Buenos Aires, General Pueyrredón", 6357110L, "C 497", "INDEC", 0, 0 },
                    { 635711002645L, "CALLE", 0, 0, "C 499, Buenos Aires, General Pueyrredón", 6357110L, "C 499", "INDEC", 0, 0 },
                    { 635711002650L, "CALLE", 33999, 3698, "C 50 - CABRERA, Buenos Aires, General Pueyrredón", 6357110L, "C 50 - CABRERA", "INDEC", 0, 0 },
                    { 635711002655L, "CALLE", 0, 0, "C 501, Buenos Aires, General Pueyrredón", 6357110L, "C 501", "INDEC", 0, 0 },
                    { 635711002660L, "CALLE", 0, 0, "C 503, Buenos Aires, General Pueyrredón", 6357110L, "C 503", "INDEC", 0, 0 },
                    { 635711002665L, "CALLE", 0, 0, "C 505, Buenos Aires, General Pueyrredón", 6357110L, "C 505", "INDEC", 0, 0 },
                    { 635711002670L, "CALLE", 0, 0, "C 507, Buenos Aires, General Pueyrredón", 6357110L, "C 507", "INDEC", 0, 0 },
                    { 635711002675L, "CALLE", 0, 0, "C 509, Buenos Aires, General Pueyrredón", 6357110L, "C 509", "INDEC", 0, 0 },
                    { 635711002680L, "CALLE", 0, 0, "C 511, Buenos Aires, General Pueyrredón", 6357110L, "C 511", "INDEC", 0, 0 },
                    { 635711002685L, "CALLE", 0, 0, "C 513, Buenos Aires, General Pueyrredón", 6357110L, "C 513", "INDEC", 0, 0 },
                    { 635711002690L, "CALLE", 0, 0, "C 515, Buenos Aires, General Pueyrredón", 6357110L, "C 515", "INDEC", 0, 0 },
                    { 635711002695L, "CALLE", 3699, 3698, "C 52 - PEREZ BULNES, Buenos Aires, General Pueyrredón", 6357110L, "C 52 - PEREZ BULNES", "INDEC", 2300, 0 },
                    { 635711002700L, "CALLE", 3198, 3199, "C 54 - P M ARAOZ, Buenos Aires, General Pueyrredón", 6357110L, "C 54 - P M ARAOZ", "INDEC", 2200, 2201 },
                    { 635711002705L, "CALLE", 3198, 3199, "C 56 - ACEVEDO, Buenos Aires, General Pueyrredón", 6357110L, "C 56 - ACEVEDO", "INDEC", 0, 0 },
                    { 635711002710L, "CALLE", 2998, 3099, "C 58 - GRL PACHECO, Buenos Aires, General Pueyrredón", 6357110L, "C 58 - GRL PACHECO", "INDEC", 0, 0 },
                    { 635711002715L, "CALLE", 899, 898, "C 6, Buenos Aires, General Pueyrredón", 6357110L, "C 6", "INDEC", 0, 0 },
                    { 635711002720L, "CALLE", 0, 0, "C 6 - BIS, Buenos Aires, General Pueyrredón", 6357110L, "C 6 - BIS", "INDEC", 0, 0 },
                    { 635711002725L, "CALLE", 3198, 3099, "C 60 - CROCCE, Buenos Aires, General Pueyrredón", 6357110L, "C 60 - CROCCE", "INDEC", 0, 0 },
                    { 635711002730L, "CALLE", 3198, 3099, "C 62 - VERGARA, Buenos Aires, General Pueyrredón", 6357110L, "C 62 - VERGARA", "INDEC", 0, 0 },
                    { 635711002735L, "CALLE", 2998, 3199, "C 64 - G GIACOMINI, Buenos Aires, General Pueyrredón", 6357110L, "C 64 - G GIACOMINI", "INDEC", 0, 0 },
                    { 635711002740L, "CALLE", 3098, 3199, "C 68 - LUIS VERNET, Buenos Aires, General Pueyrredón", 6357110L, "C 68 - LUIS VERNET", "INDEC", 0, 0 },
                    { 635711002745L, "CALLE", 3198, 3199, "C 70 - PIEDRABUENA, Buenos Aires, General Pueyrredón", 6357110L, "C 70 - PIEDRABUENA", "INDEC", 0, 0 },
                    { 635711002750L, "CALLE", 3198, 3199, "C 72 - JUAN VUCETICH, Buenos Aires, General Pueyrredón", 6357110L, "C 72 - JUAN VUCETICH", "INDEC", 0, 0 },
                    { 635711002755L, "CALLE", 3198, 3199, "C 74 - GRL MOSCONI, Buenos Aires, General Pueyrredón", 6357110L, "C 74 - GRL MOSCONI", "INDEC", 0, 0 },
                    { 635711002760L, "CALLE", 3198, 3099, "C 76 - A AGUADO, Buenos Aires, General Pueyrredón", 6357110L, "C 76 - A AGUADO", "INDEC", 0, 0 },
                    { 635711002765L, "CALLE", 3926, 3199, "C 78 - ALBERT EINSTEIN, Buenos Aires, General Pueyrredón", 6357110L, "C 78 - ALBERT EINSTEIN", "INDEC", 0, 0 },
                    { 635711002770L, "CALLE", 0, 899, "C 8, Buenos Aires, General Pueyrredón", 6357110L, "C 8", "INDEC", 0, 0 },
                    { 635711002775L, "CALLE", 0, 0, "C 8 BIS, Buenos Aires, General Pueyrredón", 6357110L, "C 8 BIS", "INDEC", 0, 0 },
                    { 635711002780L, "CALLE", 3198, 3199, "C 80 - IGR BELTRAMI, Buenos Aires, General Pueyrredón", 6357110L, "C 80 - IGR BELTRAMI", "INDEC", 0, 601 },
                    { 635711002785L, "CALLE", 3199, 3098, "C 82 - PESCADORES, Buenos Aires, General Pueyrredón", 6357110L, "C 82 - PESCADORES", "INDEC", 400, 0 },
                    { 635711002790L, "CALLE", 3199, 3199, "C 84 - FIGUEROA ALCORTA, Buenos Aires, General Pueyrredón", 6357110L, "C 84 - FIGUEROA ALCORTA", "INDEC", 0, 0 },
                    { 635711002795L, "CALLE", 6499, 6699, "C 85 - S THOEL, Buenos Aires, General Pueyrredón", 6357110L, "C 85 - S THOEL", "INDEC", 0, 0 },
                    { 635711002800L, "CALLE", 3098, 3099, "C 86 - BERMEJO, Buenos Aires, General Pueyrredón", 6357110L, "C 86 - BERMEJO", "INDEC", 0, 0 },
                    { 635711002805L, "CALLE", 3998, 3999, "C 88 - A DEL VALLE, Buenos Aires, General Pueyrredón", 6357110L, "C 88 - A DEL VALLE", "INDEC", 0, 2301 },
                    { 635711002810L, "CALLE", 3198, 3199, "C 88 - ACHA, Buenos Aires, General Pueyrredón", 6357110L, "C 88 - ACHA", "INDEC", 0, 0 },
                    { 635711002815L, "CALLE", 3998, 5099, "C 90 - LEANDRO N ALEM, Buenos Aires, General Pueyrredón", 6357110L, "C 90 - LEANDRO N ALEM", "INDEC", 0, 0 },
                    { 635711002820L, "CALLE", 5098, 5099, "C 92 - BERNARDO DE IRIGOYEN, Buenos Aires, General Pueyrredón", 6357110L, "C 92 - BERNARDO DE IRIGOYEN", "INDEC", 2402, 2401 },
                    { 635711002825L, "CALLE", 3099, 3198, "C 92 - POSADAS, Buenos Aires, General Pueyrredón", 6357110L, "C 92 - POSADAS", "INDEC", 0, 0 },
                    { 635711002830L, "CALLE", 5098, 5099, "C 94 - CARLOS PELLEGRINI, Buenos Aires, General Pueyrredón", 6357110L, "C 94 - CARLOS PELLEGRINI", "INDEC", 0, 0 },
                    { 635711002835L, "CALLE", 3098, 3199, "C 94 - RONDEAU, Buenos Aires, General Pueyrredón", 6357110L, "C 94 - RONDEAU", "INDEC", 0, 0 },
                    { 635711002840L, "CALLE", 3198, 3199, "C 96 - PADRE J DUTTO, Buenos Aires, General Pueyrredón", 6357110L, "C 96 - PADRE J DUTTO", "INDEC", 0, 0 },
                    { 635711002845L, "CALLE", 5098, 5099, "C 96 - URQUIZA, Buenos Aires, General Pueyrredón", 6357110L, "C 96 - URQUIZA", "INDEC", 0, 0 },
                    { 635711002850L, "CALLE", 4998, 7499, "C 98 - GRL PAZ, Buenos Aires, General Pueyrredón", 6357110L, "C 98 - GRL PAZ", "INDEC", 0, 0 },
                    { 635711002855L, "CALLE", 3198, 3199, "C 98 - TRIUNVIRATO, Buenos Aires, General Pueyrredón", 6357110L, "C 98 - TRIUNVIRATO", "INDEC", 0, 0 },
                    { 635711002860L, "CALLE", 0, 0, "C BERRA, Buenos Aires, General Pueyrredón", 6357110L, "C BERRA", "INDEC", 0, 0 },
                    { 635711002865L, "CALLE", 3899, 3498, "C DAGLIO, Buenos Aires, General Pueyrredón", 6357110L, "C DAGLIO", "INDEC", 0, 0 },
                    { 635711002870L, "CALLE", 0, 0, "C MANRIQUE, Buenos Aires, General Pueyrredón", 6357110L, "C MANRIQUE", "INDEC", 0, 0 },
                    { 635711002875L, "CALLE", 798, 799, "C MARTIN, Buenos Aires, General Pueyrredón", 6357110L, "C MARTIN", "INDEC", 300, 301 },
                    { 635711002880L, "CALLE", 0, 0, "C PAMPEANA, Buenos Aires, General Pueyrredón", 6357110L, "C PAMPEANA", "INDEC", 0, 0 },
                    { 635711002885L, "CALLE", 0, 0, "C SUAREZ BIS, Buenos Aires, General Pueyrredón", 6357110L, "C SUAREZ BIS", "INDEC", 0, 0 },
                    { 635711002890L, "CALLE", 0, 0, "C 1, Buenos Aires, General Pueyrredón", 6357110L, "C 1", "INDEC", 0, 0 },
                    { 635711002895L, "CALLE", 0, 0, "C 10, Buenos Aires, General Pueyrredón", 6357110L, "C 10", "INDEC", 0, 0 },
                    { 635711002900L, "CALLE", 0, 0, "C 8, Buenos Aires, General Pueyrredón", 6357110L, "C 8", "INDEC", 0, 0 },
                    { 635711002902L, "CALLE", 0, 0, "CABEZA, Buenos Aires, General Pueyrredón", 6357110L, "CABEZA", "INDEC", 0, 0 },
                    { 635711002905L, "CALLE", 5799, 5798, "CABILDO, Buenos Aires, General Pueyrredón", 6357110L, "CABILDO", "INDEC", 5701, 5700 },
                    { 635711002910L, "CALLE", 0, 0, "CABO CORRIENTES, Buenos Aires, General Pueyrredón", 6357110L, "CABO CORRIENTES", "INDEC", 0, 0 },
                    { 635711002915L, "CALLE", 0, 0, "CABO DE HORNOS, Buenos Aires, General Pueyrredón", 6357110L, "CABO DE HORNOS", "INDEC", 0, 0 },
                    { 635711002920L, "CALLE", 98, 99, "CABRAL SGT, Buenos Aires, General Pueyrredón", 6357110L, "CABRAL SGT", "INDEC", 0, 1 },
                    { 635711002925L, "CALLE", 0, 0, "CABRERA, Buenos Aires, General Pueyrredón", 6357110L, "CABRERA", "INDEC", 0, 0 },
                    { 635711002930L, "CALLE", 0, 0, "CACIQUE CHUYANTUYA, Buenos Aires, General Pueyrredón", 6357110L, "CACIQUE CHUYANTUYA", "INDEC", 0, 0 },
                    { 635711002935L, "CALLE", 3399, 3498, "CALABRESE, Buenos Aires, General Pueyrredón", 6357110L, "CALABRESE", "INDEC", 0, 0 },
                    { 635711002940L, "CALLE", 0, 0, "CALABRIA, Buenos Aires, General Pueyrredón", 6357110L, "CALABRIA", "INDEC", 0, 0 },
                    { 635711002945L, "CALLE", 7099, 7098, "CALABRIA BIS B, Buenos Aires, General Pueyrredón", 6357110L, "CALABRIA BIS B", "INDEC", 0, 0 },
                    { 635711002950L, "CALLE", 298, 399, "CALANDRIA, Buenos Aires, General Pueyrredón", 6357110L, "CALANDRIA", "INDEC", 0, 0 },
                    { 635711002955L, "CALLE", 0, 0, "CALAZA BIS, Buenos Aires, General Pueyrredón", 6357110L, "CALAZA BIS", "INDEC", 0, 0 },
                    { 635711002960L, "CALLE", 6699, 6698, "CALCHAQUI, Buenos Aires, General Pueyrredón", 6357110L, "CALCHAQUI", "INDEC", 0, 0 },
                    { 635711002965L, "CALLE", 0, 0, "CALFULCURA, Buenos Aires, General Pueyrredón", 6357110L, "CALFULCURA", "INDEC", 0, 0 },
                    { 635711002970L, "CALLE", 898, 0, "CALLE 0, Buenos Aires, General Pueyrredón", 6357110L, "CALLE 0", "INDEC", 0, 0 },
                    { 635711002975L, "CALLE", 0, 0, "CALLE 1 - LOMA VERDE, Buenos Aires, General Pueyrredón", 6357110L, "CALLE 1 - LOMA VERDE", "INDEC", 0, 0 },
                    { 635711002980L, "CALLE", 0, 0, "CALLE 1 ( BELTRAN BIS), Buenos Aires, General Pueyrredón", 6357110L, "CALLE 1 ( BELTRAN BIS)", "INDEC", 0, 0 },
                    { 635711002985L, "CALLE", 0, 0, "CALLE 1 B, Buenos Aires, General Pueyrredón", 6357110L, "CALLE 1 B", "INDEC", 0, 0 },
                    { 635711002990L, "CALLE", 0, 0, "CALLE 10, Buenos Aires, General Pueyrredón", 6357110L, "CALLE 10", "INDEC", 0, 0 },
                    { 635711002995L, "CALLE", 0, 0, "CALLE 10 BIS, Buenos Aires, General Pueyrredón", 6357110L, "CALLE 10 BIS", "INDEC", 0, 0 },
                    { 635711003000L, "CALLE", 0, 0, "CALLE 11, Buenos Aires, General Pueyrredón", 6357110L, "CALLE 11", "INDEC", 0, 0 },
                    { 635711003005L, "CALLE", 0, 0, "CALLE 13, Buenos Aires, General Pueyrredón", 6357110L, "CALLE 13", "INDEC", 0, 0 },
                    { 635711003010L, "CALLE", 0, 0, "CALLE 14 BIS, Buenos Aires, General Pueyrredón", 6357110L, "CALLE 14 BIS", "INDEC", 0, 0 },
                    { 635711003015L, "CALLE", 0, 0, "CALLE 17, Buenos Aires, General Pueyrredón", 6357110L, "CALLE 17", "INDEC", 0, 0 },
                    { 635711003020L, "CALLE", 798, 599, "CALLE 2, Buenos Aires, General Pueyrredón", 6357110L, "CALLE 2", "INDEC", 0, 0 },
                    { 635711003025L, "CALLE", 0, 0, "CALLE 200, Buenos Aires, General Pueyrredón", 6357110L, "CALLE 200", "INDEC", 0, 0 },
                    { 635711003030L, "CALLE", 0, 0, "CALLE 209 BIS, Buenos Aires, General Pueyrredón", 6357110L, "CALLE 209 BIS", "INDEC", 0, 0 },
                    { 635711003035L, "CALLE", 0, 0, "CALLE 211 BIS, Buenos Aires, General Pueyrredón", 6357110L, "CALLE 211 BIS", "INDEC", 0, 0 },
                    { 635711003040L, "CALLE", 0, 0, "CALLE 228 BIS, Buenos Aires, General Pueyrredón", 6357110L, "CALLE 228 BIS", "INDEC", 0, 0 },
                    { 635711003045L, "CALLE", 0, 0, "CALLE 252 (EX 232), Buenos Aires, General Pueyrredón", 6357110L, "CALLE 252 (EX 232)", "INDEC", 0, 0 },
                    { 635711003050L, "CALLE", 1899, 1798, "CALLE 254, Buenos Aires, General Pueyrredón", 6357110L, "CALLE 254", "INDEC", 1101, 0 },
                    { 635711003055L, "CALLE", 0, 0, "CALLE 254 (EX 234), Buenos Aires, General Pueyrredón", 6357110L, "CALLE 254 (EX 234)", "INDEC", 0, 0 },
                    { 635711003060L, "CALLE", 1898, 1899, "CALLE 256, Buenos Aires, General Pueyrredón", 6357110L, "CALLE 256", "INDEC", 0, 0 },
                    { 635711003065L, "CALLE", 0, 0, "CALLE 256 (EX 238), Buenos Aires, General Pueyrredón", 6357110L, "CALLE 256 (EX 238)", "INDEC", 0, 0 },
                    { 635711003070L, "CALLE", 0, 0, "CALLE 258, Buenos Aires, General Pueyrredón", 6357110L, "CALLE 258", "INDEC", 0, 0 },
                    { 635711003075L, "CALLE", 1798, 0, "CALLE 258 (EX 258), Buenos Aires, General Pueyrredón", 6357110L, "CALLE 258 (EX 258)", "INDEC", 0, 0 },
                    { 635711003080L, "CALLE", 0, 0, "CALLE 270 BIS, Buenos Aires, General Pueyrredón", 6357110L, "CALLE 270 BIS", "INDEC", 0, 0 },
                    { 635711003085L, "CALLE", 0, 0, "CALLE 272 BIS, Buenos Aires, General Pueyrredón", 6357110L, "CALLE 272 BIS", "INDEC", 0, 0 },
                    { 635711003090L, "CALLE", 0, 0, "CALLE 29, Buenos Aires, General Pueyrredón", 6357110L, "CALLE 29", "INDEC", 0, 0 },
                    { 635711003095L, "CALLE", 0, 0, "CALLE 3, Buenos Aires, General Pueyrredón", 6357110L, "CALLE 3", "INDEC", 0, 0 },
                    { 635711003100L, "CALLE", 0, 0, "CALLE 31, Buenos Aires, General Pueyrredón", 6357110L, "CALLE 31", "INDEC", 0, 0 },
                    { 635711003105L, "CALLE", 0, 0, "CALLE 33, Buenos Aires, General Pueyrredón", 6357110L, "CALLE 33", "INDEC", 0, 0 },
                    { 635711003110L, "CALLE", 0, 0, "CALLE 34, Buenos Aires, General Pueyrredón", 6357110L, "CALLE 34", "INDEC", 0, 0 },
                    { 635711003115L, "CALLE", 0, 0, "CALLE 35, Buenos Aires, General Pueyrredón", 6357110L, "CALLE 35", "INDEC", 0, 0 },
                    { 635711003120L, "CALLE", 0, 0, "CALLE 4, Buenos Aires, General Pueyrredón", 6357110L, "CALLE 4", "INDEC", 0, 0 },
                    { 635711003125L, "CALLE", 0, 0, "CALLE 4 BIS, Buenos Aires, General Pueyrredón", 6357110L, "CALLE 4 BIS", "INDEC", 0, 0 },
                    { 635711003130L, "CALLE", 0, 0, "CALLE 40, Buenos Aires, General Pueyrredón", 6357110L, "CALLE 40", "INDEC", 0, 0 },
                    { 635711003135L, "CALLE", 0, 0, "CALLE 42, Buenos Aires, General Pueyrredón", 6357110L, "CALLE 42", "INDEC", 0, 0 },
                    { 635711003140L, "CALLE", 0, 0, "CALLE 44, Buenos Aires, General Pueyrredón", 6357110L, "CALLE 44", "INDEC", 0, 0 },
                    { 635711003145L, "CALLE", 0, 0, "CALLE 46, Buenos Aires, General Pueyrredón", 6357110L, "CALLE 46", "INDEC", 0, 0 },
                    { 635711003150L, "CALLE", 0, 0, "CALLE 48, Buenos Aires, General Pueyrredón", 6357110L, "CALLE 48", "INDEC", 0, 0 },
                    { 635711003155L, "CALLE", 0, 0, "CALLE 5, Buenos Aires, General Pueyrredón", 6357110L, "CALLE 5", "INDEC", 0, 0 },
                    { 635711003160L, "CALLE", 0, 0, "CALLE 50, Buenos Aires, General Pueyrredón", 6357110L, "CALLE 50", "INDEC", 0, 0 },
                    { 635711003165L, "CALLE", 0, 0, "CALLE 509, Buenos Aires, General Pueyrredón", 6357110L, "CALLE 509", "INDEC", 0, 0 },
                    { 635711003170L, "CALLE", 0, 0, "CALLE 52, Buenos Aires, General Pueyrredón", 6357110L, "CALLE 52", "INDEC", 0, 0 },
                    { 635711003175L, "CALLE", 0, 0, "CALLE 54, Buenos Aires, General Pueyrredón", 6357110L, "CALLE 54", "INDEC", 0, 0 },
                    { 635711003180L, "CALLE", 0, 0, "CALLE 58, Buenos Aires, General Pueyrredón", 6357110L, "CALLE 58", "INDEC", 0, 0 },
                    { 635711003185L, "CALLE", 0, 0, "CALLE 6, Buenos Aires, General Pueyrredón", 6357110L, "CALLE 6", "INDEC", 0, 0 },
                    { 635711003190L, "CALLE", 0, 0, "CALLE 6 BIS, Buenos Aires, General Pueyrredón", 6357110L, "CALLE 6 BIS", "INDEC", 0, 0 },
                    { 635711003195L, "CALLE", 0, 4598, "CALLE 63 BIS, Buenos Aires, General Pueyrredón", 6357110L, "CALLE 63 BIS", "INDEC", 0, 4500 },
                    { 635711003200L, "CALLE", 0, 0, "CALLE 65, Buenos Aires, General Pueyrredón", 6357110L, "CALLE 65", "INDEC", 0, 0 },
                    { 635711003205L, "CALLE", 0, 0, "CALLE 66, Buenos Aires, General Pueyrredón", 6357110L, "CALLE 66", "INDEC", 0, 0 },
                    { 635711003210L, "CALLE", 0, 0, "CALLE 67, Buenos Aires, General Pueyrredón", 6357110L, "CALLE 67", "INDEC", 0, 0 },
                    { 635711003215L, "CALLE", 0, 0, "CALLE 69, Buenos Aires, General Pueyrredón", 6357110L, "CALLE 69", "INDEC", 0, 0 },
                    { 635711003220L, "CALLE", 0, 0, "CALLE 7, Buenos Aires, General Pueyrredón", 6357110L, "CALLE 7", "INDEC", 0, 0 },
                    { 635711003225L, "CALLE", 0, 0, "CALLE 71, Buenos Aires, General Pueyrredón", 6357110L, "CALLE 71", "INDEC", 0, 0 },
                    { 635711003230L, "CALLE", 1999, 1799, "CALLE 71 - ONEGLIA, Buenos Aires, General Pueyrredón", 6357110L, "CALLE 71 - ONEGLIA", "INDEC", 0, 0 },
                    { 635711003235L, "CALLE", 0, 0, "CALLE 71 BIS, Buenos Aires, General Pueyrredón", 6357110L, "CALLE 71 BIS", "INDEC", 0, 0 },
                    { 635711003240L, "CALLE", 0, 0, "CALLE 72, Buenos Aires, General Pueyrredón", 6357110L, "CALLE 72", "INDEC", 0, 0 },
                    { 635711003245L, "CALLE", 0, 0, "CALLE 73, Buenos Aires, General Pueyrredón", 6357110L, "CALLE 73", "INDEC", 0, 0 },
                    { 635711003250L, "CALLE", 15899, 799, "CALLE 73 - COMUNA DE MAFALDA, Buenos Aires, General Pueyrredón", 6357110L, "CALLE 73 - COMUNA DE MAFALDA", "INDEC", 0, 0 },
                    { 635711003255L, "CALLE", 0, 0, "CALLE 74, Buenos Aires, General Pueyrredón", 6357110L, "CALLE 74", "INDEC", 0, 0 },
                    { 635711003260L, "CALLE", 0, 0, "CALLE 75, Buenos Aires, General Pueyrredón", 6357110L, "CALLE 75", "INDEC", 0, 0 },
                    { 635711003265L, "CALLE", 1099, 1098, "CALLE 75 - BONNET, Buenos Aires, General Pueyrredón", 6357110L, "CALLE 75 - BONNET", "INDEC", 0, 0 },
                    { 635711003270L, "CALLE", 0, 0, "CALLE 79, Buenos Aires, General Pueyrredón", 6357110L, "CALLE 79", "INDEC", 0, 0 },
                    { 635711003275L, "CALLE", 0, 0, "CALLE 8, Buenos Aires, General Pueyrredón", 6357110L, "CALLE 8", "INDEC", 0, 0 },
                    { 635711003280L, "CALLE", 0, 0, "CALLE 8 BIS, Buenos Aires, General Pueyrredón", 6357110L, "CALLE 8 BIS", "INDEC", 0, 0 },
                    { 635711003285L, "CALLE", 0, 0, "CALLE 81, Buenos Aires, General Pueyrredón", 6357110L, "CALLE 81", "INDEC", 0, 0 },
                    { 635711003290L, "CALLE", 0, 0, "CALLE 83, Buenos Aires, General Pueyrredón", 6357110L, "CALLE 83", "INDEC", 0, 0 },
                    { 635711003295L, "CALLE", 0, 0, "CALLE 85, Buenos Aires, General Pueyrredón", 6357110L, "CALLE 85", "INDEC", 0, 0 },
                    { 635711003300L, "CALLE", 0, 0, "CALLE 9, Buenos Aires, General Pueyrredón", 6357110L, "CALLE 9", "INDEC", 0, 0 },
                    { 635711003305L, "CALLE", 0, 0, "CALLE 91, Buenos Aires, General Pueyrredón", 6357110L, "CALLE 91", "INDEC", 0, 0 },
                    { 635711003310L, "CALLE", 0, 0, "CALLE CANARIO, Buenos Aires, General Pueyrredón", 6357110L, "CALLE CANARIO", "INDEC", 0, 0 },
                    { 635711003315L, "CALLE", 0, 0, "CALLE LA CALANDRIA, Buenos Aires, General Pueyrredón", 6357110L, "CALLE LA CALANDRIA", "INDEC", 0, 0 },
                    { 635711003320L, "CALLE", 0, 0, "CALLE LAS MARGARITAS, Buenos Aires, General Pueyrredón", 6357110L, "CALLE LAS MARGARITAS", "INDEC", 0, 0 },
                    { 635711003325L, "CALLE", 0, 0, "CALLE LAS PALMERAS, Buenos Aires, General Pueyrredón", 6357110L, "CALLE LAS PALMERAS", "INDEC", 0, 0 },
                    { 635711003330L, "CALLE", 0, 0, "CALLE LOS NARANJOS, Buenos Aires, General Pueyrredón", 6357110L, "CALLE LOS NARANJOS", "INDEC", 0, 0 },
                    { 635711003335L, "CALLE", 0, 0, "CALLE LOS TILOS, Buenos Aires, General Pueyrredón", 6357110L, "CALLE LOS TILOS", "INDEC", 0, 0 },
                    { 635711003340L, "CALLE", 0, 0, "CALLE N 2, Buenos Aires, General Pueyrredón", 6357110L, "CALLE N 2", "INDEC", 0, 0 },
                    { 635711003345L, "CALLE", 0, 0, "CALLE N 1, Buenos Aires, General Pueyrredón", 6357110L, "CALLE N 1", "INDEC", 0, 0 },
                    { 635711003350L, "CALLE", 0, 0, "CALLE N 11, Buenos Aires, General Pueyrredón", 6357110L, "CALLE N 11", "INDEC", 0, 0 },
                    { 635711003355L, "CALLE", 0, 0, "CALLE N 18, Buenos Aires, General Pueyrredón", 6357110L, "CALLE N 18", "INDEC", 0, 0 },
                    { 635711003360L, "CALLE", 0, 0, "CALLE N 2, Buenos Aires, General Pueyrredón", 6357110L, "CALLE N 2", "INDEC", 0, 0 },
                    { 635711003365L, "CALLE", 0, 0, "CALLE N 3, Buenos Aires, General Pueyrredón", 6357110L, "CALLE N 3", "INDEC", 0, 0 },
                    { 635711003370L, "CALLE", 0, 0, "CALLE N 36, Buenos Aires, General Pueyrredón", 6357110L, "CALLE N 36", "INDEC", 0, 0 },
                    { 635711003375L, "CALLE", 0, 0, "CALLE N 38, Buenos Aires, General Pueyrredón", 6357110L, "CALLE N 38", "INDEC", 0, 0 },
                    { 635711003380L, "CALLE", 0, 0, "CALLE N 4, Buenos Aires, General Pueyrredón", 6357110L, "CALLE N 4", "INDEC", 0, 0 },
                    { 635711003385L, "CALLE", 0, 0, "CALLE N 5, Buenos Aires, General Pueyrredón", 6357110L, "CALLE N 5", "INDEC", 0, 0 },
                    { 635711003390L, "CALLE", 0, 0, "CALLE N 6, Buenos Aires, General Pueyrredón", 6357110L, "CALLE N 6", "INDEC", 0, 0 },
                    { 635711003395L, "CALLE", 0, 0, "CALLE N 8, Buenos Aires, General Pueyrredón", 6357110L, "CALLE N 8", "INDEC", 0, 0 },
                    { 635711003400L, "CALLE", 0, 0, "CALLE N 9, Buenos Aires, General Pueyrredón", 6357110L, "CALLE N 9", "INDEC", 0, 0 },
                    { 635711003405L, "CALLE", 0, 0, "CALLE N° 4, Buenos Aires, General Pueyrredón", 6357110L, "CALLE N° 4", "INDEC", 0, 0 },
                    { 635711003410L, "CALLE", 0, 0, "CALLE N°6, Buenos Aires, General Pueyrredón", 6357110L, "CALLE N°6", "INDEC", 0, 0 },
                    { 635711003415L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711003420L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711003425L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711003430L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711003435L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711003440L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711003445L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711003450L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711003455L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711003460L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711003465L, "CALLE", 1598, 9498, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 1501 },
                    { 635711003470L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711003475L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711003480L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711003485L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711003490L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711003495L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711003500L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711003505L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711003510L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711003515L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711003520L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711003525L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711003530L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711003535L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711003540L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711003545L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711003550L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711003555L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711003560L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711003565L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711003570L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711003575L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711003580L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711003585L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711003590L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711003595L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711003600L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711003605L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711003610L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711003620L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711003625L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711003630L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711003635L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711003640L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711003645L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711003650L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711003655L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711003660L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711003665L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711003670L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711003675L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711003680L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711003685L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711003690L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711003695L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711003700L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711003705L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711003710L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711003715L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711003720L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711003725L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711003730L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711003735L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711003740L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711003745L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711003750L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711003755L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711003760L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711003765L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711003770L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711003775L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711003780L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711003785L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711003790L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711003795L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711003800L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711003805L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711003810L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711003815L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711003820L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711003825L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711003830L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711003835L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711003840L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711003845L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711003850L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711003855L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711003860L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711003865L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711003870L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711003875L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711003880L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711003885L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711003890L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711003895L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711003900L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711003905L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711003910L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711003915L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711003920L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711003925L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711003930L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711003935L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711003940L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711003945L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711003950L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711003955L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711003960L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711003965L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711003970L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711003975L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711003980L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711003985L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711003990L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711003995L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711004000L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711004005L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711004010L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711004015L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711004020L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711004025L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711004030L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711004035L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711004040L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711004045L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711004050L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711004055L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711004060L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711004065L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711004070L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711004075L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711004080L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711004085L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711004090L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711004095L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711004100L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711004105L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711004110L, "CALLE", 599, 598, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 501, 500 },
                    { 635711004115L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711004120L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711004125L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711004130L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711004135L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711004140L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711004145L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711004150L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711004155L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711004160L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711004162L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711004165L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711004167L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711004170L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711004175L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711004180L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711004185L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711004190L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711004195L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711004200L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711004205L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711004210L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711004215L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711004220L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711004225L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711004230L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711004235L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711004240L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711004245L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711004250L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711004255L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711004260L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711004265L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711004270L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711004275L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711004280L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711004285L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711004290L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711004295L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711004300L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711004305L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711004310L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711004315L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711004320L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711004325L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711004330L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711004335L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711004340L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711004345L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711004350L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711004355L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711004360L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711004365L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711004370L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711004375L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711004380L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711004385L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711004390L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711004395L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711004400L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711004405L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711004410L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711004415L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711004420L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711004425L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711004430L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711004435L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711004440L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711004445L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711004450L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711004455L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711004460L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711004465L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711004470L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SN", "INDEC", 0, 0 },
                    { 635711004475L, "CALLE", 0, 0, "CALLE SOLEDAD, Buenos Aires, General Pueyrredón", 6357110L, "CALLE SOLEDAD", "INDEC", 0, 0 },
                    { 635711004480L, "CALLE", 0, 0, "CAMET F, Buenos Aires, General Pueyrredón", 6357110L, "CAMET F", "INDEC", 0, 0 },
                    { 635711004485L, "CALLE", 0, 0, "CAMET J P, Buenos Aires, General Pueyrredón", 6357110L, "CAMET J P", "INDEC", 0, 0 },
                    { 635711004490L, "CALLE", 0, 0, "CAMINO SAN FRANCISCO, Buenos Aires, General Pueyrredón", 6357110L, "CAMINO SAN FRANCISCO", "INDEC", 0, 0 },
                    { 635711004495L, "CALLE", 0, 0, "CAMINOS A LAS CANERAS, Buenos Aires, General Pueyrredón", 6357110L, "CAMINOS A LAS CANERAS", "INDEC", 0, 0 },
                    { 635711004500L, "CALLE", 0, 0, "CAMPESINOS, Buenos Aires, General Pueyrredón", 6357110L, "CAMPESINOS", "INDEC", 0, 0 },
                    { 635711004505L, "CALLE", 2798, 2799, "CANATA DIAG, Buenos Aires, General Pueyrredón", 6357110L, "CANATA DIAG", "INDEC", 2400, 2401 },
                    { 635711004510L, "CALLE", 0, 0, "CANNES, Buenos Aires, General Pueyrredón", 6357110L, "CANNES", "INDEC", 0, 0 },
                    { 635711004515L, "CALLE", 0, 0, "CAPITAN GIACHINO PEDRO EDUARDO, Buenos Aires, General Pueyrredón", 6357110L, "CAPITAN GIACHINO PEDRO EDUARDO", "INDEC", 0, 0 },
                    { 635711004520L, "CALLE", 0, 0, "CARPINTERO, Buenos Aires, General Pueyrredón", 6357110L, "CARPINTERO", "INDEC", 0, 0 },
                    { 635711004525L, "CALLE", 2498, 2498, "CARRASCO, Buenos Aires, General Pueyrredón", 6357110L, "CARRASCO", "INDEC", 2400, 2400 },
                    { 635711004530L, "CALLE", 998, 999, "CARRIEGO EVARISTO, Buenos Aires, General Pueyrredón", 6357110L, "CARRIEGO EVARISTO", "INDEC", 0, 0 },
                    { 635711004535L, "CALLE", 10898, 2198, "CARRILLO, Buenos Aires, General Pueyrredón", 6357110L, "CARRILLO", "INDEC", 0, 0 },
                    { 635711004540L, "CALLE", 0, 0, "CASACUBERTA, Buenos Aires, General Pueyrredón", 6357110L, "CASACUBERTA", "INDEC", 0, 0 },
                    { 635711004545L, "CALLE", 0, 0, "CASEROS, Buenos Aires, General Pueyrredón", 6357110L, "CASEROS", "INDEC", 0, 0 },
                    { 635711004550L, "CALLE", 0, 0, "CASTAGNINO, Buenos Aires, General Pueyrredón", 6357110L, "CASTAGNINO", "INDEC", 0, 0 },
                    { 635711004555L, "CALLE", 1099, 599, "CASTILLA Y LEON, Buenos Aires, General Pueyrredón", 6357110L, "CASTILLA Y LEON", "INDEC", 0, 0 },
                    { 635711004560L, "CALLE", 3598, 6598, "CATRIEL, Buenos Aires, General Pueyrredón", 6357110L, "CATRIEL", "INDEC", 0, 0 },
                    { 635711004565L, "CALLE", 0, 0, "CAUPOLICAN, Buenos Aires, General Pueyrredón", 6357110L, "CAUPOLICAN", "INDEC", 0, 0 },
                    { 635711004570L, "CALLE", 0, 0, "CAYETANO RODRIGUEZ, Buenos Aires, General Pueyrredón", 6357110L, "CAYETANO RODRIGUEZ", "INDEC", 0, 0 },
                    { 635711004575L, "CALLE", 0, 0, "CEDRO, Buenos Aires, General Pueyrredón", 6357110L, "CEDRO", "INDEC", 0, 0 },
                    { 635711004580L, "CALLE", 0, 0, "CEDRO AZUL, Buenos Aires, General Pueyrredón", 6357110L, "CEDRO AZUL", "INDEC", 0, 0 },
                    { 635711004585L, "CALLE", 8899, 8898, "CEDROS, Buenos Aires, General Pueyrredón", 6357110L, "CEDROS", "INDEC", 0, 0 },
                    { 635711004590L, "CALLE", 0, 0, "CEIBOS, Buenos Aires, General Pueyrredón", 6357110L, "CEIBOS", "INDEC", 0, 0 },
                    { 635711004595L, "CALLE", 0, 0, "CELEDONIO FLORES, Buenos Aires, General Pueyrredón", 6357110L, "CELEDONIO FLORES", "INDEC", 0, 0 },
                    { 635711004600L, "CALLE", 0, 0, "CENTENARIO AV, Buenos Aires, General Pueyrredón", 6357110L, "CENTENARIO AV", "INDEC", 0, 0 },
                    { 635711004605L, "CALLE", 0, 0, "CERRITO, Buenos Aires, General Pueyrredón", 6357110L, "CERRITO", "INDEC", 0, 0 },
                    { 635711004610L, "CALLE", 0, 0, "CERRITO SUR, Buenos Aires, General Pueyrredón", 6357110L, "CERRITO SUR", "INDEC", 0, 0 },
                    { 635711004615L, "CALLE", 0, 0, "CERRO ACONCAGUA, Buenos Aires, General Pueyrredón", 6357110L, "CERRO ACONCAGUA", "INDEC", 0, 0 },
                    { 635711004620L, "CALLE", 0, 0, "CERRO FIAMBALA, Buenos Aires, General Pueyrredón", 6357110L, "CERRO FIAMBALA", "INDEC", 0, 0 },
                    { 635711004625L, "CALLE", 0, 0, "CERRO HERMOSO, Buenos Aires, General Pueyrredón", 6357110L, "CERRO HERMOSO", "INDEC", 0, 0 },
                    { 635711004630L, "CALLE", 0, 0, "CERRO LANIN, Buenos Aires, General Pueyrredón", 6357110L, "CERRO LANIN", "INDEC", 0, 0 },
                    { 635711004635L, "CALLE", 0, 0, "CERRO MERCEDARIO, Buenos Aires, General Pueyrredón", 6357110L, "CERRO MERCEDARIO", "INDEC", 0, 0 },
                    { 635711004640L, "CALLE", 0, 0, "CERRO MURALLON, Buenos Aires, General Pueyrredón", 6357110L, "CERRO MURALLON", "INDEC", 0, 0 },
                    { 635711004645L, "CALLE", 0, 0, "CERRO TORRE, Buenos Aires, General Pueyrredón", 6357110L, "CERRO TORRE", "INDEC", 0, 0 },
                    { 635711004650L, "CALLE", 0, 0, "CERRO TRONADOR, Buenos Aires, General Pueyrredón", 6357110L, "CERRO TRONADOR", "INDEC", 0, 0 },
                    { 635711004655L, "CALLE", 0, 0, "CHAITER, Buenos Aires, General Pueyrredón", 6357110L, "CHAITER", "INDEC", 0, 0 },
                    { 635711004660L, "CALLE", 599, 598, "CHAMPAGNAT, Buenos Aires, General Pueyrredón", 6357110L, "CHAMPAGNAT", "INDEC", 1, 0 },
                    { 635711004665L, "CALLE", 0, 0, "CHANAL, Buenos Aires, General Pueyrredón", 6357110L, "CHANAL", "INDEC", 0, 0 },
                    { 635711004670L, "CALLE", 298, 299, "CHARLONE, Buenos Aires, General Pueyrredón", 6357110L, "CHARLONE", "INDEC", 0, 0 },
                    { 635711004675L, "CALLE", 1, 0, "CHASCOMUS, Buenos Aires, General Pueyrredón", 6357110L, "CHASCOMUS", "INDEC", 0, 0 },
                    { 635711004680L, "CALLE", 0, 0, "CHINGOLO, Buenos Aires, General Pueyrredón", 6357110L, "CHINGOLO", "INDEC", 0, 0 },
                    { 635711004685L, "CALLE", 0, 0, "CHOCORI, Buenos Aires, General Pueyrredón", 6357110L, "CHOCORI", "INDEC", 0, 0 },
                    { 635711004690L, "CALLE", 0, 0, "CIANCHETTA LORENZO, Buenos Aires, General Pueyrredón", 6357110L, "CIANCHETTA LORENZO", "INDEC", 0, 0 },
                    { 635711004695L, "CALLE", 0, 0, "CIPRESE, Buenos Aires, General Pueyrredón", 6357110L, "CIPRESE", "INDEC", 0, 0 },
                    { 635711004700L, "CALLE", 0, 299, "CIPRESES, Buenos Aires, General Pueyrredón", 6357110L, "CIPRESES", "INDEC", 0, 0 },
                    { 635711004705L, "CALLE", 3399, 3553, "CIUDAD DE ASUNCION, Buenos Aires, General Pueyrredón", 6357110L, "CIUDAD DE ASUNCION", "INDEC", 0, 0 },
                    { 635711004710L, "CALLE", 0, 0, "CIUDAD DE DOLORES BIS, Buenos Aires, General Pueyrredón", 6357110L, "CIUDAD DE DOLORES BIS", "INDEC", 0, 0 },
                    { 635711004715L, "CALLE", 798, 799, "CIUDAD DE LAS FLORES, Buenos Aires, General Pueyrredón", 6357110L, "CIUDAD DE LAS FLORES", "INDEC", 300, 301 },
                    { 635711004720L, "CALLE", 0, 0, "CNO EST CAMET, Buenos Aires, General Pueyrredón", 6357110L, "CNO EST CAMET", "INDEC", 0, 0 },
                    { 635711004725L, "CALLE", 0, 0, "CNO PARQUE HERMOSO A AEROCLUB, Buenos Aires, General Pueyrredón", 6357110L, "CNO PARQUE HERMOSO A AEROCLUB", "INDEC", 0, 0 },
                    { 635711004730L, "CALLE", 0, 0, "COCHERO FERRO, Buenos Aires, General Pueyrredón", 6357110L, "COCHERO FERRO", "INDEC", 0, 0 },
                    { 635711004735L, "CALLE", 5198, 3998, "COELHO DE MEYRELLES J, Buenos Aires, General Pueyrredón", 6357110L, "COELHO DE MEYRELLES J", "INDEC", 0, 0 },
                    { 635711004740L, "CALLE", 9498, 8999, "COLECTORA NORTE VIA, Buenos Aires, General Pueyrredón", 6357110L, "COLECTORA NORTE VIA", "INDEC", 9000, 8901 },
                    { 635711004745L, "CALLE", 0, 0, "COLIQUEO, Buenos Aires, General Pueyrredón", 6357110L, "COLIQUEO", "INDEC", 0, 0 },
                    { 635711004750L, "CALLE", 0, 0, "COMANDANTE ERNESTO GUEVARA, Buenos Aires, General Pueyrredón", 6357110L, "COMANDANTE ERNESTO GUEVARA", "INDEC", 0, 0 },
                    { 635711004755L, "CALLE", 0, 0, "COMODORO RIVADAVIA, Buenos Aires, General Pueyrredón", 6357110L, "COMODORO RIVADAVIA", "INDEC", 0, 0 },
                    { 635711004760L, "CALLE", 3699, 3798, "CORBETA GRAN VILLE, Buenos Aires, General Pueyrredón", 6357110L, "CORBETA GRAN VILLE", "INDEC", 3501, 0 },
                    { 635711004765L, "CALLE", 38410, 5298, "CORBETA URUGUAY, Buenos Aires, General Pueyrredón", 6357110L, "CORBETA URUGUAY", "INDEC", 0, 0 },
                    { 635711004770L, "CALLE", 4699, 4798, "CORONEL DAVID JAWETT, Buenos Aires, General Pueyrredón", 6357110L, "CORONEL DAVID JAWETT", "INDEC", 0, 0 },
                    { 635711004775L, "CALLE", 5199, 4598, "COSTA ATLANTICA, Buenos Aires, General Pueyrredón", 6357110L, "COSTA ATLANTICA", "INDEC", 0, 0 },
                    { 635711004780L, "CALLE", 3498, 3399, "COSTA AZUL, Buenos Aires, General Pueyrredón", 6357110L, "COSTA AZUL", "INDEC", 0, 0 },
                    { 635711004785L, "CALLE", 0, 0, "CRUCERO GRL BELGRANO, Buenos Aires, General Pueyrredón", 6357110L, "CRUCERO GRL BELGRANO", "INDEC", 0, 0 },
                    { 635711004790L, "CALLE", 0, 0, "CRUCERO LA ARGENTINA, Buenos Aires, General Pueyrredón", 6357110L, "CRUCERO LA ARGENTINA", "INDEC", 0, 0 },
                    { 635711004795L, "CALLE", 0, 0, "CURRO MANUEL, Buenos Aires, General Pueyrredón", 6357110L, "CURRO MANUEL", "INDEC", 0, 0 },
                    { 635711004800L, "CALLE", 0, 0, "CURROS, Buenos Aires, General Pueyrredón", 6357110L, "CURROS", "INDEC", 0, 0 },
                    { 635711004805L, "CALLE", 0, 0, "DALIAS, Buenos Aires, General Pueyrredón", 6357110L, "DALIAS", "INDEC", 0, 0 },
                    { 635711004810L, "CALLE", 0, 0, "DANERI, Buenos Aires, General Pueyrredón", 6357110L, "DANERI", "INDEC", 0, 0 },
                    { 635711004815L, "CALLE", 0, 0, "DANIEL A JUCIC, Buenos Aires, General Pueyrredón", 6357110L, "DANIEL A JUCIC", "INDEC", 0, 0 },
                    { 635711004820L, "CALLE", 6098, 6099, "DAVALOS, Buenos Aires, General Pueyrredón", 6357110L, "DAVALOS", "INDEC", 5900, 5901 },
                    { 635711004825L, "CALLE", 2099, 2198, "DE BIEDMA J, Buenos Aires, General Pueyrredón", 6357110L, "DE BIEDMA J", "INDEC", 1761, 1702 },
                    { 635711004830L, "CALLE", 798, 799, "DE BRAGADO, Buenos Aires, General Pueyrredón", 6357110L, "DE BRAGADO", "INDEC", 300, 301 },
                    { 635711004835L, "CALLE", 0, 0, "DE LA COLINA, Buenos Aires, General Pueyrredón", 6357110L, "DE LA COLINA", "INDEC", 0, 0 },
                    { 635711004840L, "CALLE", 0, 0, "DE LA PLAZA FORTUNATO, Buenos Aires, General Pueyrredón", 6357110L, "DE LA PLAZA FORTUNATO", "INDEC", 0, 0 },
                    { 635711004845L, "CALLE", 0, 0, "DE LOS INCAS, Buenos Aires, General Pueyrredón", 6357110L, "DE LOS INCAS", "INDEC", 0, 0 },
                    { 635711004850L, "CALLE", 0, 0, "DE LOS RESERVISTAS, Buenos Aires, General Pueyrredón", 6357110L, "DE LOS RESERVISTAS", "INDEC", 0, 0 },
                    { 635711004855L, "CALLE", 1598, 1599, "DE MARCHI, Buenos Aires, General Pueyrredón", 6357110L, "DE MARCHI", "INDEC", 0, 0 },
                    { 635711004860L, "CALLE", 0, 8499, "DEL LAGO, Buenos Aires, General Pueyrredón", 6357110L, "DEL LAGO", "INDEC", 0, 0 },
                    { 635711004865L, "CALLE", 3399, 3398, "DELLEPIANE, Buenos Aires, General Pueyrredón", 6357110L, "DELLEPIANE", "INDEC", 3201, 3200 },
                    { 635711004870L, "CALLE", 1198, 1199, "DERQUI, Buenos Aires, General Pueyrredón", 6357110L, "DERQUI", "INDEC", 0, 0 },
                    { 635711004875L, "CALLE", 1899, 7500, "DIAG ENRIQUE SANTOS DISCEPOLO, Buenos Aires, General Pueyrredón", 6357110L, "DIAG ENRIQUE SANTOS DISCEPOLO", "INDEC", 0, 0 },
                    { 635711004880L, "CALLE", 3398, 3399, "DIAG ANTONIO ALVAREZ, Buenos Aires, General Pueyrredón", 6357110L, "DIAG ANTONIO ALVAREZ", "INDEC", 3300, 3301 },
                    { 635711004885L, "CALLE", 0, 0, "DIAG CALLE 14, Buenos Aires, General Pueyrredón", 6357110L, "DIAG CALLE 14", "INDEC", 0, 0 },
                    { 635711004890L, "CALLE", 5799, 5798, "DIAG GARIBALDI, Buenos Aires, General Pueyrredón", 6357110L, "DIAG GARIBALDI", "INDEC", 0, 0 },
                    { 635711004895L, "CALLE", 1498, 0, "DIAG INVADO, Buenos Aires, General Pueyrredón", 6357110L, "DIAG INVADO", "INDEC", 0, 0 },
                    { 635711004900L, "CALLE", 0, 0, "DIAG JUSTO ERNESTO ROMAN, Buenos Aires, General Pueyrredón", 6357110L, "DIAG JUSTO ERNESTO ROMAN", "INDEC", 0, 0 },
                    { 635711004905L, "CALLE", 7998, 7999, "DIAG LEOPOLDO LUGONES, Buenos Aires, General Pueyrredón", 6357110L, "DIAG LEOPOLDO LUGONES", "INDEC", 1801, 0 },
                    { 635711004910L, "CALLE", 0, 0, "DIAG SUR, Buenos Aires, General Pueyrredón", 6357110L, "DIAG SUR", "INDEC", 0, 0 },
                    { 635711004915L, "CALLE", 3299, 799, "DIAG VELEZ SARFIELD, Buenos Aires, General Pueyrredón", 6357110L, "DIAG VELEZ SARFIELD", "INDEC", 0, 0 },
                    { 635711004920L, "CALLE", 0, 0, "DIAG BUQUE PESQUERO SAN GABRIEL, Buenos Aires, General Pueyrredón", 6357110L, "DIAG BUQUE PESQUERO SAN GABRIEL", "INDEC", 0, 0 },
                    { 635711004925L, "CALLE", 0, 0, "DIAG DEL SUR, Buenos Aires, General Pueyrredón", 6357110L, "DIAG DEL SUR", "INDEC", 0, 0 },
                    { 635711004930L, "CALLE", 799, 898, "DIAG GRAN ALMIRANTE, Buenos Aires, General Pueyrredón", 6357110L, "DIAG GRAN ALMIRANTE", "INDEC", 0, 0 },
                    { 635711004935L, "CALLE", 2699, 2698, "DIAG JUAN B ALBERDI, Buenos Aires, General Pueyrredón", 6357110L, "DIAG JUAN B ALBERDI", "INDEC", 0, 0 },
                    { 635711004940L, "CALLE", 0, 0, "DIAG NORTE, Buenos Aires, General Pueyrredón", 6357110L, "DIAG NORTE", "INDEC", 0, 0 },
                    { 635711004945L, "CALLE", 0, 0, "DIAGONAL BORDE ARROYO, Buenos Aires, General Pueyrredón", 6357110L, "DIAGONAL BORDE ARROYO", "INDEC", 0, 0 },
                    { 635711004950L, "CALLE", 0, 0, "DIAGONAL DEL NORTE, Buenos Aires, General Pueyrredón", 6357110L, "DIAGONAL DEL NORTE", "INDEC", 0, 0 },
                    { 635711004955L, "CALLE", 0, 0, "DIAGONAL DEL SUR, Buenos Aires, General Pueyrredón", 6357110L, "DIAGONAL DEL SUR", "INDEC", 0, 0 },
                    { 635711004960L, "CALLE", 0, 0, "DIAGONAL NORTE, Buenos Aires, General Pueyrredón", 6357110L, "DIAGONAL NORTE", "INDEC", 0, 0 },
                    { 635711004965L, "CALLE", 4599, 4199, "DIAGONAL OMBU, Buenos Aires, General Pueyrredón", 6357110L, "DIAGONAL OMBU", "INDEC", 3801, 0 },
                    { 635711004970L, "CALLE", 0, 0, "DIAGONAL SUR, Buenos Aires, General Pueyrredón", 6357110L, "DIAGONAL SUR", "INDEC", 0, 0 },
                    { 635711004975L, "CALLE", 0, 0, "DIECKMANN JUANA G, Buenos Aires, General Pueyrredón", 6357110L, "DIECKMANN JUANA G", "INDEC", 0, 0 },
                    { 635711004980L, "CALLE", 0, 0, "DON ARTURO, Buenos Aires, General Pueyrredón", 6357110L, "DON ARTURO", "INDEC", 0, 0 },
                    { 635711004985L, "CALLE", 0, 0, "DON T ROLDAN, Buenos Aires, General Pueyrredón", 6357110L, "DON T ROLDAN", "INDEC", 0, 0 },
                    { 635711004990L, "CALLE", 0, 0, "DR MARCELO JULIO FITTE, Buenos Aires, General Pueyrredón", 6357110L, "DR MARCELO JULIO FITTE", "INDEC", 0, 0 },
                    { 635711004995L, "CALLE", 0, 0, "DUFRECHOU, Buenos Aires, General Pueyrredón", 6357110L, "DUFRECHOU", "INDEC", 0, 0 },
                    { 635711005000L, "CALLE", 5999, 5998, "E ZEBALLOS, Buenos Aires, General Pueyrredón", 6357110L, "E ZEBALLOS", "INDEC", 0, 0 },
                    { 635711005005L, "CALLE", 0, 0, "ED P RAMOS, Buenos Aires, General Pueyrredón", 6357110L, "ED P RAMOS", "INDEC", 0, 0 },
                    { 635711005010L, "CALLE", 0, 0, "EDUARDO AROLAS, Buenos Aires, General Pueyrredón", 6357110L, "EDUARDO AROLAS", "INDEC", 0, 0 },
                    { 635711005015L, "CALLE", 0, 0, "EDUARDO G CARASA, Buenos Aires, General Pueyrredón", 6357110L, "EDUARDO G CARASA", "INDEC", 0, 0 },
                    { 635711005020L, "CALLE", 398, 399, "EL BENTEVEO, Buenos Aires, General Pueyrredón", 6357110L, "EL BENTEVEO", "INDEC", 0, 1 },
                    { 635711005025L, "CALLE", 8299, 8298, "EL CANO, Buenos Aires, General Pueyrredón", 6357110L, "EL CANO", "INDEC", 0, 0 },
                    { 635711005030L, "CALLE", 0, 0, "EL CANO BIS, Buenos Aires, General Pueyrredón", 6357110L, "EL CANO BIS", "INDEC", 0, 0 },
                    { 635711005035L, "CALLE", 0, 0, "EL CARDENAL, Buenos Aires, General Pueyrredón", 6357110L, "EL CARDENAL", "INDEC", 0, 0 },
                    { 635711005040L, "CALLE", 399, 398, "EL CARPINTERO, Buenos Aires, General Pueyrredón", 6357110L, "EL CARPINTERO", "INDEC", 1, 0 },
                    { 635711005045L, "CALLE", 0, 0, "EL CHAJA, Buenos Aires, General Pueyrredón", 6357110L, "EL CHAJA", "INDEC", 0, 0 },
                    { 635711005050L, "CALLE", 298, 298, "EL CHINGOLO, Buenos Aires, General Pueyrredón", 6357110L, "EL CHINGOLO", "INDEC", 0, 0 },
                    { 635711005055L, "CALLE", 399, 398, "EL CHURRINCHE, Buenos Aires, General Pueyrredón", 6357110L, "EL CHURRINCHE", "INDEC", 1, 0 },
                    { 635711005060L, "CALLE", 399, 98, "EL CORBATITA, Buenos Aires, General Pueyrredón", 6357110L, "EL CORBATITA", "INDEC", 0, 0 },
                    { 635711005065L, "CALLE", 0, 0, "EL FLAMENCO, Buenos Aires, General Pueyrredón", 6357110L, "EL FLAMENCO", "INDEC", 0, 0 },
                    { 635711005070L, "CALLE", 399, 98, "EL GAVIOTIN, Buenos Aires, General Pueyrredón", 6357110L, "EL GAVIOTIN", "INDEC", 1, 0 },
                    { 635711005075L, "CALLE", 399, 398, "EL GORRION, Buenos Aires, General Pueyrredón", 6357110L, "EL GORRION", "INDEC", 0, 0 },
                    { 635711005080L, "CALLE", 0, 0, "EL HORNERO, Buenos Aires, General Pueyrredón", 6357110L, "EL HORNERO", "INDEC", 0, 0 },
                    { 635711005085L, "CALLE", 399, 398, "EL JILGUERO, Buenos Aires, General Pueyrredón", 6357110L, "EL JILGUERO", "INDEC", 0, 0 },
                    { 635711005090L, "CALLE", 398, 399, "EL LENATERO, Buenos Aires, General Pueyrredón", 6357110L, "EL LENATERO", "INDEC", 0, 1 },
                    { 635711005095L, "CALLE", 0, 0, "EL MIXTO, Buenos Aires, General Pueyrredón", 6357110L, "EL MIXTO", "INDEC", 0, 0 },
                    { 635711005100L, "CALLE", 8199, 8198, "EL PAMPERO, Buenos Aires, General Pueyrredón", 6357110L, "EL PAMPERO", "INDEC", 8001, 8002 },
                    { 635711005105L, "CALLE", 0, 0, "EL PICAFLOR, Buenos Aires, General Pueyrredón", 6357110L, "EL PICAFLOR", "INDEC", 0, 0 },
                    { 635711005110L, "CALLE", 399, 0, "EL PIRINCHO, Buenos Aires, General Pueyrredón", 6357110L, "EL PIRINCHO", "INDEC", 0, 0 },
                    { 635711005115L, "CALLE", 0, 0, "EL SULKY, Buenos Aires, General Pueyrredón", 6357110L, "EL SULKY", "INDEC", 0, 0 },
                    { 635711005120L, "CALLE", 0, 0, "EL TEJADO, Buenos Aires, General Pueyrredón", 6357110L, "EL TEJADO", "INDEC", 0, 0 },
                    { 635711005125L, "CALLE", 399, 398, "EL TERO, Buenos Aires, General Pueyrredón", 6357110L, "EL TERO", "INDEC", 0, 0 },
                    { 635711005130L, "CALLE", 0, 0, "EL TEROTERO, Buenos Aires, General Pueyrredón", 6357110L, "EL TEROTERO", "INDEC", 0, 0 },
                    { 635711005135L, "CALLE", 398, 399, "EL TORDO, Buenos Aires, General Pueyrredón", 6357110L, "EL TORDO", "INDEC", 0, 0 },
                    { 635711005140L, "CALLE", 0, 0, "EL ZORZAL, Buenos Aires, General Pueyrredón", 6357110L, "EL ZORZAL", "INDEC", 0, 0 },
                    { 635711005145L, "CALLE", 10698, 10499, "ELCANO, Buenos Aires, General Pueyrredón", 6357110L, "ELCANO", "INDEC", 0, 0 },
                    { 635711005150L, "CALLE", 4899, 0, "ELIAS ALLIPI, Buenos Aires, General Pueyrredón", 6357110L, "ELIAS ALLIPI", "INDEC", 0, 0 },
                    { 635711005155L, "CALLE", 0, 0, "ELISA ALVEAR DE BOSCH, Buenos Aires, General Pueyrredón", 6357110L, "ELISA ALVEAR DE BOSCH", "INDEC", 0, 0 },
                    { 635711005160L, "CALLE", 1998, 1999, "ESPERANTO, Buenos Aires, General Pueyrredón", 6357110L, "ESPERANTO", "INDEC", 0, 0 },
                    { 635711005165L, "CALLE", 0, 0, "ESQUEL, Buenos Aires, General Pueyrredón", 6357110L, "ESQUEL", "INDEC", 0, 0 },
                    { 635711005170L, "CALLE", 8199, 8295, "ESQUIVEL E, Buenos Aires, General Pueyrredón", 6357110L, "ESQUIVEL E", "INDEC", 0, 0 },
                    { 635711005175L, "CALLE", 299, 0, "ESTADOS UNIDOS DE NORTEAMERICA DIAG, Buenos Aires, General Pueyrredón", 6357110L, "ESTADOS UNIDOS DE NORTEAMERICA DIAG", "INDEC", 0, 0 },
                    { 635711005180L, "CALLE", 0, 0, "ESTANCIA CABO CORRIENTES, Buenos Aires, General Pueyrredón", 6357110L, "ESTANCIA CABO CORRIENTES", "INDEC", 0, 0 },
                    { 635711005185L, "CALLE", 0, 0, "ESTANCIA CHAPADMALAL, Buenos Aires, General Pueyrredón", 6357110L, "ESTANCIA CHAPADMALAL", "INDEC", 0, 0 },
                    { 635711005190L, "CALLE", 0, 0, "ESTANCIA EL BOQUERON, Buenos Aires, General Pueyrredón", 6357110L, "ESTANCIA EL BOQUERON", "INDEC", 0, 0 },
                    { 635711005195L, "CALLE", 0, 0, "ESTANCIA ITUZAINGO, Buenos Aires, General Pueyrredón", 6357110L, "ESTANCIA ITUZAINGO", "INDEC", 0, 0 },
                    { 635711005200L, "CALLE", 0, 0, "ESTANCIA LAGUNA DE LOS PADRES, Buenos Aires, General Pueyrredón", 6357110L, "ESTANCIA LAGUNA DE LOS PADRES", "INDEC", 0, 0 },
                    { 635711005205L, "CALLE", 0, 0, "ESTANCIA SAN JULIAN DE VIVORATA, Buenos Aires, General Pueyrredón", 6357110L, "ESTANCIA SAN JULIAN DE VIVORATA", "INDEC", 0, 0 },
                    { 635711005210L, "CALLE", 0, 0, "ESTANCIA VIVORATA, Buenos Aires, General Pueyrredón", 6357110L, "ESTANCIA VIVORATA", "INDEC", 0, 0 },
                    { 635711005215L, "CALLE", 0, 0, "ESTRELLA DEL SUR, Buenos Aires, General Pueyrredón", 6357110L, "ESTRELLA DEL SUR", "INDEC", 0, 0 },
                    { 635711005220L, "CALLE", 2199, 2098, "EUSEBIONE L, Buenos Aires, General Pueyrredón", 6357110L, "EUSEBIONE L", "INDEC", 0, 0 },
                    { 635711005225L, "CALLE", 0, 0, "F CATUOGNO, Buenos Aires, General Pueyrredón", 6357110L, "F CATUOGNO", "INDEC", 0, 0 },
                    { 635711005230L, "CALLE", 898, 0, "F FERRER, Buenos Aires, General Pueyrredón", 6357110L, "F FERRER", "INDEC", 0, 0 },
                    { 635711005235L, "CALLE", 798, 799, "F J DE DIOS, Buenos Aires, General Pueyrredón", 6357110L, "F J DE DIOS", "INDEC", 300, 301 },
                    { 635711005240L, "CALLE", 4298, 4299, "F SANCHEZ, Buenos Aires, General Pueyrredón", 6357110L, "F SANCHEZ", "INDEC", 3600, 3741 },
                    { 635711005245L, "CALLE", 0, 0, "F SARTORA, Buenos Aires, General Pueyrredón", 6357110L, "F SARTORA", "INDEC", 0, 0 },
                    { 635711005250L, "CALLE", 10098, 9999, "FALKNER, Buenos Aires, General Pueyrredón", 6357110L, "FALKNER", "INDEC", 0, 0 },
                    { 635711005255L, "CALLE", 7798, 7799, "FALKNER TOMAS, Buenos Aires, General Pueyrredón", 6357110L, "FALKNER TOMAS", "INDEC", 0, 0 },
                    { 635711005260L, "CALLE", 199, 198, "FALUCHO, Buenos Aires, General Pueyrredón", 6357110L, "FALUCHO", "INDEC", 1, 2 },
                    { 635711005265L, "CALLE", 0, 0, "FERNANDO CATUOGNO, Buenos Aires, General Pueyrredón", 6357110L, "FERNANDO CATUOGNO", "INDEC", 0, 0 },
                    { 635711005270L, "CALLE", 0, 0, "FERRE PEDRO, Buenos Aires, General Pueyrredón", 6357110L, "FERRE PEDRO", "INDEC", 0, 0 },
                    { 635711005275L, "CALLE", 0, 0, "FERREYRA, Buenos Aires, General Pueyrredón", 6357110L, "FERREYRA", "INDEC", 0, 0 },
                    { 635711005280L, "CALLE", 0, 0, "FILIBERTO BIS, Buenos Aires, General Pueyrredón", 6357110L, "FILIBERTO BIS", "INDEC", 0, 0 },
                    { 635711005285L, "CALLE", 0, 1299, "FLORENCIO MARTINEZ DE HOZ, Buenos Aires, General Pueyrredón", 6357110L, "FLORENCIO MARTINEZ DE HOZ", "INDEC", 0, 0 },
                    { 635711005290L, "CALLE", 0, 0, "FLORENCIO PARRAVICINI, Buenos Aires, General Pueyrredón", 6357110L, "FLORENCIO PARRAVICINI", "INDEC", 0, 0 },
                    { 635711005295L, "CALLE", 3998, 3999, "FRAG HALCON, Buenos Aires, General Pueyrredón", 6357110L, "FRAG HALCON", "INDEC", 3800, 3801 },
                    { 635711005300L, "CALLE", 0, 0, "FRAG HERCULES, Buenos Aires, General Pueyrredón", 6357110L, "FRAG HERCULES", "INDEC", 0, 0 },
                    { 635711005305L, "CALLE", 3998, 3999, "FRAG LIBERTAD, Buenos Aires, General Pueyrredón", 6357110L, "FRAG LIBERTAD", "INDEC", 0, 0 },
                    { 635711005310L, "CALLE", 3998, 3999, "FRAG MALDONADO, Buenos Aires, General Pueyrredón", 6357110L, "FRAG MALDONADO", "INDEC", 3800, 3801 },
                    { 635711005315L, "CALLE", 3798, 3398, "FRAG SARMIENTO, Buenos Aires, General Pueyrredón", 6357110L, "FRAG SARMIENTO", "INDEC", 0, 0 },
                    { 635711005320L, "CALLE", 0, 0, "FRANCISCO CHACAHUAC, Buenos Aires, General Pueyrredón", 6357110L, "FRANCISCO CHACAHUAC", "INDEC", 0, 0 },
                    { 635711005325L, "CALLE", 0, 0, "FRENGUELLI, Buenos Aires, General Pueyrredón", 6357110L, "FRENGUELLI", "INDEC", 0, 0 },
                    { 635711005330L, "CALLE", 0, 0, "FRESNOS, Buenos Aires, General Pueyrredón", 6357110L, "FRESNOS", "INDEC", 0, 0 },
                    { 635711005335L, "CALLE", 0, 0, "G BURMEISTES, Buenos Aires, General Pueyrredón", 6357110L, "G BURMEISTES", "INDEC", 0, 0 },
                    { 635711005340L, "CALLE", 0, 4298, "G CHAVES, Buenos Aires, General Pueyrredón", 6357110L, "G CHAVES", "INDEC", 0, 0 },
                    { 635711005345L, "CALLE", 0, 0, "G VENTURA, Buenos Aires, General Pueyrredón", 6357110L, "G VENTURA", "INDEC", 0, 0 },
                    { 635711005350L, "CALLE", 0, 0, "G BURMEISTER, Buenos Aires, General Pueyrredón", 6357110L, "G BURMEISTER", "INDEC", 0, 0 },
                    { 635711005355L, "CALLE", 77899, 99999, "GABOTO, Buenos Aires, General Pueyrredón", 6357110L, "GABOTO", "INDEC", 0, 0 },
                    { 635711005360L, "CALLE", 0, 0, "GABOTO BIS, Buenos Aires, General Pueyrredón", 6357110L, "GABOTO BIS", "INDEC", 0, 0 },
                    { 635711005365L, "CALLE", 0, 0, "GALLARDO, Buenos Aires, General Pueyrredón", 6357110L, "GALLARDO", "INDEC", 0, 0 },
                    { 635711005370L, "CALLE", 0, 0, "GALLO, Buenos Aires, General Pueyrredón", 6357110L, "GALLO", "INDEC", 0, 0 },
                    { 635711005375L, "CALLE", 3398, 3399, "GAMAL ABDEL NASSER, Buenos Aires, General Pueyrredón", 6357110L, "GAMAL ABDEL NASSER", "INDEC", 0, 0 },
                    { 635711005380L, "CALLE", 0, 0, "GANDARA, Buenos Aires, General Pueyrredón", 6357110L, "GANDARA", "INDEC", 0, 0 },
                    { 635711005385L, "CALLE", 5099, 4988, "GANDHI, Buenos Aires, General Pueyrredón", 6357110L, "GANDHI", "INDEC", 0, 0 },
                    { 635711005390L, "CALLE", 0, 0, "GARCIA LORCA BIS, Buenos Aires, General Pueyrredón", 6357110L, "GARCIA LORCA BIS", "INDEC", 0, 0 },
                    { 635711005395L, "CALLE", 3199, 3198, "GASCON DIAG, Buenos Aires, General Pueyrredón", 6357110L, "GASCON DIAG", "INDEC", 0, 0 },
                    { 635711005400L, "CALLE", 1998, 1999, "GAUDINI, Buenos Aires, General Pueyrredón", 6357110L, "GAUDINI", "INDEC", 1300, 1301 },
                    { 635711005405L, "CALLE", 0, 0, "GENOVA BIS, Buenos Aires, General Pueyrredón", 6357110L, "GENOVA BIS", "INDEC", 0, 0 },
                    { 635711005410L, "CALLE", 0, 0, "GERANIOS, Buenos Aires, General Pueyrredón", 6357110L, "GERANIOS", "INDEC", 0, 0 },
                    { 635711005415L, "CALLE", 0, 0, "GERMAN ABDALA, Buenos Aires, General Pueyrredón", 6357110L, "GERMAN ABDALA", "INDEC", 0, 0 },
                    { 635711005420L, "CALLE", 0, 0, "GOLETA SARANDI, Buenos Aires, General Pueyrredón", 6357110L, "GOLETA SARANDI", "INDEC", 0, 0 },
                    { 635711005425L, "CALLE", 0, 0, "GOLONDRINA, Buenos Aires, General Pueyrredón", 6357110L, "GOLONDRINA", "INDEC", 0, 0 },
                    { 635711005430L, "CALLE", 0, 0, "GONZALES CHAVEZ BIS, Buenos Aires, General Pueyrredón", 6357110L, "GONZALES CHAVEZ BIS", "INDEC", 0, 0 },
                    { 635711005435L, "CALLE", 5798, 5799, "GONZALEZ E DIAG, Buenos Aires, General Pueyrredón", 6357110L, "GONZALEZ E DIAG", "INDEC", 4700, 0 },
                    { 635711005440L, "CALLE", 0, 0, "GONI JUAN BIS, Buenos Aires, General Pueyrredón", 6357110L, "GONI JUAN BIS", "INDEC", 0, 0 },
                    { 635711005445L, "CALLE", 0, 0, "GRANJA MARUCHA, Buenos Aires, General Pueyrredón", 6357110L, "GRANJA MARUCHA", "INDEC", 0, 0 },
                    { 635711005450L, "CALLE", 0, 0, "GRL BELGRANO, Buenos Aires, General Pueyrredón", 6357110L, "GRL BELGRANO", "INDEC", 0, 0 },
                    { 635711005455L, "CALLE", 6699, 0, "GROEBER, Buenos Aires, General Pueyrredón", 6357110L, "GROEBER", "INDEC", 0, 0 },
                    { 635711005460L, "CALLE", 65969, 96898, "GUANAHANI, Buenos Aires, General Pueyrredón", 6357110L, "GUANAHANI", "INDEC", 0, 0 },
                    { 635711005465L, "CALLE", 5699, 1098, "GUERNICA, Buenos Aires, General Pueyrredón", 6357110L, "GUERNICA", "INDEC", 0, 0 },
                    { 635711005470L, "CALLE", 998, 999, "GUERRA, Buenos Aires, General Pueyrredón", 6357110L, "GUERRA", "INDEC", 0, 701 },
                    { 635711005475L, "CALLE", 0, 0, "GUERRICO A, Buenos Aires, General Pueyrredón", 6357110L, "GUERRICO A", "INDEC", 0, 0 },
                    { 635711005480L, "CALLE", 998, 999, "GUGLIEMO, Buenos Aires, General Pueyrredón", 6357110L, "GUGLIEMO", "INDEC", 0, 0 },
                    { 635711005485L, "CALLE", 0, 0, "GUIRALDES BIS, Buenos Aires, General Pueyrredón", 6357110L, "GUIRALDES BIS", "INDEC", 0, 0 },
                    { 635711005490L, "CALLE", 0, 0, "GURRIERI, Buenos Aires, General Pueyrredón", 6357110L, "GURRIERI", "INDEC", 0, 0 },
                    { 635711005495L, "CALLE", 6998, 6999, "GUTEMBERG BIS, Buenos Aires, General Pueyrredón", 6357110L, "GUTEMBERG BIS", "INDEC", 0, 0 },
                    { 635711005500L, "CALLE", 998, 999, "GUTIERREZ RICARDO, Buenos Aires, General Pueyrredón", 6357110L, "GUTIERREZ RICARDO", "INDEC", 0, 0 },
                    { 635711005505L, "CALLE", 0, 0, "H ENGLENDER, Buenos Aires, General Pueyrredón", 6357110L, "H ENGLENDER", "INDEC", 0, 0 },
                    { 635711005510L, "CALLE", 0, 0, "H MANZI, Buenos Aires, General Pueyrredón", 6357110L, "H MANZI", "INDEC", 0, 0 },
                    { 635711005515L, "CALLE", 0, 0, "HAENCKE TADEO, Buenos Aires, General Pueyrredón", 6357110L, "HAENCKE TADEO", "INDEC", 0, 0 },
                    { 635711005520L, "CALLE", 0, 0, "HARAS ABOLENGO, Buenos Aires, General Pueyrredón", 6357110L, "HARAS ABOLENGO", "INDEC", 0, 0 },
                    { 635711005525L, "CALLE", 0, 0, "HARAS COMAZAL, Buenos Aires, General Pueyrredón", 6357110L, "HARAS COMAZAL", "INDEC", 0, 0 },
                    { 635711005530L, "CALLE", 398, 599, "HARAS EL ALEAR, Buenos Aires, General Pueyrredón", 6357110L, "HARAS EL ALEAR", "INDEC", 0, 0 },
                    { 635711005535L, "CALLE", 398, 399, "HARAS EL CANDIL, Buenos Aires, General Pueyrredón", 6357110L, "HARAS EL CANDIL", "INDEC", 0, 0 },
                    { 635711005540L, "CALLE", 0, 0, "HARAS EL TURF, Buenos Aires, General Pueyrredón", 6357110L, "HARAS EL TURF", "INDEC", 0, 0 },
                    { 635711005545L, "CALLE", 0, 0, "HARAS FIRMAMENTO, Buenos Aires, General Pueyrredón", 6357110L, "HARAS FIRMAMENTO", "INDEC", 0, 0 },
                    { 635711005550L, "CALLE", 0, 0, "HARAS HORIZONTE, Buenos Aires, General Pueyrredón", 6357110L, "HARAS HORIZONTE", "INDEC", 0, 0 },
                    { 635711005555L, "CALLE", 0, 0, "HARAS LA BIZNAGA, Buenos Aires, General Pueyrredón", 6357110L, "HARAS LA BIZNAGA", "INDEC", 0, 0 },
                    { 635711005560L, "CALLE", 0, 0, "HARAS LA MADRUGADA, Buenos Aires, General Pueyrredón", 6357110L, "HARAS LA MADRUGADA", "INDEC", 0, 0 },
                    { 635711005565L, "CALLE", 0, 0, "HARAS LAS ORTIGAS, Buenos Aires, General Pueyrredón", 6357110L, "HARAS LAS ORTIGAS", "INDEC", 0, 0 },
                    { 635711005570L, "CALLE", 0, 0, "HARAS MALAHUE, Buenos Aires, General Pueyrredón", 6357110L, "HARAS MALAHUE", "INDEC", 0, 0 },
                    { 635711005575L, "CALLE", 0, 0, "HARAS V CACION, Buenos Aires, General Pueyrredón", 6357110L, "HARAS V CACION", "INDEC", 0, 0 },
                    { 635711005580L, "CALLE", 598, 599, "HARAS VENCENIL, Buenos Aires, General Pueyrredón", 6357110L, "HARAS VENCENIL", "INDEC", 0, 1 },
                    { 635711005585L, "CALLE", 0, 0, "HECTOR RAMON BORDON, Buenos Aires, General Pueyrredón", 6357110L, "HECTOR RAMON BORDON", "INDEC", 0, 0 },
                    { 635711005590L, "CALLE", 0, 0, "HEGUILOR DOMINGO BIS, Buenos Aires, General Pueyrredón", 6357110L, "HEGUILOR DOMINGO BIS", "INDEC", 0, 0 },
                    { 635711005595L, "CALLE", 0, 0, "HELECHOS, Buenos Aires, General Pueyrredón", 6357110L, "HELECHOS", "INDEC", 0, 0 },
                    { 635711005600L, "CALLE", 0, 0, "HERMANOS ALDACOCHE, Buenos Aires, General Pueyrredón", 6357110L, "HERMANOS ALDACOCHE", "INDEC", 0, 0 },
                    { 635711005605L, "CALLE", 0, 0, "HERMIDA, Buenos Aires, General Pueyrredón", 6357110L, "HERMIDA", "INDEC", 0, 0 },
                    { 635711005610L, "CALLE", 9499, 65998, "HERNANDARIAS, Buenos Aires, General Pueyrredón", 6357110L, "HERNANDARIAS", "INDEC", 0, 0 },
                    { 635711005615L, "CALLE", 0, 0, "HERRERIA, Buenos Aires, General Pueyrredón", 6357110L, "HERRERIA", "INDEC", 0, 0 },
                    { 635711005620L, "CALLE", 0, 0, "HOLMBERG, Buenos Aires, General Pueyrredón", 6357110L, "HOLMBERG", "INDEC", 0, 0 },
                    { 635711005625L, "CALLE", 398, 399, "HORNERO, Buenos Aires, General Pueyrredón", 6357110L, "HORNERO", "INDEC", 0, 1 },
                    { 635711005630L, "CALLE", 4598, 4599, "HUDSON GUILLERMO, Buenos Aires, General Pueyrredón", 6357110L, "HUDSON GUILLERMO", "INDEC", 400, 4201 },
                    { 635711005635L, "CALLE", 0, 0, "HUILEN, Buenos Aires, General Pueyrredón", 6357110L, "HUILEN", "INDEC", 0, 0 },
                    { 635711005640L, "CALLE", 0, 0, "HUSSAY, Buenos Aires, General Pueyrredón", 6357110L, "HUSSAY", "INDEC", 0, 0 },
                    { 635711005645L, "CALLE", 6699, 6698, "I OLAN, Buenos Aires, General Pueyrredón", 6357110L, "I OLAN", "INDEC", 0, 0 },
                    { 635711005650L, "CALLE", 0, 0, "INDA RUFINO BIS, Buenos Aires, General Pueyrredón", 6357110L, "INDA RUFINO BIS", "INDEC", 0, 0 },
                    { 635711005655L, "CALLE", 5199, 5198, "ING OTTO KRAUSE, Buenos Aires, General Pueyrredón", 6357110L, "ING OTTO KRAUSE", "INDEC", 5001, 0 },
                    { 635711005660L, "CALLE", 4798, 6999, "ING RATERIY, Buenos Aires, General Pueyrredón", 6357110L, "ING RATERIY", "INDEC", 0, 0 },
                    { 635711005665L, "CALLE", 3598, 3799, "INGENIEROS JOSE, Buenos Aires, General Pueyrredón", 6357110L, "INGENIEROS JOSE", "INDEC", 0, 0 },
                    { 635711005670L, "CALLE", 0, 0, "INT JOSE A CAVALLO, Buenos Aires, General Pueyrredón", 6357110L, "INT JOSE A CAVALLO", "INDEC", 0, 0 },
                    { 635711005675L, "CALLE", 38799, 11198, "IRALA, Buenos Aires, General Pueyrredón", 6357110L, "IRALA", "INDEC", 0, 0 },
                    { 635711005680L, "CALLE", 0, 0, "ISLA BLANCO, Buenos Aires, General Pueyrredón", 6357110L, "ISLA BLANCO", "INDEC", 0, 0 },
                    { 635711005685L, "CALLE", 0, 0, "ISLA BORGON, Buenos Aires, General Pueyrredón", 6357110L, "ISLA BORGON", "INDEC", 0, 0 },
                    { 635711005690L, "CALLE", 0, 0, "ISLA CORONACION, Buenos Aires, General Pueyrredón", 6357110L, "ISLA CORONACION", "INDEC", 0, 0 },
                    { 635711005695L, "CALLE", 3099, 660, "ISLA DE CERDENA - CALLE 69, Buenos Aires, General Pueyrredón", 6357110L, "ISLA DE CERDENA - CALLE 69", "INDEC", 0, 0 },
                    { 635711005700L, "CALLE", 0, 0, "ISLA DE LOS ESTADOS, Buenos Aires, General Pueyrredón", 6357110L, "ISLA DE LOS ESTADOS", "INDEC", 0, 0 },
                    { 635711005705L, "CALLE", 0, 0, "ISLA ELEFANTE, Buenos Aires, General Pueyrredón", 6357110L, "ISLA ELEFANTE", "INDEC", 0, 0 },
                    { 635711005710L, "CALLE", 0, 0, "ISLA JOINVILLE, Buenos Aires, General Pueyrredón", 6357110L, "ISLA JOINVILLE", "INDEC", 0, 0 },
                    { 635711005715L, "CALLE", 0, 0, "ISLA LAURIE, Buenos Aires, General Pueyrredón", 6357110L, "ISLA LAURIE", "INDEC", 0, 0 },
                    { 635711005720L, "CALLE", 0, 0, "ISLA PAJAROS, Buenos Aires, General Pueyrredón", 6357110L, "ISLA PAJAROS", "INDEC", 0, 0 },
                    { 635711005725L, "CALLE", 0, 0, "ISLA REMOLINOS, Buenos Aires, General Pueyrredón", 6357110L, "ISLA REMOLINOS", "INDEC", 0, 0 },
                    { 635711005730L, "CALLE", 0, 0, "ISLA SEBALDES, Buenos Aires, General Pueyrredón", 6357110L, "ISLA SEBALDES", "INDEC", 0, 0 },
                    { 635711005735L, "CALLE", 0, 0, "ISLA TRAVERSE, Buenos Aires, General Pueyrredón", 6357110L, "ISLA TRAVERSE", "INDEC", 0, 0 },
                    { 635711005740L, "CALLE", 0, 0, "ISLA TRINIDAD, Buenos Aires, General Pueyrredón", 6357110L, "ISLA TRINIDAD", "INDEC", 0, 0 },
                    { 635711005745L, "CALLE", 0, 0, "ISLA TULES DEL SUR, Buenos Aires, General Pueyrredón", 6357110L, "ISLA TULES DEL SUR", "INDEC", 0, 0 },
                    { 635711005750L, "CALLE", 0, 0, "ISLA VIGIA, Buenos Aires, General Pueyrredón", 6357110L, "ISLA VIGIA", "INDEC", 0, 0 },
                    { 635711005755L, "CALLE", 4798, 0, "ISLAS BALEARES, Buenos Aires, General Pueyrredón", 6357110L, "ISLAS BALEARES", "INDEC", 0, 0 },
                    { 635711005760L, "CALLE", 0, 0, "ISLAS DE LOS ESTADOS SUR, Buenos Aires, General Pueyrredón", 6357110L, "ISLAS DE LOS ESTADOS SUR", "INDEC", 0, 0 },
                    { 635711005765L, "CALLE", 0, 0, "ITUZAINGO, Buenos Aires, General Pueyrredón", 6357110L, "ITUZAINGO", "INDEC", 0, 0 },
                    { 635711005770L, "CALLE", 0, 0, "J DE LA LLOSA, Buenos Aires, General Pueyrredón", 6357110L, "J DE LA LLOSA", "INDEC", 0, 0 },
                    { 635711005775L, "CALLE", 0, 0, "J HERNANDEZ, Buenos Aires, General Pueyrredón", 6357110L, "J HERNANDEZ", "INDEC", 0, 0 },
                    { 635711005780L, "CALLE", 4599, 4199, "J J PASO, Buenos Aires, General Pueyrredón", 6357110L, "J J PASO", "INDEC", 0, 0 },
                    { 635711005785L, "CALLE", 0, 0, "J M MICHEL, Buenos Aires, General Pueyrredón", 6357110L, "J M MICHEL", "INDEC", 0, 0 },
                    { 635711005790L, "CALLE", 4299, 4298, "J MANZO, Buenos Aires, General Pueyrredón", 6357110L, "J MANZO", "INDEC", 0, 0 },
                    { 635711005795L, "CALLE", 4299, 4298, "J P RAMOS, Buenos Aires, General Pueyrredón", 6357110L, "J P RAMOS", "INDEC", 3601, 3740 },
                    { 635711005800L, "CALLE", 3499, 3498, "J PUJIA, Buenos Aires, General Pueyrredón", 6357110L, "J PUJIA", "INDEC", 0, 0 },
                    { 635711005805L, "CALLE", 0, 0, "JACINTO PERALTA RAMOS BIS, Buenos Aires, General Pueyrredón", 6357110L, "JACINTO PERALTA RAMOS BIS", "INDEC", 0, 0 },
                    { 635711005810L, "CALLE", 0, 0, "JAZMINES, Buenos Aires, General Pueyrredón", 6357110L, "JAZMINES", "INDEC", 0, 0 },
                    { 635711005815L, "CALLE", 1798, 0, "JOSE COEHLO DE MEYRELLES, Buenos Aires, General Pueyrredón", 6357110L, "JOSE COEHLO DE MEYRELLES", "INDEC", 0, 0 },
                    { 635711005820L, "CALLE", 0, 0, "JOSE DANTE FABUR, Buenos Aires, General Pueyrredón", 6357110L, "JOSE DANTE FABUR", "INDEC", 0, 0 },
                    { 635711005825L, "CALLE", 0, 0, "JOSE DEYACCOBI, Buenos Aires, General Pueyrredón", 6357110L, "JOSE DEYACCOBI", "INDEC", 0, 0 },
                    { 635711005830L, "CALLE", 0, 0, "JOSE DOCNOYAHAL17, Buenos Aires, General Pueyrredón", 6357110L, "JOSE DOCNOYAHAL17", "INDEC", 0, 0 },
                    { 635711005835L, "CALLE", 0, 0, "JOSE F BOTANA, Buenos Aires, General Pueyrredón", 6357110L, "JOSE F BOTANA", "INDEC", 0, 0 },
                    { 635711005840L, "CALLE", 0, 0, "JOSE HERNANDEZ, Buenos Aires, General Pueyrredón", 6357110L, "JOSE HERNANDEZ", "INDEC", 0, 0 },
                    { 635711005845L, "CALLE", 0, 0, "JOSE L RODRIGUEZ, Buenos Aires, General Pueyrredón", 6357110L, "JOSE L RODRIGUEZ", "INDEC", 0, 0 },
                    { 635711005850L, "CALLE", 0, 0, "JOSE RAZZANO, Buenos Aires, General Pueyrredón", 6357110L, "JOSE RAZZANO", "INDEC", 0, 0 },
                    { 635711005855L, "CALLE", 0, 0, "JUAN B JUSTO, Buenos Aires, General Pueyrredón", 6357110L, "JUAN B JUSTO", "INDEC", 0, 0 },
                    { 635711005860L, "CALLE", 0, 0, "JUAN C CASTAGNINO, Buenos Aires, General Pueyrredón", 6357110L, "JUAN C CASTAGNINO", "INDEC", 0, 0 },
                    { 635711005865L, "CALLE", 0, 0, "JUAN CUTAY, Buenos Aires, General Pueyrredón", 6357110L, "JUAN CUTAY", "INDEC", 0, 0 },
                    { 635711005870L, "CALLE", 0, 0, "JUAN D PERON CALLE 35, Buenos Aires, General Pueyrredón", 6357110L, "JUAN D PERON CALLE 35", "INDEC", 0, 0 },
                    { 635711005875L, "CALLE", 0, 0, "JUAN D`ARIENZO, Buenos Aires, General Pueyrredón", 6357110L, "JUAN D`ARIENZO", "INDEC", 0, 0 },
                    { 635711005880L, "CALLE", 0, 0, "JUAN DE DIOS FILIBERTO, Buenos Aires, General Pueyrredón", 6357110L, "JUAN DE DIOS FILIBERTO", "INDEC", 0, 0 },
                    { 635711005885L, "CALLE", 699, 698, "JUAN JOSE VALLE, Buenos Aires, General Pueyrredón", 6357110L, "JUAN JOSE VALLE", "INDEC", 0, 0 },
                    { 635711005890L, "CALLE", 10000, 9499, "JUAN MORO, Buenos Aires, General Pueyrredón", 6357110L, "JUAN MORO", "INDEC", 8902, 8001 },
                    { 635711005895L, "CALLE", 0, 0, "JUAN YAHAM, Buenos Aires, General Pueyrredón", 6357110L, "JUAN YAHAM", "INDEC", 0, 0 },
                    { 635711005900L, "CALLE", 0, 0, "JUANA AZURDUY BIS, Buenos Aires, General Pueyrredón", 6357110L, "JUANA AZURDUY BIS", "INDEC", 0, 0 },
                    { 635711005905L, "CALLE", 2598, 2599, "JUAREZ BENITO, Buenos Aires, General Pueyrredón", 6357110L, "JUAREZ BENITO", "INDEC", 0, 1 },
                    { 635711005910L, "CALLE", 0, 0, "JULIO CANESSA, Buenos Aires, General Pueyrredón", 6357110L, "JULIO CANESSA", "INDEC", 0, 0 },
                    { 635711005915L, "CALLE", 0, 0, "JULIO DE CARO, Buenos Aires, General Pueyrredón", 6357110L, "JULIO DE CARO", "INDEC", 0, 0 },
                    { 635711005920L, "CALLE", 5799, 5798, "KENNEDY, Buenos Aires, General Pueyrredón", 6357110L, "KENNEDY", "INDEC", 5701, 5700 },
                    { 635711005925L, "CALLE", 0, 0, "KRAGLIEVICH, Buenos Aires, General Pueyrredón", 6357110L, "KRAGLIEVICH", "INDEC", 0, 0 },
                    { 635711005930L, "CALLE", 0, 0, "L FRAGNAUD, Buenos Aires, General Pueyrredón", 6357110L, "L FRAGNAUD", "INDEC", 0, 0 },
                    { 635711005935L, "CALLE", 0, 0, "L SCAGLIA, Buenos Aires, General Pueyrredón", 6357110L, "L SCAGLIA", "INDEC", 0, 0 },
                    { 635711005940L, "CALLE", 0, 0, "LA ALONDRA, Buenos Aires, General Pueyrredón", 6357110L, "LA ALONDRA", "INDEC", 0, 0 },
                    { 635711005945L, "CALLE", 0, 0, "LA ARMONIA, Buenos Aires, General Pueyrredón", 6357110L, "LA ARMONIA", "INDEC", 0, 0 },
                    { 635711005950L, "CALLE", 0, 0, "LA AURORA, Buenos Aires, General Pueyrredón", 6357110L, "LA AURORA", "INDEC", 0, 0 },
                    { 635711005955L, "CALLE", 0, 0, "LA CACHIRA, Buenos Aires, General Pueyrredón", 6357110L, "LA CACHIRA", "INDEC", 0, 0 },
                    { 635711005960L, "CALLE", 0, 0, "LA CALANDRIA, Buenos Aires, General Pueyrredón", 6357110L, "LA CALANDRIA", "INDEC", 0, 0 },
                    { 635711005965L, "CALLE", 0, 0, "LA CIGUENA, Buenos Aires, General Pueyrredón", 6357110L, "LA CIGUENA", "INDEC", 0, 0 },
                    { 635711005970L, "CALLE", 0, 0, "LA COLMENA, Buenos Aires, General Pueyrredón", 6357110L, "LA COLMENA", "INDEC", 0, 0 },
                    { 635711005975L, "CALLE", 0, 0, "LA COPELINA, Buenos Aires, General Pueyrredón", 6357110L, "LA COPELINA", "INDEC", 0, 0 },
                    { 635711005980L, "CALLE", 0, 0, "LA CORONA, Buenos Aires, General Pueyrredón", 6357110L, "LA CORONA", "INDEC", 0, 0 },
                    { 635711005985L, "CALLE", 0, 0, "LA GAVIOTA, Buenos Aires, General Pueyrredón", 6357110L, "LA GAVIOTA", "INDEC", 0, 0 },
                    { 635711005990L, "CALLE", 398, 399, "LA GOLONDRINA, Buenos Aires, General Pueyrredón", 6357110L, "LA GOLONDRINA", "INDEC", 0, 0 },
                    { 635711005995L, "CALLE", 0, 0, "LA JOYA, Buenos Aires, General Pueyrredón", 6357110L, "LA JOYA", "INDEC", 0, 0 },
                    { 635711006000L, "CALLE", 0, 0, "LA LAURA, Buenos Aires, General Pueyrredón", 6357110L, "LA LAURA", "INDEC", 0, 0 },
                    { 635711006005L, "CALLE", 0, 0, "LA MARTINETA, Buenos Aires, General Pueyrredón", 6357110L, "LA MARTINETA", "INDEC", 0, 0 },
                    { 635711006010L, "CALLE", 3998, 3999, "LA NINA, Buenos Aires, General Pueyrredón", 6357110L, "LA NINA", "INDEC", 3600, 3601 },
                    { 635711006015L, "CALLE", 3998, 3999, "LA PAMPA, Buenos Aires, General Pueyrredón", 6357110L, "LA PAMPA", "INDEC", 3800, 3801 },
                    { 635711006020L, "CALLE", 0, 0, "LA PASIONARIA, Buenos Aires, General Pueyrredón", 6357110L, "LA PASIONARIA", "INDEC", 0, 0 },
                    { 635711006025L, "CALLE", 0, 0, "LA PERDIZ, Buenos Aires, General Pueyrredón", 6357110L, "LA PERDIZ", "INDEC", 0, 0 },
                    { 635711006030L, "CALLE", 0, 0, "LA PEREGRINA, Buenos Aires, General Pueyrredón", 6357110L, "LA PEREGRINA", "INDEC", 0, 0 },
                    { 635711006035L, "CALLE", 3798, 3799, "LA PINTA, Buenos Aires, General Pueyrredón", 6357110L, "LA PINTA", "INDEC", 3600, 3601 },
                    { 635711006040L, "CALLE", 5498, 0, "LA PRIMAVERA, Buenos Aires, General Pueyrredón", 6357110L, "LA PRIMAVERA", "INDEC", 0, 0 },
                    { 635711006045L, "CALLE", 298, 299, "LA RATONERA, Buenos Aires, General Pueyrredón", 6357110L, "LA RATONERA", "INDEC", 0, 0 },
                    { 635711006050L, "CALLE", 0, 0, "LA REFORMA, Buenos Aires, General Pueyrredón", 6357110L, "LA REFORMA", "INDEC", 0, 0 },
                    { 635711006055L, "CALLE", 3798, 3799, "LA SANTA MARIA, Buenos Aires, General Pueyrredón", 6357110L, "LA SANTA MARIA", "INDEC", 3600, 0 },
                    { 635711006060L, "CALLE", 0, 0, "LA SERENA, Buenos Aires, General Pueyrredón", 6357110L, "LA SERENA", "INDEC", 0, 0 },
                    { 635711006065L, "CALLE", 0, 0, "LA TIJERETA, Buenos Aires, General Pueyrredón", 6357110L, "LA TIJERETA", "INDEC", 0, 0 },
                    { 635711006070L, "CALLE", 399, 398, "LA TORCACITA, Buenos Aires, General Pueyrredón", 6357110L, "LA TORCACITA", "INDEC", 1, 100 },
                    { 635711006075L, "CALLE", 0, 0, "LA TORCAZA, Buenos Aires, General Pueyrredón", 6357110L, "LA TORCAZA", "INDEC", 0, 0 },
                    { 635711006080L, "CALLE", 0, 0, "LABARDEN, Buenos Aires, General Pueyrredón", 6357110L, "LABARDEN", "INDEC", 0, 0 },
                    { 635711006085L, "CALLE", 6698, 0, "LABRADOR, Buenos Aires, General Pueyrredón", 6357110L, "LABRADOR", "INDEC", 0, 0 },
                    { 635711006090L, "CALLE", 0, 0, "LAHILLE, Buenos Aires, General Pueyrredón", 6357110L, "LAHILLE", "INDEC", 0, 0 },
                    { 635711006095L, "CALLE", 0, 0, "LAMAS, Buenos Aires, General Pueyrredón", 6357110L, "LAMAS", "INDEC", 0, 0 },
                    { 635711006100L, "CALLE", 0, 399, "LAMBARDIA, Buenos Aires, General Pueyrredón", 6357110L, "LAMBARDIA", "INDEC", 0, 0 },
                    { 635711006105L, "CALLE", 0, 0, "LAMBERSIANAS, Buenos Aires, General Pueyrredón", 6357110L, "LAMBERSIANAS", "INDEC", 0, 0 },
                    { 635711006110L, "CALLE", 0, 0, "LAPRIDA, Buenos Aires, General Pueyrredón", 6357110L, "LAPRIDA", "INDEC", 0, 0 },
                    { 635711006115L, "CALLE", 0, 0, "LAS ACACIAS, Buenos Aires, General Pueyrredón", 6357110L, "LAS ACACIAS", "INDEC", 0, 0 },
                    { 635711006120L, "CALLE", 0, 0, "LAS ARAUCARIAS, Buenos Aires, General Pueyrredón", 6357110L, "LAS ARAUCARIAS", "INDEC", 0, 0 },
                    { 635711006125L, "CALLE", 1399, 1398, "LAS AZUCENAS, Buenos Aires, General Pueyrredón", 6357110L, "LAS AZUCENAS", "INDEC", 1101, 1100 },
                    { 635711006130L, "CALLE", 3299, 0, "LAS CABRILLAS, Buenos Aires, General Pueyrredón", 6357110L, "LAS CABRILLAS", "INDEC", 0, 0 },
                    { 635711006135L, "CALLE", 0, 0, "LAS CALAS, Buenos Aires, General Pueyrredón", 6357110L, "LAS CALAS", "INDEC", 0, 0 },
                    { 635711006140L, "CALLE", 1299, 1298, "LAS CAMELIAS, Buenos Aires, General Pueyrredón", 6357110L, "LAS CAMELIAS", "INDEC", 1101, 1100 },
                    { 635711006145L, "CALLE", 8398, 8399, "LAS CASUARINAS, Buenos Aires, General Pueyrredón", 6357110L, "LAS CASUARINAS", "INDEC", 830, 8301 },
                    { 635711006150L, "CALLE", 0, 0, "LAS CEREZAS, Buenos Aires, General Pueyrredón", 6357110L, "LAS CEREZAS", "INDEC", 0, 0 },
                    { 635711006155L, "CALLE", 0, 0, "LAS CHINCHAS, Buenos Aires, General Pueyrredón", 6357110L, "LAS CHINCHAS", "INDEC", 0, 0 },
                    { 635711006160L, "CALLE", 0, 0, "LAS CORONAS, Buenos Aires, General Pueyrredón", 6357110L, "LAS CORONAS", "INDEC", 0, 0 },
                    { 635711006165L, "CALLE", 0, 0, "LAS DALIAS, Buenos Aires, General Pueyrredón", 6357110L, "LAS DALIAS", "INDEC", 0, 0 },
                    { 635711006170L, "CALLE", 0, 0, "LAS ENCIMAS, Buenos Aires, General Pueyrredón", 6357110L, "LAS ENCIMAS", "INDEC", 0, 0 },
                    { 635711006175L, "CALLE", 0, 0, "LAS ENCIMERAS, Buenos Aires, General Pueyrredón", 6357110L, "LAS ENCIMERAS", "INDEC", 0, 0 },
                    { 635711006180L, "CALLE", 0, 0, "LAS FAJAS, Buenos Aires, General Pueyrredón", 6357110L, "LAS FAJAS", "INDEC", 0, 0 },
                    { 635711006185L, "CALLE", 0, 0, "LAS FRESIAS, Buenos Aires, General Pueyrredón", 6357110L, "LAS FRESIAS", "INDEC", 0, 0 },
                    { 635711006190L, "CALLE", 1299, 1298, "LAS GARDENIAS, Buenos Aires, General Pueyrredón", 6357110L, "LAS GARDENIAS", "INDEC", 1101, 1100 },
                    { 635711006195L, "CALLE", 0, 0, "LAS HIGUERAS, Buenos Aires, General Pueyrredón", 6357110L, "LAS HIGUERAS", "INDEC", 0, 0 },
                    { 635711006200L, "CALLE", 0, 0, "LAS HORTENSIAS, Buenos Aires, General Pueyrredón", 6357110L, "LAS HORTENSIAS", "INDEC", 0, 0 },
                    { 635711006205L, "CALLE", 0, 0, "LAS LAMBERICANAS, Buenos Aires, General Pueyrredón", 6357110L, "LAS LAMBERICANAS", "INDEC", 0, 0 },
                    { 635711006210L, "CALLE", 0, 0, "LAS MAGNOLIAS, Buenos Aires, General Pueyrredón", 6357110L, "LAS MAGNOLIAS", "INDEC", 0, 0 },
                    { 635711006215L, "CALLE", 0, 0, "LAS MARAVILLAS, Buenos Aires, General Pueyrredón", 6357110L, "LAS MARAVILLAS", "INDEC", 0, 0 },
                    { 635711006220L, "CALLE", 0, 3698, "LAS MARGARITAS, Buenos Aires, General Pueyrredón", 6357110L, "LAS MARGARITAS", "INDEC", 0, 0 },
                    { 635711006225L, "CALLE", 0, 0, "LAS MORERAS, Buenos Aires, General Pueyrredón", 6357110L, "LAS MORERAS", "INDEC", 0, 0 },
                    { 635711006230L, "CALLE", 0, 0, "LAS PALMERAS, Buenos Aires, General Pueyrredón", 6357110L, "LAS PALMERAS", "INDEC", 0, 0 },
                    { 635711006235L, "CALLE", 0, 0, "LAS PECHERAS, Buenos Aires, General Pueyrredón", 6357110L, "LAS PECHERAS", "INDEC", 0, 0 },
                    { 635711006240L, "CALLE", 1299, 1298, "LAS ROSAS, Buenos Aires, General Pueyrredón", 6357110L, "LAS ROSAS", "INDEC", 0, 0 },
                    { 635711006245L, "CALLE", 0, 0, "LAS TABAS, Buenos Aires, General Pueyrredón", 6357110L, "LAS TABAS", "INDEC", 0, 0 },
                    { 635711006250L, "CALLE", 0, 0, "LAS TRES MARIAS, Buenos Aires, General Pueyrredón", 6357110L, "LAS TRES MARIAS", "INDEC", 0, 0 },
                    { 635711006255L, "CALLE", 0, 0, "LAS TUYAS, Buenos Aires, General Pueyrredón", 6357110L, "LAS TUYAS", "INDEC", 0, 0 },
                    { 635711006260L, "CALLE", 0, 0, "LAS VIOLETAS, Buenos Aires, General Pueyrredón", 6357110L, "LAS VIOLETAS", "INDEC", 0, 0 },
                    { 635711006265L, "CALLE", 6699, 6898, "LATANTU, Buenos Aires, General Pueyrredón", 6357110L, "LATANTU", "INDEC", 6201, 6200 },
                    { 635711006270L, "CALLE", 0, 0, "LEGH II, Buenos Aires, General Pueyrredón", 6357110L, "LEGH II", "INDEC", 0, 0 },
                    { 635711006275L, "CALLE", 0, 0, "LILLO M, Buenos Aires, General Pueyrredón", 6357110L, "LILLO M", "INDEC", 0, 0 },
                    { 635711006280L, "CALLE", 0, 0, "LINCOLN, Buenos Aires, General Pueyrredón", 6357110L, "LINCOLN", "INDEC", 0, 0 },
                    { 635711006285L, "CALLE", 599, 598, "LINIERS, Buenos Aires, General Pueyrredón", 6357110L, "LINIERS", "INDEC", 1, 0 },
                    { 635711006290L, "CALLE", 0, 0, "LIRIOS, Buenos Aires, General Pueyrredón", 6357110L, "LIRIOS", "INDEC", 0, 0 },
                    { 635711006295L, "CALLE", 1099, 1098, "LITUANIA, Buenos Aires, General Pueyrredón", 6357110L, "LITUANIA", "INDEC", 0, 0 },
                    { 635711006300L, "CALLE", 0, 0, "LOBERIA, Buenos Aires, General Pueyrredón", 6357110L, "LOBERIA", "INDEC", 0, 0 },
                    { 635711006305L, "CALLE", 3399, 3298, "LORENZO CIANCHETTA, Buenos Aires, General Pueyrredón", 6357110L, "LORENZO CIANCHETTA", "INDEC", 0, 0 },
                    { 635711006310L, "CALLE", 1579, 1598, "LORENZO EUSEBIONE, Buenos Aires, General Pueyrredón", 6357110L, "LORENZO EUSEBIONE", "INDEC", 0, 0 },
                    { 635711006315L, "CALLE", 0, 0, "LOS ABEDULES, Buenos Aires, General Pueyrredón", 6357110L, "LOS ABEDULES", "INDEC", 0, 0 },
                    { 635711006320L, "CALLE", 0, 0, "LOS ABETOS, Buenos Aires, General Pueyrredón", 6357110L, "LOS ABETOS", "INDEC", 0, 0 },
                    { 635711006325L, "CALLE", 0, 0, "LOS AGAPANTHUS, Buenos Aires, General Pueyrredón", 6357110L, "LOS AGAPANTHUS", "INDEC", 0, 0 },
                    { 635711006330L, "CALLE", 0, 0, "LOS ALACALUPES, Buenos Aires, General Pueyrredón", 6357110L, "LOS ALACALUPES", "INDEC", 0, 0 },
                    { 635711006335L, "CALLE", 0, 0, "LOS ALAMOS, Buenos Aires, General Pueyrredón", 6357110L, "LOS ALAMOS", "INDEC", 0, 0 },
                    { 635711006340L, "CALLE", 0, 0, "LOS ALAMOS - BO CAMET, Buenos Aires, General Pueyrredón", 6357110L, "LOS ALAMOS - BO CAMET", "INDEC", 0, 0 },
                    { 635711006345L, "CALLE", 0, 0, "LOS ALELIES, Buenos Aires, General Pueyrredón", 6357110L, "LOS ALELIES", "INDEC", 0, 0 },
                    { 635711006350L, "CALLE", 1299, 1298, "LOS ALHELIES, Buenos Aires, General Pueyrredón", 6357110L, "LOS ALHELIES", "INDEC", 1101, 1100 },
                    { 635711006355L, "CALLE", 0, 0, "LOS ALMENDROS, Buenos Aires, General Pueyrredón", 6357110L, "LOS ALMENDROS", "INDEC", 0, 0 },
                    { 635711006360L, "CALLE", 0, 0, "LOS ARAUCANOS, Buenos Aires, General Pueyrredón", 6357110L, "LOS ARAUCANOS", "INDEC", 0, 0 },
                    { 635711006365L, "CALLE", 0, 0, "LOS AROMOS, Buenos Aires, General Pueyrredón", 6357110L, "LOS AROMOS", "INDEC", 0, 0 },
                    { 635711006370L, "CALLE", 0, 0, "LOS ARRAYANES, Buenos Aires, General Pueyrredón", 6357110L, "LOS ARRAYANES", "INDEC", 0, 0 },
                    { 635711006375L, "CALLE", 0, 0, "LOS AVIPONES, Buenos Aires, General Pueyrredón", 6357110L, "LOS AVIPONES", "INDEC", 0, 0 },
                    { 635711006380L, "CALLE", 0, 0, "LOS AZTECAS, Buenos Aires, General Pueyrredón", 6357110L, "LOS AZTECAS", "INDEC", 0, 0 },
                    { 635711006385L, "CALLE", 0, 0, "LOS CALCHAQUIES, Buenos Aires, General Pueyrredón", 6357110L, "LOS CALCHAQUIES", "INDEC", 0, 0 },
                    { 635711006390L, "CALLE", 0, 0, "LOS CAROYAS, Buenos Aires, General Pueyrredón", 6357110L, "LOS CAROYAS", "INDEC", 0, 0 },
                    { 635711006395L, "CALLE", 0, 0, "LOS CASTANOS, Buenos Aires, General Pueyrredón", 6357110L, "LOS CASTANOS", "INDEC", 0, 0 },
                    { 635711006400L, "CALLE", 0, 0, "LOS CEDROS, Buenos Aires, General Pueyrredón", 6357110L, "LOS CEDROS", "INDEC", 0, 0 },
                    { 635711006405L, "CALLE", 0, 0, "LOS CEDROS - BO CAMET, Buenos Aires, General Pueyrredón", 6357110L, "LOS CEDROS - BO CAMET", "INDEC", 0, 0 },
                    { 635711006410L, "CALLE", 0, 0, "LOS CEIBOS, Buenos Aires, General Pueyrredón", 6357110L, "LOS CEIBOS", "INDEC", 0, 0 },
                    { 635711006415L, "CALLE", 0, 0, "LOS CEREZOS, Buenos Aires, General Pueyrredón", 6357110L, "LOS CEREZOS", "INDEC", 0, 0 },
                    { 635711006420L, "CALLE", 0, 0, "LOS CHANAS, Buenos Aires, General Pueyrredón", 6357110L, "LOS CHANAS", "INDEC", 0, 0 },
                    { 635711006425L, "CALLE", 0, 0, "LOS CHANARES, Buenos Aires, General Pueyrredón", 6357110L, "LOS CHANARES", "INDEC", 0, 0 },
                    { 635711006430L, "CALLE", 0, 0, "LOS CHARRUAS, Buenos Aires, General Pueyrredón", 6357110L, "LOS CHARRUAS", "INDEC", 0, 0 },
                    { 635711006435L, "CALLE", 0, 0, "LOS CHIRIGUANOS, Buenos Aires, General Pueyrredón", 6357110L, "LOS CHIRIGUANOS", "INDEC", 0, 0 },
                    { 635711006440L, "CALLE", 0, 0, "LOS CIPRESES, Buenos Aires, General Pueyrredón", 6357110L, "LOS CIPRESES", "INDEC", 0, 0 },
                    { 635711006445L, "CALLE", 1299, 1298, "LOS CLAVELES, Buenos Aires, General Pueyrredón", 6357110L, "LOS CLAVELES", "INDEC", 1101, 1100 },
                    { 635711006450L, "CALLE", 0, 0, "LOS CLAVELES DEL BOSQUE, Buenos Aires, General Pueyrredón", 6357110L, "LOS CLAVELES DEL BOSQUE", "INDEC", 0, 0 },
                    { 635711006455L, "CALLE", 0, 0, "LOS COLLAS, Buenos Aires, General Pueyrredón", 6357110L, "LOS COLLAS", "INDEC", 0, 0 },
                    { 635711006460L, "CALLE", 0, 0, "LOS COMECHINGONES, Buenos Aires, General Pueyrredón", 6357110L, "LOS COMECHINGONES", "INDEC", 0, 0 },
                    { 635711006465L, "CALLE", 0, 0, "LOS CRISANTEMOS, Buenos Aires, General Pueyrredón", 6357110L, "LOS CRISANTEMOS", "INDEC", 0, 0 },
                    { 635711006470L, "CALLE", 0, 0, "LOS DIAGUITAS, Buenos Aires, General Pueyrredón", 6357110L, "LOS DIAGUITAS", "INDEC", 0, 0 },
                    { 635711006475L, "CALLE", 0, 0, "LOS DURAZNEROS, Buenos Aires, General Pueyrredón", 6357110L, "LOS DURAZNEROS", "INDEC", 0, 0 },
                    { 635711006480L, "CALLE", 0, 0, "LOS EUCALIPTOS, Buenos Aires, General Pueyrredón", 6357110L, "LOS EUCALIPTOS", "INDEC", 0, 0 },
                    { 635711006485L, "CALLE", 8898, 598, "LOS EUCALIPTUS, Buenos Aires, General Pueyrredón", 6357110L, "LOS EUCALIPTUS", "INDEC", 0, 0 },
                    { 635711006490L, "CALLE", 0, 0, "LOS FRESNOS, Buenos Aires, General Pueyrredón", 6357110L, "LOS FRESNOS", "INDEC", 0, 0 },
                    { 635711006495L, "CALLE", 0, 0, "LOS GERANIOS, Buenos Aires, General Pueyrredón", 6357110L, "LOS GERANIOS", "INDEC", 0, 0 },
                    { 635711006500L, "CALLE", 0, 0, "LOS GRANADOS, Buenos Aires, General Pueyrredón", 6357110L, "LOS GRANADOS", "INDEC", 0, 0 },
                    { 635711006505L, "CALLE", 0, 0, "LOS GUARANIES, Buenos Aires, General Pueyrredón", 6357110L, "LOS GUARANIES", "INDEC", 0, 0 },
                    { 635711006510L, "CALLE", 0, 0, "LOS GUAYCURUES, Buenos Aires, General Pueyrredón", 6357110L, "LOS GUAYCURUES", "INDEC", 0, 0 },
                    { 635711006515L, "CALLE", 0, 0, "LOS HUARPES, Buenos Aires, General Pueyrredón", 6357110L, "LOS HUARPES", "INDEC", 0, 0 },
                    { 635711006520L, "CALLE", 0, 0, "LOS INCAS, Buenos Aires, General Pueyrredón", 6357110L, "LOS INCAS", "INDEC", 0, 0 },
                    { 635711006525L, "CALLE", 0, 0, "LOS JACINTOS, Buenos Aires, General Pueyrredón", 6357110L, "LOS JACINTOS", "INDEC", 0, 0 },
                    { 635711006530L, "CALLE", 1399, 1398, "LOS JAZMINES, Buenos Aires, General Pueyrredón", 6357110L, "LOS JAZMINES", "INDEC", 1101, 1100 },
                    { 635711006535L, "CALLE", 0, 0, "LOS JUNCOS, Buenos Aires, General Pueyrredón", 6357110L, "LOS JUNCOS", "INDEC", 0, 0 },
                    { 635711006540L, "CALLE", 0, 0, "LOS LIMONEROS, Buenos Aires, General Pueyrredón", 6357110L, "LOS LIMONEROS", "INDEC", 0, 0 },
                    { 635711006545L, "CALLE", 0, 0, "LOS LIRIOS, Buenos Aires, General Pueyrredón", 6357110L, "LOS LIRIOS", "INDEC", 0, 0 },
                    { 635711006550L, "CALLE", 0, 0, "LOS LULES, Buenos Aires, General Pueyrredón", 6357110L, "LOS LULES", "INDEC", 0, 0 },
                    { 635711006555L, "CALLE", 0, 0, "LOS MALVONES, Buenos Aires, General Pueyrredón", 6357110L, "LOS MALVONES", "INDEC", 0, 0 },
                    { 635711006560L, "CALLE", 0, 0, "LOS MANZANOS, Buenos Aires, General Pueyrredón", 6357110L, "LOS MANZANOS", "INDEC", 0, 0 },
                    { 635711006565L, "CALLE", 0, 0, "LOS MAPUCHES, Buenos Aires, General Pueyrredón", 6357110L, "LOS MAPUCHES", "INDEC", 0, 0 },
                    { 635711006570L, "CALLE", 0, 0, "LOS MATACOS, Buenos Aires, General Pueyrredón", 6357110L, "LOS MATACOS", "INDEC", 0, 0 },
                    { 635711006575L, "CALLE", 0, 0, "LOS MOCOVIES, Buenos Aires, General Pueyrredón", 6357110L, "LOS MOCOVIES", "INDEC", 0, 0 },
                    { 635711006580L, "CALLE", 0, 0, "LOS NARANJOS, Buenos Aires, General Pueyrredón", 6357110L, "LOS NARANJOS", "INDEC", 0, 0 },
                    { 635711006585L, "CALLE", 1299, 1298, "LOS NARDOS, Buenos Aires, General Pueyrredón", 6357110L, "LOS NARDOS", "INDEC", 1101, 1100 },
                    { 635711006590L, "CALLE", 0, 0, "LOS NOGALES, Buenos Aires, General Pueyrredón", 6357110L, "LOS NOGALES", "INDEC", 0, 0 },
                    { 635711006595L, "CALLE", 8498, 8699, "LOS OLMOS, Buenos Aires, General Pueyrredón", 6357110L, "LOS OLMOS", "INDEC", 0, 0 },
                    { 635711006600L, "CALLE", 0, 0, "LOS ONAS, Buenos Aires, General Pueyrredón", 6357110L, "LOS ONAS", "INDEC", 0, 0 },
                    { 635711006605L, "CALLE", 0, 0, "LOS PARAISOS, Buenos Aires, General Pueyrredón", 6357110L, "LOS PARAISOS", "INDEC", 0, 0 },
                    { 635711006610L, "CALLE", 0, 0, "LOS PATAGONES, Buenos Aires, General Pueyrredón", 6357110L, "LOS PATAGONES", "INDEC", 0, 0 },
                    { 635711006615L, "CALLE", 0, 0, "LOS PILAGAS, Buenos Aires, General Pueyrredón", 6357110L, "LOS PILAGAS", "INDEC", 0, 0 },
                    { 635711006620L, "CALLE", 0, 0, "LOS PINOS, Buenos Aires, General Pueyrredón", 6357110L, "LOS PINOS", "INDEC", 0, 0 },
                    { 635711006625L, "CALLE", 0, 0, "LOS PLATANOS, Buenos Aires, General Pueyrredón", 6357110L, "LOS PLATANOS", "INDEC", 0, 0 },
                    { 635711006630L, "CALLE", 0, 0, "LOS PUELCHES, Buenos Aires, General Pueyrredón", 6357110L, "LOS PUELCHES", "INDEC", 0, 0 },
                    { 635711006635L, "CALLE", 0, 0, "LOS QUEBRACHOS, Buenos Aires, General Pueyrredón", 6357110L, "LOS QUEBRACHOS", "INDEC", 0, 0 },
                    { 635711006640L, "CALLE", 0, 0, "LOS QUICHUAS, Buenos Aires, General Pueyrredón", 6357110L, "LOS QUICHUAS", "INDEC", 0, 0 },
                    { 635711006645L, "CALLE", 0, 0, "LOS QUILMES, Buenos Aires, General Pueyrredón", 6357110L, "LOS QUILMES", "INDEC", 0, 0 },
                    { 635711006650L, "CALLE", 0, 0, "LOS RANQUELES, Buenos Aires, General Pueyrredón", 6357110L, "LOS RANQUELES", "INDEC", 0, 0 },
                    { 635711006655L, "CALLE", 0, 0, "LOS ROBLES, Buenos Aires, General Pueyrredón", 6357110L, "LOS ROBLES", "INDEC", 0, 0 },
                    { 635711006660L, "CALLE", 0, 0, "LOS SANAVIRONES, Buenos Aires, General Pueyrredón", 6357110L, "LOS SANAVIRONES", "INDEC", 0, 0 },
                    { 635711006665L, "CALLE", 0, 0, "LOS SAUCES, Buenos Aires, General Pueyrredón", 6357110L, "LOS SAUCES", "INDEC", 0, 0 },
                    { 635711006670L, "CALLE", 0, 0, "LOS TALAS, Buenos Aires, General Pueyrredón", 6357110L, "LOS TALAS", "INDEC", 0, 0 },
                    { 635711006675L, "CALLE", 0, 0, "LOS TAPES, Buenos Aires, General Pueyrredón", 6357110L, "LOS TAPES", "INDEC", 0, 0 },
                    { 635711006680L, "CALLE", 0, 0, "LOS TEHUELCHES, Buenos Aires, General Pueyrredón", 6357110L, "LOS TEHUELCHES", "INDEC", 0, 0 },
                    { 635711006685L, "CALLE", 0, 0, "LOS TILOS, Buenos Aires, General Pueyrredón", 6357110L, "LOS TILOS", "INDEC", 0, 0 },
                    { 635711006690L, "CALLE", 0, 0, "LOS TIMBUES, Buenos Aires, General Pueyrredón", 6357110L, "LOS TIMBUES", "INDEC", 0, 0 },
                    { 635711006695L, "CALLE", 0, 0, "LOS TOBAS, Buenos Aires, General Pueyrredón", 6357110L, "LOS TOBAS", "INDEC", 0, 0 },
                    { 635711006700L, "CALLE", 0, 0, "LOS TOTORAS, Buenos Aires, General Pueyrredón", 6357110L, "LOS TOTORAS", "INDEC", 0, 0 },
                    { 635711006705L, "CALLE", 0, 0, "LOS WICHIES, Buenos Aires, General Pueyrredón", 6357110L, "LOS WICHIES", "INDEC", 0, 0 },
                    { 635711006710L, "CALLE", 0, 0, "LOS XIUX, Buenos Aires, General Pueyrredón", 6357110L, "LOS XIUX", "INDEC", 0, 0 },
                    { 635711006715L, "CALLE", 1299, 1298, "LUCANIA, Buenos Aires, General Pueyrredón", 6357110L, "LUCANIA", "INDEC", 0, 0 },
                    { 635711006720L, "CALLE", 0, 0, "LUIS A GALLO, Buenos Aires, General Pueyrredón", 6357110L, "LUIS A GALLO", "INDEC", 0, 0 },
                    { 635711006725L, "CALLE", 298, 0, "LUIS ANGEL FIRPO, Buenos Aires, General Pueyrredón", 6357110L, "LUIS ANGEL FIRPO", "INDEC", 0, 0 },
                    { 635711006730L, "CALLE", 0, 0, "LUIS DEL HIERRO, Buenos Aires, General Pueyrredón", 6357110L, "LUIS DEL HIERRO", "INDEC", 0, 0 },
                    { 635711006735L, "CALLE", 0, 0, "LUIS DEL ORO, Buenos Aires, General Pueyrredón", 6357110L, "LUIS DEL ORO", "INDEC", 0, 0 },
                    { 635711006740L, "CALLE", 0, 0, "LUIS FRANCO, Buenos Aires, General Pueyrredón", 6357110L, "LUIS FRANCO", "INDEC", 0, 0 },
                    { 635711006745L, "CALLE", 0, 0, "LUIS SANDRINI, Buenos Aires, General Pueyrredón", 6357110L, "LUIS SANDRINI", "INDEC", 0, 0 },
                    { 635711006750L, "CALLE", 0, 0, "LUIS VARESE, Buenos Aires, General Pueyrredón", 6357110L, "LUIS VARESE", "INDEC", 0, 0 },
                    { 635711006755L, "CALLE", 8399, 8098, "LUISONI, Buenos Aires, General Pueyrredón", 6357110L, "LUISONI", "INDEC", 0, 0 },
                    { 635711006760L, "CALLE", 0, 0, "M CHILABERT BIS, Buenos Aires, General Pueyrredón", 6357110L, "M CHILABERT BIS", "INDEC", 0, 0 },
                    { 635711006765L, "CALLE", 0, 0, "M T DE ALVEAR, Buenos Aires, General Pueyrredón", 6357110L, "M T DE ALVEAR", "INDEC", 0, 0 },
                    { 635711006770L, "CALLE", 0, 0, "M URRUTIA, Buenos Aires, General Pueyrredón", 6357110L, "M URRUTIA", "INDEC", 0, 0 },
                    { 635711006775L, "CALLE", 0, 0, "MAC GAUL ANDRES BIS, Buenos Aires, General Pueyrredón", 6357110L, "MAC GAUL ANDRES BIS", "INDEC", 0, 0 },
                    { 635711006780L, "CALLE", 2598, 2498, "MACEDONIO FERNANDEZ, Buenos Aires, General Pueyrredón", 6357110L, "MACEDONIO FERNANDEZ", "INDEC", 0, 0 },
                    { 635711006782L, "CALLE", 0, 0, "MADARIAGA, Buenos Aires, General Pueyrredón", 6357110L, "MADARIAGA", "INDEC", 0, 0 },
                    { 635711006785L, "CALLE", 7998, 7999, "MAGABURU BIS, Buenos Aires, General Pueyrredón", 6357110L, "MAGABURU BIS", "INDEC", 7900, 7901 },
                    { 635711006790L, "CALLE", 76999, 54999, "MAGALLANES, Buenos Aires, General Pueyrredón", 6357110L, "MAGALLANES", "INDEC", 0, 0 },
                    { 635711006795L, "CALLE", 0, 0, "MAGALLANES BIS, Buenos Aires, General Pueyrredón", 6357110L, "MAGALLANES BIS", "INDEC", 0, 0 },
                    { 635711006800L, "CALLE", 5099, 0, "MAGRASSI GUILLERMO, Buenos Aires, General Pueyrredón", 6357110L, "MAGRASSI GUILLERMO", "INDEC", 0, 0 },
                    { 635711006805L, "CALLE", 0, 0, "MANCO CAPAC, Buenos Aires, General Pueyrredón", 6357110L, "MANCO CAPAC", "INDEC", 0, 0 },
                    { 635711006810L, "CALLE", 0, 0, "MANGORE, Buenos Aires, General Pueyrredón", 6357110L, "MANGORE", "INDEC", 0, 0 },
                    { 635711006815L, "CALLE", 0, 0, "MANRIQUE, Buenos Aires, General Pueyrredón", 6357110L, "MANRIQUE", "INDEC", 0, 0 },
                    { 635711006820L, "CALLE", 0, 0, "MANSILLA LUCIO, Buenos Aires, General Pueyrredón", 6357110L, "MANSILLA LUCIO", "INDEC", 0, 0 },
                    { 635711006825L, "CALLE", 0, 0, "MANUEL GRANDE, Buenos Aires, General Pueyrredón", 6357110L, "MANUEL GRANDE", "INDEC", 0, 0 },
                    { 635711006830L, "CALLE", 19999, 8398, "MANUWAL A V, Buenos Aires, General Pueyrredón", 6357110L, "MANUWAL A V", "INDEC", 1901, 0 },
                    { 635711006835L, "CALLE", 0, 0, "MARCELO G PLANES, Buenos Aires, General Pueyrredón", 6357110L, "MARCELO G PLANES", "INDEC", 0, 0 },
                    { 635711006840L, "CALLE", 0, 0, "MARCELO JULIO FITTE DOCTOR, Buenos Aires, General Pueyrredón", 6357110L, "MARCELO JULIO FITTE DOCTOR", "INDEC", 0, 0 },
                    { 635711006845L, "CALLE", 0, 0, "MARCELO T DE ALVEAR DOCTOR, Buenos Aires, General Pueyrredón", 6357110L, "MARCELO T DE ALVEAR DOCTOR", "INDEC", 0, 0 },
                    { 635711006850L, "CALLE", 6798, 6799, "MARECHAL, Buenos Aires, General Pueyrredón", 6357110L, "MARECHAL", "INDEC", 6400, 2600 },
                    { 635711006855L, "CALLE", 0, 0, "MARIA GERTRUDIS, Buenos Aires, General Pueyrredón", 6357110L, "MARIA GERTRUDIS", "INDEC", 0, 0 },
                    { 635711006860L, "CALLE", 0, 0, "MARIANO A CISNEROS, Buenos Aires, General Pueyrredón", 6357110L, "MARIANO A CISNEROS", "INDEC", 0, 0 },
                    { 635711006865L, "CALLE", 6399, 6398, "MARIANO ROSAS, Buenos Aires, General Pueyrredón", 6357110L, "MARIANO ROSAS", "INDEC", 0, 0 },
                    { 635711006870L, "CALLE", 0, 0, "MARILIN, Buenos Aires, General Pueyrredón", 6357110L, "MARILIN", "INDEC", 0, 0 },
                    { 635711006875L, "CALLE", 0, 0, "MARILIN II, Buenos Aires, General Pueyrredón", 6357110L, "MARILIN II", "INDEC", 0, 0 },
                    { 635711006880L, "CALLE", 0, 0, "MARILUZ, Buenos Aires, General Pueyrredón", 6357110L, "MARILUZ", "INDEC", 0, 0 },
                    { 635711006885L, "CALLE", 0, 0, "MARIO BRAVO, Buenos Aires, General Pueyrredón", 6357110L, "MARIO BRAVO", "INDEC", 0, 0 },
                    { 635711006890L, "CALLE", 0, 0, "MARIO R LUNA, Buenos Aires, General Pueyrredón", 6357110L, "MARIO R LUNA", "INDEC", 0, 0 },
                    { 635711006895L, "CALLE", 998, 999, "MARMOL JOSE, Buenos Aires, General Pueyrredón", 6357110L, "MARMOL JOSE", "INDEC", 0, 1 },
                    { 635711006900L, "CALLE", 0, 0, "MARQUEZ, Buenos Aires, General Pueyrredón", 6357110L, "MARQUEZ", "INDEC", 0, 0 },
                    { 635711006905L, "CALLE", 0, 0, "MARTIN FIERRO, Buenos Aires, General Pueyrredón", 6357110L, "MARTIN FIERRO", "INDEC", 0, 0 },
                    { 635711006910L, "CALLE", 3498, 3499, "MARTINEZ, Buenos Aires, General Pueyrredón", 6357110L, "MARTINEZ", "INDEC", 0, 0 },
                    { 635711006915L, "CALLE", 0, 0, "MARTINEZ DE HOZ FLORENCIO BIS, Buenos Aires, General Pueyrredón", 6357110L, "MARTINEZ DE HOZ FLORENCIO BIS", "INDEC", 0, 0 },
                    { 635711006920L, "CALLE", 2098, 8059, "MASCIAS R, Buenos Aires, General Pueyrredón", 6357110L, "MASCIAS R", "INDEC", 0, 0 },
                    { 635711006925L, "CALLE", 0, 0, "MATIENZO BENJAMIN, Buenos Aires, General Pueyrredón", 6357110L, "MATIENZO BENJAMIN", "INDEC", 0, 0 },
                    { 635711006930L, "CALLE", 0, 0, "MAYOR JR FALCONIER, Buenos Aires, General Pueyrredón", 6357110L, "MAYOR JR FALCONIER", "INDEC", 0, 0 },
                    { 635711006935L, "CALLE", 0, 0, "MELINAO, Buenos Aires, General Pueyrredón", 6357110L, "MELINAO", "INDEC", 0, 0 },
                    { 635711006940L, "CALLE", 8199, 8398, "MENDIOROZ B, Buenos Aires, General Pueyrredón", 6357110L, "MENDIOROZ B", "INDEC", 0, 0 },
                    { 635711006945L, "CALLE", 0, 0, "MENGHIN EDUARDO, Buenos Aires, General Pueyrredón", 6357110L, "MENGHIN EDUARDO", "INDEC", 0, 0 },
                    { 635711006950L, "CALLE", 0, 0, "MERCEDES, Buenos Aires, General Pueyrredón", 6357110L, "MERCEDES", "INDEC", 0, 0 },
                    { 635711006955L, "CALLE", 0, 0, "MINUANES, Buenos Aires, General Pueyrredón", 6357110L, "MINUANES", "INDEC", 0, 0 },
                    { 635711006960L, "CALLE", 3999, 4098, "MISIONES, Buenos Aires, General Pueyrredón", 6357110L, "MISIONES", "INDEC", 0, 3800 },
                    { 635711006965L, "CALLE", 0, 0, "MOCORETA, Buenos Aires, General Pueyrredón", 6357110L, "MOCORETA", "INDEC", 0, 0 },
                    { 635711006970L, "CALLE", 0, 0, "MOCTEZUMA, Buenos Aires, General Pueyrredón", 6357110L, "MOCTEZUMA", "INDEC", 0, 0 },
                    { 635711006975L, "CALLE", 6298, 0, "MONACO, Buenos Aires, General Pueyrredón", 6357110L, "MONACO", "INDEC", 6200, 0 },
                    { 635711006980L, "CALLE", 3499, 0, "MONSALVO, Buenos Aires, General Pueyrredón", 6357110L, "MONSALVO", "INDEC", 0, 0 },
                    { 635711006985L, "CALLE", 0, 0, "MONSENOR SEGURA, Buenos Aires, General Pueyrredón", 6357110L, "MONSENOR SEGURA", "INDEC", 0, 0 },
                    { 635711006990L, "CALLE", 0, 0, "MONSENOR ERNESTO SEGURA, Buenos Aires, General Pueyrredón", 6357110L, "MONSENOR ERNESTO SEGURA", "INDEC", 0, 0 },
                    { 635711006995L, "CALLE", 0, 0, "MONSENOR RAU BIS, Buenos Aires, General Pueyrredón", 6357110L, "MONSENOR RAU BIS", "INDEC", 0, 0 },
                    { 635711007000L, "CALLE", 0, 0, "MOYANO C, Buenos Aires, General Pueyrredón", 6357110L, "MOYANO C", "INDEC", 0, 0 },
                    { 635711007005L, "CALLE", 0, 0, "MUELLE, Buenos Aires, General Pueyrredón", 6357110L, "MUELLE", "INDEC", 0, 0 },
                    { 635711007010L, "CALLE", 3498, 3499, "N ROMANO, Buenos Aires, General Pueyrredón", 6357110L, "N ROMANO", "INDEC", 0, 0 },
                    { 635711007015L, "CALLE", 0, 0, "N MIGUELETES, Buenos Aires, General Pueyrredón", 6357110L, "N MIGUELETES", "INDEC", 0, 0 },
                    { 635711007020L, "CALLE", 0, 0, "NAHUEL HUAPI, Buenos Aires, General Pueyrredón", 6357110L, "NAHUEL HUAPI", "INDEC", 0, 0 },
                    { 635711007025L, "CALLE", 0, 0, "NAHUELPAN, Buenos Aires, General Pueyrredón", 6357110L, "NAHUELPAN", "INDEC", 0, 0 },
                    { 635711007030L, "CALLE", 0, 0, "NAMUNCURA, Buenos Aires, General Pueyrredón", 6357110L, "NAMUNCURA", "INDEC", 0, 0 },
                    { 635711007035L, "CALLE", 1799, 548, "NAVARRA, Buenos Aires, General Pueyrredón", 6357110L, "NAVARRA", "INDEC", 0, 0 },
                    { 635711007040L, "CALLE", 0, 2498, "NERUDA, Buenos Aires, General Pueyrredón", 6357110L, "NERUDA", "INDEC", 0, 0 },
                    { 635711007045L, "CALLE", 8398, 8499, "NEWBERY JORGE, Buenos Aires, General Pueyrredón", 6357110L, "NEWBERY JORGE", "INDEC", 0, 7901 },
                    { 635711007050L, "CALLE", 2098, 10699, "NICARAGUA, Buenos Aires, General Pueyrredón", 6357110L, "NICARAGUA", "INDEC", 0, 0 },
                    { 635711007055L, "CALLE", 98, 99, "NOGAL, Buenos Aires, General Pueyrredón", 6357110L, "NOGAL", "INDEC", 0, 1 },
                    { 635711007060L, "CALLE", 0, 0, "NOGALES, Buenos Aires, General Pueyrredón", 6357110L, "NOGALES", "INDEC", 0, 0 },
                    { 635711007065L, "CALLE", 0, 0, "NUESTRA SENORA DE SCHOENSTDL, Buenos Aires, General Pueyrredón", 6357110L, "NUESTRA SENORA DE SCHOENSTDL", "INDEC", 0, 0 },
                    { 635711007070L, "CALLE", 0, 0, "NUEVO BOSQUE, Buenos Aires, General Pueyrredón", 6357110L, "NUEVO BOSQUE", "INDEC", 0, 0 },
                    { 635711007075L, "CALLE", 0, 0, "O DE ZARATE, Buenos Aires, General Pueyrredón", 6357110L, "O DE ZARATE", "INDEC", 0, 0 },
                    { 635711007080L, "CALLE", 0, 0, "OJO DE AGUA, Buenos Aires, General Pueyrredón", 6357110L, "OJO DE AGUA", "INDEC", 0, 0 },
                    { 635711007085L, "CALLE", 0, 0, "OLAVARRIA, Buenos Aires, General Pueyrredón", 6357110L, "OLAVARRIA", "INDEC", 0, 0 },
                    { 635711007090L, "CALLE", 599, 600, "OLEGARIO OLAZAR, Buenos Aires, General Pueyrredón", 6357110L, "OLEGARIO OLAZAR", "INDEC", 101, 102 },
                    { 635711007095L, "CALLE", 0, 0, "OLMO, Buenos Aires, General Pueyrredón", 6357110L, "OLMO", "INDEC", 0, 0 },
                    { 635711007100L, "CALLE", 0, 0, "OLMOS, Buenos Aires, General Pueyrredón", 6357110L, "OLMOS", "INDEC", 0, 0 },
                    { 635711007105L, "CALLE", 398, 399, "OMBUES, Buenos Aires, General Pueyrredón", 6357110L, "OMBUES", "INDEC", 0, 0 },
                    { 635711007110L, "CALLE", 0, 0, "ONEGLIA, Buenos Aires, General Pueyrredón", 6357110L, "ONEGLIA", "INDEC", 0, 0 },
                    { 635711007115L, "CALLE", 8399, 8198, "ORIGONE, Buenos Aires, General Pueyrredón", 6357110L, "ORIGONE", "INDEC", 0, 0 },
                    { 635711007120L, "CALLE", 77999, 72098, "ORTIZ DE ZARATE, Buenos Aires, General Pueyrredón", 6357110L, "ORTIZ DE ZARATE", "INDEC", 0, 0 },
                    { 635711007125L, "CALLE", 0, 0, "OSCAR DIARTE, Buenos Aires, General Pueyrredón", 6357110L, "OSCAR DIARTE", "INDEC", 0, 0 },
                    { 635711007130L, "CALLE", 0, 0, "OUTES FELIX, Buenos Aires, General Pueyrredón", 6357110L, "OUTES FELIX", "INDEC", 0, 0 },
                    { 635711007135L, "CALLE", 0, 0, "P GOYENA, Buenos Aires, General Pueyrredón", 6357110L, "P GOYENA", "INDEC", 0, 0 },
                    { 635711007140L, "CALLE", 0, 0, "PADRE SAN PIO DE PIETRELCINA, Buenos Aires, General Pueyrredón", 6357110L, "PADRE SAN PIO DE PIETRELCINA", "INDEC", 0, 0 },
                    { 635711007145L, "CALLE", 0, 0, "PAGANO, Buenos Aires, General Pueyrredón", 6357110L, "PAGANO", "INDEC", 0, 0 },
                    { 635711007150L, "CALLE", 0, 0, "PALESTINA, Buenos Aires, General Pueyrredón", 6357110L, "PALESTINA", "INDEC", 0, 0 },
                    { 635711007155L, "CALLE", 2599, 2598, "PALMA RICARDO, Buenos Aires, General Pueyrredón", 6357110L, "PALMA RICARDO", "INDEC", 1, 0 },
                    { 635711007160L, "CALLE", 0, 0, "PAMPERO, Buenos Aires, General Pueyrredón", 6357110L, "PAMPERO", "INDEC", 0, 0 },
                    { 635711007165L, "CALLE", 0, 0, "PARAISOS, Buenos Aires, General Pueyrredón", 6357110L, "PARAISOS", "INDEC", 0, 0 },
                    { 635711007170L, "CALLE", 0, 0, "PARODI, Buenos Aires, General Pueyrredón", 6357110L, "PARODI", "INDEC", 0, 0 },
                    { 635711007175L, "CALLE", 0, 0, "PARRAVICINI, Buenos Aires, General Pueyrredón", 6357110L, "PARRAVICINI", "INDEC", 0, 0 },
                    { 635711007180L, "PJE", 0, 0, "PASAJE ARRIBENOS, Buenos Aires, General Pueyrredón", 6357110L, "PASAJE ARRIBENOS", "INDEC", 0, 0 },
                    { 635711007185L, "PJE", 0, 0, "PASAJE DEL TEJAR, Buenos Aires, General Pueyrredón", 6357110L, "PASAJE DEL TEJAR", "INDEC", 0, 0 },
                    { 635711007190L, "CALLE", 0, 0, "PASEO CARIBE, Buenos Aires, General Pueyrredón", 6357110L, "PASEO CARIBE", "INDEC", 0, 0 },
                    { 635711007195L, "CALLE", 0, 0, "PASEO DAVILA, Buenos Aires, General Pueyrredón", 6357110L, "PASEO DAVILA", "INDEC", 0, 0 },
                    { 635711007200L, "CALLE", 0, 0, "PASEO JESUS DE GALINDEZ, Buenos Aires, General Pueyrredón", 6357110L, "PASEO JESUS DE GALINDEZ", "INDEC", 0, 0 },
                    { 635711007205L, "CALLE", 0, 0, "PASEO VICTORIA OCAMPO, Buenos Aires, General Pueyrredón", 6357110L, "PASEO VICTORIA OCAMPO", "INDEC", 0, 0 },
                    { 635711007210L, "CALLE", 0, 0, "PATAGONIA, Buenos Aires, General Pueyrredón", 6357110L, "PATAGONIA", "INDEC", 0, 0 },
                    { 635711007215L, "CALLE", 8199, 8198, "PEDRO BOUCHEZ, Buenos Aires, General Pueyrredón", 6357110L, "PEDRO BOUCHEZ", "INDEC", 7401, 7400 },
                    { 635711007220L, "CALLE", 0, 0, "PEDRO ZANINI, Buenos Aires, General Pueyrredón", 6357110L, "PEDRO ZANINI", "INDEC", 0, 0 },
                    { 635711007225L, "CALLE", 5898, 5899, "PEDRONI, Buenos Aires, General Pueyrredón", 6357110L, "PEDRONI", "INDEC", 0, 0 },
                    { 635711007230L, "CALLE", 1698, 2999, "PEHUAJO, Buenos Aires, General Pueyrredón", 6357110L, "PEHUAJO", "INDEC", 0, 0 },
                    { 635711007235L, "CALLE", 0, 0, "PERITO MORENO, Buenos Aires, General Pueyrredón", 6357110L, "PERITO MORENO", "INDEC", 0, 0 },
                    { 635711007240L, "CALLE", 0, 0, "PESQUERO ALMA MADRE, Buenos Aires, General Pueyrredón", 6357110L, "PESQUERO ALMA MADRE", "INDEC", 0, 0 },
                    { 635711007245L, "CALLE", 3098, 0, "PESQUERO HALCON, Buenos Aires, General Pueyrredón", 6357110L, "PESQUERO HALCON", "INDEC", 3000, 0 },
                    { 635711007250L, "CALLE", 0, 0, "PESQUERO HAPPI DAIS, Buenos Aires, General Pueyrredón", 6357110L, "PESQUERO HAPPI DAIS", "INDEC", 0, 0 },
                    { 635711007255L, "CALLE", 0, 0, "PESQUERO KONTIKI, Buenos Aires, General Pueyrredón", 6357110L, "PESQUERO KONTIKI", "INDEC", 0, 0 },
                    { 635711007260L, "CALLE", 0, 0, "PESQUERO NOMADE, Buenos Aires, General Pueyrredón", 6357110L, "PESQUERO NOMADE", "INDEC", 0, 0 },
                    { 635711007265L, "CALLE", 0, 0, "PESQUERO NORWAL, Buenos Aires, General Pueyrredón", 6357110L, "PESQUERO NORWAL", "INDEC", 0, 0 },
                    { 635711007270L, "CALLE", 0, 0, "PESQUERO PUMAO, Buenos Aires, General Pueyrredón", 6357110L, "PESQUERO PUMAO", "INDEC", 0, 0 },
                    { 635711007275L, "CALLE", 0, 0, "PESQUERO QUO VADI, Buenos Aires, General Pueyrredón", 6357110L, "PESQUERO QUO VADI", "INDEC", 0, 0 },
                    { 635711007280L, "CALLE", 0, 0, "PINCEN, Buenos Aires, General Pueyrredón", 6357110L, "PINCEN", "INDEC", 0, 0 },
                    { 635711007285L, "CALLE", 8399, 8398, "PINO, Buenos Aires, General Pueyrredón", 6357110L, "PINO", "INDEC", 8301, 0 },
                    { 635711007290L, "CALLE", 0, 0, "PINOS, Buenos Aires, General Pueyrredón", 6357110L, "PINOS", "INDEC", 0, 0 },
                    { 635711007295L, "CALLE", 0, 0, "PINACAL, Buenos Aires, General Pueyrredón", 6357110L, "PINACAL", "INDEC", 0, 0 },
                    { 635711007300L, "CALLE", 0, 0, "PIONERO, Buenos Aires, General Pueyrredón", 6357110L, "PIONERO", "INDEC", 0, 0 },
                    { 635711007305L, "PJE", 0, 0, "PJE 278 BIS, Buenos Aires, General Pueyrredón", 6357110L, "PJE 278 BIS", "INDEC", 0, 0 },
                    { 635711007310L, "PJE", 0, 0, "PJE EL DANTE, Buenos Aires, General Pueyrredón", 6357110L, "PJE EL DANTE", "INDEC", 0, 0 },
                    { 635711007315L, "PJE", 8999, 8999, "PJE JUAN M DE ROSAS, Buenos Aires, General Pueyrredón", 6357110L, "PJE JUAN M DE ROSAS", "INDEC", 8801, 8801 },
                    { 635711007320L, "PJE", 7998, 7499, "PJE 175 BIS, Buenos Aires, General Pueyrredón", 6357110L, "PJE 175 BIS", "INDEC", 0, 0 },
                    { 635711007325L, "PJE", 8999, 8998, "PJE 22 DE ABRIL, Buenos Aires, General Pueyrredón", 6357110L, "PJE 22 DE ABRIL", "INDEC", 8901, 8900 },
                    { 635711007330L, "PJE", 0, 6898, "PJE CARLOS GARDEL, Buenos Aires, General Pueyrredón", 6357110L, "PJE CARLOS GARDEL", "INDEC", 0, 6600 },
                    { 635711007335L, "PJE", 198, 199, "PJE DE ANGELIS, Buenos Aires, General Pueyrredón", 6357110L, "PJE DE ANGELIS", "INDEC", 0, 1 },
                    { 635711007340L, "PJE", 1142, 1141, "PJE ECHEVERRIA, Buenos Aires, General Pueyrredón", 6357110L, "PJE ECHEVERRIA", "INDEC", 1100, 1101 },
                    { 635711007345L, "PJE", 0, 0, "PJE ERREA FERMIN, Buenos Aires, General Pueyrredón", 6357110L, "PJE ERREA FERMIN", "INDEC", 0, 0 },
                    { 635711007350L, "PJE", 3199, 3198, "PJE GABITO BANAT, Buenos Aires, General Pueyrredón", 6357110L, "PJE GABITO BANAT", "INDEC", 3001, 3000 },
                    { 635711007355L, "PJE", 0, 0, "PJE LUJAN, Buenos Aires, General Pueyrredón", 6357110L, "PJE LUJAN", "INDEC", 0, 0 },
                    { 635711007360L, "PJE", 598, 599, "PJE MAR DEL PLATA, Buenos Aires, General Pueyrredón", 6357110L, "PJE MAR DEL PLATA", "INDEC", 500, 501 },
                    { 635711007365L, "PJE", 0, 0, "PJE OLLEROS, Buenos Aires, General Pueyrredón", 6357110L, "PJE OLLEROS", "INDEC", 0, 0 },
                    { 635711007370L, "PJE", 0, 0, "PJE PAEATONAL SN, Buenos Aires, General Pueyrredón", 6357110L, "PJE PAEATONAL SN", "INDEC", 0, 0 },
                    { 635711007375L, "PJE", 0, 0, "PJE PARANA, Buenos Aires, General Pueyrredón", 6357110L, "PJE PARANA", "INDEC", 0, 0 },
                    { 635711007380L, "PJE", 0, 0, "PJE PORTUGAL, Buenos Aires, General Pueyrredón", 6357110L, "PJE PORTUGAL", "INDEC", 0, 0 },
                    { 635711007385L, "PJE", 0, 0, "PJE ROSALES, Buenos Aires, General Pueyrredón", 6357110L, "PJE ROSALES", "INDEC", 0, 0 },
                    { 635711007390L, "PJE", 7799, 7798, "PJE SAN BENITO, Buenos Aires, General Pueyrredón", 6357110L, "PJE SAN BENITO", "INDEC", 7601, 7600 },
                    { 635711007395L, "PJE", 598, 599, "PJE SAN BERNARDO, Buenos Aires, General Pueyrredón", 6357110L, "PJE SAN BERNARDO", "INDEC", 300, 301 },
                    { 635711007400L, "PJE", 0, 0, "PJE T DEL FOURNIER, Buenos Aires, General Pueyrredón", 6357110L, "PJE T DEL FOURNIER", "INDEC", 0, 0 },
                    { 635711007405L, "PJE", 0, 0, "PJE TECE, Buenos Aires, General Pueyrredón", 6357110L, "PJE TECE", "INDEC", 0, 0 },
                    { 635711007410L, "CALLE", 0, 0, "PLATANOS, Buenos Aires, General Pueyrredón", 6357110L, "PLATANOS", "INDEC", 0, 0 },
                    { 635711007415L, "CALLE", 2099, 2098, "PLUS ULTRA, Buenos Aires, General Pueyrredón", 6357110L, "PLUS ULTRA", "INDEC", 0, 0 },
                    { 635711007420L, "CALLE", 0, 0, "POLITTIZ, Buenos Aires, General Pueyrredón", 6357110L, "POLITTIZ", "INDEC", 0, 0 },
                    { 635711007425L, "CALLE", 0, 0, "PREFECTURA NAVAL ARGENTINA, Buenos Aires, General Pueyrredón", 6357110L, "PREFECTURA NAVAL ARGENTINA", "INDEC", 0, 0 },
                    { 635711007430L, "CALLE", 0, 0, "PSJ BERUTI, Buenos Aires, General Pueyrredón", 6357110L, "PSJ BERUTI", "INDEC", 0, 0 },
                    { 635711007435L, "CALLE", 0, 0, "PTA RAMOS E BIS, Buenos Aires, General Pueyrredón", 6357110L, "PTA RAMOS E BIS", "INDEC", 0, 0 },
                    { 635711007440L, "CALLE", 0, 0, "PTO MADRYN, Buenos Aires, General Pueyrredón", 6357110L, "PTO MADRYN", "INDEC", 0, 0 },
                    { 635711007445L, "CALLE", 0, 0, "PUAN, Buenos Aires, General Pueyrredón", 6357110L, "PUAN", "INDEC", 0, 0 },
                    { 635711007450L, "CALLE", 0, 0, "PUEYRREDON, Buenos Aires, General Pueyrredón", 6357110L, "PUEYRREDON", "INDEC", 0, 0 },
                    { 635711007455L, "CALLE", 3398, 0, "PUEYRREDON DIAG, Buenos Aires, General Pueyrredón", 6357110L, "PUEYRREDON DIAG", "INDEC", 0, 0 },
                    { 635711007460L, "CALLE", 0, 0, "QUANTEMOC, Buenos Aires, General Pueyrredón", 6357110L, "QUANTEMOC", "INDEC", 0, 0 },
                    { 635711007465L, "CALLE", 3798, 0, "QUEEN MARY, Buenos Aires, General Pueyrredón", 6357110L, "QUEEN MARY", "INDEC", 3600, 0 },
                    { 635711007470L, "CALLE", 0, 0, "QUERANDIES, Buenos Aires, General Pueyrredón", 6357110L, "QUERANDIES", "INDEC", 0, 0 },
                    { 635711007475L, "CALLE", 0, 0, "QUESADA J, Buenos Aires, General Pueyrredón", 6357110L, "QUESADA J", "INDEC", 0, 0 },
                    { 635711007480L, "CALLE", 4598, 4599, "QUIROGA HORACIO, Buenos Aires, General Pueyrredón", 6357110L, "QUIROGA HORACIO", "INDEC", 4200, 4201 },
                    { 635711007485L, "CALLE", 0, 0, "RAUCH BIS, Buenos Aires, General Pueyrredón", 6357110L, "RAUCH BIS", "INDEC", 0, 0 },
                    { 635711007490L, "CALLE", 0, 1899, "RECUERDOS, Buenos Aires, General Pueyrredón", 6357110L, "RECUERDOS", "INDEC", 0, 0 },
                    { 635711007495L, "CALLE", 0, 0, "REGION MOLISE, Buenos Aires, General Pueyrredón", 6357110L, "REGION MOLISE", "INDEC", 0, 0 },
                    { 635711007500L, "CALLE", 7799, 7698, "REJON GERONIMO, Buenos Aires, General Pueyrredón", 6357110L, "REJON GERONIMO", "INDEC", 0, 0 },
                    { 635711007505L, "CALLE", 0, 0, "REPUBLICA DE SUDAFRICA, Buenos Aires, General Pueyrredón", 6357110L, "REPUBLICA DE SUDAFRICA", "INDEC", 0, 0 },
                    { 635711007510L, "CALLE", 0, 0, "REPUBLIQUETAS, Buenos Aires, General Pueyrredón", 6357110L, "REPUBLIQUETAS", "INDEC", 0, 0 },
                    { 635711007515L, "CALLE", 0, 0, "RICARDO M GURRIERI, Buenos Aires, General Pueyrredón", 6357110L, "RICARDO M GURRIERI", "INDEC", 0, 0 },
                    { 635711007520L, "CALLE", 0, 0, "RINGUELET, Buenos Aires, General Pueyrredón", 6357110L, "RINGUELET", "INDEC", 0, 0 },
                    { 635711007525L, "CALLE", 0, 0, "RIO DE LA PLATA, Buenos Aires, General Pueyrredón", 6357110L, "RIO DE LA PLATA", "INDEC", 0, 0 },
                    { 635711007530L, "CALLE", 0, 0, "RIO GALLEGOS, Buenos Aires, General Pueyrredón", 6357110L, "RIO GALLEGOS", "INDEC", 0, 0 },
                    { 635711007535L, "CALLE", 0, 3399, "RIO IGUAZU, Buenos Aires, General Pueyrredón", 6357110L, "RIO IGUAZU", "INDEC", 0, 0 },
                    { 635711007540L, "CALLE", 0, 0, "RIO MATANZA, Buenos Aires, General Pueyrredón", 6357110L, "RIO MATANZA", "INDEC", 0, 0 },
                    { 635711007545L, "CALLE", 198, 99, "RIZZUTO, Buenos Aires, General Pueyrredón", 6357110L, "RIZZUTO", "INDEC", 0, 1 },
                    { 635711007550L, "CALLE", 5899, 0, "ROBERTO ARLT, Buenos Aires, General Pueyrredón", 6357110L, "ROBERTO ARLT", "INDEC", 5801, 0 },
                    { 635711007555L, "CALLE", 0, 4698, "ROBERTO PAYRO, Buenos Aires, General Pueyrredón", 6357110L, "ROBERTO PAYRO", "INDEC", 0, 0 },
                    { 635711007560L, "CALLE", 8398, 839, "ROBLE, Buenos Aires, General Pueyrredón", 6357110L, "ROBLE", "INDEC", 830, 8301 },
                    { 635711007565L, "CALLE", 0, 0, "ROBLES, Buenos Aires, General Pueyrredón", 6357110L, "ROBLES", "INDEC", 0, 0 },
                    { 635711007570L, "CALLE", 0, 0, "ROCAS CORMORAN, Buenos Aires, General Pueyrredón", 6357110L, "ROCAS CORMORAN", "INDEC", 0, 0 },
                    { 635711007575L, "CALLE", 698, 799, "ROCHA DARDO, Buenos Aires, General Pueyrredón", 6357110L, "ROCHA DARDO", "INDEC", 0, 1 },
                    { 635711007580L, "CALLE", 1099, 898, "RODOLFO WALSH, Buenos Aires, General Pueyrredón", 6357110L, "RODOLFO WALSH", "INDEC", 0, 0 },
                    { 635711007585L, "CALLE", 0, 0, "RODRIGUEZ, Buenos Aires, General Pueyrredón", 6357110L, "RODRIGUEZ", "INDEC", 0, 0 },
                    { 635711007590L, "CALLE", 0, 0, "RODRIGUEZ PENA, Buenos Aires, General Pueyrredón", 6357110L, "RODRIGUEZ PENA", "INDEC", 0, 0 },
                    { 635711007595L, "CALLE", 2599, 2598, "ROFFO, Buenos Aires, General Pueyrredón", 6357110L, "ROFFO", "INDEC", 1, 0 },
                    { 635711007600L, "CALLE", 0, 0, "ROJAS, Buenos Aires, General Pueyrredón", 6357110L, "ROJAS", "INDEC", 0, 0 },
                    { 635711007605L, "CALLE", 0, 2198, "ROMERO E, Buenos Aires, General Pueyrredón", 6357110L, "ROMERO E", "INDEC", 0, 0 },
                    { 635711007610L, "CALLE", 2099, 2098, "ROMERO E, Buenos Aires, General Pueyrredón", 6357110L, "ROMERO E", "INDEC", 2001, 2002 },
                    { 635711007615L, "CALLE", 0, 0, "ROMPEHIELOS IRIZAR, Buenos Aires, General Pueyrredón", 6357110L, "ROMPEHIELOS IRIZAR", "INDEC", 0, 0 },
                    { 635711007620L, "CALLE", 3798, 3999, "ROMPEHIELOS SAN MARTIN, Buenos Aires, General Pueyrredón", 6357110L, "ROMPEHIELOS SAN MARTIN", "INDEC", 0, 0 },
                    { 635711007625L, "CALLE", 0, 0, "ROTONDA EL ZORZAL, Buenos Aires, General Pueyrredón", 6357110L, "ROTONDA EL ZORZAL", "INDEC", 0, 0 },
                    { 635711007630L, "RUTA", 0, 0, "RUTA 11, Buenos Aires, General Pueyrredón", 6357110L, "RUTA 11", "INDEC", 0, 0 },
                    { 635711007635L, "AV", 1498, 2198, "RTA 2 - AV MONS JUAN ZABALA, Buenos Aires, General Pueyrredón", 6357110L, "RTA 2 - AV MONS JUAN ZABALA", "INDEC", 0, 0 },
                    { 635711007640L, "RUTA", 0, 0, "RUTA NAC 2, Buenos Aires, General Pueyrredón", 6357110L, "RUTA NAC 2", "INDEC", 0, 0 },
                    { 635711007645L, "RUTA", 0, 0, "RUTA NACIONAL 226, Buenos Aires, General Pueyrredón", 6357110L, "RUTA NACIONAL 226", "INDEC", 0, 0 },
                    { 635711007650L, "RUTA", 3699, 0, "RUTA PCIAL 11, Buenos Aires, General Pueyrredón", 6357110L, "RUTA PCIAL 11", "INDEC", 0, 0 },
                    { 635711007655L, "CALLE", 8898, 8899, "SAN ANTONIO, Buenos Aires, General Pueyrredón", 6357110L, "SAN ANTONIO", "INDEC", 0, 0 },
                    { 635711007660L, "CALLE", 0, 0, "SAN ANTONIO II, Buenos Aires, General Pueyrredón", 6357110L, "SAN ANTONIO II", "INDEC", 0, 0 },
                    { 635711007665L, "CALLE", 0, 0, "SAN CAYETANO, Buenos Aires, General Pueyrredón", 6357110L, "SAN CAYETANO", "INDEC", 0, 0 },
                    { 635711007670L, "CALLE", 0, 0, "SAN FRANCISCO DE ASIS, Buenos Aires, General Pueyrredón", 6357110L, "SAN FRANCISCO DE ASIS", "INDEC", 0, 0 },
                    { 635711007675L, "CALLE", 0, 0, "SAN FRANCISCO DE JAVIER, Buenos Aires, General Pueyrredón", 6357110L, "SAN FRANCISCO DE JAVIER", "INDEC", 0, 0 },
                    { 635711007680L, "CALLE", 0, 0, "SAN JOSE DE CALASANZ BIS, Buenos Aires, General Pueyrredón", 6357110L, "SAN JOSE DE CALASANZ BIS", "INDEC", 0, 0 },
                    { 635711007685L, "CALLE", 0, 0, "SAN PATRICIO, Buenos Aires, General Pueyrredón", 6357110L, "SAN PATRICIO", "INDEC", 0, 0 },
                    { 635711007690L, "CALLE", 0, 0, "SAN PEDRO, Buenos Aires, General Pueyrredón", 6357110L, "SAN PEDRO", "INDEC", 0, 0 },
                    { 635711007695L, "CALLE", 74199, 68989, "SAN SALVADOR, Buenos Aires, General Pueyrredón", 6357110L, "SAN SALVADOR", "INDEC", 0, 0 },
                    { 635711007700L, "CALLE", 9500, 9499, "SANCHEZ DE TOMPSON, Buenos Aires, General Pueyrredón", 6357110L, "SANCHEZ DE TOMPSON", "INDEC", 8702, 8701 },
                    { 635711007705L, "CALLE", 2198, 2199, "SANDINO, Buenos Aires, General Pueyrredón", 6357110L, "SANDINO", "INDEC", 0, 0 },
                    { 635711007710L, "CALLE", 0, 0, "SANTA ELENA, Buenos Aires, General Pueyrredón", 6357110L, "SANTA ELENA", "INDEC", 0, 0 },
                    { 635711007715L, "CALLE", 0, 0, "SANTA INES, Buenos Aires, General Pueyrredón", 6357110L, "SANTA INES", "INDEC", 0, 0 },
                    { 635711007720L, "CALLE", 0, 0, "SANTA MARGARITA, Buenos Aires, General Pueyrredón", 6357110L, "SANTA MARGARITA", "INDEC", 0, 0 },
                    { 635711007725L, "CALLE", 0, 0, "SANTA MARIA, Buenos Aires, General Pueyrredón", 6357110L, "SANTA MARIA", "INDEC", 0, 0 },
                    { 635711007730L, "CALLE", 0, 0, "SANTA ROSA, Buenos Aires, General Pueyrredón", 6357110L, "SANTA ROSA", "INDEC", 0, 0 },
                    { 635711007735L, "CALLE", 0, 0, "SANTIAGO LACAMTU, Buenos Aires, General Pueyrredón", 6357110L, "SANTIAGO LACAMTU", "INDEC", 0, 0 },
                    { 635711007740L, "CALLE", 2899, 2598, "SASTRE MARCOS, Buenos Aires, General Pueyrredón", 6357110L, "SASTRE MARCOS", "INDEC", 0, 0 },
                    { 635711007745L, "CALLE", 199, 98, "SAUCES, Buenos Aires, General Pueyrredón", 6357110L, "SAUCES", "INDEC", 1, 0 },
                    { 635711007750L, "CALLE", 3498, 3499, "SCIOCCO DOMINGO, Buenos Aires, General Pueyrredón", 6357110L, "SCIOCCO DOMINGO", "INDEC", 0, 0 },
                    { 635711007755L, "CALLE", 0, 0, "SEBASTIAN GARAU, Buenos Aires, General Pueyrredón", 6357110L, "SEBASTIAN GARAU", "INDEC", 0, 0 },
                    { 635711007760L, "CALLE", 0, 0, "SEGURA G, Buenos Aires, General Pueyrredón", 6357110L, "SEGURA G", "INDEC", 0, 0 },
                    { 635711007765L, "CALLE", 0, 0, "SEMBRADOR, Buenos Aires, General Pueyrredón", 6357110L, "SEMBRADOR", "INDEC", 0, 0 },
                    { 635711007770L, "CALLE", 0, 0, "SEVERO RUIZ, Buenos Aires, General Pueyrredón", 6357110L, "SEVERO RUIZ", "INDEC", 0, 0 },
                    { 635711007775L, "CALLE", 0, 0, "SEVILLA, Buenos Aires, General Pueyrredón", 6357110L, "SEVILLA", "INDEC", 0, 0 },
                    { 635711007780L, "CALLE", 0, 0, "SICILIA BIS, Buenos Aires, General Pueyrredón", 6357110L, "SICILIA BIS", "INDEC", 0, 0 },
                    { 635711007785L, "CALLE", 10000, 9499, "SILVIA OCAMPO, Buenos Aires, General Pueyrredón", 6357110L, "SILVIA OCAMPO", "INDEC", 8702, 8701 },
                    { 635711007790L, "CALLE", 6399, 6398, "SOIHUEQUE, Buenos Aires, General Pueyrredón", 6357110L, "SOIHUEQUE", "INDEC", 6201, 6200 },
                    { 635711007795L, "CALLE", 0, 0, "SOLDADO JOSE LUIS DEL HIERRO, Buenos Aires, General Pueyrredón", 6357110L, "SOLDADO JOSE LUIS DEL HIERRO", "INDEC", 0, 0 },
                    { 635711007800L, "CALLE", 0, 0, "SOLDADO ROLANDO PACHOLEZUK, Buenos Aires, General Pueyrredón", 6357110L, "SOLDADO ROLANDO PACHOLEZUK", "INDEC", 0, 0 },
                    { 635711007805L, "CALLE", 75899, 58899, "SOLIS, Buenos Aires, General Pueyrredón", 6357110L, "SOLIS", "INDEC", 0, 0 },
                    { 635711007810L, "CALLE", 0, 0, "SOLIS BIS, Buenos Aires, General Pueyrredón", 6357110L, "SOLIS BIS", "INDEC", 0, 0 },
                    { 635711007815L, "CALLE", 999, 998, "SOUESSIA, Buenos Aires, General Pueyrredón", 6357110L, "SOUESSIA", "INDEC", 701, 700 },
                    { 635711007820L, "CALLE", 0, 0, "STELLA MARIS, Buenos Aires, General Pueyrredón", 6357110L, "STELLA MARIS", "INDEC", 0, 0 },
                    { 635711007825L, "CALLE", 0, 0, "SUBMARINO SANTA FE, Buenos Aires, General Pueyrredón", 6357110L, "SUBMARINO SANTA FE", "INDEC", 0, 0 },
                    { 635711007830L, "CALLE", 0, 0, "SUBOFICIAL 1º FELIX OSCAR ARTUSO, Buenos Aires, General Pueyrredón", 6357110L, "SUBOFICIAL 1º FELIX OSCAR ARTUSO", "INDEC", 0, 0 },
                    { 635711007835L, "CALLE", 0, 0, "SUQUIA, Buenos Aires, General Pueyrredón", 6357110L, "SUQUIA", "INDEC", 0, 0 },
                    { 635711007840L, "CALLE", 0, 0, "TAGLE, Buenos Aires, General Pueyrredón", 6357110L, "TAGLE", "INDEC", 0, 0 },
                    { 635711007845L, "CALLE", 3398, 3399, "TALCAHUANO, Buenos Aires, General Pueyrredón", 6357110L, "TALCAHUANO", "INDEC", 3200, 3201 },
                    { 635711007850L, "CALLE", 0, 0, "TAVELLI, Buenos Aires, General Pueyrredón", 6357110L, "TAVELLI", "INDEC", 0, 0 },
                    { 635711007855L, "CALLE", 0, 0, "TAYLOR, Buenos Aires, General Pueyrredón", 6357110L, "TAYLOR", "INDEC", 0, 0 },
                    { 635711007860L, "CALLE", 0, 0, "TENIENTE 1º FAUSTO GAVAZZI, Buenos Aires, General Pueyrredón", 6357110L, "TENIENTE 1º FAUSTO GAVAZZI", "INDEC", 0, 0 },
                    { 635711007865L, "CALLE", 9500, 0, "TOMAS YEMEHUECH, Buenos Aires, General Pueyrredón", 6357110L, "TOMAS YEMEHUECH", "INDEC", 0, 0 },
                    { 635711007870L, "CALLE", 0, 0, "TORDO, Buenos Aires, General Pueyrredón", 6357110L, "TORDO", "INDEC", 0, 0 },
                    { 635711007875L, "CALLE", 6998, 6999, "TORRES DE VERA Y ARAGON, Buenos Aires, General Pueyrredón", 6357110L, "TORRES DE VERA Y ARAGON", "INDEC", 0, 0 },
                    { 635711007880L, "CALLE", 0, 0, "TOSCANA, Buenos Aires, General Pueyrredón", 6357110L, "TOSCANA", "INDEC", 0, 0 },
                    { 635711007885L, "CALLE", 0, 3498, "TRANSPORTE ISLA DE LOS ESTADOS, Buenos Aires, General Pueyrredón", 6357110L, "TRANSPORTE ISLA DE LOS ESTADOS", "INDEC", 0, 0 },
                    { 635711007890L, "CALLE", 0, 0, "TRES ARROYOS, Buenos Aires, General Pueyrredón", 6357110L, "TRES ARROYOS", "INDEC", 0, 0 },
                    { 635711007892L, "CALLE", 0, 0, "TRINIDAD Y TOBAGO, Buenos Aires, General Pueyrredón", 6357110L, "TRINIDAD Y TOBAGO", "INDEC", 0, 0 },
                    { 635711007895L, "CALLE", 0, 0, "TRIUNVIRATO OESTE, Buenos Aires, General Pueyrredón", 6357110L, "TRIUNVIRATO OESTE", "INDEC", 0, 0 },
                    { 635711007900L, "CALLE", 0, 0, "TTE DACNARY, Buenos Aires, General Pueyrredón", 6357110L, "TTE DACNARY", "INDEC", 0, 0 },
                    { 635711007905L, "CALLE", 0, 0, "TUPAC AMARU, Buenos Aires, General Pueyrredón", 6357110L, "TUPAC AMARU", "INDEC", 0, 0 },
                    { 635711007910L, "CALLE", 3499, 3498, "URQUIA, Buenos Aires, General Pueyrredón", 6357110L, "URQUIA", "INDEC", 0, 0 },
                    { 635711007915L, "CALLE", 0, 0, "USUAHIA, Buenos Aires, General Pueyrredón", 6357110L, "USUAHIA", "INDEC", 0, 0 },
                    { 635711007920L, "CALLE", 2198, 0, "V LABORANTE, Buenos Aires, General Pueyrredón", 6357110L, "V LABORANTE", "INDEC", 0, 0 },
                    { 635711007925L, "CALLE", 0, 0, "VALENCIA, Buenos Aires, General Pueyrredón", 6357110L, "VALENCIA", "INDEC", 0, 0 },
                    { 635711007930L, "CALLE", 4798, 4799, "VECINALISTA A MOLFENI, Buenos Aires, General Pueyrredón", 6357110L, "VECINALISTA A MOLFENI", "INDEC", 4700, 4701 },
                    { 635711007935L, "CALLE", 0, 8099, "VELEZ, Buenos Aires, General Pueyrredón", 6357110L, "VELEZ", "INDEC", 0, 8001 },
                    { 635711007940L, "CALLE", 9298, 9299, "VERNE, Buenos Aires, General Pueyrredón", 6357110L, "VERNE", "INDEC", 0, 0 },
                    { 635711007945L, "CALLE", 0, 0, "VIEDMA, Buenos Aires, General Pueyrredón", 6357110L, "VIEDMA", "INDEC", 0, 0 },
                    { 635711007950L, "CALLE", 0, 0, "VILLAR BIS, Buenos Aires, General Pueyrredón", 6357110L, "VILLAR BIS", "INDEC", 0, 0 },
                    { 635711007955L, "CALLE", 0, 0, "VILLARINO, Buenos Aires, General Pueyrredón", 6357110L, "VILLARINO", "INDEC", 0, 0 },
                    { 635711007960L, "CALLE", 7978, 8899, "VINA DEL MAR, Buenos Aires, General Pueyrredón", 6357110L, "VINA DEL MAR", "INDEC", 0, 0 },
                    { 635711007965L, "CALLE", 1299, 1298, "VIOLETAS, Buenos Aires, General Pueyrredón", 6357110L, "VIOLETAS", "INDEC", 1101, 1100 },
                    { 635711007970L, "CALLE", 0, 0, "VIRGEN DE LA LAGRIMA, Buenos Aires, General Pueyrredón", 6357110L, "VIRGEN DE LA LAGRIMA", "INDEC", 0, 0 },
                    { 635711007975L, "CALLE", 0, 0, "VIRREY DEL PINO, Buenos Aires, General Pueyrredón", 6357110L, "VIRREY DEL PINO", "INDEC", 0, 0 },
                    { 635711007980L, "CALLE", 5999, 5998, "VUELTA DE OBLIGADO, Buenos Aires, General Pueyrredón", 6357110L, "VUELTA DE OBLIGADO", "INDEC", 0, 0 },
                    { 635711007985L, "CALLE", 3499, 3498, "VULCAN, Buenos Aires, General Pueyrredón", 6357110L, "VULCAN", "INDEC", 0, 0 },
                    { 635711007990L, "CALLE", 0, 0, "WILLIAM MORRIS BIS, Buenos Aires, General Pueyrredón", 6357110L, "WILLIAM MORRIS BIS", "INDEC", 0, 0 },
                    { 635711007995L, "CALLE", 0, 0, "YAHATY JUAN, Buenos Aires, General Pueyrredón", 6357110L, "YAHATY JUAN", "INDEC", 0, 0 },
                    { 635711008000L, "CALLE", 0, 0, "YANQUETRUZ, Buenos Aires, General Pueyrredón", 6357110L, "YANQUETRUZ", "INDEC", 0, 0 },
                    { 635711008005L, "CALLE", 798, 0, "YAPEYU, Buenos Aires, General Pueyrredón", 6357110L, "YAPEYU", "INDEC", 0, 0 },
                    { 635711008010L, "CALLE", 0, 0, "YAPEYU BIS, Buenos Aires, General Pueyrredón", 6357110L, "YAPEYU BIS", "INDEC", 0, 0 },
                    { 635711008015L, "CALLE", 4099, 4098, "ZUBIARRE DIAG, Buenos Aires, General Pueyrredón", 6357110L, "ZUBIARRE DIAG", "INDEC", 4001, 4000 },
                    { 635711008020L, "CALLE", 0, 0, "ZURITA, Buenos Aires, General Pueyrredón", 6357110L, "ZURITA", "INDEC", 0, 0 },
                    { 635711099936L, "PJE", 8698, 9898, "PASAJE SN, Buenos Aires, General Pueyrredón", 6357110L, "PASAJE SN", "INDEC", 0, 0 },
                    { 635711099995L, "CALLE", 0, 0, "CALLE INTERNA, Buenos Aires, General Pueyrredón", 6357110L, "CALLE INTERNA", "INDEC", 0, 0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000005L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000010L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000015L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000020L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000025L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000030L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000035L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000040L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000045L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000050L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000055L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000060L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000065L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000070L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000075L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000080L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000085L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000090L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000095L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000100L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000105L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000110L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000115L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000120L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000125L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000130L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000135L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000140L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000145L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000150L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000155L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000160L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000165L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000170L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000175L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000180L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000185L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000190L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000195L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000200L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000205L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000210L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000215L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000220L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000225L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000230L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000235L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000240L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000245L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000250L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000255L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000260L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000265L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000270L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000275L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000280L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000285L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000290L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000295L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000300L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000305L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000310L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000315L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000320L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000325L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000330L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000335L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000340L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000345L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000350L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000355L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000360L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000365L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000370L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000375L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000380L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000385L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000390L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000395L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000400L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000405L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000410L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000415L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000420L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000425L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000430L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000435L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000440L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000445L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000450L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000455L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000460L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000465L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000470L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000475L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000480L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000485L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000490L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000495L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000500L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000505L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000510L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000515L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000520L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000525L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000530L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000535L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000540L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000545L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000550L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000555L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000560L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000565L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000570L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000575L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000580L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000585L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000590L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000595L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000600L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000605L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000610L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000615L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000620L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000625L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000630L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000635L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000640L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000645L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000650L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000655L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000660L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000665L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000670L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000675L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000680L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000685L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000690L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000695L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000700L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000705L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000710L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000715L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000720L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000725L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000730L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000735L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000740L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000745L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000750L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000755L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000760L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000765L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000770L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000775L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000780L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000785L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000790L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000795L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000800L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000805L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000810L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000815L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000820L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000825L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000830L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000835L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000840L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000845L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000850L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000855L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000860L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000865L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000870L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000875L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000880L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000885L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000890L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000895L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000900L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000905L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000910L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000915L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000920L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000925L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000930L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000935L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000940L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000945L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000950L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000955L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000960L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000965L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000970L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000975L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000980L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000985L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000990L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711000995L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001000L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001005L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001010L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001015L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001020L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001025L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001030L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001035L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001040L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001045L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001050L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001055L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001060L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001065L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001070L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001075L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001080L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001085L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001090L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001095L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001100L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001105L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001110L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001115L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001120L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001125L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001130L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001135L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001140L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001145L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001150L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001155L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001160L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001165L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001170L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001175L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001180L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001185L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001190L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001195L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001200L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001205L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001210L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001215L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001220L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001225L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001230L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001235L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001240L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001245L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001250L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001255L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001260L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001265L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001270L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001275L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001280L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001285L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001290L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001295L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001300L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001305L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001310L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001315L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001320L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001325L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001330L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001335L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001340L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001345L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001350L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001355L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001360L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001365L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001370L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001375L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001380L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001385L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001390L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001395L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001400L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001405L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001410L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001415L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001420L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001425L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001430L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001435L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001440L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001445L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001450L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001455L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001460L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001465L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001470L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001475L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001480L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001485L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001490L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001495L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001500L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001505L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001510L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001515L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001520L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001525L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001530L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001535L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001540L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001545L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001550L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001555L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001560L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001565L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001570L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001575L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001580L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001585L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001590L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001595L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001600L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001605L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001610L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001615L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001620L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001625L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001630L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001635L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001640L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001645L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001650L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001655L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001660L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001665L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001670L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001675L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001680L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001685L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001690L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001695L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001700L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001705L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001710L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001715L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001720L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001725L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001730L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001735L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001740L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001745L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001750L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001755L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001760L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001765L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001770L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001775L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001780L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001785L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001790L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001795L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001800L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001805L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001810L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001815L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001820L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001825L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001830L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001835L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001840L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001845L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001850L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001855L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001860L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001865L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001870L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001875L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001880L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001885L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001890L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001895L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001900L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001905L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001910L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001915L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001920L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001925L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001930L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001935L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001940L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001945L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001950L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001955L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001960L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001965L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001970L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001975L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001980L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001985L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001990L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711001995L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002000L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002005L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002010L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002015L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002020L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002025L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002030L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002035L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002040L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002045L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002050L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002055L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002060L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002065L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002070L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002075L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002080L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002085L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002090L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002095L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002100L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002105L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002110L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002115L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002120L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002125L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002130L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002135L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002140L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002145L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002150L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002155L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002160L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002165L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002170L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002175L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002180L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002185L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002190L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002195L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002200L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002205L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002210L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002215L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002220L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002225L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002230L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002235L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002240L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002245L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002250L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002255L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002260L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002265L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002270L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002275L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002280L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002285L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002290L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002295L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002300L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002305L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002310L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002315L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002320L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002325L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002330L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002335L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002340L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002345L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002350L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002355L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002360L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002365L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002370L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002375L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002380L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002385L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002390L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002395L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002400L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002405L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002410L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002415L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002420L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002425L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002430L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002435L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002440L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002445L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002450L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002455L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002460L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002465L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002470L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002475L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002480L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002485L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002490L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002495L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002500L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002505L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002510L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002515L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002520L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002525L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002530L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002535L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002540L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002545L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002550L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002555L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002560L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002565L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002570L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002575L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002580L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002585L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002590L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002595L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002600L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002605L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002610L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002615L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002620L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002625L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002630L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002635L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002640L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002645L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002650L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002655L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002660L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002665L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002670L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002675L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002680L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002685L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002690L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002695L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002700L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002705L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002710L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002715L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002720L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002725L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002730L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002735L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002740L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002745L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002750L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002755L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002760L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002765L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002770L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002775L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002780L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002785L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002790L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002795L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002800L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002805L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002810L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002815L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002820L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002825L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002830L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002835L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002840L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002845L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002850L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002855L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002860L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002865L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002870L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002875L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002880L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002885L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002890L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002895L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002900L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002902L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002905L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002910L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002915L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002920L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002925L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002930L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002935L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002940L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002945L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002950L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002955L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002960L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002965L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002970L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002975L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002980L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002985L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002990L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711002995L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003000L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003005L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003010L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003015L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003020L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003025L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003030L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003035L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003040L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003045L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003050L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003055L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003060L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003065L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003070L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003075L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003080L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003085L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003090L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003095L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003100L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003105L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003110L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003115L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003120L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003125L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003130L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003135L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003140L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003145L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003150L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003155L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003160L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003165L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003170L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003175L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003180L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003185L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003190L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003195L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003200L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003205L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003210L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003215L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003220L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003225L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003230L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003235L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003240L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003245L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003250L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003255L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003260L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003265L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003270L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003275L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003280L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003285L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003290L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003295L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003300L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003305L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003310L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003315L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003320L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003325L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003330L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003335L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003340L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003345L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003350L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003355L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003360L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003365L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003370L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003375L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003380L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003385L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003390L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003395L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003400L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003405L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003410L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003415L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003420L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003425L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003430L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003435L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003440L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003445L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003450L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003455L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003460L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003465L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003470L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003475L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003480L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003485L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003490L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003495L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003500L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003505L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003510L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003515L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003520L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003525L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003530L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003535L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003540L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003545L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003550L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003555L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003560L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003565L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003570L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003575L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003580L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003585L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003590L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003595L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003600L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003605L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003610L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003620L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003625L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003630L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003635L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003640L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003645L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003650L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003655L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003660L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003665L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003670L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003675L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003680L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003685L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003690L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003695L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003700L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003705L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003710L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003715L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003720L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003725L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003730L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003735L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003740L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003745L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003750L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003755L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003760L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003765L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003770L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003775L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003780L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003785L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003790L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003795L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003800L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003805L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003810L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003815L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003820L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003825L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003830L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003835L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003840L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003845L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003850L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003855L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003860L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003865L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003870L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003875L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003880L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003885L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003890L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003895L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003900L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003905L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003910L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003915L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003920L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003925L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003930L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003935L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003940L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003945L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003950L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003955L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003960L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003965L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003970L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003975L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003980L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003985L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003990L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711003995L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004000L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004005L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004010L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004015L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004020L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004025L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004030L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004035L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004040L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004045L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004050L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004055L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004060L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004065L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004070L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004075L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004080L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004085L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004090L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004095L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004100L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004105L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004110L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004115L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004120L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004125L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004130L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004135L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004140L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004145L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004150L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004155L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004160L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004162L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004165L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004167L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004170L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004175L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004180L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004185L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004190L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004195L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004200L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004205L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004210L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004215L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004220L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004225L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004230L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004235L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004240L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004245L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004250L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004255L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004260L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004265L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004270L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004275L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004280L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004285L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004290L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004295L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004300L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004305L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004310L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004315L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004320L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004325L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004330L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004335L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004340L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004345L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004350L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004355L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004360L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004365L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004370L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004375L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004380L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004385L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004390L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004395L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004400L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004405L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004410L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004415L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004420L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004425L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004430L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004435L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004440L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004445L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004450L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004455L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004460L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004465L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004470L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004475L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004480L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004485L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004490L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004495L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004500L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004505L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004510L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004515L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004520L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004525L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004530L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004535L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004540L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004545L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004550L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004555L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004560L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004565L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004570L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004575L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004580L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004585L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004590L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004595L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004600L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004605L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004610L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004615L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004620L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004625L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004630L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004635L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004640L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004645L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004650L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004655L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004660L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004665L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004670L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004675L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004680L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004685L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004690L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004695L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004700L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004705L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004710L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004715L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004720L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004725L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004730L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004735L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004740L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004745L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004750L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004755L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004760L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004765L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004770L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004775L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004780L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004785L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004790L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004795L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004800L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004805L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004810L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004815L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004820L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004825L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004830L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004835L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004840L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004845L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004850L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004855L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004860L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004865L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004870L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004875L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004880L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004885L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004890L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004895L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004900L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004905L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004910L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004915L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004920L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004925L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004930L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004935L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004940L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004945L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004950L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004955L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004960L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004965L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004970L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004975L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004980L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004985L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004990L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711004995L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005000L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005005L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005010L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005015L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005020L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005025L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005030L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005035L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005040L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005045L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005050L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005055L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005060L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005065L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005070L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005075L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005080L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005085L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005090L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005095L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005100L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005105L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005110L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005115L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005120L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005125L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005130L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005135L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005140L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005145L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005150L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005155L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005160L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005165L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005170L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005175L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005180L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005185L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005190L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005195L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005200L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005205L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005210L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005215L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005220L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005225L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005230L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005235L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005240L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005245L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005250L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005255L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005260L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005265L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005270L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005275L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005280L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005285L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005290L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005295L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005300L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005305L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005310L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005315L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005320L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005325L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005330L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005335L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005340L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005345L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005350L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005355L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005360L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005365L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005370L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005375L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005380L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005385L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005390L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005395L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005400L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005405L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005410L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005415L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005420L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005425L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005430L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005435L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005440L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005445L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005450L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005455L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005460L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005465L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005470L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005475L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005480L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005485L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005490L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005495L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005500L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005505L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005510L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005515L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005520L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005525L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005530L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005535L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005540L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005545L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005550L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005555L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005560L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005565L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005570L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005575L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005580L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005585L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005590L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005595L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005600L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005605L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005610L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005615L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005620L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005625L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005630L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005635L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005640L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005645L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005650L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005655L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005660L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005665L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005670L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005675L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005680L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005685L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005690L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005695L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005700L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005705L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005710L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005715L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005720L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005725L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005730L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005735L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005740L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005745L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005750L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005755L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005760L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005765L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005770L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005775L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005780L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005785L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005790L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005795L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005800L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005805L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005810L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005815L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005820L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005825L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005830L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005835L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005840L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005845L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005850L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005855L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005860L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005865L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005870L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005875L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005880L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005885L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005890L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005895L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005900L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005905L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005910L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005915L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005920L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005925L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005930L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005935L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005940L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005945L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005950L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005955L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005960L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005965L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005970L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005975L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005980L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005985L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005990L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711005995L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006000L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006005L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006010L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006015L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006020L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006025L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006030L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006035L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006040L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006045L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006050L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006055L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006060L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006065L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006070L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006075L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006080L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006085L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006090L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006095L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006100L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006105L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006110L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006115L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006120L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006125L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006130L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006135L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006140L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006145L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006150L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006155L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006160L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006165L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006170L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006175L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006180L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006185L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006190L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006195L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006200L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006205L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006210L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006215L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006220L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006225L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006230L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006235L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006240L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006245L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006250L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006255L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006260L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006265L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006270L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006275L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006280L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006285L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006290L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006295L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006300L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006305L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006310L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006315L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006320L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006325L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006330L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006335L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006340L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006345L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006350L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006355L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006360L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006365L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006370L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006375L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006380L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006385L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006390L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006395L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006400L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006405L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006410L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006415L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006420L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006425L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006430L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006435L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006440L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006445L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006450L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006455L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006460L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006465L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006470L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006475L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006480L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006485L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006490L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006495L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006500L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006505L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006510L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006515L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006520L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006525L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006530L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006535L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006540L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006545L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006550L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006555L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006560L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006565L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006570L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006575L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006580L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006585L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006590L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006595L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006600L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006605L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006610L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006615L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006620L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006625L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006630L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006635L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006640L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006645L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006650L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006655L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006660L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006665L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006670L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006675L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006680L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006685L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006690L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006695L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006700L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006705L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006710L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006715L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006720L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006725L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006730L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006735L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006740L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006745L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006750L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006755L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006760L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006765L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006770L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006775L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006780L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006782L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006785L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006790L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006795L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006800L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006805L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006810L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006815L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006820L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006825L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006830L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006835L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006840L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006845L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006850L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006855L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006860L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006865L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006870L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006875L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006880L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006885L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006890L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006895L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006900L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006905L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006910L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006915L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006920L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006925L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006930L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006935L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006940L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006945L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006950L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006955L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006960L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006965L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006970L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006975L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006980L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006985L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006990L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711006995L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007000L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007005L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007010L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007015L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007020L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007025L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007030L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007035L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007040L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007045L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007050L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007055L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007060L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007065L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007070L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007075L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007080L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007085L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007090L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007095L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007100L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007105L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007110L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007115L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007120L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007125L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007130L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007135L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007140L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007145L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007150L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007155L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007160L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007165L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007170L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007175L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007180L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007185L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007190L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007195L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007200L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007205L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007210L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007215L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007220L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007225L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007230L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007235L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007240L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007245L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007250L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007255L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007260L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007265L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007270L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007275L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007280L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007285L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007290L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007295L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007300L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007305L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007310L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007315L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007320L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007325L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007330L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007335L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007340L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007345L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007350L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007355L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007360L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007365L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007370L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007375L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007380L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007385L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007390L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007395L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007400L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007405L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007410L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007415L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007420L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007425L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007430L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007435L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007440L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007445L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007450L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007455L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007460L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007465L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007470L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007475L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007480L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007485L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007490L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007495L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007500L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007505L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007510L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007515L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007520L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007525L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007530L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007535L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007540L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007545L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007550L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007555L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007560L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007565L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007570L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007575L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007580L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007585L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007590L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007595L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007600L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007605L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007610L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007615L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007620L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007625L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007630L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007635L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007640L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007645L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007650L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007655L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007660L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007665L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007670L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007675L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007680L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007685L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007690L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007695L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007700L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007705L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007710L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007715L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007720L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007725L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007730L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007735L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007740L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007745L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007750L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007755L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007760L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007765L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007770L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007775L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007780L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007785L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007790L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007795L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007800L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007805L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007810L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007815L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007820L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007825L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007830L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007835L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007840L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007845L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007850L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007855L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007860L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007865L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007870L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007875L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007880L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007885L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007890L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007892L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007895L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007900L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007905L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007910L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007915L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007920L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007925L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007930L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007935L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007940L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007945L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007950L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007955L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007960L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007965L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007970L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007975L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007980L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007985L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007990L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711007995L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711008000L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711008005L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711008010L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711008015L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711008020L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711099936L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635711099995L);
        }
    }
}
