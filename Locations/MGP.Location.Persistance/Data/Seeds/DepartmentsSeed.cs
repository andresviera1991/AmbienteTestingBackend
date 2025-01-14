using MGP.Location.Persistance.Data.Tables;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace MGP.Location.Persistance.Data.Seeds
{
    public class DepartmentsSeed : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.HasData(
                new Department
                {
                    Id = 6014,
                    Name = "Adolfo Gonzales Chaves",
                    Source = "IGN",
                    Category = "Partido",
                    Longitude = -60.2482821323384,
                    Latitude = -37.9646159068483,
                    ProvinceId = 6
                },

new Department
{
    Id = 30015,
    Name = "Concordia",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -58.2378696898985,
    Latitude = -31.2902983724746,
    ProvinceId = 30
},

new Department
{
    Id = 30035,
    Name = "Federal",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -58.8918600477175,
    Latitude = -30.9924267798293,
    ProvinceId = 30
},

new Department
{
    Id = 30056,
    Name = "Gualeguaychú",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -58.7858051710614,
    Latitude = -33.0223490410459,
    ProvinceId = 30
},

new Department
{
    Id = 30063,
    Name = "Islas del Ibicuy",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -58.9338958542555,
    Latitude = -33.6249961546235,
    ProvinceId = 30
},

new Department
{
    Id = 30105,
    Name = "Victoria",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -60.2180700308372,
    Latitude = -32.7839424597941,
    ProvinceId = 30
},

new Department
{
    Id = 30021,
    Name = "Diamante",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -60.5239335893593,
    Latitude = -32.228040549074,
    ProvinceId = 30
},

new Department
{
    Id = 30098,
    Name = "Uruguay",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -58.5842252100111,
    Latitude = -32.4477599400377,
    ProvinceId = 30
},

new Department
{
    Id = 30084,
    Name = "Paraná",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -60.0411744815271,
    Latitude = -31.6952294494901,
    ProvinceId = 30
},

new Department
{
    Id = 6707,
    Name = "Saladillo",
    Source = "IGN",
    Category = "Partido",
    Longitude = -59.7026607444531,
    Latitude = -35.676806451923,
    ProvinceId = 6
},

new Department
{
    Id = 6455,
    Name = "Las Flores",
    Source = "IGN",
    Category = "Partido",
    Longitude = -59.1764609497072,
    Latitude = -36.015826657022,
    ProvinceId = 6
},

new Department
{
    Id = 6686,
    Name = "Rojas",
    Source = "IGN",
    Category = "Partido",
    Longitude = -60.7880234647739,
    Latitude = -34.1928173894529,
    ProvinceId = 6
},

new Department
{
    Id = 6252,
    Name = "Escobar",
    Source = "IGN",
    Category = "Partido",
    Longitude = -58.7711786108511,
    Latitude = -34.3286828340822,
    ProvinceId = 6
},

new Department
{
    Id = 6412,
    Name = "José C. Paz",
    Source = "IGN",
    Category = "Partido",
    Longitude = -58.7776345982883,
    Latitude = -34.511853162718,
    ProvinceId = 6
},

new Department
{
    Id = 6056,
    Name = "Bahía Blanca",
    Source = "IGN",
    Category = "Partido",
    Longitude = -62.1694174494415,
    Latitude = -38.5841892126256,
    ProvinceId = 6
},

new Department
{
    Id = 6735,
    Name = "San Antonio de Areco",
    Source = "IGN",
    Category = "Partido",
    Longitude = -59.5194434817548,
    Latitude = -34.2207575658705,
    ProvinceId = 6
},

new Department
{
    Id = 6511,
    Name = "Maipú",
    Source = "IGN",
    Category = "Partido",
    Longitude = -57.5861191040468,
    Latitude = -36.886933208215,
    ProvinceId = 6
},

new Department
{
    Id = 6280,
    Name = "General Alvarado",
    Source = "IGN",
    Category = "Partido",
    Longitude = -58.0718053725136,
    Latitude = -38.2026277127362,
    ProvinceId = 6
},

new Department
{
    Id = 6357,
    Name = "General Pueyrredón",
    Source = "IGN",
    Category = "Partido",
    Longitude = -57.743028347627,
    Latitude = -37.9656831422541,
    ProvinceId = 6
},

new Department
{
    Id = 6518,
    Name = "Mar Chiquita",
    Source = "IGN",
    Category = "Partido",
    Longitude = -57.6432660560016,
    Latitude = -37.4986405981654,
    ProvinceId = 6
},

new Department
{
    Id = 6868,
    Name = "Villa Gesell",
    Source = "IGN",
    Category = "Partido",
    Longitude = -57.0633978822493,
    Latitude = -37.3670719558785,
    ProvinceId = 6
},

new Department
{
    Id = 6644,
    Name = "Pinamar",
    Source = "IGN",
    Category = "Partido",
    Longitude = -56.8702834122236,
    Latitude = -37.1110742904936,
    ProvinceId = 6
},

new Department
{
    Id = 6336,
    Name = "General Lavalle",
    Source = "IGN",
    Category = "Partido",
    Longitude = -56.9410029895247,
    Latitude = -36.650750377237,
    ProvinceId = 6
},

new Department
{
    Id = 6420,
    Name = "La Costa",
    Source = "IGN",
    Category = "Partido",
    Longitude = -56.7159402751909,
    Latitude = -36.6971678213727,
    ProvinceId = 6
},

new Department
{
    Id = 6505,
    Name = "Magdalena",
    Source = "IGN",
    Category = "Partido",
    Longitude = -57.6861279818118,
    Latitude = -35.1851030703307,
    ProvinceId = 6
},

new Department
{
    Id = 18175,
    Name = "Sauce",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -58.7949968561603,
    Latitude = -29.9995030631702,
    ProvinceId = 18
},

new Department
{
    Id = 6861,
    Name = "Vicente López",
    Source = "IGN",
    Category = "Partido",
    Longitude = -58.5044865130649,
    Latitude = -34.52653142362,
    ProvinceId = 6
},

new Department
{
    Id = 66098,
    Name = "La Viña",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -65.5805831392571,
    Latitude = -25.4471786730855,
    ProvinceId = 66
},

new Department
{
    Id = 6672,
    Name = "Rauch",
    Source = "IGN",
    Category = "Partido",
    Longitude = -58.9441413666159,
    Latitude = -36.5721944489319,
    ProvinceId = 6
},

new Department
{
    Id = 66112,
    Name = "Metán",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -64.5880714654829,
    Latitude = -25.4252109663753,
    ProvinceId = 66
},

new Department
{
    Id = 66119,
    Name = "Molinos",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -66.4548727525442,
    Latitude = -25.5643165283563,
    ProvinceId = 66
},

new Department
{
    Id = 22112,
    Name = "O'Higgins",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -60.6799749172166,
    Latitude = -27.2556537688374,
    ProvinceId = 22
},

new Department
{
    Id = 6560,
    Name = "Moreno",
    Source = "IGN",
    Category = "Partido",
    Longitude = -58.8108985084565,
    Latitude = -34.6106807864965,
    ProvinceId = 6
},

new Department
{
    Id = 6427,
    Name = "La Matanza",
    Source = "IGN",
    Category = "Partido",
    Longitude = -58.6254456945004,
    Latitude = -34.7703481015398,
    ProvinceId = 6
},

new Department
{
    Id = 6791,
    Name = "Tandil",
    Source = "IGN",
    Category = "Partido",
    Longitude = -59.1819827896233,
    Latitude = -37.3364293166464,
    ProvinceId = 6
},

new Department
{
    Id = 6203,
    Name = "Coronel Suárez",
    Source = "IGN",
    Category = "Partido",
    Longitude = -61.8890922422146,
    Latitude = -37.534856250067,
    ProvinceId = 6
},

new Department
{
    Id = 46035,
    Name = "Chamical",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -65.9564977168655,
    Latitude = -30.1676450229169,
    ProvinceId = 46
},

new Department
{
    Id = 26035,
    Name = "Futaleufú",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -71.4554653748233,
    Latitude = -43.0705971248375,
    ProvinceId = 26
},

new Department
{
    Id = 78049,
    Name = "Río Chico",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -71.113837498627,
    Latitude = -48.2873290195571,
    ProvinceId = 78
},

new Department
{
    Id = 62077,
    Name = "San Antonio",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -65.3712443332326,
    Latitude = -40.9526636914294,
    ProvinceId = 62
},

new Department
{
    Id = 86014,
    Name = "Alberdi",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -62.7280139284021,
    Latitude = -26.5210423501695,
    ProvinceId = 86
},

new Department
{
    Id = 86098,
    Name = "Juan Felipe Ibarra",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -62.5443747130478,
    Latitude = -28.0394929915456,
    ProvinceId = 86
},

new Department
{
    Id = 86077,
    Name = "General Taboada",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -62.3387633833787,
    Latitude = -28.5683250686056,
    ProvinceId = 86
},

new Department
{
    Id = 6721,
    Name = "Salliqueló",
    Source = "IGN",
    Category = "Partido",
    Longitude = -63.0479735266054,
    Latitude = -36.6717775352133,
    ProvinceId = 6
},

new Department
{
    Id = 6091,
    Name = "Berazategui",
    Source = "IGN",
    Category = "Partido",
    Longitude = -58.155461508679,
    Latitude = -34.8182447703794,
    ProvinceId = 6
},

new Department
{
    Id = 66049,
    Name = "General Güemes",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -64.9560620821107,
    Latitude = -24.7646021168635,
    ProvinceId = 66
},

new Department
{
    Id = 66154,
    Name = "San Carlos",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -66.1746708204562,
    Latitude = -25.8295042903902,
    ProvinceId = 66
},

new Department
{
    Id = 6343,
    Name = "General Paz",
    Source = "IGN",
    Category = "Partido",
    Longitude = -58.389651959253,
    Latitude = -35.466183010272,
    ProvinceId = 6
},

new Department
{
    Id = 6308,
    Name = "General Guido",
    Source = "IGN",
    Category = "Partido",
    Longitude = -57.9957365952016,
    Latitude = -36.6660345415851,
    ProvinceId = 6
},

new Department
{
    Id = 6315,
    Name = "General Juan Madariaga",
    Source = "IGN",
    Category = "Partido",
    Longitude = -57.2306605949345,
    Latitude = -37.1535157186092,
    ProvinceId = 6
},

new Department
{
    Id = 78028,
    Name = "Lago Argentino",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -72.06547133431,
    Latitude = -49.8364881436802,
    ProvinceId = 78
},

new Department
{
    Id = 86154,
    Name = "Rivadavia",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -62.280260406999,
    Latitude = -30.0205069976617,
    ProvinceId = 86
},

new Department
{
    Id = 86126,
    Name = "Ojo de Agua",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -64.0144967880943,
    Latitude = -29.3043766197306,
    ProvinceId = 86
},

new Department
{
    Id = 86063,
    Name = "Choya",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -64.7638924389835,
    Latitude = -28.7541678003854,
    ProvinceId = 86
},

new Department
{
    Id = 74042,
    Name = "Gobernador Dupuy",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -65.809487372821,
    Latitude = -35.3684506230675,
    ProvinceId = 74
},

new Department
{
    Id = 66014,
    Name = "Cachi",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -66.2026200885047,
    Latitude = -25.038755786337,
    ProvinceId = 66
},

new Department
{
    Id = 66042,
    Name = "Chicoana",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -65.6063327574043,
    Latitude = -25.1514413324719,
    ProvinceId = 66
},

new Department
{
    Id = 26042,
    Name = "Gaiman",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -66.1720705793314,
    Latitude = -43.2725140893505,
    ProvinceId = 26
},

new Department
{
    Id = 26077,
    Name = "Rawson",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -65.0757170605931,
    Latitude = -43.1373292631623,
    ProvinceId = 26
},

new Department
{
    Id = 46077,
    Name = "General Lamadrid",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -68.6975444932226,
    Latitude = -28.7904386774179,
    ProvinceId = 46
},

new Department
{
    Id = 74007,
    Name = "Ayacucho",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -66.5423618070089,
    Latitude = -32.1657217092103,
    ProvinceId = 74
},

new Department
{
    Id = 22036,
    Name = "12 de Octubre",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -61.4758065480051,
    Latitude = -27.3333760774448,
    ProvinceId = 22
},

new Department
{
    Id = 14175,
    Name = "Tulumba",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -63.8287887197042,
    Latitude = -30.2195169248248,
    ProvinceId = 14
},

new Department
{
    Id = 14028,
    Name = "Cruz del Eje",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -65.0782065927095,
    Latitude = -30.6567576546802,
    ProvinceId = 14
},

new Department
{
    Id = 14091,
    Name = "Punilla",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -64.5858722176043,
    Latitude = -31.2187582835824,
    ProvinceId = 14
},

new Department
{
    Id = 2042,
    Name = "Comuna 6",
    Source = "IGN",
    Category = "Comuna",
    Longitude = -58.4435682279951,
    Latitude = -34.6168433901026,
    ProvinceId = 2
},

new Department
{
    Id = 50112,
    Name = "Santa Rosa",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -67.9638561142682,
    Latitude = -33.6169989146657,
    ProvinceId = 50
},

new Department
{
    Id = 22063,
    Name = "General Güemes",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -61.3344270231873,
    Latitude = -25.212576905898,
    ProvinceId = 22
},

new Department
{
    Id = 46084,
    Name = "General Ortiz de Ocampo",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -66.0589849758729,
    Latitude = -31.0067607030974,
    ProvinceId = 46
},

new Department
{
    Id = 14035,
    Name = "General Roca",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -64.3730221441911,
    Latitude = -34.6231276675475,
    ProvinceId = 14
},

new Department
{
    Id = 34042,
    Name = "Pilagás",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -58.6616277481182,
    Latitude = -25.1053773069172,
    ProvinceId = 34
},

new Department
{
    Id = 34021,
    Name = "Laishi",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -58.5654632415076,
    Latitude = -26.4675822193402,
    ProvinceId = 34
},

new Department
{
    Id = 50084,
    Name = "Rivadavia",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -68.6049732994365,
    Latitude = -33.4170768899779,
    ProvinceId = 50
},

new Department
{
    Id = 6819,
    Name = "Tornquist",
    Source = "IGN",
    Category = "Partido",
    Longitude = -62.2905659977374,
    Latitude = -38.2576421634805,
    ProvinceId = 6
},

new Department
{
    Id = 50042,
    Name = "La Paz",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -67.2497236922759,
    Latitude = -33.7012853202088,
    ProvinceId = 50
},

new Department
{
    Id = 6196,
    Name = "Coronel Pringles",
    Source = "IGN",
    Category = "Partido",
    Longitude = -61.2644174529926,
    Latitude = -38.1479172688233,
    ProvinceId = 6
},

new Department
{
    Id = 62028,
    Name = "Conesa",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -64.3049127228304,
    Latitude = -40.1487161931233,
    ProvinceId = 62
},

new Department
{
    Id = 6875,
    Name = "Villarino",
    Source = "IGN",
    Category = "Partido",
    Longitude = -62.7245989548872,
    Latitude = -39.1285652325867,
    ProvinceId = 6
},

new Department
{
    Id = 34056,
    Name = "Pirané",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -59.1592563969217,
    Latitude = -25.7672913544641,
    ProvinceId = 34
},

new Department
{
    Id = 6351,
    Name = "General Pinto",
    Source = "IGN",
    Category = "Partido",
    Longitude = -62.0398536742269,
    Latitude = -34.6696214541604,
    ProvinceId = 6
},

new Department
{
    Id = 6742,
    Name = "San Cayetano",
    Source = "IGN",
    Category = "Partido",
    Longitude = -59.5863264400332,
    Latitude = -38.3890731972465,
    ProvinceId = 6
},

new Department
{
    Id = 6833,
    Name = "Tres Arroyos",
    Source = "IGN",
    Category = "Partido",
    Longitude = -60.2374173247047,
    Latitude = -38.5118142752579,
    ProvinceId = 6
},

new Department
{
    Id = 6189,
    Name = "Coronel Dorrego",
    Source = "IGN",
    Category = "Partido",
    Longitude = -61.0955505728699,
    Latitude = -38.6708176079735,
    ProvinceId = 6
},

new Department
{
    Id = 6581,
    Name = "Necochea",
    Source = "IGN",
    Category = "Partido",
    Longitude = -59.1673869468897,
    Latitude = -38.2554110045679,
    ProvinceId = 6
},

new Department
{
    Id = 46105,
    Name = "Independencia",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -67.3355098029644,
    Latitude = -30.1144556417024,
    ProvinceId = 46
},

new Department
{
    Id = 6218,
    Name = "Chascomús",
    Source = "IGN",
    Category = "Partido",
    Longitude = -57.9039810685242,
    Latitude = -35.6186883086057,
    ProvinceId = 6
},

new Department
{
    Id = 6655,
    Name = "Punta Indio",
    Source = "IGN",
    Category = "Partido",
    Longitude = -57.3992340402061,
    Latitude = -35.4260558765566,
    ProvinceId = 6
},

new Department
{
    Id = 38014,
    Name = "El Carmen",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -65.1012859046503,
    Latitude = -24.4475372667752,
    ProvinceId = 38
},

new Department
{
    Id = 14147,
    Name = "Santa María",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -64.3059021632813,
    Latitude = -31.7097123126909,
    ProvinceId = 14
},

new Department
{
    Id = 62084,
    Name = "Valcheta",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -66.3108907979663,
    Latitude = -40.9744584304307,
    ProvinceId = 62
},

new Department
{
    Id = 46007,
    Name = "Arauco",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -66.7191026010202,
    Latitude = -28.5330436663011,
    ProvinceId = 46
},

new Department
{
    Id = 6466,
    Name = "Lezama",
    Source = "IGN",
    Category = "Partido",
    Longitude = -57.8948443895452,
    Latitude = -35.8492083919939,
    ProvinceId = 6
},

new Department
{
    Id = 6126,
    Name = "Campana",
    Source = "IGN",
    Category = "Partido",
    Longitude = -58.8829573786215,
    Latitude = -34.1383889592817,
    ProvinceId = 6
},

new Department
{
    Id = 78042,
    Name = "Magallanes",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -68.4681621290535,
    Latitude = -48.8383418227095,
    ProvinceId = 78
},

new Department
{
    Id = 78007,
    Name = "Corpen Aike",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -69.4469507226845,
    Latitude = -49.9474837008291,
    ProvinceId = 78
},

new Department
{
    Id = 14070,
    Name = "Minas",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -65.4119724397194,
    Latitude = -31.0350313100891,
    ProvinceId = 14
},

new Department
{
    Id = 14126,
    Name = "San Alberto",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -65.1565147370037,
    Latitude = -31.7080283283874,
    ProvinceId = 14
},

new Department
{
    Id = 14119,
    Name = "Río Segundo",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -63.4748555205649,
    Latitude = -31.7331087895549,
    ProvinceId = 14
},

new Department
{
    Id = 14140,
    Name = "San Justo",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -62.5275890566991,
    Latitude = -31.242567096662,
    ProvinceId = 14
},

new Department
{
    Id = 14182,
    Name = "Unión",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -62.7915970558691,
    Latitude = -32.8783816611385,
    ProvinceId = 14
},

new Department
{
    Id = 14161,
    Name = "Tercero Arriba",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -63.77900489607,
    Latitude = -32.2876800226932,
    ProvinceId = 14
},

new Department
{
    Id = 66035,
    Name = "Cerrillos",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -65.4038161087861,
    Latitude = -24.9885439364757,
    ProvinceId = 66
},

new Department
{
    Id = 14098,
    Name = "Río Cuarto",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -64.4931343088767,
    Latitude = -33.330534188986,
    ProvinceId = 14
},

new Department
{
    Id = 50126,
    Name = "Tupungato",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -69.2962859030556,
    Latitude = -33.2934009869539,
    ProvinceId = 50
},

new Department
{
    Id = 62049,
    Name = "9 de Julio",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -67.4574916560521,
    Latitude = -40.9255514713631,
    ProvinceId = 62
},

new Department
{
    Id = 62056,
    Name = "Ñorquinco",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -70.4011459093449,
    Latitude = -41.7398229279456,
    ProvinceId = 62
},

new Department
{
    Id = 50105,
    Name = "San Rafael",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -68.384239783985,
    Latitude = -34.9454490543358,
    ProvinceId = 50
},

new Department
{
    Id = 66007,
    Name = "Anta",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -63.8397263286188,
    Latitude = -24.8754563539578,
    ProvinceId = 66
},

new Department
{
    Id = 58098,
    Name = "Picún Leufú",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -69.427190720517,
    Latitude = -39.4039652237483,
    ProvinceId = 58
},

new Department
{
    Id = 58112,
    Name = "Zapala",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -69.8223682005858,
    Latitude = -38.9221765260283,
    ProvinceId = 58
},

new Department
{
    Id = 62091,
    Name = "25 de Mayo",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -68.9063262041627,
    Latitude = -41.1330450365746,
    ProvinceId = 62
},

new Department
{
    Id = 26105,
    Name = "Telsen",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -67.176877305263,
    Latitude = -42.4388519406853,
    ProvinceId = 26
},

new Department
{
    Id = 62070,
    Name = "Pilcaniyeu",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -70.4627105357719,
    Latitude = -40.8875523576138,
    ProvinceId = 62
},

new Department
{
    Id = 6007,
    Name = "Adolfo Alsina",
    Source = "IGN",
    Category = "Partido",
    Longitude = -63.0560551528803,
    Latitude = -37.196762082356,
    ProvinceId = 6
},

new Department
{
    Id = 50014,
    Name = "General Alvear",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -67.0805881742222,
    Latitude = -35.2188456896959,
    ProvinceId = 50
},

new Department
{
    Id = 66077,
    Name = "La Caldera",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -65.4290994435937,
    Latitude = -24.5623996239199,
    ProvinceId = 66
},

new Department
{
    Id = 22154,
    Name = "Sargento Cabral",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -59.5191057139149,
    Latitude = -26.7997133020842,
    ProvinceId = 22
},

new Department
{
    Id = 6616,
    Name = "Pellegrini",
    Source = "IGN",
    Category = "Partido",
    Longitude = -63.2257521123403,
    Latitude = -36.2711917055859,
    ProvinceId = 6
},

new Department
{
    Id = 58007,
    Name = "Aluminé",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -71.0463179632078,
    Latitude = -39.1314863536249,
    ProvinceId = 58
},

new Department
{
    Id = 66070,
    Name = "Iruya",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -64.9205141250691,
    Latitude = -22.8153452313602,
    ProvinceId = 66
},

new Department
{
    Id = 58056,
    Name = "Lácar",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -71.1842639628873,
    Latitude = -40.314223088982,
    ProvinceId = 58
},

new Department
{
    Id = 10063,
    Name = "Fray Mamerto Esquiú",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -65.731187897962,
    Latitude = -28.3343382720204,
    ProvinceId = 10
},

new Department
{
    Id = 10112,
    Name = "Valle Viejo",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -65.7079324164837,
    Latitude = -28.6000684837485,
    ProvinceId = 10
},

new Department
{
    Id = 18133,
    Name = "San Cosme",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -58.5174742251831,
    Latitude = -27.3822986767274,
    ProvinceId = 18
},

new Department
{
    Id = 26091,
    Name = "Sarmiento",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -69.0028400019161,
    Latitude = -45.3450926864638,
    ProvinceId = 26
},

new Department
{
    Id = 2007,
    Name = "Comuna 1",
    Source = "IGN",
    Category = "Comuna",
    Longitude = -58.3715117424742,
    Latitude = -34.6064435423382,
    ProvinceId = 2
},

new Department
{
    Id = 2028,
    Name = "Comuna 4",
    Source = "IGN",
    Category = "Comuna",
    Longitude = -58.3875614030278,
    Latitude = -34.6421128950646,
    ProvinceId = 2
},

new Department
{
    Id = 62035,
    Name = "El Cuy",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -68.4827895211107,
    Latitude = -39.7003601698155,
    ProvinceId = 62
},

new Department
{
    Id = 50049,
    Name = "Las Heras",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -69.2679113756459,
    Latitude = -32.5246239358788,
    ProvinceId = 50
},

new Department
{
    Id = 22161,
    Name = "Tapenagá",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -59.827840211346,
    Latitude = -27.6596299369227,
    ProvinceId = 22
},

new Department
{
    Id = 50056,
    Name = "Lavalle",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -67.8966912637568,
    Latitude = -32.5754675617188,
    ProvinceId = 50
},

new Department
{
    Id = 50077,
    Name = "Malargüe",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -69.3130810458033,
    Latitude = -36.1589400383152,
    ProvinceId = 50
},

new Department
{
    Id = 14084,
    Name = "Presidente Roque Sáenz Peña",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -63.4188652087471,
    Latitude = -34.1404893695479,
    ProvinceId = 14
},

new Department
{
    Id = 58021,
    Name = "Catán Lil",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -70.4335593332114,
    Latitude = -39.4807942919835,
    ProvinceId = 58
},

new Department
{
    Id = 22119,
    Name = "Presidencia de la Plaza",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -59.7745640420007,
    Latitude = -27.0446247369186,
    ProvinceId = 22
},

new Department
{
    Id = 2035,
    Name = "Comuna 5",
    Source = "IGN",
    Category = "Comuna",
    Longitude = -58.4205721902504,
    Latitude = -34.6173699237915,
    ProvinceId = 2
},

new Department
{
    Id = 18049,
    Name = "Esquina",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -59.2413818424126,
    Latitude = -29.985327366863,
    ProvinceId = 18
},

new Department
{
    Id = 94015,
    Name = "Ushuaia",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -66.6836200601613,
    Latitude = -54.7704676359158,
    ProvinceId = 94
},

new Department
{
    Id = 10028,
    Name = "Antofagasta de la Sierra",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -67.6778798484787,
    Latitude = -25.9467556410811,
    ProvinceId = 10
},

new Department
{
    Id = 6245,
    Name = "Ensenada",
    Source = "IGN",
    Category = "Partido",
    Longitude = -57.9791090925538,
    Latitude = -34.8421497421872,
    ProvinceId = 6
},

new Department
{
    Id = 90084,
    Name = "Capital",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -65.2170208037282,
    Latitude = -26.8332209186353,
    ProvinceId = 90
},

new Department
{
    Id = 82007,
    Name = "Belgrano",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -61.7047364516353,
    Latitude = -32.6104361547012,
    ProvinceId = 82
},

new Department
{
    Id = 6623,
    Name = "Pergamino",
    Source = "IGN",
    Category = "Partido",
    Longitude = -60.5447828161659,
    Latitude = -33.8360668139653,
    ProvinceId = 6
},

new Department
{
    Id = 6651,
    Name = "Puán",
    Source = "IGN",
    Category = "Partido",
    Longitude = -63.0574326099086,
    Latitude = -38.0760763207387,
    ProvinceId = 6
},

new Department
{
    Id = 6392,
    Name = "General Villegas",
    Source = "IGN",
    Category = "Partido",
    Longitude = -62.9541988413061,
    Latitude = -34.7702605023112,
    ProvinceId = 6
},

new Department
{
    Id = 2084,
    Name = "Comuna 12",
    Source = "IGN",
    Category = "Comuna",
    Longitude = -58.4904280414968,
    Latitude = -34.5662276068999,
    ProvinceId = 2
},

new Department
{
    Id = 82049,
    Name = "General Obligado",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -59.5266963989458,
    Latitude = -28.672536399396,
    ProvinceId = 82
},

new Department
{
    Id = 82133,
    Name = "Vera",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -60.4136679252075,
    Latitude = -28.9706345150851,
    ProvinceId = 82
},

new Department
{
    Id = 82077,
    Name = "9 de Julio",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -61.3979945646643,
    Latitude = -28.8486776771703,
    ProvinceId = 82
},

new Department
{
    Id = 62007,
    Name = "Adolfo Alsina",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -63.7651004404077,
    Latitude = -40.7916894116905,
    ProvinceId = 62
},

new Department
{
    Id = 22133,
    Name = "Quitilipi",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -60.1729742758302,
    Latitude = -26.6663185244379,
    ProvinceId = 22
},

new Department
{
    Id = 78021,
    Name = "Güer Aike",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -70.5618155469082,
    Latitude = -51.4134125039336,
    ProvinceId = 78
},

new Department
{
    Id = 10042,
    Name = "Capayán",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -65.9017191021383,
    Latitude = -28.9094976289814,
    ProvinceId = 10
},

new Department
{
    Id = 90007,
    Name = "Burruyacú",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -64.8195981132229,
    Latitude = -26.5305481465544,
    ProvinceId = 90
},

new Department
{
    Id = 82105,
    Name = "San Jerónimo",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -61.0481265782097,
    Latitude = -32.1537713587336,
    ProvinceId = 82
},

new Department
{
    Id = 22070,
    Name = "Independencia",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -60.7563736019567,
    Latitude = -26.735179032354,
    ProvinceId = 22
},

new Department
{
    Id = 18035,
    Name = "Curuzú Cuatiá",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -58.3248599040647,
    Latitude = -29.6954668055505,
    ProvinceId = 18
},

new Department
{
    Id = 50063,
    Name = "Luján de Cuyo",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -69.4516850524047,
    Latitude = -33.0384947617689,
    ProvinceId = 50
},

new Department
{
    Id = 10105,
    Name = "Tinogasta",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -67.9307422147195,
    Latitude = -27.5418355834148,
    ProvinceId = 10
},

new Department
{
    Id = 2049,
    Name = "Comuna 7",
    Source = "IGN",
    Category = "Comuna",
    Longitude = -58.4518868569654,
    Latitude = -34.636554414358,
    ProvinceId = 2
},

new Department
{
    Id = 42077,
    Name = "Hucal",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -63.9544864276514,
    Latitude = -37.9792315730965,
    ProvinceId = 42
},

new Department
{
    Id = 18077,
    Name = "Itatí",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -58.0713817911441,
    Latitude = -27.3460559292444,
    ProvinceId = 18
},

new Department
{
    Id = 2070,
    Name = "Comuna 10",
    Source = "IGN",
    Category = "Comuna",
    Longitude = -58.5028178465965,
    Latitude = -34.6278517920976,
    ProvinceId = 2
},

new Department
{
    Id = 42014,
    Name = "Caleu Caleu",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -63.8968185406946,
    Latitude = -38.6756398635536,
    ProvinceId = 42
},

new Department
{
    Id = 42084,
    Name = "Lihuel Calel",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -65.0966893102146,
    Latitude = -38.2616348854642,
    ProvinceId = 42
},

new Department
{
    Id = 42042,
    Name = "Curacó",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -66.330067375997,
    Latitude = -38.1797329921075,
    ProvinceId = 42
},

new Department
{
    Id = 58035,
    Name = "Confluencia",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -68.7940772839278,
    Latitude = -38.8322794945189,
    ProvinceId = 58
},

new Department
{
    Id = 58105,
    Name = "Picunches",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -70.3729610459357,
    Latitude = -38.5742773422999,
    ProvinceId = 58
},

new Department
{
    Id = 58014,
    Name = "Añelo",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -69.0157147264732,
    Latitude = -38.0983759451619,
    ProvinceId = 58
},

new Department
{
    Id = 58063,
    Name = "Loncopué",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -70.3142327793889,
    Latitude = -38.0659451614955,
    ProvinceId = 58
},

new Department
{
    Id = 58084,
    Name = "Ñorquín",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -70.6780421229319,
    Latitude = -37.6381186650332,
    ProvinceId = 58
},

new Department
{
    Id = 58091,
    Name = "Pehuenches",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -69.4030432724945,
    Latitude = -37.3984094176891,
    ProvinceId = 58
},

new Department
{
    Id = 2077,
    Name = "Comuna 11",
    Source = "IGN",
    Category = "Comuna",
    Longitude = -58.4967420076817,
    Latitude = -34.6061370106731,
    ProvinceId = 2
},

new Department
{
    Id = 54084,
    Name = "Montecarlo",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -54.5631774506644,
    Latitude = -26.6579081868111,
    ProvinceId = 54
},

new Department
{
    Id = 54042,
    Name = "Eldorado",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -54.4407363386816,
    Latitude = -26.3138449972573,
    ProvinceId = 54
},

new Department
{
    Id = 54112,
    Name = "San Pedro",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -53.9629780421788,
    Latitude = -26.62996077436,
    ProvinceId = 54
},

new Department
{
    Id = 94028,
    Name = "Antártida Argentina",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -50.6480306037361,
    Latitude = -82.7776766547034,
    ProvinceId = 94
},

new Department
{
    Id = 58077,
    Name = "Minas",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -70.78364814983,
    Latitude = -36.8585578940124,
    ProvinceId = 58
},

new Department
{
    Id = 58042,
    Name = "Chos Malal",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -70.2863793101158,
    Latitude = -36.8805641891102,
    ProvinceId = 58
},

new Department
{
    Id = 26014,
    Name = "Cushamen",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -70.7119978032417,
    Latitude = -42.3663973043627,
    ProvinceId = 26
},

new Department
{
    Id = 78035,
    Name = "Lago Buenos Aires",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -70.6313995743965,
    Latitude = -46.8342043710739,
    ProvinceId = 78
},

new Department
{
    Id = 62063,
    Name = "Pichi Mahuida",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -64.4007362191104,
    Latitude = -39.4076049744942,
    ProvinceId = 62
},

new Department
{
    Id = 86175,
    Name = "San Martín",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -63.854114579261,
    Latitude = -28.1877612839021,
    ProvinceId = 86
},

new Department
{
    Id = 38112,
    Name = "Yavi",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -65.5667394207971,
    Latitude = -22.290645260596,
    ProvinceId = 38
},

new Department
{
    Id = 38077,
    Name = "Santa Catalina",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -66.227261407729,
    Latitude = -22.1376406851166,
    ProvinceId = 38
},

new Department
{
    Id = 38063,
    Name = "San Pedro",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -64.8109899059972,
    Latitude = -24.2985083171115,
    ProvinceId = 38
},

new Department
{
    Id = 38105,
    Name = "Valle Grande",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -65.0120193444126,
    Latitude = -23.4666140607053,
    ProvinceId = 38
},

new Department
{
    Id = 34035,
    Name = "Patiño",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -59.9584280130313,
    Latitude = -24.8750081858591,
    ProvinceId = 34
},

new Department
{
    Id = 34007,
    Name = "Bermejo",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -61.2828611773469,
    Latitude = -24.0254990220968,
    ProvinceId = 34
},

new Department
{
    Id = 38084,
    Name = "Susques",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -66.6617118803761,
    Latitude = -23.5206710927029,
    ProvinceId = 38
},

new Department
{
    Id = 34028,
    Name = "Matacos",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -62.0770650055764,
    Latitude = -23.8544865427827,
    ProvinceId = 34
},

new Department
{
    Id = 66105,
    Name = "Los Andes",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -67.3440956899683,
    Latitude = -24.6426248978878,
    ProvinceId = 66
},

new Department
{
    Id = 66126,
    Name = "Orán",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -64.150945650256,
    Latitude = -23.4987916315192,
    ProvinceId = 66
},

new Department
{
    Id = 38094,
    Name = "Tilcara",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -65.3200105901478,
    Latitude = -23.5604015183698,
    ProvinceId = 38
},

new Department
{
    Id = 38042,
    Name = "Palpalá",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -65.1264498101135,
    Latitude = -24.1949225166052,
    ProvinceId = 38
},

new Department
{
    Id = 42098,
    Name = "Loventué",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -65.533063651288,
    Latitude = -36.4785080840981,
    ProvinceId = 42
},

new Department
{
    Id = 26084,
    Name = "Río Senguer",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -70.6400850098256,
    Latitude = -45.3405591890669,
    ProvinceId = 26
},

new Department
{
    Id = 62021,
    Name = "Bariloche",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -71.5310863063756,
    Latitude = -41.4981376652733,
    ProvinceId = 62
},

new Department
{
    Id = 58049,
    Name = "Huiliches",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -71.2590025540624,
    Latitude = -39.7946776781884,
    ProvinceId = 58
},

new Department
{
    Id = 42091,
    Name = "Limay Mahuida",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -66.5552326917265,
    Latitude = -37.2419021199685,
    ProvinceId = 42
},

new Department
{
    Id = 42112,
    Name = "Puelén",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -67.6045329036613,
    Latitude = -37.4345215375332,
    ProvinceId = 42
},

new Department
{
    Id = 42049,
    Name = "Chalileo",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -66.5727424085761,
    Latitude = -36.395699692841,
    ProvinceId = 42
},

new Department
{
    Id = 42063,
    Name = "Chical Co",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -67.6944669009179,
    Latitude = -36.3969736431163,
    ProvinceId = 42
},

new Department
{
    Id = 86140,
    Name = "Quebrachos",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -63.3484161216539,
    Latitude = -29.3883234023198,
    ProvinceId = 86
},

new Department
{
    Id = 18112,
    Name = "Monte Caseros",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -57.870301871575,
    Latitude = -30.2289612354938,
    ProvinceId = 18
},

new Department
{
    Id = 22098,
    Name = "Mayor Luis J. Fontana",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -60.6567128818538,
    Latitude = -27.7429616104984,
    ProvinceId = 22
},

new Department
{
    Id = 22043,
    Name = "Fray Justo Santa María de Oro",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -61.3012288739823,
    Latitude = -27.8647076723602,
    ProvinceId = 22
},

new Department
{
    Id = 46063,
    Name = "General Belgrano",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -65.9324739936757,
    Latitude = -30.5778081168076,
    ProvinceId = 46
},

new Department
{
    Id = 82070,
    Name = "Las Colonias",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -61.1094808023915,
    Latitude = -31.3153379040603,
    ProvinceId = 82
},

new Department
{
    Id = 82112,
    Name = "San Justo",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -60.4886940672178,
    Latitude = -30.5304248144909,
    ProvinceId = 82
},

new Department
{
    Id = 82091,
    Name = "San Cristóbal",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -61.3599372073841,
    Latitude = -30.2283897206038,
    ProvinceId = 82
},

new Department
{
    Id = 82098,
    Name = "San Javier",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -59.8980704736792,
    Latitude = -30.1041461062467,
    ProvinceId = 82
},

new Department
{
    Id = 42056,
    Name = "Chapaleufú",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -63.6603750662124,
    Latitude = -35.2298937893695,
    ProvinceId = 42
},

new Department
{
    Id = 42133,
    Name = "Realicó",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -64.2098498059179,
    Latitude = -35.2306620563122,
    ProvinceId = 42
},

new Department
{
    Id = 42105,
    Name = "Maracó",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -63.6624899647122,
    Latitude = -35.6796161112326,
    ProvinceId = 42
},

new Department
{
    Id = 42147,
    Name = "Trenel",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -64.2143766255202,
    Latitude = -35.631875013139,
    ProvinceId = 42
},

new Department
{
    Id = 86056,
    Name = "Copo",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -62.7310972270609,
    Latitude = -25.9391612005653,
    ProvinceId = 86
},

new Department
{
    Id = 42021,
    Name = "Capital",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -64.198128304565,
    Latitude = -36.4980625982423,
    ProvinceId = 42
},

new Department
{
    Id = 38070,
    Name = "Santa Bárbara",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -64.4023116738515,
    Latitude = -24.007640144548,
    ProvinceId = 38
},

new Department
{
    Id = 22007,
    Name = "Almirante Brown",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -61.9589813624119,
    Latitude = -25.7452119099225,
    ProvinceId = 22
},

new Department
{
    Id = 66140,
    Name = "Rosario de la Frontera",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -64.7288089239246,
    Latitude = -25.8715613006323,
    ProvinceId = 66
},

new Department
{
    Id = 58028,
    Name = "Collón Curá",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -70.2813667759367,
    Latitude = -40.0529194288429,
    ProvinceId = 58
},

new Department
{
    Id = 2021,
    Name = "Comuna 3",
    Source = "IGN",
    Category = "Comuna",
    Longitude = -58.4026514511807,
    Latitude = -34.6138430816924,
    ProvinceId = 2
},

new Department
{
    Id = 6749,
    Name = "San Fernando",
    Source = "IGN",
    Category = "Partido",
    Longitude = -58.5345816568901,
    Latitude = -34.1558361119161,
    ProvinceId = 6
},

new Department
{
    Id = 6805,
    Name = "Tigre",
    Source = "IGN",
    Category = "Partido",
    Longitude = -58.5881738725709,
    Latitude = -34.382019907997,
    ProvinceId = 6
},

new Department
{
    Id = 10091,
    Name = "Santa María",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -66.2612705245824,
    Latitude = -26.7734648563207,
    ProvinceId = 10
},

new Department
{
    Id = 10098,
    Name = "Santa Rosa",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -65.3350824661739,
    Latitude = -28.082107971849,
    ProvinceId = 10
},

new Department
{
    Id = 10070,
    Name = "La Paz",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -65.1920338746874,
    Latitude = -29.3955036215545,
    ProvinceId = 10
},

new Department
{
    Id = 86147,
    Name = "Río Hondo",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -64.7601169003321,
    Latitude = -27.4855424248983,
    ProvinceId = 86
},

new Department
{
    Id = 46098,
    Name = "Vinchina",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -68.5252928296074,
    Latitude = -28.3166977149073,
    ProvinceId = 46
},

new Department
{
    Id = 46014,
    Name = "Capital",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -66.3526000997493,
    Latitude = -29.4605896547988,
    ProvinceId = 46
},

new Department
{
    Id = 14112,
    Name = "Río Seco",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -63.1990187799045,
    Latitude = -30.0450412488063,
    ProvinceId = 14
},

new Department
{
    Id = 62014,
    Name = "Avellaneda",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -66.20639651701,
    Latitude = -39.4102626929359,
    ProvinceId = 62
},

new Department
{
    Id = 62042,
    Name = "General Roca",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -67.5574036622512,
    Latitude = -38.5298947783261,
    ProvinceId = 62
},

new Department
{
    Id = 74014,
    Name = "Belgrano",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -66.7150525486673,
    Latitude = -32.7356111326592,
    ProvinceId = 74
},

new Department
{
    Id = 58070,
    Name = "Los Lagos",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -71.4867232511371,
    Latitude = -40.7743503720999,
    ProvinceId = 58
},

new Department
{
    Id = 10049,
    Name = "Capital",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -65.8367262921682,
    Latitude = -28.4117889646495,
    ProvinceId = 10
},

new Department
{
    Id = 10014,
    Name = "Ancasti",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -65.504299177941,
    Latitude = -28.9274130674418,
    ProvinceId = 10
},

new Department
{
    Id = 10084,
    Name = "Pomán",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -66.3888045363986,
    Latitude = -28.2337589059236,
    ProvinceId = 10
},

new Department
{
    Id = 2014,
    Name = "Comuna 2",
    Source = "IGN",
    Category = "Comuna",
    Longitude = -58.3949035422527,
    Latitude = -34.5857888788086,
    ProvinceId = 2
},

new Department
{
    Id = 22105,
    Name = "9 de Julio",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -61.264612522285,
    Latitude = -26.9436383020752,
    ProvinceId = 22
},

new Department
{
    Id = 14077,
    Name = "Pocho",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -65.4351550968219,
    Latitude = -31.4627416617352,
    ProvinceId = 14
},

new Department
{
    Id = 6270,
    Name = "Ezeiza",
    Source = "IGN",
    Category = "Partido",
    Longitude = -58.5647013731149,
    Latitude = -34.8760968437468,
    ProvinceId = 6
},

new Department
{
    Id = 10021,
    Name = "Andalgalá",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -66.3731024938335,
    Latitude = -27.5728459104474,
    ProvinceId = 10
},

new Department
{
    Id = 10007,
    Name = "Ambato",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -65.9227878835948,
    Latitude = -28.0199741656262,
    ProvinceId = 10
},

new Department
{
    Id = 2056,
    Name = "Comuna 8",
    Source = "IGN",
    Category = "Comuna",
    Longitude = -58.461948060155,
    Latitude = -34.6745664758358,
    ProvinceId = 2
},

new Department
{
    Id = 86084,
    Name = "Guasayán",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -64.8712241216861,
    Latitude = -27.9768511960939,
    ProvinceId = 86
},

new Department
{
    Id = 10077,
    Name = "Paclín",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -65.6743180153264,
    Latitude = -28.1103167424607,
    ProvinceId = 10
},

new Department
{
    Id = 10056,
    Name = "El Alto",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -65.3604289203864,
    Latitude = -28.4317063831316,
    ProvinceId = 10
},

new Department
{
    Id = 14154,
    Name = "Sobremonte",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -64.1425182645874,
    Latitude = -29.7643092597004,
    ProvinceId = 14
},

new Department
{
    Id = 94008,
    Name = "Río Grande",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -68.1361046544505,
    Latitude = -53.7462919871752,
    ProvinceId = 94
},

new Department
{
    Id = 2091,
    Name = "Comuna 13",
    Source = "IGN",
    Category = "Comuna",
    Longitude = -58.4540029618054,
    Latitude = -34.5541262964697,
    ProvinceId = 2
},

new Department
{
    Id = 86035,
    Name = "Banda",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -64.2098658068652,
    Latitude = -27.4347067680665,
    ProvinceId = 86
},

new Department
{
    Id = 26070,
    Name = "Paso de Indios",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -68.6858628378531,
    Latitude = -44.0301843801728,
    ProvinceId = 26
},

new Department
{
    Id = 14014,
    Name = "Capital",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -64.1835837727284,
    Latitude = -31.4167568770155,
    ProvinceId = 14
},

new Department
{
    Id = 26063,
    Name = "Mártires",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -67.2399811031767,
    Latitude = -43.8138479495924,
    ProvinceId = 26
},

new Department
{
    Id = 86182,
    Name = "Sarmiento",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -63.4461751488241,
    Latitude = -28.1061147414452,
    ProvinceId = 86
},

new Department
{
    Id = 78014,
    Name = "Deseado",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -68.0290548030539,
    Latitude = -47.3305629962178,
    ProvinceId = 78
},

new Department
{
    Id = 26056,
    Name = "Languiñeo",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -70.3484079877641,
    Latitude = -43.3234918785199,
    ProvinceId = 26
},

new Department
{
    Id = 86042,
    Name = "Belgrano",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -62.2182795085019,
    Latitude = -29.0815053728088,
    ProvinceId = 86
},

new Department
{
    Id = 86007,
    Name = "Aguirre",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -62.5150973801298,
    Latitude = -29.2979732282428,
    ProvinceId = 86
},

new Department
{
    Id = 22091,
    Name = "Maipú",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -60.4546439783309,
    Latitude = -26.3190099893669,
    ProvinceId = 22
},

new Department
{
    Id = 50091,
    Name = "San Carlos",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -69.0973090508602,
    Latitude = -34.0755248766466,
    ProvinceId = 50
},

new Department
{
    Id = 50119,
    Name = "Tunuyán",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -69.5092965661889,
    Latitude = -33.6228877049098,
    ProvinceId = 50
},

new Department
{
    Id = 86161,
    Name = "Robles",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -63.9075092603375,
    Latitude = -27.8539440726978,
    ProvinceId = 86
},

new Department
{
    Id = 86105,
    Name = "Loreto",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -64.3107274308462,
    Latitude = -28.6244804370084,
    ProvinceId = 86
},

new Department
{
    Id = 42028,
    Name = "Catriló",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -63.6648685343036,
    Latitude = -36.581670209145,
    ProvinceId = 42
},

new Department
{
    Id = 86049,
    Name = "Capital",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -64.435667540413,
    Latitude = -27.8847652276627,
    ProvinceId = 86
},

new Department
{
    Id = 2098,
    Name = "Comuna 14",
    Source = "IGN",
    Category = "Comuna",
    Longitude = -58.4222940810483,
    Latitude = -34.573874740768,
    ProvinceId = 2
},

new Department
{
    Id = 30008,
    Name = "Colón",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -58.3699129592392,
    Latitude = -32.0114827530749,
    ProvinceId = 30
},

new Department
{
    Id = 30113,
    Name = "Villaguay",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -59.0594708103114,
    Latitude = -31.6477388964372,
    ProvinceId = 30
},

new Department
{
    Id = 6168,
    Name = "Castelli",
    Source = "IGN",
    Category = "Partido",
    Longitude = -57.6574251943684,
    Latitude = -36.0414897439213,
    ProvinceId = 6
},

new Department
{
    Id = 30088,
    Name = "San Salvador",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -58.4863728567569,
    Latitude = -31.576883538854,
    ProvinceId = 30
},

new Department
{
    Id = 10035,
    Name = "Belén",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -66.9224805098511,
    Latitude = -27.1019560038189,
    ProvinceId = 10
},

new Department
{
    Id = 6028,
    Name = "Almirante Brown",
    Source = "IGN",
    Category = "Partido",
    Longitude = -58.36737293295,
    Latitude = -34.8356191132679,
    ProvinceId = 6
},

new Department
{
    Id = 30077,
    Name = "Nogoyá",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -59.7697019154662,
    Latitude = -32.2187123476403,
    ProvinceId = 30
},

new Department
{
    Id = 30091,
    Name = "Tala",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -59.2672864854832,
    Latitude = -32.3174117218427,
    ProvinceId = 30
},

new Department
{
    Id = 30049,
    Name = "Gualeguay",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -59.6014598265182,
    Latitude = -33.1192366285416,
    ProvinceId = 30
},

new Department
{
    Id = 30028,
    Name = "Federación",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -58.1591551818899,
    Latitude = -30.7348532046962,
    ProvinceId = 30
},

new Department
{
    Id = 30070,
    Name = "La Paz",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -59.5004308899395,
    Latitude = -30.8973573249588,
    ProvinceId = 30
},

new Department
{
    Id = 30042,
    Name = "Feliciano",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -58.7288907563202,
    Latitude = -30.4138996015365,
    ProvinceId = 30
},

new Department
{
    Id = 6648,
    Name = "Presidente Perón",
    Source = "IGN",
    Category = "Partido",
    Longitude = -58.3980842106611,
    Latitude = -34.9298478405731,
    ProvinceId = 6
},

new Department
{
    Id = 6413,
    Name = "Junín",
    Source = "IGN",
    Category = "Partido",
    Longitude = -61.0052501278322,
    Latitude = -34.5464751322689,
    ProvinceId = 6
},

new Department
{
    Id = 6119,
    Name = "Brandsen",
    Source = "IGN",
    Category = "Partido",
    Longitude = -58.1752339039367,
    Latitude = -35.2225197990076,
    ProvinceId = 6
},

new Department
{
    Id = 6224,
    Name = "Chivilcoy",
    Source = "IGN",
    Category = "Partido",
    Longitude = -59.9584194881488,
    Latitude = -34.915487328433,
    ProvinceId = 6
},

new Department
{
    Id = 6021,
    Name = "Alberti",
    Source = "IGN",
    Category = "Partido",
    Longitude = -60.2819765918318,
    Latitude = -35.0369685106341,
    ProvinceId = 6
},

new Department
{
    Id = 6112,
    Name = "Bragado",
    Source = "IGN",
    Category = "Partido",
    Longitude = -60.6040466528095,
    Latitude = -35.0614122707821,
    ProvinceId = 6
},

new Department
{
    Id = 6329,
    Name = "General Las Heras",
    Source = "IGN",
    Category = "Partido",
    Longitude = -58.9954466211925,
    Latitude = -34.9094243780878,
    ProvinceId = 6
},

new Department
{
    Id = 6147,
    Name = "Carlos Casares",
    Source = "IGN",
    Category = "Partido",
    Longitude = -61.3743777867738,
    Latitude = -35.7499222140362,
    ProvinceId = 6
},

new Department
{
    Id = 6525,
    Name = "Marcos Paz",
    Source = "IGN",
    Category = "Partido",
    Longitude = -58.8478312046572,
    Latitude = -34.8140029646158,
    ProvinceId = 6
},

new Department
{
    Id = 6385,
    Name = "General Viamonte",
    Source = "IGN",
    Category = "Partido",
    Longitude = -61.0496572343522,
    Latitude = -34.9977788912459,
    ProvinceId = 6
},

new Department
{
    Id = 6154,
    Name = "Carlos Tejedor",
    Source = "IGN",
    Category = "Partido",
    Longitude = -62.4297895789754,
    Latitude = -35.3797449374452,
    ProvinceId = 6
},

new Department
{
    Id = 6854,
    Name = "25 de Mayo",
    Source = "IGN",
    Category = "Partido",
    Longitude = -60.2302837885052,
    Latitude = -35.527208971772,
    ProvinceId = 6
},

new Department
{
    Id = 6588,
    Name = "9 de Julio",
    Source = "IGN",
    Category = "Partido",
    Longitude = -60.975425441559,
    Latitude = -35.4812271475831,
    ProvinceId = 6
},

new Department
{
    Id = 6609,
    Name = "Pehuajó",
    Source = "IGN",
    Category = "Partido",
    Longitude = -61.9281257343997,
    Latitude = -35.8836208341768,
    ProvinceId = 6
},

new Department
{
    Id = 6798,
    Name = "Tapalqué",
    Source = "IGN",
    Category = "Partido",
    Longitude = -60.1310650281756,
    Latitude = -36.3471436403082,
    ProvinceId = 6
},

new Department
{
    Id = 6826,
    Name = "Trenque Lauquen",
    Source = "IGN",
    Category = "Partido",
    Longitude = -62.6350797832329,
    Latitude = -36.0567662720701,
    ProvinceId = 6
},

new Department
{
    Id = 6301,
    Name = "General Belgrano",
    Source = "IGN",
    Category = "Partido",
    Longitude = -58.6980799686583,
    Latitude = -35.8346623469788,
    ProvinceId = 6
},

new Department
{
    Id = 6547,
    Name = "Monte",
    Source = "IGN",
    Category = "Partido",
    Longitude = -58.7672358382292,
    Latitude = -35.5098267581846,
    ProvinceId = 6
},

new Department
{
    Id = 6693,
    Name = "Roque Pérez",
    Source = "IGN",
    Category = "Partido",
    Longitude = -59.3575118159751,
    Latitude = -35.481635701192,
    ProvinceId = 6
},

new Department
{
    Id = 6595,
    Name = "Olavarría",
    Source = "IGN",
    Category = "Partido",
    Longitude = -60.6702054013071,
    Latitude = -36.8576340464573,
    ProvinceId = 6
},

new Department
{
    Id = 6539,
    Name = "Merlo",
    Source = "IGN",
    Category = "Partido",
    Longitude = -58.7419584139756,
    Latitude = -34.7110032783084,
    ProvinceId = 6
},

new Department
{
    Id = 54014,
    Name = "Cainguás",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -54.8023437852311,
    Latitude = -27.1478365768268,
    ProvinceId = 54
},

new Department
{
    Id = 94021,
    Name = "Islas del Atlántico Sur",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -53.4026402162418,
    Latitude = -52.5006628799787,
    ProvinceId = 94
},

new Department
{
    Id = 6260,
    Name = "Esteban Echeverría",
    Source = "IGN",
    Category = "Partido",
    Longitude = -58.4769479291405,
    Latitude = -34.8312135656106,
    ProvinceId = 6
},

new Department
{
    Id = 6077,
    Name = "Arrecifes",
    Source = "IGN",
    Category = "Partido",
    Longitude = -60.0626641477636,
    Latitude = -34.0118119181559,
    ProvinceId = 6
},

new Department
{
    Id = 6140,
    Name = "Capitán Sarmiento",
    Source = "IGN",
    Category = "Partido",
    Longitude = -59.8540147848747,
    Latitude = -34.1498445273572,
    ProvinceId = 6
},

new Department
{
    Id = 38021,
    Name = "Dr. Manuel Belgrano",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -65.4478782461086,
    Latitude = -24.0891183755518,
    ProvinceId = 38
},

new Department
{
    Id = 6161,
    Name = "Carmen de Areco",
    Source = "IGN",
    Category = "Partido",
    Longitude = -59.8844134882327,
    Latitude = -34.4067977883926,
    ProvinceId = 6
},

new Department
{
    Id = 6714,
    Name = "Salto",
    Source = "IGN",
    Category = "Partido",
    Longitude = -60.3052878686828,
    Latitude = -34.2710777868364,
    ProvinceId = 6
},

new Department
{
    Id = 6266,
    Name = "Exaltación de la Cruz",
    Source = "IGN",
    Category = "Partido",
    Longitude = -59.1559461316089,
    Latitude = -34.2951342236201,
    ProvinceId = 6
},

new Department
{
    Id = 6760,
    Name = "San Miguel",
    Source = "IGN",
    Category = "Partido",
    Longitude = -58.6917835230047,
    Latitude = -34.5521343486779,
    ProvinceId = 6
},

new Department
{
    Id = 6728,
    Name = "San Andrés de Giles",
    Source = "IGN",
    Category = "Partido",
    Longitude = -59.4731985905145,
    Latitude = -34.4377314289072,
    ProvinceId = 6
},

new Department
{
    Id = 6532,
    Name = "Mercedes",
    Source = "IGN",
    Category = "Partido",
    Longitude = -59.4204811393582,
    Latitude = -34.6973213261419,
    ProvinceId = 6
},

new Department
{
    Id = 6638,
    Name = "Pilar",
    Source = "IGN",
    Category = "Partido",
    Longitude = -58.9033327303822,
    Latitude = -34.4481640053043,
    ProvinceId = 6
},

new Department
{
    Id = 6497,
    Name = "Luján",
    Source = "IGN",
    Category = "Partido",
    Longitude = -59.1584564399668,
    Latitude = -34.5673224195595,
    ProvinceId = 6
},

new Department
{
    Id = 90028,
    Name = "Famaillá",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -65.4789084982894,
    Latitude = -26.9759689777425,
    ProvinceId = 90
},

new Department
{
    Id = 6408,
    Name = "Hurlingham",
    Source = "IGN",
    Category = "Partido",
    Longitude = -58.6495253867317,
    Latitude = -34.5992830551765,
    ProvinceId = 6
},

new Department
{
    Id = 6568,
    Name = "Morón",
    Source = "IGN",
    Category = "Partido",
    Longitude = -58.6198317111492,
    Latitude = -34.6493861631091,
    ProvinceId = 6
},

new Department
{
    Id = 6210,
    Name = "Chacabuco",
    Source = "IGN",
    Category = "Partido",
    Longitude = -60.3543081129662,
    Latitude = -34.6182002950801,
    ProvinceId = 6
},

new Department
{
    Id = 50035,
    Name = "Junín",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -68.4973606539186,
    Latitude = -33.1503940875751,
    ProvinceId = 50
},

new Department
{
    Id = 6515,
    Name = "Malvinas Argentinas",
    Source = "IGN",
    Category = "Partido",
    Longitude = -58.7121372415949,
    Latitude = -34.4873113444512,
    ProvinceId = 6
},

new Department
{
    Id = 6847,
    Name = "Tres Lomas",
    Source = "IGN",
    Category = "Partido",
    Longitude = -62.8639077725213,
    Latitude = -36.4971002162064,
    ProvinceId = 6
},

new Department
{
    Id = 6042,
    Name = "Ayacucho",
    Source = "IGN",
    Category = "Partido",
    Longitude = -58.4425565239465,
    Latitude = -37.0354309121063,
    ProvinceId = 6
},

new Department
{
    Id = 6399,
    Name = "Guaminí",
    Source = "IGN",
    Category = "Partido",
    Longitude = -62.4185310608382,
    Latitude = -36.8906755108534,
    ProvinceId = 6
},

new Department
{
    Id = 6371,
    Name = "General San Martín",
    Source = "IGN",
    Category = "Partido",
    Longitude = -58.5642821761285,
    Latitude = -34.5527719180977,
    ProvinceId = 6
},

new Department
{
    Id = 6469,
    Name = "Lincoln",
    Source = "IGN",
    Category = "Partido",
    Longitude = -61.6824583851265,
    Latitude = -35.0704479695471,
    ProvinceId = 6
},

new Department
{
    Id = 6448,
    Name = "Laprida",
    Source = "IGN",
    Category = "Partido",
    Longitude = -60.7681481810422,
    Latitude = -37.5165055849878,
    ProvinceId = 6
},

new Department
{
    Id = 6756,
    Name = "San Isidro",
    Source = "IGN",
    Category = "Partido",
    Longitude = -58.5372090766799,
    Latitude = -34.4868929544319,
    ProvinceId = 6
},

new Department
{
    Id = 6084,
    Name = "Benito Juárez",
    Source = "IGN",
    Category = "Partido",
    Longitude = -59.8883978406322,
    Latitude = -37.586110705761,
    ProvinceId = 6
},

new Department
{
    Id = 6175,
    Name = "Colón",
    Source = "IGN",
    Category = "Partido",
    Longitude = -61.0624837286828,
    Latitude = -33.885864543958,
    ProvinceId = 6
},

new Department
{
    Id = 6410,
    Name = "Ituzaingó",
    Source = "IGN",
    Category = "Partido",
    Longitude = -58.6887595155761,
    Latitude = -34.6360716118614,
    ProvinceId = 6
},

new Department
{
    Id = 6364,
    Name = "General Rodríguez",
    Source = "IGN",
    Category = "Partido",
    Longitude = -58.9878467982653,
    Latitude = -34.6506156900812,
    ProvinceId = 6
},

new Department
{
    Id = 6784,
    Name = "Suipacha",
    Source = "IGN",
    Category = "Partido",
    Longitude = -59.7033860485774,
    Latitude = -34.7485741352291,
    ProvinceId = 6
},

new Department
{
    Id = 6840,
    Name = "Tres de Febrero",
    Source = "IGN",
    Category = "Partido",
    Longitude = -58.5791883855736,
    Latitude = -34.5960100738691,
    ProvinceId = 6
},

new Department
{
    Id = 46028,
    Name = "General Felipe Varela",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -68.3285566475246,
    Latitude = -29.4499054722468,
    ProvinceId = 46
},

new Department
{
    Id = 6274,
    Name = "Florencio Varela",
    Source = "IGN",
    Category = "Partido",
    Longitude = -58.2585548857898,
    Latitude = -34.8777448240057,
    ProvinceId = 6
},

new Department
{
    Id = 6574,
    Name = "Navarro",
    Source = "IGN",
    Category = "Partido",
    Longitude = -59.4293585541147,
    Latitude = -35.0304844816228,
    ProvinceId = 6
},

new Department
{
    Id = 6134,
    Name = "Cañuelas",
    Source = "IGN",
    Category = "Partido",
    Longitude = -58.6910941846835,
    Latitude = -35.1448044957896,
    ProvinceId = 6
},

new Department
{
    Id = 86119,
    Name = "Moreno",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -62.4639026540336,
    Latitude = -27.2982006559922,
    ProvinceId = 86
},

new Department
{
    Id = 22028,
    Name = "Chacabuco",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -61.3088349505972,
    Latitude = -27.1153502635495,
    ProvinceId = 22
},

new Department
{
    Id = 6778,
    Name = "San Vicente",
    Source = "IGN",
    Category = "Partido",
    Longitude = -58.4318120603267,
    Latitude = -35.0715087168304,
    ProvinceId = 6
},

new Department
{
    Id = 6483,
    Name = "Lobos",
    Source = "IGN",
    Category = "Partido",
    Longitude = -59.1457418827425,
    Latitude = -35.2195857860094,
    ProvinceId = 6
},

new Department
{
    Id = 6287,
    Name = "General Alvear",
    Source = "IGN",
    Category = "Partido",
    Longitude = -60.1331531037654,
    Latitude = -36.0347106495852,
    ProvinceId = 6
},

new Department
{
    Id = 6658,
    Name = "Quilmes",
    Source = "IGN",
    Category = "Partido",
    Longitude = -58.2768580209942,
    Latitude = -34.7349707991152,
    ProvinceId = 6
},

new Department
{
    Id = 6630,
    Name = "Pila",
    Source = "IGN",
    Category = "Partido",
    Longitude = -58.3404430505536,
    Latitude = -36.2029842239612,
    ProvinceId = 6
},

new Department
{
    Id = 6322,
    Name = "General La Madrid",
    Source = "IGN",
    Category = "Partido",
    Longitude = -61.3441308948924,
    Latitude = -37.3561277769109,
    ProvinceId = 6
},

new Department
{
    Id = 6105,
    Name = "Bolívar",
    Source = "IGN",
    Category = "Partido",
    Longitude = -61.1498600852285,
    Latitude = -36.2989479582916,
    ProvinceId = 6
},

new Department
{
    Id = 46021,
    Name = "Castro Barros",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -66.918584755618,
    Latitude = -28.8599829479134,
    ProvinceId = 46
},

new Department
{
    Id = 6063,
    Name = "Balcarce",
    Source = "IGN",
    Category = "Partido",
    Longitude = -58.2717475616555,
    Latitude = -37.7146198082264,
    ProvinceId = 6
},

new Department
{
    Id = 6406,
    Name = "Hipólito Yrigoyen",
    Source = "IGN",
    Category = "Partido",
    Longitude = -61.660187626031,
    Latitude = -36.2591890205909,
    ProvinceId = 6
},

new Department
{
    Id = 50007,
    Name = "Capital",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -68.893648801808,
    Latitude = -32.8828960440395,
    ProvinceId = 50
},

new Department
{
    Id = 6238,
    Name = "Dolores",
    Source = "IGN",
    Category = "Partido",
    Longitude = -57.6319261244954,
    Latitude = -36.3989376730385,
    ProvinceId = 6
},

new Department
{
    Id = 6049,
    Name = "Azul",
    Source = "IGN",
    Category = "Partido",
    Longitude = -59.696478337621,
    Latitude = -36.7859352165928,
    ProvinceId = 6
},

new Department
{
    Id = 6231,
    Name = "Daireaux",
    Source = "IGN",
    Category = "Partido",
    Longitude = -61.8912495525965,
    Latitude = -36.6408692174847,
    ProvinceId = 6
},

new Department
{
    Id = 50021,
    Name = "Godoy Cruz",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -68.9141362247952,
    Latitude = -32.9320744395304,
    ProvinceId = 50
},

new Department
{
    Id = 66021,
    Name = "Cafayate",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -65.8767230578258,
    Latitude = -26.1257489988731,
    ProvinceId = 66
},

new Department
{
    Id = 86070,
    Name = "Figueroa",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -63.579632022065,
    Latitude = -27.3218567501665,
    ProvinceId = 86
},

new Department
{
    Id = 6700,
    Name = "Saavedra",
    Source = "IGN",
    Category = "Partido",
    Longitude = -62.4343829136658,
    Latitude = -37.7706381329573,
    ProvinceId = 6
},

new Department
{
    Id = 6553,
    Name = "Monte Hermoso",
    Source = "IGN",
    Category = "Partido",
    Longitude = -61.2921466954973,
    Latitude = -38.9616237886799,
    ProvinceId = 6
},

new Department
{
    Id = 6476,
    Name = "Lobería",
    Source = "IGN",
    Category = "Partido",
    Longitude = -58.6935497786696,
    Latitude = -38.090052818611,
    ProvinceId = 6
},

new Department
{
    Id = 6098,
    Name = "Berisso",
    Source = "IGN",
    Category = "Partido",
    Longitude = -57.8283797724826,
    Latitude = -34.9093551143988,
    ProvinceId = 6
},

new Department
{
    Id = 6812,
    Name = "Tordillo",
    Source = "IGN",
    Category = "Partido",
    Longitude = -57.2738116449804,
    Latitude = -36.3905151218837,
    ProvinceId = 6
},

new Department
{
    Id = 6882,
    Name = "Zárate",
    Source = "IGN",
    Category = "Partido",
    Longitude = -59.1282153004682,
    Latitude = -33.9970897980955,
    ProvinceId = 6
},

new Department
{
    Id = 6665,
    Name = "Ramallo",
    Source = "IGN",
    Category = "Partido",
    Longitude = -60.0575064405905,
    Latitude = -33.5871861466481,
    ProvinceId = 6
},

new Department
{
    Id = 6763,
    Name = "San Nicolás",
    Source = "IGN",
    Category = "Partido",
    Longitude = -60.2931487802824,
    Latitude = -33.4829873308981,
    ProvinceId = 6
},

new Department
{
    Id = 86168,
    Name = "Salavina",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -63.3035949539634,
    Latitude = -28.9187435895832,
    ProvinceId = 86
},

new Department
{
    Id = 86133,
    Name = "Pellegrini",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -64.0917498279144,
    Latitude = -26.2199018368927,
    ProvinceId = 86
},

new Department
{
    Id = 86028,
    Name = "Avellaneda",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -63.20376658846,
    Latitude = -28.555362665393,
    ProvinceId = 86
},

new Department
{
    Id = 22039,
    Name = "2 de Abril",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -61.3289519563791,
    Latitude = -27.6198551557059,
    ProvinceId = 22
},

new Department
{
    Id = 50028,
    Name = "Guaymallén",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -68.7333034931406,
    Latitude = -32.8929748154748,
    ProvinceId = 50
},

new Department
{
    Id = 14056,
    Name = "Juárez Celman",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -63.6063858554279,
    Latitude = -33.3295744809665,
    ProvinceId = 14
},

new Department
{
    Id = 66028,
    Name = "Capital",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -65.2713224010013,
    Latitude = -24.8897949232452,
    ProvinceId = 66
},

new Department
{
    Id = 86189,
    Name = "Silípica",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -64.2732683808613,
    Latitude = -28.1888486590344,
    ProvinceId = 86
},

new Department
{
    Id = 66084,
    Name = "La Candelaria",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -65.1760220468639,
    Latitude = -26.0848731785427,
    ProvinceId = 66
},

new Department
{
    Id = 42126,
    Name = "Rancul",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -64.7962057702449,
    Latitude = -35.408324405275,
    ProvinceId = 42
},

new Department
{
    Id = 50070,
    Name = "Maipú",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -68.6563133629426,
    Latitude = -32.9797495635853,
    ProvinceId = 50
},

new Department
{
    Id = 66063,
    Name = "Guachipas",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -65.4445406244237,
    Latitude = -25.7029584300217,
    ProvinceId = 66
},

new Department
{
    Id = 42007,
    Name = "Atreucó",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -63.7788849526284,
    Latitude = -37.0324944038817,
    ProvinceId = 42
},

new Department
{
    Id = 50098,
    Name = "San Martín",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -68.2888458647488,
    Latitude = -32.9140381657571,
    ProvinceId = 50
},

new Department
{
    Id = 42070,
    Name = "Guatraché",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -63.7813081297621,
    Latitude = -37.4836471472851,
    ProvinceId = 42
},

new Department
{
    Id = 46126,
    Name = "Sanagasta",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -67.0658836337284,
    Latitude = -29.1585269700836,
    ProvinceId = 46
},

new Department
{
    Id = 42035,
    Name = "Conhelo",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -64.5086492198133,
    Latitude = -36.0320043909386,
    ProvinceId = 42
},

new Department
{
    Id = 54077,
    Name = "Libertador General San Martín",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -54.9233629608393,
    Latitude = -26.8931448896048,
    ProvinceId = 54
},

new Department
{
    Id = 46112,
    Name = "Rosario Vera Peñaloza",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -66.6741641296595,
    Latitude = -31.4229834527921,
    ProvinceId = 46
},

new Department
{
    Id = 18154,
    Name = "San Miguel",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -57.4100421733803,
    Latitude = -27.8758596571718,
    ProvinceId = 18
},

new Department
{
    Id = 46070,
    Name = "General Juan Facundo Quiroga",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -66.8678571954155,
    Latitude = -30.8006382527121,
    ProvinceId = 46
},

new Department
{
    Id = 46056,
    Name = "Ángel Vicente Peñaloza",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -66.6630521188297,
    Latitude = -30.3128975387926,
    ProvinceId = 46
},

new Department
{
    Id = 18042,
    Name = "Empedrado",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -58.665840300338,
    Latitude = -27.8961126654966,
    ProvinceId = 18
},

new Department
{
    Id = 46042,
    Name = "Chilecito",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -67.427886789152,
    Latitude = -29.39593747537,
    ProvinceId = 46
},

new Department
{
    Id = 42140,
    Name = "Toay",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -64.6922110147401,
    Latitude = -36.662162152652,
    ProvinceId = 42
},

new Department
{
    Id = 14021,
    Name = "Colón",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -64.149086867857,
    Latitude = -31.1461809443167,
    ProvinceId = 14
},

new Department
{
    Id = 18084,
    Name = "Ituzaingó",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -56.790098223735,
    Latitude = -27.9113085755074,
    ProvinceId = 18
},

new Department
{
    Id = 46049,
    Name = "Famatina",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -67.5592543116777,
    Latitude = -28.6973536209113,
    ProvinceId = 46
},

new Department
{
    Id = 82042,
    Name = "General López",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -61.939680211795,
    Latitude = -33.9221898209726,
    ProvinceId = 82
},

new Department
{
    Id = 82028,
    Name = "Constitución",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -60.8374001304635,
    Latitude = -33.4871399171909,
    ProvinceId = 82
},

new Department
{
    Id = 82014,
    Name = "Caseros",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -61.5428621200429,
    Latitude = -33.2249739383268,
    ProvinceId = 82
},

new Department
{
    Id = 82084,
    Name = "Rosario",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -60.7232422315034,
    Latitude = -33.1178472652264,
    ProvinceId = 82
},

new Department
{
    Id = 82119,
    Name = "San Lorenzo",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -60.9640078882428,
    Latitude = -32.9413325358441,
    ProvinceId = 82
},

new Department
{
    Id = 82056,
    Name = "Iriondo",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -61.273387709005,
    Latitude = -32.7060836089974,
    ProvinceId = 82
},

new Department
{
    Id = 6434,
    Name = "Lanús",
    Source = "IGN",
    Category = "Partido",
    Longitude = -58.3946965048442,
    Latitude = -34.7056542439723,
    ProvinceId = 6
},

new Department
{
    Id = 46091,
    Name = "General San Martín",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -66.1458162300477,
    Latitude = -31.6414651427458,
    ProvinceId = 46
},

new Department
{
    Id = 46119,
    Name = "San Blas de Los Sauces",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -67.1581352967929,
    Latitude = -28.5432938438178,
    ProvinceId = 46
},

new Department
{
    Id = 38056,
    Name = "San Antonio",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -65.4465034514555,
    Latitude = -24.3466655289394,
    ProvinceId = 38
},

new Department
{
    Id = 38049,
    Name = "Rinconada",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -66.5415632203904,
    Latitude = -22.621441999219,
    ProvinceId = 38
},

new Department
{
    Id = 34063,
    Name = "Ramón Lista",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -62.1378892144612,
    Latitude = -23.120377014683,
    ProvinceId = 34
},

new Department
{
    Id = 66091,
    Name = "La Poma",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -66.2072973644748,
    Latitude = -24.146976523836,
    ProvinceId = 66
},

new Department
{
    Id = 26007,
    Name = "Biedma",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -64.9333479901808,
    Latitude = -42.4435913808796,
    ProvinceId = 26
},

new Department
{
    Id = 18021,
    Name = "Capital",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -58.7624842360155,
    Latitude = -27.5223367116017,
    ProvinceId = 18
},

new Department
{
    Id = 18140,
    Name = "San Luis del Palmar",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -58.2683508234644,
    Latitude = -27.6020530782378,
    ProvinceId = 18
},

new Department
{
    Id = 34014,
    Name = "Formosa",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -58.3773174492375,
    Latitude = -25.9396352320143,
    ProvinceId = 34
},

new Department
{
    Id = 34049,
    Name = "Pilcomayo",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -58.0626062654551,
    Latitude = -25.3700377166163,
    ProvinceId = 34
},

new Department
{
    Id = 26098,
    Name = "Tehuelches",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -70.5769493727789,
    Latitude = -44.2001445034306,
    ProvinceId = 26
},

new Department
{
    Id = 26021,
    Name = "Escalante",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -67.7088649201803,
    Latitude = -45.2828915460529,
    ProvinceId = 26
},

new Department
{
    Id = 14049,
    Name = "Ischilín",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -64.609928019562,
    Latitude = -30.3985157855081,
    ProvinceId = 14
},

new Department
{
    Id = 14168,
    Name = "Totoral",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -63.9844039885161,
    Latitude = -30.7263442710895,
    ProvinceId = 14
},

new Department
{
    Id = 14042,
    Name = "General San Martín",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -63.2562056057504,
    Latitude = -32.5143227869566,
    ProvinceId = 14
},

new Department
{
    Id = 14133,
    Name = "San Javier",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -65.1422236066015,
    Latitude = -32.0760871294213,
    ProvinceId = 14
},

new Department
{
    Id = 14105,
    Name = "Río Primero",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -63.436114778127,
    Latitude = -31.0315240757859,
    ProvinceId = 14
},

new Department
{
    Id = 14063,
    Name = "Marcos Juárez",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -62.2775947053165,
    Latitude = -33.0308431509632,
    ProvinceId = 14
},

new Department
{
    Id = 22056,
    Name = "General Donovan",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -59.3467829351985,
    Latitude = -27.1388899905163,
    ProvinceId = 22
},

new Department
{
    Id = 6462,
    Name = "Leandro N. Alem",
    Source = "IGN",
    Category = "Partido",
    Longitude = -61.6125874742962,
    Latitude = -34.4985652798534,
    ProvinceId = 6
},

new Department
{
    Id = 22084,
    Name = "Libertador General San Martín",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -59.4877181570758,
    Latitude = -26.3775454900773,
    ProvinceId = 22
},

new Department
{
    Id = 26049,
    Name = "Gastre",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -68.8023248035912,
    Latitude = -42.7490296126002,
    ProvinceId = 26
},

new Department
{
    Id = 6294,
    Name = "General Arenales",
    Source = "IGN",
    Category = "Partido",
    Longitude = -61.2833812257449,
    Latitude = -34.2379020431362,
    ProvinceId = 6
},

new Department
{
    Id = 22014,
    Name = "Bermejo",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -58.709116096044,
    Latitude = -26.9580421515067,
    ProvinceId = 22
},

new Department
{
    Id = 14007,
    Name = "Calamuchita",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -64.6151725606746,
    Latitude = -32.2020591306015,
    ProvinceId = 14
},

new Department
{
    Id = 90014,
    Name = "Cruz Alta",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -64.9738642266054,
    Latitude = -26.9180036848972,
    ProvinceId = 90
},

new Department
{
    Id = 90063,
    Name = "Lules",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -65.4310245938907,
    Latitude = -26.8622353459017,
    ProvinceId = 90
},

new Department
{
    Id = 90119,
    Name = "Yerba Buena",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -65.3411739273315,
    Latitude = -26.7839244723358,
    ProvinceId = 90
},

new Department
{
    Id = 90105,
    Name = "Tafí Viejo",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -65.4640739296384,
    Latitude = -26.6601491447319,
    ProvinceId = 90
},

new Department
{
    Id = 74063,
    Name = "Libertador General San Martín",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -65.7095887718459,
    Latitude = -32.5784192378867,
    ProvinceId = 74
},

new Department
{
    Id = 74021,
    Name = "Coronel Pringles",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -65.9007902060388,
    Latitude = -33.1068820570862,
    ProvinceId = 74
},

new Department
{
    Id = 74028,
    Name = "Chacabuco",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -65.198209788321,
    Latitude = -32.7270768664399,
    ProvinceId = 74
},

new Department
{
    Id = 6679,
    Name = "Rivadavia",
    Source = "IGN",
    Category = "Partido",
    Longitude = -63.0947616852349,
    Latitude = -35.581056985938,
    ProvinceId = 6
},

new Department
{
    Id = 6602,
    Name = "Patagones",
    Source = "IGN",
    Category = "Partido",
    Longitude = -62.8508023633523,
    Latitude = -40.1963833078675,
    ProvinceId = 6
},

new Department
{
    Id = 74056,
    Name = "Juan Martín de Pueyrredón",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -66.5024402257537,
    Latitude = -33.900714617211,
    ProvinceId = 74
},

new Department
{
    Id = 74035,
    Name = "General Pedernera",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -65.5597745631101,
    Latitude = -33.8922244453095,
    ProvinceId = 74
},

new Department
{
    Id = 90112,
    Name = "Trancas",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -65.4058207897255,
    Latitude = -26.3434123363847,
    ProvinceId = 90
},

new Department
{
    Id = 90098,
    Name = "Tafí del Valle",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -65.8893504834043,
    Latitude = -26.5914686020616,
    ProvinceId = 90
},

new Department
{
    Id = 2063,
    Name = "Comuna 9",
    Source = "IGN",
    Category = "Comuna",
    Longitude = -58.4991751735853,
    Latitude = -34.6517887970418,
    ProvinceId = 2
},

new Department
{
    Id = 74049,
    Name = "Junín",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -65.3948431186635,
    Latitude = -32.2163016656263,
    ProvinceId = 74
},

new Department
{
    Id = 86112,
    Name = "Mitre",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -62.7386757564942,
    Latitude = -29.6150490318213,
    ProvinceId = 86
},

new Department
{
    Id = 86021,
    Name = "Atamisqui",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -63.8815639977726,
    Latitude = -28.6918181695012,
    ProvinceId = 86
},

new Department
{
    Id = 18014,
    Name = "Berón de Astrada",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -57.6113807712108,
    Latitude = -27.4779704395686,
    ProvinceId = 18
},

new Department
{
    Id = 94011,
    Name = "Tolhuin",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -67.5034849447963,
    Latitude = -54.4245608947124,
    ProvinceId = 94
},

new Department
{
    Id = 54028,
    Name = "Capital",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -55.8565833366475,
    Latitude = -27.5505259291655,
    ProvinceId = 54
},

new Department
{
    Id = 54021,
    Name = "Candelaria",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -55.5826900383218,
    Latitude = -27.4608500546705,
    ProvinceId = 54
},

new Department
{
    Id = 86091,
    Name = "Jiménez",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -64.2724736671085,
    Latitude = -26.8996081032586,
    ProvinceId = 86
},

new Department
{
    Id = 6182,
    Name = "Coronel de Marina Leonardo Rosales",
    Source = "IGN",
    Category = "Partido",
    Longitude = -61.8355844196542,
    Latitude = -38.8490773280679,
    ProvinceId = 6
},

new Department
{
    Id = 6070,
    Name = "Baradero",
    Source = "IGN",
    Category = "Partido",
    Longitude = -59.4927871380553,
    Latitude = -33.9319613769628,
    ProvinceId = 6
},

new Department
{
    Id = 6770,
    Name = "San Pedro",
    Source = "IGN",
    Category = "Partido",
    Longitude = -59.7826260109294,
    Latitude = -33.7809860202918,
    ProvinceId = 6
},

new Department
{
    Id = 66161,
    Name = "Santa Victoria",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -64.8955647956079,
    Latitude = -22.3958917322092,
    ProvinceId = 66
},

new Department
{
    Id = 66056,
    Name = "General José de San Martín",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -63.6582864287813,
    Latitude = -22.7144623805907,
    ProvinceId = 66
},

new Department
{
    Id = 66133,
    Name = "Rivadavia",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -62.8285940219747,
    Latitude = -23.5194718277586,
    ProvinceId = 66
},

new Department
{
    Id = 66147,
    Name = "Rosario de Lerma",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -65.8530078405525,
    Latitude = -24.5457519055916,
    ProvinceId = 66
},

new Department
{
    Id = 38035,
    Name = "Ledesma",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -64.8288746330382,
    Latitude = -23.7854859185353,
    ProvinceId = 38
},

new Department
{
    Id = 38028,
    Name = "Humahuaca",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -65.4095227491295,
    Latitude = -23.0820099180032,
    ProvinceId = 38
},

new Department
{
    Id = 38007,
    Name = "Cochinoca",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -65.9347260935414,
    Latitude = -22.9392130779775,
    ProvinceId = 38
},

new Department
{
    Id = 38098,
    Name = "Tumbaya",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -65.6961901966194,
    Latitude = -23.7434749479331,
    ProvinceId = 38
},

new Department
{
    Id = 6277,
    Name = "Florentino Ameghino",
    Source = "IGN",
    Category = "Partido",
    Longitude = -62.4017162645879,
    Latitude = -34.8741058055206,
    ProvinceId = 6
},

new Department
{
    Id = 26028,
    Name = "Florentino Ameghino",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -66.1302641083269,
    Latitude = -44.4231369267293,
    ProvinceId = 26
},

new Department
{
    Id = 90049,
    Name = "La Cocha",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -65.5977877083311,
    Latitude = -27.7940604809292,
    ProvinceId = 90
},

new Department
{
    Id = 90035,
    Name = "Graneros",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -65.2550360276541,
    Latitude = -27.7132775964524,
    ProvinceId = 90
},

new Department
{
    Id = 90042,
    Name = "Juan Bautista Alberdi",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -65.7831912587906,
    Latitude = -27.6060757021473,
    ProvinceId = 90
},

new Department
{
    Id = 90077,
    Name = "Río Chico",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -65.7518266389415,
    Latitude = -27.4501203542874,
    ProvinceId = 90
},

new Department
{
    Id = 90091,
    Name = "Simoca",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -65.2924847788807,
    Latitude = -27.4238370613532,
    ProvinceId = 90
},

new Department
{
    Id = 90021,
    Name = "Chicligasta",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -65.8110637206058,
    Latitude = -27.2696018679715,
    ProvinceId = 90
},

new Department
{
    Id = 90070,
    Name = "Monteros",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -65.6430768814482,
    Latitude = -27.1106201705702,
    ProvinceId = 90
},

new Department
{
    Id = 90056,
    Name = "Leales",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -65.0848647351414,
    Latitude = -27.1918831757327,
    ProvinceId = 90
},

new Department
{
    Id = 82126,
    Name = "San Martín",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -61.8090742014148,
    Latitude = -32.0122706461745,
    ProvinceId = 82
},

new Department
{
    Id = 82063,
    Name = "La Capital",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -60.6694790136058,
    Latitude = -31.4753563668226,
    ProvinceId = 82
},

new Department
{
    Id = 54049,
    Name = "General Manuel Belgrano",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -53.9638550967802,
    Latitude = -25.9784317106931,
    ProvinceId = 54
},

new Department
{
    Id = 54056,
    Name = "Guaraní",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -54.2693651314473,
    Latitude = -27.0262348990631,
    ProvinceId = 54
},

new Department
{
    Id = 54063,
    Name = "Iguazú",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -54.4004185890739,
    Latitude = -25.8747354911285,
    ProvinceId = 54
},

new Department
{
    Id = 54119,
    Name = "25 de Mayo",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -54.6340904863083,
    Latitude = -27.3786143619873,
    ProvinceId = 54
},

new Department
{
    Id = 54091,
    Name = "Oberá",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -55.0712221113606,
    Latitude = -27.4763636010381,
    ProvinceId = 54
},

new Department
{
    Id = 82021,
    Name = "Castellanos",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -61.6572584461682,
    Latitude = -31.2314615495091,
    ProvinceId = 82
},

new Department
{
    Id = 82035,
    Name = "Garay",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -60.1258077355938,
    Latitude = -31.0546413334486,
    ProvinceId = 82
},

new Department
{
    Id = 42119,
    Name = "Quemú Quemú",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -63.6637300134466,
    Latitude = -36.1306405658638,
    ProvinceId = 42
},

new Department
{
    Id = 54098,
    Name = "San Ignacio",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -55.3392901736977,
    Latitude = -27.1765939471765,
    ProvinceId = 54
},

new Department
{
    Id = 42154,
    Name = "Utracán",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -65.082831667763,
    Latitude = -37.3338794806419,
    ProvinceId = 42
},

new Department
{
    Id = 18147,
    Name = "San Martín",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -56.9315835110542,
    Latitude = -28.8289801487463,
    ProvinceId = 18
},

new Department
{
    Id = 18119,
    Name = "Paso de los Libres",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -57.2996338361445,
    Latitude = -29.5936363396967,
    ProvinceId = 18
},

new Department
{
    Id = 18070,
    Name = "Goya",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -59.2559121520651,
    Latitude = -29.4514535088561,
    ProvinceId = 18
},

new Department
{
    Id = 18091,
    Name = "Lavalle",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -58.9337232555635,
    Latitude = -28.9879904880901,
    ProvinceId = 18
},

new Department
{
    Id = 18161,
    Name = "San Roque",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -58.6130359023562,
    Latitude = -28.705807188664,
    ProvinceId = 18
},

new Department
{
    Id = 18056,
    Name = "General Alvear",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -56.5115304340621,
    Latitude = -28.775163187308,
    ProvinceId = 18
},

new Department
{
    Id = 18028,
    Name = "Concepción",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -58.0313928425117,
    Latitude = -28.4083995312262,
    ProvinceId = 18
},

new Department
{
    Id = 18007,
    Name = "Bella Vista",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -58.9304354321186,
    Latitude = -28.4973870089949,
    ProvinceId = 18
},

new Department
{
    Id = 18168,
    Name = "Santo Tomé",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -56.2221766248194,
    Latitude = -28.2311041286613,
    ProvinceId = 18
},

new Department
{
    Id = 18126,
    Name = "Saladas",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -58.6199128880477,
    Latitude = -28.2124686853348,
    ProvinceId = 18
},

new Department
{
    Id = 18063,
    Name = "General Paz",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -57.7876331852429,
    Latitude = -27.7199319611528,
    ProvinceId = 18
},

new Department
{
    Id = 54070,
    Name = "Leandro N. Alem",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -55.3880677316604,
    Latitude = -27.6306652583192,
    ProvinceId = 54
},

new Department
{
    Id = 54105,
    Name = "San Javier",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -55.1674595937339,
    Latitude = -27.7771031453698,
    ProvinceId = 54
},

new Department
{
    Id = 18098,
    Name = "Mburucuyá",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -58.1855639990468,
    Latitude = -28.0163838994325,
    ProvinceId = 18
},

new Department
{
    Id = 54035,
    Name = "Concepción",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -55.4670364912488,
    Latitude = -27.9311673935877,
    ProvinceId = 54
},

new Department
{
    Id = 54007,
    Name = "Apóstoles",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -55.6781134842867,
    Latitude = -27.8887539522051,
    ProvinceId = 54
},

new Department
{
    Id = 22126,
    Name = "1° de Mayo",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -58.9587415590109,
    Latitude = -27.1678037354366,
    ProvinceId = 22
},

new Department
{
    Id = 22140,
    Name = "San Fernando",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -59.1154439908292,
    Latitude = -27.7156982892704,
    ProvinceId = 22
},

new Department
{
    Id = 22147,
    Name = "San Lorenzo",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -60.3637302119912,
    Latitude = -27.3933734765875,
    ProvinceId = 22
},

new Department
{
    Id = 6490,
    Name = "Lomas de Zamora",
    Source = "IGN",
    Category = "Partido",
    Longitude = -58.4240954303406,
    Latitude = -34.7549679553956,
    ProvinceId = 6
},

new Department
{
    Id = 6035,
    Name = "Avellaneda",
    Source = "IGN",
    Category = "Partido",
    Longitude = -58.3411445451106,
    Latitude = -34.6781993084404,
    ProvinceId = 6
},

new Department
{
    Id = 22168,
    Name = "25 de Mayo",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -60.0184594861944,
    Latitude = -26.8170406143405,
    ProvinceId = 22
},

new Department
{
    Id = 22049,
    Name = "General Belgrano",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -61.0713338324887,
    Latitude = -26.8478157545068,
    ProvinceId = 22
},

new Department
{
    Id = 22077,
    Name = "Libertad",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -59.2597877694895,
    Latitude = -27.3493250970289,
    ProvinceId = 22
},

new Department
{
    Id = 22021,
    Name = "Comandante Fernández",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -60.4612869070114,
    Latitude = -26.7853900358381,
    ProvinceId = 22
},

new Department
{
    Id = 2105,
    Name = "Comuna 15",
    Source = "IGN",
    Category = "Comuna",
    Longitude = -58.4627740218465,
    Latitude = -34.5918836701535,
    ProvinceId = 2
},

new Department
{
    Id = 70042,
    Name = "Chimbas",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -68.5239289663008,
    Latitude = -31.4874196948537,
    ProvinceId = 70
},

new Department
{
    Id = 70028,
    Name = "Capital",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -68.5342856277496,
    Latitude = -31.5330748483668,
    ProvinceId = 70
},

new Department
{
    Id = 70084,
    Name = "Rivadavia",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -68.6416232535725,
    Latitude = -31.5542325394282,
    ProvinceId = 70
},

new Department
{
    Id = 70063,
    Name = "9 de Julio",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -68.3891603884533,
    Latitude = -31.6454181217339,
    ProvinceId = 70
},

new Department
{
    Id = 70007,
    Name = "Albardón",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -68.4521792374306,
    Latitude = -31.209735511428,
    ProvinceId = 70
},

new Department
{
    Id = 70014,
    Name = "Angaco",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -68.1320483297946,
    Latitude = -31.1922718652932,
    ProvinceId = 70
},

new Department
{
    Id = 70098,
    Name = "Santa Lucía",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -68.4634100474193,
    Latitude = -31.5327197592087,
    ProvinceId = 70
},

new Department
{
    Id = 70077,
    Name = "Rawson",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -68.4675945970348,
    Latitude = -31.6866317967417,
    ProvinceId = 70
},

new Department
{
    Id = 70126,
    Name = "25 de Mayo",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -67.8268026426216,
    Latitude = -31.9898921289958,
    ProvinceId = 70
},

new Department
{
    Id = 70091,
    Name = "San Martín",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -68.2072669737396,
    Latitude = -31.5285457556281,
    ProvinceId = 70
},

new Department
{
    Id = 70070,
    Name = "Pocito",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -68.5846798192063,
    Latitude = -31.7472539046839,
    ProvinceId = 70
},

new Department
{
    Id = 70133,
    Name = "Zonda",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -68.9548418805416,
    Latitude = -31.6417783563664,
    ProvinceId = 70
},

new Department
{
    Id = 70112,
    Name = "Ullum",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -68.8823909182891,
    Latitude = -31.0852853750901,
    ProvinceId = 70
},

new Department
{
    Id = 70105,
    Name = "Sarmiento",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -68.6870408796588,
    Latitude = -32.076116858425,
    ProvinceId = 70
},

new Department
{
    Id = 70021,
    Name = "Calingasta",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -69.8318658247746,
    Latitude = -31.4509359086826,
    ProvinceId = 70
},

new Department
{
    Id = 70049,
    Name = "Iglesia",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -69.4387201063957,
    Latitude = -29.6011907018103,
    ProvinceId = 70
},

new Department
{
    Id = 70056,
    Name = "Jáchal",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -68.4399965840681,
    Latitude = -30.3546413571108,
    ProvinceId = 70
},

new Department
{
    Id = 70119,
    Name = "Valle Fértil",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -67.5276736787401,
    Latitude = -30.7168856749658,
    ProvinceId = 70
},

new Department
{
    Id = 70035,
    Name = "Caucete",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -67.5454408659079,
    Latitude = -31.5069003261853,
    ProvinceId = 70
},

new Department
{
    Id = 6441,
    Name = "La Plata",
    Source = "IGN",
    Category = "Partido",
    Longitude = -58.0177777886077,
    Latitude = -35.0038470156345,
    ProvinceId = 6
},

new Department
{
    Id = 18105,
    Name = "Mercedes",
    Source = "IGN",
    Category = "Departamento",
    Longitude = -57.8183859330354,
    Latitude = -29.0645067636205,
    ProvinceId = 18
}

                );
        }
    }
}
