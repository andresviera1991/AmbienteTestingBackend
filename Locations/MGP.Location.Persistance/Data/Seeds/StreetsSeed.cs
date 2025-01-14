using MGP.Location.Persistance.Data.Tables;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace MGP.Location.Persistance.Data.Seeds
{
    public class StreetsSeed : IEntityTypeConfiguration<Street>
    {
        public void Configure(EntityTypeBuilder<Street> builder)
        {
            builder.HasData(
                new Street
{
    Id = 635711007990,
    Name = "WILLIAM MORRIS BIS",
    FullName = "WILLIAM MORRIS BIS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000110,
    Name = "A VALENTINI",
    FullName = "A VALENTINI, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 3398,
    EndHeightLeft = 3399,
    StartHeightRight = 3200,
    StartHeightLeft = 3201,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000600,
    Name = "BALCARCE",
    FullName = "BALCARCE, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000605,
    Name = "BANUELOS",
    FullName = "BANUELOS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000610,
    Name = "BASSI",
    FullName = "BASSI, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003285,
    Name = "CALLE 81",
    FullName = "CALLE 81, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003290,
    Name = "CALLE 83",
    FullName = "CALLE 83, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000005,
    Name = "1 - TRINIDAD",
    FullName = "1 - TRINIDAD, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000010,
    Name = "10 - LA TRINIDAD",
    FullName = "10 - LA TRINIDAD, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000015,
    Name = "11 - TRINIDAD",
    FullName = "11 - TRINIDAD, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000020,
    Name = "12 - LA TRINIDAD",
    FullName = "12 - LA TRINIDAD, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000115,
    Name = "A GALEANA",
    FullName = "A GALEANA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 3498,
    EndHeightLeft = 3299,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000120,
    Name = "ABETOS",
    FullName = "ABETOS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000220,
    Name = "AMADO BOND PLAND",
    FullName = "AMADO BOND PLAND, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000310,
    Name = "ATAHUALPA",
    FullName = "ATAHUALPA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000025,
    Name = "12 DE OCTUBRE",
    FullName = "12 DE OCTUBRE, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 11198,
    EndHeightLeft = 89999,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000030,
    Name = "13 - TRINIDAD",
    FullName = "13 - TRINIDAD, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000035,
    Name = "15 - LA TRINIDAD",
    FullName = "15 - LA TRINIDAD, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000040,
    Name = "17 - LA TRINIDAD",
    FullName = "17 - LA TRINIDAD, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000045,
    Name = "201 BIS",
    FullName = "201 BIS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000050,
    Name = "203 BIS",
    FullName = "203 BIS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000055,
    Name = "234 - BO V DE LUJAN",
    FullName = "234 - BO V DE LUJAN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000060,
    Name = "250 - SAN JORGE JOSE",
    FullName = "250 - SAN JORGE JOSE, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "AV",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000065,
    Name = "3 - TRINIDAD",
    FullName = "3 - TRINIDAD, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000070,
    Name = "5 - TRINIDAD",
    FullName = "5 - TRINIDAD, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000075,
    Name = "6 - LA TRINIDAD",
    FullName = "6 - LA TRINIDAD, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000080,
    Name = "7 - TRINIDAD",
    FullName = "7 - TRINIDAD, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000085,
    Name = "8 - LA TRINIDAD",
    FullName = "8 - LA TRINIDAD, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000090,
    Name = "9 - TRINIDAD",
    FullName = "9 - TRINIDAD, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000095,
    Name = "9 DE JUILO",
    FullName = "9 DE JUILO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000100,
    Name = "A DEL SOLAR",
    FullName = "A DEL SOLAR, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000105,
    Name = "A TAPIA",
    FullName = "A TAPIA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003295,
    Name = "CALLE 85",
    FullName = "CALLE 85, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000125,
    Name = "ABIGAIL BURTHABURU",
    FullName = "ABIGAIL BURTHABURU, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 5198,
    EndHeightLeft = 43999,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000130,
    Name = "ACACIAS",
    FullName = "ACACIAS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000135,
    Name = "AGUA BLANCA",
    FullName = "AGUA BLANCA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 3498,
    EndHeightLeft = 3399,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000140,
    Name = "AGUATERO",
    FullName = "AGUATERO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000145,
    Name = "AGUSTIN MAGALDI",
    FullName = "AGUSTIN MAGALDI, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000150,
    Name = "AGUSTIN VILERT",
    FullName = "AGUSTIN VILERT, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000155,
    Name = "ALAMO",
    FullName = "ALAMO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000160,
    Name = "ALAMOS",
    FullName = "ALAMOS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 8899,
    EndHeightLeft = 8898,
    StartHeightRight = 0,
    StartHeightLeft = 8500,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000165,
    Name = "ALBERTO GARAGIOLA",
    FullName = "ALBERTO GARAGIOLA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000170,
    Name = "ALFREDO LEPERA",
    FullName = "ALFREDO LEPERA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000175,
    Name = "ALFREDO MARTINEZ BAYA",
    FullName = "ALFREDO MARTINEZ BAYA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000180,
    Name = "ALGARROBOS",
    FullName = "ALGARROBOS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 99,
    EndHeightLeft = 98,
    StartHeightRight = 1,
    StartHeightLeft = 1,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000185,
    Name = "ALICOA MOREAU DE JUSTO",
    FullName = "ALICOA MOREAU DE JUSTO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 9499,
    EndHeightLeft = 9500,
    StartHeightRight = 8701,
    StartHeightLeft = 8702,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000190,
    Name = "ALIPI",
    FullName = "ALIPI, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000195,
    Name = "ALMONACID",
    FullName = "ALMONACID, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 1999,
    EndHeightLeft = 8098,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000200,
    Name = "ALVAREZ",
    FullName = "ALVAREZ, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000205,
    Name = "ALVAREZ CONDARCO",
    FullName = "ALVAREZ CONDARCO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 5998,
    EndHeightLeft = 5999,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000210,
    Name = "ALVARO",
    FullName = "ALVARO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000215,
    Name = "AMADEO COUREL",
    FullName = "AMADEO COUREL, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003300,
    Name = "CALLE 9",
    FullName = "CALLE 9, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000225,
    Name = "AMBROSETTI JUAN B",
    FullName = "AMBROSETTI JUAN B, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000230,
    Name = "AMEGHINO",
    FullName = "AMEGHINO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 598,
    EndHeightLeft = 599,
    StartHeightRight = 200,
    StartHeightLeft = 201,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000235,
    Name = "ANCHORENA",
    FullName = "ANCHORENA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 5998,
    EndHeightLeft = 5999,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000240,
    Name = "ANGEL VARGAS",
    FullName = "ANGEL VARGAS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000245,
    Name = "ANGELINA PAGANO",
    FullName = "ANGELINA PAGANO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000250,
    Name = "ANTONIO M DIAZ",
    FullName = "ANTONIO M DIAZ, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000255,
    Name = "ANTONIO SPINELLI",
    FullName = "ANTONIO SPINELLI, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000260,
    Name = "ANTONIO STROPATO",
    FullName = "ANTONIO STROPATO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000265,
    Name = "ARANA Y GOIRI",
    FullName = "ARANA Y GOIRI, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000270,
    Name = "ARANA Y GOITI",
    FullName = "ARANA Y GOITI, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 11898,
    EndHeightLeft = 11899,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000275,
    Name = "ARDILES",
    FullName = "ARDILES, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000280,
    Name = "ARMANDO CHULAK",
    FullName = "ARMANDO CHULAK, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 6898,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000285,
    Name = "AROMO",
    FullName = "AROMO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000290,
    Name = "AROMOS",
    FullName = "AROMOS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 5598,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000295,
    Name = "ARQCEDRON",
    FullName = "ARQCEDRON, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000300,
    Name = "ARROYO CORRIENTES",
    FullName = "ARROYO CORRIENTES, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 4999,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000305,
    Name = "ASTOR PIAZZOLLA",
    FullName = "ASTOR PIAZZOLLA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000315,
    Name = "AUTOPISTA MAR DEL PLATA JORGE NEWBERY",
    FullName = "AUTOPISTA MAR DEL PLATA JORGE NEWBERY, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 3848,
    EndHeightLeft = 3999,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000320,
    Name = "AV 10 DE FEBRERO",
    FullName = "AV 10 DE FEBRERO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "AV",
    EndHeightRight = 299,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000325,
    Name = "AV 150 - JACINTO PERALTA RAMOS",
    FullName = "AV 150 - JACINTO PERALTA RAMOS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "AV",
    EndHeightRight = 3099,
    EndHeightLeft = 3198,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000330,
    Name = "AV 150 INDEPENDENCIA",
    FullName = "AV 150 INDEPENDENCIA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "AV",
    EndHeightRight = 4499,
    EndHeightLeft = 4498,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000335,
    Name = "AV 186 - POLONIA",
    FullName = "AV 186 - POLONIA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "AV",
    EndHeightRight = 3200,
    EndHeightLeft = 4698,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003090,
    Name = "CALLE 29",
    FullName = "CALLE 29, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003305,
    Name = "CALLE 91",
    FullName = "CALLE 91, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000340,
    Name = "AV 188 - JARA",
    FullName = "AV 188 - JARA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "AV",
    EndHeightRight = 4199,
    EndHeightLeft = 4198,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000345,
    Name = "AV 199 - CONSTITUCION",
    FullName = "AV 199 - CONSTITUCION, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "AV",
    EndHeightRight = 9498,
    EndHeightLeft = 8999,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000365,
    Name = "AV 239 - LIBERTAD",
    FullName = "AV 239 - LIBERTAD, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "AV",
    EndHeightRight = 10748,
    EndHeightLeft = 10499,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000385,
    Name = "AV 282 - FERMIN ERREA",
    FullName = "AV 282 - FERMIN ERREA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "AV",
    EndHeightRight = 2199,
    EndHeightLeft = 2198,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003095,
    Name = "CALLE 3",
    FullName = "CALLE 3, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000350,
    Name = "AV 210 - CHAMPAGNAT",
    FullName = "AV 210 - CHAMPAGNAT, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "AV",
    EndHeightRight = 3899,
    EndHeightLeft = 6215,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000355,
    Name = "AV 210 - TETAMANTI",
    FullName = "AV 210 - TETAMANTI, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "AV",
    EndHeightRight = 600,
    EndHeightLeft = 3198,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000360,
    Name = "AV 234 - ARTURO ALIO",
    FullName = "AV 234 - ARTURO ALIO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "AV",
    EndHeightRight = 3699,
    EndHeightLeft = 3698,
    StartHeightRight = 0,
    StartHeightLeft = 50,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000615,
    Name = "BAUTISTA",
    FullName = "BAUTISTA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 3988,
    EndHeightLeft = 3499,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000370,
    Name = "AV 251 - PEDRO LURO",
    FullName = "AV 251 - PEDRO LURO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "AV",
    EndHeightRight = 10598,
    EndHeightLeft = 10899,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000375,
    Name = "AV 263 - COLON",
    FullName = "AV 263 - COLON, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "AV",
    EndHeightRight = 10999,
    EndHeightLeft = 8998,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000380,
    Name = "AV 282 - ALBERT SCHWEITZER",
    FullName = "AV 282 - ALBERT SCHWEITZER, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "AV",
    EndHeightRight = 199,
    EndHeightLeft = 10198,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000695,
    Name = "C 0 BIS",
    FullName = "C 0 BIS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002555,
    Name = "C 465",
    FullName = "C 465, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003995,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000390,
    Name = "AV 303 - JUAN JOSE PASO",
    FullName = "AV 303 - JUAN JOSE PASO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "AV",
    EndHeightRight = 3998,
    EndHeightLeft = 3999,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000395,
    Name = "AV 345 - VERTIZ",
    FullName = "AV 345 - VERTIZ, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "AV",
    EndHeightRight = 11898,
    EndHeightLeft = 55996,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000400,
    Name = "AV 361 - F DE LA PLAZA",
    FullName = "AV 361 - F DE LA PLAZA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "AV",
    EndHeightRight = 8398,
    EndHeightLeft = 9399,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000730,
    Name = "C 104 - PAUNERO",
    FullName = "C 104 - PAUNERO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 44984,
    EndHeightLeft = 33992,
    StartHeightRight = 2100,
    StartHeightLeft = 2101,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000405,
    Name = "AV 385 - MARIO BRAVO",
    FullName = "AV 385 - MARIO BRAVO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "AV",
    EndHeightRight = 9100,
    EndHeightLeft = 10969,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000410,
    Name = "AV 66 - CERVANTES SAAVEDRA",
    FullName = "AV 66 - CERVANTES SAAVEDRA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "AV",
    EndHeightRight = 3198,
    EndHeightLeft = 3199,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000415,
    Name = "AV 90 - THOMAS ALVA EDISON",
    FullName = "AV 90 - THOMAS ALVA EDISON, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "AV",
    EndHeightRight = 3099,
    EndHeightLeft = 3198,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000420,
    Name = "AV ANTARTIDA ARGENTINA",
    FullName = "AV ANTARTIDA ARGENTINA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "AV",
    EndHeightRight = 4598,
    EndHeightLeft = 4299,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000490,
    Name = "AV INGENIERO DELLA PAOLERA",
    FullName = "AV INGENIERO DELLA PAOLERA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "AV",
    EndHeightRight = 2498,
    EndHeightLeft = 2499,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004000,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000425,
    Name = "AV CAMET FELIX",
    FullName = "AV CAMET FELIX, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "AV",
    EndHeightRight = 6698,
    EndHeightLeft = 2699,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000430,
    Name = "AV CANOSA AMERICO R",
    FullName = "AV CANOSA AMERICO R, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "AV",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000435,
    Name = "AV CARLOS GARDEL",
    FullName = "AV CARLOS GARDEL, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "AV",
    EndHeightRight = 1898,
    EndHeightLeft = 1899,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000440,
    Name = "AV CIRCUNVALACION MEYRELLES",
    FullName = "AV CIRCUNVALACION MEYRELLES, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "AV",
    EndHeightRight = 6598,
    EndHeightLeft = 6599,
    StartHeightRight = 0,
    StartHeightLeft = 5801,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000445,
    Name = "AV DE LA HERRADURA",
    FullName = "AV DE LA HERRADURA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "AV",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000450,
    Name = "AV DE LA TORRE",
    FullName = "AV DE LA TORRE, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "AV",
    EndHeightRight = 8999,
    EndHeightLeft = 898,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000455,
    Name = "AV DE LAS OLIMPIADAS",
    FullName = "AV DE LAS OLIMPIADAS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "AV",
    EndHeightRight = 998,
    EndHeightLeft = 1098,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000460,
    Name = "AV DE LOS JUBILADOS",
    FullName = "AV DE LOS JUBILADOS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "AV",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000465,
    Name = "AV DE LOS PESCADORES",
    FullName = "AV DE LOS PESCADORES, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "AV",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000495,
    Name = "AV ISLA SOLEDAD",
    FullName = "AV ISLA SOLEDAD, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "AV",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000470,
    Name = "AV DE LOS TRABAJADORES",
    FullName = "AV DE LOS TRABAJADORES, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "AV",
    EndHeightRight = 4499,
    EndHeightLeft = 5475,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000475,
    Name = "AV DORREGO",
    FullName = "AV DORREGO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "AV",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000480,
    Name = "AV HARAS TARANTINO",
    FullName = "AV HARAS TARANTINO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "AV",
    EndHeightRight = 399,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000485,
    Name = "AV HIPODROMO",
    FullName = "AV HIPODROMO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "AV",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000565,
    Name = "AZUCENA MAIZANI",
    FullName = "AZUCENA MAIZANI, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000570,
    Name = "B BALERDI",
    FullName = "B BALERDI, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000575,
    Name = "B LYNCH",
    FullName = "B LYNCH, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000580,
    Name = "B BALERDI",
    FullName = "B BALERDI, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000500,
    Name = "AV JUAN B JUSTO",
    FullName = "AV JUAN B JUSTO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "AV",
    EndHeightRight = 85898,
    EndHeightLeft = 8999,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000505,
    Name = "AV LOS PLATANOS",
    FullName = "AV LOS PLATANOS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "AV",
    EndHeightRight = 5388,
    EndHeightLeft = 1198,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000510,
    Name = "AV LURO",
    FullName = "AV LURO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "AV",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000515,
    Name = "AV MONSENOR ZABALA",
    FullName = "AV MONSENOR ZABALA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "AV",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000520,
    Name = "AV PERITO MORENO",
    FullName = "AV PERITO MORENO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "AV",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000585,
    Name = "BAHIA SAN BLAS",
    FullName = "BAHIA SAN BLAS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000590,
    Name = "BAHIA THETIS",
    FullName = "BAHIA THETIS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000595,
    Name = "BAIGORRITA",
    FullName = "BAIGORRITA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 6498,
    EndHeightLeft = 6499,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000525,
    Name = "AV PRESIDENTE PERON",
    FullName = "AV PRESIDENTE PERON, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "AV",
    EndHeightRight = 0,
    EndHeightLeft = 198,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000530,
    Name = "AV SALVADOR VIVAS",
    FullName = "AV SALVADOR VIVAS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "AV",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000535,
    Name = "AV TEJEDOR CARLOS",
    FullName = "AV TEJEDOR CARLOS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "AV",
    EndHeightRight = 3699,
    EndHeightLeft = 3698,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000540,
    Name = "AVELLANEDA",
    FullName = "AVELLANEDA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000545,
    Name = "AYELEP",
    FullName = "AYELEP, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000550,
    Name = "AYOLAS",
    FullName = "AYOLAS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 72999,
    EndHeightLeft = 72988,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000555,
    Name = "AZARA",
    FullName = "AZARA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000560,
    Name = "AZARA F",
    FullName = "AZARA F, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000620,
    Name = "BELTRAN",
    FullName = "BELTRAN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 55798,
    EndHeightLeft = 2,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000625,
    Name = "BENITO LYNCH",
    FullName = "BENITO LYNCH, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000630,
    Name = "BIGUA",
    FullName = "BIGUA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000635,
    Name = "BLANCO",
    FullName = "BLANCO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000640,
    Name = "BORMIDA",
    FullName = "BORMIDA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000645,
    Name = "BOSQUE GRANDE",
    FullName = "BOSQUE GRANDE, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 9498,
    EndHeightLeft = 9399,
    StartHeightRight = 9001,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000650,
    Name = "BOUCHARD",
    FullName = "BOUCHARD, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 9498,
    EndHeightLeft = 9499,
    StartHeightRight = 1501,
    StartHeightLeft = 1500,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000655,
    Name = "BOULEVARD BOSQUE NORTE",
    FullName = "BOULEVARD BOSQUE NORTE, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000660,
    Name = "BOULEVARD DEL BOSQUE",
    FullName = "BOULEVARD DEL BOSQUE, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000665,
    Name = "BRAGADAO BIS",
    FullName = "BRAGADAO BIS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000670,
    Name = "BROCHERO",
    FullName = "BROCHERO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000700,
    Name = "C 10",
    FullName = "C 10, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002560,
    Name = "C 467",
    FullName = "C 467, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003100,
    Name = "CALLE 31",
    FullName = "CALLE 31, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000675,
    Name = "BULEVARD MARITIMO P P RAMOS",
    FullName = "BULEVARD MARITIMO P P RAMOS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 5999,
    EndHeightLeft = 1498,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000680,
    Name = "BUQUE PESQUERO SAN FRANCISCO",
    FullName = "BUQUE PESQUERO SAN FRANCISCO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000685,
    Name = "BV DEL BOSQUE",
    FullName = "BV DEL BOSQUE, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000690,
    Name = "BVARD DEL BOSQUE",
    FullName = "BVARD DEL BOSQUE, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000705,
    Name = "C 100 - ALVEAR DE BOSCH",
    FullName = "C 100 - ALVEAR DE BOSCH, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 3199,
    EndHeightLeft = 3098,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000710,
    Name = "C 100 - GRL RIVAS",
    FullName = "C 100 - GRL RIVAS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 4999,
    EndHeightLeft = 4998,
    StartHeightRight = 2301,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000715,
    Name = "C 102 - DON ORIONE",
    FullName = "C 102 - DON ORIONE, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 3199,
    EndHeightLeft = 3198,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000720,
    Name = "C 102 - LAVALLE",
    FullName = "C 102 - LAVALLE, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 4999,
    EndHeightLeft = 4998,
    StartHeightRight = 2201,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000725,
    Name = "C 104 - LANZILOTA",
    FullName = "C 104 - LANZILOTA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 3199,
    EndHeightLeft = 3198,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002705,
    Name = "C 56 - ACEVEDO",
    FullName = "C 56 - ACEVEDO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 3199,
    EndHeightLeft = 3198,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004005,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000735,
    Name = "C 106 - JURAMENTO",
    FullName = "C 106 - JURAMENTO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 3199,
    EndHeightLeft = 3198,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000740,
    Name = "C 106 - MENDOZA",
    FullName = "C 106 - MENDOZA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 4999,
    EndHeightLeft = 4998,
    StartHeightRight = 2001,
    StartHeightLeft = 2001,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000745,
    Name = "C 108 - ALEJANDRO KORN",
    FullName = "C 108 - ALEJANDRO KORN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 3199,
    EndHeightLeft = 3198,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000750,
    Name = "C 108 - VIAMONTE",
    FullName = "C 108 - VIAMONTE, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 4899,
    EndHeightLeft = 4998,
    StartHeightRight = 0,
    StartHeightLeft = 1900,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000755,
    Name = "C 11",
    FullName = "C 11, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000760,
    Name = "C 110 - ALVEAR",
    FullName = "C 110 - ALVEAR, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 4899,
    EndHeightLeft = 4998,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002710,
    Name = "C 58 - GRL PACHECO",
    FullName = "C 58 - GRL PACHECO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 3099,
    EndHeightLeft = 2998,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000765,
    Name = "C 110 - HERNANDEZ",
    FullName = "C 110 - HERNANDEZ, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 3199,
    EndHeightLeft = 3198,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000770,
    Name = "C 112 - ALVEAR",
    FullName = "C 112 - ALVEAR, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 2899,
    EndHeightLeft = 2898,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000775,
    Name = "C 112 - GUEMES",
    FullName = "C 112 - GUEMES, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 4899,
    EndHeightLeft = 4898,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000780,
    Name = "C 114 - CERRITO",
    FullName = "C 114 - CERRITO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 3199,
    EndHeightLeft = 3198,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000785,
    Name = "C 114 - OLAVARRIA",
    FullName = "C 114 - OLAVARRIA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 4899,
    EndHeightLeft = 4898,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001070,
    Name = "C 160 - MONSENOR RAU",
    FullName = "C 160 - MONSENOR RAU, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 2799,
    EndHeightLeft = 2798,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000790,
    Name = "C 116 - ALSINA",
    FullName = "C 116 - ALSINA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 4899,
    EndHeightLeft = 4898,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000795,
    Name = "C 116 - JOSE MARTI",
    FullName = "C 116 - JOSE MARTI, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 3199,
    EndHeightLeft = 3198,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000800,
    Name = "C 117 - J ZACAGNINI",
    FullName = "C 117 - J ZACAGNINI, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 7398,
    EndHeightLeft = 7399,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000805,
    Name = "C 118 - GIANELLI",
    FullName = "C 118 - GIANELLI, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 3199,
    EndHeightLeft = 3198,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000810,
    Name = "C 118 - SARMIENTO",
    FullName = "C 118 - SARMIENTO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 4799,
    EndHeightLeft = 4898,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000845,
    Name = "C 124 - LUIS AGOTE",
    FullName = "C 124 - LUIS AGOTE, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 3199,
    EndHeightLeft = 3198,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000815,
    Name = "C 12",
    FullName = "C 12, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000820,
    Name = "C 12 BIS",
    FullName = "C 12 BIS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000825,
    Name = "C 120 - LAS HERAS",
    FullName = "C 120 - LAS HERAS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 4799,
    EndHeightLeft = 4798,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000830,
    Name = "C 120 - SANTA CECILIA",
    FullName = "C 120 - SANTA CECILIA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 3199,
    EndHeightLeft = 3198,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000835,
    Name = "C 122 - FLEMMING",
    FullName = "C 122 - FLEMMING, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 3199,
    EndHeightLeft = 3198,
    StartHeightRight = 1,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000840,
    Name = "C 122 - LAMADRID",
    FullName = "C 122 - LAMADRID, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 4799,
    EndHeightLeft = 4798,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001075,
    Name = "C 161 - ANCHORENA",
    FullName = "C 161 - ANCHORENA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 5399,
    EndHeightLeft = 5398,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002900,
    Name = "C 8",
    FullName = "C 8, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000850,
    Name = "C 124 - ARENALES",
    FullName = "C 124 - ARENALES, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 4699,
    EndHeightLeft = 4698,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000855,
    Name = "C 126 - GALICIA",
    FullName = "C 126 - GALICIA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 3199,
    EndHeightLeft = 3198,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000860,
    Name = "C 126 - TUCUMAN",
    FullName = "C 126 - TUCUMAN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 4799,
    EndHeightLeft = 4798,
    StartHeightRight = 2201,
    StartHeightLeft = 2200,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000865,
    Name = "C 128 - BUENOS AIRES",
    FullName = "C 128 - BUENOS AIRES, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 4699,
    EndHeightLeft = 4798,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000870,
    Name = "C 128 - ESTEBAN ECHEVERRIA",
    FullName = "C 128 - ESTEBAN ECHEVERRIA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 3199,
    EndHeightLeft = 3198,
    StartHeightRight = 1,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000875,
    Name = "C 130 - ENTRE RIOS",
    FullName = "C 130 - ENTRE RIOS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 4699,
    EndHeightLeft = 4698,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002902,
    Name = "CABEZA",
    FullName = "CABEZA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000880,
    Name = "C 130 - ROQUE SAENZ PENA",
    FullName = "C 130 - ROQUE SAENZ PENA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 3199,
    EndHeightLeft = 3198,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000885,
    Name = "C 132 - CORRIENTES",
    FullName = "C 132 - CORRIENTES, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 4699,
    EndHeightLeft = 4698,
    StartHeightRight = 1501,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000890,
    Name = "C 132 - GRL M SAVIO",
    FullName = "C 132 - GRL M SAVIO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 3199,
    EndHeightLeft = 3198,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000895,
    Name = "C 134 - GRL R DE RIEGO",
    FullName = "C 134 - GRL R DE RIEGO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 3099,
    EndHeightLeft = 10098,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000900,
    Name = "C 134 - SANTA FE",
    FullName = "C 134 - SANTA FE, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 4699,
    EndHeightLeft = 4698,
    StartHeightRight = 0,
    StartHeightLeft = 1200,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002905,
    Name = "CABILDO",
    FullName = "CABILDO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 5798,
    EndHeightLeft = 5799,
    StartHeightRight = 5700,
    StartHeightLeft = 5701,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002910,
    Name = "CABO CORRIENTES",
    FullName = "CABO CORRIENTES, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000905,
    Name = "C 136 - MATEOTTI",
    FullName = "C 136 - MATEOTTI, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 3199,
    EndHeightLeft = 3098,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000910,
    Name = "C 136 - SANTIAGO DEL ESTERO",
    FullName = "C 136 - SANTIAGO DEL ESTERO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 4699,
    EndHeightLeft = 4698,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000915,
    Name = "C 138 - CORDOBA",
    FullName = "C 138 - CORDOBA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 4651,
    EndHeightLeft = 4698,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000920,
    Name = "C 138 - TALCAHUANO",
    FullName = "C 138 - TALCAHUANO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 47996,
    EndHeightLeft = 3198,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000950,
    Name = "C 144 - AMBROSIO BESTOSO",
    FullName = "C 144 - AMBROSIO BESTOSO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 2999,
    EndHeightLeft = 3098,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002915,
    Name = "CABO DE HORNOS",
    FullName = "CABO DE HORNOS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000925,
    Name = "C 14",
    FullName = "C 14, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000930,
    Name = "C 140 - LUIS DELLEPIANE",
    FullName = "C 140 - LUIS DELLEPIANE, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 3099,
    EndHeightLeft = 5698,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000935,
    Name = "C 140 - SAN LUIS",
    FullName = "C 140 - SAN LUIS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 4599,
    EndHeightLeft = 4650,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000940,
    Name = "C 142 - ANTONIO VALENTINI",
    FullName = "C 142 - ANTONIO VALENTINI, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 3199,
    EndHeightLeft = 3198,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000945,
    Name = "C 142 - BARTOLOME MITRE",
    FullName = "C 142 - BARTOLOME MITRE, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 4599,
    EndHeightLeft = 4598,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002920,
    Name = "CABRAL SGT",
    FullName = "CABRAL SGT, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 99,
    EndHeightLeft = 98,
    StartHeightRight = 1,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000955,
    Name = "C 144 - HIPOLITO YRIGOYEN",
    FullName = "C 144 - HIPOLITO YRIGOYEN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 4599,
    EndHeightLeft = 4598,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000960,
    Name = "C 146 - JUANA MANSO",
    FullName = "C 146 - JUANA MANSO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 3199,
    EndHeightLeft = 3198,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000965,
    Name = "C 146 - LA RIOJA",
    FullName = "C 146 - LA RIOJA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 4599,
    EndHeightLeft = 17978,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000970,
    Name = "C 147 - CURA BROCHERO",
    FullName = "C 147 - CURA BROCHERO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 5098,
    EndHeightLeft = 5099,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000975,
    Name = "C 148 - CATAMARCA",
    FullName = "C 148 - CATAMARCA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 4499,
    EndHeightLeft = 4598,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001030,
    Name = "C 157 - FERRE",
    FullName = "C 157 - FERRE, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 5098,
    EndHeightLeft = 4999,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001035,
    Name = "C 1570 - QUINQUELA MARTIN",
    FullName = "C 1570 - QUINQUELA MARTIN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 1899,
    EndHeightLeft = 1898,
    StartHeightRight = 1101,
    StartHeightLeft = 1100,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004010,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000980,
    Name = "C 148 - F SANCHEZ",
    FullName = "C 148 - F SANCHEZ, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 6099,
    EndHeightLeft = 5698,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000985,
    Name = "C 149 - FRAY LUIS BELTRAN",
    FullName = "C 149 - FRAY LUIS BELTRAN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 5198,
    EndHeightLeft = 5199,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000990,
    Name = "C 152 - C VILLAR",
    FullName = "C 152 - C VILLAR, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 4298,
    EndHeightLeft = 4299,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711000995,
    Name = "C 152 - SALTA",
    FullName = "C 152 - SALTA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 4399,
    EndHeightLeft = 4498,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001000,
    Name = "C 153 - F DE ARANA",
    FullName = "C 153 - F DE ARANA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 5998,
    EndHeightLeft = 53999,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001140,
    Name = "C 172 - BLAS PARERA",
    FullName = "C 172 - BLAS PARERA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 1699,
    EndHeightLeft = 1798,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001005,
    Name = "C 154 - GONZALES CHAVES",
    FullName = "C 154 - GONZALES CHAVES, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 6999,
    EndHeightLeft = 2798,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001010,
    Name = "C 154 - JUJUY",
    FullName = "C 154 - JUJUY, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 4399,
    EndHeightLeft = 4398,
    StartHeightRight = 1,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001015,
    Name = "C 155 - GODOY CRUZ",
    FullName = "C 155 - GODOY CRUZ, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 5998,
    EndHeightLeft = 35799,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001020,
    Name = "C 156 - CIUDAD DE DOLORES",
    FullName = "C 156 - CIUDAD DE DOLORES, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 2799,
    EndHeightLeft = 2798,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001025,
    Name = "C 156 - ESPANA",
    FullName = "C 156 - ESPANA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 4499,
    EndHeightLeft = 4498,
    StartHeightRight = 0,
    StartHeightLeft = 100,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003105,
    Name = "CALLE 33",
    FullName = "CALLE 33, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001040,
    Name = "C 158 - 20 - DE SEPTIEMBRE",
    FullName = "C 158 - 20 - DE SEPTIEMBRE, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 4399,
    EndHeightLeft = 4498,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001045,
    Name = "C 158 - DR M CASTEX",
    FullName = "C 158 - DR M CASTEX, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 2799,
    EndHeightLeft = 2798,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001050,
    Name = "C 159 - CASEROS",
    FullName = "C 159 - CASEROS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 5798,
    EndHeightLeft = 5799,
    StartHeightRight = 500,
    StartHeightLeft = 4501,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001055,
    Name = "C 159 - ESTANISLAO ZEBALLOS",
    FullName = "C 159 - ESTANISLAO ZEBALLOS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 14898,
    EndHeightLeft = 5199,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001060,
    Name = "C 16",
    FullName = "C 16, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001065,
    Name = "C 160 - 14 DE JULIO",
    FullName = "C 160 - 14 DE JULIO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 4398,
    EndHeightLeft = 4399,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001080,
    Name = "C 162 - DORREGO",
    FullName = "C 162 - DORREGO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 4398,
    EndHeightLeft = 4399,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001085,
    Name = "C 162 - FRIULLI",
    FullName = "C 162 - FRIULLI, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 1999,
    EndHeightLeft = 2798,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001090,
    Name = "C 163 - GRL MANSILLA",
    FullName = "C 163 - GRL MANSILLA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 5199,
    EndHeightLeft = 4898,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001095,
    Name = "C 164 - CNL CELESTINO VIDAL",
    FullName = "C 164 - CNL CELESTINO VIDAL, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 2399,
    EndHeightLeft = 2398,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001100,
    Name = "C 164 - GUIDO",
    FullName = "C 164 - GUIDO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 4398,
    EndHeightLeft = 4399,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001105,
    Name = "C 165 - VUELTA DE OBLIGADO",
    FullName = "C 165 - VUELTA DE OBLIGADO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 4998,
    EndHeightLeft = 5098,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002925,
    Name = "CABRERA",
    FullName = "CABRERA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001110,
    Name = "C 166 - DEAN FUNES",
    FullName = "C 166 - DEAN FUNES, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 4398,
    EndHeightLeft = 3699,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001115,
    Name = "C 166 - UDINE",
    FullName = "C 166 - UDINE, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 1999,
    EndHeightLeft = 7198,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001120,
    Name = "C 167 - CHAPEAUROUGE",
    FullName = "C 167 - CHAPEAUROUGE, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 5798,
    EndHeightLeft = 5199,
    StartHeightRight = 4500,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001125,
    Name = "C 168 - OLAZABAL",
    FullName = "C 168 - OLAZABAL, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 4099,
    EndHeightLeft = 4200,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001130,
    Name = "C 170 - PATAGONES",
    FullName = "C 170 - PATAGONES, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 1699,
    EndHeightLeft = 1698,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001135,
    Name = "C 170 - SAN JUAN",
    FullName = "C 170 - SAN JUAN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 4298,
    EndHeightLeft = 4199,
    StartHeightRight = 0,
    StartHeightLeft = 1,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002930,
    Name = "CACIQUE CHUYANTUYA",
    FullName = "CACIQUE CHUYANTUYA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003270,
    Name = "CALLE 79",
    FullName = "CALLE 79, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001145,
    Name = "C 172 - LA PAMPA",
    FullName = "C 172 - LA PAMPA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 3298,
    EndHeightLeft = 3399,
    StartHeightRight = 0,
    StartHeightLeft = 1,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001150,
    Name = "C 173 - MARIE CURIE",
    FullName = "C 173 - MARIE CURIE, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 7398,
    EndHeightLeft = 7399,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001155,
    Name = "C 174 - CHACO",
    FullName = "C 174 - CHACO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 4299,
    EndHeightLeft = 4298,
    StartHeightRight = 0,
    StartHeightLeft = 1,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001160,
    Name = "C 174 - LIBRES DEL SUD",
    FullName = "C 174 - LIBRES DEL SUD, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 2099,
    EndHeightLeft = 1998,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001165,
    Name = "C 174 - RCA DE CUBA",
    FullName = "C 174 - RCA DE CUBA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 3199,
    EndHeightLeft = 3198,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001420,
    Name = "C 20 - INT GRL RACEDO",
    FullName = "C 20 - INT GRL RACEDO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 5198,
    EndHeightLeft = 44989,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001170,
    Name = "C 175 - J M ESTRADA",
    FullName = "C 175 - J M ESTRADA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 14898,
    EndHeightLeft = 7299,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001175,
    Name = "C 176 - DE LOS INMIGRANTES",
    FullName = "C 176 - DE LOS INMIGRANTES, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 5899,
    EndHeightLeft = 2798,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001180,
    Name = "C 176 - FRAY MAMERTO ESQUIU",
    FullName = "C 176 - FRAY MAMERTO ESQUIU, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 2399,
    EndHeightLeft = 2398,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001185,
    Name = "C 176 - MISIONES",
    FullName = "C 176 - MISIONES, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 3399,
    EndHeightLeft = 3398,
    StartHeightRight = 0,
    StartHeightLeft = 1,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001190,
    Name = "C 177 - J A AGUIRRE",
    FullName = "C 177 - J A AGUIRRE, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 8099,
    EndHeightLeft = 8098,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001195,
    Name = "C 178 - INT J CAMUSO",
    FullName = "C 178 - INT J CAMUSO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 49999,
    EndHeightLeft = 2698,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007305,
    Name = "PJE 278 BIS",
    FullName = "PJE 278 BIS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "PJE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001200,
    Name = "C 178 - ITALIA",
    FullName = "C 178 - ITALIA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 4199,
    EndHeightLeft = 4198,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001205,
    Name = "C 178 - PASTEUR",
    FullName = "C 178 - PASTEUR, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 2799,
    EndHeightLeft = 2698,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001210,
    Name = "C 179 - A ALICE",
    FullName = "C 179 - A ALICE, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 8098,
    EndHeightLeft = 7999,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001215,
    Name = "C 18",
    FullName = "C 18, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001220,
    Name = "C 180 - MANUELA PEDRAZA",
    FullName = "C 180 - MANUELA PEDRAZA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 3099,
    EndHeightLeft = 2998,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003310,
    Name = "CALLE CANARIO",
    FullName = "CALLE CANARIO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001225,
    Name = "C 180 - NEUQUEN",
    FullName = "C 180 - NEUQUEN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 4199,
    EndHeightLeft = 4198,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001230,
    Name = "C 180 - OSVALDO MAGNASCO",
    FullName = "C 180 - OSVALDO MAGNASCO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 2799,
    EndHeightLeft = 2798,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001235,
    Name = "C 181 - ALFONSINA STORNI",
    FullName = "C 181 - ALFONSINA STORNI, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 7998,
    EndHeightLeft = 7899,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001240,
    Name = "C 182 - CEFERINO NAMUNCURA",
    FullName = "C 182 - CEFERINO NAMUNCURA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 2798,
    EndHeightLeft = 2799,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001245,
    Name = "C 182 - CHUBUT",
    FullName = "C 182 - CHUBUT, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 3099,
    EndHeightLeft = 3098,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002935,
    Name = "CALABRESE",
    FullName = "CALABRESE, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 3498,
    EndHeightLeft = 3399,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001250,
    Name = "C 182 - DON BOSCO",
    FullName = "C 182 - DON BOSCO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 4199,
    EndHeightLeft = 4198,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001255,
    Name = "C 183 - P MUGABURU",
    FullName = "C 183 - P MUGABURU, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 7998,
    EndHeightLeft = 7999,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001260,
    Name = "C 184 - FRANCIA",
    FullName = "C 184 - FRANCIA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 4999,
    EndHeightLeft = 4198,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001265,
    Name = "C 184 - H BRUMANA",
    FullName = "C 184 - H BRUMANA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 2798,
    EndHeightLeft = 4698,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001455,
    Name = "C 202 - J ORTEGA Y GASSET",
    FullName = "C 202 - J ORTEGA Y GASSET, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 2598,
    EndHeightLeft = 2999,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001270,
    Name = "C 185 - M SAGASTIZABAL",
    FullName = "C 185 - M SAGASTIZABAL, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 58798,
    EndHeightLeft = 7999,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001275,
    Name = "C 187 - J ACEVEDO",
    FullName = "C 187 - J ACEVEDO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 7999,
    EndHeightLeft = 8098,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001280,
    Name = "C 188 - 1 DE MAYO",
    FullName = "C 188 - 1 DE MAYO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 4199,
    EndHeightLeft = 4198,
    StartHeightRight = 1,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001285,
    Name = "C 188 - C C CERETTI",
    FullName = "C 188 - C C CERETTI, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 2799,
    EndHeightLeft = 2798,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001290,
    Name = "C 189 - C DAPROTIS",
    FullName = "C 189 - C DAPROTIS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 7998,
    EndHeightLeft = 8199,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002940,
    Name = "CALABRIA",
    FullName = "CALABRIA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001295,
    Name = "C 189 - VICENTE LOPEZ Y PLANES",
    FullName = "C 189 - VICENTE LOPEZ Y PLANES, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 3599,
    EndHeightLeft = 3598,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001300,
    Name = "C 19",
    FullName = "C 19, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001305,
    Name = "C 190 - BELISARIO ROLDAN",
    FullName = "C 190 - BELISARIO ROLDAN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 2598,
    EndHeightLeft = 2998,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001310,
    Name = "C 190 - INT G GUERRICO",
    FullName = "C 190 - INT G GUERRICO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 12996,
    EndHeightLeft = 2798,
    StartHeightRight = 501,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001315,
    Name = "C 190 - MARCONI",
    FullName = "C 190 - MARCONI, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 5199,
    EndHeightLeft = 4198,
    StartHeightRight = 1,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001345,
    Name = "C 193 - J LIJO LOPEZ",
    FullName = "C 193 - J LIJO LOPEZ, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 7998,
    EndHeightLeft = 7899,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001320,
    Name = "C 191 - J MARIANI",
    FullName = "C 191 - J MARIANI, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 7898,
    EndHeightLeft = 8099,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001325,
    Name = "C 192 - ARTIGAS",
    FullName = "C 192 - ARTIGAS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 2599,
    EndHeightLeft = 2598,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001330,
    Name = "C 192 - FITTE",
    FullName = "C 192 - FITTE, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 598,
    EndHeightLeft = 699,
    StartHeightRight = 0,
    StartHeightLeft = 1,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001335,
    Name = "C 192 - INT R INDA",
    FullName = "C 192 - INT R INDA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 3300,
    EndHeightLeft = 2798,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001340,
    Name = "C 192 - URUGUAY",
    FullName = "C 192 - URUGUAY, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 4199,
    EndHeightLeft = 5298,
    StartHeightRight = 1,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001350,
    Name = "C 194",
    FullName = "C 194, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 500,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001460,
    Name = "C 202 - JUAN FERNANDEZ",
    FullName = "C 202 - JUAN FERNANDEZ, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 699,
    EndHeightLeft = 598,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003315,
    Name = "CALLE LA CALANDRIA",
    FullName = "CALLE LA CALANDRIA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001355,
    Name = "C 194 - CHILE",
    FullName = "C 194 - CHILE, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 2999,
    EndHeightLeft = 4198,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001360,
    Name = "C 194 - DE LOS RESERVISTAS",
    FullName = "C 194 - DE LOS RESERVISTAS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 999,
    EndHeightLeft = 699,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001365,
    Name = "C 194 - INT F MARTINEZ DE HOZ",
    FullName = "C 194 - INT F MARTINEZ DE HOZ, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 2998,
    EndHeightLeft = 2999,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001370,
    Name = "C 195 - ARAGON",
    FullName = "C 195 - ARAGON, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 8398,
    EndHeightLeft = 8399,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001375,
    Name = "C 196 - INT J B GONI",
    FullName = "C 196 - INT J B GONI, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 3099,
    EndHeightLeft = 3098,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001380,
    Name = "C 196 - LABARDEN",
    FullName = "C 196 - LABARDEN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 698,
    EndHeightLeft = 699,
    StartHeightRight = 0,
    StartHeightLeft = 1,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001385,
    Name = "C 196 - MEJICO",
    FullName = "C 196 - MEJICO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 7798,
    EndHeightLeft = 3799,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003320,
    Name = "CALLE LAS MARGARITAS",
    FullName = "CALLE LAS MARGARITAS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001390,
    Name = "C 197 - CATALUNA",
    FullName = "C 197 - CATALUNA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 8399,
    EndHeightLeft = 8398,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001395,
    Name = "C 198 - LOBERIA",
    FullName = "C 198 - LOBERIA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 698,
    EndHeightLeft = 699,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001400,
    Name = "C 198 - PERU",
    FullName = "C 198 - PERU, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 3000,
    EndHeightLeft = 3000,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001405,
    Name = "C 198 - REFORMA UNIVERSITARIA",
    FullName = "C 198 - REFORMA UNIVERSITARIA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 4799,
    EndHeightLeft = 12983,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001410,
    Name = "C 2 BIS",
    FullName = "C 2 BIS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001415,
    Name = "C 20",
    FullName = "C 20, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002945,
    Name = "CALABRIA BIS B",
    FullName = "CALABRIA BIS B, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 7098,
    EndHeightLeft = 7099,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001425,
    Name = "C 200 - INT E PERALTA RAMOS",
    FullName = "C 200 - INT E PERALTA RAMOS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 3199,
    EndHeightLeft = 16983,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001430,
    Name = "C 200 - SAN CAYETANO",
    FullName = "C 200 - SAN CAYETANO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 698,
    EndHeightLeft = 699,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001435,
    Name = "C 200 - TIERRA DEL FUEGO",
    FullName = "C 200 - TIERRA DEL FUEGO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 3099,
    EndHeightLeft = 3000,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001440,
    Name = "C 200 TIERRA DEL FUEGO",
    FullName = "C 200 TIERRA DEL FUEGO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 3798,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001445,
    Name = "C 201 - VALENCIA",
    FullName = "C 201 - VALENCIA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 8198,
    EndHeightLeft = 9299,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001450,
    Name = "C 202 - INT D'HEGUILOR",
    FullName = "C 202 - INT D'HEGUILOR, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 58896,
    EndHeightLeft = 5898,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001550,
    Name = "C 21",
    FullName = "C 21, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001465,
    Name = "C 202 - TEODORO BRONZINI",
    FullName = "C 202 - TEODORO BRONZINI, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 3999,
    EndHeightLeft = 3498,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001470,
    Name = "C 203 - JUSTO L DE GOMARA",
    FullName = "C 203 - JUSTO L DE GOMARA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 8198,
    EndHeightLeft = 8199,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001475,
    Name = "C 204 - FINOCHIETTO",
    FullName = "C 204 - FINOCHIETTO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 699,
    EndHeightLeft = 698,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001480,
    Name = "C 204 - INT A MAC GAUL",
    FullName = "C 204 - INT A MAC GAUL, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 3199,
    EndHeightLeft = 6999,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001485,
    Name = "C 204 - MALVINAS",
    FullName = "C 204 - MALVINAS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 3999,
    EndHeightLeft = 3998,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001555,
    Name = "C 210 - ECHEGARAY",
    FullName = "C 210 - ECHEGARAY, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 1799,
    EndHeightLeft = 1798,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007310,
    Name = "PJE EL DANTE",
    FullName = "PJE EL DANTE, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "PJE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001490,
    Name = "C 204 - OLEGARIO ANDRADE",
    FullName = "C 204 - OLEGARIO ANDRADE, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 2199,
    EndHeightLeft = 2198,
    StartHeightRight = 1,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001495,
    Name = "C 205 - CONCEPCION ARENAL",
    FullName = "C 205 - CONCEPCION ARENAL, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 8098,
    EndHeightLeft = 8798,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001500,
    Name = "C 206 - CANESA",
    FullName = "C 206 - CANESA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 1899,
    EndHeightLeft = 698,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001505,
    Name = "C 206 - G DAIREAUX",
    FullName = "C 206 - G DAIREAUX, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 2999,
    EndHeightLeft = 2298,
    StartHeightRight = 1,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001510,
    Name = "C 206 - INT A VIGNOLO",
    FullName = "C 206 - INT A VIGNOLO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 3199,
    EndHeightLeft = 19835,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001515,
    Name = "C 206 - JUNCAL",
    FullName = "C 206 - JUNCAL, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 3999,
    EndHeightLeft = 3998,
    StartHeightRight = 1,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002950,
    Name = "CALANDRIA",
    FullName = "CALANDRIA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 399,
    EndHeightLeft = 298,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001520,
    Name = "C 207 - F ACOSTA",
    FullName = "C 207 - F ACOSTA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 7998,
    EndHeightLeft = 7999,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001525,
    Name = "C 208 - INT O OLAZAR",
    FullName = "C 208 - INT O OLAZAR, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 3199,
    EndHeightLeft = 3198,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001530,
    Name = "C 208 - RICARDO ROJAS",
    FullName = "C 208 - RICARDO ROJAS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 2098,
    EndHeightLeft = 2099,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001535,
    Name = "C 208 - SCARDATTI",
    FullName = "C 208 - SCARDATTI, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 1899,
    EndHeightLeft = 1898,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001540,
    Name = "C 208 - V MONTES",
    FullName = "C 208 - V MONTES, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 3998,
    EndHeightLeft = 5199,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001545,
    Name = "C 209 - JUAN PENA",
    FullName = "C 209 - JUAN PENA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 7798,
    EndHeightLeft = 7798,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002955,
    Name = "CALAZA BIS",
    FullName = "CALAZA BIS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001560,
    Name = "C 210 - JOAQUIN V GONZALEZ",
    FullName = "C 210 - JOAQUIN V GONZALEZ, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 2698,
    EndHeightLeft = 2599,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001565,
    Name = "C 210 AV V TETAMANTI",
    FullName = "C 210 AV V TETAMANTI, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "AV",
    EndHeightRight = 599,
    EndHeightLeft = 0,
    StartHeightRight = 101,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001570,
    Name = "C 211 - PADRE J CARDIEL",
    FullName = "C 211 - PADRE J CARDIEL, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 7798,
    EndHeightLeft = 7799,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001575,
    Name = "C 212 - JAURETCHE",
    FullName = "C 212 - JAURETCHE, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 1899,
    EndHeightLeft = 1898,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001580,
    Name = "C 212 - JOSE M GORRITI",
    FullName = "C 212 - JOSE M GORRITI, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 2198,
    EndHeightLeft = 2199,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001585,
    Name = "C 212 - MARIANO ACOSTA",
    FullName = "C 212 - MARIANO ACOSTA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 3899,
    EndHeightLeft = 3898,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001590,
    Name = "C 214 - BAHIA BLANCA",
    FullName = "C 214 - BAHIA BLANCA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 3898,
    EndHeightLeft = 3899,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003325,
    Name = "CALLE LAS PALMERAS",
    FullName = "CALLE LAS PALMERAS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001595,
    Name = "C 214 - MIGUEL DE UNAMUNO",
    FullName = "C 214 - MIGUEL DE UNAMUNO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 2999,
    EndHeightLeft = 2299,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001600,
    Name = "C 215 - MATIAS STROBEL",
    FullName = "C 215 - MATIAS STROBEL, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 7699,
    EndHeightLeft = 10098,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001605,
    Name = "C 216 - JUAN DE DIOS FILIBERTO",
    FullName = "C 216 - JUAN DE DIOS FILIBERTO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 1899,
    EndHeightLeft = 1898,
    StartHeightRight = 1101,
    StartHeightLeft = 1100,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001610,
    Name = "C 216 - REMOLCADOR GUARANI",
    FullName = "C 216 - REMOLCADOR GUARANI, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 2198,
    EndHeightLeft = 2199,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001615,
    Name = "C 216 - S E BORDABEHERE",
    FullName = "C 216 - S E BORDABEHERE, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 3899,
    EndHeightLeft = 3898,
    StartHeightRight = 0,
    StartHeightLeft = 1,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001620,
    Name = "C 218 - PROF DR MONTES CARBALLO",
    FullName = "C 218 - PROF DR MONTES CARBALLO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 2198,
    EndHeightLeft = 2599,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001750,
    Name = "C 230 - ERNESTO CHE GUEVARA",
    FullName = "C 230 - ERNESTO CHE GUEVARA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 1898,
    EndHeightLeft = 1899,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001625,
    Name = "C 218 - TRES ARROYOS",
    FullName = "C 218 - TRES ARROYOS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 3899,
    EndHeightLeft = 3898,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001630,
    Name = "C 219 - RIO NEGRO",
    FullName = "C 219 - RIO NEGRO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 7898,
    EndHeightLeft = 9999,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001635,
    Name = "C 22",
    FullName = "C 22, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001640,
    Name = "C 22 - THAMES",
    FullName = "C 22 - THAMES, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 5199,
    EndHeightLeft = 5198,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001645,
    Name = "C 220 - CIUDAD DE BRAGADO",
    FullName = "C 220 - CIUDAD DE BRAGADO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 1898,
    EndHeightLeft = 14999,
    StartHeightRight = 1100,
    StartHeightLeft = 1101,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001650,
    Name = "C 220 - RCA DEL LIBANO",
    FullName = "C 220 - RCA DEL LIBANO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 3399,
    EndHeightLeft = 3398,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001655,
    Name = "C 220 -TORRES DE VERA Y ARAGON",
    FullName = "C 220 -TORRES DE VERA Y ARAGON, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 1898,
    EndHeightLeft = 1899,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001660,
    Name = "C 220 BIS",
    FullName = "C 220 BIS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001665,
    Name = "C 221 - SANTA CRUZ",
    FullName = "C 221 - SANTA CRUZ, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 7879,
    EndHeightLeft = 7878,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001670,
    Name = "C 222 - CIUDAD DE LAS FLORES",
    FullName = "C 222 - CIUDAD DE LAS FLORES, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 1899,
    EndHeightLeft = 1898,
    StartHeightRight = 0,
    StartHeightLeft = 1100,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001675,
    Name = "C 222 - MARTINEZ ZUVIRIA",
    FullName = "C 222 - MARTINEZ ZUVIRIA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 2198,
    EndHeightLeft = 2199,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001680,
    Name = "C 223 - BERUTI",
    FullName = "C 223 - BERUTI, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 9099,
    EndHeightLeft = 10598,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001685,
    Name = "C 224 - DAVID ORTEGA",
    FullName = "C 224 - DAVID ORTEGA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 3399,
    EndHeightLeft = 3398,
    StartHeightRight = 1,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002960,
    Name = "CALCHAQUI",
    FullName = "CALCHAQUI, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 6698,
    EndHeightLeft = 6699,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003330,
    Name = "CALLE LOS NARANJOS",
    FullName = "CALLE LOS NARANJOS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001690,
    Name = "C 224 - SAN JOSE DE CALASANZ",
    FullName = "C 224 - SAN JOSE DE CALASANZ, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 2599,
    EndHeightLeft = 2598,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001695,
    Name = "C 224 - YAPEYU",
    FullName = "C 224 - YAPEYU, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 1799,
    EndHeightLeft = 1898,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001700,
    Name = "C 225 - FRENCH",
    FullName = "C 225 - FRENCH, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 9499,
    EndHeightLeft = 9798,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001705,
    Name = "C 226 - ESTADO DE ISRAEL",
    FullName = "C 226 - ESTADO DE ISRAEL, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 3799,
    EndHeightLeft = 3798,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001710,
    Name = "C 226 - JUAN BAUTISTA DE LA SALLE",
    FullName = "C 226 - JUAN BAUTISTA DE LA SALLE, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 2499,
    EndHeightLeft = 2499,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001715,
    Name = "C 226 - JUANA AZURDUY",
    FullName = "C 226 - JUANA AZURDUY, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 1899,
    EndHeightLeft = 1898,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001755,
    Name = "C 230 - FUNES DE MILLAN",
    FullName = "C 230 - FUNES DE MILLAN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 2498,
    EndHeightLeft = 2499,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001720,
    Name = "C 227 - BRANDSEN",
    FullName = "C 227 - BRANDSEN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 9798,
    EndHeightLeft = 77799,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001725,
    Name = "C 228",
    FullName = "C 228, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 1899,
    EndHeightLeft = 1898,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001730,
    Name = "C 228 - BELGICA",
    FullName = "C 228 - BELGICA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 2198,
    EndHeightLeft = 2299,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001735,
    Name = "C 228 - REMEDIOS DE ESCALADA",
    FullName = "C 228 - REMEDIOS DE ESCALADA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 3799,
    EndHeightLeft = 3798,
    StartHeightRight = 1,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001740,
    Name = "C 229 - NECOCHEA",
    FullName = "C 229 - NECOCHEA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 77699,
    EndHeightLeft = 9798,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001745,
    Name = "C 23",
    FullName = "C 23, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002965,
    Name = "CALFULCURA",
    FullName = "CALFULCURA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001760,
    Name = "C 230 - PAULA ALBARRACIN",
    FullName = "C 230 - PAULA ALBARRACIN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 3799,
    EndHeightLeft = 3798,
    StartHeightRight = 0,
    StartHeightLeft = 1,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001765,
    Name = "C 231 - ITUZAINGO",
    FullName = "C 231 - ITUZAINGO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 9799,
    EndHeightLeft = 8998,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001770,
    Name = "C 232",
    FullName = "C 232, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 1899,
    EndHeightLeft = 1898,
    StartHeightRight = 1101,
    StartHeightLeft = 1100,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001775,
    Name = "C 232 - GRECIA",
    FullName = "C 232 - GRECIA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 3799,
    EndHeightLeft = 3798,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001780,
    Name = "C 232 - PIRAN",
    FullName = "C 232 - PIRAN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 2398,
    EndHeightLeft = 2499,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001785,
    Name = "C 233 - AYACUCHO",
    FullName = "C 233 - AYACUCHO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 8999,
    EndHeightLeft = 8998,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003335,
    Name = "CALLE LOS TILOS",
    FullName = "CALLE LOS TILOS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001790,
    Name = "C 235 - CHACABUCO",
    FullName = "C 235 - CHACABUCO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 10499,
    EndHeightLeft = 10499,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001795,
    Name = "C 236 - PELAYO",
    FullName = "C 236 - PELAYO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 2198,
    EndHeightLeft = 7498,
    StartHeightRight = 0,
    StartHeightLeft = 200,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001800,
    Name = "C 236 - ARMENIA",
    FullName = "C 236 - ARMENIA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 3399,
    EndHeightLeft = 3398,
    StartHeightRight = 0,
    StartHeightLeft = 1,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001805,
    Name = "C 237 - MAIPU",
    FullName = "C 237 - MAIPU, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 10599,
    EndHeightLeft = 10598,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001810,
    Name = "C 238 - JOVELLANOS",
    FullName = "C 238 - JOVELLANOS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 2099,
    EndHeightLeft = 2098,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001815,
    Name = "C 238 - TERMAS DE RIO HONDO",
    FullName = "C 238 - TERMAS DE RIO HONDO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 3399,
    EndHeightLeft = 3398,
    StartHeightRight = 1,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004015,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001820,
    Name = "C 24",
    FullName = "C 24, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001825,
    Name = "C 24 - SERRANO",
    FullName = "C 24 - SERRANO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 5098,
    EndHeightLeft = 5098,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001830,
    Name = "C 240 - ARRUE",
    FullName = "C 240 - ARRUE, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 2999,
    EndHeightLeft = 2998,
    StartHeightRight = 1,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001835,
    Name = "C 240 - ASTURIAS",
    FullName = "C 240 - ASTURIAS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 1899,
    EndHeightLeft = 1928,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001840,
    Name = "C 241 - BALCARCE",
    FullName = "C 241 - BALCARCE, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 10749,
    EndHeightLeft = 77898,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001930,
    Name = "C 253 - M CHILABERT",
    FullName = "C 253 - M CHILABERT, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 2999,
    EndHeightLeft = 2998,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001845,
    Name = "C 242 - C SUAREZ",
    FullName = "C 242 - C SUAREZ, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 3599,
    EndHeightLeft = 3598,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001850,
    Name = "C 242 - RIZZUTO",
    FullName = "C 242 - RIZZUTO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 1899,
    EndHeightLeft = 1898,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001855,
    Name = "C 243 - 11 DE SEPTIEMBRE",
    FullName = "C 243 - 11 DE SEPTIEMBRE, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 10798,
    EndHeightLeft = 10799,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001860,
    Name = "C 244 - C M CALAZA",
    FullName = "C 244 - C M CALAZA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 2999,
    EndHeightLeft = 2998,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001865,
    Name = "C 244 - LUZURIAGA",
    FullName = "C 244 - LUZURIAGA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 1798,
    EndHeightLeft = 1799,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002020,
    Name = "C 264 - FAGNANI",
    FullName = "C 264 - FAGNANI, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 1299,
    EndHeightLeft = 1298,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003110,
    Name = "CALLE 34",
    FullName = "CALLE 34, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001870,
    Name = "C 245 - 3 DE FEBRERO",
    FullName = "C 245 - 3 DE FEBRERO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 37987,
    EndHeightLeft = 10799,
    StartHeightRight = 2300,
    StartHeightLeft = 2301,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001875,
    Name = "C 246 - C RAUCH",
    FullName = "C 246 - C RAUCH, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 2999,
    EndHeightLeft = 2998,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001880,
    Name = "C 246 - LORENZINI",
    FullName = "C 246 - LORENZINI, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 1599,
    EndHeightLeft = 2099,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001885,
    Name = "C 247 - 9 DE JULIO",
    FullName = "C 247 - 9 DE JULIO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 10798,
    EndHeightLeft = 10799,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001890,
    Name = "C 248 - L CANDELARIA",
    FullName = "C 248 - L CANDELARIA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 1599,
    EndHeightLeft = 8098,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003115,
    Name = "CALLE 35",
    FullName = "CALLE 35, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007315,
    Name = "PJE JUAN M DE ROSAS",
    FullName = "PJE JUAN M DE ROSAS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "PJE",
    EndHeightRight = 8999,
    EndHeightLeft = 8999,
    StartHeightRight = 8801,
    StartHeightLeft = 8801,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001895,
    Name = "C 249 - 25 DE MAYO",
    FullName = "C 249 - 25 DE MAYO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 10798,
    EndHeightLeft = 10799,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001900,
    Name = "C 25 - VOLCAN COPAHUE",
    FullName = "C 25 - VOLCAN COPAHUE, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001905,
    Name = "C 250 - BRADLEY",
    FullName = "C 250 - BRADLEY, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 1399,
    EndHeightLeft = 8198,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001910,
    Name = "C 251 - JUAN N CZETZ",
    FullName = "C 251 - JUAN N CZETZ, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 3099,
    EndHeightLeft = 3598,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001915,
    Name = "C 252 - ANGEL GARDELLA",
    FullName = "C 252 - ANGEL GARDELLA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 2199,
    EndHeightLeft = 2198,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001920,
    Name = "C 252 - CNL J ACOSTA",
    FullName = "C 252 - CNL J ACOSTA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 2999,
    EndHeightLeft = 2998,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001925,
    Name = "C 252 - PEDRO ZANNI",
    FullName = "C 252 - PEDRO ZANNI, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 1498,
    EndHeightLeft = 1699,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002120,
    Name = "C 28 - BUSTAMANTE",
    FullName = "C 28 - BUSTAMANTE, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 5198,
    EndHeightLeft = 5299,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001935,
    Name = "C 253 - SAN MARTIN",
    FullName = "C 253 - SAN MARTIN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 39998,
    EndHeightLeft = 10698,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001940,
    Name = "C 254 - NUESTRA SRA DEL PILAR",
    FullName = "C 254 - NUESTRA SRA DEL PILAR, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 999,
    StartHeightRight = 0,
    StartHeightLeft = 701,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001945,
    Name = "C 254 - TANDIL",
    FullName = "C 254 - TANDIL, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 2998,
    EndHeightLeft = 2999,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001950,
    Name = "C 255 - RIVADAVIA",
    FullName = "C 255 - RIVADAVIA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 10898,
    EndHeightLeft = 10699,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001955,
    Name = "C 256 - LEOPOLDO MENDEZ",
    FullName = "C 256 - LEOPOLDO MENDEZ, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001960,
    Name = "C 256 - PIGUE",
    FullName = "C 256 - PIGUE, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 5999,
    EndHeightLeft = 2498,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007550,
    Name = "ROBERTO ARLT",
    FullName = "ROBERTO ARLT, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 5899,
    StartHeightRight = 0,
    StartHeightLeft = 5801,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001965,
    Name = "C 257 - BELGRANO",
    FullName = "C 257 - BELGRANO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 10899,
    EndHeightLeft = 10999,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001970,
    Name = "C 258 - BOLIVIA",
    FullName = "C 258 - BOLIVIA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 2599,
    EndHeightLeft = 2498,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001975,
    Name = "C 258 - COUREL",
    FullName = "C 258 - COUREL, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 899,
    EndHeightLeft = 998,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001980,
    Name = "C 259 - MORENO",
    FullName = "C 259 - MORENO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 10998,
    EndHeightLeft = 10999,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001985,
    Name = "C 26",
    FullName = "C 26, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002125,
    Name = "C 280 - M A CASTELLANO",
    FullName = "C 280 - M A CASTELLANO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 199,
    EndHeightLeft = 198,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007725,
    Name = "SANTA MARIA",
    FullName = "SANTA MARIA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001990,
    Name = "C 26 - SANTA MARIA DE ORO",
    FullName = "C 26 - SANTA MARIA DE ORO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 4998,
    EndHeightLeft = 4999,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711001995,
    Name = "C 260 - BRASIL",
    FullName = "C 260 - BRASIL, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 8999,
    EndHeightLeft = 2598,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002000,
    Name = "C 261 - BOLIVAR",
    FullName = "C 261 - BOLIVAR, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 10998,
    EndHeightLeft = 10999,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002005,
    Name = "C 262 - PARAGUAY",
    FullName = "C 262 - PARAGUAY, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 2599,
    EndHeightLeft = 2598,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002010,
    Name = "C 262 - RODRIGUEZ",
    FullName = "C 262 - RODRIGUEZ, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 999,
    EndHeightLeft = 998,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002015,
    Name = "C 264 - DR G BAILEY",
    FullName = "C 264 - DR G BAILEY, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 2599,
    EndHeightLeft = 2599,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004020,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002025,
    Name = "C 265 - ALMTE BROWN",
    FullName = "C 265 - ALMTE BROWN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 8998,
    EndHeightLeft = 8899,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002030,
    Name = "C 266 - LEGUIZAMON",
    FullName = "C 266 - LEGUIZAMON, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 3498,
    EndHeightLeft = 2199,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002035,
    Name = "C 266 - STAGNANI",
    FullName = "C 266 - STAGNANI, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 1298,
    EndHeightLeft = 895,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002040,
    Name = "C 267 - FALUCHO",
    FullName = "C 267 - FALUCHO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 8999,
    EndHeightLeft = 8998,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002045,
    Name = "C 268 - WILDE",
    FullName = "C 268 - WILDE, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 2198,
    EndHeightLeft = 2199,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004025,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002050,
    Name = "C 269 - GASCON",
    FullName = "C 269 - GASCON, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 8999,
    EndHeightLeft = 8998,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002055,
    Name = "C 27",
    FullName = "C 27, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002060,
    Name = "C 270 - CANADA",
    FullName = "C 270 - CANADA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 2199,
    EndHeightLeft = 2198,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002065,
    Name = "C 271 - ALBERTI",
    FullName = "C 271 - ALBERTI, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 27987,
    EndHeightLeft = 8998,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002070,
    Name = "C 272 - RCA ARABE SIRIA",
    FullName = "C 272 - RCA ARABE SIRIA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 2198,
    EndHeightLeft = 2199,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002075,
    Name = "C 273 - RAWSON",
    FullName = "C 273 - RAWSON, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 7999,
    EndHeightLeft = 7998,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002080,
    Name = "C 274 - DANTE ALIGHIERI",
    FullName = "C 274 - DANTE ALIGHIERI, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 2199,
    EndHeightLeft = 2198,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002085,
    Name = "C 275 - GARAY",
    FullName = "C 275 - GARAY, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 8399,
    EndHeightLeft = 8398,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002090,
    Name = "C 276 - ECUADOR",
    FullName = "C 276 - ECUADOR, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 1598,
    EndHeightLeft = 1599,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002130,
    Name = "C 280 - VENEZUELA",
    FullName = "C 280 - VENEZUELA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 1598,
    EndHeightLeft = 1599,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004030,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002095,
    Name = "C 277 - CASTELLI",
    FullName = "C 277 - CASTELLI, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 8399,
    EndHeightLeft = 44498,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002100,
    Name = "C 278 - COLOMBIA",
    FullName = "C 278 - COLOMBIA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 1598,
    EndHeightLeft = 1599,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002105,
    Name = "C 278 - JOSE R BALET",
    FullName = "C 278 - JOSE R BALET, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 199,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002110,
    Name = "C 279 - ALVARADO",
    FullName = "C 279 - ALVARADO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 8999,
    EndHeightLeft = 8999,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002115,
    Name = "C 28",
    FullName = "C 28, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003275,
    Name = "CALLE 8",
    FullName = "CALLE 8, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004035,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002135,
    Name = "C 281 - AVELLANEDA",
    FullName = "C 281 - AVELLANEDA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 7599,
    EndHeightLeft = 7599,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002140,
    Name = "C 283 - SAN LORENZO",
    FullName = "C 283 - SAN LORENZO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 7698,
    EndHeightLeft = 7799,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002145,
    Name = "C 284 - GUYANA",
    FullName = "C 284 - GUYANA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 2198,
    EndHeightLeft = 2199,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002150,
    Name = "C 285 - GRL ROCA",
    FullName = "C 285 - GRL ROCA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 7798,
    EndHeightLeft = 7799,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002155,
    Name = "C 286 - TRINIDAD Y TOBAGO",
    FullName = "C 286 - TRINIDAD Y TOBAGO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 1798,
    EndHeightLeft = 1799,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003340,
    Name = "CALLE N 2",
    FullName = "CALLE N 2, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002160,
    Name = "C 287 - RODRIGUEZ PENA",
    FullName = "C 287 - RODRIGUEZ PENA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 7598,
    EndHeightLeft = 7599,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002165,
    Name = "C 288 - ROSARIO",
    FullName = "C 288 - ROSARIO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 1899,
    EndHeightLeft = 1798,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002170,
    Name = "C 289 - PRIMERA JUNTA",
    FullName = "C 289 - PRIMERA JUNTA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 7398,
    EndHeightLeft = 7399,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002175,
    Name = "C 29",
    FullName = "C 29, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002180,
    Name = "C 290 - MADARIAGA",
    FullName = "C 290 - MADARIAGA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 1999,
    EndHeightLeft = 1998,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002185,
    Name = "C 291 - SAAVEDRA",
    FullName = "C 291 - SAAVEDRA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 7398,
    EndHeightLeft = 7999,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002190,
    Name = "C 292 - ESPERANTO",
    FullName = "C 292 - ESPERANTO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003345,
    Name = "CALLE N 1",
    FullName = "CALLE N 1, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004165,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002195,
    Name = "C 293 - QUINTANA",
    FullName = "C 293 - QUINTANA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 7398,
    EndHeightLeft = 7399,
    StartHeightRight = 0,
    StartHeightLeft = 1,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002200,
    Name = "C 294 - ANGELELLI",
    FullName = "C 294 - ANGELELLI, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 2198,
    EndHeightLeft = 2199,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002205,
    Name = "C 295 - MATHEU",
    FullName = "C 295 - MATHEU, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 6598,
    EndHeightLeft = 6599,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002210,
    Name = "C 296 - AMAYA",
    FullName = "C 296 - AMAYA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 2198,
    EndHeightLeft = 2199,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002215,
    Name = "C 297 - FORMOSA",
    FullName = "C 297 - FORMOSA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 6199,
    EndHeightLeft = 6198,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002290,
    Name = "C 34 - PACHECO DE MELO",
    FullName = "C 34 - PACHECO DE MELO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 44989,
    EndHeightLeft = 48999,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002220,
    Name = "C 299 - ALMAFUERTE",
    FullName = "C 299 - ALMAFUERTE, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 5298,
    EndHeightLeft = 5299,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002225,
    Name = "C 30",
    FullName = "C 30, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002230,
    Name = "C 30 - A SAENZ",
    FullName = "C 30 - A SAENZ, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 32499,
    EndHeightLeft = 47398,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002235,
    Name = "C 30 - BIS - JOSE ALONSO",
    FullName = "C 30 - BIS - JOSE ALONSO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 4198,
    EndHeightLeft = 3499,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002240,
    Name = "C 301 - LAPRIDA",
    FullName = "C 301 - LAPRIDA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 5199,
    EndHeightLeft = 5198,
    StartHeightRight = 700,
    StartHeightLeft = 701,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002245,
    Name = "C 306 - VIEYTES",
    FullName = "C 306 - VIEYTES, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 3999,
    EndHeightLeft = 3998,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003350,
    Name = "CALLE N 11",
    FullName = "CALLE N 11, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004167,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002250,
    Name = "C 307 - LARREA",
    FullName = "C 307 - LARREA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 3598,
    EndHeightLeft = 3599,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002255,
    Name = "C 309 - AZCUENAGA",
    FullName = "C 309 - AZCUENAGA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 3099,
    EndHeightLeft = 3998,
    StartHeightRight = 0,
    StartHeightLeft = 200,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002260,
    Name = "C 311 - PRINGLES",
    FullName = "C 311 - PRINGLES, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 2599,
    EndHeightLeft = 2598,
    StartHeightRight = 201,
    StartHeightLeft = 200,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002265,
    Name = "C 313 - O'HIGGINS",
    FullName = "C 313 - O'HIGGINS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 2098,
    EndHeightLeft = 2099,
    StartHeightRight = 0,
    StartHeightLeft = 201,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002270,
    Name = "C 315 - MARTIN RODRIGUEZ",
    FullName = "C 315 - MARTIN RODRIGUEZ, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 1598,
    EndHeightLeft = 1599,
    StartHeightRight = 200,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002275,
    Name = "C 317 - VICENTE LOPEZ",
    FullName = "C 317 - VICENTE LOPEZ, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 1199,
    EndHeightLeft = 1198,
    StartHeightRight = 201,
    StartHeightLeft = 100,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002280,
    Name = "C 32",
    FullName = "C 32, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002285,
    Name = "C 32 - C RODRIGUEZ",
    FullName = "C 32 - C RODRIGUEZ, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 35800,
    EndHeightLeft = 4799,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004365,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002295,
    Name = "C 347 - AZOPARDO",
    FullName = "C 347 - AZOPARDO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 82696,
    EndHeightLeft = 11899,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002300,
    Name = "C 349 - BOUCHARD",
    FullName = "C 349 - BOUCHARD, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 11899,
    EndHeightLeft = 11899,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002305,
    Name = "C 351 - ROSALES",
    FullName = "C 351 - ROSALES, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 11899,
    EndHeightLeft = 11898,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002385,
    Name = "C 38 - DE LA MAZA",
    FullName = "C 38 - DE LA MAZA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 5198,
    EndHeightLeft = 3799,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004370,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004375,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002310,
    Name = "C 353 - T DEL FOURNIER",
    FullName = "C 353 - T DEL FOURNIER, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 11899,
    EndHeightLeft = 89989,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002315,
    Name = "C 355 - SOLER",
    FullName = "C 355 - SOLER, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 11899,
    EndHeightLeft = 11899,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002320,
    Name = "C 357 - S DE ARANA Y GOIRI",
    FullName = "C 357 - S DE ARANA Y GOIRI, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 89198,
    EndHeightLeft = 84199,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002430,
    Name = "C 427",
    FullName = "C 427, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002325,
    Name = "C 359 - EDUARDO G CARASA",
    FullName = "C 359 - EDUARDO G CARASA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 9499,
    EndHeightLeft = 90998,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002330,
    Name = "C 36 - P MEDRANO",
    FullName = "C 36 - P MEDRANO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 39898,
    EndHeightLeft = 5099,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002335,
    Name = "C 363 - MOISES LEBENSHON",
    FullName = "C 363 - MOISES LEBENSHON, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 8398,
    EndHeightLeft = 8399,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002340,
    Name = "C 365 - PUAN",
    FullName = "C 365 - PUAN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 8699,
    EndHeightLeft = 8698,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002435,
    Name = "C 427 - BIS",
    FullName = "C 427 - BIS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003460,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002345,
    Name = "C 367 - NAPOLES",
    FullName = "C 367 - NAPOLES, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 24989,
    EndHeightLeft = 9999,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002350,
    Name = "C 369 - GENOVA",
    FullName = "C 369 - GENOVA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 9098,
    EndHeightLeft = 8999,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002355,
    Name = "C 37",
    FullName = "C 37, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002360,
    Name = "C 371 - SICILIA",
    FullName = "C 371 - SICILIA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 9098,
    EndHeightLeft = 9099,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002465,
    Name = "C 433 BIS",
    FullName = "C 433 BIS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002365,
    Name = "C 373 - CALABRIA",
    FullName = "C 373 - CALABRIA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 9299,
    EndHeightLeft = 9298,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002370,
    Name = "C 375 - GUTENBERG",
    FullName = "C 375 - GUTENBERG, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 9498,
    EndHeightLeft = 9499,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002375,
    Name = "C 377 - WILLIAM MORRIS",
    FullName = "C 377 - WILLIAM MORRIS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 9498,
    EndHeightLeft = 9499,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002380,
    Name = "C 379 - RICARDO GUIRALDES",
    FullName = "C 379 - RICARDO GUIRALDES, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 9498,
    EndHeightLeft = 9499,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004380,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002390,
    Name = "C 381 - GARCIA LORCA",
    FullName = "C 381 - GARCIA LORCA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 9499,
    EndHeightLeft = 9498,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002395,
    Name = "C 383 - B LYNCH",
    FullName = "C 383 - B LYNCH, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 9499,
    EndHeightLeft = 9498,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002400,
    Name = "C 4",
    FullName = "C 4, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 899,
    EndHeightLeft = 798,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002405,
    Name = "C 4 BIS",
    FullName = "C 4 BIS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002410,
    Name = "C 40 - MALABIA",
    FullName = "C 40 - MALABIA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 3798,
    EndHeightLeft = 3799,
    StartHeightRight = 0,
    StartHeightLeft = 320,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002415,
    Name = "C 413",
    FullName = "C 413, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002420,
    Name = "C 415",
    FullName = "C 415, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002425,
    Name = "C 42 - MONSENOR MIGUEL DE ANDREA",
    FullName = "C 42 - MONSENOR MIGUEL DE ANDREA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 3799,
    EndHeightLeft = 37983,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003465,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 9498,
    EndHeightLeft = 1598,
    StartHeightRight = 1501,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002440,
    Name = "C 429",
    FullName = "C 429, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002445,
    Name = "C 429 BIS",
    FullName = "C 429 BIS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002450,
    Name = "C 431",
    FullName = "C 431, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002455,
    Name = "C 431 BIS",
    FullName = "C 431 BIS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002460,
    Name = "C 433",
    FullName = "C 433, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002550,
    Name = "C 463",
    FullName = "C 463, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003470,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002470,
    Name = "C 435",
    FullName = "C 435, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 399,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002475,
    Name = "C 437",
    FullName = "C 437, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 398,
    EndHeightLeft = 399,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002480,
    Name = "C 439",
    FullName = "C 439, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 399,
    EndHeightLeft = 398,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002485,
    Name = "C 44 - DARRAGUEIRA",
    FullName = "C 44 - DARRAGUEIRA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 3799,
    EndHeightLeft = 3798,
    StartHeightRight = 2701,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002490,
    Name = "C 441",
    FullName = "C 441, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 378,
    EndHeightLeft = 399,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002495,
    Name = "C 443",
    FullName = "C 443, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 399,
    EndHeightLeft = 398,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002500,
    Name = "C 445",
    FullName = "C 445, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 398,
    EndHeightLeft = 398,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002505,
    Name = "C 447",
    FullName = "C 447, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 399,
    EndHeightLeft = 398,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002510,
    Name = "C 449",
    FullName = "C 449, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 398,
    EndHeightLeft = 399,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002515,
    Name = "C 451",
    FullName = "C 451, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 399,
    EndHeightLeft = 398,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002520,
    Name = "C 453",
    FullName = "C 453, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 398,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002525,
    Name = "C 455",
    FullName = "C 455, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002530,
    Name = "C 457",
    FullName = "C 457, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002535,
    Name = "C 459",
    FullName = "C 459, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002540,
    Name = "C 46 - COLOMBRES",
    FullName = "C 46 - COLOMBRES, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 3798,
    EndHeightLeft = 3799,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002545,
    Name = "C 461",
    FullName = "C 461, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003475,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002565,
    Name = "C 469",
    FullName = "C 469, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002570,
    Name = "C 471",
    FullName = "C 471, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002575,
    Name = "C 473",
    FullName = "C 473, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002580,
    Name = "C 475",
    FullName = "C 475, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002585,
    Name = "C 477",
    FullName = "C 477, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002590,
    Name = "C 479",
    FullName = "C 479, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002595,
    Name = "C 48 - CASTRO BARROS",
    FullName = "C 48 - CASTRO BARROS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 3698,
    EndHeightLeft = 3799,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002600,
    Name = "C 481",
    FullName = "C 481, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002605,
    Name = "C 483",
    FullName = "C 483, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002610,
    Name = "C 485",
    FullName = "C 485, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002970,
    Name = "CALLE 0",
    FullName = "CALLE 0, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 898,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002615,
    Name = "C 487",
    FullName = "C 487, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002620,
    Name = "C 489",
    FullName = "C 489, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002625,
    Name = "C 491",
    FullName = "C 491, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002630,
    Name = "C 493",
    FullName = "C 493, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002635,
    Name = "C 495",
    FullName = "C 495, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002640,
    Name = "C 497",
    FullName = "C 497, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002645,
    Name = "C 499",
    FullName = "C 499, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002650,
    Name = "C 50 - CABRERA",
    FullName = "C 50 - CABRERA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 3698,
    EndHeightLeft = 33999,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002655,
    Name = "C 501",
    FullName = "C 501, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003480,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002660,
    Name = "C 503",
    FullName = "C 503, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002665,
    Name = "C 505",
    FullName = "C 505, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002670,
    Name = "C 507",
    FullName = "C 507, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002675,
    Name = "C 509",
    FullName = "C 509, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002680,
    Name = "C 511",
    FullName = "C 511, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002685,
    Name = "C 513",
    FullName = "C 513, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002690,
    Name = "C 515",
    FullName = "C 515, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002695,
    Name = "C 52 - PEREZ BULNES",
    FullName = "C 52 - PEREZ BULNES, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 3698,
    EndHeightLeft = 3699,
    StartHeightRight = 0,
    StartHeightLeft = 2300,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002700,
    Name = "C 54 - P M ARAOZ",
    FullName = "C 54 - P M ARAOZ, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 3199,
    EndHeightLeft = 3198,
    StartHeightRight = 2201,
    StartHeightLeft = 2200,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002715,
    Name = "C 6",
    FullName = "C 6, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 898,
    EndHeightLeft = 899,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002720,
    Name = "C 6 - BIS",
    FullName = "C 6 - BIS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002725,
    Name = "C 60 - CROCCE",
    FullName = "C 60 - CROCCE, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 3099,
    EndHeightLeft = 3198,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002730,
    Name = "C 62 - VERGARA",
    FullName = "C 62 - VERGARA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 3099,
    EndHeightLeft = 3198,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002735,
    Name = "C 64 - G GIACOMINI",
    FullName = "C 64 - G GIACOMINI, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 3199,
    EndHeightLeft = 2998,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002740,
    Name = "C 68 - LUIS VERNET",
    FullName = "C 68 - LUIS VERNET, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 3199,
    EndHeightLeft = 3098,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002745,
    Name = "C 70 - PIEDRABUENA",
    FullName = "C 70 - PIEDRABUENA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 3199,
    EndHeightLeft = 3198,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003665,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002750,
    Name = "C 72 - JUAN VUCETICH",
    FullName = "C 72 - JUAN VUCETICH, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 3199,
    EndHeightLeft = 3198,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002755,
    Name = "C 74 - GRL MOSCONI",
    FullName = "C 74 - GRL MOSCONI, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 3199,
    EndHeightLeft = 3198,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002760,
    Name = "C 76 - A AGUADO",
    FullName = "C 76 - A AGUADO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 3099,
    EndHeightLeft = 3198,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002765,
    Name = "C 78 - ALBERT EINSTEIN",
    FullName = "C 78 - ALBERT EINSTEIN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 3199,
    EndHeightLeft = 3926,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002770,
    Name = "C 8",
    FullName = "C 8, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 899,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002775,
    Name = "C 8 BIS",
    FullName = "C 8 BIS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002975,
    Name = "CALLE 1 - LOMA VERDE",
    FullName = "CALLE 1 - LOMA VERDE, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002780,
    Name = "C 80 - IGR BELTRAMI",
    FullName = "C 80 - IGR BELTRAMI, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 3199,
    EndHeightLeft = 3198,
    StartHeightRight = 601,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002785,
    Name = "C 82 - PESCADORES",
    FullName = "C 82 - PESCADORES, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 3098,
    EndHeightLeft = 3199,
    StartHeightRight = 0,
    StartHeightLeft = 400,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002790,
    Name = "C 84 - FIGUEROA ALCORTA",
    FullName = "C 84 - FIGUEROA ALCORTA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 3199,
    EndHeightLeft = 3199,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002795,
    Name = "C 85 - S THOEL",
    FullName = "C 85 - S THOEL, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 6699,
    EndHeightLeft = 6499,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002800,
    Name = "C 86 - BERMEJO",
    FullName = "C 86 - BERMEJO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 3099,
    EndHeightLeft = 3098,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002805,
    Name = "C 88 - A DEL VALLE",
    FullName = "C 88 - A DEL VALLE, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 3999,
    EndHeightLeft = 3998,
    StartHeightRight = 2301,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002810,
    Name = "C 88 - ACHA",
    FullName = "C 88 - ACHA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 3199,
    EndHeightLeft = 3198,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002815,
    Name = "C 90 - LEANDRO N ALEM",
    FullName = "C 90 - LEANDRO N ALEM, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 5099,
    EndHeightLeft = 3998,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002820,
    Name = "C 92 - BERNARDO DE IRIGOYEN",
    FullName = "C 92 - BERNARDO DE IRIGOYEN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 5099,
    EndHeightLeft = 5098,
    StartHeightRight = 2401,
    StartHeightLeft = 2402,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002825,
    Name = "C 92 - POSADAS",
    FullName = "C 92 - POSADAS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 3198,
    EndHeightLeft = 3099,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002830,
    Name = "C 94 - CARLOS PELLEGRINI",
    FullName = "C 94 - CARLOS PELLEGRINI, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 5099,
    EndHeightLeft = 5098,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002835,
    Name = "C 94 - RONDEAU",
    FullName = "C 94 - RONDEAU, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 3199,
    EndHeightLeft = 3098,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002980,
    Name = "CALLE 1 ( BELTRAN BIS)",
    FullName = "CALLE 1 ( BELTRAN BIS), Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002985,
    Name = "CALLE 1 B",
    FullName = "CALLE 1 B, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003280,
    Name = "CALLE 8 BIS",
    FullName = "CALLE 8 BIS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002840,
    Name = "C 96 - PADRE J DUTTO",
    FullName = "C 96 - PADRE J DUTTO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 3199,
    EndHeightLeft = 3198,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002845,
    Name = "C 96 - URQUIZA",
    FullName = "C 96 - URQUIZA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 5099,
    EndHeightLeft = 5098,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002850,
    Name = "C 98 - GRL PAZ",
    FullName = "C 98 - GRL PAZ, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 7499,
    EndHeightLeft = 4998,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002855,
    Name = "C 98 - TRIUNVIRATO",
    FullName = "C 98 - TRIUNVIRATO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 3199,
    EndHeightLeft = 3198,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002860,
    Name = "C BERRA",
    FullName = "C BERRA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002865,
    Name = "C DAGLIO",
    FullName = "C DAGLIO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 3498,
    EndHeightLeft = 3899,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002870,
    Name = "C MANRIQUE",
    FullName = "C MANRIQUE, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002875,
    Name = "C MARTIN",
    FullName = "C MARTIN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 799,
    EndHeightLeft = 798,
    StartHeightRight = 301,
    StartHeightLeft = 300,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002880,
    Name = "C PAMPEANA",
    FullName = "C PAMPEANA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002885,
    Name = "C SUAREZ BIS",
    FullName = "C SUAREZ BIS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002890,
    Name = "C 1",
    FullName = "C 1, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002895,
    Name = "C 10",
    FullName = "C 10, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002990,
    Name = "CALLE 10",
    FullName = "CALLE 10, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711002995,
    Name = "CALLE 10 BIS",
    FullName = "CALLE 10 BIS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003000,
    Name = "CALLE 11",
    FullName = "CALLE 11, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003005,
    Name = "CALLE 13",
    FullName = "CALLE 13, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003010,
    Name = "CALLE 14 BIS",
    FullName = "CALLE 14 BIS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003015,
    Name = "CALLE 17",
    FullName = "CALLE 17, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003020,
    Name = "CALLE 2",
    FullName = "CALLE 2, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 599,
    EndHeightLeft = 798,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003025,
    Name = "CALLE 200",
    FullName = "CALLE 200, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003030,
    Name = "CALLE 209 BIS",
    FullName = "CALLE 209 BIS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003035,
    Name = "CALLE 211 BIS",
    FullName = "CALLE 211 BIS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003040,
    Name = "CALLE 228 BIS",
    FullName = "CALLE 228 BIS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003045,
    Name = "CALLE 252 (EX 232)",
    FullName = "CALLE 252 (EX 232), Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003050,
    Name = "CALLE 254",
    FullName = "CALLE 254, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 1798,
    EndHeightLeft = 1899,
    StartHeightRight = 0,
    StartHeightLeft = 1101,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003055,
    Name = "CALLE 254 (EX 234)",
    FullName = "CALLE 254 (EX 234), Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003060,
    Name = "CALLE 256",
    FullName = "CALLE 256, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 1899,
    EndHeightLeft = 1898,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003065,
    Name = "CALLE 256 (EX 238)",
    FullName = "CALLE 256 (EX 238), Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003070,
    Name = "CALLE 258",
    FullName = "CALLE 258, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003075,
    Name = "CALLE 258 (EX 258)",
    FullName = "CALLE 258 (EX 258), Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 1798,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003080,
    Name = "CALLE 270 BIS",
    FullName = "CALLE 270 BIS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003085,
    Name = "CALLE 272 BIS",
    FullName = "CALLE 272 BIS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003120,
    Name = "CALLE 4",
    FullName = "CALLE 4, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003125,
    Name = "CALLE 4 BIS",
    FullName = "CALLE 4 BIS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003130,
    Name = "CALLE 40",
    FullName = "CALLE 40, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003135,
    Name = "CALLE 42",
    FullName = "CALLE 42, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003140,
    Name = "CALLE 44",
    FullName = "CALLE 44, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003145,
    Name = "CALLE 46",
    FullName = "CALLE 46, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003150,
    Name = "CALLE 48",
    FullName = "CALLE 48, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003155,
    Name = "CALLE 5",
    FullName = "CALLE 5, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003160,
    Name = "CALLE 50",
    FullName = "CALLE 50, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003165,
    Name = "CALLE 509",
    FullName = "CALLE 509, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003170,
    Name = "CALLE 52",
    FullName = "CALLE 52, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003175,
    Name = "CALLE 54",
    FullName = "CALLE 54, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003265,
    Name = "CALLE 75 - BONNET",
    FullName = "CALLE 75 - BONNET, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 1098,
    EndHeightLeft = 1099,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003180,
    Name = "CALLE 58",
    FullName = "CALLE 58, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003185,
    Name = "CALLE 6",
    FullName = "CALLE 6, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003190,
    Name = "CALLE 6 BIS",
    FullName = "CALLE 6 BIS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003195,
    Name = "CALLE 63 BIS",
    FullName = "CALLE 63 BIS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 4598,
    EndHeightLeft = 0,
    StartHeightRight = 4500,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003200,
    Name = "CALLE 65",
    FullName = "CALLE 65, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003205,
    Name = "CALLE 66",
    FullName = "CALLE 66, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003210,
    Name = "CALLE 67",
    FullName = "CALLE 67, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003215,
    Name = "CALLE 69",
    FullName = "CALLE 69, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003220,
    Name = "CALLE 7",
    FullName = "CALLE 7, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003225,
    Name = "CALLE 71",
    FullName = "CALLE 71, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003230,
    Name = "CALLE 71 - ONEGLIA",
    FullName = "CALLE 71 - ONEGLIA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 1799,
    EndHeightLeft = 1999,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003235,
    Name = "CALLE 71 BIS",
    FullName = "CALLE 71 BIS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003240,
    Name = "CALLE 72",
    FullName = "CALLE 72, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003245,
    Name = "CALLE 73",
    FullName = "CALLE 73, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003250,
    Name = "CALLE 73 - COMUNA DE MAFALDA",
    FullName = "CALLE 73 - COMUNA DE MAFALDA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 799,
    EndHeightLeft = 15899,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003255,
    Name = "CALLE 74",
    FullName = "CALLE 74, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003260,
    Name = "CALLE 75",
    FullName = "CALLE 75, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003355,
    Name = "CALLE N 18",
    FullName = "CALLE N 18, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003360,
    Name = "CALLE N 2",
    FullName = "CALLE N 2, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003365,
    Name = "CALLE N 3",
    FullName = "CALLE N 3, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003370,
    Name = "CALLE N 36",
    FullName = "CALLE N 36, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003375,
    Name = "CALLE N 38",
    FullName = "CALLE N 38, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003380,
    Name = "CALLE N 4",
    FullName = "CALLE N 4, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003385,
    Name = "CALLE N 5",
    FullName = "CALLE N 5, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003390,
    Name = "CALLE N 6",
    FullName = "CALLE N 6, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003395,
    Name = "CALLE N 8",
    FullName = "CALLE N 8, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003400,
    Name = "CALLE N 9",
    FullName = "CALLE N 9, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003405,
    Name = "CALLE N° 4",
    FullName = "CALLE N° 4, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003410,
    Name = "CALLE N°6",
    FullName = "CALLE N°6, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003415,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003420,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003425,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003430,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003435,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003440,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003445,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003450,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003455,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003990,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003485,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003490,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003495,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003500,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003505,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003510,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003515,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003520,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003525,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003530,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003535,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003540,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003545,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003550,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003555,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003560,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003565,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003570,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003575,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003580,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003585,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003590,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003595,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003600,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003605,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003610,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003620,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003625,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003630,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003635,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003640,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003645,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003650,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003655,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003660,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003670,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003675,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003680,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003685,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003690,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003695,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003700,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003705,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003710,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003715,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003720,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003725,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003730,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003735,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003740,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003745,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003750,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003755,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003760,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003765,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003770,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003775,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003780,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003785,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003790,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003795,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003800,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003805,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003810,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003815,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003820,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003825,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003830,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003835,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003840,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003845,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003850,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003855,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003860,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003865,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003870,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003875,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003880,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003885,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003890,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003895,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003900,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003905,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003910,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003915,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003920,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003925,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003930,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003935,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003940,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003945,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003950,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003955,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003960,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003965,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003970,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003975,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003980,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711003985,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004040,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004045,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004050,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004055,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004060,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004065,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004070,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004075,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004080,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004085,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004090,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004095,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004100,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004105,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004110,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 598,
    EndHeightLeft = 599,
    StartHeightRight = 500,
    StartHeightLeft = 501,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004115,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004120,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004125,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004130,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004135,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004140,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004145,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004150,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004155,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004160,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004162,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004170,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004175,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004180,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004185,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004190,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004195,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004200,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004205,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004210,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004215,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004220,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004225,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004230,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004235,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004240,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004245,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004250,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004255,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004260,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004265,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004270,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004275,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004280,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004285,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004290,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004295,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004300,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004305,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004310,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004315,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004320,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004325,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004330,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004335,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004340,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004345,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004350,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004355,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004360,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004385,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004390,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004395,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004400,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004405,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004410,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004415,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004420,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004425,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004430,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004435,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004440,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004445,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004450,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004455,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004460,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004465,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004470,
    Name = "CALLE SN",
    FullName = "CALLE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004475,
    Name = "CALLE SOLEDAD",
    FullName = "CALLE SOLEDAD, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004480,
    Name = "CAMET F",
    FullName = "CAMET F, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004485,
    Name = "CAMET J P",
    FullName = "CAMET J P, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004490,
    Name = "CAMINO SAN FRANCISCO",
    FullName = "CAMINO SAN FRANCISCO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004495,
    Name = "CAMINOS A LAS CANERAS",
    FullName = "CAMINOS A LAS CANERAS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004500,
    Name = "CAMPESINOS",
    FullName = "CAMPESINOS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004505,
    Name = "CANATA DIAG",
    FullName = "CANATA DIAG, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 2799,
    EndHeightLeft = 2798,
    StartHeightRight = 2401,
    StartHeightLeft = 2400,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004510,
    Name = "CANNES",
    FullName = "CANNES, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004515,
    Name = "CAPITAN GIACHINO PEDRO EDUARDO",
    FullName = "CAPITAN GIACHINO PEDRO EDUARDO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004520,
    Name = "CARPINTERO",
    FullName = "CARPINTERO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004525,
    Name = "CARRASCO",
    FullName = "CARRASCO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 2498,
    EndHeightLeft = 2498,
    StartHeightRight = 2400,
    StartHeightLeft = 2400,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004530,
    Name = "CARRIEGO EVARISTO",
    FullName = "CARRIEGO EVARISTO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 999,
    EndHeightLeft = 998,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004535,
    Name = "CARRILLO",
    FullName = "CARRILLO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 2198,
    EndHeightLeft = 10898,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004540,
    Name = "CASACUBERTA",
    FullName = "CASACUBERTA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004545,
    Name = "CASEROS",
    FullName = "CASEROS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004550,
    Name = "CASTAGNINO",
    FullName = "CASTAGNINO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004555,
    Name = "CASTILLA Y LEON",
    FullName = "CASTILLA Y LEON, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 599,
    EndHeightLeft = 1099,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004560,
    Name = "CATRIEL",
    FullName = "CATRIEL, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 6598,
    EndHeightLeft = 3598,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004565,
    Name = "CAUPOLICAN",
    FullName = "CAUPOLICAN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004570,
    Name = "CAYETANO RODRIGUEZ",
    FullName = "CAYETANO RODRIGUEZ, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004575,
    Name = "CEDRO",
    FullName = "CEDRO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004580,
    Name = "CEDRO AZUL",
    FullName = "CEDRO AZUL, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004585,
    Name = "CEDROS",
    FullName = "CEDROS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 8898,
    EndHeightLeft = 8899,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004590,
    Name = "CEIBOS",
    FullName = "CEIBOS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004595,
    Name = "CELEDONIO FLORES",
    FullName = "CELEDONIO FLORES, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004600,
    Name = "CENTENARIO AV",
    FullName = "CENTENARIO AV, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004605,
    Name = "CERRITO",
    FullName = "CERRITO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004610,
    Name = "CERRITO SUR",
    FullName = "CERRITO SUR, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004615,
    Name = "CERRO ACONCAGUA",
    FullName = "CERRO ACONCAGUA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004620,
    Name = "CERRO FIAMBALA",
    FullName = "CERRO FIAMBALA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004625,
    Name = "CERRO HERMOSO",
    FullName = "CERRO HERMOSO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004630,
    Name = "CERRO LANIN",
    FullName = "CERRO LANIN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004635,
    Name = "CERRO MERCEDARIO",
    FullName = "CERRO MERCEDARIO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004640,
    Name = "CERRO MURALLON",
    FullName = "CERRO MURALLON, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004645,
    Name = "CERRO TORRE",
    FullName = "CERRO TORRE, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004650,
    Name = "CERRO TRONADOR",
    FullName = "CERRO TRONADOR, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004655,
    Name = "CHAITER",
    FullName = "CHAITER, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004660,
    Name = "CHAMPAGNAT",
    FullName = "CHAMPAGNAT, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 598,
    EndHeightLeft = 599,
    StartHeightRight = 0,
    StartHeightLeft = 1,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004665,
    Name = "CHANAL",
    FullName = "CHANAL, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004670,
    Name = "CHARLONE",
    FullName = "CHARLONE, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 299,
    EndHeightLeft = 298,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004675,
    Name = "CHASCOMUS",
    FullName = "CHASCOMUS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 1,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004680,
    Name = "CHINGOLO",
    FullName = "CHINGOLO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004685,
    Name = "CHOCORI",
    FullName = "CHOCORI, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004690,
    Name = "CIANCHETTA LORENZO",
    FullName = "CIANCHETTA LORENZO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004695,
    Name = "CIPRESE",
    FullName = "CIPRESE, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004700,
    Name = "CIPRESES",
    FullName = "CIPRESES, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 299,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004705,
    Name = "CIUDAD DE ASUNCION",
    FullName = "CIUDAD DE ASUNCION, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 3553,
    EndHeightLeft = 3399,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004710,
    Name = "CIUDAD DE DOLORES BIS",
    FullName = "CIUDAD DE DOLORES BIS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004715,
    Name = "CIUDAD DE LAS FLORES",
    FullName = "CIUDAD DE LAS FLORES, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 799,
    EndHeightLeft = 798,
    StartHeightRight = 301,
    StartHeightLeft = 300,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004720,
    Name = "CNO EST CAMET",
    FullName = "CNO EST CAMET, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004725,
    Name = "CNO PARQUE HERMOSO A AEROCLUB",
    FullName = "CNO PARQUE HERMOSO A AEROCLUB, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004730,
    Name = "COCHERO FERRO",
    FullName = "COCHERO FERRO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004735,
    Name = "COELHO DE MEYRELLES J",
    FullName = "COELHO DE MEYRELLES J, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 3998,
    EndHeightLeft = 5198,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004740,
    Name = "COLECTORA NORTE VIA",
    FullName = "COLECTORA NORTE VIA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 8999,
    EndHeightLeft = 9498,
    StartHeightRight = 8901,
    StartHeightLeft = 9000,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004745,
    Name = "COLIQUEO",
    FullName = "COLIQUEO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004750,
    Name = "COMANDANTE ERNESTO GUEVARA",
    FullName = "COMANDANTE ERNESTO GUEVARA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004755,
    Name = "COMODORO RIVADAVIA",
    FullName = "COMODORO RIVADAVIA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004760,
    Name = "CORBETA GRAN VILLE",
    FullName = "CORBETA GRAN VILLE, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 3798,
    EndHeightLeft = 3699,
    StartHeightRight = 0,
    StartHeightLeft = 3501,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004765,
    Name = "CORBETA URUGUAY",
    FullName = "CORBETA URUGUAY, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 5298,
    EndHeightLeft = 38410,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004770,
    Name = "CORONEL DAVID JAWETT",
    FullName = "CORONEL DAVID JAWETT, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 4798,
    EndHeightLeft = 4699,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004775,
    Name = "COSTA ATLANTICA",
    FullName = "COSTA ATLANTICA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 4598,
    EndHeightLeft = 5199,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004875,
    Name = "DIAG ENRIQUE SANTOS DISCEPOLO",
    FullName = "DIAG ENRIQUE SANTOS DISCEPOLO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 7500,
    EndHeightLeft = 1899,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004880,
    Name = "DIAG ANTONIO ALVAREZ",
    FullName = "DIAG ANTONIO ALVAREZ, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 3399,
    EndHeightLeft = 3398,
    StartHeightRight = 3301,
    StartHeightLeft = 3300,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004780,
    Name = "COSTA AZUL",
    FullName = "COSTA AZUL, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 3399,
    EndHeightLeft = 3498,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004785,
    Name = "CRUCERO GRL BELGRANO",
    FullName = "CRUCERO GRL BELGRANO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004790,
    Name = "CRUCERO LA ARGENTINA",
    FullName = "CRUCERO LA ARGENTINA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004795,
    Name = "CURRO MANUEL",
    FullName = "CURRO MANUEL, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004800,
    Name = "CURROS",
    FullName = "CURROS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004805,
    Name = "DALIAS",
    FullName = "DALIAS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004810,
    Name = "DANERI",
    FullName = "DANERI, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004815,
    Name = "DANIEL A JUCIC",
    FullName = "DANIEL A JUCIC, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004820,
    Name = "DAVALOS",
    FullName = "DAVALOS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 6099,
    EndHeightLeft = 6098,
    StartHeightRight = 5901,
    StartHeightLeft = 5900,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004825,
    Name = "DE BIEDMA J",
    FullName = "DE BIEDMA J, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 2198,
    EndHeightLeft = 2099,
    StartHeightRight = 1702,
    StartHeightLeft = 1761,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004830,
    Name = "DE BRAGADO",
    FullName = "DE BRAGADO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 799,
    EndHeightLeft = 798,
    StartHeightRight = 301,
    StartHeightLeft = 300,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004835,
    Name = "DE LA COLINA",
    FullName = "DE LA COLINA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004840,
    Name = "DE LA PLAZA FORTUNATO",
    FullName = "DE LA PLAZA FORTUNATO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004845,
    Name = "DE LOS INCAS",
    FullName = "DE LOS INCAS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004850,
    Name = "DE LOS RESERVISTAS",
    FullName = "DE LOS RESERVISTAS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004855,
    Name = "DE MARCHI",
    FullName = "DE MARCHI, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 1599,
    EndHeightLeft = 1598,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004860,
    Name = "DEL LAGO",
    FullName = "DEL LAGO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 8499,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004865,
    Name = "DELLEPIANE",
    FullName = "DELLEPIANE, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 3398,
    EndHeightLeft = 3399,
    StartHeightRight = 3200,
    StartHeightLeft = 3201,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004870,
    Name = "DERQUI",
    FullName = "DERQUI, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 1199,
    EndHeightLeft = 1198,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004885,
    Name = "DIAG CALLE 14",
    FullName = "DIAG CALLE 14, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004890,
    Name = "DIAG GARIBALDI",
    FullName = "DIAG GARIBALDI, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 5798,
    EndHeightLeft = 5799,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004895,
    Name = "DIAG INVADO",
    FullName = "DIAG INVADO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 1498,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004900,
    Name = "DIAG JUSTO ERNESTO ROMAN",
    FullName = "DIAG JUSTO ERNESTO ROMAN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004905,
    Name = "DIAG LEOPOLDO LUGONES",
    FullName = "DIAG LEOPOLDO LUGONES, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 7999,
    EndHeightLeft = 7998,
    StartHeightRight = 0,
    StartHeightLeft = 1801,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004910,
    Name = "DIAG SUR",
    FullName = "DIAG SUR, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004915,
    Name = "DIAG VELEZ SARFIELD",
    FullName = "DIAG VELEZ SARFIELD, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 799,
    EndHeightLeft = 3299,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004920,
    Name = "DIAG BUQUE PESQUERO SAN GABRIEL",
    FullName = "DIAG BUQUE PESQUERO SAN GABRIEL, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004925,
    Name = "DIAG DEL SUR",
    FullName = "DIAG DEL SUR, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004930,
    Name = "DIAG GRAN ALMIRANTE",
    FullName = "DIAG GRAN ALMIRANTE, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 898,
    EndHeightLeft = 799,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004935,
    Name = "DIAG JUAN B ALBERDI",
    FullName = "DIAG JUAN B ALBERDI, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 2698,
    EndHeightLeft = 2699,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004940,
    Name = "DIAG NORTE",
    FullName = "DIAG NORTE, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004945,
    Name = "DIAGONAL BORDE ARROYO",
    FullName = "DIAGONAL BORDE ARROYO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004950,
    Name = "DIAGONAL DEL NORTE",
    FullName = "DIAGONAL DEL NORTE, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004955,
    Name = "DIAGONAL DEL SUR",
    FullName = "DIAGONAL DEL SUR, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005045,
    Name = "EL CHAJA",
    FullName = "EL CHAJA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004960,
    Name = "DIAGONAL NORTE",
    FullName = "DIAGONAL NORTE, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004965,
    Name = "DIAGONAL OMBU",
    FullName = "DIAGONAL OMBU, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 4199,
    EndHeightLeft = 4599,
    StartHeightRight = 0,
    StartHeightLeft = 3801,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004970,
    Name = "DIAGONAL SUR",
    FullName = "DIAGONAL SUR, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004975,
    Name = "DIECKMANN JUANA G",
    FullName = "DIECKMANN JUANA G, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004980,
    Name = "DON ARTURO",
    FullName = "DON ARTURO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004985,
    Name = "DON T ROLDAN",
    FullName = "DON T ROLDAN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004990,
    Name = "DR MARCELO JULIO FITTE",
    FullName = "DR MARCELO JULIO FITTE, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711004995,
    Name = "DUFRECHOU",
    FullName = "DUFRECHOU, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005000,
    Name = "E ZEBALLOS",
    FullName = "E ZEBALLOS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 5998,
    EndHeightLeft = 5999,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005005,
    Name = "ED P RAMOS",
    FullName = "ED P RAMOS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005010,
    Name = "EDUARDO AROLAS",
    FullName = "EDUARDO AROLAS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005015,
    Name = "EDUARDO G CARASA",
    FullName = "EDUARDO G CARASA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005020,
    Name = "EL BENTEVEO",
    FullName = "EL BENTEVEO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 399,
    EndHeightLeft = 398,
    StartHeightRight = 1,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005025,
    Name = "EL CANO",
    FullName = "EL CANO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 8298,
    EndHeightLeft = 8299,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005030,
    Name = "EL CANO BIS",
    FullName = "EL CANO BIS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005035,
    Name = "EL CARDENAL",
    FullName = "EL CARDENAL, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005040,
    Name = "EL CARPINTERO",
    FullName = "EL CARPINTERO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 398,
    EndHeightLeft = 399,
    StartHeightRight = 0,
    StartHeightLeft = 1,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005050,
    Name = "EL CHINGOLO",
    FullName = "EL CHINGOLO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 298,
    EndHeightLeft = 298,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005055,
    Name = "EL CHURRINCHE",
    FullName = "EL CHURRINCHE, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 398,
    EndHeightLeft = 399,
    StartHeightRight = 0,
    StartHeightLeft = 1,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005060,
    Name = "EL CORBATITA",
    FullName = "EL CORBATITA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 98,
    EndHeightLeft = 399,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005065,
    Name = "EL FLAMENCO",
    FullName = "EL FLAMENCO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005070,
    Name = "EL GAVIOTIN",
    FullName = "EL GAVIOTIN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 98,
    EndHeightLeft = 399,
    StartHeightRight = 0,
    StartHeightLeft = 1,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005075,
    Name = "EL GORRION",
    FullName = "EL GORRION, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 398,
    EndHeightLeft = 399,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005080,
    Name = "EL HORNERO",
    FullName = "EL HORNERO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005085,
    Name = "EL JILGUERO",
    FullName = "EL JILGUERO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 398,
    EndHeightLeft = 399,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005090,
    Name = "EL LENATERO",
    FullName = "EL LENATERO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 399,
    EndHeightLeft = 398,
    StartHeightRight = 1,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005095,
    Name = "EL MIXTO",
    FullName = "EL MIXTO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005100,
    Name = "EL PAMPERO",
    FullName = "EL PAMPERO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 8198,
    EndHeightLeft = 8199,
    StartHeightRight = 8002,
    StartHeightLeft = 8001,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005105,
    Name = "EL PICAFLOR",
    FullName = "EL PICAFLOR, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005110,
    Name = "EL PIRINCHO",
    FullName = "EL PIRINCHO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 399,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005115,
    Name = "EL SULKY",
    FullName = "EL SULKY, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005120,
    Name = "EL TEJADO",
    FullName = "EL TEJADO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005125,
    Name = "EL TERO",
    FullName = "EL TERO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 398,
    EndHeightLeft = 399,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005130,
    Name = "EL TEROTERO",
    FullName = "EL TEROTERO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005135,
    Name = "EL TORDO",
    FullName = "EL TORDO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 399,
    EndHeightLeft = 398,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005140,
    Name = "EL ZORZAL",
    FullName = "EL ZORZAL, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005145,
    Name = "ELCANO",
    FullName = "ELCANO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 10499,
    EndHeightLeft = 10698,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005150,
    Name = "ELIAS ALLIPI",
    FullName = "ELIAS ALLIPI, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 4899,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005155,
    Name = "ELISA ALVEAR DE BOSCH",
    FullName = "ELISA ALVEAR DE BOSCH, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005160,
    Name = "ESPERANTO",
    FullName = "ESPERANTO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 1999,
    EndHeightLeft = 1998,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005165,
    Name = "ESQUEL",
    FullName = "ESQUEL, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005170,
    Name = "ESQUIVEL E",
    FullName = "ESQUIVEL E, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 8295,
    EndHeightLeft = 8199,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005175,
    Name = "ESTADOS UNIDOS DE NORTEAMERICA DIAG",
    FullName = "ESTADOS UNIDOS DE NORTEAMERICA DIAG, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 299,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005180,
    Name = "ESTANCIA CABO CORRIENTES",
    FullName = "ESTANCIA CABO CORRIENTES, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005185,
    Name = "ESTANCIA CHAPADMALAL",
    FullName = "ESTANCIA CHAPADMALAL, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005190,
    Name = "ESTANCIA EL BOQUERON",
    FullName = "ESTANCIA EL BOQUERON, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005195,
    Name = "ESTANCIA ITUZAINGO",
    FullName = "ESTANCIA ITUZAINGO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005200,
    Name = "ESTANCIA LAGUNA DE LOS PADRES",
    FullName = "ESTANCIA LAGUNA DE LOS PADRES, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005205,
    Name = "ESTANCIA SAN JULIAN DE VIVORATA",
    FullName = "ESTANCIA SAN JULIAN DE VIVORATA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005210,
    Name = "ESTANCIA VIVORATA",
    FullName = "ESTANCIA VIVORATA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005215,
    Name = "ESTRELLA DEL SUR",
    FullName = "ESTRELLA DEL SUR, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005305,
    Name = "FRAG LIBERTAD",
    FullName = "FRAG LIBERTAD, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 3999,
    EndHeightLeft = 3998,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005220,
    Name = "EUSEBIONE L",
    FullName = "EUSEBIONE L, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 2098,
    EndHeightLeft = 2199,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005225,
    Name = "F CATUOGNO",
    FullName = "F CATUOGNO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005230,
    Name = "F FERRER",
    FullName = "F FERRER, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 898,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005235,
    Name = "F J DE DIOS",
    FullName = "F J DE DIOS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 799,
    EndHeightLeft = 798,
    StartHeightRight = 301,
    StartHeightLeft = 300,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005240,
    Name = "F SANCHEZ",
    FullName = "F SANCHEZ, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 4299,
    EndHeightLeft = 4298,
    StartHeightRight = 3741,
    StartHeightLeft = 3600,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005245,
    Name = "F SARTORA",
    FullName = "F SARTORA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005250,
    Name = "FALKNER",
    FullName = "FALKNER, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 9999,
    EndHeightLeft = 10098,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005255,
    Name = "FALKNER TOMAS",
    FullName = "FALKNER TOMAS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 7799,
    EndHeightLeft = 7798,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005260,
    Name = "FALUCHO",
    FullName = "FALUCHO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 198,
    EndHeightLeft = 199,
    StartHeightRight = 2,
    StartHeightLeft = 1,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005265,
    Name = "FERNANDO CATUOGNO",
    FullName = "FERNANDO CATUOGNO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005270,
    Name = "FERRE PEDRO",
    FullName = "FERRE PEDRO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005275,
    Name = "FERREYRA",
    FullName = "FERREYRA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005280,
    Name = "FILIBERTO BIS",
    FullName = "FILIBERTO BIS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005285,
    Name = "FLORENCIO MARTINEZ DE HOZ",
    FullName = "FLORENCIO MARTINEZ DE HOZ, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 1299,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005290,
    Name = "FLORENCIO PARRAVICINI",
    FullName = "FLORENCIO PARRAVICINI, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005295,
    Name = "FRAG HALCON",
    FullName = "FRAG HALCON, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 3999,
    EndHeightLeft = 3998,
    StartHeightRight = 3801,
    StartHeightLeft = 3800,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005300,
    Name = "FRAG HERCULES",
    FullName = "FRAG HERCULES, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005310,
    Name = "FRAG MALDONADO",
    FullName = "FRAG MALDONADO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 3999,
    EndHeightLeft = 3998,
    StartHeightRight = 3801,
    StartHeightLeft = 3800,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005315,
    Name = "FRAG SARMIENTO",
    FullName = "FRAG SARMIENTO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 3398,
    EndHeightLeft = 3798,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005320,
    Name = "FRANCISCO CHACAHUAC",
    FullName = "FRANCISCO CHACAHUAC, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005325,
    Name = "FRENGUELLI",
    FullName = "FRENGUELLI, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005330,
    Name = "FRESNOS",
    FullName = "FRESNOS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005335,
    Name = "G BURMEISTES",
    FullName = "G BURMEISTES, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005340,
    Name = "G CHAVES",
    FullName = "G CHAVES, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 4298,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005345,
    Name = "G VENTURA",
    FullName = "G VENTURA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005350,
    Name = "G BURMEISTER",
    FullName = "G BURMEISTER, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005355,
    Name = "GABOTO",
    FullName = "GABOTO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 99999,
    EndHeightLeft = 77899,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005360,
    Name = "GABOTO BIS",
    FullName = "GABOTO BIS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005365,
    Name = "GALLARDO",
    FullName = "GALLARDO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005370,
    Name = "GALLO",
    FullName = "GALLO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005375,
    Name = "GAMAL ABDEL NASSER",
    FullName = "GAMAL ABDEL NASSER, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 3399,
    EndHeightLeft = 3398,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005380,
    Name = "GANDARA",
    FullName = "GANDARA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005560,
    Name = "HARAS LA MADRUGADA",
    FullName = "HARAS LA MADRUGADA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005385,
    Name = "GANDHI",
    FullName = "GANDHI, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 4988,
    EndHeightLeft = 5099,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005390,
    Name = "GARCIA LORCA BIS",
    FullName = "GARCIA LORCA BIS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005395,
    Name = "GASCON DIAG",
    FullName = "GASCON DIAG, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 3198,
    EndHeightLeft = 3199,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005400,
    Name = "GAUDINI",
    FullName = "GAUDINI, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 1999,
    EndHeightLeft = 1998,
    StartHeightRight = 1301,
    StartHeightLeft = 1300,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005405,
    Name = "GENOVA BIS",
    FullName = "GENOVA BIS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005410,
    Name = "GERANIOS",
    FullName = "GERANIOS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005415,
    Name = "GERMAN ABDALA",
    FullName = "GERMAN ABDALA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005420,
    Name = "GOLETA SARANDI",
    FullName = "GOLETA SARANDI, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005425,
    Name = "GOLONDRINA",
    FullName = "GOLONDRINA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005430,
    Name = "GONZALES CHAVEZ BIS",
    FullName = "GONZALES CHAVEZ BIS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005435,
    Name = "GONZALEZ E DIAG",
    FullName = "GONZALEZ E DIAG, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 5799,
    EndHeightLeft = 5798,
    StartHeightRight = 0,
    StartHeightLeft = 4700,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005440,
    Name = "GONI JUAN BIS",
    FullName = "GONI JUAN BIS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005445,
    Name = "GRANJA MARUCHA",
    FullName = "GRANJA MARUCHA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005450,
    Name = "GRL BELGRANO",
    FullName = "GRL BELGRANO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005455,
    Name = "GROEBER",
    FullName = "GROEBER, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 6699,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005565,
    Name = "HARAS LAS ORTIGAS",
    FullName = "HARAS LAS ORTIGAS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005460,
    Name = "GUANAHANI",
    FullName = "GUANAHANI, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 96898,
    EndHeightLeft = 65969,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005465,
    Name = "GUERNICA",
    FullName = "GUERNICA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 1098,
    EndHeightLeft = 5699,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005470,
    Name = "GUERRA",
    FullName = "GUERRA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 999,
    EndHeightLeft = 998,
    StartHeightRight = 701,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005475,
    Name = "GUERRICO A",
    FullName = "GUERRICO A, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005480,
    Name = "GUGLIEMO",
    FullName = "GUGLIEMO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 999,
    EndHeightLeft = 998,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005485,
    Name = "GUIRALDES BIS",
    FullName = "GUIRALDES BIS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005490,
    Name = "GURRIERI",
    FullName = "GURRIERI, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005495,
    Name = "GUTEMBERG BIS",
    FullName = "GUTEMBERG BIS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 6999,
    EndHeightLeft = 6998,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005500,
    Name = "GUTIERREZ RICARDO",
    FullName = "GUTIERREZ RICARDO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 999,
    EndHeightLeft = 998,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005505,
    Name = "H ENGLENDER",
    FullName = "H ENGLENDER, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005510,
    Name = "H MANZI",
    FullName = "H MANZI, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005515,
    Name = "HAENCKE TADEO",
    FullName = "HAENCKE TADEO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005520,
    Name = "HARAS ABOLENGO",
    FullName = "HARAS ABOLENGO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005525,
    Name = "HARAS COMAZAL",
    FullName = "HARAS COMAZAL, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005530,
    Name = "HARAS EL ALEAR",
    FullName = "HARAS EL ALEAR, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 599,
    EndHeightLeft = 398,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005535,
    Name = "HARAS EL CANDIL",
    FullName = "HARAS EL CANDIL, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 399,
    EndHeightLeft = 398,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005540,
    Name = "HARAS EL TURF",
    FullName = "HARAS EL TURF, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005545,
    Name = "HARAS FIRMAMENTO",
    FullName = "HARAS FIRMAMENTO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005550,
    Name = "HARAS HORIZONTE",
    FullName = "HARAS HORIZONTE, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005555,
    Name = "HARAS LA BIZNAGA",
    FullName = "HARAS LA BIZNAGA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005570,
    Name = "HARAS MALAHUE",
    FullName = "HARAS MALAHUE, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005575,
    Name = "HARAS V CACION",
    FullName = "HARAS V CACION, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005580,
    Name = "HARAS VENCENIL",
    FullName = "HARAS VENCENIL, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 599,
    EndHeightLeft = 598,
    StartHeightRight = 1,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005585,
    Name = "HECTOR RAMON BORDON",
    FullName = "HECTOR RAMON BORDON, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005590,
    Name = "HEGUILOR DOMINGO BIS",
    FullName = "HEGUILOR DOMINGO BIS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005595,
    Name = "HELECHOS",
    FullName = "HELECHOS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005600,
    Name = "HERMANOS ALDACOCHE",
    FullName = "HERMANOS ALDACOCHE, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005605,
    Name = "HERMIDA",
    FullName = "HERMIDA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005610,
    Name = "HERNANDARIAS",
    FullName = "HERNANDARIAS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 65998,
    EndHeightLeft = 9499,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005615,
    Name = "HERRERIA",
    FullName = "HERRERIA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005620,
    Name = "HOLMBERG",
    FullName = "HOLMBERG, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005625,
    Name = "HORNERO",
    FullName = "HORNERO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 399,
    EndHeightLeft = 398,
    StartHeightRight = 1,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005630,
    Name = "HUDSON GUILLERMO",
    FullName = "HUDSON GUILLERMO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 4599,
    EndHeightLeft = 4598,
    StartHeightRight = 4201,
    StartHeightLeft = 400,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005635,
    Name = "HUILEN",
    FullName = "HUILEN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005640,
    Name = "HUSSAY",
    FullName = "HUSSAY, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005645,
    Name = "I OLAN",
    FullName = "I OLAN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 6698,
    EndHeightLeft = 6699,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005650,
    Name = "INDA RUFINO BIS",
    FullName = "INDA RUFINO BIS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005655,
    Name = "ING OTTO KRAUSE",
    FullName = "ING OTTO KRAUSE, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 5198,
    EndHeightLeft = 5199,
    StartHeightRight = 0,
    StartHeightLeft = 5001,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005705,
    Name = "ISLA ELEFANTE",
    FullName = "ISLA ELEFANTE, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005660,
    Name = "ING RATERIY",
    FullName = "ING RATERIY, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 6999,
    EndHeightLeft = 4798,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005665,
    Name = "INGENIEROS JOSE",
    FullName = "INGENIEROS JOSE, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 3799,
    EndHeightLeft = 3598,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005670,
    Name = "INT JOSE A CAVALLO",
    FullName = "INT JOSE A CAVALLO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005675,
    Name = "IRALA",
    FullName = "IRALA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 11198,
    EndHeightLeft = 38799,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005680,
    Name = "ISLA BLANCO",
    FullName = "ISLA BLANCO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005685,
    Name = "ISLA BORGON",
    FullName = "ISLA BORGON, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005690,
    Name = "ISLA CORONACION",
    FullName = "ISLA CORONACION, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005695,
    Name = "ISLA DE CERDENA - CALLE 69",
    FullName = "ISLA DE CERDENA - CALLE 69, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 660,
    EndHeightLeft = 3099,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005700,
    Name = "ISLA DE LOS ESTADOS",
    FullName = "ISLA DE LOS ESTADOS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005710,
    Name = "ISLA JOINVILLE",
    FullName = "ISLA JOINVILLE, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005715,
    Name = "ISLA LAURIE",
    FullName = "ISLA LAURIE, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005720,
    Name = "ISLA PAJAROS",
    FullName = "ISLA PAJAROS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005725,
    Name = "ISLA REMOLINOS",
    FullName = "ISLA REMOLINOS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005730,
    Name = "ISLA SEBALDES",
    FullName = "ISLA SEBALDES, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005735,
    Name = "ISLA TRAVERSE",
    FullName = "ISLA TRAVERSE, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005740,
    Name = "ISLA TRINIDAD",
    FullName = "ISLA TRINIDAD, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005745,
    Name = "ISLA TULES DEL SUR",
    FullName = "ISLA TULES DEL SUR, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005750,
    Name = "ISLA VIGIA",
    FullName = "ISLA VIGIA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005755,
    Name = "ISLAS BALEARES",
    FullName = "ISLAS BALEARES, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 4798,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005760,
    Name = "ISLAS DE LOS ESTADOS SUR",
    FullName = "ISLAS DE LOS ESTADOS SUR, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005765,
    Name = "ITUZAINGO",
    FullName = "ITUZAINGO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005770,
    Name = "J DE LA LLOSA",
    FullName = "J DE LA LLOSA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005775,
    Name = "J HERNANDEZ",
    FullName = "J HERNANDEZ, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005780,
    Name = "J J PASO",
    FullName = "J J PASO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 4199,
    EndHeightLeft = 4599,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005785,
    Name = "J M MICHEL",
    FullName = "J M MICHEL, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005790,
    Name = "J MANZO",
    FullName = "J MANZO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 4298,
    EndHeightLeft = 4299,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005795,
    Name = "J P RAMOS",
    FullName = "J P RAMOS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 4298,
    EndHeightLeft = 4299,
    StartHeightRight = 3740,
    StartHeightLeft = 3601,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005800,
    Name = "J PUJIA",
    FullName = "J PUJIA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 3498,
    EndHeightLeft = 3499,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005805,
    Name = "JACINTO PERALTA RAMOS BIS",
    FullName = "JACINTO PERALTA RAMOS BIS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005810,
    Name = "JAZMINES",
    FullName = "JAZMINES, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005815,
    Name = "JOSE COEHLO DE MEYRELLES",
    FullName = "JOSE COEHLO DE MEYRELLES, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 1798,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005820,
    Name = "JOSE DANTE FABUR",
    FullName = "JOSE DANTE FABUR, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005825,
    Name = "JOSE DEYACCOBI",
    FullName = "JOSE DEYACCOBI, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005830,
    Name = "JOSE DOCNOYAHAL17",
    FullName = "JOSE DOCNOYAHAL17, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005835,
    Name = "JOSE F BOTANA",
    FullName = "JOSE F BOTANA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005840,
    Name = "JOSE HERNANDEZ",
    FullName = "JOSE HERNANDEZ, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005845,
    Name = "JOSE L RODRIGUEZ",
    FullName = "JOSE L RODRIGUEZ, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005850,
    Name = "JOSE RAZZANO",
    FullName = "JOSE RAZZANO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005855,
    Name = "JUAN B JUSTO",
    FullName = "JUAN B JUSTO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005860,
    Name = "JUAN C CASTAGNINO",
    FullName = "JUAN C CASTAGNINO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005865,
    Name = "JUAN CUTAY",
    FullName = "JUAN CUTAY, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005870,
    Name = "JUAN D PERON CALLE 35",
    FullName = "JUAN D PERON CALLE 35, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005875,
    Name = "JUAN D`ARIENZO",
    FullName = "JUAN D`ARIENZO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005880,
    Name = "JUAN DE DIOS FILIBERTO",
    FullName = "JUAN DE DIOS FILIBERTO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005885,
    Name = "JUAN JOSE VALLE",
    FullName = "JUAN JOSE VALLE, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 698,
    EndHeightLeft = 699,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005890,
    Name = "JUAN MORO",
    FullName = "JUAN MORO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 9499,
    EndHeightLeft = 10000,
    StartHeightRight = 8001,
    StartHeightLeft = 8902,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005895,
    Name = "JUAN YAHAM",
    FullName = "JUAN YAHAM, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005900,
    Name = "JUANA AZURDUY BIS",
    FullName = "JUANA AZURDUY BIS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005905,
    Name = "JUAREZ BENITO",
    FullName = "JUAREZ BENITO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 2599,
    EndHeightLeft = 2598,
    StartHeightRight = 1,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005910,
    Name = "JULIO CANESSA",
    FullName = "JULIO CANESSA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005915,
    Name = "JULIO DE CARO",
    FullName = "JULIO DE CARO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005920,
    Name = "KENNEDY",
    FullName = "KENNEDY, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 5798,
    EndHeightLeft = 5799,
    StartHeightRight = 5700,
    StartHeightLeft = 5701,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005925,
    Name = "KRAGLIEVICH",
    FullName = "KRAGLIEVICH, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005930,
    Name = "L FRAGNAUD",
    FullName = "L FRAGNAUD, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005935,
    Name = "L SCAGLIA",
    FullName = "L SCAGLIA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005940,
    Name = "LA ALONDRA",
    FullName = "LA ALONDRA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005945,
    Name = "LA ARMONIA",
    FullName = "LA ARMONIA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005950,
    Name = "LA AURORA",
    FullName = "LA AURORA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005955,
    Name = "LA CACHIRA",
    FullName = "LA CACHIRA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005960,
    Name = "LA CALANDRIA",
    FullName = "LA CALANDRIA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005965,
    Name = "LA CIGUENA",
    FullName = "LA CIGUENA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005970,
    Name = "LA COLMENA",
    FullName = "LA COLMENA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005975,
    Name = "LA COPELINA",
    FullName = "LA COPELINA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005980,
    Name = "LA CORONA",
    FullName = "LA CORONA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005985,
    Name = "LA GAVIOTA",
    FullName = "LA GAVIOTA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005990,
    Name = "LA GOLONDRINA",
    FullName = "LA GOLONDRINA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 399,
    EndHeightLeft = 398,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711005995,
    Name = "LA JOYA",
    FullName = "LA JOYA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006000,
    Name = "LA LAURA",
    FullName = "LA LAURA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006005,
    Name = "LA MARTINETA",
    FullName = "LA MARTINETA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006010,
    Name = "LA NINA",
    FullName = "LA NINA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 3999,
    EndHeightLeft = 3998,
    StartHeightRight = 3601,
    StartHeightLeft = 3600,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006015,
    Name = "LA PAMPA",
    FullName = "LA PAMPA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 3999,
    EndHeightLeft = 3998,
    StartHeightRight = 3801,
    StartHeightLeft = 3800,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006020,
    Name = "LA PASIONARIA",
    FullName = "LA PASIONARIA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006025,
    Name = "LA PERDIZ",
    FullName = "LA PERDIZ, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006030,
    Name = "LA PEREGRINA",
    FullName = "LA PEREGRINA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006035,
    Name = "LA PINTA",
    FullName = "LA PINTA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 3799,
    EndHeightLeft = 3798,
    StartHeightRight = 3601,
    StartHeightLeft = 3600,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006040,
    Name = "LA PRIMAVERA",
    FullName = "LA PRIMAVERA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 5498,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006045,
    Name = "LA RATONERA",
    FullName = "LA RATONERA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 299,
    EndHeightLeft = 298,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006050,
    Name = "LA REFORMA",
    FullName = "LA REFORMA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006055,
    Name = "LA SANTA MARIA",
    FullName = "LA SANTA MARIA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 3799,
    EndHeightLeft = 3798,
    StartHeightRight = 0,
    StartHeightLeft = 3600,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006060,
    Name = "LA SERENA",
    FullName = "LA SERENA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006065,
    Name = "LA TIJERETA",
    FullName = "LA TIJERETA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006070,
    Name = "LA TORCACITA",
    FullName = "LA TORCACITA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 398,
    EndHeightLeft = 399,
    StartHeightRight = 100,
    StartHeightLeft = 1,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006075,
    Name = "LA TORCAZA",
    FullName = "LA TORCAZA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006080,
    Name = "LABARDEN",
    FullName = "LABARDEN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006085,
    Name = "LABRADOR",
    FullName = "LABRADOR, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 6698,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006090,
    Name = "LAHILLE",
    FullName = "LAHILLE, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006095,
    Name = "LAMAS",
    FullName = "LAMAS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006100,
    Name = "LAMBARDIA",
    FullName = "LAMBARDIA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 399,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006105,
    Name = "LAMBERSIANAS",
    FullName = "LAMBERSIANAS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006110,
    Name = "LAPRIDA",
    FullName = "LAPRIDA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006115,
    Name = "LAS ACACIAS",
    FullName = "LAS ACACIAS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006120,
    Name = "LAS ARAUCARIAS",
    FullName = "LAS ARAUCARIAS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006125,
    Name = "LAS AZUCENAS",
    FullName = "LAS AZUCENAS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 1398,
    EndHeightLeft = 1399,
    StartHeightRight = 1100,
    StartHeightLeft = 1101,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006130,
    Name = "LAS CABRILLAS",
    FullName = "LAS CABRILLAS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 3299,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006135,
    Name = "LAS CALAS",
    FullName = "LAS CALAS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006140,
    Name = "LAS CAMELIAS",
    FullName = "LAS CAMELIAS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 1298,
    EndHeightLeft = 1299,
    StartHeightRight = 1100,
    StartHeightLeft = 1101,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006145,
    Name = "LAS CASUARINAS",
    FullName = "LAS CASUARINAS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 8399,
    EndHeightLeft = 8398,
    StartHeightRight = 8301,
    StartHeightLeft = 830,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006150,
    Name = "LAS CEREZAS",
    FullName = "LAS CEREZAS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006155,
    Name = "LAS CHINCHAS",
    FullName = "LAS CHINCHAS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006160,
    Name = "LAS CORONAS",
    FullName = "LAS CORONAS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006165,
    Name = "LAS DALIAS",
    FullName = "LAS DALIAS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006170,
    Name = "LAS ENCIMAS",
    FullName = "LAS ENCIMAS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006175,
    Name = "LAS ENCIMERAS",
    FullName = "LAS ENCIMERAS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006180,
    Name = "LAS FAJAS",
    FullName = "LAS FAJAS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006260,
    Name = "LAS VIOLETAS",
    FullName = "LAS VIOLETAS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006185,
    Name = "LAS FRESIAS",
    FullName = "LAS FRESIAS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006190,
    Name = "LAS GARDENIAS",
    FullName = "LAS GARDENIAS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 1298,
    EndHeightLeft = 1299,
    StartHeightRight = 1100,
    StartHeightLeft = 1101,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006195,
    Name = "LAS HIGUERAS",
    FullName = "LAS HIGUERAS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006200,
    Name = "LAS HORTENSIAS",
    FullName = "LAS HORTENSIAS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006205,
    Name = "LAS LAMBERICANAS",
    FullName = "LAS LAMBERICANAS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006210,
    Name = "LAS MAGNOLIAS",
    FullName = "LAS MAGNOLIAS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006215,
    Name = "LAS MARAVILLAS",
    FullName = "LAS MARAVILLAS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006220,
    Name = "LAS MARGARITAS",
    FullName = "LAS MARGARITAS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 3698,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006225,
    Name = "LAS MORERAS",
    FullName = "LAS MORERAS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006230,
    Name = "LAS PALMERAS",
    FullName = "LAS PALMERAS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006235,
    Name = "LAS PECHERAS",
    FullName = "LAS PECHERAS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006240,
    Name = "LAS ROSAS",
    FullName = "LAS ROSAS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 1298,
    EndHeightLeft = 1299,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006245,
    Name = "LAS TABAS",
    FullName = "LAS TABAS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006250,
    Name = "LAS TRES MARIAS",
    FullName = "LAS TRES MARIAS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006255,
    Name = "LAS TUYAS",
    FullName = "LAS TUYAS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006265,
    Name = "LATANTU",
    FullName = "LATANTU, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 6898,
    EndHeightLeft = 6699,
    StartHeightRight = 6200,
    StartHeightLeft = 6201,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006270,
    Name = "LEGH II",
    FullName = "LEGH II, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006275,
    Name = "LILLO M",
    FullName = "LILLO M, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006280,
    Name = "LINCOLN",
    FullName = "LINCOLN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006285,
    Name = "LINIERS",
    FullName = "LINIERS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 598,
    EndHeightLeft = 599,
    StartHeightRight = 0,
    StartHeightLeft = 1,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006290,
    Name = "LIRIOS",
    FullName = "LIRIOS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006295,
    Name = "LITUANIA",
    FullName = "LITUANIA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 1098,
    EndHeightLeft = 1099,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006300,
    Name = "LOBERIA",
    FullName = "LOBERIA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006305,
    Name = "LORENZO CIANCHETTA",
    FullName = "LORENZO CIANCHETTA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 3298,
    EndHeightLeft = 3399,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006310,
    Name = "LORENZO EUSEBIONE",
    FullName = "LORENZO EUSEBIONE, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 1598,
    EndHeightLeft = 1579,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006315,
    Name = "LOS ABEDULES",
    FullName = "LOS ABEDULES, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006320,
    Name = "LOS ABETOS",
    FullName = "LOS ABETOS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006325,
    Name = "LOS AGAPANTHUS",
    FullName = "LOS AGAPANTHUS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006330,
    Name = "LOS ALACALUPES",
    FullName = "LOS ALACALUPES, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006335,
    Name = "LOS ALAMOS",
    FullName = "LOS ALAMOS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006340,
    Name = "LOS ALAMOS - BO CAMET",
    FullName = "LOS ALAMOS - BO CAMET, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006345,
    Name = "LOS ALELIES",
    FullName = "LOS ALELIES, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006350,
    Name = "LOS ALHELIES",
    FullName = "LOS ALHELIES, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 1298,
    EndHeightLeft = 1299,
    StartHeightRight = 1100,
    StartHeightLeft = 1101,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006355,
    Name = "LOS ALMENDROS",
    FullName = "LOS ALMENDROS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006360,
    Name = "LOS ARAUCANOS",
    FullName = "LOS ARAUCANOS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006365,
    Name = "LOS AROMOS",
    FullName = "LOS AROMOS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006370,
    Name = "LOS ARRAYANES",
    FullName = "LOS ARRAYANES, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006375,
    Name = "LOS AVIPONES",
    FullName = "LOS AVIPONES, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006380,
    Name = "LOS AZTECAS",
    FullName = "LOS AZTECAS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006385,
    Name = "LOS CALCHAQUIES",
    FullName = "LOS CALCHAQUIES, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006390,
    Name = "LOS CAROYAS",
    FullName = "LOS CAROYAS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006395,
    Name = "LOS CASTANOS",
    FullName = "LOS CASTANOS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006400,
    Name = "LOS CEDROS",
    FullName = "LOS CEDROS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006405,
    Name = "LOS CEDROS - BO CAMET",
    FullName = "LOS CEDROS - BO CAMET, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006410,
    Name = "LOS CEIBOS",
    FullName = "LOS CEIBOS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006415,
    Name = "LOS CEREZOS",
    FullName = "LOS CEREZOS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006420,
    Name = "LOS CHANAS",
    FullName = "LOS CHANAS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006425,
    Name = "LOS CHANARES",
    FullName = "LOS CHANARES, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006430,
    Name = "LOS CHARRUAS",
    FullName = "LOS CHARRUAS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006435,
    Name = "LOS CHIRIGUANOS",
    FullName = "LOS CHIRIGUANOS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006440,
    Name = "LOS CIPRESES",
    FullName = "LOS CIPRESES, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006445,
    Name = "LOS CLAVELES",
    FullName = "LOS CLAVELES, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 1298,
    EndHeightLeft = 1299,
    StartHeightRight = 1100,
    StartHeightLeft = 1101,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006450,
    Name = "LOS CLAVELES DEL BOSQUE",
    FullName = "LOS CLAVELES DEL BOSQUE, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006455,
    Name = "LOS COLLAS",
    FullName = "LOS COLLAS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006460,
    Name = "LOS COMECHINGONES",
    FullName = "LOS COMECHINGONES, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006465,
    Name = "LOS CRISANTEMOS",
    FullName = "LOS CRISANTEMOS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006470,
    Name = "LOS DIAGUITAS",
    FullName = "LOS DIAGUITAS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006475,
    Name = "LOS DURAZNEROS",
    FullName = "LOS DURAZNEROS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006480,
    Name = "LOS EUCALIPTOS",
    FullName = "LOS EUCALIPTOS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006640,
    Name = "LOS QUICHUAS",
    FullName = "LOS QUICHUAS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006485,
    Name = "LOS EUCALIPTUS",
    FullName = "LOS EUCALIPTUS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 598,
    EndHeightLeft = 8898,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006490,
    Name = "LOS FRESNOS",
    FullName = "LOS FRESNOS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006495,
    Name = "LOS GERANIOS",
    FullName = "LOS GERANIOS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006500,
    Name = "LOS GRANADOS",
    FullName = "LOS GRANADOS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006505,
    Name = "LOS GUARANIES",
    FullName = "LOS GUARANIES, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006510,
    Name = "LOS GUAYCURUES",
    FullName = "LOS GUAYCURUES, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006515,
    Name = "LOS HUARPES",
    FullName = "LOS HUARPES, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006520,
    Name = "LOS INCAS",
    FullName = "LOS INCAS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006525,
    Name = "LOS JACINTOS",
    FullName = "LOS JACINTOS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006530,
    Name = "LOS JAZMINES",
    FullName = "LOS JAZMINES, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 1398,
    EndHeightLeft = 1399,
    StartHeightRight = 1100,
    StartHeightLeft = 1101,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006535,
    Name = "LOS JUNCOS",
    FullName = "LOS JUNCOS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006540,
    Name = "LOS LIMONEROS",
    FullName = "LOS LIMONEROS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006545,
    Name = "LOS LIRIOS",
    FullName = "LOS LIRIOS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006550,
    Name = "LOS LULES",
    FullName = "LOS LULES, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006555,
    Name = "LOS MALVONES",
    FullName = "LOS MALVONES, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006645,
    Name = "LOS QUILMES",
    FullName = "LOS QUILMES, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006650,
    Name = "LOS RANQUELES",
    FullName = "LOS RANQUELES, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006560,
    Name = "LOS MANZANOS",
    FullName = "LOS MANZANOS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006565,
    Name = "LOS MAPUCHES",
    FullName = "LOS MAPUCHES, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006570,
    Name = "LOS MATACOS",
    FullName = "LOS MATACOS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006575,
    Name = "LOS MOCOVIES",
    FullName = "LOS MOCOVIES, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006580,
    Name = "LOS NARANJOS",
    FullName = "LOS NARANJOS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006585,
    Name = "LOS NARDOS",
    FullName = "LOS NARDOS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 1298,
    EndHeightLeft = 1299,
    StartHeightRight = 1100,
    StartHeightLeft = 1101,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006590,
    Name = "LOS NOGALES",
    FullName = "LOS NOGALES, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006595,
    Name = "LOS OLMOS",
    FullName = "LOS OLMOS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 8699,
    EndHeightLeft = 8498,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006600,
    Name = "LOS ONAS",
    FullName = "LOS ONAS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006605,
    Name = "LOS PARAISOS",
    FullName = "LOS PARAISOS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006610,
    Name = "LOS PATAGONES",
    FullName = "LOS PATAGONES, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006615,
    Name = "LOS PILAGAS",
    FullName = "LOS PILAGAS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006620,
    Name = "LOS PINOS",
    FullName = "LOS PINOS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006625,
    Name = "LOS PLATANOS",
    FullName = "LOS PLATANOS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006630,
    Name = "LOS PUELCHES",
    FullName = "LOS PUELCHES, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006635,
    Name = "LOS QUEBRACHOS",
    FullName = "LOS QUEBRACHOS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006655,
    Name = "LOS ROBLES",
    FullName = "LOS ROBLES, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006660,
    Name = "LOS SANAVIRONES",
    FullName = "LOS SANAVIRONES, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006665,
    Name = "LOS SAUCES",
    FullName = "LOS SAUCES, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006670,
    Name = "LOS TALAS",
    FullName = "LOS TALAS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006675,
    Name = "LOS TAPES",
    FullName = "LOS TAPES, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006680,
    Name = "LOS TEHUELCHES",
    FullName = "LOS TEHUELCHES, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006685,
    Name = "LOS TILOS",
    FullName = "LOS TILOS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006690,
    Name = "LOS TIMBUES",
    FullName = "LOS TIMBUES, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006695,
    Name = "LOS TOBAS",
    FullName = "LOS TOBAS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006700,
    Name = "LOS TOTORAS",
    FullName = "LOS TOTORAS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006705,
    Name = "LOS WICHIES",
    FullName = "LOS WICHIES, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006710,
    Name = "LOS XIUX",
    FullName = "LOS XIUX, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006715,
    Name = "LUCANIA",
    FullName = "LUCANIA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 1298,
    EndHeightLeft = 1299,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006720,
    Name = "LUIS A GALLO",
    FullName = "LUIS A GALLO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006725,
    Name = "LUIS ANGEL FIRPO",
    FullName = "LUIS ANGEL FIRPO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 298,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006730,
    Name = "LUIS DEL HIERRO",
    FullName = "LUIS DEL HIERRO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006735,
    Name = "LUIS DEL ORO",
    FullName = "LUIS DEL ORO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006740,
    Name = "LUIS FRANCO",
    FullName = "LUIS FRANCO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006745,
    Name = "LUIS SANDRINI",
    FullName = "LUIS SANDRINI, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006750,
    Name = "LUIS VARESE",
    FullName = "LUIS VARESE, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006755,
    Name = "LUISONI",
    FullName = "LUISONI, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 8098,
    EndHeightLeft = 8399,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006760,
    Name = "M CHILABERT BIS",
    FullName = "M CHILABERT BIS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006765,
    Name = "M T DE ALVEAR",
    FullName = "M T DE ALVEAR, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006770,
    Name = "M URRUTIA",
    FullName = "M URRUTIA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006775,
    Name = "MAC GAUL ANDRES BIS",
    FullName = "MAC GAUL ANDRES BIS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006780,
    Name = "MACEDONIO FERNANDEZ",
    FullName = "MACEDONIO FERNANDEZ, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 2498,
    EndHeightLeft = 2598,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006782,
    Name = "MADARIAGA",
    FullName = "MADARIAGA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006785,
    Name = "MAGABURU BIS",
    FullName = "MAGABURU BIS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 7999,
    EndHeightLeft = 7998,
    StartHeightRight = 7901,
    StartHeightLeft = 7900,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006790,
    Name = "MAGALLANES",
    FullName = "MAGALLANES, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 54999,
    EndHeightLeft = 76999,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006795,
    Name = "MAGALLANES BIS",
    FullName = "MAGALLANES BIS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006800,
    Name = "MAGRASSI GUILLERMO",
    FullName = "MAGRASSI GUILLERMO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 5099,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006805,
    Name = "MANCO CAPAC",
    FullName = "MANCO CAPAC, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006810,
    Name = "MANGORE",
    FullName = "MANGORE, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006815,
    Name = "MANRIQUE",
    FullName = "MANRIQUE, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006820,
    Name = "MANSILLA LUCIO",
    FullName = "MANSILLA LUCIO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006825,
    Name = "MANUEL GRANDE",
    FullName = "MANUEL GRANDE, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006830,
    Name = "MANUWAL A V",
    FullName = "MANUWAL A V, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 8398,
    EndHeightLeft = 19999,
    StartHeightRight = 0,
    StartHeightLeft = 1901,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006835,
    Name = "MARCELO G PLANES",
    FullName = "MARCELO G PLANES, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006840,
    Name = "MARCELO JULIO FITTE DOCTOR",
    FullName = "MARCELO JULIO FITTE DOCTOR, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006845,
    Name = "MARCELO T DE ALVEAR DOCTOR",
    FullName = "MARCELO T DE ALVEAR DOCTOR, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006850,
    Name = "MARECHAL",
    FullName = "MARECHAL, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 6799,
    EndHeightLeft = 6798,
    StartHeightRight = 2600,
    StartHeightLeft = 6400,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006855,
    Name = "MARIA GERTRUDIS",
    FullName = "MARIA GERTRUDIS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006860,
    Name = "MARIANO A CISNEROS",
    FullName = "MARIANO A CISNEROS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006865,
    Name = "MARIANO ROSAS",
    FullName = "MARIANO ROSAS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 6398,
    EndHeightLeft = 6399,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006870,
    Name = "MARILIN",
    FullName = "MARILIN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006875,
    Name = "MARILIN II",
    FullName = "MARILIN II, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006880,
    Name = "MARILUZ",
    FullName = "MARILUZ, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006885,
    Name = "MARIO BRAVO",
    FullName = "MARIO BRAVO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006890,
    Name = "MARIO R LUNA",
    FullName = "MARIO R LUNA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006895,
    Name = "MARMOL JOSE",
    FullName = "MARMOL JOSE, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 999,
    EndHeightLeft = 998,
    StartHeightRight = 1,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006900,
    Name = "MARQUEZ",
    FullName = "MARQUEZ, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006905,
    Name = "MARTIN FIERRO",
    FullName = "MARTIN FIERRO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006910,
    Name = "MARTINEZ",
    FullName = "MARTINEZ, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 3499,
    EndHeightLeft = 3498,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006915,
    Name = "MARTINEZ DE HOZ FLORENCIO BIS",
    FullName = "MARTINEZ DE HOZ FLORENCIO BIS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006920,
    Name = "MASCIAS R",
    FullName = "MASCIAS R, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 8059,
    EndHeightLeft = 2098,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006925,
    Name = "MATIENZO BENJAMIN",
    FullName = "MATIENZO BENJAMIN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006930,
    Name = "MAYOR JR FALCONIER",
    FullName = "MAYOR JR FALCONIER, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006935,
    Name = "MELINAO",
    FullName = "MELINAO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006940,
    Name = "MENDIOROZ B",
    FullName = "MENDIOROZ B, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 8398,
    EndHeightLeft = 8199,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006945,
    Name = "MENGHIN EDUARDO",
    FullName = "MENGHIN EDUARDO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006950,
    Name = "MERCEDES",
    FullName = "MERCEDES, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006955,
    Name = "MINUANES",
    FullName = "MINUANES, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006960,
    Name = "MISIONES",
    FullName = "MISIONES, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 4098,
    EndHeightLeft = 3999,
    StartHeightRight = 3800,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006965,
    Name = "MOCORETA",
    FullName = "MOCORETA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006970,
    Name = "MOCTEZUMA",
    FullName = "MOCTEZUMA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006975,
    Name = "MONACO",
    FullName = "MONACO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 6298,
    StartHeightRight = 0,
    StartHeightLeft = 6200,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006980,
    Name = "MONSALVO",
    FullName = "MONSALVO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 3499,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006985,
    Name = "MONSENOR SEGURA",
    FullName = "MONSENOR SEGURA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006990,
    Name = "MONSENOR ERNESTO SEGURA",
    FullName = "MONSENOR ERNESTO SEGURA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711006995,
    Name = "MONSENOR RAU BIS",
    FullName = "MONSENOR RAU BIS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007000,
    Name = "MOYANO C",
    FullName = "MOYANO C, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007005,
    Name = "MUELLE",
    FullName = "MUELLE, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007010,
    Name = "N ROMANO",
    FullName = "N ROMANO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 3499,
    EndHeightLeft = 3498,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007015,
    Name = "N MIGUELETES",
    FullName = "N MIGUELETES, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007020,
    Name = "NAHUEL HUAPI",
    FullName = "NAHUEL HUAPI, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007025,
    Name = "NAHUELPAN",
    FullName = "NAHUELPAN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007195,
    Name = "PASEO DAVILA",
    FullName = "PASEO DAVILA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007030,
    Name = "NAMUNCURA",
    FullName = "NAMUNCURA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007035,
    Name = "NAVARRA",
    FullName = "NAVARRA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 548,
    EndHeightLeft = 1799,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007040,
    Name = "NERUDA",
    FullName = "NERUDA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 2498,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007045,
    Name = "NEWBERY JORGE",
    FullName = "NEWBERY JORGE, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 8499,
    EndHeightLeft = 8398,
    StartHeightRight = 7901,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007050,
    Name = "NICARAGUA",
    FullName = "NICARAGUA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 10699,
    EndHeightLeft = 2098,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007055,
    Name = "NOGAL",
    FullName = "NOGAL, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 99,
    EndHeightLeft = 98,
    StartHeightRight = 1,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007060,
    Name = "NOGALES",
    FullName = "NOGALES, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007065,
    Name = "NUESTRA SENORA DE SCHOENSTDL",
    FullName = "NUESTRA SENORA DE SCHOENSTDL, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007070,
    Name = "NUEVO BOSQUE",
    FullName = "NUEVO BOSQUE, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007075,
    Name = "O DE ZARATE",
    FullName = "O DE ZARATE, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007080,
    Name = "OJO DE AGUA",
    FullName = "OJO DE AGUA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007085,
    Name = "OLAVARRIA",
    FullName = "OLAVARRIA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007090,
    Name = "OLEGARIO OLAZAR",
    FullName = "OLEGARIO OLAZAR, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 600,
    EndHeightLeft = 599,
    StartHeightRight = 102,
    StartHeightLeft = 101,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007095,
    Name = "OLMO",
    FullName = "OLMO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007100,
    Name = "OLMOS",
    FullName = "OLMOS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007105,
    Name = "OMBUES",
    FullName = "OMBUES, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 399,
    EndHeightLeft = 398,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007110,
    Name = "ONEGLIA",
    FullName = "ONEGLIA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007115,
    Name = "ORIGONE",
    FullName = "ORIGONE, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 8198,
    EndHeightLeft = 8399,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007200,
    Name = "PASEO JESUS DE GALINDEZ",
    FullName = "PASEO JESUS DE GALINDEZ, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007120,
    Name = "ORTIZ DE ZARATE",
    FullName = "ORTIZ DE ZARATE, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 72098,
    EndHeightLeft = 77999,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007125,
    Name = "OSCAR DIARTE",
    FullName = "OSCAR DIARTE, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007130,
    Name = "OUTES FELIX",
    FullName = "OUTES FELIX, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007135,
    Name = "P GOYENA",
    FullName = "P GOYENA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007140,
    Name = "PADRE SAN PIO DE PIETRELCINA",
    FullName = "PADRE SAN PIO DE PIETRELCINA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007145,
    Name = "PAGANO",
    FullName = "PAGANO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007150,
    Name = "PALESTINA",
    FullName = "PALESTINA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007155,
    Name = "PALMA RICARDO",
    FullName = "PALMA RICARDO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 2598,
    EndHeightLeft = 2599,
    StartHeightRight = 0,
    StartHeightLeft = 1,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007160,
    Name = "PAMPERO",
    FullName = "PAMPERO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007165,
    Name = "PARAISOS",
    FullName = "PARAISOS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007170,
    Name = "PARODI",
    FullName = "PARODI, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007175,
    Name = "PARRAVICINI",
    FullName = "PARRAVICINI, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007180,
    Name = "PASAJE ARRIBENOS",
    FullName = "PASAJE ARRIBENOS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "PJE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007185,
    Name = "PASAJE DEL TEJAR",
    FullName = "PASAJE DEL TEJAR, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "PJE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007190,
    Name = "PASEO CARIBE",
    FullName = "PASEO CARIBE, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007205,
    Name = "PASEO VICTORIA OCAMPO",
    FullName = "PASEO VICTORIA OCAMPO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007210,
    Name = "PATAGONIA",
    FullName = "PATAGONIA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007215,
    Name = "PEDRO BOUCHEZ",
    FullName = "PEDRO BOUCHEZ, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 8198,
    EndHeightLeft = 8199,
    StartHeightRight = 7400,
    StartHeightLeft = 7401,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007220,
    Name = "PEDRO ZANINI",
    FullName = "PEDRO ZANINI, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007225,
    Name = "PEDRONI",
    FullName = "PEDRONI, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 5899,
    EndHeightLeft = 5898,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007230,
    Name = "PEHUAJO",
    FullName = "PEHUAJO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 2999,
    EndHeightLeft = 1698,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007235,
    Name = "PERITO MORENO",
    FullName = "PERITO MORENO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007240,
    Name = "PESQUERO ALMA MADRE",
    FullName = "PESQUERO ALMA MADRE, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007245,
    Name = "PESQUERO HALCON",
    FullName = "PESQUERO HALCON, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 3098,
    StartHeightRight = 0,
    StartHeightLeft = 3000,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007250,
    Name = "PESQUERO HAPPI DAIS",
    FullName = "PESQUERO HAPPI DAIS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007255,
    Name = "PESQUERO KONTIKI",
    FullName = "PESQUERO KONTIKI, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007260,
    Name = "PESQUERO NOMADE",
    FullName = "PESQUERO NOMADE, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007265,
    Name = "PESQUERO NORWAL",
    FullName = "PESQUERO NORWAL, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007270,
    Name = "PESQUERO PUMAO",
    FullName = "PESQUERO PUMAO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007275,
    Name = "PESQUERO QUO VADI",
    FullName = "PESQUERO QUO VADI, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007280,
    Name = "PINCEN",
    FullName = "PINCEN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007285,
    Name = "PINO",
    FullName = "PINO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 8398,
    EndHeightLeft = 8399,
    StartHeightRight = 0,
    StartHeightLeft = 8301,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007290,
    Name = "PINOS",
    FullName = "PINOS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007295,
    Name = "PINACAL",
    FullName = "PINACAL, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007300,
    Name = "PIONERO",
    FullName = "PIONERO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007320,
    Name = "PJE 175 BIS",
    FullName = "PJE 175 BIS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "PJE",
    EndHeightRight = 7499,
    EndHeightLeft = 7998,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007325,
    Name = "PJE 22 DE ABRIL",
    FullName = "PJE 22 DE ABRIL, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "PJE",
    EndHeightRight = 8998,
    EndHeightLeft = 8999,
    StartHeightRight = 8900,
    StartHeightLeft = 8901,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007330,
    Name = "PJE CARLOS GARDEL",
    FullName = "PJE CARLOS GARDEL, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "PJE",
    EndHeightRight = 6898,
    EndHeightLeft = 0,
    StartHeightRight = 6600,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007335,
    Name = "PJE DE ANGELIS",
    FullName = "PJE DE ANGELIS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "PJE",
    EndHeightRight = 199,
    EndHeightLeft = 198,
    StartHeightRight = 1,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007340,
    Name = "PJE ECHEVERRIA",
    FullName = "PJE ECHEVERRIA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "PJE",
    EndHeightRight = 1141,
    EndHeightLeft = 1142,
    StartHeightRight = 1101,
    StartHeightLeft = 1100,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007345,
    Name = "PJE ERREA FERMIN",
    FullName = "PJE ERREA FERMIN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "PJE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007350,
    Name = "PJE GABITO BANAT",
    FullName = "PJE GABITO BANAT, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "PJE",
    EndHeightRight = 3198,
    EndHeightLeft = 3199,
    StartHeightRight = 3000,
    StartHeightLeft = 3001,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007355,
    Name = "PJE LUJAN",
    FullName = "PJE LUJAN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "PJE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007360,
    Name = "PJE MAR DEL PLATA",
    FullName = "PJE MAR DEL PLATA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "PJE",
    EndHeightRight = 599,
    EndHeightLeft = 598,
    StartHeightRight = 501,
    StartHeightLeft = 500,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007365,
    Name = "PJE OLLEROS",
    FullName = "PJE OLLEROS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "PJE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007370,
    Name = "PJE PAEATONAL SN",
    FullName = "PJE PAEATONAL SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "PJE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007375,
    Name = "PJE PARANA",
    FullName = "PJE PARANA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "PJE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007380,
    Name = "PJE PORTUGAL",
    FullName = "PJE PORTUGAL, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "PJE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007385,
    Name = "PJE ROSALES",
    FullName = "PJE ROSALES, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "PJE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007390,
    Name = "PJE SAN BENITO",
    FullName = "PJE SAN BENITO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "PJE",
    EndHeightRight = 7798,
    EndHeightLeft = 7799,
    StartHeightRight = 7600,
    StartHeightLeft = 7601,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007395,
    Name = "PJE SAN BERNARDO",
    FullName = "PJE SAN BERNARDO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "PJE",
    EndHeightRight = 599,
    EndHeightLeft = 598,
    StartHeightRight = 301,
    StartHeightLeft = 300,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007400,
    Name = "PJE T DEL FOURNIER",
    FullName = "PJE T DEL FOURNIER, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "PJE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007405,
    Name = "PJE TECE",
    FullName = "PJE TECE, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "PJE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007410,
    Name = "PLATANOS",
    FullName = "PLATANOS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007415,
    Name = "PLUS ULTRA",
    FullName = "PLUS ULTRA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 2098,
    EndHeightLeft = 2099,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007420,
    Name = "POLITTIZ",
    FullName = "POLITTIZ, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007425,
    Name = "PREFECTURA NAVAL ARGENTINA",
    FullName = "PREFECTURA NAVAL ARGENTINA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007430,
    Name = "PSJ BERUTI",
    FullName = "PSJ BERUTI, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007435,
    Name = "PTA RAMOS E BIS",
    FullName = "PTA RAMOS E BIS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007440,
    Name = "PTO MADRYN",
    FullName = "PTO MADRYN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007445,
    Name = "PUAN",
    FullName = "PUAN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007450,
    Name = "PUEYRREDON",
    FullName = "PUEYRREDON, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007455,
    Name = "PUEYRREDON DIAG",
    FullName = "PUEYRREDON DIAG, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 3398,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007460,
    Name = "QUANTEMOC",
    FullName = "QUANTEMOC, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007465,
    Name = "QUEEN MARY",
    FullName = "QUEEN MARY, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 3798,
    StartHeightRight = 0,
    StartHeightLeft = 3600,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007470,
    Name = "QUERANDIES",
    FullName = "QUERANDIES, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007475,
    Name = "QUESADA J",
    FullName = "QUESADA J, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007480,
    Name = "QUIROGA HORACIO",
    FullName = "QUIROGA HORACIO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 4599,
    EndHeightLeft = 4598,
    StartHeightRight = 4201,
    StartHeightLeft = 4200,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007485,
    Name = "RAUCH BIS",
    FullName = "RAUCH BIS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007490,
    Name = "RECUERDOS",
    FullName = "RECUERDOS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 1899,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007495,
    Name = "REGION MOLISE",
    FullName = "REGION MOLISE, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007500,
    Name = "REJON GERONIMO",
    FullName = "REJON GERONIMO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 7698,
    EndHeightLeft = 7799,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007505,
    Name = "REPUBLICA DE SUDAFRICA",
    FullName = "REPUBLICA DE SUDAFRICA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007510,
    Name = "REPUBLIQUETAS",
    FullName = "REPUBLIQUETAS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007515,
    Name = "RICARDO M GURRIERI",
    FullName = "RICARDO M GURRIERI, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007520,
    Name = "RINGUELET",
    FullName = "RINGUELET, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007525,
    Name = "RIO DE LA PLATA",
    FullName = "RIO DE LA PLATA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007530,
    Name = "RIO GALLEGOS",
    FullName = "RIO GALLEGOS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007535,
    Name = "RIO IGUAZU",
    FullName = "RIO IGUAZU, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 3399,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007540,
    Name = "RIO MATANZA",
    FullName = "RIO MATANZA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007545,
    Name = "RIZZUTO",
    FullName = "RIZZUTO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 99,
    EndHeightLeft = 198,
    StartHeightRight = 1,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007555,
    Name = "ROBERTO PAYRO",
    FullName = "ROBERTO PAYRO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 4698,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007560,
    Name = "ROBLE",
    FullName = "ROBLE, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 839,
    EndHeightLeft = 8398,
    StartHeightRight = 8301,
    StartHeightLeft = 830,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007565,
    Name = "ROBLES",
    FullName = "ROBLES, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007570,
    Name = "ROCAS CORMORAN",
    FullName = "ROCAS CORMORAN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007575,
    Name = "ROCHA DARDO",
    FullName = "ROCHA DARDO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 799,
    EndHeightLeft = 698,
    StartHeightRight = 1,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007580,
    Name = "RODOLFO WALSH",
    FullName = "RODOLFO WALSH, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 898,
    EndHeightLeft = 1099,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007585,
    Name = "RODRIGUEZ",
    FullName = "RODRIGUEZ, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007590,
    Name = "RODRIGUEZ PENA",
    FullName = "RODRIGUEZ PENA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007595,
    Name = "ROFFO",
    FullName = "ROFFO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 2598,
    EndHeightLeft = 2599,
    StartHeightRight = 0,
    StartHeightLeft = 1,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007600,
    Name = "ROJAS",
    FullName = "ROJAS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007605,
    Name = "ROMERO E",
    FullName = "ROMERO E, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 2198,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007610,
    Name = "ROMERO E",
    FullName = "ROMERO E, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 2098,
    EndHeightLeft = 2099,
    StartHeightRight = 2002,
    StartHeightLeft = 2001,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007615,
    Name = "ROMPEHIELOS IRIZAR",
    FullName = "ROMPEHIELOS IRIZAR, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007620,
    Name = "ROMPEHIELOS SAN MARTIN",
    FullName = "ROMPEHIELOS SAN MARTIN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 3999,
    EndHeightLeft = 3798,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007625,
    Name = "ROTONDA EL ZORZAL",
    FullName = "ROTONDA EL ZORZAL, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007630,
    Name = "RUTA 11",
    FullName = "RUTA 11, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "RUTA",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007635,
    Name = "RTA 2 - AV MONS JUAN ZABALA",
    FullName = "RTA 2 - AV MONS JUAN ZABALA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "AV",
    EndHeightRight = 2198,
    EndHeightLeft = 1498,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007640,
    Name = "RUTA NAC 2",
    FullName = "RUTA NAC 2, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "RUTA",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007645,
    Name = "RUTA NACIONAL 226",
    FullName = "RUTA NACIONAL 226, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "RUTA",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007650,
    Name = "RUTA PCIAL 11",
    FullName = "RUTA PCIAL 11, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "RUTA",
    EndHeightRight = 0,
    EndHeightLeft = 3699,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007655,
    Name = "SAN ANTONIO",
    FullName = "SAN ANTONIO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 8899,
    EndHeightLeft = 8898,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007660,
    Name = "SAN ANTONIO II",
    FullName = "SAN ANTONIO II, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007665,
    Name = "SAN CAYETANO",
    FullName = "SAN CAYETANO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007670,
    Name = "SAN FRANCISCO DE ASIS",
    FullName = "SAN FRANCISCO DE ASIS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007675,
    Name = "SAN FRANCISCO DE JAVIER",
    FullName = "SAN FRANCISCO DE JAVIER, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007680,
    Name = "SAN JOSE DE CALASANZ BIS",
    FullName = "SAN JOSE DE CALASANZ BIS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007685,
    Name = "SAN PATRICIO",
    FullName = "SAN PATRICIO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007690,
    Name = "SAN PEDRO",
    FullName = "SAN PEDRO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007695,
    Name = "SAN SALVADOR",
    FullName = "SAN SALVADOR, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 68989,
    EndHeightLeft = 74199,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007700,
    Name = "SANCHEZ DE TOMPSON",
    FullName = "SANCHEZ DE TOMPSON, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 9499,
    EndHeightLeft = 9500,
    StartHeightRight = 8701,
    StartHeightLeft = 8702,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007705,
    Name = "SANDINO",
    FullName = "SANDINO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 2199,
    EndHeightLeft = 2198,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007710,
    Name = "SANTA ELENA",
    FullName = "SANTA ELENA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007715,
    Name = "SANTA INES",
    FullName = "SANTA INES, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007720,
    Name = "SANTA MARGARITA",
    FullName = "SANTA MARGARITA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007730,
    Name = "SANTA ROSA",
    FullName = "SANTA ROSA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007735,
    Name = "SANTIAGO LACAMTU",
    FullName = "SANTIAGO LACAMTU, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007740,
    Name = "SASTRE MARCOS",
    FullName = "SASTRE MARCOS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 2598,
    EndHeightLeft = 2899,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007745,
    Name = "SAUCES",
    FullName = "SAUCES, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 98,
    EndHeightLeft = 199,
    StartHeightRight = 0,
    StartHeightLeft = 1,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007750,
    Name = "SCIOCCO DOMINGO",
    FullName = "SCIOCCO DOMINGO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 3499,
    EndHeightLeft = 3498,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007755,
    Name = "SEBASTIAN GARAU",
    FullName = "SEBASTIAN GARAU, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007760,
    Name = "SEGURA G",
    FullName = "SEGURA G, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007765,
    Name = "SEMBRADOR",
    FullName = "SEMBRADOR, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007770,
    Name = "SEVERO RUIZ",
    FullName = "SEVERO RUIZ, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007775,
    Name = "SEVILLA",
    FullName = "SEVILLA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007780,
    Name = "SICILIA BIS",
    FullName = "SICILIA BIS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007785,
    Name = "SILVIA OCAMPO",
    FullName = "SILVIA OCAMPO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 9499,
    EndHeightLeft = 10000,
    StartHeightRight = 8701,
    StartHeightLeft = 8702,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007790,
    Name = "SOIHUEQUE",
    FullName = "SOIHUEQUE, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 6398,
    EndHeightLeft = 6399,
    StartHeightRight = 6200,
    StartHeightLeft = 6201,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007795,
    Name = "SOLDADO JOSE LUIS DEL HIERRO",
    FullName = "SOLDADO JOSE LUIS DEL HIERRO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007800,
    Name = "SOLDADO ROLANDO PACHOLEZUK",
    FullName = "SOLDADO ROLANDO PACHOLEZUK, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007890,
    Name = "TRES ARROYOS",
    FullName = "TRES ARROYOS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007892,
    Name = "TRINIDAD Y TOBAGO",
    FullName = "TRINIDAD Y TOBAGO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007805,
    Name = "SOLIS",
    FullName = "SOLIS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 58899,
    EndHeightLeft = 75899,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007810,
    Name = "SOLIS BIS",
    FullName = "SOLIS BIS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007815,
    Name = "SOUESSIA",
    FullName = "SOUESSIA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 998,
    EndHeightLeft = 999,
    StartHeightRight = 700,
    StartHeightLeft = 701,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007820,
    Name = "STELLA MARIS",
    FullName = "STELLA MARIS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007825,
    Name = "SUBMARINO SANTA FE",
    FullName = "SUBMARINO SANTA FE, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007830,
    Name = "SUBOFICIAL 1º FELIX OSCAR ARTUSO",
    FullName = "SUBOFICIAL 1º FELIX OSCAR ARTUSO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007835,
    Name = "SUQUIA",
    FullName = "SUQUIA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007840,
    Name = "TAGLE",
    FullName = "TAGLE, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007845,
    Name = "TALCAHUANO",
    FullName = "TALCAHUANO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 3399,
    EndHeightLeft = 3398,
    StartHeightRight = 3201,
    StartHeightLeft = 3200,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007850,
    Name = "TAVELLI",
    FullName = "TAVELLI, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007855,
    Name = "TAYLOR",
    FullName = "TAYLOR, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007860,
    Name = "TENIENTE 1º FAUSTO GAVAZZI",
    FullName = "TENIENTE 1º FAUSTO GAVAZZI, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007865,
    Name = "TOMAS YEMEHUECH",
    FullName = "TOMAS YEMEHUECH, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 9500,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007870,
    Name = "TORDO",
    FullName = "TORDO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007875,
    Name = "TORRES DE VERA Y ARAGON",
    FullName = "TORRES DE VERA Y ARAGON, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 6999,
    EndHeightLeft = 6998,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007880,
    Name = "TOSCANA",
    FullName = "TOSCANA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007885,
    Name = "TRANSPORTE ISLA DE LOS ESTADOS",
    FullName = "TRANSPORTE ISLA DE LOS ESTADOS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 3498,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007895,
    Name = "TRIUNVIRATO OESTE",
    FullName = "TRIUNVIRATO OESTE, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007900,
    Name = "TTE DACNARY",
    FullName = "TTE DACNARY, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007905,
    Name = "TUPAC AMARU",
    FullName = "TUPAC AMARU, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007910,
    Name = "URQUIA",
    FullName = "URQUIA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 3498,
    EndHeightLeft = 3499,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007915,
    Name = "USUAHIA",
    FullName = "USUAHIA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007920,
    Name = "V LABORANTE",
    FullName = "V LABORANTE, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 2198,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007925,
    Name = "VALENCIA",
    FullName = "VALENCIA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007930,
    Name = "VECINALISTA A MOLFENI",
    FullName = "VECINALISTA A MOLFENI, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 4799,
    EndHeightLeft = 4798,
    StartHeightRight = 4701,
    StartHeightLeft = 4700,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007935,
    Name = "VELEZ",
    FullName = "VELEZ, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 8099,
    EndHeightLeft = 0,
    StartHeightRight = 8001,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007940,
    Name = "VERNE",
    FullName = "VERNE, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 9299,
    EndHeightLeft = 9298,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007945,
    Name = "VIEDMA",
    FullName = "VIEDMA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007950,
    Name = "VILLAR BIS",
    FullName = "VILLAR BIS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007955,
    Name = "VILLARINO",
    FullName = "VILLARINO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007960,
    Name = "VINA DEL MAR",
    FullName = "VINA DEL MAR, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 8899,
    EndHeightLeft = 7978,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007965,
    Name = "VIOLETAS",
    FullName = "VIOLETAS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 1298,
    EndHeightLeft = 1299,
    StartHeightRight = 1100,
    StartHeightLeft = 1101,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007970,
    Name = "VIRGEN DE LA LAGRIMA",
    FullName = "VIRGEN DE LA LAGRIMA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007975,
    Name = "VIRREY DEL PINO",
    FullName = "VIRREY DEL PINO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007980,
    Name = "VUELTA DE OBLIGADO",
    FullName = "VUELTA DE OBLIGADO, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 5998,
    EndHeightLeft = 5999,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007985,
    Name = "VULCAN",
    FullName = "VULCAN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 3498,
    EndHeightLeft = 3499,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711007995,
    Name = "YAHATY JUAN",
    FullName = "YAHATY JUAN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711008000,
    Name = "YANQUETRUZ",
    FullName = "YANQUETRUZ, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711008005,
    Name = "YAPEYU",
    FullName = "YAPEYU, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 798,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711008010,
    Name = "YAPEYU BIS",
    FullName = "YAPEYU BIS, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711008015,
    Name = "ZUBIARRE DIAG",
    FullName = "ZUBIARRE DIAG, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 4098,
    EndHeightLeft = 4099,
    StartHeightRight = 4000,
    StartHeightLeft = 4001,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711008020,
    Name = "ZURITA",
    FullName = "ZURITA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711099936,
    Name = "PASAJE SN",
    FullName = "PASAJE SN, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "PJE",
    EndHeightRight = 9898,
    EndHeightLeft = 8698,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
},

new Street
{
    Id = 635711099995,
    Name = "CALLE INTERNA",
    FullName = "CALLE INTERNA, Buenos Aires, General Pueyrredón",
    Source = "INDEC",
    Category = "CALLE",
    EndHeightRight = 0,
    EndHeightLeft = 0,
    StartHeightRight = 0,
    StartHeightLeft = 0,
    LocalityId = 6357110,
}
            );
        }
    }
}