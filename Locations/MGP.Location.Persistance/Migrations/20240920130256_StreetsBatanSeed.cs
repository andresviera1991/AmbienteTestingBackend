using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MGP.Location.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class StreetsBatanSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Street",
                columns: new[] { "Id", "Category", "EndHeightLeft", "EndHeightRight", "FullName", "LocalityId", "Name", "Source", "StartHeightLeft", "StartHeightRight" },
                values: new object[,]
                {
                    { 635707000005L, "CALLE", 0, 0, "ALEJANDRO VOLTA, Buenos Aires, General Pueyrredón", 6357070L, "ALEJANDRO VOLTA", "INDEC", 0, 0 },
                    { 635707000010L, "CALLE", 0, 0, "ALFREDO L PALACIOS, Buenos Aires, General Pueyrredón", 6357070L, "ALFREDO L PALACIOS", "INDEC", 0, 0 },
                    { 635707000015L, "CALLE", 3699, 3798, "ALFREDO PALACIOS CALLE 27, Buenos Aires, General Pueyrredón", 6357070L, "ALFREDO PALACIOS CALLE 27", "INDEC", 0, 3300 },
                    { 635707000020L, "CALLE", 0, 0, "ALGEL VICENTE PENALOZA, Buenos Aires, General Pueyrredón", 6357070L, "ALGEL VICENTE PENALOZA", "INDEC", 0, 0 },
                    { 635707000025L, "CALLE", 0, 0, "ALICIA MOREAU DE JUSTO, Buenos Aires, General Pueyrredón", 6357070L, "ALICIA MOREAU DE JUSTO", "INDEC", 0, 0 },
                    { 635707000030L, "CALLE", 3699, 3698, "ALICIA MOREAU DE JUSTO CALLE 29, Buenos Aires, General Pueyrredón", 6357070L, "ALICIA MOREAU DE JUSTO CALLE 29", "INDEC", 2900, 3300 },
                    { 635707000035L, "CALLE", 0, 0, "AMALIA V DE BALLINA, Buenos Aires, General Pueyrredón", 6357070L, "AMALIA V DE BALLINA", "INDEC", 0, 0 },
                    { 635707000040L, "CALLE", 0, 0, "ANIBAL TROILO PICHUCO, Buenos Aires, General Pueyrredón", 6357070L, "ANIBAL TROILO PICHUCO", "INDEC", 0, 0 },
                    { 635707000045L, "CALLE", 0, 0, "ANTONIO MACHADO, Buenos Aires, General Pueyrredón", 6357070L, "ANTONIO MACHADO", "INDEC", 0, 0 },
                    { 635707000050L, "CALLE", 0, 0, "ATAHUALPA YUPANQUI, Buenos Aires, General Pueyrredón", 6357070L, "ATAHUALPA YUPANQUI", "INDEC", 0, 0 },
                    { 635707000055L, "AV", 0, 0, "AV LIBERTADOR GRAL SAN MARTIN, Buenos Aires, General Pueyrredón", 6357070L, "AV LIBERTADOR GRAL SAN MARTIN", "INDEC", 0, 0 },
                    { 635707000060L, "AV", 0, 0, "AV PRESIDENTE PERON, Buenos Aires, General Pueyrredón", 6357070L, "AV PRESIDENTE PERON", "INDEC", 0, 0 },
                    { 635707000065L, "CALLE", 0, 0, "BALDOMERO FERNANDEZ MORENO, Buenos Aires, General Pueyrredón", 6357070L, "BALDOMERO FERNANDEZ MORENO", "INDEC", 0, 0 },
                    { 635707000070L, "CALLE", 0, 0, "BALTAZAR DEMATTEI, Buenos Aires, General Pueyrredón", 6357070L, "BALTAZAR DEMATTEI", "INDEC", 0, 0 },
                    { 635707000075L, "CALLE", 0, 0, "BRONZINI, Buenos Aires, General Pueyrredón", 6357070L, "BRONZINI", "INDEC", 0, 0 },
                    { 635707000080L, "CALLE", 0, 0, "CALLE 105, Buenos Aires, General Pueyrredón", 6357070L, "CALLE 105", "INDEC", 0, 0 },
                    { 635707000085L, "CALLE", 0, 0, "CALLE 120 BATAN, Buenos Aires, General Pueyrredón", 6357070L, "CALLE 120 BATAN", "INDEC", 0, 0 },
                    { 635707000090L, "CALLE", 3, 0, "CALLE 126 RICARDO BALBIN, Buenos Aires, General Pueyrredón", 6357070L, "CALLE 126 RICARDO BALBIN", "INDEC", 0, 0 },
                    { 635707000095L, "CALLE", 0, 0, "CALLE 128, Buenos Aires, General Pueyrredón", 6357070L, "CALLE 128", "INDEC", 0, 0 },
                    { 635707000100L, "CALLE", 0, 0, "CALLE 130, Buenos Aires, General Pueyrredón", 6357070L, "CALLE 130", "INDEC", 0, 0 },
                    { 635707000105L, "CALLE", 0, 0, "CALLE 133, Buenos Aires, General Pueyrredón", 6357070L, "CALLE 133", "INDEC", 0, 0 },
                    { 635707000110L, "CALLE", 0, 0, "CALLE 136, Buenos Aires, General Pueyrredón", 6357070L, "CALLE 136", "INDEC", 0, 0 },
                    { 635707000115L, "CALLE", 0, 0, "CALLE 142, Buenos Aires, General Pueyrredón", 6357070L, "CALLE 142", "INDEC", 0, 0 },
                    { 635707000120L, "CALLE", 0, 0, "CALLE 149, Buenos Aires, General Pueyrredón", 6357070L, "CALLE 149", "INDEC", 0, 0 },
                    { 635707000125L, "CALLE", 0, 0, "CALLE 157, Buenos Aires, General Pueyrredón", 6357070L, "CALLE 157", "INDEC", 0, 0 },
                    { 635707000130L, "CALLE", 0, 0, "CALLE 159, Buenos Aires, General Pueyrredón", 6357070L, "CALLE 159", "INDEC", 0, 0 },
                    { 635707000135L, "CALLE", 0, 0, "CALLE 160, Buenos Aires, General Pueyrredón", 6357070L, "CALLE 160", "INDEC", 0, 0 },
                    { 635707000140L, "CALLE", 0, 0, "CALLE 163, Buenos Aires, General Pueyrredón", 6357070L, "CALLE 163", "INDEC", 0, 0 },
                    { 635707000145L, "CALLE", 0, 0, "CALLE 170, Buenos Aires, General Pueyrredón", 6357070L, "CALLE 170", "INDEC", 0, 0 },
                    { 635707000150L, "CALLE", 0, 0, "CALLE 171, Buenos Aires, General Pueyrredón", 6357070L, "CALLE 171", "INDEC", 0, 0 },
                    { 635707000155L, "CALLE", 0, 0, "CALLE 177, Buenos Aires, General Pueyrredón", 6357070L, "CALLE 177", "INDEC", 0, 0 },
                    { 635707000160L, "CALLE", 0, 0, "CALLE 33B, Buenos Aires, General Pueyrredón", 6357070L, "CALLE 33B", "INDEC", 0, 0 },
                    { 635707000165L, "CALLE", 0, 0, "CALLE 35, Buenos Aires, General Pueyrredón", 6357070L, "CALLE 35", "INDEC", 0, 0 },
                    { 635707000170L, "CALLE", 0, 0, "CALLE 35B, Buenos Aires, General Pueyrredón", 6357070L, "CALLE 35B", "INDEC", 0, 0 },
                    { 635707000175L, "CALLE", 0, 0, "CALLE 39, Buenos Aires, General Pueyrredón", 6357070L, "CALLE 39", "INDEC", 0, 0 },
                    { 635707000180L, "CALLE", 0, 0, "CALLE 41, Buenos Aires, General Pueyrredón", 6357070L, "CALLE 41", "INDEC", 0, 0 },
                    { 635707000185L, "CALLE", 0, 0, "CALLE 42, Buenos Aires, General Pueyrredón", 6357070L, "CALLE 42", "INDEC", 0, 0 },
                    { 635707000190L, "CALLE", 0, 0, "CALLE 44, Buenos Aires, General Pueyrredón", 6357070L, "CALLE 44", "INDEC", 0, 0 },
                    { 635707000195L, "CALLE", 0, 0, "CALLE 46, Buenos Aires, General Pueyrredón", 6357070L, "CALLE 46", "INDEC", 0, 0 },
                    { 635707000200L, "CALLE", 0, 0, "CALLE 48, Buenos Aires, General Pueyrredón", 6357070L, "CALLE 48", "INDEC", 0, 0 },
                    { 635707000205L, "CALLE", 0, 0, "CALLE 50, Buenos Aires, General Pueyrredón", 6357070L, "CALLE 50", "INDEC", 0, 0 },
                    { 635707000210L, "CALLE", 0, 0, "CALLE 51, Buenos Aires, General Pueyrredón", 6357070L, "CALLE 51", "INDEC", 0, 0 },
                    { 635707000215L, "CALLE", 0, 0, "CALLE 52, Buenos Aires, General Pueyrredón", 6357070L, "CALLE 52", "INDEC", 0, 0 },
                    { 635707000220L, "CALLE", 0, 0, "CALLE 53, Buenos Aires, General Pueyrredón", 6357070L, "CALLE 53", "INDEC", 0, 0 },
                    { 635707000225L, "CALLE", 0, 0, "CALLE 54, Buenos Aires, General Pueyrredón", 6357070L, "CALLE 54", "INDEC", 0, 0 },
                    { 635707000230L, "CALLE", 0, 0, "CALLE 58, Buenos Aires, General Pueyrredón", 6357070L, "CALLE 58", "INDEC", 0, 0 },
                    { 635707000235L, "CALLE", 0, 0, "CALLE 60, Buenos Aires, General Pueyrredón", 6357070L, "CALLE 60", "INDEC", 0, 0 },
                    { 635707000240L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357070L, "CALLE SN", "INDEC", 0, 0 },
                    { 635707000245L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357070L, "CALLE SN", "INDEC", 0, 0 },
                    { 635707000250L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357070L, "CALLE SN", "INDEC", 0, 0 },
                    { 635707000255L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357070L, "CALLE SN", "INDEC", 0, 0 },
                    { 635707000260L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357070L, "CALLE SN", "INDEC", 0, 0 },
                    { 635707000265L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357070L, "CALLE SN", "INDEC", 0, 0 },
                    { 635707000270L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357070L, "CALLE SN", "INDEC", 0, 0 },
                    { 635707000275L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357070L, "CALLE SN", "INDEC", 0, 0 },
                    { 635707000280L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357070L, "CALLE SN", "INDEC", 0, 0 },
                    { 635707000285L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357070L, "CALLE SN", "INDEC", 0, 0 },
                    { 635707000290L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357070L, "CALLE SN", "INDEC", 0, 0 },
                    { 635707000295L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357070L, "CALLE SN", "INDEC", 0, 0 },
                    { 635707000300L, "CALLE", 0, 0, "CARLOS SAAVEDRA LAMAS, Buenos Aires, General Pueyrredón", 6357070L, "CARLOS SAAVEDRA LAMAS", "INDEC", 0, 0 },
                    { 635707000305L, "CALLE", 0, 0, "CELESTINO GALDOS, Buenos Aires, General Pueyrredón", 6357070L, "CELESTINO GALDOS", "INDEC", 0, 0 },
                    { 635707000310L, "CALLE", 0, 0, "COLECTORA, Buenos Aires, General Pueyrredón", 6357070L, "COLECTORA", "INDEC", 0, 0 },
                    { 635707000315L, "RUTA", 0, 0, "COLECTORA RUTA 88, Buenos Aires, General Pueyrredón", 6357070L, "COLECTORA RUTA 88", "INDEC", 0, 0 },
                    { 635707000320L, "CALLE", 0, 0, "D BATAN CALLE 37, Buenos Aires, General Pueyrredón", 6357070L, "D BATAN CALLE 37", "INDEC", 0, 0 },
                    { 635707000325L, "CALLE", 0, 0, "DIAG MAR DEL PLATA, Buenos Aires, General Pueyrredón", 6357070L, "DIAG MAR DEL PLATA", "INDEC", 0, 0 },
                    { 635707000330L, "CALLE", 0, 0, "DOLORES MORA, Buenos Aires, General Pueyrredón", 6357070L, "DOLORES MORA", "INDEC", 0, 0 },
                    { 635707000335L, "CALLE", 0, 0, "DR RICARDO BALBIN CALLE 44, Buenos Aires, General Pueyrredón", 6357070L, "DR RICARDO BALBIN CALLE 44", "INDEC", 0, 0 },
                    { 635707000340L, "CALLE", 0, 0, "EA SAN JUSTO, Buenos Aires, General Pueyrredón", 6357070L, "EA SAN JUSTO", "INDEC", 0, 0 },
                    { 635707000345L, "CALLE", 0, 0, "EDUARDO MALLEA, Buenos Aires, General Pueyrredón", 6357070L, "EDUARDO MALLEA", "INDEC", 0, 0 },
                    { 635707000350L, "CALLE", 0, 0, "EL AMERICANO, Buenos Aires, General Pueyrredón", 6357070L, "EL AMERICANO", "INDEC", 0, 0 },
                    { 635707000355L, "CALLE", 0, 0, "EL COLMENAR, Buenos Aires, General Pueyrredón", 6357070L, "EL COLMENAR", "INDEC", 0, 0 },
                    { 635707000360L, "CALLE", 0, 0, "EMILIO SALGARI, Buenos Aires, General Pueyrredón", 6357070L, "EMILIO SALGARI", "INDEC", 0, 0 },
                    { 635707000365L, "CALLE", 0, 0, "EMMA GEMOLI DE OLIVA, Buenos Aires, General Pueyrredón", 6357070L, "EMMA GEMOLI DE OLIVA", "INDEC", 0, 0 },
                    { 635707000370L, "CALLE", 0, 0, "ENRRIQUE LARRETA, Buenos Aires, General Pueyrredón", 6357070L, "ENRRIQUE LARRETA", "INDEC", 0, 0 },
                    { 635707000375L, "CALLE", 0, 0, "ESTANCIA SAN CIPRIANO, Buenos Aires, General Pueyrredón", 6357070L, "ESTANCIA SAN CIPRIANO", "INDEC", 0, 0 },
                    { 635707000380L, "CALLE", 0, 0, "ESTANISLAO DEL CAMPO, Buenos Aires, General Pueyrredón", 6357070L, "ESTANISLAO DEL CAMPO", "INDEC", 0, 0 },
                    { 635707000385L, "CALLE", 0, 0, "ESTEBAN ANGEL BONANNI, Buenos Aires, General Pueyrredón", 6357070L, "ESTEBAN ANGEL BONANNI", "INDEC", 0, 0 },
                    { 635707000390L, "CALLE", 3199, 3198, "EVA DUARTE CALLE 40, Buenos Aires, General Pueyrredón", 6357070L, "EVA DUARTE CALLE 40", "INDEC", 0, 0 },
                    { 635707000395L, "CALLE", 0, 0, "EVA DUARTE DE PERON - 124, Buenos Aires, General Pueyrredón", 6357070L, "EVA DUARTE DE PERON - 124", "INDEC", 0, 0 },
                    { 635707000400L, "CALLE", 0, 0, "FRANCISCO ALVAREZ, Buenos Aires, General Pueyrredón", 6357070L, "FRANCISCO ALVAREZ", "INDEC", 0, 0 },
                    { 635707000405L, "CALLE", 0, 0, "GABRIELA MISTRAL, Buenos Aires, General Pueyrredón", 6357070L, "GABRIELA MISTRAL", "INDEC", 0, 0 },
                    { 635707000410L, "CALLE", 0, 0, "GLORIA TREJON DE LOPEZ, Buenos Aires, General Pueyrredón", 6357070L, "GLORIA TREJON DE LOPEZ", "INDEC", 0, 0 },
                    { 635707000415L, "CALLE", 0, 0, "GUILLERMO VAN HEDEN, Buenos Aires, General Pueyrredón", 6357070L, "GUILLERMO VAN HEDEN", "INDEC", 0, 0 },
                    { 635707000420L, "CALLE", 0, 0, "HERNAN CORTES, Buenos Aires, General Pueyrredón", 6357070L, "HERNAN CORTES", "INDEC", 0, 0 },
                    { 635707000425L, "CALLE", 0, 0, "HEROES DE MALVINAS, Buenos Aires, General Pueyrredón", 6357070L, "HEROES DE MALVINAS", "INDEC", 0, 0 },
                    { 635707000430L, "CALLE", 0, 0, "HUGO DEL CARRIL, Buenos Aires, General Pueyrredón", 6357070L, "HUGO DEL CARRIL", "INDEC", 0, 0 },
                    { 635707000435L, "CALLE", 0, 0, "HUGO DEL CARRIL CALLE 50, Buenos Aires, General Pueyrredón", 6357070L, "HUGO DEL CARRIL CALLE 50", "INDEC", 0, 0 },
                    { 635707000440L, "CALLE", 0, 0, "JORGE AVALOS, Buenos Aires, General Pueyrredón", 6357070L, "JORGE AVALOS", "INDEC", 0, 0 },
                    { 635707000445L, "CALLE", 0, 0, "JORGE CAFRUNE, Buenos Aires, General Pueyrredón", 6357070L, "JORGE CAFRUNE", "INDEC", 0, 0 },
                    { 635707000450L, "CALLE", 0, 0, "JUAN D PERON CALLE 35, Buenos Aires, General Pueyrredón", 6357070L, "JUAN D PERON CALLE 35", "INDEC", 0, 0 },
                    { 635707000455L, "CALLE", 0, 0, "JUAN FACUNDO QUIROGA, Buenos Aires, General Pueyrredón", 6357070L, "JUAN FACUNDO QUIROGA", "INDEC", 0, 0 },
                    { 635707000460L, "CALLE", 0, 0, "JUAN JAUREGUI, Buenos Aires, General Pueyrredón", 6357070L, "JUAN JAUREGUI", "INDEC", 0, 0 },
                    { 635707000465L, "CALLE", 3099, 3198, "JUAN M DE ROSAS CALLE 42, Buenos Aires, General Pueyrredón", 6357070L, "JUAN M DE ROSAS CALLE 42", "INDEC", 0, 0 },
                    { 635707000470L, "CALLE", 0, 0, "JUANA DE IBARBOUROU, Buenos Aires, General Pueyrredón", 6357070L, "JUANA DE IBARBOUROU", "INDEC", 0, 0 },
                    { 635707000475L, "CALLE", 0, 0, "JULIAN RIOS, Buenos Aires, General Pueyrredón", 6357070L, "JULIAN RIOS", "INDEC", 0, 0 },
                    { 635707000480L, "CALLE", 3799, 3598, "JULIAN RIOS CALLE 31, Buenos Aires, General Pueyrredón", 6357070L, "JULIAN RIOS CALLE 31", "INDEC", 0, 0 },
                    { 635707000485L, "CALLE", 0, 0, "JULIO CORTAZAR, Buenos Aires, General Pueyrredón", 6357070L, "JULIO CORTAZAR", "INDEC", 0, 0 },
                    { 635707000490L, "CALLE", 0, 0, "LA SERRANA, Buenos Aires, General Pueyrredón", 6357070L, "LA SERRANA", "INDEC", 0, 0 },
                    { 635707000495L, "CALLE", 3599, 0, "LARRAYA CALLE 33, Buenos Aires, General Pueyrredón", 6357070L, "LARRAYA CALLE 33", "INDEC", 0, 0 },
                    { 635707000500L, "CALLE", 0, 0, "LAS ALAMEDAS, Buenos Aires, General Pueyrredón", 6357070L, "LAS ALAMEDAS", "INDEC", 0, 0 },
                    { 635707000505L, "CALLE", 3599, 0, "LAS CHARITAS, Buenos Aires, General Pueyrredón", 6357070L, "LAS CHARITAS", "INDEC", 0, 0 },
                    { 635707000510L, "CALLE", 0, 0, "LAS LOMAS, Buenos Aires, General Pueyrredón", 6357070L, "LAS LOMAS", "INDEC", 0, 0 },
                    { 635707000515L, "CALLE", 0, 0, "LOS ORTIZ, Buenos Aires, General Pueyrredón", 6357070L, "LOS ORTIZ", "INDEC", 0, 0 },
                    { 635707000520L, "CALLE", 0, 0, "LUCIO VARELA, Buenos Aires, General Pueyrredón", 6357070L, "LUCIO VARELA", "INDEC", 0, 0 },
                    { 635707000525L, "CALLE", 0, 0, "LUIS LELOIR, Buenos Aires, General Pueyrredón", 6357070L, "LUIS LELOIR", "INDEC", 0, 0 },
                    { 635707000530L, "CALLE", 0, 0, "MACACHA GUEMES, Buenos Aires, General Pueyrredón", 6357070L, "MACACHA GUEMES", "INDEC", 0, 0 },
                    { 635707000535L, "CALLE", 0, 0, "MARTIN ALONSO PINZON, Buenos Aires, General Pueyrredón", 6357070L, "MARTIN ALONSO PINZON", "INDEC", 0, 0 },
                    { 635707000540L, "CALLE", 0, 0, "MONTE MALABRIGO, Buenos Aires, General Pueyrredón", 6357070L, "MONTE MALABRIGO", "INDEC", 0, 0 },
                    { 635707000545L, "CALLE", 0, 0, "NICOLAS DAZEO, Buenos Aires, General Pueyrredón", 6357070L, "NICOLAS DAZEO", "INDEC", 0, 0 },
                    { 635707000550L, "CALLE", 3399, 0, "ORO NEGRO CALLE 36, Buenos Aires, General Pueyrredón", 6357070L, "ORO NEGRO CALLE 36", "INDEC", 0, 0 },
                    { 635707000555L, "PJE", 0, 0, "PJE SN, Buenos Aires, General Pueyrredón", 6357070L, "PJE SN", "INDEC", 0, 0 },
                    { 635707000560L, "CALLE", 0, 0, "PLACIDO GARCIA, Buenos Aires, General Pueyrredón", 6357070L, "PLACIDO GARCIA", "INDEC", 0, 0 },
                    { 635707000565L, "CALLE", 0, 0, "PURA SAGASTA, Buenos Aires, General Pueyrredón", 6357070L, "PURA SAGASTA", "INDEC", 0, 0 },
                    { 635707000570L, "CALLE", 0, 0, "RAFAEL OBLIGADO, Buenos Aires, General Pueyrredón", 6357070L, "RAFAEL OBLIGADO", "INDEC", 0, 0 },
                    { 635707000575L, "CALLE", 0, 0, "REGINA PACINI DE ALVEAR, Buenos Aires, General Pueyrredón", 6357070L, "REGINA PACINI DE ALVEAR", "INDEC", 0, 0 },
                    { 635707000580L, "CALLE", 0, 0, "SALVADOR ALLENDE CALLE 46, Buenos Aires, General Pueyrredón", 6357070L, "SALVADOR ALLENDE CALLE 46", "INDEC", 0, 0 },
                    { 635707000585L, "CALLE", 0, 0, "TEODORO J BRONZINI, Buenos Aires, General Pueyrredón", 6357070L, "TEODORO J BRONZINI", "INDEC", 0, 0 },
                    { 635707000590L, "CALLE", 0, 0, "VILLA GUSTAVA - 122, Buenos Aires, General Pueyrredón", 6357070L, "VILLA GUSTAVA - 122", "INDEC", 0, 0 },
                    { 635707000595L, "CALLE", 3199, 3198, "VILLA GUSTAVA CALLE 38, Buenos Aires, General Pueyrredón", 6357070L, "VILLA GUSTAVA CALLE 38", "INDEC", 0, 0 },
                    { 635707000600L, "CALLE", 3499, 3498, "VIOLETA PARRA, Buenos Aires, General Pueyrredón", 6357070L, "VIOLETA PARRA", "INDEC", 0, 0 },
                    { 635707000605L, "CALLE", 3599, 3598, "VIOLETA PARRA CALLE 25, Buenos Aires, General Pueyrredón", 6357070L, "VIOLETA PARRA CALLE 25", "INDEC", 3301, 3300 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635707000005L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635707000010L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635707000015L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635707000020L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635707000025L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635707000030L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635707000035L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635707000040L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635707000045L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635707000050L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635707000055L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635707000060L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635707000065L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635707000070L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635707000075L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635707000080L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635707000085L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635707000090L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635707000095L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635707000100L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635707000105L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635707000110L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635707000115L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635707000120L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635707000125L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635707000130L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635707000135L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635707000140L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635707000145L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635707000150L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635707000155L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635707000160L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635707000165L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635707000170L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635707000175L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635707000180L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635707000185L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635707000190L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635707000195L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635707000200L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635707000205L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635707000210L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635707000215L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635707000220L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635707000225L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635707000230L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635707000235L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635707000240L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635707000245L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635707000250L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635707000255L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635707000260L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635707000265L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635707000270L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635707000275L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635707000280L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635707000285L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635707000290L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635707000295L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635707000300L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635707000305L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635707000310L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635707000315L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635707000320L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635707000325L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635707000330L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635707000335L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635707000340L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635707000345L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635707000350L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635707000355L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635707000360L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635707000365L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635707000370L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635707000375L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635707000380L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635707000385L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635707000390L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635707000395L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635707000400L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635707000405L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635707000410L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635707000415L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635707000420L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635707000425L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635707000430L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635707000435L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635707000440L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635707000445L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635707000450L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635707000455L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635707000460L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635707000465L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635707000470L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635707000475L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635707000480L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635707000485L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635707000490L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635707000495L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635707000500L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635707000505L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635707000510L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635707000515L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635707000520L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635707000525L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635707000530L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635707000535L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635707000540L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635707000545L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635707000550L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635707000555L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635707000560L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635707000565L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635707000570L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635707000575L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635707000580L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635707000585L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635707000590L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635707000595L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635707000600L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635707000605L);
        }
    }
}
