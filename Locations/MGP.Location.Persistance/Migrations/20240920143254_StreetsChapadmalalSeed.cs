using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MGP.Location.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class StreetsChapadmalalSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Street",
                columns: new[] { "Id", "Category", "EndHeightLeft", "EndHeightRight", "FullName", "LocalityId", "Name", "Source", "StartHeightLeft", "StartHeightRight" },
                values: new object[,]
                {
                    { 635708000005L, "CALLE", 0, 0, "821, Buenos Aires, General Pueyrredón", 6357080L, "821", "INDEC", 0, 0 },
                    { 635708000010L, "CALLE", 0, 0, "ALE PUE, Buenos Aires, General Pueyrredón", 6357080L, "ALE PUE", "INDEC", 0, 0 },
                    { 635708000015L, "CALLE", 0, 0, "ANKEN LEUFU, Buenos Aires, General Pueyrredón", 6357080L, "ANKEN LEUFU", "INDEC", 0, 0 },
                    { 635708000020L, "CALLE", 0, 0, "ARAUCANOS, Buenos Aires, General Pueyrredón", 6357080L, "ARAUCANOS", "INDEC", 0, 0 },
                    { 635708000025L, "AV", 1299, 1298, "AV DE LOS LOBOS MARINOS, Buenos Aires, General Pueyrredón", 6357080L, "AV DE LOS LOBOS MARINOS", "INDEC", 0, 0 },
                    { 635708000030L, "CALLE", 0, 0, "CALE RUMENCO, Buenos Aires, General Pueyrredón", 6357080L, "CALE RUMENCO", "INDEC", 0, 0 },
                    { 635708000035L, "CALLE", 8199, 0, "CALLE 0, Buenos Aires, General Pueyrredón", 6357080L, "CALLE 0", "INDEC", 0, 0 },
                    { 635708000040L, "CALLE", 0, 0, "CALLE 10, Buenos Aires, General Pueyrredón", 6357080L, "CALLE 10", "INDEC", 0, 0 },
                    { 635708000045L, "CALLE", 0, 0, "CALLE 10 BIS, Buenos Aires, General Pueyrredón", 6357080L, "CALLE 10 BIS", "INDEC", 0, 0 },
                    { 635708000050L, "CALLE", 0, 0, "CALLE 12, Buenos Aires, General Pueyrredón", 6357080L, "CALLE 12", "INDEC", 0, 0 },
                    { 635708000055L, "CALLE", 0, 0, "CALLE 12 BIS, Buenos Aires, General Pueyrredón", 6357080L, "CALLE 12 BIS", "INDEC", 0, 0 },
                    { 635708000060L, "CALLE", 0, 0, "CALLE 13, Buenos Aires, General Pueyrredón", 6357080L, "CALLE 13", "INDEC", 0, 0 },
                    { 635708000065L, "CALLE", 0, 0, "CALLE 14 BIS, Buenos Aires, General Pueyrredón", 6357080L, "CALLE 14 BIS", "INDEC", 0, 0 },
                    { 635708000070L, "CALLE", 8599, 8598, "CALLE 16, Buenos Aires, General Pueyrredón", 6357080L, "CALLE 16", "INDEC", 0, 0 },
                    { 635708000075L, "CALLE", 8598, 8599, "CALLE 18, Buenos Aires, General Pueyrredón", 6357080L, "CALLE 18", "INDEC", 0, 0 },
                    { 635708000080L, "CALLE", 0, 7799, "CALLE 19, Buenos Aires, General Pueyrredón", 6357080L, "CALLE 19", "INDEC", 0, 0 },
                    { 635708000085L, "CALLE", 8499, 8498, "CALLE 2, Buenos Aires, General Pueyrredón", 6357080L, "CALLE 2", "INDEC", 0, 0 },
                    { 635708000090L, "CALLE", 8599, 8598, "CALLE 20, Buenos Aires, General Pueyrredón", 6357080L, "CALLE 20", "INDEC", 0, 0 },
                    { 635708000095L, "CALLE", 8598, 0, "CALLE 22, Buenos Aires, General Pueyrredón", 6357080L, "CALLE 22", "INDEC", 0, 0 },
                    { 635708000100L, "CALLE", 0, 0, "CALLE 22 BIS, Buenos Aires, General Pueyrredón", 6357080L, "CALLE 22 BIS", "INDEC", 0, 0 },
                    { 635708000105L, "CALLE", 0, 0, "CALLE 24, Buenos Aires, General Pueyrredón", 6357080L, "CALLE 24", "INDEC", 0, 0 },
                    { 635708000110L, "CALLE", 1299, 0, "CALLE 26, Buenos Aires, General Pueyrredón", 6357080L, "CALLE 26", "INDEC", 0, 0 },
                    { 635708000115L, "CALLE", 0, 0, "CALLE 28, Buenos Aires, General Pueyrredón", 6357080L, "CALLE 28", "INDEC", 0, 0 },
                    { 635708000120L, "CALLE", 0, 0, "CALLE 30, Buenos Aires, General Pueyrredón", 6357080L, "CALLE 30", "INDEC", 0, 0 },
                    { 635708000125L, "CALLE", 0, 0, "CALLE 32, Buenos Aires, General Pueyrredón", 6357080L, "CALLE 32", "INDEC", 0, 0 },
                    { 635708000130L, "CALLE", 0, 0, "CALLE 34, Buenos Aires, General Pueyrredón", 6357080L, "CALLE 34", "INDEC", 0, 0 },
                    { 635708000135L, "CALLE", 0, 0, "CALLE 36, Buenos Aires, General Pueyrredón", 6357080L, "CALLE 36", "INDEC", 0, 0 },
                    { 635708000140L, "CALLE", 0, 0, "CALLE 38, Buenos Aires, General Pueyrredón", 6357080L, "CALLE 38", "INDEC", 0, 0 },
                    { 635708000145L, "CALLE", 0, 8598, "CALLE 4, Buenos Aires, General Pueyrredón", 6357080L, "CALLE 4", "INDEC", 0, 0 },
                    { 635708000150L, "CALLE", 0, 0, "CALLE 40, Buenos Aires, General Pueyrredón", 6357080L, "CALLE 40", "INDEC", 0, 0 },
                    { 635708000155L, "CALLE", 0, 0, "CALLE 42, Buenos Aires, General Pueyrredón", 6357080L, "CALLE 42", "INDEC", 0, 0 },
                    { 635708000160L, "CALLE", 0, 0, "CALLE 44, Buenos Aires, General Pueyrredón", 6357080L, "CALLE 44", "INDEC", 0, 0 },
                    { 635708000165L, "CALLE", 0, 0, "CALLE 48, Buenos Aires, General Pueyrredón", 6357080L, "CALLE 48", "INDEC", 0, 0 },
                    { 635708000170L, "CALLE", 0, 0, "CALLE 56, Buenos Aires, General Pueyrredón", 6357080L, "CALLE 56", "INDEC", 0, 0 },
                    { 635708000175L, "CALLE", 0, 0, "CALLE 58, Buenos Aires, General Pueyrredón", 6357080L, "CALLE 58", "INDEC", 0, 0 },
                    { 635708000180L, "CALLE", 8498, 8599, "CALLE 6, Buenos Aires, General Pueyrredón", 6357080L, "CALLE 6", "INDEC", 0, 0 },
                    { 635708000185L, "CALLE", 0, 0, "CALLE 60, Buenos Aires, General Pueyrredón", 6357080L, "CALLE 60", "INDEC", 0, 0 },
                    { 635708000190L, "CALLE", 0, 0, "CALLE 62, Buenos Aires, General Pueyrredón", 6357080L, "CALLE 62", "INDEC", 0, 0 },
                    { 635708000195L, "CALLE", 0, 0, "CALLE 64, Buenos Aires, General Pueyrredón", 6357080L, "CALLE 64", "INDEC", 0, 0 },
                    { 635708000200L, "CALLE", 0, 0, "CALLE 687 BIS, Buenos Aires, General Pueyrredón", 6357080L, "CALLE 687 BIS", "INDEC", 0, 0 },
                    { 635708000205L, "CALLE", 0, 0, "CALLE 693, Buenos Aires, General Pueyrredón", 6357080L, "CALLE 693", "INDEC", 0, 0 },
                    { 635708000210L, "CALLE", 0, 0, "CALLE 695 B, Buenos Aires, General Pueyrredón", 6357080L, "CALLE 695 B", "INDEC", 0, 0 },
                    { 635708000215L, "CALLE", 0, 0, "CALLE 697 BIS, Buenos Aires, General Pueyrredón", 6357080L, "CALLE 697 BIS", "INDEC", 0, 0 },
                    { 635708000220L, "CALLE", 0, 0, "CALLE 705, Buenos Aires, General Pueyrredón", 6357080L, "CALLE 705", "INDEC", 0, 0 },
                    { 635708000225L, "CALLE", 0, 0, "CALLE 711 BIS, Buenos Aires, General Pueyrredón", 6357080L, "CALLE 711 BIS", "INDEC", 0, 0 },
                    { 635708000230L, "CALLE", 0, 0, "CALLE 713, Buenos Aires, General Pueyrredón", 6357080L, "CALLE 713", "INDEC", 0, 0 },
                    { 635708000235L, "CALLE", 0, 0, "CALLE 715, Buenos Aires, General Pueyrredón", 6357080L, "CALLE 715", "INDEC", 0, 0 },
                    { 635708000240L, "CALLE", 0, 0, "CALLE 717, Buenos Aires, General Pueyrredón", 6357080L, "CALLE 717", "INDEC", 0, 0 },
                    { 635708000245L, "CALLE", 0, 0, "CALLE 721, Buenos Aires, General Pueyrredón", 6357080L, "CALLE 721", "INDEC", 0, 0 },
                    { 635708000250L, "CALLE", 0, 0, "CALLE 725, Buenos Aires, General Pueyrredón", 6357080L, "CALLE 725", "INDEC", 0, 0 },
                    { 635708000255L, "CALLE", 0, 0, "CALLE 727, Buenos Aires, General Pueyrredón", 6357080L, "CALLE 727", "INDEC", 0, 0 },
                    { 635708000260L, "CALLE", 0, 0, "CALLE 729, Buenos Aires, General Pueyrredón", 6357080L, "CALLE 729", "INDEC", 0, 0 },
                    { 635708000265L, "CALLE", 0, 0, "CALLE 731, Buenos Aires, General Pueyrredón", 6357080L, "CALLE 731", "INDEC", 0, 0 },
                    { 635708000270L, "CALLE", 0, 0, "CALLE 733, Buenos Aires, General Pueyrredón", 6357080L, "CALLE 733", "INDEC", 0, 0 },
                    { 635708000275L, "CALLE", 0, 0, "CALLE 735, Buenos Aires, General Pueyrredón", 6357080L, "CALLE 735", "INDEC", 0, 0 },
                    { 635708000280L, "CALLE", 0, 0, "CALLE 739, Buenos Aires, General Pueyrredón", 6357080L, "CALLE 739", "INDEC", 0, 0 },
                    { 635708000285L, "CALLE", 0, 0, "CALLE 745, Buenos Aires, General Pueyrredón", 6357080L, "CALLE 745", "INDEC", 0, 0 },
                    { 635708000290L, "CALLE", 0, 0, "CALLE 747, Buenos Aires, General Pueyrredón", 6357080L, "CALLE 747", "INDEC", 0, 0 },
                    { 635708000295L, "CALLE", 0, 0, "CALLE 749, Buenos Aires, General Pueyrredón", 6357080L, "CALLE 749", "INDEC", 0, 0 },
                    { 635708000300L, "CALLE", 0, 0, "CALLE 751, Buenos Aires, General Pueyrredón", 6357080L, "CALLE 751", "INDEC", 0, 0 },
                    { 635708000305L, "CALLE", 0, 0, "CALLE 753, Buenos Aires, General Pueyrredón", 6357080L, "CALLE 753", "INDEC", 0, 0 },
                    { 635708000310L, "CALLE", 0, 0, "CALLE 755, Buenos Aires, General Pueyrredón", 6357080L, "CALLE 755", "INDEC", 0, 0 },
                    { 635708000315L, "CALLE", 0, 0, "CALLE 759, Buenos Aires, General Pueyrredón", 6357080L, "CALLE 759", "INDEC", 0, 0 },
                    { 635708000320L, "CALLE", 0, 0, "CALLE 761, Buenos Aires, General Pueyrredón", 6357080L, "CALLE 761", "INDEC", 0, 0 },
                    { 635708000325L, "CALLE", 0, 0, "CALLE 763, Buenos Aires, General Pueyrredón", 6357080L, "CALLE 763", "INDEC", 0, 0 },
                    { 635708000330L, "CALLE", 0, 0, "CALLE 765, Buenos Aires, General Pueyrredón", 6357080L, "CALLE 765", "INDEC", 0, 0 },
                    { 635708000335L, "CALLE", 0, 0, "CALLE 767, Buenos Aires, General Pueyrredón", 6357080L, "CALLE 767", "INDEC", 0, 0 },
                    { 635708000340L, "CALLE", 0, 0, "CALLE 769, Buenos Aires, General Pueyrredón", 6357080L, "CALLE 769", "INDEC", 0, 0 },
                    { 635708000345L, "CALLE", 0, 0, "CALLE 771, Buenos Aires, General Pueyrredón", 6357080L, "CALLE 771", "INDEC", 0, 0 },
                    { 635708000350L, "CALLE", 0, 0, "CALLE 771 BIS, Buenos Aires, General Pueyrredón", 6357080L, "CALLE 771 BIS", "INDEC", 0, 0 },
                    { 635708000355L, "CALLE", 0, 0, "CALLE 773, Buenos Aires, General Pueyrredón", 6357080L, "CALLE 773", "INDEC", 0, 0 },
                    { 635708000360L, "CALLE", 0, 0, "CALLE 775, Buenos Aires, General Pueyrredón", 6357080L, "CALLE 775", "INDEC", 0, 0 },
                    { 635708000365L, "CALLE", 0, 0, "CALLE 777, Buenos Aires, General Pueyrredón", 6357080L, "CALLE 777", "INDEC", 0, 0 },
                    { 635708000370L, "CALLE", 0, 0, "CALLE 779, Buenos Aires, General Pueyrredón", 6357080L, "CALLE 779", "INDEC", 0, 0 },
                    { 635708000375L, "CALLE", 0, 0, "CALLE 781, Buenos Aires, General Pueyrredón", 6357080L, "CALLE 781", "INDEC", 0, 0 },
                    { 635708000380L, "CALLE", 0, 0, "CALLE 783, Buenos Aires, General Pueyrredón", 6357080L, "CALLE 783", "INDEC", 0, 0 },
                    { 635708000385L, "CALLE", 0, 0, "CALLE 785, Buenos Aires, General Pueyrredón", 6357080L, "CALLE 785", "INDEC", 0, 0 },
                    { 635708000390L, "CALLE", 0, 0, "CALLE 787, Buenos Aires, General Pueyrredón", 6357080L, "CALLE 787", "INDEC", 0, 0 },
                    { 635708000395L, "CALLE", 0, 0, "CALLE 789, Buenos Aires, General Pueyrredón", 6357080L, "CALLE 789", "INDEC", 0, 0 },
                    { 635708000400L, "CALLE", 0, 0, "CALLE 791, Buenos Aires, General Pueyrredón", 6357080L, "CALLE 791", "INDEC", 0, 0 },
                    { 635708000405L, "CALLE", 0, 0, "CALLE 791 BIS, Buenos Aires, General Pueyrredón", 6357080L, "CALLE 791 BIS", "INDEC", 0, 0 },
                    { 635708000410L, "CALLE", 0, 0, "CALLE 793, Buenos Aires, General Pueyrredón", 6357080L, "CALLE 793", "INDEC", 0, 0 },
                    { 635708000415L, "CALLE", 0, 0, "CALLE 793 BIS, Buenos Aires, General Pueyrredón", 6357080L, "CALLE 793 BIS", "INDEC", 0, 0 },
                    { 635708000420L, "CALLE", 0, 0, "CALLE 795, Buenos Aires, General Pueyrredón", 6357080L, "CALLE 795", "INDEC", 0, 0 },
                    { 635708000425L, "CALLE", 0, 0, "CALLE 797, Buenos Aires, General Pueyrredón", 6357080L, "CALLE 797", "INDEC", 0, 0 },
                    { 635708000430L, "CALLE", 0, 0, "CALLE 799, Buenos Aires, General Pueyrredón", 6357080L, "CALLE 799", "INDEC", 0, 0 },
                    { 635708000435L, "CALLE", 0, 0, "CALLE 8, Buenos Aires, General Pueyrredón", 6357080L, "CALLE 8", "INDEC", 0, 0 },
                    { 635708000440L, "CALLE", 0, 0, "CALLE 801, Buenos Aires, General Pueyrredón", 6357080L, "CALLE 801", "INDEC", 0, 0 },
                    { 635708000445L, "CALLE", 0, 0, "CALLE 801 BIS, Buenos Aires, General Pueyrredón", 6357080L, "CALLE 801 BIS", "INDEC", 0, 0 },
                    { 635708000450L, "CALLE", 0, 0, "CALLE 803, Buenos Aires, General Pueyrredón", 6357080L, "CALLE 803", "INDEC", 0, 0 },
                    { 635708000455L, "CALLE", 0, 0, "CALLE 805, Buenos Aires, General Pueyrredón", 6357080L, "CALLE 805", "INDEC", 0, 0 },
                    { 635708000460L, "CALLE", 0, 0, "CALLE 807, Buenos Aires, General Pueyrredón", 6357080L, "CALLE 807", "INDEC", 0, 0 },
                    { 635708000465L, "CALLE", 0, 0, "CALLE 809, Buenos Aires, General Pueyrredón", 6357080L, "CALLE 809", "INDEC", 0, 0 },
                    { 635708000470L, "CALLE", 0, 0, "CALLE 811, Buenos Aires, General Pueyrredón", 6357080L, "CALLE 811", "INDEC", 0, 0 },
                    { 635708000475L, "CALLE", 0, 0, "CALLE 813, Buenos Aires, General Pueyrredón", 6357080L, "CALLE 813", "INDEC", 0, 0 },
                    { 635708000480L, "CALLE", 0, 0, "CALLE 815, Buenos Aires, General Pueyrredón", 6357080L, "CALLE 815", "INDEC", 0, 0 },
                    { 635708000485L, "CALLE", 0, 0, "CALLE 817, Buenos Aires, General Pueyrredón", 6357080L, "CALLE 817", "INDEC", 0, 0 },
                    { 635708000490L, "CALLE", 1598, 1599, "CALLE 817 BIS, Buenos Aires, General Pueyrredón", 6357080L, "CALLE 817 BIS", "INDEC", 1500, 1501 },
                    { 635708000495L, "CALLE", 0, 0, "CALLE 819, Buenos Aires, General Pueyrredón", 6357080L, "CALLE 819", "INDEC", 0, 0 },
                    { 635708000500L, "CALLE", 0, 0, "CALLE 819 BIS, Buenos Aires, General Pueyrredón", 6357080L, "CALLE 819 BIS", "INDEC", 0, 0 },
                    { 635708000505L, "CALLE", 1198, 2098, "CALLE 823, Buenos Aires, General Pueyrredón", 6357080L, "CALLE 823", "INDEC", 0, 0 },
                    { 635708000510L, "CALLE", 1599, 1598, "CALLE 825, Buenos Aires, General Pueyrredón", 6357080L, "CALLE 825", "INDEC", 1401, 1400 },
                    { 635708000515L, "CALLE", 1898, 18999, "CALLE 827, Buenos Aires, General Pueyrredón", 6357080L, "CALLE 827", "INDEC", 0, 0 },
                    { 635708000520L, "CALLE", 2098, 2099, "CALLE 829, Buenos Aires, General Pueyrredón", 6357080L, "CALLE 829", "INDEC", 701, 700 },
                    { 635708000525L, "CALLE", 1999, 1998, "CALLE 831, Buenos Aires, General Pueyrredón", 6357080L, "CALLE 831", "INDEC", 901, 900 },
                    { 635708000530L, "CALLE", 1998, 1999, "CALLE 833, Buenos Aires, General Pueyrredón", 6357080L, "CALLE 833", "INDEC", 1100, 1101 },
                    { 635708000535L, "CALLE", 1999, 1998, "CALLE 835, Buenos Aires, General Pueyrredón", 6357080L, "CALLE 835", "INDEC", 0, 0 },
                    { 635708000540L, "CALLE", 1998, 1999, "CALLE 837, Buenos Aires, General Pueyrredón", 6357080L, "CALLE 837", "INDEC", 0, 0 },
                    { 635708000545L, "CALLE", 1999, 1998, "CALLE 839, Buenos Aires, General Pueyrredón", 6357080L, "CALLE 839", "INDEC", 1101, 1100 },
                    { 635708000550L, "CALLE", 1698, 1699, "CALLE 839 BIS, Buenos Aires, General Pueyrredón", 6357080L, "CALLE 839 BIS", "INDEC", 1600, 1601 },
                    { 635708000555L, "CALLE", 2098, 2099, "CALLE 841, Buenos Aires, General Pueyrredón", 6357080L, "CALLE 841", "INDEC", 0, 0 },
                    { 635708000560L, "CALLE", 1899, 1898, "CALLE 843, Buenos Aires, General Pueyrredón", 6357080L, "CALLE 843", "INDEC", 1101, 1100 },
                    { 635708000565L, "CALLE", 1698, 0, "CALLE 843 BIS, Buenos Aires, General Pueyrredón", 6357080L, "CALLE 843 BIS", "INDEC", 1600, 1699 },
                    { 635708000570L, "CALLE", 1199, 1098, "CALLE 845, Buenos Aires, General Pueyrredón", 6357080L, "CALLE 845", "INDEC", 0, 0 },
                    { 635708000575L, "CALLE", 1999, 1998, "CALLE 847, Buenos Aires, General Pueyrredón", 6357080L, "CALLE 847", "INDEC", 600, 0 },
                    { 635708000580L, "CALLE", 1998, 1998, "CALLE 849, Buenos Aires, General Pueyrredón", 6357080L, "CALLE 849", "INDEC", 1100, 1101 },
                    { 635708000585L, "CALLE", 1899, 1898, "CALLE 851, Buenos Aires, General Pueyrredón", 6357080L, "CALLE 851", "INDEC", 701, 700 },
                    { 635708000590L, "CALLE", 2099, 0, "CALLE 853, Buenos Aires, General Pueyrredón", 6357080L, "CALLE 853", "INDEC", 0, 0 },
                    { 635708000595L, "CALLE", 398, 399, "CALLE SN, Buenos Aires, General Pueyrredón", 6357080L, "CALLE SN", "INDEC", 0, 1 },
                    { 635708000600L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357080L, "CALLE SN", "INDEC", 0, 0 },
                    { 635708000605L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357080L, "CALLE SN", "INDEC", 0, 0 },
                    { 635708000610L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357080L, "CALLE SN", "INDEC", 0, 0 },
                    { 635708000615L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357080L, "CALLE SN", "INDEC", 0, 0 },
                    { 635708000620L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357080L, "CALLE SN", "INDEC", 0, 0 },
                    { 635708000625L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357080L, "CALLE SN", "INDEC", 0, 0 },
                    { 635708000630L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357080L, "CALLE SN", "INDEC", 0, 0 },
                    { 635708000635L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357080L, "CALLE SN", "INDEC", 0, 0 },
                    { 635708000640L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357080L, "CALLE SN", "INDEC", 0, 0 },
                    { 635708000645L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357080L, "CALLE SN", "INDEC", 0, 0 },
                    { 635708000650L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357080L, "CALLE SN", "INDEC", 0, 0 },
                    { 635708000655L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357080L, "CALLE SN", "INDEC", 0, 0 },
                    { 635708000660L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357080L, "CALLE SN", "INDEC", 0, 0 },
                    { 635708000665L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357080L, "CALLE SN", "INDEC", 0, 0 },
                    { 635708000670L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357080L, "CALLE SN", "INDEC", 0, 0 },
                    { 635708000675L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357080L, "CALLE SN", "INDEC", 0, 0 },
                    { 635708000680L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357080L, "CALLE SN", "INDEC", 0, 0 },
                    { 635708000685L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357080L, "CALLE SN", "INDEC", 0, 0 },
                    { 635708000690L, "CALLE", 0, 0, "CALLE SN, Buenos Aires, General Pueyrredón", 6357080L, "CALLE SN", "INDEC", 0, 0 },
                    { 635708000695L, "CALLE", 1599, 1598, "CANAI-QUEN, Buenos Aires, General Pueyrredón", 6357080L, "CANAI-QUEN", "INDEC", 0, 0 },
                    { 635708000700L, "CALLE", 0, 0, "CHAPADMALAL, Buenos Aires, General Pueyrredón", 6357080L, "CHAPADMALAL", "INDEC", 0, 0 },
                    { 635708000705L, "CALLE", 0, 0, "CUNCUMEN, Buenos Aires, General Pueyrredón", 6357080L, "CUNCUMEN", "INDEC", 0, 0 },
                    { 635708000710L, "CALLE", 0, 0, "DIAG 707, Buenos Aires, General Pueyrredón", 6357080L, "DIAG 707", "INDEC", 0, 0 },
                    { 635708000715L, "CALLE", 0, 0, "DIAG 709, Buenos Aires, General Pueyrredón", 6357080L, "DIAG 709", "INDEC", 0, 0 },
                    { 635708000720L, "CALLE", 0, 0, "DIAG 711, Buenos Aires, General Pueyrredón", 6357080L, "DIAG 711", "INDEC", 0, 0 },
                    { 635708000725L, "CALLE", 0, 0, "DIAG 75, Buenos Aires, General Pueyrredón", 6357080L, "DIAG 75", "INDEC", 0, 0 },
                    { 635708000730L, "CALLE", 0, 0, "DIAG CALLE 66, Buenos Aires, General Pueyrredón", 6357080L, "DIAG CALLE 66", "INDEC", 0, 0 },
                    { 635708000735L, "CALLE", 0, 0, "DIAG CALLE 68, Buenos Aires, General Pueyrredón", 6357080L, "DIAG CALLE 68", "INDEC", 0, 0 },
                    { 635708000740L, "CALLE", 699, 698, "EL PEJERREY, Buenos Aires, General Pueyrredón", 6357080L, "EL PEJERREY", "INDEC", 0, 0 },
                    { 635708000745L, "CALLE", 1499, 1598, "ESTRELLA DE MAR, Buenos Aires, General Pueyrredón", 6357080L, "ESTRELLA DE MAR", "INDEC", 501, 500 },
                    { 635708000750L, "CALLE", 0, 0, "FLOREAL GORINI, Buenos Aires, General Pueyrredón", 6357080L, "FLOREAL GORINI", "INDEC", 0, 0 },
                    { 635708000755L, "CALLE", 0, 0, "FUTURA AUTOPISTA A MAR DEL PLATA, Buenos Aires, General Pueyrredón", 6357080L, "FUTURA AUTOPISTA A MAR DEL PLATA", "INDEC", 0, 0 },
                    { 635708000760L, "CALLE", 0, 0, "HULLEN, Buenos Aires, General Pueyrredón", 6357080L, "HULLEN", "INDEC", 0, 0 },
                    { 635708000765L, "CALLE", 1599, 1598, "INCA-HUEN, Buenos Aires, General Pueyrredón", 6357080L, "INCA-HUEN", "INDEC", 0, 0 },
                    { 635708000770L, "CALLE", 0, 0, "INCAHUEN, Buenos Aires, General Pueyrredón", 6357080L, "INCAHUEN", "INDEC", 0, 0 },
                    { 635708000775L, "CALLE", 0, 0, "LAFQUEN, Buenos Aires, General Pueyrredón", 6357080L, "LAFQUEN", "INDEC", 0, 0 },
                    { 635708000780L, "CALLE", 1498, 1499, "LAS ALMEJAS, Buenos Aires, General Pueyrredón", 6357080L, "LAS ALMEJAS", "INDEC", 400, 401 },
                    { 635708000785L, "CALLE", 1199, 1198, "LAS BALLENAS, Buenos Aires, General Pueyrredón", 6357080L, "LAS BALLENAS", "INDEC", 0, 0 },
                    { 635708000790L, "CALLE", 1699, 0, "LAS CARACOLAS, Buenos Aires, General Pueyrredón", 6357080L, "LAS CARACOLAS", "INDEC", 0, 0 },
                    { 635708000795L, "CALLE", 1498, 1499, "LAS CENTOLLAS, Buenos Aires, General Pueyrredón", 6357080L, "LAS CENTOLLAS", "INDEC", 0, 801 },
                    { 635708000800L, "CALLE", 1498, 0, "LAS CORVINAS, Buenos Aires, General Pueyrredón", 6357080L, "LAS CORVINAS", "INDEC", 0, 0 },
                    { 635708000805L, "CALLE", 1299, 698, "LAS FOCAS, Buenos Aires, General Pueyrredón", 6357080L, "LAS FOCAS", "INDEC", 0, 0 },
                    { 635708000810L, "CALLE", 398, 399, "LAS LISAS, Buenos Aires, General Pueyrredón", 6357080L, "LAS LISAS", "INDEC", 0, 1 },
                    { 635708000815L, "CALLE", 1598, 1599, "LAS MADRESPERLAS, Buenos Aires, General Pueyrredón", 6357080L, "LAS MADRESPERLAS", "INDEC", 500, 501 },
                    { 635708000820L, "CALLE", 199, 198, "LAS NUTRIAS, Buenos Aires, General Pueyrredón", 6357080L, "LAS NUTRIAS", "INDEC", 101, 100 },
                    { 635708000825L, "CALLE", 1298, 1299, "LAS ORCAS, Buenos Aires, General Pueyrredón", 6357080L, "LAS ORCAS", "INDEC", 200, 201 },
                    { 635708000830L, "CALLE", 799, 498, "LAS OSTRAS, Buenos Aires, General Pueyrredón", 6357080L, "LAS OSTRAS", "INDEC", 1, 50 },
                    { 635708000835L, "CALLE", 399, 398, "LAS PALOMETAS, Buenos Aires, General Pueyrredón", 6357080L, "LAS PALOMETAS", "INDEC", 1, 0 },
                    { 635708000840L, "CALLE", 698, 699, "LAS RETAMAS, Buenos Aires, General Pueyrredón", 6357080L, "LAS RETAMAS", "INDEC", 0, 1 },
                    { 635708000845L, "CALLE", 1299, 1298, "LAS TONINAS, Buenos Aires, General Pueyrredón", 6357080L, "LAS TONINAS", "INDEC", 0, 0 },
                    { 635708000850L, "CALLE", 1299, 1298, "LAS TORTUGAS, Buenos Aires, General Pueyrredón", 6357080L, "LAS TORTUGAS", "INDEC", 81, 100 },
                    { 635708000855L, "CALLE", 198, 0, "LLIFEN, Buenos Aires, General Pueyrredón", 6357080L, "LLIFEN", "INDEC", 0, 0 },
                    { 635708000860L, "CALLE", 1298, 1299, "LOS CALAMARES, Buenos Aires, General Pueyrredón", 6357080L, "LOS CALAMARES", "INDEC", 80, 51 },
                    { 635708000865L, "CALLE", 1598, 1599, "LOS CORALES, Buenos Aires, General Pueyrredón", 6357080L, "LOS CORALES", "INDEC", 0, 0 },
                    { 635708000870L, "CALLE", 1298, 1299, "LOS DELFINES, Buenos Aires, General Pueyrredón", 6357080L, "LOS DELFINES", "INDEC", 150, 101 },
                    { 635708000875L, "CALLE", 1598, 1599, "LOS HIPOCAMPOS, Buenos Aires, General Pueyrredón", 6357080L, "LOS HIPOCAMPOS", "INDEC", 0, 0 },
                    { 635708000880L, "CALLE", 1299, 1298, "LOS MEJILLONES, Buenos Aires, General Pueyrredón", 6357080L, "LOS MEJILLONES", "INDEC", 51, 50 },
                    { 635708000885L, "CALLE", 1298, 1299, "LOS NARVALES, Buenos Aires, General Pueyrredón", 6357080L, "LOS NARVALES", "INDEC", 180, 181 },
                    { 635708000890L, "CALLE", 1498, 1499, "LOS NAUTILOS, Buenos Aires, General Pueyrredón", 6357080L, "LOS NAUTILOS", "INDEC", 400, 401 },
                    { 635708000895L, "CALLE", 1499, 1498, "LOS SALMONES, Buenos Aires, General Pueyrredón", 6357080L, "LOS SALMONES", "INDEC", 401, 400 },
                    { 635708000900L, "CALLE", 0, 0, "PEHUENCO, Buenos Aires, General Pueyrredón", 6357080L, "PEHUENCO", "INDEC", 0, 0 },
                    { 635708000905L, "CALLE", 1298, 1299, "PESCADORES, Buenos Aires, General Pueyrredón", 6357080L, "PESCADORES", "INDEC", 0, 0 },
                    { 635708000910L, "CALLE", 1399, 1398, "PEUMAMEN, Buenos Aires, General Pueyrredón", 6357080L, "PEUMAMEN", "INDEC", 1, 0 },
                    { 635708000915L, "CALLE", 0, 0, "PEUMAYEN, Buenos Aires, General Pueyrredón", 6357080L, "PEUMAYEN", "INDEC", 0, 0 },
                    { 635708000920L, "CALLE", 398, 398, "PUCO YAN, Buenos Aires, General Pueyrredón", 6357080L, "PUCO YAN", "INDEC", 0, 0 },
                    { 635708000925L, "CALLE", 0, 0, "QUINE QUIPAN, Buenos Aires, General Pueyrredón", 6357080L, "QUINE QUIPAN", "INDEC", 0, 0 },
                    { 635708000930L, "CALLE", 0, 0, "RUMEN CO, Buenos Aires, General Pueyrredón", 6357080L, "RUMEN CO", "INDEC", 0, 0 },
                    { 635708000935L, "CALLE", 0, 0, "RUMENCO, Buenos Aires, General Pueyrredón", 6357080L, "RUMENCO", "INDEC", 0, 0 },
                    { 635708000940L, "RUTA", 0, 0, "RUTA PROVINCIAL 11, Buenos Aires, General Pueyrredón", 6357080L, "RUTA PROVINCIAL 11", "INDEC", 0, 0 },
                    { 635708000945L, "CALLE", 0, 0, "YUMBEL, Buenos Aires, General Pueyrredón", 6357080L, "YUMBEL", "INDEC", 0, 0 },
                    { 635708099995L, "CALLE", 0, 0, "CALLE INTERNA, Buenos Aires, General Pueyrredón", 6357080L, "CALLE INTERNA", "INDEC", 0, 0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000005L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000010L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000015L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000020L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000025L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000030L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000035L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000040L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000045L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000050L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000055L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000060L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000065L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000070L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000075L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000080L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000085L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000090L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000095L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000100L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000105L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000110L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000115L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000120L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000125L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000130L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000135L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000140L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000145L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000150L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000155L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000160L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000165L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000170L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000175L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000180L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000185L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000190L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000195L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000200L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000205L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000210L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000215L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000220L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000225L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000230L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000235L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000240L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000245L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000250L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000255L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000260L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000265L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000270L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000275L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000280L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000285L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000290L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000295L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000300L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000305L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000310L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000315L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000320L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000325L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000330L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000335L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000340L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000345L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000350L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000355L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000360L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000365L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000370L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000375L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000380L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000385L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000390L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000395L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000400L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000405L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000410L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000415L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000420L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000425L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000430L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000435L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000440L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000445L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000450L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000455L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000460L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000465L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000470L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000475L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000480L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000485L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000490L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000495L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000500L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000505L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000510L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000515L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000520L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000525L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000530L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000535L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000540L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000545L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000550L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000555L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000560L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000565L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000570L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000575L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000580L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000585L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000590L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000595L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000600L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000605L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000610L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000615L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000620L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000625L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000630L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000635L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000640L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000645L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000650L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000655L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000660L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000665L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000670L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000675L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000680L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000685L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000690L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000695L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000700L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000705L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000710L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000715L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000720L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000725L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000730L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000735L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000740L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000745L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000750L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000755L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000760L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000765L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000770L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000775L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000780L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000785L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000790L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000795L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000800L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000805L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000810L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000815L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000820L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000825L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000830L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000835L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000840L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000845L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000850L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000855L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000860L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000865L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000870L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000875L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000880L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000885L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000890L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000895L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000900L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000905L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000910L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000915L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000920L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000925L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000930L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000935L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000940L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708000945L);

            migrationBuilder.DeleteData(
                table: "Street",
                keyColumn: "Id",
                keyValue: 635708099995L);
        }
    }
}
