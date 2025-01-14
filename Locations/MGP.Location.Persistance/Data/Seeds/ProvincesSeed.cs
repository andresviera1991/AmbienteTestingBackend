using MGP.Location.Persistance.Data.Tables;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace MGP.Location.Persistance.Data.Seeds
{
    public class ProvincesSeed : IEntityTypeConfiguration<Province>
    {
        public void Configure(EntityTypeBuilder<Province> builder)
        {
            builder.HasData(
                new Province
                {
                    Id = 02,
                    Name = "Ciudad Autónoma de Buenos Aires",
                    FullName = "Ciudad Autónoma de Buenos Aires",
                    Source = "IGN",
                    Category = "Ciudad Autónoma",
                    CentroidLon = -58.4458763250916,
                    CentroidLat = -34.6144420654301,
                    IsoId = "AR-C",
                    IsoName = "Ciudad Autónoma de Buenos Aires"
                },
                new Province
                {
                    Id = 58,
                    Name = "Neuquén",
                    FullName = "Provincia del Neuquén",
                    Source = "IGN",
                    Category = "Provincia",
                    CentroidLon = -70.1198972237318,
                    CentroidLat = -38.6419828626673,
                    IsoId = "AR-Q",
                    IsoName = "Neuquén"
                },
                new Province
                {
                    Id = 74,
                    Name = "San Luis",
                    FullName = "Provincia de San Luis",
                    Source = "IGN",
                    Category = "Provincia",
                    CentroidLon = -66.0252312714021,
                    CentroidLat = -33.7611035381154,
                    IsoId = "AR-D",
                    IsoName = "San Luis"
                },
                new Province
                {
                    Id = 82,
                    Name = "Santa Fe",
                    FullName = "Provincia de Santa Fe",
                    Source = "IGN",
                    Category = "Provincia",
                    CentroidLon = -60.9506872769706,
                    CentroidLat = -30.7088227091528,
                    IsoId = "AR-S",
                    IsoName = "Santa Fe"
                },
                new Province
                {
                    Id = 46,
                    Name = "La Rioja",
                    FullName = "Provincia de La Rioja",
                    Source = "IGN",
                    Category = "Provincia",
                    CentroidLon = -67.1817575814487,
                    CentroidLat = -29.6849372775783,
                    IsoId = "AR-F",
                    IsoName = "La Rioja"
                },
                new Province
                {
                    Id = 10,
                    Name = "Catamarca",
                    FullName = "Provincia de Catamarca",
                    Source = "IGN",
                    Category = "Provincia",
                    CentroidLon = -66.9478972451295,
                    CentroidLat = -27.3359537960762,
                    IsoId = "AR-K",
                    IsoName = "Catamarca"
                },
                new Province
                {
                    Id = 90,
                    Name = "Tucumán",
                    FullName = "Provincia de Tucumán",
                    Source = "IGN",
                    Category = "Provincia",
                    CentroidLon = -65.3647655803683,
                    CentroidLat = -26.948283501723,
                    IsoId = "AR-T",
                    IsoName = "Tucumán"
                },
                new Province
                {
                    Id = 22,
                    Name = "Chaco",
                    FullName = "Provincia del Chaco",
                    Source = "IGN",
                    Category = "Provincia",
                    CentroidLon = -60.765116260356,
                    CentroidLat = -26.3869871835867,
                    IsoId = "AR-H",
                    IsoName = "Chaco"
                },
                new Province
                {
                    Id = 34,
                    Name = "Formosa",
                    FullName = "Provincia de Formosa",
                    Source = "IGN",
                    Category = "Provincia",
                    CentroidLon = -59.9321901121647,
                    CentroidLat = -24.8950871761481,
                    IsoId = "AR-P",
                    IsoName = "Formosa"
                },
                new Province
                {
                    Id = 78,
                    Name = "Santa Cruz",
                    FullName = "Provincia de Santa Cruz",
                    Source = "IGN",
                    Category = "Provincia",
                    CentroidLon = -69.9557619144913,
                    CentroidLat = -48.8155471830527,
                    IsoId = "AR-Z",
                    IsoName = "Santa Cruz"
                },
                new Province
                {
                    Id = 26,
                    Name = "Chubut",
                    FullName = "Provincia del Chubut",
                    Source = "IGN",
                    Category = "Provincia",
                    CentroidLon = -68.5267363339818,
                    CentroidLat = -43.7886271389083,
                    IsoId = "AR-U",
                    IsoName = "Chubut"
                },
                new Province
                {
                    Id = 50,
                    Name = "Mendoza",
                    FullName = "Provincia de Mendoza",
                    Source = "IGN",
                    Category = "Provincia",
                    CentroidLon = -68.5829456019867,
                    CentroidLat = -34.6303887067166,
                    IsoId = "AR-M",
                    IsoName = "Mendoza"
                },
                new Province
                {
                    Id = 30,
                    Name = "Entre Ríos",
                    FullName = "Provincia de Entre Ríos",
                    Source = "IGN",
                    Category = "Provincia",
                    CentroidLon = -59.201262616496,
                    CentroidLat = -32.0589278938558,
                    IsoId = "AR-E",
                    IsoName = "Entre Ríos"
                },
                new Province
                {
                    Id = 70,
                    Name = "San Juan",
                    FullName = "Provincia de San Juan",
                    Source = "IGN",
                    Category = "Provincia",
                    CentroidLon = -68.8881597071776,
                    CentroidLat = -30.8656607015096,
                    IsoId = "AR-J",
                    IsoName = "San Juan"
                },
                new Province
                {
                    Id = 38,
                    Name = "Jujuy",
                    FullName = "Provincia de Jujuy",
                    Source = "IGN",
                    Category = "Provincia",
                    CentroidLon = -65.764423919292,
                    CentroidLat = -23.3199750616583,
                    IsoId = "AR-Y",
                    IsoName = "Jujuy"
                },
                new Province
                {
                    Id = 86,
                    Name = "Santiago del Estero",
                    FullName = "Provincia de Santiago del Estero",
                    Source = "IGN",
                    Category = "Provincia",
                    CentroidLon = -63.2526268856462,
                    CentroidLat = -27.7834318817521,
                    IsoId = "AR-G",
                    IsoName = "Santiago del Estero"
                },
                new Province
                {
                    Id = 62,
                    Name = "Río Negro",
                    FullName = "Provincia de Río Negro",
                    Source = "IGN",
                    Category = "Provincia",
                    CentroidLon = -67.2296757996036,
                    CentroidLat = -40.4050796306359,
                    IsoId = "AR-R",
                    IsoName = "Río Negro"
                },
                new Province
                {
                    Id = 18,
                    Name = "Corrientes",
                    FullName = "Provincia de Corrientes",
                    Source = "IGN",
                    Category = "Provincia",
                    CentroidLon = -57.8010818603331,
                    CentroidLat = -28.7742044813623,
                    IsoId = "AR-W",
                    IsoName = "Corrientes"
                },
                new Province
                {
                    Id = 54,
                    Name = "Misiones",
                    FullName = "Provincia de Misiones",
                    Source = "IGN",
                    Category = "Provincia",
                    CentroidLon = -54.6515705627219,
                    CentroidLat = -26.8753025989034,
                    IsoId = "AR-N",
                    IsoName = "Misiones"
                },
                new Province
                {
                    Id = 66,
                    Name = "Salta",
                    FullName = "Provincia de Salta",
                    Source = "IGN",
                    Category = "Provincia",
                    CentroidLon = -64.8141586574346,
                    CentroidLat = -24.2992838957201,
                    IsoId = "AR-A",
                    IsoName = "Salta"
                },
                new Province
                {
                    Id = 14,
                    Name = "Córdoba",
                    FullName = "Provincia de Córdoba",
                    Source = "IGN",
                    Category = "Provincia",
                    CentroidLon = -63.801973466573,
                    CentroidLat = -32.1447993873859,
                    IsoId = "AR-X",
                    IsoName = "Córdoba"
                },
                new Province
                {
                    Id = 06,
                    Name = "Buenos Aires",
                    FullName = "Provincia de Buenos Aires",
                    Source = "IGN",
                    Category = "Provincia",
                    CentroidLon = -60.5584771084959,
                    CentroidLat = -36.6773920760823,
                    IsoId = "AR-B",
                    IsoName = "Buenos Aires"
                },
                new Province
                {
                    Id = 42,
                    Name = "La Pampa",
                    FullName = "Provincia de La Pampa",
                    Source = "IGN",
                    Category = "Provincia",
                    CentroidLon = -65.4476439990213,
                    CentroidLat = -37.1350652212898,
                    IsoId = "AR-L",
                    IsoName = "La Pampa"
                },
                new Province
                {
                    Id = 94,
                    Name = "Tierra del Fuego, Antártida e Islas del Atlántico Sur",
                    FullName = "Provincia de Tierra del Fuego, Antártida e Islas del Atlántico Sur",
                    Source = "IGN",
                    Category = "Provincia",
                    CentroidLon = -50.7428606764691,
                    CentroidLat = -82.5211345211545,
                    IsoId = "AR-V",
                    IsoName = "Tierra del Fuego"
                }
            );
        }
    }
}