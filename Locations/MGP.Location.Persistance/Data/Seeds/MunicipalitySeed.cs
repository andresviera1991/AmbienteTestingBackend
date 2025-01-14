//using MGP.Location.Persistance.Data.Tables;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;
//using Microsoft.EntityFrameworkCore;

//namespace MGP.Location.Persistance.Data.Seeds
//{
//    public class MunicipalitySeed : IEntityTypeConfiguration<Municipality>
//    {
//        public void Configure(EntityTypeBuilder<Municipality> builder)
//        {
//            builder.HasData(
//                new Municipality()
//                {
//                    Id = 300437,
//                    Name = "1º de Mayo",
//                    FullName = "Municipality 1º de Mayo",
//                    Source = "IGN",
//                    Category = "Municipality",
//                    Longitude = -58.4829232898883,
//                    Latitude = -32.2504196859396,
//                },
//new Municipality()
//{
//    Id = 60854,
//    Name = "25 de Mayo",
//    FullName = "Municipality 25 de Mayo",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -60.2302837885052,
//    Latitude = -35.527208971772,
//},
//new Municipality()
//{
//    Id = 700126,
//    Name = "25 de Mayo",
//    FullName = "Municipality 25 de Mayo",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -67.8269513563397,
//    Latitude = -31.9899356982964,
//},
//new Municipality()
//{
//    Id = 540525,
//    Name = "25 de Mayo",
//    FullName = "Municipality 25 de Mayo",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -54.6814951271007,
//    Latitude = -27.3331053108538,
//},
//new Municipality()
//{
//    Id = 265014,
//    Name = "28 de Julio",
//    FullName = "Comisión 28 de Julio",
//    Source = "IGN",
//    Category = "Comisión",
//    Longitude = -65.8391207473089,
//    Latitude = -43.3837023377194,
//},
//new Municipality()
//{
//    Id = 908007,
//    Name = "7 de Abril",
//    FullName = "Comuna 7 de Abril",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -64.5824344744593,
//    Latitude = -26.3206442551004,
//},
//new Municipality()
//{
//    Id = 540161,
//    Name = "9 de Julio",
//    FullName = "Municipality 9 de Julio",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -54.4912136872105,
//    Latitude = -26.434887611534,
//},
//new Municipality()
//{
//    Id = 180399,
//    Name = "9 de Julio",
//    FullName = "Municipality 9 de Julio",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -58.8281078015102,
//    Latitude = -28.8264543361085,
//},
//new Municipality()
//{
//    Id = 60588,
//    Name = "9 de Julio",
//    FullName = "Municipality 9 de Julio",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -60.97542544156,
//    Latitude = -35.4812271475918,
//},
//new Municipality()
//{
//    Id = 700063,
//    Name = "9 de Julio",
//    FullName = "Municipality 9 de Julio",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -68.3891603884533,
//    Latitude = -31.6454181217365,
//},
//new Municipality()
//{
//    Id = 822574,
//    Name = "Aarón Castellanos",
//    FullName = "Comuna Aarón Castellanos",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -62.3303685728059,
//    Latitude = -34.302284392925,
//},
//new Municipality()
//{
//    Id = 386007,
//    Name = "Abdón Castro Tolay",
//    FullName = "Comisión Abdón Castro Tolay",
//    Source = "IGN",
//    Category = "Comisión",
//    Longitude = -65.9919066150133,
//    Latitude = -23.3202785908531,
//},
//new Municipality()
//{
//    Id = 380014,
//    Name = "Abra Pampa",
//    FullName = "Municipality Abra Pampa",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -66.0320925149678,
//    Latitude = -22.8431857775554,
//},
//new Municipality()
//{
//    Id = 386014,
//    Name = "Abralaite",
//    FullName = "Comisión Abralaite",
//    Source = "IGN",
//    Category = "Comisión",
//    Longitude = -65.7924320491578,
//    Latitude = -23.1363958816796,
//},
//new Municipality()
//{
//    Id = 420007,
//    Name = "Abramo",
//    FullName = "Municipality Abramo",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -64.1906632401513,
//    Latitude = -37.9218412713471,
//},
//new Municipality()
//{
//    Id = 823351,
//    Name = "Acebal",
//    FullName = "Comuna Acebal",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -60.8804688942704,
//    Latitude = -33.2433836177279,
//},
//new Municipality()
//{
//    Id = 908378,
//    Name = "Acheral",
//    FullName = "Comuna Acheral",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -65.4496229529651,
//    Latitude = -27.1428055882278,
//},
//new Municipality()
//{
//    Id = 140756,
//    Name = "Achiras",
//    FullName = "Municipality Achiras",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -64.9783311643432,
//    Latitude = -33.1696958774564,
//},
//new Municipality()
//{
//    Id = 100042,
//    Name = "Aconquija",
//    FullName = "Municipality Aconquija",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -66.058483404966,
//    Latitude = -27.5046353282862,
//},
//new Municipality()
//{
//    Id = 140763,
//    Name = "Adelia María",
//    FullName = "Municipality Adelia María",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -64.0187063516426,
//    Latitude = -33.6333900310006,
//},
//new Municipality()
//{
//    Id = 60007,
//    Name = "Adolfo Alsina",
//    FullName = "Municipality Adolfo Alsina",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -63.0560551528092,
//    Latitude = -37.1967620824704,
//},
//new Municipality()
//{
//    Id = 60014,
//    Name = "Adolfo Gonzales Chaves",
//    FullName = "Municipality Adolfo Gonzales Chaves",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -60.2482821323377,
//    Latitude = -37.9646159068502,
//},
//new Municipality()
//{
//    Id = 425007,
//    Name = "Adolfo Van Praet",
//    FullName = "Comisión Adolfo Van Praet",
//    Source = "IGN",
//    Category = "Comisión",
//    Longitude = -64.0161081323521,
//    Latitude = -35.0728733595308,
//},
//new Municipality()
//{
//    Id = 140084,
//    Name = "Agua de Oro",
//    FullName = "Municipality Agua de Oro",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -64.3259937691714,
//    Latitude = -31.0500245015486,
//},
//new Municipality()
//{
//    Id = 908273,
//    Name = "Agua Dulce y La Soledad",
//    FullName = "Comuna Agua Dulce y La Soledad",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -65.0464235955617,
//    Latitude = -27.0939074469691,
//},
//new Municipality()
//{
//    Id = 585014,
//    Name = "Aguada San Roque",
//    FullName = "Comisión Aguada San Roque",
//    Source = "IGN",
//    Category = "Comisión",
//    Longitude = -68.9371469809915,
//    Latitude = -37.9738679915588,
//},
//new Municipality()
//{
//    Id = 823477,
//    Name = "Aguará Grande",
//    FullName = "Comuna Aguará Grande",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -60.8529461195038,
//    Latitude = -29.988028807828,
//},
//new Municipality()
//{
//    Id = 660126,
//    Name = "Aguaray",
//    FullName = "Municipality Aguaray",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -63.5396235961639,
//    Latitude = -22.181891286007,
//},
//new Municipality()
//{
//    Id = 660290,
//    Name = "Aguas Blancas",
//    FullName = "Municipality Aguas Blancas",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -64.3732527032261,
//    Latitude = -22.7623142193627,
//},
//new Municipality()
//{
//    Id = 380049,
//    Name = "Aguas Calientes",
//    FullName = "Municipality Aguas Calientes",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -64.9346850054292,
//    Latitude = -24.5647500977416,
//},
//new Municipality()
//{
//    Id = 900091,
//    Name = "Aguilares",
//    FullName = "Municipality Aguilares",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -65.6284335465751,
//    Latitude = -27.4381337135354,
//},
//new Municipality()
//{
//    Id = 425014,
//    Name = "Agustoni",
//    FullName = "Comisión Agustoni",
//    Source = "IGN",
//    Category = "Comisión",
//    Longitude = -63.4827300108575,
//    Latitude = -35.7927846055121,
//},
//new Municipality()
//{
//    Id = 540511,
//    Name = "Alba Posse",
//    FullName = "Municipality Alba Posse",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -54.7985455371757,
//    Latitude = -27.4811807319274,
//},
//new Municipality()
//{
//    Id = 700007,
//    Name = "Albardón",
//    FullName = "Municipality Albardón",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -68.4521792374595,
//    Latitude = -31.2097355114726,
//},
//new Municipality()
//{
//    Id = 823358,
//    Name = "Albarellos",
//    FullName = "Comuna Albarellos",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -60.6273437225374,
//    Latitude = -33.2386305005586,
//},
//new Municipality()
//{
//    Id = 60021,
//    Name = "Alberti",
//    FullName = "Municipality Alberti",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -60.2819765918318,
//    Latitude = -35.0369685106341,
//},
//new Municipality()
//{
//    Id = 300231,
//    Name = "Alcaraz",
//    FullName = "Municipality Alcaraz",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -59.5894411441375,
//    Latitude = -31.4188335586423,
//},
//new Municipality()
//{
//    Id = 309415,
//    Name = "Alcaraz Norte",
//    FullName = "Junta Alcaraz Norte",
//    Source = "IGN",
//    Category = "Junta",
//    Longitude = -59.6857348871918,
//    Latitude = -31.3350311469125,
//},
//new Municipality()
//{
//    Id = 309420,
//    Name = "Alcaraz Sur",
//    FullName = "Junta Alcaraz Sur",
//    Source = "IGN",
//    Category = "Junta",
//    Longitude = -59.8396777081631,
//    Latitude = -31.3655007389196,
//},
//new Municipality()
//{
//    Id = 140770,
//    Name = "Alcira",
//    FullName = "Municipality Alcira",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -64.3355358980884,
//    Latitude = -32.7517122016285,
//},
//new Municipality()
//{
//    Id = 822413,
//    Name = "Alcorta",
//    FullName = "Comuna Alcorta",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -61.1369460435635,
//    Latitude = -33.5768880596232,
//},
//new Municipality()
//{
//    Id = 823981,
//    Name = "Aldao",
//    FullName = "Comuna Aldao",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -60.8602550310954,
//    Latitude = -32.7105750431762,
//},
//new Municipality()
//{
//    Id = 302383,
//    Name = "Aldea Asunción",
//    FullName = "Junta Aldea Asunción",
//    Source = "IGN",
//    Category = "Junta",
//    Longitude = -59.2155107428924,
//    Latitude = -32.7941039184642,
//},
//new Municipality()
//{
//    Id = 268091,
//    Name = "Aldea Beleiro",
//    FullName = "Comuna Aldea Beleiro",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -71.5479426044116,
//    Latitude = -45.55476045364,
//},
//new Municipality()
//{
//    Id = 309075,
//    Name = "Aldea Brasilera",
//    FullName = "Municipality Aldea Brasilera",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -60.6103657979486,
//    Latitude = -31.9034230937927,
//},
//new Municipality()
//{
//    Id = 309575,
//    Name = "Aldea Eigenfeld",
//    FullName = "Junta Aldea Eigenfeld",
//    Source = "IGN",
//    Category = "Junta",
//    Longitude = -60.2366789258288,
//    Latitude = -31.8951524920186,
//},
//new Municipality()
//{
//    Id = 268049,
//    Name = "Aldea Epulef",
//    FullName = "Comuna Aldea Epulef",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -69.6832150363228,
//    Latitude = -43.3048186911105,
//},
//new Municipality()
//{
//    Id = 309080,
//    Name = "Aldea Grapschental",
//    FullName = "Junta Aldea Grapschental",
//    Source = "IGN",
//    Category = "Junta",
//    Longitude = -60.5042455086022,
//    Latitude = -31.9666878340643,
//},
//new Municipality()
//{
//    Id = 302112,
//    Name = "Aldea Protestante",
//    FullName = "Junta Aldea Protestante",
//    Source = "IGN",
//    Category = "Junta",
//    Longitude = -60.5715354529829,
//    Latitude = -32.0337403567141,
//},
//new Municipality()
//{
//    Id = 309090,
//    Name = "Aldea Salto",
//    FullName = "Junta Aldea Salto",
//    Source = "IGN",
//    Category = "Junta",
//    Longitude = -60.5475784351843,
//    Latitude = -31.9245441422128,
//},
//new Municipality()
//{
//    Id = 300182,
//    Name = "Aldea San Antonio",
//    FullName = "Municipality Aldea San Antonio",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -58.7084107978686,
//    Latitude = -32.6235071028841,
//},
//new Municipality()
//{
//    Id = 309585,
//    Name = "Aldea San Antonio",
//    FullName = "Junta Aldea San Antonio",
//    Source = "IGN",
//    Category = "Junta",
//    Longitude = -60.1651793366167,
//    Latitude = -31.8734051597514,
//},
//new Municipality()
//{
//    Id = 302453,
//    Name = "Aldea San Juan",
//    FullName = "Comuna Aldea San Juan",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -58.7672034293295,
//    Latitude = -32.7063699044511,
//},
//new Municipality()
//{
//    Id = 309515,
//    Name = "Aldea San Miguel",
//    FullName = "Junta Aldea San Miguel",
//    Source = "IGN",
//    Category = "Junta",
//    Longitude = -60.172887809658,
//    Latitude = -32.080404217041,
//},
//new Municipality()
//{
//    Id = 309590,
//    Name = "Aldea San Rafael",
//    FullName = "Junta Aldea San Rafael",
//    Source = "IGN",
//    Category = "Junta",
//    Longitude = -60.2610780978496,
//    Latitude = -31.9675390353288,
//},
//new Municipality()
//{
//    Id = 302836,
//    Name = "Aldea Santa María",
//    FullName = "Junta Aldea Santa María",
//    Source = "IGN",
//    Category = "Junta",
//    Longitude = -60.0032728296625,
//    Latitude = -31.6191161825159,
//},
//new Municipality()
//{
//    Id = 143225,
//    Name = "Aldea Santa María",
//    FullName = "Comuna Aldea Santa María",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -62.9142238528503,
//    Latitude = -33.6993242969668,
//},
//new Municipality()
//{
//    Id = 302843,
//    Name = "Aldea Santa Rosa",
//    FullName = "Junta Aldea Santa Rosa",
//    Source = "IGN",
//    Category = "Junta",
//    Longitude = -60.2116679908633,
//    Latitude = -32.0091892100126,
//},
//new Municipality()
//{
//    Id = 302126,
//    Name = "Aldea Spatzenkutter",
//    FullName = "Junta Aldea Spatzenkutter",
//    Source = "IGN",
//    Category = "Junta",
//    Longitude = -60.5782285873818,
//    Latitude = -31.947417767172,
//},
//new Municipality()
//{
//    Id = 300077,
//    Name = "Aldea Valle María",
//    FullName = "Municipality Aldea Valle María",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -60.5954555686355,
//    Latitude = -31.9895868819086,
//},
//new Municipality()
//{
//    Id = 900021,
//    Name = "Alderetes",
//    FullName = "Municipality Alderetes",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -65.1344053220564,
//    Latitude = -26.7919955238759,
//},
//new Municipality()
//{
//    Id = 823687,
//    Name = "Alejandra",
//    FullName = "Comuna Alejandra",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -59.8247012546168,
//    Latitude = -29.9434037285657,
//},
//new Municipality()
//{
//    Id = 140385,
//    Name = "Alejandro Roca",
//    FullName = "Municipality Alejandro Roca",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -63.7203299331366,
//    Latitude = -33.3442762498231,
//},
//new Municipality()
//{
//    Id = 140476,
//    Name = "Alejo Ledesma",
//    FullName = "Municipality Alejo Ledesma",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -62.623853511442,
//    Latitude = -33.5987357093936,
//},
//new Municipality()
//{
//    Id = 420011,
//    Name = "Algarrobo del Águila",
//    FullName = "Municipality Algarrobo del Águila",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -67.4088444346938,
//    Latitude = -36.3998698222836,
//},
//new Municipality()
//{
//    Id = 141162,
//    Name = "Alicia",
//    FullName = "Municipality Alicia",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -62.4655974862229,
//    Latitude = -31.9393591274178,
//},
//new Municipality()
//{
//    Id = 620091,
//    Name = "Allen",
//    FullName = "Municipality Allen",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -67.7958871201423,
//    Latitude = -39.0076614484542,
//},
//new Municipality()
//{
//    Id = 540238,
//    Name = "Almafuerte",
//    FullName = "Municipality Almafuerte",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -55.3874717127581,
//    Latitude = -27.5255595160407,
//},
//new Municipality()
//{
//    Id = 141421,
//    Name = "Almafuerte",
//    FullName = "Municipality Almafuerte",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -64.241398104166,
//    Latitude = -32.2022805520145,
//},
//new Municipality()
//{
//    Id = 60028,
//    Name = "Almirante Brown",
//    FullName = "Municipality Almirante Brown",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -58.3673729329589,
//    Latitude = -34.8356191132619,
//},
//new Municipality()
//{
//    Id = 140777,
//    Name = "Alpa Corral",
//    FullName = "Municipality Alpa Corral",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -64.7275918344128,
//    Latitude = -32.682752317234,
//},
//new Municipality()
//{
//    Id = 420014,
//    Name = "Alpachiri",
//    FullName = "Municipality Alpachiri",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -63.8366890133439,
//    Latitude = -37.3878939429584,
//},
//new Municipality()
//{
//    Id = 908161,
//    Name = "Alpachiri y El Molino",
//    FullName = "Comuna Alpachiri y El Molino",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -65.9101103737518,
//    Latitude = -27.2636150721804,
//},
//new Municipality()
//{
//    Id = 141372,
//    Name = "Alta Gracia",
//    FullName = "Municipality Alta Gracia",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -64.4406982021906,
//    Latitude = -31.6508353289639,
//},
//new Municipality()
//{
//    Id = 420021,
//    Name = "Alta Italia",
//    FullName = "Municipality Alta Italia",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -64.0994549006877,
//    Latitude = -35.3498671084483,
//},
//new Municipality()
//{
//    Id = 309790,
//    Name = "Altamirano Sur",
//    FullName = "Junta Altamirano Sur",
//    Source = "IGN",
//    Category = "Junta",
//    Longitude = -59.1504151734853,
//    Latitude = -32.1350500877167,
//},
//new Municipality()
//{
//    Id = 141589,
//    Name = "Alto Alegre",
//    FullName = "Municipality Alto Alegre",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -62.8819564273261,
//    Latitude = -32.3422197988317,
//},
//new Municipality()
//{
//    Id = 142133,
//    Name = "Alto de los Quebrachos",
//    FullName = "Comuna Alto de los Quebrachos",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -65.1225465080377,
//    Latitude = -30.5351780991222,
//},
//new Municipality()
//{
//    Id = 746231,
//    Name = "Alto Pelado",
//    FullName = "Comisión Alto Pelado",
//    Source = "IGN",
//    Category = "Comisión",
//    Longitude = -66.1255415411312,
//    Latitude = -33.8241276567726,
//},
//new Municipality()
//{
//    Id = 746238,
//    Name = "Alto Pencoso",
//    FullName = "Comisión Alto Pencoso",
//    Source = "IGN",
//    Category = "Comisión",
//    Longitude = -66.9268856281153,
//    Latitude = -33.4319845531256,
//},
//new Municipality()
//{
//    Id = 260126,
//    Name = "Alto Río Senguer",
//    FullName = "Municipality Alto Río Senguer",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -71.2060348461438,
//    Latitude = -44.9435324779047,
//},
//new Municipality()
//{
//    Id = 908168,
//    Name = "Alto Verde y Los Guchea",
//    FullName = "Comuna Alto Verde y Los Guchea",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -65.6125080754228,
//    Latitude = -27.3887695040468,
//},
//new Municipality()
//{
//    Id = 141169,
//    Name = "Altos de Chipión",
//    FullName = "Municipality Altos de Chipión",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -62.3373302112667,
//    Latitude = -30.9547219317203,
//},
//new Municipality()
//{
//    Id = 580007,
//    Name = "Aluminé",
//    FullName = "Municipality Aluminé",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -70.9120954468479,
//    Latitude = -39.2342734029443,
//},
//new Municipality()
//{
//    Id = 823365,
//    Name = "Álvarez",
//    FullName = "Comuna Álvarez",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -60.8078469904161,
//    Latitude = -33.1403539047982,
//},
//new Municipality()
//{
//    Id = 823372,
//    Name = "Alvear",
//    FullName = "Comuna Alvear",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -60.6419157602812,
//    Latitude = -33.0710404515405,
//},
//new Municipality()
//{
//    Id = 180098,
//    Name = "Alvear",
//    FullName = "Municipality Alvear",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -56.5272352302079,
//    Latitude = -28.7678593524958,
//},
//new Municipality()
//{
//    Id = 908567,
//    Name = "Amaicha del Valle",
//    FullName = "Comuna Amaicha del Valle",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -65.8559948379265,
//    Latitude = -26.510222769761,
//},
//new Municipality()
//{
//    Id = 908385,
//    Name = "Amberes",
//    FullName = "Comuna Amberes",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -65.4935457141554,
//    Latitude = -27.2756807767921,
//},
//new Municipality()
//{
//    Id = 142007,
//    Name = "Amboy",
//    FullName = "Comuna Amboy",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -64.5750894423152,
//    Latitude = -32.1764282380889,
//},
//new Municipality()
//{
//    Id = 823484,
//    Name = "Ambrosetti",
//    FullName = "Comuna Ambrosetti",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -61.5468550660109,
//    Latitude = -29.9789705589281,
//},
//new Municipality()
//{
//    Id = 142833,
//    Name = "Ambul",
//    FullName = "Comuna Ambul",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -65.0780298240082,
//    Latitude = -31.5186767924263,
//},
//new Municipality()
//{
//    Id = 822581,
//    Name = "Amenábar",
//    FullName = "Comuna Amenábar",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -62.4106609815495,
//    Latitude = -34.0808111397627,
//},
//new Municipality()
//{
//    Id = 143232,
//    Name = "Ana Zumarán",
//    FullName = "Comuna Ana Zumarán",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -63.0580417527231,
//    Latitude = -32.3920332145426,
//},
//new Municipality()
//{
//    Id = 908595,
//    Name = "Anca Juli",
//    FullName = "Comuna Anca Juli",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -65.6320620878699,
//    Latitude = -26.6237548395938,
//},
//new Municipality()
//{
//    Id = 100035,
//    Name = "Ancasti",
//    FullName = "Municipality Ancasti",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -65.504299177941,
//    Latitude = -28.9274130674418,
//},
//new Municipality()
//{
//    Id = 746147,
//    Name = "Anchorena",
//    FullName = "Comisión Anchorena",
//    Source = "IGN",
//    Category = "Comisión",
//    Longitude = -65.430221064837,
//    Latitude = -35.6729611617831,
//},
//new Municipality()
//{
//    Id = 580140,
//    Name = "Andacollo",
//    FullName = "Municipality Andacollo",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -70.6130162430231,
//    Latitude = -37.2627225951776,
//},
//new Municipality()
//{
//    Id = 100049,
//    Name = "Andalgalá",
//    FullName = "Municipality Andalgalá",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -66.4043741883495,
//    Latitude = -27.5574896209088,
//},
//new Municipality()
//{
//    Id = 700014,
//    Name = "Angaco",
//    FullName = "Municipality Angaco",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -68.1320483297946,
//    Latitude = -31.1922718652932,
//},
//new Municipality()
//{
//    Id = 660378,
//    Name = "Angastaco",
//    FullName = "Municipality Angastaco",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -66.3284084776408,
//    Latitude = -25.9195059498447,
//},
//new Municipality()
//{
//    Id = 460056,
//    Name = "Ángel Vicente Peñaloza",
//    FullName = "Municipality Ángel Vicente Peñaloza",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -66.6630521188297,
//    Latitude = -30.3128975387926,
//},
//new Municipality()
//{
//    Id = 822112,
//    Name = "Angélica",
//    FullName = "Comuna Angélica",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -61.5042325557288,
//    Latitude = -31.5216603668312,
//},
//new Municipality()
//{
//    Id = 823862,
//    Name = "Angeloni",
//    FullName = "Comuna Angeloni",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -60.7195972963312,
//    Latitude = -30.8601855786429,
//},
//new Municipality()
//{
//    Id = 420028,
//    Name = "Anguil",
//    FullName = "Municipality Anguil",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -64.0452421266793,
//    Latitude = -36.5543101526284,
//},
//new Municipality()
//{
//    Id = 660385,
//    Name = "Animaná",
//    FullName = "Municipality Animaná",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -66.0199971092978,
//    Latitude = -25.9751173403341,
//},
//new Municipality()
//{
//    Id = 141375,
//    Name = "Anisacate",
//    FullName = "Municipality Anisacate",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -64.4044575589392,
//    Latitude = -31.7138413750519,
//},
//new Municipality()
//{
//    Id = 303196,
//    Name = "Antelo",
//    FullName = "Junta Antelo",
//    Source = "IGN",
//    Category = "Junta",
//    Longitude = -60.0366520600662,
//    Latitude = -32.532296648571,
//},
//new Municipality()
//{
//    Id = 100056,
//    Name = "Antofagasta de la Sierra",
//    FullName = "Municipality Antofagasta de la Sierra",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -67.6778759619339,
//    Latitude = -25.9467617197245,
//},
//new Municipality()
//{
//    Id = 309605,
//    Name = "Antonio Tomás",
//    FullName = "Junta Antonio Tomás",
//    Source = "IGN",
//    Category = "Junta",
//    Longitude = -59.9581124863204,
//    Latitude = -31.3910722014451,
//},
//new Municipality()
//{
//    Id = 580014,
//    Name = "Añelo",
//    FullName = "Municipality Añelo",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -68.8054456067665,
//    Latitude = -38.3599912075969,
//},
//new Municipality()
//{
//    Id = 660007,
//    Name = "Apolinario Saravia",
//    FullName = "Municipality Apolinario Saravia",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -64.1454276604192,
//    Latitude = -24.5028815648274,
//},
//new Municipality()
//{
//    Id = 540007,
//    Name = "Apóstoles",
//    FullName = "Municipality Apóstoles",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -55.7215766559763,
//    Latitude = -27.902494483774,
//},
//new Municipality()
//{
//    Id = 420035,
//    Name = "Arata",
//    FullName = "Municipality Arata",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -64.371960668905,
//    Latitude = -35.6396510640821,
//},
//new Municipality()
//{
//    Id = 460007,
//    Name = "Arauco",
//    FullName = "Municipality Arauco",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -66.7191026196252,
//    Latitude = -28.533043656156,
//},
//new Municipality()
//{
//    Id = 908175,
//    Name = "Arcadia",
//    FullName = "Comuna Arcadia",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -65.7395630543639,
//    Latitude = -27.2268711863939,
//},
//new Municipality()
//{
//    Id = 822028,
//    Name = "Arequito",
//    FullName = "Comuna Arequito",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -61.5075643530667,
//    Latitude = -33.1514565982953,
//},
//new Municipality()
//{
//    Id = 140483,
//    Name = "Arias",
//    FullName = "Municipality Arias",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -62.4028701481866,
//    Latitude = -33.6394688790659,
//},
//new Municipality()
//{
//    Id = 540035,
//    Name = "Aristóbulo del Valle",
//    FullName = "Municipality Aristóbulo del Valle",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -54.826909982175,
//    Latitude = -27.1247445459801,
//},
//new Municipality()
//{
//    Id = 746154,
//    Name = "Arizona",
//    FullName = "Comisión Arizona",
//    Source = "IGN",
//    Category = "Comisión",
//    Longitude = -65.3157176252592,
//    Latitude = -35.7270528785446,
//},
//new Municipality()
//{
//    Id = 823379,
//    Name = "Arminda",
//    FullName = "Comuna Arminda",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -60.9618757506766,
//    Latitude = -33.2495867418903,
//},
//new Municipality()
//{
//    Id = 820007,
//    Name = "Armstrong",
//    FullName = "Municipality Armstrong",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -61.6467090866422,
//    Latitude = -32.8821841928136,
//},
//new Municipality()
//{
//    Id = 823722,
//    Name = "Arocena",
//    FullName = "Comuna Arocena",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -60.8840247196916,
//    Latitude = -32.0860982082976,
//},
//new Municipality()
//{
//    Id = 386091,
//    Name = "Arrayanal",
//    FullName = "Comisión Arrayanal",
//    Source = "IGN",
//    Category = "Comisión",
//    Longitude = -64.7786455342862,
//    Latitude = -24.1314231570408,
//},
//new Municipality()
//{
//    Id = 60077,
//    Name = "Arrecifes",
//    FullName = "Municipality Arrecifes",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -60.0626641477636,
//    Latitude = -34.0118119181559,
//},
//new Municipality()
//{
//    Id = 141176,
//    Name = "Arroyito",
//    FullName = "Municipality Arroyito",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -63.0461064879716,
//    Latitude = -31.4197877113034,
//},
//new Municipality()
//{
//    Id = 822952,
//    Name = "Arroyo Aguiar",
//    FullName = "Comuna Arroyo Aguiar",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -60.6125961253542,
//    Latitude = -31.4107990800771,
//},
//new Municipality()
//{
//    Id = 140266,
//    Name = "Arroyo Algodón",
//    FullName = "Municipality Arroyo Algodón",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -63.1629657659445,
//    Latitude = -32.201489853995,
//},
//new Municipality()
//{
//    Id = 302007,
//    Name = "Arroyo Barú",
//    FullName = "Junta Arroyo Barú",
//    Source = "IGN",
//    Category = "Junta",
//    Longitude = -58.4552417530432,
//    Latitude = -31.8417263031094,
//},
//new Municipality()
//{
//    Id = 309610,
//    Name = "Arroyo Burgos",
//    FullName = "Junta Arroyo Burgos",
//    Source = "IGN",
//    Category = "Junta",
//    Longitude = -59.6582289640376,
//    Latitude = -31.5487257877298,
//},
//new Municipality()
//{
//    Id = 140273,
//    Name = "Arroyo Cabral",
//    FullName = "Municipality Arroyo Cabral",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -63.4014050637081,
//    Latitude = -32.4891001131457,
//},
//new Municipality()
//{
//    Id = 822763,
//    Name = "Arroyo Ceibal",
//    FullName = "Comuna Arroyo Ceibal",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -59.3815838624214,
//    Latitude = -28.7149881684662,
//},
//new Municipality()
//{
//    Id = 309795,
//    Name = "Arroyo Cle",
//    FullName = "Junta Arroyo Cle",
//    Source = "IGN",
//    Category = "Junta",
//    Longitude = -59.3797757476779,
//    Latitude = -32.6105294667617,
//},
//new Municipality()
//{
//    Id = 309615,
//    Name = "Arroyo Corralito",
//    FullName = "Junta Arroyo Corralito",
//    Source = "IGN",
//    Category = "Junta",
//    Longitude = -59.9815346589258,
//    Latitude = -31.4861076033803,
//},
//new Municipality()
//{
//    Id = 142840,
//    Name = "Arroyo de los Patos",
//    FullName = "Comuna Arroyo de los Patos",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -65.0013233421398,
//    Latitude = -31.7642195618748,
//},
//new Municipality()
//{
//    Id = 540245,
//    Name = "Arroyo del Medio",
//    FullName = "Municipality Arroyo del Medio",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -55.3978729228723,
//    Latitude = -27.7292589472833,
//},
//new Municipality()
//{
//    Id = 309190,
//    Name = "Arroyo del Medio",
//    FullName = "Junta Arroyo del Medio",
//    Source = "IGN",
//    Category = "Junta",
//    Longitude = -59.1073238495906,
//    Latitude = -31.3223245362025,
//},
//new Municipality()
//{
//    Id = 309832,
//    Name = "Arroyo Gená",
//    FullName = "Junta Arroyo Gená",
//    Source = "IGN",
//    Category = "Junta",
//    Longitude = -58.6858101349749,
//    Latitude = -32.1938530790445,
//},
//new Municipality()
//{
//    Id = 309192,
//    Name = "Arroyo Las Tunas",
//    FullName = "Junta Arroyo Las Tunas",
//    Source = "IGN",
//    Category = "Junta",
//    Longitude = -58.8485094242809,
//    Latitude = -30.7614131321231,
//},
//new Municipality()
//{
//    Id = 822959,
//    Name = "Arroyo Leyes",
//    FullName = "Comuna Arroyo Leyes",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -60.4683779917462,
//    Latitude = -31.5426514768932,
//},
//new Municipality()
//{
//    Id = 309620,
//    Name = "Arroyo Maturrango",
//    FullName = "Junta Arroyo Maturrango",
//    Source = "IGN",
//    Category = "Junta",
//    Longitude = -59.9534554172371,
//    Latitude = -31.7000123463817,
//},
//new Municipality()
//{
//    Id = 309625,
//    Name = "Arroyo Palo Seco",
//    FullName = "Junta Arroyo Palo Seco",
//    Source = "IGN",
//    Category = "Junta",
//    Longitude = -59.7681839833203,
//    Latitude = -31.6201311977767,
//},
//new Municipality()
//{
//    Id = 820182,
//    Name = "Arroyo Seco",
//    FullName = "Municipality Arroyo Seco",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -60.5458497884735,
//    Latitude = -33.1690763212751,
//},
//new Municipality()
//{
//    Id = 823491,
//    Name = "Arrufo",
//    FullName = "Comuna Arrufo",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -61.6249034870369,
//    Latitude = -30.235998408784,
//},
//new Municipality()
//{
//    Id = 822035,
//    Name = "Arteaga",
//    FullName = "Comuna Arteaga",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -61.8371590973113,
//    Latitude = -33.1371389250757,
//},
//new Municipality()
//{
//    Id = 142308,
//    Name = "Assunta",
//    FullName = "Comuna Assunta",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -63.2252758695141,
//    Latitude = -33.6337692253498,
//},
//new Municipality()
//{
//    Id = 908490,
//    Name = "Atahona",
//    FullName = "Comuna Atahona",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -65.2924614558001,
//    Latitude = -27.3981645478523,
//},
//new Municipality()
//{
//    Id = 142609,
//    Name = "Atahona",
//    FullName = "Comuna Atahona",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -63.7057819594878,
//    Latitude = -30.9040365023302,
//},
//new Municipality()
//{
//    Id = 822119,
//    Name = "Ataliva",
//    FullName = "Comuna Ataliva",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -61.4318015145206,
//    Latitude = -30.9962504496126,
//},
//new Municipality()
//{
//    Id = 420042,
//    Name = "Ataliva Roca",
//    FullName = "Municipality Ataliva Roca",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -64.4149902481864,
//    Latitude = -36.9529434508078,
//},
//new Municipality()
//{
//    Id = 822126,
//    Name = "Aurelia",
//    FullName = "Comuna Aurelia",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -61.4134539754319,
//    Latitude = -31.392107492263,
//},
//new Municipality()
//{
//    Id = 140280,
//    Name = "Ausonia",
//    FullName = "Municipality Ausonia",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -63.2473324157256,
//    Latitude = -32.5890346393292,
//},
//new Municipality()
//{
//    Id = 820091,
//    Name = "Avellaneda",
//    FullName = "Municipality Avellaneda",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -59.5355066404356,
//    Latitude = -29.0659341304493,
//},
//new Municipality()
//{
//    Id = 142259,
//    Name = "Avellaneda",
//    FullName = "Comuna Avellaneda",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -64.2284115083041,
//    Latitude = -30.5973098046684,
//},
//new Municipality()
//{
//    Id = 60035,
//    Name = "Avellaneda",
//    FullName = "Municipality Avellaneda",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -58.3411669443016,
//    Latitude = -34.678165231634,
//},
//new Municipality()
//{
//    Id = 220210,
//    Name = "Avia Terai",
//    FullName = "Municipality Avia Terai",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -60.7260215972599,
//    Latitude = -26.5809759258693,
//},
//new Municipality()
//{
//    Id = 60042,
//    Name = "Ayacucho",
//    FullName = "Municipality Ayacucho",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -58.4425565239446,
//    Latitude = -37.0354309121036,
//},
//new Municipality()
//{
//    Id = 540014,
//    Name = "Azara",
//    FullName = "Municipality Azara",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -55.6663155246574,
//    Latitude = -28.0543064927395,
//},
//new Municipality()
//{
//    Id = 60049,
//    Name = "Azul",
//    FullName = "Municipality Azul",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -59.6964783376236,
//    Latitude = -36.7859352165956,
//},
//new Municipality()
//{
//    Id = 746161,
//    Name = "Bagual",
//    FullName = "Comisión Bagual",
//    Source = "IGN",
//    Category = "Comisión",
//    Longitude = -65.5694561123146,
//    Latitude = -35.1430062488726,
//},
//new Municipality()
//{
//    Id = 60056,
//    Name = "Bahía Blanca",
//    FullName = "Municipality Bahía Blanca",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -62.1694174494126,
//    Latitude = -38.5841892125766,
//},
//new Municipality()
//{
//    Id = 580224,
//    Name = "Bajada del Agrio",
//    FullName = "Municipality Bajada del Agrio",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -70.0310159232412,
//    Latitude = -38.4056776856649,
//},
//new Municipality()
//{
//    Id = 60063,
//    Name = "Balcarce",
//    FullName = "Municipality Balcarce",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -58.2717475616573,
//    Latitude = -37.7146198082256,
//},
//new Municipality()
//{
//    Id = 746245,
//    Name = "Balde",
//    FullName = "Comisión Balde",
//    Source = "IGN",
//    Category = "Comisión",
//    Longitude = -66.6363665747936,
//    Latitude = -33.4521935892941,
//},
//new Municipality()
//{
//    Id = 141596,
//    Name = "Ballesteros",
//    FullName = "Municipality Ballesteros",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -62.9807310033667,
//    Latitude = -32.546237695526,
//},
//new Municipality()
//{
//    Id = 141603,
//    Name = "Ballesteros Sud",
//    FullName = "Municipality Ballesteros Sud",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -63.0250790508917,
//    Latitude = -32.5887950634732,
//},
//new Municipality()
//{
//    Id = 141183,
//    Name = "Balnearia",
//    FullName = "Municipality Balnearia",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -62.6695377581647,
//    Latitude = -31.0090169258664,
//},
//new Municipality()
//{
//    Id = 900028,
//    Name = "Banda del Río Salí",
//    FullName = "Municipality Banda del Río Salí",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -65.1563685202547,
//    Latitude = -26.8676962333268,
//},
//new Municipality()
//{
//    Id = 309193,
//    Name = "Banderas",
//    FullName = "Junta Banderas",
//    Source = "IGN",
//    Category = "Junta",
//    Longitude = -59.201001776865,
//    Latitude = -30.8673873743336,
//},
//new Municipality()
//{
//    Id = 142140,
//    Name = "Bañado de Soto",
//    FullName = "Comuna Bañado de Soto",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -65.0550301741107,
//    Latitude = -30.8036031227312,
//},
//new Municipality()
//{
//    Id = 60070,
//    Name = "Baradero",
//    FullName = "Municipality Baradero",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -59.4927917961671,
//    Latitude = -33.9319619286862,
//},
//new Municipality()
//{
//    Id = 580196,
//    Name = "Barrancas",
//    FullName = "Municipality Barrancas",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -69.9371295739397,
//    Latitude = -36.8599027330076,
//},
//new Municipality()
//{
//    Id = 823729,
//    Name = "Barrancas",
//    FullName = "Comuna Barrancas",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -60.8994527917724,
//    Latitude = -32.2528057552201,
//},
//new Municipality()
//{
//    Id = 220385,
//    Name = "Barranqueras",
//    FullName = "Municipality Barranqueras",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -58.9196517935696,
//    Latitude = -27.4819093756103,
//},
//new Municipality()
//{
//    Id = 386245,
//    Name = "Barrios",
//    FullName = "Comisión Barrios",
//    Source = "IGN",
//    Category = "Comisión",
//    Longitude = -65.5198355194042,
//    Latitude = -22.2713016774874,
//},
//new Municipality()
//{
//    Id = 220392,
//    Name = "Basail",
//    FullName = "Municipality Basail",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -59.1793155509251,
//    Latitude = -27.8747207049793,
//},
//new Municipality()
//{
//    Id = 300413,
//    Name = "Basavilbaso",
//    FullName = "Municipality Basavilbaso",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -58.8791110780108,
//    Latitude = -32.3612550588587,
//},
//new Municipality()
//{
//    Id = 746168,
//    Name = "Batavia",
//    FullName = "Comisión Batavia",
//    Source = "IGN",
//    Category = "Comisión",
//    Longitude = -65.6871985106842,
//    Latitude = -34.778482348982,
//},
//new Municipality()
//{
//    Id = 822133,
//    Name = "Bauer y Sigel",
//    FullName = "Comuna Bauer y Sigel",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -61.9504319587795,
//    Latitude = -31.2647185237711,
//},
//new Municipality()
//{
//    Id = 746252,
//    Name = "Beazley",
//    FullName = "Comisión Beazley",
//    Source = "IGN",
//    Category = "Comisión",
//    Longitude = -66.6446207562446,
//    Latitude = -33.757272199133,
//},
//new Municipality()
//{
//    Id = 100063,
//    Name = "Belén",
//    FullName = "Municipality Belén",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -66.8473267086764,
//    Latitude = -27.7129686606176,
//},
//new Municipality()
//{
//    Id = 141610,
//    Name = "Bell Ville",
//    FullName = "Municipality Bell Ville",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -62.6950392494892,
//    Latitude = -32.6187289822799,
//},
//new Municipality()
//{
//    Id = 822140,
//    Name = "Bella Italia",
//    FullName = "Comuna Bella Italia",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -61.3812054149924,
//    Latitude = -31.2622960932673,
//},
//new Municipality()
//{
//    Id = 900070,
//    Name = "Bella Vista",
//    FullName = "Municipality Bella Vista",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -65.3070652400644,
//    Latitude = -27.0635338340967,
//},
//new Municipality()
//{
//    Id = 180007,
//    Name = "Bella Vista",
//    FullName = "Municipality Bella Vista",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -58.9336140843193,
//    Latitude = -28.6031832947484,
//},
//new Municipality()
//{
//    Id = 140392,
//    Name = "Bengolea",
//    FullName = "Municipality Bengolea",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -63.6714870729592,
//    Latitude = -33.0277675204366,
//},
//new Municipality()
//{
//    Id = 60084,
//    Name = "Benito Juárez",
//    FullName = "Municipality Benito Juárez",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -59.8883978406364,
//    Latitude = -37.5861107057646,
//},
//new Municipality()
//{
//    Id = 908063,
//    Name = "Benjamín Aráoz y El Tajamar",
//    FullName = "Comuna Benjamín Aráoz y El Tajamar",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -64.8166974682851,
//    Latitude = -26.5650275880602,
//},
//new Municipality()
//{
//    Id = 141617,
//    Name = "Benjamín Gould",
//    FullName = "Municipality Benjamín Gould",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -62.7275448930231,
//    Latitude = -33.5839636588853,
//},
//new Municipality()
//{
//    Id = 822042,
//    Name = "Berabevú",
//    FullName = "Comuna Berabevú",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -61.8668567595638,
//    Latitude = -33.2950393682508,
//},
//new Municipality()
//{
//    Id = 60091,
//    Name = "Berazategui",
//    FullName = "Municipality Berazategui",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -58.1554615086763,
//    Latitude = -34.8182447703804,
//},
//new Municipality()
//{
//    Id = 60098,
//    Name = "Berisso",
//    FullName = "Municipality Berisso",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -57.8283797724826,
//    Latitude = -34.9093551143988,
//},
//new Municipality()
//{
//    Id = 822770,
//    Name = "Berna",
//    FullName = "Comuna Berna",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -59.9081439943422,
//    Latitude = -29.2271092112468,
//},
//new Municipality()
//{
//    Id = 540175,
//    Name = "Bernardo de Irigoyen",
//    FullName = "Municipality Bernardo de Irigoyen",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -53.9469700865317,
//    Latitude = -26.1815939515087,
//},
//new Municipality()
//{
//    Id = 823736,
//    Name = "Bernardo de Irigoyen",
//    FullName = "Comuna Bernardo de Irigoyen",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -61.2655749941511,
//    Latitude = -32.1672138904682,
//},
//new Municipality()
//{
//    Id = 420049,
//    Name = "Bernardo Larroudé",
//    FullName = "Municipality Bernardo Larroudé",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -63.4945357660619,
//    Latitude = -35.070769536645,
//},
//new Municipality()
//{
//    Id = 420056,
//    Name = "Bernasconi",
//    FullName = "Municipality Bernasconi",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -64.1075193406339,
//    Latitude = -38.1805732650446,
//},
//new Municipality()
//{
//    Id = 140784,
//    Name = "Berrotarán",
//    FullName = "Municipality Berrotarán",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -64.3889098621188,
//    Latitude = -32.44800784576,
//},
//new Municipality()
//{
//    Id = 309520,
//    Name = "Betbeder",
//    FullName = "Junta Betbeder",
//    Source = "IGN",
//    Category = "Junta",
//    Longitude = -59.930601381347,
//    Latitude = -32.3707819646952,
//},
//new Municipality()
//{
//    Id = 140665,
//    Name = "Bialet Massé",
//    FullName = "Municipality Bialet Massé",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -64.5025780065731,
//    Latitude = -31.312123729813,
//},
//new Municipality()
//{
//    Id = 822049,
//    Name = "Bigand",
//    FullName = "Comuna Bigand",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -61.1845657783871,
//    Latitude = -33.3710199776336,
//},
//new Municipality()
//{
//    Id = 60105,
//    Name = "Bolívar",
//    FullName = "Municipality Bolívar",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -61.1498600852288,
//    Latitude = -36.298947958292,
//},
//new Municipality()
//{
//    Id = 822420,
//    Name = "Bombal",
//    FullName = "Comuna Bombal",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -61.3052277159428,
//    Latitude = -33.4572041858455,
//},
//new Municipality()
//{
//    Id = 540056,
//    Name = "Bonpland",
//    FullName = "Municipality Bonpland",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -55.4718692017081,
//    Latitude = -27.4778638061538,
//},
//new Municipality()
//{
//    Id = 180280,
//    Name = "Bonpland",
//    FullName = "Municipality Bonpland",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -57.4609947265433,
//    Latitude = -29.9449397049881,
//},
//new Municipality()
//{
//    Id = 822007,
//    Name = "Bouquet",
//    FullName = "Comuna Bouquet",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -61.877632276779,
//    Latitude = -32.4171813942361,
//},
//new Municipality()
//{
//    Id = 141377,
//    Name = "Bouwer",
//    FullName = "Municipality Bouwer",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -64.1791819532753,
//    Latitude = -31.549740886718,
//},
//new Municipality()
//{
//    Id = 300238,
//    Name = "Bovril",
//    FullName = "Municipality Bovril",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -59.4527179344767,
//    Latitude = -31.3261698439771,
//},
//new Municipality()
//{
//    Id = 60112,
//    Name = "Bragado",
//    FullName = "Municipality Bragado",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -60.6040466528149,
//    Latitude = -35.0614122707839,
//},
//new Municipality()
//{
//    Id = 60119,
//    Name = "Brandsen",
//    FullName = "Municipality Brandsen",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -58.1752339039367,
//    Latitude = -35.2225197990076,
//},
//new Municipality()
//{
//    Id = 141190,
//    Name = "Brinkmann",
//    FullName = "Municipality Brinkmann",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -62.0382117148241,
//    Latitude = -30.8738051951416,
//},
//new Municipality()
//{
//    Id = 140210,
//    Name = "Buchardo",
//    FullName = "Municipality Buchardo",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -63.507311594887,
//    Latitude = -34.7236789574212,
//},
//new Municipality()
//{
//    Id = 268119,
//    Name = "Buen Pasto",
//    FullName = "Comuna Buen Pasto",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -69.4653884108616,
//    Latitude = -45.068316569196,
//},
//new Municipality()
//{
//    Id = 740084,
//    Name = "Buena Esperanza",
//    FullName = "Municipality Buena Esperanza",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -65.2537704313506,
//    Latitude = -34.7590033684233,
//},
//new Municipality()
//{
//    Id = 345056,
//    Name = "Buena Vista",
//    FullName = "Comisión Buena Vista",
//    Source = "IGN",
//    Category = "Comisión",
//    Longitude = -58.3852760427268,
//    Latitude = -25.0710502152579,
//},
//new Municipality()
//{
//    Id = 908497,
//    Name = "Buena Vista",
//    FullName = "Comuna Buena Vista",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -65.4086214831062,
//    Latitude = -27.2931025546672,
//},
//new Municipality()
//{
//    Id = 140791,
//    Name = "Bulnes",
//    FullName = "Municipality Bulnes",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -64.6777003609733,
//    Latitude = -33.5042811125423,
//},
//new Municipality()
//{
//    Id = 900007,
//    Name = "Burruyacú",
//    FullName = "Municipality Burruyacú",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -64.7366427947443,
//    Latitude = -26.4603848495652,
//},
//new Municipality()
//{
//    Id = 822882,
//    Name = "Bustinza",
//    FullName = "Comuna Bustinza",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -61.3524022732469,
//    Latitude = -32.6894261984963,
//},
//new Municipality()
//{
//    Id = 580203,
//    Name = "Buta Ranquil",
//    FullName = "Municipality Buta Ranquil",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -69.8212157543304,
//    Latitude = -37.2422556925228,
//},
//new Municipality()
//{
//    Id = 180112,
//    Name = "Caá Catí",
//    FullName = "Municipality Caá Catí",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -57.7330173182867,
//    Latitude = -27.7179679780286,
//},
//new Municipality()
//{
//    Id = 540252,
//    Name = "Caá Yarí",
//    FullName = "Municipality Caá Yarí",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -55.3054526022292,
//    Latitude = -27.5172025945394,
//},
//new Municipality()
//{
//    Id = 822966,
//    Name = "Cabal",
//    FullName = "Comuna Cabal",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -60.7457774011671,
//    Latitude = -31.1047189527714,
//},
//new Municipality()
//{
//    Id = 142469,
//    Name = "Cabalango",
//    FullName = "Comuna Cabalango",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -64.5640472582957,
//    Latitude = -31.4009006602271,
//},
//new Municipality()
//{
//    Id = 660042,
//    Name = "Cachi",
//    FullName = "Municipality Cachi",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -66.2798125785485,
//    Latitude = -25.0618347947625,
//},
//new Municipality()
//{
//    Id = 823694,
//    Name = "Cacique Ariacaiquín",
//    FullName = "Comuna Cacique Ariacaiquín",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -60.2659296648822,
//    Latitude = -30.5970430509751,
//},
//new Municipality()
//{
//    Id = 660056,
//    Name = "Cafayate",
//    FullName = "Municipality Cafayate",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -65.87672346398,
//    Latitude = -26.125748931235,
//},
//new Municipality()
//{
//    Id = 822588,
//    Name = "Cafferata",
//    FullName = "Comuna Cafferata",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -62.0871825190781,
//    Latitude = -33.4800131950516,
//},
//new Municipality()
//{
//    Id = 380119,
//    Name = "Caimancito",
//    FullName = "Municipality Caimancito",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -64.6978855113341,
//    Latitude = -23.646942846436,
//},
//new Municipality()
//{
//    Id = 820329,
//    Name = "Calchaquí",
//    FullName = "Municipality Calchaquí",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -60.3771331094779,
//    Latitude = -29.8814121218995,
//},
//new Municipality()
//{
//    Id = 140973,
//    Name = "Calchín",
//    FullName = "Municipality Calchín",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -63.1974210579747,
//    Latitude = -31.6676543704963,
//},
//new Municipality()
//{
//    Id = 140980,
//    Name = "Calchín Oeste",
//    FullName = "Municipality Calchín Oeste",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -63.2781089159471,
//    Latitude = -31.8626925094345,
//},
//new Municipality()
//{
//    Id = 420063,
//    Name = "Caleufú",
//    FullName = "Municipality Caleufú",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -64.5916676567215,
//    Latitude = -35.6439826195733,
//},
//new Municipality()
//{
//    Id = 380126,
//    Name = "Calilegua",
//    FullName = "Municipality Calilegua",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -64.7600333436033,
//    Latitude = -23.7340581012476,
//},
//new Municipality()
//{
//    Id = 700021,
//    Name = "Calingasta",
//    FullName = "Municipality Calingasta",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -69.8318658247753,
//    Latitude = -31.4509359086814,
//},
//new Municipality()
//{
//    Id = 260063,
//    Name = "Camarones",
//    FullName = "Municipality Camarones",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -65.7501067940426,
//    Latitude = -44.7983158107646,
//},
//new Municipality()
//{
//    Id = 140490,
//    Name = "Camilo Aldao",
//    FullName = "Municipality Camilo Aldao",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -62.095365317054,
//    Latitude = -33.1268229039745,
//},
//new Municipality()
//{
//    Id = 143120,
//    Name = "Caminiaga",
//    FullName = "Comuna Caminiaga",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -64.0159666929361,
//    Latitude = -30.0636109407393,
//},
//new Municipality()
//{
//    Id = 60126,
//    Name = "Campana",
//    FullName = "Municipality Campana",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -58.8829573786219,
//    Latitude = -34.1383889592815,
//},
//new Municipality()
//{
//    Id = 822973,
//    Name = "Campo Andino",
//    FullName = "Comuna Campo Andino",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -60.542704029724,
//    Latitude = -31.2742893629978,
//},
//new Municipality()
//{
//    Id = 540042,
//    Name = "Campo Grande",
//    FullName = "Municipality Campo Grande",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -54.9614135522405,
//    Latitude = -27.231896357596,
//},
//new Municipality()
//{
//    Id = 620098,
//    Name = "Campo Grande",
//    FullName = "Municipality Campo Grande",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -68.1796447587331,
//    Latitude = -38.6879378416455,
//},
//new Municipality()
//{
//    Id = 220217,
//    Name = "Campo Largo",
//    FullName = "Municipality Campo Largo",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -60.8026877845143,
//    Latitude = -26.8542352439575,
//},
//new Municipality()
//{
//    Id = 823743,
//    Name = "Campo Piaggio",
//    FullName = "Comuna Campo Piaggio",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -61.3087536417042,
//    Latitude = -31.9578774355513,
//},
//new Municipality()
//{
//    Id = 660364,
//    Name = "Campo Quijano",
//    FullName = "Municipality Campo Quijano",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -65.8647103693992,
//    Latitude = -24.5063259781413,
//},
//new Municipality()
//{
//    Id = 540357,
//    Name = "Campo Ramón",
//    FullName = "Municipality Campo Ramón",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -54.9662783280794,
//    Latitude = -27.4792463870228,
//},
//new Municipality()
//{
//    Id = 660105,
//    Name = "Campo Santo",
//    FullName = "Municipality Campo Santo",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -65.1120611051683,
//    Latitude = -24.6700854158298,
//},
//new Municipality()
//{
//    Id = 540364,
//    Name = "Campo Viera",
//    FullName = "Municipality Campo Viera",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -55.0718611750162,
//    Latitude = -27.2823846249012,
//},
//new Municipality()
//{
//    Id = 141624,
//    Name = "Canals",
//    FullName = "Municipality Canals",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -62.8811407005032,
//    Latitude = -33.5586948564453,
//},
//new Municipality()
//{
//    Id = 540063,
//    Name = "Candelaria",
//    FullName = "Municipality Candelaria",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -55.7145178743897,
//    Latitude = -27.4689189015024,
//},
//new Municipality()
//{
//    Id = 740007,
//    Name = "Candelaria",
//    FullName = "Municipality Candelaria",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -65.8335092068045,
//    Latitude = -32.0696433724044,
//},
//new Municipality()
//{
//    Id = 143169,
//    Name = "Candelaria Sud",
//    FullName = "Comuna Candelaria Sud",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -63.8032592447914,
//    Latitude = -30.8433176604863,
//},
//new Municipality()
//{
//    Id = 822980,
//    Name = "Candioti",
//    FullName = "Comuna Candioti",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -60.7596570634448,
//    Latitude = -31.3933381339346,
//},
//new Municipality()
//{
//    Id = 386252,
//    Name = "Cangrejillos",
//    FullName = "Comisión Cangrejillos",
//    Source = "IGN",
//    Category = "Comisión",
//    Longitude = -65.5409173820932,
//    Latitude = -22.443934913097,
//},
//new Municipality()
//{
//    Id = 820126,
//    Name = "Cañada de Gómez",
//    FullName = "Municipality Cañada de Gómez",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -61.4282037638467,
//    Latitude = -32.843409026272,
//},
//new Municipality()
//{
//    Id = 141512,
//    Name = "Cañada de Luque",
//    FullName = "Municipality Cañada de Luque",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -63.725138408134,
//    Latitude = -30.7381485912168,
//},
//new Municipality()
//{
//    Id = 142616,
//    Name = "Cañada de Machado",
//    FullName = "Comuna Cañada de Machado",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -63.5869750076907,
//    Latitude = -31.4291231437251,
//},
//new Municipality()
//{
//    Id = 142266,
//    Name = "Cañada de Río Pinto",
//    FullName = "Comuna Cañada de Río Pinto",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -64.2526933568927,
//    Latitude = -30.7405230006184,
//},
//new Municipality()
//{
//    Id = 142021,
//    Name = "Cañada del Sauce",
//    FullName = "Comuna Cañada del Sauce",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -64.6369274751008,
//    Latitude = -32.3827196464223,
//},
//new Municipality()
//{
//    Id = 822595,
//    Name = "Cañada del Ucle",
//    FullName = "Comuna Cañada del Ucle",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -61.6450157286564,
//    Latitude = -33.3931162936675,
//},
//new Municipality()
//{
//    Id = 824142,
//    Name = "Cañada Ombú",
//    FullName = "Comuna Cañada Ombú",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -60.3199525625028,
//    Latitude = -28.2891586112433,
//},
//new Municipality()
//{
//    Id = 822427,
//    Name = "Cañada Rica",
//    FullName = "Comuna Cañada Rica",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -60.6434461414242,
//    Latitude = -33.5345894602677,
//},
//new Municipality()
//{
//    Id = 824044,
//    Name = "Cañada Rosquín",
//    FullName = "Comuna Cañada Rosquín",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -61.5717382076517,
//    Latitude = -32.0184866476057,
//},
//new Municipality()
//{
//    Id = 60134,
//    Name = "Cañuelas",
//    FullName = "Municipality Cañuelas",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -58.6910941846835,
//    Latitude = -35.1448044957897,
//},
//new Municipality()
//{
//    Id = 100126,
//    Name = "Capayán",
//    FullName = "Municipality Capayán",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -65.8951418899623,
//    Latitude = -29.0371235588453,
//},
//new Municipality()
//{
//    Id = 142623,
//    Name = "Capilla de los Remedios",
//    FullName = "Comuna Capilla de los Remedios",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -63.8203344245727,
//    Latitude = -31.4269081145413,
//},
//new Municipality()
//{
//    Id = 143176,
//    Name = "Capilla de Sitón",
//    FullName = "Comuna Capilla de Sitón",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -63.653161773578,
//    Latitude = -30.5721396926692,
//},
//new Municipality()
//{
//    Id = 140987,
//    Name = "Capilla del Carmen",
//    FullName = "Municipality Capilla del Carmen",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -63.3412198297323,
//    Latitude = -31.5078552559627,
//},
//new Municipality()
//{
//    Id = 140672,
//    Name = "Capilla del Monte",
//    FullName = "Municipality Capilla del Monte",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -64.526171059997,
//    Latitude = -30.8478650515881,
//},
//new Municipality()
//{
//    Id = 540294,
//    Name = "Capioví",
//    FullName = "Municipality Capioví",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -55.058958496652,
//    Latitude = -26.9170033762862,
//},
//new Municipality()
//{
//    Id = 820266,
//    Name = "Capitán Bermúdez",
//    FullName = "Municipality Capitán Bermúdez",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -60.7155011273292,
//    Latitude = -32.8201185291097,
//},
//new Municipality()
//{
//    Id = 908392,
//    Name = "Capitán Cáceres",
//    FullName = "Comuna Capitán Cáceres",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -65.6997955571367,
//    Latitude = -27.1346089954425,
//},
//new Municipality()
//{
//    Id = 140497,
//    Name = "Capitán General Bernardo O'Higgins",
//    FullName = "Municipality Capitán General Bernardo O'Higgins",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -62.2690389534895,
//    Latitude = -33.2490438734254,
//},
//new Municipality()
//{
//    Id = 60140,
//    Name = "Capitán Sarmiento",
//    FullName = "Municipality Capitán Sarmiento",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -59.8540147848762,
//    Latitude = -34.1498445273581,
//},
//new Municipality()
//{
//    Id = 220434,
//    Name = "Capitán Solari",
//    FullName = "Municipality Capitán Solari",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -59.4352719413839,
//    Latitude = -26.8010046765166,
//},
//new Municipality()
//{
//    Id = 823498,
//    Name = "Capivara",
//    FullName = "Comuna Capivara",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -61.3146214679865,
//    Latitude = -30.4748021593471,
//},
//new Municipality()
//{
//    Id = 540336,
//    Name = "Caraguatay",
//    FullName = "Municipality Caraguatay",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -54.6714739859482,
//    Latitude = -26.7880793603049,
//},
//new Municipality()
//{
//    Id = 820273,
//    Name = "Carcarañá",
//    FullName = "Municipality Carcarañá",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -61.130992566749,
//    Latitude = -32.8981441182566,
//},
//new Municipality()
//{
//    Id = 60147,
//    Name = "Carlos Casares",
//    FullName = "Municipality Carlos Casares",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -61.3743777867732,
//    Latitude = -35.7499222140379,
//},
//new Municipality()
//{
//    Id = 824051,
//    Name = "Carlos Pellegrini",
//    FullName = "Comuna Carlos Pellegrini",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -61.8160903505083,
//    Latitude = -32.0531376864246,
//},
//new Municipality()
//{
//    Id = 60154,
//    Name = "Carlos Tejedor",
//    FullName = "Municipality Carlos Tejedor",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -62.4297895789674,
//    Latitude = -35.3797449374574,
//},
//new Municipality()
//{
//    Id = 822602,
//    Name = "Carmen",
//    FullName = "Comuna Carmen",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -61.7809193437975,
//    Latitude = -33.6869903501739,
//},
//new Municipality()
//{
//    Id = 60161,
//    Name = "Carmen de Areco",
//    FullName = "Municipality Carmen de Areco",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -59.884413320764,
//    Latitude = -34.4067977840705,
//},
//new Municipality()
//{
//    Id = 823386,
//    Name = "Carmen del Sauce",
//    FullName = "Comuna Carmen del Sauce",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -60.7866248679102,
//    Latitude = -33.2300039630498,
//},
//new Municipality()
//{
//    Id = 140399,
//    Name = "Carnerillo",
//    FullName = "Municipality Carnerillo",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -64.0239837960949,
//    Latitude = -32.9166449025116,
//},
//new Municipality()
//{
//    Id = 180137,
//    Name = "Carolina",
//    FullName = "Municipality Carolina",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -59.1310456904865,
//    Latitude = -29.1224017112865,
//},
//new Municipality()
//{
//    Id = 740095,
//    Name = "Carpintería",
//    FullName = "Municipality Carpintería",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -64.9996118733987,
//    Latitude = -32.4109275234323,
//},
//new Municipality()
//{
//    Id = 268056,
//    Name = "Carrenleufú",
//    FullName = "Comuna Carrenleufú",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -71.6561284273161,
//    Latitude = -43.5775209919203,
//},
//new Municipality()
//{
//    Id = 822609,
//    Name = "Carreras",
//    FullName = "Comuna Carreras",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -61.3528987413893,
//    Latitude = -33.6251532592042,
//},
//new Municipality()
//{
//    Id = 140994,
//    Name = "Carrilobo",
//    FullName = "Municipality Carrilobo",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -63.1151968886878,
//    Latitude = -31.8688626120995,
//},
//new Municipality()
//{
//    Id = 822889,
//    Name = "Carrizales",
//    FullName = "Comuna Carrizales",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -61.0545249334345,
//    Latitude = -32.5088944503732,
//},
//new Municipality()
//{
//    Id = 420070,
//    Name = "Carro Quemado",
//    FullName = "Municipality Carro Quemado",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -65.3294244941382,
//    Latitude = -36.6770495426341,
//},
//new Municipality()
//{
//    Id = 422007,
//    Name = "Casa de Piedra",
//    FullName = "Comuna Casa de Piedra",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -66.9837281887527,
//    Latitude = -38.2359647768981,
//},
//new Municipality()
//{
//    Id = 142476,
//    Name = "Casa Grande",
//    FullName = "Comuna Casa Grande",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -64.478139337956,
//    Latitude = -31.1582887825211,
//},
//new Municipality()
//{
//    Id = 823750,
//    Name = "Casalegno",
//    FullName = "Comuna Casalegno",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -61.1341439588106,
//    Latitude = -32.2547015044954,
//},
//new Municipality()
//{
//    Id = 824058,
//    Name = "Casas",
//    FullName = "Comuna Casas",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -61.571784017754,
//    Latitude = -32.1577234516421,
//},
//new Municipality()
//{
//    Id = 300420,
//    Name = "Caseros",
//    FullName = "Municipality Caseros",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -58.4842317911848,
//    Latitude = -32.4751363046034,
//},
//new Municipality()
//{
//    Id = 820028,
//    Name = "Casilda",
//    FullName = "Municipality Casilda",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -61.1906668618148,
//    Latitude = -33.0496734903771,
//},
//new Municipality()
//{
//    Id = 386210,
//    Name = "Caspalá",
//    FullName = "Comisión Caspalá",
//    Source = "IGN",
//    Category = "Comisión",
//    Longitude = -65.084994852165,
//    Latitude = -23.3314742193667,
//},
//new Municipality()
//{
//    Id = 824065,
//    Name = "Castelar",
//    FullName = "Comuna Castelar",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -62.1142901138258,
//    Latitude = -31.6760632401892,
//},
//new Municipality()
//{
//    Id = 822168,
//    Name = "Castellanos",
//    FullName = "Comuna Castellanos",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -61.7393661969737,
//    Latitude = -31.1589792060729,
//},
//new Municipality()
//{
//    Id = 60168,
//    Name = "Castelli",
//    FullName = "Municipality Castelli",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -57.6574251947415,
//    Latitude = -36.0414897440036,
//},
//new Municipality()
//{
//    Id = 460021,
//    Name = "Castro Barros",
//    FullName = "Municipality Castro Barros",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -66.918584755618,
//    Latitude = -28.8599829479134,
//},
//new Municipality()
//{
//    Id = 620105,
//    Name = "Catriel",
//    FullName = "Municipality Catriel",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -67.8505121881145,
//    Latitude = -37.883695568622,
//},
//new Municipality()
//{
//    Id = 420077,
//    Name = "Catriló",
//    FullName = "Municipality Catriló",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -63.4792026931568,
//    Latitude = -36.4566727938573,
//},
//new Municipality()
//{
//    Id = 386154,
//    Name = "Catua",
//    FullName = "Comisión Catua",
//    Source = "IGN",
//    Category = "Comisión",
//    Longitude = -66.9595488490146,
//    Latitude = -23.6603549774637,
//},
//new Municipality()
//{
//    Id = 700035,
//    Name = "Caucete",
//    FullName = "Municipality Caucete",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -67.5454408659161,
//    Latitude = -31.5069003261866,
//},
//new Municipality()
//{
//    Id = 140504,
//    Name = "Cavanagh",
//    FullName = "Municipality Cavanagh",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -62.3387928906849,
//    Latitude = -33.477401802254,
//},
//new Municipality()
//{
//    Id = 580168,
//    Name = "Caviahue - Copahue",
//    FullName = "Municipality Caviahue - Copahue",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -71.0450198739331,
//    Latitude = -37.8563623456137,
//},
//new Municipality()
//{
//    Id = 823036,
//    Name = "Cavour",
//    FullName = "Comuna Cavour",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -60.9954046960922,
//    Latitude = -31.3872673145398,
//},
//new Municipality()
//{
//    Id = 822539,
//    Name = "Cayastá",
//    FullName = "Comuna Cayastá",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -60.2433549071387,
//    Latitude = -31.2269237199356,
//},
//new Municipality()
//{
//    Id = 823869,
//    Name = "Cayastacito",
//    FullName = "Comuna Cayastacito",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -60.4956435317884,
//    Latitude = -31.1132405532552,
//},
//new Municipality()
//{
//    Id = 180059,
//    Name = "Cazadores Correntinos",
//    FullName = "Municipality Cazadores Correntinos",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -58.2697837311347,
//    Latitude = -30.1149974823736,
//},
//new Municipality()
//{
//    Id = 420084,
//    Name = "Ceballos",
//    FullName = "Municipality Ceballos",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -63.8132013276735,
//    Latitude = -35.257312509695,
//},
//new Municipality()
//{
//    Id = 180188,
//    Name = "Cecilio Echavarría",
//    FullName = "Municipality Cecilio Echavarría",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -59.1371706365002,
//    Latitude = -28.9295102558124,
//},
//new Municipality()
//{
//    Id = 300210,
//    Name = "Ceibas",
//    FullName = "Municipality Ceibas",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -58.8283172501627,
//    Latitude = -33.5462534607888,
//},
//new Municipality()
//{
//    Id = 580042,
//    Name = "Centenario",
//    FullName = "Municipality Centenario",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -68.2666896219457,
//    Latitude = -38.7042256139599,
//},
//new Municipality()
//{
//    Id = 823757,
//    Name = "Centeno",
//    FullName = "Comuna Centeno",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -61.3879286384149,
//    Latitude = -32.2799048993992,
//},
//new Municipality()
//{
//    Id = 822434,
//    Name = "Cepeda",
//    FullName = "Comuna Cepeda",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -60.5863509794206,
//    Latitude = -33.4041900910842,
//},
//new Municipality()
//{
//    Id = 820224,
//    Name = "Ceres",
//    FullName = "Municipality Ceres",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -61.9207533224311,
//    Latitude = -29.8519739213029,
//},
//new Municipality()
//{
//    Id = 300294,
//    Name = "Cerrito",
//    FullName = "Municipality Cerrito",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -60.0710214197077,
//    Latitude = -31.565261810305,
//},
//new Municipality()
//{
//    Id = 540259,
//    Name = "Cerro Azul",
//    FullName = "Municipality Cerro Azul",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -55.5134639632846,
//    Latitude = -27.6492686427669,
//},
//new Municipality()
//{
//    Id = 268021,
//    Name = "Cerro Centinela",
//    FullName = "Comuna Cerro Centinela",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -71.6090756854463,
//    Latitude = -43.4623262308252,
//},
//new Municipality()
//{
//    Id = 142735,
//    Name = "Cerro Colorado",
//    FullName = "Comuna Cerro Colorado",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -63.9308316345683,
//    Latitude = -30.1019030225598,
//},
//new Municipality()
//{
//    Id = 540070,
//    Name = "Cerro Corá",
//    FullName = "Municipality Cerro Corá",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -55.6020787861869,
//    Latitude = -27.5269569041305,
//},
//new Municipality()
//{
//    Id = 620112,
//    Name = "Cervantes",
//    FullName = "Municipality Cervantes",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -67.4361987549371,
//    Latitude = -39.051777777185,
//},
//new Municipality()
//{
//    Id = 908644,
//    Name = "Cevil Redondo",
//    FullName = "Comuna Cevil Redondo",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -65.308174018918,
//    Latitude = -26.7604178632689,
//},
//new Municipality()
//{
//    Id = 822056,
//    Name = "Chabas",
//    FullName = "Comuna Chabas",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -61.364288623701,
//    Latitude = -33.2624921319325,
//},
//new Municipality()
//{
//    Id = 60210,
//    Name = "Chacabuco",
//    FullName = "Municipality Chacabuco",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -60.3543081129666,
//    Latitude = -34.6182002950802,
//},
//new Municipality()
//{
//    Id = 425049,
//    Name = "Chacharramendi",
//    FullName = "Comisión Chacharramendi",
//    Source = "IGN",
//    Category = "Comisión",
//    Longitude = -65.7044365847663,
//    Latitude = -37.2319839948408,
//},
//new Municipality()
//{
//    Id = 140798,
//    Name = "Chaján",
//    FullName = "Municipality Chaján",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -65.0045692987122,
//    Latitude = -33.5562216707363,
//},
//new Municipality()
//{
//    Id = 300105,
//    Name = "Chajarí",
//    FullName = "Municipality Chajarí",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -57.9784528300781,
//    Latitude = -30.7399159326042,
//},
//new Municipality()
//{
//    Id = 142630,
//    Name = "Chalacea",
//    FullName = "Comuna Chalacea",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -63.5769184254782,
//    Latitude = -30.7632052336575,
//},
//new Municipality()
//{
//    Id = 460035,
//    Name = "Chamical",
//    FullName = "Municipality Chamical",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -65.9564977168715,
//    Latitude = -30.1676450231494,
//},
//new Municipality()
//{
//    Id = 142406,
//    Name = "Chancani",
//    FullName = "Comuna Chancani",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -65.4541355537782,
//    Latitude = -31.4141204298845,
//},
//new Municipality()
//{
//    Id = 822063,
//    Name = "Chañar Ladeado",
//    FullName = "Comuna Chañar Ladeado",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -62.0040366530648,
//    Latitude = -33.3073339182632,
//},
//new Municipality()
//{
//    Id = 142742,
//    Name = "Chañar Viejo",
//    FullName = "Comuna Chañar Viejo",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -63.8514999217487,
//    Latitude = -29.9924994136234,
//},
//new Municipality()
//{
//    Id = 822616,
//    Name = "Chapuy",
//    FullName = "Comuna Chapuy",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -61.7629859351878,
//    Latitude = -33.8060370663112,
//},
//new Municipality()
//{
//    Id = 220469,
//    Name = "Charadai",
//    FullName = "Municipality Charadai",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -59.9615830907614,
//    Latitude = -27.6442542844503,
//},
//new Municipality()
//{
//    Id = 220084,
//    Name = "Charata",
//    FullName = "Municipality Charata",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -61.3088346235932,
//    Latitude = -27.1153498940707,
//},
//new Municipality()
//{
//    Id = 142483,
//    Name = "Charbonier",
//    FullName = "Comuna Charbonier",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -64.5633540911154,
//    Latitude = -30.7610604774202,
//},
//new Municipality()
//{
//    Id = 140406,
//    Name = "Charras",
//    FullName = "Municipality Charras",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -64.0481926881725,
//    Latitude = -33.0231292173334,
//},
//new Municipality()
//{
//    Id = 60218,
//    Name = "Chascomús",
//    FullName = "Municipality Chascomús",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -57.9039810685242,
//    Latitude = -35.6186883086057,
//},
//new Municipality()
//{
//    Id = 180413,
//    Name = "Chavarría",
//    FullName = "Municipality Chavarría",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -58.519190065446,
//    Latitude = -28.8781264905085,
//},
//new Municipality()
//{
//    Id = 140287,
//    Name = "Chazón",
//    FullName = "Municipality Chazón",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -63.2744840417554,
//    Latitude = -33.0779841520433,
//},
//new Municipality()
//{
//    Id = 620119,
//    Name = "Chichinales",
//    FullName = "Municipality Chichinales",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -66.9503201220478,
//    Latitude = -39.1303030332847,
//},
//new Municipality()
//{
//    Id = 660091,
//    Name = "Chicoana",
//    FullName = "Municipality Chicoana",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -65.6751474306073,
//    Latitude = -25.1595002403091,
//},
//new Municipality()
//{
//    Id = 309880,
//    Name = "Chilcas",
//    FullName = "Junta Chilcas",
//    Source = "IGN",
//    Category = "Junta",
//    Longitude = -60.2680203681267,
//    Latitude = -32.3117845615934,
//},
//new Municipality()
//{
//    Id = 460042,
//    Name = "Chilecito",
//    FullName = "Municipality Chilecito",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -67.427886789152,
//    Latitude = -29.39593747537,
//},
//new Municipality()
//{
//    Id = 141631,
//    Name = "Chilibroste",
//    FullName = "Municipality Chilibroste",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -62.5134148309413,
//    Latitude = -32.3326918177426,
//},
//new Municipality()
//{
//    Id = 700042,
//    Name = "Chimbas",
//    FullName = "Municipality Chimbas",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -68.5239289663008,
//    Latitude = -31.4874196948537,
//},
//new Municipality()
//{
//    Id = 620021,
//    Name = "Chimpay",
//    FullName = "Municipality Chimpay",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -66.1565596219794,
//    Latitude = -39.1578724361784,
//},
//new Municipality()
//{
//    Id = 60224,
//    Name = "Chivilcoy",
//    FullName = "Municipality Chivilcoy",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -59.958419488149,
//    Latitude = -34.9154873284331,
//},
//new Municipality()
//{
//    Id = 620028,
//    Name = "Choele Choel",
//    FullName = "Municipality Choele Choel",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -65.6501737454108,
//    Latitude = -39.2973907241514,
//},
//new Municipality()
//{
//    Id = 260014,
//    Name = "Cholila",
//    FullName = "Municipality Cholila",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -71.4218533427081,
//    Latitude = -42.4826328295296,
//},
//new Municipality()
//{
//    Id = 908623,
//    Name = "Choromoro",
//    FullName = "Comuna Choromoro",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -65.4177381246714,
//    Latitude = -26.4504510305717,
//},
//new Municipality()
//{
//    Id = 220119,
//    Name = "Chorotis",
//    FullName = "Municipality Chorotis",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -61.5418835499658,
//    Latitude = -27.8791821836819,
//},
//new Municipality()
//{
//    Id = 585063,
//    Name = "Chorriaca",
//    FullName = "Comisión Chorriaca",
//    Source = "IGN",
//    Category = "Comisión",
//    Longitude = -70.0454887052143,
//    Latitude = -37.9187490777073,
//},
//new Municipality()
//{
//    Id = 580098,
//    Name = "Chos Malal",
//    FullName = "Municipality Chos Malal",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -70.2707713376411,
//    Latitude = -37.3560814630106,
//},
//new Municipality()
//{
//    Id = 822623,
//    Name = "Chovet",
//    FullName = "Comuna Chovet",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -61.6504491902047,
//    Latitude = -33.5498667445754,
//},
//new Municipality()
//{
//    Id = 822630,
//    Name = "Christophersen",
//    FullName = "Comuna Christophersen",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -62.0669267336755,
//    Latitude = -34.1766468939857,
//},
//new Municipality()
//{
//    Id = 142553,
//    Name = "Chucul",
//    FullName = "Comuna Chucul",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -64.1704416685286,
//    Latitude = -33.0108482213758,
//},
//new Municipality()
//{
//    Id = 142273,
//    Name = "Chuña",
//    FullName = "Comuna Chuña",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -64.6415044577514,
//    Latitude = -30.4549727642068,
//},
//new Municipality()
//{
//    Id = 143127,
//    Name = "Chuña Huasi",
//    FullName = "Comuna Chuña Huasi",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -64.1260864027201,
//    Latitude = -29.8939402837581,
//},
//new Municipality()
//{
//    Id = 143204,
//    Name = "Churqui Cañada",
//    FullName = "Comuna Churqui Cañada",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -63.938667533284,
//    Latitude = -30.2150807804174,
//},
//new Municipality()
//{
//    Id = 142357,
//    Name = "Ciénaga del Coro",
//    FullName = "Comuna Ciénaga del Coro",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -65.2173529643715,
//    Latitude = -31.0053157540084,
//},
//new Municipality()
//{
//    Id = 386133,
//    Name = "Cieneguillas",
//    FullName = "Comisión Cieneguillas",
//    Source = "IGN",
//    Category = "Comisión",
//    Longitude = -65.9421448476013,
//    Latitude = -22.125510104751,
//},
//new Municipality()
//{
//    Id = 220252,
//    Name = "Ciervo Petiso",
//    FullName = "Municipality Ciervo Petiso",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -59.6212180366661,
//    Latitude = -26.5677763759121,
//},
//new Municipality()
//{
//    Id = 620126,
//    Name = "Cinco Saltos",
//    FullName = "Municipality Cinco Saltos",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -68.0648503162591,
//    Latitude = -38.8139938415882,
//},
//new Municipality()
//{
//    Id = 141638,
//    Name = "Cintra",
//    FullName = "Municipality Cintra",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -62.6517297624238,
//    Latitude = -32.3087285653745,
//},
//new Municipality()
//{
//    Id = 620133,
//    Name = "Cipolletti",
//    FullName = "Municipality Cipolletti",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -68.6955226062846,
//    Latitude = -39.4542427486591,
//},
//new Municipality()
//{
//    Id = 908504,
//    Name = "Ciudacita",
//    FullName = "Comuna Ciudacita",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -65.4190451924839,
//    Latitude = -27.4421858365345,
//},
//new Municipality()
//{
//    Id = 822896,
//    Name = "Classon",
//    FullName = "Comuna Classon",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -61.3490127007287,
//    Latitude = -32.4901170255222,
//},
//new Municipality()
//{
//    Id = 309035,
//    Name = "Clodomiro Ledesma",
//    FullName = "Junta Clodomiro Ledesma",
//    Source = "IGN",
//    Category = "Junta",
//    Longitude = -58.2111881081589,
//    Latitude = -31.5654066331359,
//},
//new Municipality()
//{
//    Id = 340189,
//    Name = "Clorinda",
//    FullName = "Municipality Clorinda",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -57.750524963664,
//    Latitude = -25.336544448852,
//},
//new Municipality()
//{
//    Id = 908574,
//    Name = "Colalao del Valle",
//    FullName = "Comuna Colalao del Valle",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -66.0628509955511,
//    Latitude = -26.4288793646823,
//},
//new Municipality()
//{
//    Id = 268063,
//    Name = "Colan Conhue",
//    FullName = "Comuna Colan Conhue",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -70.0165928358279,
//    Latitude = -43.2569672103579,
//},
//new Municipality()
//{
//    Id = 141001,
//    Name = "Colazo",
//    FullName = "Municipality Colazo",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -63.3815414522893,
//    Latitude = -31.9618836173836,
//},
//new Municipality()
//{
//    Id = 908077,
//    Name = "Colombres",
//    FullName = "Comuna Colombres",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -65.070141646709,
//    Latitude = -26.8923611719294,
//},
//new Municipality()
//{
//    Id = 60175,
//    Name = "Colón",
//    FullName = "Municipality Colón",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -61.0624837286828,
//    Latitude = -33.885864543958,
//},
//new Municipality()
//{
//    Id = 300007,
//    Name = "Colón",
//    FullName = "Municipality Colón",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -58.2076157399041,
//    Latitude = -32.2605089735912,
//},
//new Municipality()
//{
//    Id = 420385,
//    Name = "Colonia 25 de Mayo",
//    FullName = "Municipality Colonia 25 de Mayo",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -67.3036887447812,
//    Latitude = -37.7965968231496,
//},
//new Municipality()
//{
//    Id = 309917,
//    Name = "Colonia Adivino",
//    FullName = "Junta Colonia Adivino",
//    Source = "IGN",
//    Category = "Junta",
//    Longitude = -59.3297736711386,
//    Latitude = -31.4033826395218,
//},
//new Municipality()
//{
//    Id = 540371,
//    Name = "Colonia Alberdi",
//    FullName = "Municipality Colonia Alberdi",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -55.2012289666856,
//    Latitude = -27.3573478556655,
//},
//new Municipality()
//{
//    Id = 822147,
//    Name = "Colonia Aldao",
//    FullName = "Comuna Colonia Aldao",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -61.7400552024928,
//    Latitude = -30.9857555355997,
//},
//new Municipality()
//{
//    Id = 309135,
//    Name = "Colonia Alemana",
//    FullName = "Junta Colonia Alemana",
//    Source = "IGN",
//    Category = "Junta",
//    Longitude = -58.0231927415399,
//    Latitude = -30.9079145948782,
//},
//new Municipality()
//{
//    Id = 141428,
//    Name = "Colonia Almada",
//    FullName = "Municipality Colonia Almada",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -63.8637834613237,
//    Latitude = -32.0344936485779,
//},
//new Municipality()
//{
//    Id = 823505,
//    Name = "Colonia Ana",
//    FullName = "Comuna Colonia Ana",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -61.9662786636887,
//    Latitude = -30.1298883651937,
//},
//new Municipality()
//{
//    Id = 142931,
//    Name = "Colonia Anita",
//    FullName = "Comuna Colonia Anita",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -62.2342507930804,
//    Latitude = -31.1210986173448,
//},
//new Municipality()
//{
//    Id = 540518,
//    Name = "Colonia Aurora",
//    FullName = "Municipality Colonia Aurora",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -54.4485723076837,
//    Latitude = -27.3576371078122,
//},
//new Municipality()
//{
//    Id = 300297,
//    Name = "Colonia Avellaneda",
//    FullName = "Municipality Colonia Avellaneda",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -60.3982459241848,
//    Latitude = -31.734886008257,
//},
//new Municipality()
//{
//    Id = 302596,
//    Name = "Colonia Avigdor",
//    FullName = "Junta Colonia Avigdor",
//    Source = "IGN",
//    Category = "Junta",
//    Longitude = -59.4460172741413,
//    Latitude = -31.1472245961019,
//},
//new Municipality()
//{
//    Id = 300035,
//    Name = "Colonia Ayuí",
//    FullName = "Municipality Colonia Ayuí",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -58.0345506181468,
//    Latitude = -31.2161390420137,
//},
//new Municipality()
//{
//    Id = 142336,
//    Name = "Colonia Barge",
//    FullName = "Comuna Colonia Barge",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -62.6074772843903,
//    Latitude = -33.2560592578889,
//},
//new Municipality()
//{
//    Id = 420091,
//    Name = "Colonia Barón",
//    FullName = "Municipality Colonia Barón",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -63.8361884288118,
//    Latitude = -36.2070971406217,
//},
//new Municipality()
//{
//    Id = 309770,
//    Name = "Colonia Baylina",
//    FullName = "Junta Colonia Baylina",
//    Source = "IGN",
//    Category = "Junta",
//    Longitude = -58.5249570390168,
//    Latitude = -31.7707029079917,
//},
//new Municipality()
//{
//    Id = 824072,
//    Name = "Colonia Belgrano",
//    FullName = "Comuna Colonia Belgrano",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -61.421539312411,
//    Latitude = -31.9541122826766,
//},
//new Municipality()
//{
//    Id = 220364,
//    Name = "Colonia Benítez",
//    FullName = "Municipality Colonia Benítez",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -58.8534296645655,
//    Latitude = -27.3093128388898,
//},
//new Municipality()
//{
//    Id = 822154,
//    Name = "Colonia Bicha",
//    FullName = "Comuna Colonia Bicha",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -61.8407751742027,
//    Latitude = -30.8608539786446,
//},
//new Municipality()
//{
//    Id = 822161,
//    Name = "Colonia Bigand",
//    FullName = "Comuna Colonia Bigand",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -61.7175552465498,
//    Latitude = -31.0667175039589,
//},
//new Municipality()
//{
//    Id = 141645,
//    Name = "Colonia Bismarck",
//    FullName = "Municipality Colonia Bismarck",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -62.7159959455752,
//    Latitude = -33.3005078918635,
//},
//new Municipality()
//{
//    Id = 823512,
//    Name = "Colonia Bossi",
//    FullName = "Comuna Colonia Bossi",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -61.7877992515141,
//    Latitude = -30.672623427857,
//},
//new Municipality()
//{
//    Id = 143239,
//    Name = "Colonia Bremen",
//    FullName = "Comuna Colonia Bremen",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -62.730992323301,
//    Latitude = -33.4634143562879,
//},
//new Municipality()
//{
//    Id = 180357,
//    Name = "Colonia Carlos Pellegrini",
//    FullName = "Municipality Colonia Carlos Pellegrini",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -56.9796496923308,
//    Latitude = -28.5228151073389,
//},
//new Municipality()
//{
//    Id = 140091,
//    Name = "Colonia Caroya",
//    FullName = "Municipality Colonia Caroya",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -64.0859537870841,
//    Latitude = -31.0541541597821,
//},
//new Municipality()
//{
//    Id = 309430,
//    Name = "Colonia Carrasco",
//    FullName = "Junta Colonia Carrasco",
//    Source = "IGN",
//    Category = "Junta",
//    Longitude = -59.5556243500382,
//    Latitude = -31.3097060457356,
//},
//new Municipality()
//{
//    Id = 309635,
//    Name = "Colonia Celina",
//    FullName = "Junta Colonia Celina",
//    Source = "IGN",
//    Category = "Junta",
//    Longitude = -60.2493770452831,
//    Latitude = -31.6081673170439,
//},
//new Municipality()
//{
//    Id = 822175,
//    Name = "Colonia Cello",
//    FullName = "Comuna Colonia Cello",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -61.8690954995392,
//    Latitude = -31.442922092944,
//},
//new Municipality()
//{
//    Id = 823568,
//    Name = "Colonia Clara",
//    FullName = "Comuna Colonia Clara",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -61.0654579390127,
//    Latitude = -30.5475134918445,
//},
//new Municipality()
//{
//    Id = 302899,
//    Name = "Colonia Crespo",
//    FullName = "Junta Colonia Crespo",
//    Source = "IGN",
//    Category = "Junta",
//    Longitude = -60.2122585156225,
//    Latitude = -31.7017898721301,
//},
//new Municipality()
//{
//    Id = 540140,
//    Name = "Colonia Delicia",
//    FullName = "Municipality Colonia Delicia",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -54.3968718899566,
//    Latitude = -26.2054681647982,
//},
//new Municipality()
//{
//    Id = 823876,
//    Name = "Colonia Dolores",
//    FullName = "Comuna Colonia Dolores",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -60.304352539679,
//    Latitude = -30.4046798589517,
//},
//new Municipality()
//{
//    Id = 823701,
//    Name = "Colonia Durán",
//    FullName = "Comuna Colonia Durán",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -59.9664905410897,
//    Latitude = -29.5713985436429,
//},
//new Municipality()
//{
//    Id = 300423,
//    Name = "Colonia Elía",
//    FullName = "Municipality Colonia Elía",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -58.2965384206995,
//    Latitude = -32.7803765549593,
//},
//new Municipality()
//{
//    Id = 220441,
//    Name = "Colonia Elisa",
//    FullName = "Municipality Colonia Elisa",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -59.407007547917,
//    Latitude = -26.9245048009317,
//},
//new Municipality()
//{
//    Id = 302133,
//    Name = "Colonia Ensayo",
//    FullName = "Junta Colonia Ensayo",
//    Source = "IGN",
//    Category = "Junta",
//    Longitude = -60.5876359037979,
//    Latitude = -31.8549427850758,
//},
//new Municipality()
//{
//    Id = 140511,
//    Name = "Colonia Italiana",
//    FullName = "Municipality Colonia Italiana",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -62.1813642349834,
//    Latitude = -33.3065740201285,
//},
//new Municipality()
//{
//    Id = 822182,
//    Name = "Colonia Iturraspe",
//    FullName = "Comuna Colonia Iturraspe",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -61.6182940033775,
//    Latitude = -31.4872374386429,
//},
//new Municipality()
//{
//    Id = 142938,
//    Name = "Colonia Iturraspe",
//    FullName = "Comuna Colonia Iturraspe",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -62.1111936572759,
//    Latitude = -31.2076433233757,
//},
//new Municipality()
//{
//    Id = 309140,
//    Name = "Colonia La Argentina",
//    FullName = "Junta Colonia La Argentina",
//    Source = "IGN",
//    Category = "Junta",
//    Longitude = -58.0178587911315,
//    Latitude = -31.0784734844505,
//},
//new Municipality()
//{
//    Id = 142637,
//    Name = "Colonia Las Cuatro Esquinas",
//    FullName = "Comuna Colonia Las Cuatro Esquinas",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -63.2243244282166,
//    Latitude = -31.2036266461889,
//},
//new Municipality()
//{
//    Id = 142945,
//    Name = "Colonia Las Pichanas",
//    FullName = "Comuna Colonia Las Pichanas",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -62.9366942797857,
//    Latitude = -31.3039964065618,
//},
//new Municipality()
//{
//    Id = 180252,
//    Name = "Colonia Libertad",
//    FullName = "Municipality Colonia Libertad",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -57.8975859463097,
//    Latitude = -29.9598614782455,
//},
//new Municipality()
//{
//    Id = 180161,
//    Name = "Colonia Liebig",
//    FullName = "Municipality Colonia Liebig",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -56.0568042426164,
//    Latitude = -27.7797461106603,
//},
//new Municipality()
//{
//    Id = 822189,
//    Name = "Colonia Margarita",
//    FullName = "Comuna Colonia Margarita",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -61.6520048498578,
//    Latitude = -31.6832565715029,
//},
//new Municipality()
//{
//    Id = 141197,
//    Name = "Colonia Marina",
//    FullName = "Municipality Colonia Marina",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -62.3626031807012,
//    Latitude = -31.2488859057542,
//},
//new Municipality()
//{
//    Id = 822546,
//    Name = "Colonia Mascías",
//    FullName = "Comuna Colonia Mascías",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -59.9651810583686,
//    Latitude = -30.7725602238251,
//},
//new Municipality()
//{
//    Id = 822301,
//    Name = "Colonia Maua",
//    FullName = "Comuna Colonia Maua",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -61.2600717295104,
//    Latitude = -30.7754677445171,
//},
//new Municipality()
//{
//    Id = 309650,
//    Name = "Colonia Merou",
//    FullName = "Junta Colonia Merou",
//    Source = "IGN",
//    Category = "Junta",
//    Longitude = -60.3122616671076,
//    Latitude = -31.9031757974734,
//},
//new Municipality()
//{
//    Id = 309435,
//    Name = "Colonia Oficial N° 13",
//    FullName = "Junta Colonia Oficial N° 13",
//    Source = "IGN",
//    Category = "Junta",
//    Longitude = -59.5431591089184,
//    Latitude = -30.6518580097937,
//},
//new Municipality()
//{
//    Id = 309440,
//    Name = "Colonia Oficial Nº 3 y 14",
//    FullName = "Junta Colonia Oficial Nº 3 y 14",
//    Source = "IGN",
//    Category = "Junta",
//    Longitude = -59.35842402843,
//    Latitude = -30.5758854543547,
//},
//new Municipality()
//{
//    Id = 309775,
//    Name = "Colonia Oficial Nº 5",
//    FullName = "Junta Colonia Oficial Nº 5",
//    Source = "IGN",
//    Category = "Junta",
//    Longitude = -58.3262801985659,
//    Latitude = -31.5965321271639,
//},
//new Municipality()
//{
//    Id = 180417,
//    Name = "Colonia Pando",
//    FullName = "Municipality Colonia Pando",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -58.4963951407095,
//    Latitude = -28.4888476762592,
//},
//new Municipality()
//{
//    Id = 345014,
//    Name = "Colonia Pastoril",
//    FullName = "Comisión Colonia Pastoril",
//    Source = "IGN",
//    Category = "Comisión",
//    Longitude = -58.2668101771917,
//    Latitude = -25.6835261933357,
//},
//new Municipality()
//{
//    Id = 540420,
//    Name = "Colonia Polana",
//    FullName = "Municipality Colonia Polana",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -55.3166146375267,
//    Latitude = -27.0078896040364,
//},
//new Municipality()
//{
//    Id = 220231,
//    Name = "Colonia Popular",
//    FullName = "Municipality Colonia Popular",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -59.1276189578969,
//    Latitude = -27.2935365478148,
//},
//new Municipality()
//{
//    Id = 141204,
//    Name = "Colonia Prosperidad",
//    FullName = "Municipality Colonia Prosperidad",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -62.3816472058385,
//    Latitude = -31.6255205424057,
//},
//new Municipality()
//{
//    Id = 822196,
//    Name = "Colonia Raquel",
//    FullName = "Comuna Colonia Raquel",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -61.5053825202058,
//    Latitude = -30.8228701986045,
//},
//new Municipality()
//{
//    Id = 823519,
//    Name = "Colonia Rosa",
//    FullName = "Comuna Colonia Rosa",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -62.0293366266851,
//    Latitude = -30.3193361058803,
//},
//new Municipality()
//{
//    Id = 309007,
//    Name = "Colonia San Anselmo y Aledañas",
//    FullName = "Junta Colonia San Anselmo y Aledañas",
//    Source = "IGN",
//    Category = "Junta",
//    Longitude = -58.2079351906869,
//    Latitude = -32.3133019308667,
//},
//new Municipality()
//{
//    Id = 141211,
//    Name = "Colonia San Bartolomé",
//    FullName = "Municipality Colonia San Bartolomé",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -62.7236406722185,
//    Latitude = -31.5279808890143,
//},
//new Municipality()
//{
//    Id = 142952,
//    Name = "Colonia San Pedro",
//    FullName = "Comuna Colonia San Pedro",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -61.9173543437841,
//    Latitude = -30.7826893147179,
//},
//new Municipality()
//{
//    Id = 425028,
//    Name = "Colonia Santa María",
//    FullName = "Comisión Colonia Santa María",
//    Source = "IGN",
//    Category = "Comisión",
//    Longitude = -64.176842474325,
//    Latitude = -37.4369062401872,
//},
//new Municipality()
//{
//    Id = 309143,
//    Name = "Colonia Santa María y Las Margaritas",
//    FullName = "Junta Colonia Santa María y Las Margaritas",
//    Source = "IGN",
//    Category = "Junta",
//    Longitude = -58.1572372824938,
//    Latitude = -30.577903932217,
//},
//new Municipality()
//{
//    Id = 180035,
//    Name = "Colonia Santa Rosa",
//    FullName = "Municipality Colonia Santa Rosa",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -57.9454747325673,
//    Latitude = -28.1481419835769,
//},
//new Municipality()
//{
//    Id = 660294,
//    Name = "Colonia Santa Rosa",
//    FullName = "Municipality Colonia Santa Rosa",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -64.392718679896,
//    Latitude = -23.3801440595807,
//},
//new Municipality()
//{
//    Id = 420343,
//    Name = "Colonia Santa Teresa",
//    FullName = "Municipality Colonia Santa Teresa",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -63.530284566768,
//    Latitude = -37.557730904223,
//},
//new Municipality()
//{
//    Id = 140098,
//    Name = "Colonia Tirolesa",
//    FullName = "Municipality Colonia Tirolesa",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -64.0295107529085,
//    Latitude = -31.2182550190745,
//},
//new Municipality()
//{
//    Id = 309145,
//    Name = "Colonia Tunas",
//    FullName = "Junta Colonia Tunas",
//    Source = "IGN",
//    Category = "Junta",
//    Longitude = -58.2271628068873,
//    Latitude = -30.3869618213432,
//},
//new Municipality()
//{
//    Id = 142959,
//    Name = "Colonia Valtelina",
//    FullName = "Comuna Colonia Valtelina",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -62.2339804279146,
//    Latitude = -31.0524082685551,
//},
//new Municipality()
//{
//    Id = 142098,
//    Name = "Colonia Vicente Agüero",
//    FullName = "Comuna Colonia Vicente Agüero",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -64.001954509175,
//    Latitude = -31.0166675793953,
//},
//new Municipality()
//{
//    Id = 540147,
//    Name = "Colonia Victoria",
//    FullName = "Municipality Colonia Victoria",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -54.4956399292813,
//    Latitude = -26.3079117236751,
//},
//new Municipality()
//{
//    Id = 142805,
//    Name = "Colonia Videla",
//    FullName = "Comuna Colonia Videla",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -63.5039908818592,
//    Latitude = -31.9169547649849,
//},
//new Municipality()
//{
//    Id = 141218,
//    Name = "Colonia Vignaud",
//    FullName = "Municipality Colonia Vignaud",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -61.9554557644487,
//    Latitude = -30.8424347299693,
//},
//new Municipality()
//{
//    Id = 309445,
//    Name = "Colonia Viraró",
//    FullName = "Junta Colonia Viraró",
//    Source = "IGN",
//    Category = "Junta",
//    Longitude = -59.4030290029107,
//    Latitude = -31.2617783176604,
//},
//new Municipality()
//{
//    Id = 540231,
//    Name = "Colonia Wanda",
//    FullName = "Municipality Colonia Wanda",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -54.3100077564001,
//    Latitude = -25.9807484031609,
//},
//new Municipality()
//{
//    Id = 220448,
//    Name = "Colonias Unidas",
//    FullName = "Municipality Colonias Unidas",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -59.6200326318341,
//    Latitude = -26.6968299152344,
//},
//new Municipality()
//{
//    Id = 620217,
//    Name = "Comallo",
//    FullName = "Municipality Comallo",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -70.2714048948203,
//    Latitude = -41.0270061846137,
//},
//new Municipality()
//{
//    Id = 540182,
//    Name = "Comandante Andresito",
//    FullName = "Municipality Comandante Andresito",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -54.0113111965447,
//    Latitude = -25.7226094657463,
//},
//new Municipality()
//{
//    Id = 340091,
//    Name = "Comandante Fontana",
//    FullName = "Municipality Comandante Fontana",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -59.684853628009,
//    Latitude = -25.3369590717899,
//},
//new Municipality()
//{
//    Id = 142644,
//    Name = "Comechingones",
//    FullName = "Comuna Comechingones",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -63.6066406773798,
//    Latitude = -31.171688863206,
//},
//new Municipality()
//{
//    Id = 260049,
//    Name = "Comodoro Rivadavia",
//    FullName = "Municipality Comodoro Rivadavia",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -67.5913153223866,
//    Latitude = -45.839341003736,
//},
//new Municipality()
//{
//    Id = 22007,
//    Name = "Comuna 1",
//    FullName = "Comuna 1",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -58.3715117424742,
//    Latitude = -34.6064435423382,
//},
//new Municipality()
//{
//    Id = 22070,
//    Name = "Comuna 10",
//    FullName = "Comuna 10",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -58.5028148619848,
//    Latitude = -34.6278367969553,
//},
//new Municipality()
//{
//    Id = 22077,
//    Name = "Comuna 11",
//    FullName = "Comuna 11",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -58.496843970025,
//    Latitude = -34.6061049880892,
//},
//new Municipality()
//{
//    Id = 22084,
//    Name = "Comuna 12",
//    FullName = "Comuna 12",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -58.490466695976,
//    Latitude = -34.5663151369651,
//},
//new Municipality()
//{
//    Id = 22091,
//    Name = "Comuna 13",
//    FullName = "Comuna 13",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -58.4539600938986,
//    Latitude = -34.5541785487029,
//},
//new Municipality()
//{
//    Id = 22098,
//    Name = "Comuna 14",
//    FullName = "Comuna 14",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -58.4222940810483,
//    Latitude = -34.573874740768,
//},
//new Municipality()
//{
//    Id = 22105,
//    Name = "Comuna 15",
//    FullName = "Comuna 15",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -58.4627740218465,
//    Latitude = -34.5918836701535,
//},
//new Municipality()
//{
//    Id = 22014,
//    Name = "Comuna 2",
//    FullName = "Comuna 2",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -58.3949035422527,
//    Latitude = -34.5857888788086,
//},
//new Municipality()
//{
//    Id = 22021,
//    Name = "Comuna 3",
//    FullName = "Comuna 3",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -58.4026514511807,
//    Latitude = -34.6138430816924,
//},
//new Municipality()
//{
//    Id = 22028,
//    Name = "Comuna 4",
//    FullName = "Comuna 4",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -58.3876200325984,
//    Latitude = -34.642104987405,
//},
//new Municipality()
//{
//    Id = 22035,
//    Name = "Comuna 5",
//    FullName = "Comuna 5",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -58.4205721902504,
//    Latitude = -34.6173699237915,
//},
//new Municipality()
//{
//    Id = 22042,
//    Name = "Comuna 6",
//    FullName = "Comuna 6",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -58.4435682279951,
//    Latitude = -34.6168433901026,
//},
//new Municipality()
//{
//    Id = 22049,
//    Name = "Comuna 7",
//    FullName = "Comuna 7",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -58.4518868569654,
//    Latitude = -34.6365544143585,
//},
//new Municipality()
//{
//    Id = 22056,
//    Name = "Comuna 8",
//    FullName = "Comuna 8",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -58.4618739596935,
//    Latitude = -34.6745166595408,
//},
//new Municipality()
//{
//    Id = 22063,
//    Name = "Comuna 9",
//    FullName = "Comuna 9",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -58.4989974714121,
//    Latitude = -34.6517457394601,
//},
//new Municipality()
//{
//    Id = 303154,
//    Name = "Comuna Tala",
//    FullName = "Junta Comuna Tala",
//    Source = "IGN",
//    Category = "Junta",
//    Longitude = -58.4375906084751,
//    Latitude = -32.5925154307621,
//},
//new Municipality()
//{
//    Id = 740049,
//    Name = "Concarán",
//    FullName = "Municipality Concarán",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -65.2385006221038,
//    Latitude = -32.564830869466,
//},
//new Municipality()
//{
//    Id = 900035,
//    Name = "Concepción",
//    FullName = "Municipality Concepción",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -65.612698841403,
//    Latitude = -27.3447468902026,
//},
//new Municipality()
//{
//    Id = 540126,
//    Name = "Concepción de la Sierra",
//    FullName = "Municipality Concepción de la Sierra",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -55.5161642960578,
//    Latitude = -27.9975106088471,
//},
//new Municipality()
//{
//    Id = 220007,
//    Name = "Concepción del Bermejo",
//    FullName = "Municipality Concepción del Bermejo",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -60.9140113621832,
//    Latitude = -26.436938789105,
//},
//new Municipality()
//{
//    Id = 300427,
//    Name = "Concepción del Uruguay",
//    FullName = "Municipality Concepción del Uruguay",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -58.2821726317446,
//    Latitude = -32.4616997675992,
//},
//new Municipality()
//{
//    Id = 180042,
//    Name = "Concepción del Yaguareté Corá",
//    FullName = "Municipality Concepción del Yaguareté Corá",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -58.0315854569809,
//    Latitude = -28.5085687298947,
//},
//new Municipality()
//{
//    Id = 300042,
//    Name = "Concordia",
//    FullName = "Municipality Concordia",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -58.0342282993041,
//    Latitude = -31.3439911542353,
//},
//new Municipality()
//{
//    Id = 420098,
//    Name = "Conhelo",
//    FullName = "Municipality Conhelo",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -64.6068637777027,
//    Latitude = -35.9895788985957,
//},
//new Municipality()
//{
//    Id = 142889,
//    Name = "Conlara",
//    FullName = "Comuna Conlara",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -65.1662653577112,
//    Latitude = -32.0892748148358,
//},
//new Municipality()
//{
//    Id = 300140,
//    Name = "Conscripto Bernardi",
//    FullName = "Municipality Conscripto Bernardi",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -59.1064287806207,
//    Latitude = -31.0259639410861,
//},
//new Municipality()
//{
//    Id = 823526,
//    Name = "Constanza",
//    FullName = "Comuna Constanza",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -61.3044646745223,
//    Latitude = -30.6503841416816,
//},
//new Municipality()
//{
//    Id = 620140,
//    Name = "Contralmirante Cordero",
//    FullName = "Municipality Contralmirante Cordero",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -68.1185635387972,
//    Latitude = -38.7237820651806,
//},
//new Municipality()
//{
//    Id = 142280,
//    Name = "Copacabana",
//    FullName = "Comuna Copacabana",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -64.5015919158185,
//    Latitude = -30.6442603235698,
//},
//new Municipality()
//{
//    Id = 386161,
//    Name = "Coranzuli",
//    FullName = "Comisión Coranzuli",
//    Source = "IGN",
//    Category = "Comisión",
//    Longitude = -66.6145554693078,
//    Latitude = -23.1948672048368,
//},
//new Municipality()
//{
//    Id = 260070,
//    Name = "Corcovado",
//    FullName = "Municipality Corcovado",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -71.457093661324,
//    Latitude = -43.517929877381,
//},
//new Municipality()
//{
//    Id = 140077,
//    Name = "Córdoba",
//    FullName = "Municipality Córdoba",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -64.1832233454368,
//    Latitude = -31.4170520006004,
//},
//new Municipality()
//{
//    Id = 820245,
//    Name = "Coronda",
//    FullName = "Municipality Coronda",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -60.86643137469,
//    Latitude = -31.9806759524685,
//},
//new Municipality()
//{
//    Id = 823988,
//    Name = "Coronel Arnold",
//    FullName = "Comuna Coronel Arnold",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -60.9718538087994,
//    Latitude = -33.097318222927,
//},
//new Municipality()
//{
//    Id = 140805,
//    Name = "Coronel Baigorria",
//    FullName = "Municipality Coronel Baigorria",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -64.3679739325012,
//    Latitude = -32.8535584171106,
//},
//new Municipality()
//{
//    Id = 620035,
//    Name = "Coronel Belisle",
//    FullName = "Municipality Coronel Belisle",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -65.9755069949983,
//    Latitude = -39.2062279201652,
//},
//new Municipality()
//{
//    Id = 823393,
//    Name = "Coronel Bogado",
//    FullName = "Comuna Coronel Bogado",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -60.5882072319938,
//    Latitude = -33.3068723984299,
//},
//new Municipality()
//{
//    Id = 60182,
//    Name = "Coronel de Marina Leonardo Rosales",
//    FullName = "Municipality Coronel de Marina Leonardo Rosales",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -61.8355844196542,
//    Latitude = -38.8490773280679,
//},
//new Municipality()
//{
//    Id = 823470,
//    Name = "Coronel Domínguez",
//    FullName = "Comuna Coronel Domínguez",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -60.7384468170916,
//    Latitude = -33.1910836736566,
//},
//new Municipality()
//{
//    Id = 60189,
//    Name = "Coronel Dorrego",
//    FullName = "Municipality Coronel Dorrego",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -61.0955505728699,
//    Latitude = -38.6708176079735,
//},
//new Municipality()
//{
//    Id = 220308,
//    Name = "Coronel Du Graty",
//    FullName = "Municipality Coronel Du Graty",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -60.8947185609069,
//    Latitude = -27.7491034495323,
//},
//new Municipality()
//{
//    Id = 822203,
//    Name = "Coronel Fraga",
//    FullName = "Comuna Coronel Fraga",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -61.9272549652368,
//    Latitude = -31.1787290544084,
//},
//new Municipality()
//{
//    Id = 420105,
//    Name = "Coronel Hilario Lagos",
//    FullName = "Municipality Coronel Hilario Lagos",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -63.8584598544233,
//    Latitude = -35.0812402407492,
//},
//new Municipality()
//{
//    Id = 140812,
//    Name = "Coronel Moldes",
//    FullName = "Municipality Coronel Moldes",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -64.5957374156971,
//    Latitude = -33.6213761643601,
//},
//new Municipality()
//{
//    Id = 660231,
//    Name = "Coronel Moldes",
//    FullName = "Municipality Coronel Moldes",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -65.4145973633781,
//    Latitude = -25.2936788500719,
//},
//new Municipality()
//{
//    Id = 60196,
//    Name = "Coronel Pringles",
//    FullName = "Municipality Coronel Pringles",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -61.2644174529925,
//    Latitude = -38.1479172688233,
//},
//new Municipality()
//{
//    Id = 60203,
//    Name = "Coronel Suárez",
//    FullName = "Municipality Coronel Suárez",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -61.8890922422101,
//    Latitude = -37.5348562500728,
//},
//new Municipality()
//{
//    Id = 540427,
//    Name = "Corpus Christi",
//    FullName = "Municipality Corpus Christi",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -55.5070851678904,
//    Latitude = -27.1463492890879,
//},
//new Municipality()
//{
//    Id = 140518,
//    Name = "Corral de Bustos Ifflinger",
//    FullName = "Municipality Corral de Bustos Ifflinger",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -62.1962096731034,
//    Latitude = -33.279888011005,
//},
//new Municipality()
//{
//    Id = 100070,
//    Name = "Corral Quemado",
//    FullName = "Municipality Corral Quemado",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -67.0146123598012,
//    Latitude = -26.9820584703085,
//},
//new Municipality()
//{
//    Id = 141435,
//    Name = "Corralito",
//    FullName = "Municipality Corralito",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -64.1871324186177,
//    Latitude = -32.0255900646531,
//},
//new Municipality()
//{
//    Id = 822903,
//    Name = "Correa",
//    FullName = "Comuna Correa",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -61.2556105339406,
//    Latitude = -32.8661284216605,
//},
//new Municipality()
//{
//    Id = 180021,
//    Name = "Corrientes",
//    FullName = "Municipality Corrientes",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -58.7708839553989,
//    Latitude = -27.4938209223809,
//},
//new Municipality()
//{
//    Id = 746070,
//    Name = "Cortaderas",
//    FullName = "Comisión Cortaderas",
//    Source = "IGN",
//    Category = "Comisión",
//    Longitude = -64.993277604739,
//    Latitude = -32.5179881649691,
//},
//new Municipality()
//{
//    Id = 220133,
//    Name = "Corzuela",
//    FullName = "Municipality Corzuela",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -61.0713548620948,
//    Latitude = -26.8478484649713,
//},
//new Municipality()
//{
//    Id = 140679,
//    Name = "Cosquín",
//    FullName = "Municipality Cosquín",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -64.6076437684247,
//    Latitude = -31.2314401876293,
//},
//new Municipality()
//{
//    Id = 309105,
//    Name = "Costa Grande",
//    FullName = "Junta Costa Grande",
//    Source = "IGN",
//    Category = "Junta",
//    Longitude = -60.4709754419162,
//    Latitude = -32.2034401533252,
//},
//new Municipality()
//{
//    Id = 141008,
//    Name = "Costa Sacate",
//    FullName = "Municipality Costa Sacate",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -63.7622771614346,
//    Latitude = -31.6470824674008,
//},
//new Municipality()
//{
//    Id = 309325,
//    Name = "Costa San Antonio",
//    FullName = "Junta Costa San Antonio",
//    Source = "IGN",
//    Category = "Junta",
//    Longitude = -59.0646990703946,
//    Latitude = -32.5799505695209,
//},
//new Municipality()
//{
//    Id = 309330,
//    Name = "Costa Uruguay Norte",
//    FullName = "Junta Costa Uruguay Norte",
//    Source = "IGN",
//    Category = "Junta",
//    Longitude = -58.3445031181693,
//    Latitude = -32.929240189942,
//},
//new Municipality()
//{
//    Id = 309335,
//    Name = "Costa Uruguay Sur",
//    FullName = "Junta Costa Uruguay Sur",
//    Source = "IGN",
//    Category = "Junta",
//    Longitude = -58.5361281020757,
//    Latitude = -33.1083814414534,
//},
//new Municipality()
//{
//    Id = 220462,
//    Name = "Cote Lai",
//    FullName = "Municipality Cote Lai",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -59.5670373631433,
//    Latitude = -27.6896128860095,
//},
//new Municipality()
//{
//    Id = 585133,
//    Name = "Covunco Abajo",
//    FullName = "Comisión Covunco Abajo",
//    Source = "IGN",
//    Category = "Comisión",
//    Longitude = -69.69164928854,
//    Latitude = -38.6166868451883,
//},
//new Municipality()
//{
//    Id = 585049,
//    Name = "Coyuco - Cochico",
//    FullName = "Comisión Coyuco - Cochico",
//    Source = "IGN",
//    Category = "Comisión",
//    Longitude = -70.2493063662083,
//    Latitude = -36.5418719278279,
//},
//new Municipality()
//{
//    Id = 300301,
//    Name = "Crespo",
//    FullName = "Municipality Crespo",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -60.3113606375153,
//    Latitude = -32.0245336968721,
//},
//new Municipality()
//{
//    Id = 824079,
//    Name = "Crispi",
//    FullName = "Comuna Crispi",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -62.0117919555162,
//    Latitude = -31.8051981594587,
//},
//new Municipality()
//{
//    Id = 309525,
//    Name = "Crucesitas Octava",
//    FullName = "Junta Crucesitas Octava",
//    Source = "IGN",
//    Category = "Junta",
//    Longitude = -59.4890118562238,
//    Latitude = -32.0152586847179,
//},
//new Municipality()
//{
//    Id = 309530,
//    Name = "Crucesitas Séptima",
//    FullName = "Junta Crucesitas Séptima",
//    Source = "IGN",
//    Category = "Junta",
//    Longitude = -59.8479156831995,
//    Latitude = -31.9457200717097,
//},
//new Municipality()
//{
//    Id = 309535,
//    Name = "Crucesitas Tercera",
//    FullName = "Junta Crucesitas Tercera",
//    Source = "IGN",
//    Category = "Junta",
//    Longitude = -59.6978922726366,
//    Latitude = -32.1243991914545,
//},
//new Municipality()
//{
//    Id = 140525,
//    Name = "Cruz Alta",
//    FullName = "Municipality Cruz Alta",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -61.8114005865518,
//    Latitude = -33.0062669805096,
//},
//new Municipality()
//{
//    Id = 142147,
//    Name = "Cruz de Caña",
//    FullName = "Comuna Cruz de Caña",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -64.9475909508309,
//    Latitude = -31.0828883237064,
//},
//new Municipality()
//{
//    Id = 180189,
//    Name = "Cruz de los Milagros",
//    FullName = "Municipality Cruz de los Milagros",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -59.0819817115913,
//    Latitude = -28.8459846411588,
//},
//new Municipality()
//{
//    Id = 140182,
//    Name = "Cruz del Eje",
//    FullName = "Municipality Cruz del Eje",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -64.7749805365374,
//    Latitude = -30.7457001539119,
//},
//new Municipality()
//{
//    Id = 309340,
//    Name = "Cuchilla Redonda",
//    FullName = "Junta Cuchilla Redonda",
//    Source = "IGN",
//    Category = "Junta",
//    Longitude = -59.1579118935291,
//    Latitude = -33.0728772631768,
//},
//new Municipality()
//{
//    Id = 425042,
//    Name = "Cuchillo Co",
//    FullName = "Comisión Cuchillo Co",
//    Source = "IGN",
//    Category = "Comisión",
//    Longitude = -64.8154556410667,
//    Latitude = -38.2880644808571,
//},
//new Municipality()
//{
//    Id = 142490,
//    Name = "Cuesta Blanca",
//    FullName = "Comuna Cuesta Blanca",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -64.5984326274193,
//    Latitude = -31.485021397287,
//},
//new Municipality()
//{
//    Id = 823050,
//    Name = "Cululú",
//    FullName = "Comuna Cululú",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -60.9262185029339,
//    Latitude = -31.2478117036458,
//},
//new Municipality()
//{
//    Id = 823533,
//    Name = "Curupaity",
//    FullName = "Comuna Curupaity",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -61.6523661988347,
//    Latitude = -30.3877590159566,
//},
//new Municipality()
//{
//    Id = 180063,
//    Name = "Curuzú Cuatiá",
//    FullName = "Municipality Curuzú Cuatiá",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -58.2786709663327,
//    Latitude = -29.6843064810562,
//},
//new Municipality()
//{
//    Id = 268014,
//    Name = "Cushamen",
//    FullName = "Comuna Cushamen",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -70.6587711745075,
//    Latitude = -42.1630600944267,
//},
//new Municipality()
//{
//    Id = 386140,
//    Name = "Cusi Cusi",
//    FullName = "Comisión Cusi Cusi",
//    Source = "IGN",
//    Category = "Comisión",
//    Longitude = -66.7410340633169,
//    Latitude = -22.4920794746387,
//},
//new Municipality()
//{
//    Id = 580049,
//    Name = "Cutral Co",
//    FullName = "Municipality Cutral Co",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -69.2541458274133,
//    Latitude = -38.9398936598766,
//},
//new Municipality()
//{
//    Id = 60231,
//    Name = "Daireaux",
//    FullName = "Municipality Daireaux",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -61.8912495526098,
//    Latitude = -36.6408692174859,
//},
//new Municipality()
//{
//    Id = 141442,
//    Name = "Dalmacio Vélez",
//    FullName = "Municipality Dalmacio Vélez",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -63.5838307311574,
//    Latitude = -32.6124531244939,
//},
//new Municipality()
//{
//    Id = 620042,
//    Name = "Darwin",
//    FullName = "Municipality Darwin",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -65.7650470201611,
//    Latitude = -39.2156639384159,
//},
//new Municipality()
//{
//    Id = 140371,
//    Name = "Deán Funes",
//    FullName = "Municipality Deán Funes",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -64.3546756378304,
//    Latitude = -30.4227482302615,
//},
//new Municipality()
//{
//    Id = 140217,
//    Name = "Del Campillo",
//    FullName = "Municipality Del Campillo",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -64.5317794477809,
//    Latitude = -34.3738504142087,
//},
//new Municipality()
//{
//    Id = 908084,
//    Name = "Delfín Gallo",
//    FullName = "Comuna Delfín Gallo",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -65.0611283648018,
//    Latitude = -26.8489596016316,
//},
//new Municipality()
//{
//    Id = 740108,
//    Name = "Desaguadero",
//    FullName = "Municipality Desaguadero",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -67.0843387509352,
//    Latitude = -33.2931116729437,
//},
//new Municipality()
//{
//    Id = 141379,
//    Name = "Despeñaderos",
//    FullName = "Municipality Despeñaderos",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -64.3037279336142,
//    Latitude = -31.8023733961723,
//},
//new Municipality()
//{
//    Id = 823764,
//    Name = "Desvío Arijón",
//    FullName = "Comuna Desvío Arijón",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -60.8689041844284,
//    Latitude = -31.8625427633772,
//},
//new Municipality()
//{
//    Id = 141225,
//    Name = "Devoto",
//    FullName = "Municipality Devoto",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -62.304879233785,
//    Latitude = -31.4054517995146,
//},
//new Municipality()
//{
//    Id = 300084,
//    Name = "Diamante",
//    FullName = "Municipality Diamante",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -60.5811435799152,
//    Latitude = -32.0976979508439,
//},
//new Municipality()
//{
//    Id = 823771,
//    Name = "Díaz",
//    FullName = "Comuna Díaz",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -61.0760881361809,
//    Latitude = -32.3772801322415,
//},
//new Municipality()
//{
//    Id = 822637,
//    Name = "Diego de Alvear",
//    FullName = "Comuna Diego de Alvear",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -62.1452517061087,
//    Latitude = -34.3123018672741,
//},
//new Municipality()
//{
//    Id = 142651,
//    Name = "Diego de Rojas",
//    FullName = "Comuna Diego de Rojas",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -63.341251457671,
//    Latitude = -31.0276086920171,
//},
//new Municipality()
//{
//    Id = 620273,
//    Name = "Dina Huapi",
//    FullName = "Municipality Dina Huapi",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -71.1517255115561,
//    Latitude = -41.078355997763,
//},
//new Municipality()
//{
//    Id = 143001,
//    Name = "Dique Chico",
//    FullName = "Comuna Dique Chico",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -64.3531607957159,
//    Latitude = -31.7181315346149,
//},
//new Municipality()
//{
//    Id = 268028,
//    Name = "Dique Florentino Ameghino",
//    FullName = "Comuna Dique Florentino Ameghino",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -66.4938176077617,
//    Latitude = -43.6946453652295,
//},
//new Municipality()
//{
//    Id = 309230,
//    Name = "Distrito Chañar",
//    FullName = "Junta Distrito Chañar",
//    Source = "IGN",
//    Category = "Junta",
//    Longitude = -59.0193737962562,
//    Latitude = -30.2916296152936,
//},
//new Municipality()
//{
//    Id = 309540,
//    Name = "Distrito Chiqueros",
//    FullName = "Junta Distrito Chiqueros",
//    Source = "IGN",
//    Category = "Junta",
//    Longitude = -59.5409715803752,
//    Latitude = -32.17659835981,
//},
//new Municipality()
//{
//    Id = 309275,
//    Name = "Distrito Cuarto",
//    FullName = "Junta Distrito Cuarto",
//    Source = "IGN",
//    Category = "Junta",
//    Longitude = -59.6275781942435,
//    Latitude = -32.704403479775,
//},
//new Municipality()
//{
//    Id = 309195,
//    Name = "Distrito Diego López",
//    FullName = "Junta Distrito Diego López",
//    Source = "IGN",
//    Category = "Junta",
//    Longitude = -58.9029269506144,
//    Latitude = -31.1126245990494,
//},
//new Municipality()
//{
//    Id = 309885,
//    Name = "Distrito Pajonal",
//    FullName = "Junta Distrito Pajonal",
//    Source = "IGN",
//    Category = "Junta",
//    Longitude = -60.2850123086421,
//    Latitude = -32.4343342594089,
//},
//new Municipality()
//{
//    Id = 309280,
//    Name = "Distrito Primero",
//    FullName = "Junta Distrito Primero",
//    Source = "IGN",
//    Category = "Junta",
//    Longitude = -59.3771188067183,
//    Latitude = -33.0830482648582,
//},
//new Municipality()
//{
//    Id = 309285,
//    Name = "Distrito Quinto",
//    FullName = "Junta Distrito Quinto",
//    Source = "IGN",
//    Category = "Junta",
//    Longitude = -59.6971481967447,
//    Latitude = -32.6544461457754,
//},
//new Municipality()
//{
//    Id = 309543,
//    Name = "Distrito Sauce",
//    FullName = "Junta de Gobierno Distrito Sauce",
//    Source = "IGN",
//    Category = "Junta de Gobierno",
//    Longitude = -59.6115136082433,
//    Latitude = -32.4898176927768,
//},
//new Municipality()
//{
//    Id = 302411,
//    Name = "Distrito Sexto",
//    FullName = "Junta Distrito Sexto",
//    Source = "IGN",
//    Category = "Junta",
//    Longitude = -59.7560124905455,
//    Latitude = -32.8041584778779,
//},
//new Municipality()
//{
//    Id = 309670,
//    Name = "Distrito Tala",
//    FullName = "Junta Distrito Tala",
//    Source = "IGN",
//    Category = "Junta",
//    Longitude = -59.9973011696223,
//    Latitude = -31.7150185880121,
//},
//new Municipality()
//{
//    Id = 309345,
//    Name = "Distrito Talitas",
//    FullName = "Junta Distrito Talitas",
//    Source = "IGN",
//    Category = "Junta",
//    Longitude = -59.071647165984,
//    Latitude = -32.8981161862654,
//},
//new Municipality()
//{
//    Id = 420112,
//    Name = "Doblas",
//    FullName = "Municipality Doblas",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -64.0057006731616,
//    Latitude = -37.1392987027127,
//},
//new Municipality()
//{
//    Id = 268098,
//    Name = "Doctor Ricardo Rojas",
//    FullName = "Comuna Doctor Ricardo Rojas",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -71.0372325754432,
//    Latitude = -45.5777033871546,
//},
//new Municipality()
//{
//    Id = 260091,
//    Name = "Dolavon",
//    FullName = "Municipality Dolavon",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -65.6836091125421,
//    Latitude = -43.3329711153712,
//},
//new Municipality()
//{
//    Id = 60238,
//    Name = "Dolores",
//    FullName = "Municipality Dolores",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -57.6319261244954,
//    Latitude = -36.3989376730385,
//},
//new Municipality()
//{
//    Id = 309545,
//    Name = "Don Cristóbal I",
//    FullName = "Junta Don Cristóbal I",
//    Source = "IGN",
//    Category = "Junta",
//    Longitude = -59.835111111394,
//    Latitude = -32.1774631757219,
//},
//new Municipality()
//{
//    Id = 302780,
//    Name = "Don Cristóbal II",
//    FullName = "Junta Don Cristóbal II",
//    Source = "IGN",
//    Category = "Junta",
//    Longitude = -60.0141432779901,
//    Latitude = -32.0586042470082,
//},
//new Municipality()
//{
//    Id = 420116,
//    Name = "Dorila",
//    FullName = "Municipality Dorila",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -63.7458253289186,
//    Latitude = -35.792273298645,
//},
//new Municipality()
//{
//    Id = 540266,
//    Name = "Dos Arroyos",
//    FullName = "Municipality Dos Arroyos",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -55.2673380242626,
//    Latitude = -27.7059580525408,
//},
//new Municipality()
//{
//    Id = 540049,
//    Name = "Dos de Mayo",
//    FullName = "Municipality Dos de Mayo",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -54.61143274302,
//    Latitude = -27.0916174132864,
//},
//new Municipality()
//{
//    Id = 823540,
//    Name = "Dos Rosas y La Legua",
//    FullName = "Comuna Dos Rosas y La Legua",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -61.8892178896325,
//    Latitude = -30.6428645248116,
//},
//new Municipality()
//{
//    Id = 268147,
//    Name = "Dr. Atilio Oscar Viglione",
//    FullName = "Comuna Dr. Atilio Oscar Viglione",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -71.6794040315732,
//    Latitude = -44.1731028533014,
//},
//new Municipality()
//{
//    Id = 303091,
//    Name = "Durazno",
//    FullName = "Junta Durazno",
//    Source = "IGN",
//    Category = "Junta",
//    Longitude = -59.2702870645111,
//    Latitude = -31.9943356124088,
//},
//new Municipality()
//{
//    Id = 420119,
//    Name = "Eduardo Castex",
//    FullName = "Municipality Eduardo Castex",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -64.3296829485929,
//    Latitude = -35.9371265801175,
//},
//new Municipality()
//{
//    Id = 822210,
//    Name = "Egusquiza",
//    FullName = "Comuna Egusquiza",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -61.6230238916174,
//    Latitude = -31.0944039294173,
//},
//new Municipality()
//{
//    Id = 380091,
//    Name = "El Aguilar",
//    FullName = "Municipality El Aguilar",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -65.6379956208247,
//    Latitude = -23.2110620393234,
//},
//new Municipality()
//{
//    Id = 540301,
//    Name = "El Alcázar",
//    FullName = "Municipality El Alcázar",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -54.7771362135563,
//    Latitude = -26.843607642473,
//},
//new Municipality()
//{
//    Id = 100147,
//    Name = "El Alto",
//    FullName = "Municipality El Alto",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -65.4307961238646,
//    Latitude = -28.4245673220056,
//},
//new Municipality()
//{
//    Id = 141232,
//    Name = "El Arañado",
//    FullName = "Municipality El Arañado",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -62.8946381603767,
//    Latitude = -31.7420994285225,
//},
//new Municipality()
//{
//    Id = 822777,
//    Name = "El Araza",
//    FullName = "Comuna El Araza",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -59.9920128000803,
//    Latitude = -29.1213769640902,
//},
//new Municipality()
//{
//    Id = 620070,
//    Name = "El Bolsón",
//    FullName = "Municipality El Bolsón",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -71.5303311051868,
//    Latitude = -41.8630560328518,
//},
//new Municipality()
//{
//    Id = 660112,
//    Name = "El Bordo",
//    FullName = "Municipality El Bordo",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -65.1594593574336,
//    Latitude = -24.5872465457022,
//},
//new Municipality()
//{
//    Id = 908091,
//    Name = "El Bracho y El Cevilar",
//    FullName = "Comuna El Bracho y El Cevilar",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -65.1539522219053,
//    Latitude = -26.9800584321283,
//},
//new Municipality()
//{
//    Id = 140185,
//    Name = "El Brete",
//    FullName = "Municipality El Brete",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -64.8798435893616,
//    Latitude = -30.6562768257355,
//},
//new Municipality()
//{
//    Id = 908602,
//    Name = "El Cadillal",
//    FullName = "Comuna El Cadillal",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -65.2176159936699,
//    Latitude = -26.6034282128442,
//},
//new Municipality()
//{
//    Id = 380056,
//    Name = "El Carmen",
//    FullName = "Municipality El Carmen",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -65.2731649354849,
//    Latitude = -24.414946947666,
//},
//new Municipality()
//{
//    Id = 660098,
//    Name = "El Carril",
//    FullName = "Municipality El Carril",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -65.4040112319134,
//    Latitude = -25.1277473955273,
//},
//new Municipality()
//{
//    Id = 908399,
//    Name = "El Cercado",
//    FullName = "Comuna El Cercado",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -65.5757616015617,
//    Latitude = -27.1910533081184,
//},
//new Municipality()
//{
//    Id = 142364,
//    Name = "El Chacho",
//    FullName = "Comuna El Chacho",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -65.4594021206252,
//    Latitude = -30.8086914691264,
//},
//new Municipality()
//{
//    Id = 908014,
//    Name = "El Chañar",
//    FullName = "Comuna El Chañar",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -65.0116544214983,
//    Latitude = -26.7585099944593,
//},
//new Municipality()
//{
//    Id = 580175,
//    Name = "El Cholar",
//    FullName = "Municipality El Cholar",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -70.6873431812617,
//    Latitude = -37.4558329459089,
//},
//new Municipality()
//{
//    Id = 340259,
//    Name = "El Chorro",
//    FullName = "Municipality El Chorro",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -62.3006586293614,
//    Latitude = -23.1836667199884,
//},
//new Municipality()
//{
//    Id = 302287,
//    Name = "El Cimarrón",
//    FullName = "Junta El Cimarrón",
//    Source = "IGN",
//    Category = "Junta",
//    Longitude = -59.0084121171791,
//    Latitude = -30.9473018475465,
//},
//new Municipality()
//{
//    Id = 340224,
//    Name = "El Colorado",
//    FullName = "Municipality El Colorado",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -59.3525192427621,
//    Latitude = -26.2786564290992,
//},
//new Municipality()
//{
//    Id = 386259,
//    Name = "El Cóndor",
//    FullName = "Comisión El Cóndor",
//    Source = "IGN",
//    Category = "Comisión",
//    Longitude = -65.3797467777214,
//    Latitude = -22.4139678532696,
//},
//new Municipality()
//{
//    Id = 142658,
//    Name = "El Crispín",
//    FullName = "Comuna El Crispín",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -63.6071854343479,
//    Latitude = -31.0189797076703,
//},
//new Municipality()
//{
//    Id = 340168,
//    Name = "El Espinillo",
//    FullName = "Municipality El Espinillo",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -58.5647875858739,
//    Latitude = -25.0004660450385,
//},
//new Municipality()
//{
//    Id = 141239,
//    Name = "El Fortín",
//    FullName = "Municipality El Fortín",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -62.3017073883342,
//    Latitude = -31.9696658576857,
//},
//new Municipality()
//{
//    Id = 386098,
//    Name = "El Fuerte",
//    FullName = "Comisión El Fuerte",
//    Source = "IGN",
//    Category = "Comisión",
//    Longitude = -64.4578030674194,
//    Latitude = -24.3218406048748,
//},
//new Municipality()
//{
//    Id = 660259,
//    Name = "El Galpón",
//    FullName = "Municipality El Galpón",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -64.3348772620854,
//    Latitude = -25.4374131493412,
//},
//new Municipality()
//{
//    Id = 309205,
//    Name = "El Gramiyal",
//    FullName = "Junta El Gramiyal",
//    Source = "IGN",
//    Category = "Junta",
//    Longitude = -59.0802942666956,
//    Latitude = -31.2006829629048,
//},
//new Municipality()
//{
//    Id = 260021,
//    Name = "El Hoyo",
//    FullName = "Municipality El Hoyo",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -71.4939336193378,
//    Latitude = -42.1082232091107,
//},
//new Municipality()
//{
//    Id = 580182,
//    Name = "El Huecú",
//    FullName = "Municipality El Huecú",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -70.5833484818072,
//    Latitude = -37.6497782492166,
//},
//new Municipality()
//{
//    Id = 660203,
//    Name = "El Jardín",
//    FullName = "Municipality El Jardín",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -65.4579765523286,
//    Latitude = -26.0511833504037,
//},
//new Municipality()
//{
//    Id = 260028,
//    Name = "El Maitén",
//    FullName = "Municipality El Maitén",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -71.1509289608032,
//    Latitude = -42.1227715249574,
//},
//new Municipality()
//{
//    Id = 908357,
//    Name = "El Manantial",
//    FullName = "Comuna El Manantial",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -65.3221667991918,
//    Latitude = -26.8395423626316,
//},
//new Municipality()
//{
//    Id = 142105,
//    Name = "El Manzano",
//    FullName = "Comuna El Manzano",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -64.3382836003479,
//    Latitude = -31.0820615295911,
//},
//new Municipality()
//{
//    Id = 908280,
//    Name = "El Mojón",
//    FullName = "Comuna El Mojón",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -64.8962995869492,
//    Latitude = -27.217747574116,
//},
//new Municipality()
//{
//    Id = 908581,
//    Name = "El Mollar",
//    FullName = "Comuna El Mollar",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -65.7634391978212,
//    Latitude = -26.9511678391337,
//},
//new Municipality()
//{
//    Id = 386179,
//    Name = "El Moreno",
//    FullName = "Comisión El Moreno",
//    Source = "IGN",
//    Category = "Comisión",
//    Longitude = -65.8123400709796,
//    Latitude = -23.7108518983613,
//},
//new Municipality()
//{
//    Id = 908098,
//    Name = "El Naranjito",
//    FullName = "Comuna El Naranjito",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -65.0736139973329,
//    Latitude = -26.9938794617517,
//},
//new Municipality()
//{
//    Id = 908021,
//    Name = "El Naranjo y El Sunchal",
//    FullName = "Comuna El Naranjo y El Sunchal",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -65.0681949978123,
//    Latitude = -26.5960891274168,
//},
//new Municipality()
//{
//    Id = 302927,
//    Name = "El Palenque",
//    FullName = "Junta El Palenque",
//    Source = "IGN",
//    Category = "Junta",
//    Longitude = -60.1643235162248,
//    Latitude = -31.6335460281569,
//},
//new Municipality()
//{
//    Id = 309680,
//    Name = "El Pingo",
//    FullName = "Municipality El Pingo",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -59.8754559672913,
//    Latitude = -31.5826469791145,
//},
//new Municipality()
//{
//    Id = 386119,
//    Name = "El Piquete",
//    FullName = "Comisión El Piquete",
//    Source = "IGN",
//    Category = "Comisión",
//    Longitude = -64.5780376206816,
//    Latitude = -24.0325512929294,
//},
//new Municipality()
//{
//    Id = 908462,
//    Name = "El Polear y Los Córdoba",
//    FullName = "Comuna El Polear y Los Córdoba",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -65.5729937637998,
//    Latitude = -27.5044215515057,
//},
//new Municipality()
//{
//    Id = 660350,
//    Name = "El Potrero",
//    FullName = "Municipality El Potrero",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -64.5703701348667,
//    Latitude = -25.903456796786,
//},
//new Municipality()
//{
//    Id = 908028,
//    Name = "El Puestito",
//    FullName = "Comuna El Puestito",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -64.7690077069276,
//    Latitude = -26.3434709448865,
//},
//new Municipality()
//{
//    Id = 660014,
//    Name = "El Quebrachal",
//    FullName = "Municipality El Quebrachal",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -63.5712408089496,
//    Latitude = -25.3946585262363,
//},
//new Municipality()
//{
//    Id = 309450,
//    Name = "El Quebracho",
//    FullName = "Junta El Quebracho",
//    Source = "IGN",
//    Category = "Junta",
//    Longitude = -59.687205310542,
//    Latitude = -30.9742406806374,
//},
//new Municipality()
//{
//    Id = 822784,
//    Name = "El Rabón",
//    FullName = "Comuna El Rabón",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -59.2515639710428,
//    Latitude = -28.213162356437,
//},
//new Municipality()
//{
//    Id = 142315,
//    Name = "El Rastreador",
//    FullName = "Comuna El Rastreador",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -63.5399472201016,
//    Latitude = -33.6654575921611,
//},
//new Municipality()
//{
//    Id = 309045,
//    Name = "El Redomón",
//    FullName = "Junta El Redomón",
//    Source = "IGN",
//    Category = "Junta",
//    Longitude = -58.3783911623542,
//    Latitude = -31.0316959257872,
//},
//new Municipality()
//{
//    Id = 143211,
//    Name = "El Rodeo",
//    FullName = "Comuna El Rodeo",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -63.8576472993799,
//    Latitude = -30.1647579225083,
//},
//new Municipality()
//{
//    Id = 100007,
//    Name = "El Rodeo",
//    FullName = "Municipality El Rodeo",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -65.9470179775985,
//    Latitude = -28.2431146257361,
//},
//new Municipality()
//{
//    Id = 908231,
//    Name = "El Sacrificio",
//    FullName = "Comuna El Sacrificio",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -65.638295918099,
//    Latitude = -27.6934741887431,
//},
//new Municipality()
//{
//    Id = 585112,
//    Name = "El Sauce",
//    FullName = "Comisión El Sauce",
//    Source = "IGN",
//    Category = "Comisión",
//    Longitude = -69.5258646816178,
//    Latitude = -39.4816153694996,
//},
//new Municipality()
//{
//    Id = 220168,
//    Name = "El Sauzalito",
//    FullName = "Municipality El Sauzalito",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -61.648138218842,
//    Latitude = -24.654311226095,
//},
//new Municipality()
//{
//    Id = 540196,
//    Name = "El Soberbio",
//    FullName = "Municipality El Soberbio",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -54.1568792924992,
//    Latitude = -27.0791888093883,
//},
//new Municipality()
//{
//    Id = 302638,
//    Name = "El Solar",
//    FullName = "Junta El Solar",
//    Source = "IGN",
//    Category = "Junta",
//    Longitude = -59.6722156610051,
//    Latitude = -31.1761959070547,
//},
//new Municipality()
//{
//    Id = 822791,
//    Name = "El Sombrerito",
//    FullName = "Comuna El Sombrerito",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -59.2773137700825,
//    Latitude = -28.6412656897047,
//},
//new Municipality()
//{
//    Id = 180073,
//    Name = "El Sombrero",
//    FullName = "Municipality El Sombrero",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -58.6686542753163,
//    Latitude = -27.7028729920914,
//},
//new Municipality()
//{
//    Id = 660210,
//    Name = "El Tala",
//    FullName = "Municipality El Tala",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -65.2864048047655,
//    Latitude = -26.0175448171736,
//},
//new Municipality()
//{
//    Id = 380238,
//    Name = "El Talar",
//    FullName = "Municipality El Talar",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -64.2899657115541,
//    Latitude = -23.5769061356858,
//},
//new Municipality()
//{
//    Id = 908035,
//    Name = "El Timbó",
//    FullName = "Comuna El Timbó",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -65.1240893597625,
//    Latitude = -26.6571117272848,
//},
//new Municipality()
//{
//    Id = 141246,
//    Name = "El Tío",
//    FullName = "Municipality El Tío",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -62.8225806131392,
//    Latitude = -31.3889356919298,
//},
//new Municipality()
//{
//    Id = 740039,
//    Name = "El Trapiche",
//    FullName = "Municipality El Trapiche",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -66.0610917870084,
//    Latitude = -33.0307488760936,
//},
//new Municipality()
//{
//    Id = 820308,
//    Name = "El Trébol",
//    FullName = "Municipality El Trébol",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -61.7060904540053,
//    Latitude = -32.2116389999817,
//},
//new Municipality()
//{
//    Id = 740112,
//    Name = "El Volcán",
//    FullName = "Municipality El Volcán",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -66.1474910728703,
//    Latitude = -33.2673739555978,
//},
//new Municipality()
//{
//    Id = 540154,
//    Name = "Eldorado",
//    FullName = "Municipality Eldorado",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -54.6153014553159,
//    Latitude = -26.4223788581272,
//},
//new Municipality()
//{
//    Id = 140819,
//    Name = "Elena",
//    FullName = "Municipality Elena",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -64.3939492510855,
//    Latitude = -32.5699065743136,
//},
//new Municipality()
//{
//    Id = 823057,
//    Name = "Elisa",
//    FullName = "Comuna Elisa",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -61.1094233962704,
//    Latitude = -30.6910583958717,
//},
//new Municipality()
//{
//    Id = 822644,
//    Name = "Elortondo",
//    FullName = "Comuna Elortondo",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -61.5768623551581,
//    Latitude = -33.7743928763854,
//},
//new Municipality()
//{
//    Id = 420126,
//    Name = "Embajador Martini",
//    FullName = "Municipality Embajador Martini",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -64.2940730619049,
//    Latitude = -35.361210878617,
//},
//new Municipality()
//{
//    Id = 140007,
//    Name = "Embalse",
//    FullName = "Municipality Embalse",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -64.3816869058495,
//    Latitude = -32.2156832682067,
//},
//new Municipality()
//{
//    Id = 660133,
//    Name = "Embarcación",
//    FullName = "Municipality Embarcación",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -63.6851032881096,
//    Latitude = -23.2143473520835,
//},
//new Municipality()
//{
//    Id = 822987,
//    Name = "Emilia",
//    FullName = "Comuna Emilia",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -60.7465206017309,
//    Latitude = -31.0545059210226,
//},
//new Municipality()
//{
//    Id = 823064,
//    Name = "Empalme San Carlos",
//    FullName = "Comuna Empalme San Carlos",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -60.8317705317935,
//    Latitude = -31.5479987891126,
//},
//new Municipality()
//{
//    Id = 822441,
//    Name = "Empalme Villa Constitución",
//    FullName = "Comuna Empalme Villa Constitución",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -60.4006220967313,
//    Latitude = -33.2818339399042,
//},
//new Municipality()
//{
//    Id = 180077,
//    Name = "Empedrado",
//    FullName = "Municipality Empedrado",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -58.6650416600243,
//    Latitude = -27.9389895384677,
//},
//new Municipality()
//{
//    Id = 300184,
//    Name = "Enrique Carbó",
//    FullName = "Municipality Enrique Carbó",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -59.0967550787686,
//    Latitude = -33.1620585990918,
//},
//new Municipality()
//{
//    Id = 220315,
//    Name = "Enrique Urién",
//    FullName = "Municipality Enrique Urién",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -60.4529693780671,
//    Latitude = -27.7976163216196,
//},
//new Municipality()
//{
//    Id = 60245,
//    Name = "Ensenada",
//    FullName = "Municipality Ensenada",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -57.9791090925591,
//    Latitude = -34.8421497421871,
//},
//new Municipality()
//{
//    Id = 260035,
//    Name = "Epuyén",
//    FullName = "Municipality Epuyén",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -71.3477379379806,
//    Latitude = -42.2742146687116,
//},
//new Municipality()
//{
//    Id = 908217,
//    Name = "Escaba",
//    FullName = "Comuna Escaba",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -65.8621513524061,
//    Latitude = -27.6302754366499,
//},
//new Municipality()
//{
//    Id = 60252,
//    Name = "Escobar",
//    FullName = "Municipality Escobar",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -58.7711786108508,
//    Latitude = -34.3286828340823,
//},
//new Municipality()
//{
//    Id = 822217,
//    Name = "Esmeralda",
//    FullName = "Comuna Esmeralda",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -62.0005133150622,
//    Latitude = -31.6269644670135,
//},
//new Municipality()
//{
//    Id = 820161,
//    Name = "Esperanza",
//    FullName = "Municipality Esperanza",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -60.8895310818672,
//    Latitude = -31.4385590388415,
//},
//new Municipality()
//{
//    Id = 309685,
//    Name = "Espinillo Norte",
//    FullName = "Junta Espinillo Norte",
//    Source = "IGN",
//    Category = "Junta",
//    Longitude = -60.294725802309,
//    Latitude = -31.8094377229258,
//},
//new Municipality()
//{
//    Id = 260077,
//    Name = "Esquel",
//    FullName = "Municipality Esquel",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -71.3158427579333,
//    Latitude = -42.9105175261124,
//},
//new Municipality()
//{
//    Id = 142665,
//    Name = "Esquina",
//    FullName = "Comuna Esquina",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -63.778770682649,
//    Latitude = -31.0965547596048,
//},
//new Municipality()
//{
//    Id = 180084,
//    Name = "Esquina",
//    FullName = "Municipality Esquina",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -59.2266212679622,
//    Latitude = -29.9337458678514,
//},
//new Municipality()
//{
//    Id = 908287,
//    Name = "Esquina y Mancopa",
//    FullName = "Comuna Esquina y Mancopa",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -65.1888666164635,
//    Latitude = -27.0301137830465,
//},
//new Municipality()
//{
//    Id = 908294,
//    Name = "Estación Aráoz y Tacanas",
//    FullName = "Comuna Estación Aráoz y Tacanas",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -64.8884956577524,
//    Latitude = -27.0973695595429,
//},
//new Municipality()
//{
//    Id = 309110,
//    Name = "Estación Camps",
//    FullName = "Junta Estación Camps",
//    Source = "IGN",
//    Category = "Junta",
//    Longitude = -60.2808094441015,
//    Latitude = -32.1099513570434,
//},
//new Municipality()
//{
//    Id = 822224,
//    Name = "Estación Clucellas",
//    FullName = "Comuna Estación Clucellas",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -61.7126891104404,
//    Latitude = -31.5252590256917,
//},
//new Municipality()
//{
//    Id = 309355,
//    Name = "Estación Escriña",
//    FullName = "Junta Estación Escriña",
//    Source = "IGN",
//    Category = "Junta",
//    Longitude = -58.893319589326,
//    Latitude = -32.6033464998232,
//},
//new Municipality()
//{
//    Id = 140102,
//    Name = "Estación General Paz",
//    FullName = "Municipality Estación General Paz",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -64.1473438921363,
//    Latitude = -31.1228499839105,
//},
//new Municipality()
//{
//    Id = 140105,
//    Name = "Estación Juárez Celman",
//    FullName = "Municipality Estación Juárez Celman",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -64.1793986490353,
//    Latitude = -31.2437846823991,
//},
//new Municipality()
//{
//    Id = 309295,
//    Name = "Estación Lazo",
//    FullName = "Junta Estación Lazo",
//    Source = "IGN",
//    Category = "Junta",
//    Longitude = -59.4203281170489,
//    Latitude = -32.8717026664748,
//},
//new Municipality()
//{
//    Id = 302512,
//    Name = "Estación Parera",
//    FullName = "Junta Estación Parera",
//    Source = "IGN",
//    Category = "Junta",
//    Longitude = -58.8798328713956,
//    Latitude = -32.8029393519327,
//},
//new Municipality()
//{
//    Id = 309920,
//    Name = "Estación Raíces",
//    FullName = "Junta Estación Raíces",
//    Source = "IGN",
//    Category = "Junta",
//    Longitude = -59.203357602747,
//    Latitude = -31.9026104197672,
//},
//new Municipality()
//{
//    Id = 302941,
//    Name = "Estación Sosa",
//    FullName = "Junta Estación Sosa",
//    Source = "IGN",
//    Category = "Junta",
//    Longitude = -59.8676489834887,
//    Latitude = -31.7350267392917,
//},
//new Municipality()
//{
//    Id = 180105,
//    Name = "Estación Torrent",
//    FullName = "Municipality Estación Torrent",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -56.4216775362144,
//    Latitude = -28.816951443081,
//},
//new Municipality()
//{
//    Id = 309050,
//    Name = "Estación Yeruá",
//    FullName = "Junta Estación Yeruá",
//    Source = "IGN",
//    Category = "Junta",
//    Longitude = -58.3306668967016,
//    Latitude = -31.4327776584848,
//},
//new Municipality()
//{
//    Id = 309055,
//    Name = "Estación Yuquerí",
//    FullName = "Junta Estación Yuquerí",
//    Source = "IGN",
//    Category = "Junta",
//    Longitude = -58.1610440111982,
//    Latitude = -31.3542228185363,
//},
//new Municipality()
//{
//    Id = 142371,
//    Name = "Estancia de Guadalupe",
//    FullName = "Comuna Estancia de Guadalupe",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -65.2460012237621,
//    Latitude = -31.1856303095931,
//},
//new Municipality()
//{
//    Id = 740038,
//    Name = "Estancia Grande",
//    FullName = "Municipality Estancia Grande",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -66.1453962235014,
//    Latitude = -33.1581085522857,
//},
//new Municipality()
//{
//    Id = 300049,
//    Name = "Estancia Grande",
//    FullName = "Municipality Estancia Grande",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -58.1620238800989,
//    Latitude = -31.4627661130579,
//},
//new Municipality()
//{
//    Id = 142497,
//    Name = "Estancia Vieja",
//    FullName = "Comuna Estancia Vieja",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -64.5263514335073,
//    Latitude = -31.3861392102136,
//},
//new Municipality()
//{
//    Id = 340098,
//    Name = "Estanislao del Campo",
//    FullName = "Municipality Estanislao del Campo",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -60.1089966071707,
//    Latitude = -25.0637553874606,
//},
//new Municipality()
//{
//    Id = 309460,
//    Name = "Estaquitas",
//    FullName = "Junta Estaquitas",
//    Source = "IGN",
//    Category = "Junta",
//    Longitude = -59.564158569723,
//    Latitude = -30.8375883149231,
//},
//new Municipality()
//{
//    Id = 60260,
//    Name = "Esteban Echeverría",
//    FullName = "Municipality Esteban Echeverría",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -58.4769479291391,
//    Latitude = -34.8312135656244,
//},
//new Municipality()
//{
//    Id = 823281,
//    Name = "Esteban Rams",
//    FullName = "Comuna Esteban Rams",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -61.4715691082062,
//    Latitude = -29.6759725228855,
//},
//new Municipality()
//{
//    Id = 823883,
//    Name = "Esther",
//    FullName = "Comuna Esther",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -60.6059052149218,
//    Latitude = -31.0440868501282,
//},
//new Municipality()
//{
//    Id = 140294,
//    Name = "Etruria",
//    FullName = "Municipality Etruria",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -63.2476339192828,
//    Latitude = -32.9395872460527,
//},
//new Municipality()
//{
//    Id = 142749,
//    Name = "Eufrasio Loza",
//    FullName = "Comuna Eufrasio Loza",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -63.5895362222017,
//    Latitude = -29.9249635677759,
//},
//new Municipality()
//{
//    Id = 822231,
//    Name = "Eusebia y Carolina",
//    FullName = "Comuna Eusebia y Carolina",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -61.8602506810635,
//    Latitude = -30.9415070170746,
//},
//new Municipality()
//{
//    Id = 822238,
//    Name = "Eustolia",
//    FullName = "Comuna Eustolia",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -61.7656861272866,
//    Latitude = -31.5807528856735,
//},
//new Municipality()
//{
//    Id = 60266,
//    Name = "Exaltación de la Cruz",
//    FullName = "Municipality Exaltación de la Cruz",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -59.1559461316119,
//    Latitude = -34.2951342236195,
//},
//new Municipality()
//{
//    Id = 60270,
//    Name = "Ezeiza",
//    FullName = "Municipality Ezeiza",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -58.5647013731149,
//    Latitude = -34.8760968437468,
//},
//new Municipality()
//{
//    Id = 540105,
//    Name = "Fachinal",
//    FullName = "Municipality Fachinal",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -55.7521360069404,
//    Latitude = -27.6681107358352,
//},
//new Municipality()
//{
//    Id = 268105,
//    Name = "Facundo",
//    FullName = "Comuna Facundo",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -69.9689190757892,
//    Latitude = -45.2957790585196,
//},
//new Municipality()
//{
//    Id = 143008,
//    Name = "Falda del Carmen",
//    FullName = "Comuna Falda del Carmen",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -64.4824020119742,
//    Latitude = -31.5761981297001,
//},
//new Municipality()
//{
//    Id = 425063,
//    Name = "Falucho",
//    FullName = "Comisión Falucho",
//    Source = "IGN",
//    Category = "Comisión",
//    Longitude = -64.0782858104092,
//    Latitude = -35.1878951146374,
//},
//new Municipality()
//{
//    Id = 900042,
//    Name = "Famaillá",
//    FullName = "Municipality Famaillá",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -65.4722260970626,
//    Latitude = -26.9788671075693,
//},
//new Municipality()
//{
//    Id = 460049,
//    Name = "Famatina",
//    FullName = "Municipality Famatina",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -67.5592543116776,
//    Latitude = -28.6973536209114,
//},
//new Municipality()
//{
//    Id = 302787,
//    Name = "Febre",
//    FullName = "Junta Febre",
//    Source = "IGN",
//    Category = "Junta",
//    Longitude = -59.8713285023937,
//    Latitude = -32.4836568394763,
//},
//new Municipality()
//{
//    Id = 300112,
//    Name = "Federación",
//    FullName = "Municipality Federación",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -57.9495484846586,
//    Latitude = -31.0509433259803,
//},
//new Municipality()
//{
//    Id = 300147,
//    Name = "Federal",
//    FullName = "Municipality Federal",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -58.7711485682144,
//    Latitude = -30.947547275027,
//},
//new Municipality()
//{
//    Id = 823071,
//    Name = "Felicia",
//    FullName = "Comuna Felicia",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -61.2319201301032,
//    Latitude = -31.2182040726477,
//},
//new Municipality()
//{
//    Id = 180231,
//    Name = "Felipe Yofré",
//    FullName = "Municipality Felipe Yofré",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -58.4042414240622,
//    Latitude = -29.0615164064279,
//},
//new Municipality()
//{
//    Id = 100224,
//    Name = "Fiambalá",
//    FullName = "Municipality Fiambalá",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -68.051273900214,
//    Latitude = -27.3760731699145,
//},
//new Municipality()
//{
//    Id = 822245,
//    Name = "Fidela",
//    FullName = "Comuna Fidela",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -61.7998595299659,
//    Latitude = -31.0524241754991,
//},
//new Municipality()
//{
//    Id = 823400,
//    Name = "Fighiera",
//    FullName = "Comuna Fighiera",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -60.4653854507219,
//    Latitude = -33.2227947553201,
//},
//new Municipality()
//{
//    Id = 820063,
//    Name = "Firmat",
//    FullName = "Municipality Firmat",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -61.4845915556458,
//    Latitude = -33.4467661872323,
//},
//new Municipality()
//{
//    Id = 820095,
//    Name = "Florencia",
//    FullName = "Municipality Florencia",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -59.1446109499756,
//    Latitude = -28.0694518087444,
//},
//new Municipality()
//{
//    Id = 60274,
//    Name = "Florencio Varela",
//    FullName = "Municipality Florencio Varela",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -58.2585548857968,
//    Latitude = -34.8777448240047,
//},
//new Municipality()
//{
//    Id = 60277,
//    Name = "Florentino Ameghino",
//    FullName = "Municipality Florentino Ameghino",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -62.4017162645914,
//    Latitude = -34.874105805522,
//},
//new Municipality()
//{
//    Id = 540476,
//    Name = "Florentino Ameghino",
//    FullName = "Municipality Florentino Ameghino",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -55.0615940731849,
//    Latitude = -27.6952894216663,
//},
//new Municipality()
//{
//    Id = 220399,
//    Name = "Fontana",
//    FullName = "Municipality Fontana",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -59.0471564817208,
//    Latitude = -27.4240293879612,
//},
//new Municipality()
//{
//    Id = 340028,
//    Name = "Formosa",
//    FullName = "Municipality Formosa",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -58.217344420551,
//    Latitude = -26.1958636875285,
//},
//new Municipality()
//{
//    Id = 746175,
//    Name = "Fortín El Patria",
//    FullName = "Comisión Fortín El Patria",
//    Source = "IGN",
//    Category = "Comisión",
//    Longitude = -65.5216731228319,
//    Latitude = -34.7739596252621,
//},
//new Municipality()
//{
//    Id = 345042,
//    Name = "Fortín Lugones",
//    FullName = "Comisión Fortín Lugones",
//    Source = "IGN",
//    Category = "Comisión",
//    Longitude = -59.8298344316784,
//    Latitude = -24.2874111689075,
//},
//new Municipality()
//{
//    Id = 824149,
//    Name = "Fortín Olmos",
//    FullName = "Comuna Fortín Olmos",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -60.6679527392562,
//    Latitude = -28.9886124948497,
//},
//new Municipality()
//{
//    Id = 746182,
//    Name = "Fortuna",
//    FullName = "Comisión Fortuna",
//    Source = "IGN",
//    Category = "Comisión",
//    Longitude = -65.3883623457859,
//    Latitude = -35.1318701277277,
//},
//new Municipality()
//{
//    Id = 746049,
//    Name = "Fraga",
//    FullName = "Comisión Fraga",
//    Source = "IGN",
//    Category = "Comisión",
//    Longitude = -65.8176668184615,
//    Latitude = -33.4675887561782,
//},
//new Municipality()
//{
//    Id = 380133,
//    Name = "Fraile Pintado",
//    FullName = "Municipality Fraile Pintado",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -64.9755293206259,
//    Latitude = -23.9211355823302,
//},
//new Municipality()
//{
//    Id = 823078,
//    Name = "Franck",
//    FullName = "Comuna Franck",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -60.9378478799339,
//    Latitude = -31.5869277209191,
//},
//new Municipality()
//{
//    Id = 820280,
//    Name = "Fray Luis Beltrán",
//    FullName = "Municipality Fray Luis Beltrán",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -60.7339969492365,
//    Latitude = -32.7862746029096,
//},
//new Municipality()
//{
//    Id = 100161,
//    Name = "Fray Mamerto Esquiú",
//    FullName = "Municipality Fray Mamerto Esquiú",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -65.7311908465217,
//    Latitude = -28.3343343529283,
//},
//new Municipality()
//{
//    Id = 141253,
//    Name = "Freyre",
//    FullName = "Municipality Freyre",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -62.0979078434039,
//    Latitude = -31.1656648235175,
//},
//new Municipality()
//{
//    Id = 820035,
//    Name = "Frontera",
//    FullName = "Municipality Frontera",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -62.0391670383165,
//    Latitude = -31.4735738450781,
//},
//new Municipality()
//{
//    Id = 823995,
//    Name = "Sources",
//    FullName = "Comuna Sources",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -61.0504190872743,
//    Latitude = -33.1808907129274,
//},
//new Municipality()
//{
//    Id = 220175,
//    Name = "Fuerte Esperanza",
//    FullName = "Municipality Fuerte Esperanza",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -61.9947690943917,
//    Latitude = -25.0409990119925,
//},
//new Municipality()
//{
//    Id = 820189,
//    Name = "Funes",
//    FullName = "Municipality Funes",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -60.8261607949605,
//    Latitude = -32.9257676945072,
//},
//new Municipality()
//{
//    Id = 823778,
//    Name = "Gaboto",
//    FullName = "Comuna Gaboto",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -60.807169414192,
//    Latitude = -32.4088595558951,
//},
//new Municipality()
//{
//    Id = 260098,
//    Name = "Gaiman",
//    FullName = "Municipality Gaiman",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -65.5118173145498,
//    Latitude = -43.3084974957434,
//},
//new Municipality()
//{
//    Id = 822252,
//    Name = "Galisteo",
//    FullName = "Comuna Galisteo",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -61.3261640759402,
//    Latitude = -31.0188302273946,
//},
//new Municipality()
//{
//    Id = 820252,
//    Name = "Gálvez",
//    FullName = "Municipality Gálvez",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -61.2351211450959,
//    Latitude = -32.0411326919863,
//},
//new Municipality()
//{
//    Id = 268126,
//    Name = "Gan Gan",
//    FullName = "Comuna Gan Gan",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -68.2827116707789,
//    Latitude = -42.517453780872,
//},
//new Municipality()
//{
//    Id = 220091,
//    Name = "Gancedo",
//    FullName = "Municipality Gancedo",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -61.6337806087492,
//    Latitude = -27.4055433703718,
//},
//new Municipality()
//{
//    Id = 824156,
//    Name = "Garabato",
//    FullName = "Comuna Garabato",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -60.2141789847547,
//    Latitude = -28.8887646620723,
//},
//new Municipality()
//{
//    Id = 180441,
//    Name = "Garaví",
//    FullName = "Municipality Garaví",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -55.8400450203393,
//    Latitude = -28.1940220491664,
//},
//new Municipality()
//{
//    Id = 822259,
//    Name = "Garibaldi",
//    FullName = "Comuna Garibaldi",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -61.8581121485345,
//    Latitude = -31.6567052458795,
//},
//new Municipality()
//{
//    Id = 908042,
//    Name = "Garmendia",
//    FullName = "Comuna Garmendia",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -64.6019700401528,
//    Latitude = -26.5437049908239,
//},
//new Municipality()
//{
//    Id = 180427,
//    Name = "Garruchos",
//    FullName = "Municipality Garruchos",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -55.741781168591,
//    Latitude = -28.1046104022621,
//},
//new Municipality()
//{
//    Id = 540308,
//    Name = "Garuhapé",
//    FullName = "Municipality Garuhapé",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -54.9072138666706,
//    Latitude = -26.8872609258331,
//},
//new Municipality()
//{
//    Id = 540112,
//    Name = "Garupá",
//    FullName = "Municipality Garupá",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -55.8647196707937,
//    Latitude = -27.5435522637668,
//},
//new Municipality()
//{
//    Id = 908182,
//    Name = "Gastona y Belicha",
//    FullName = "Comuna Gastona y Belicha",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -65.4926684584152,
//    Latitude = -27.3349592982633,
//},
//new Municipality()
//{
//    Id = 268035,
//    Name = "Gastre",
//    FullName = "Comuna Gastre",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -69.2167735510543,
//    Latitude = -42.287175612789,
//},
//new Municipality()
//{
//    Id = 823288,
//    Name = "Gato Colorado",
//    FullName = "Comuna Gato Colorado",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -61.0395778346293,
//    Latitude = -28.2297190791467,
//},
//new Municipality()
//{
//    Id = 420133,
//    Name = "General Acha",
//    FullName = "Municipality General Acha",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -65.0659942392198,
//    Latitude = -37.6096833380202,
//},
//new Municipality()
//{
//    Id = 309365,
//    Name = "General Almada",
//    FullName = "Junta General Almada",
//    Source = "IGN",
//    Category = "Junta",
//    Longitude = -58.7720076700463,
//    Latitude = -32.8540731144724,
//},
//new Municipality()
//{
//    Id = 60280,
//    Name = "General Alvarado",
//    FullName = "Municipality General Alvarado",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -58.0718053725136,
//    Latitude = -38.2026277127361,
//},
//new Municipality()
//{
//    Id = 60287,
//    Name = "General Alvear",
//    FullName = "Municipality General Alvear",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -60.1331531037654,
//    Latitude = -36.0347106495852,
//},
//new Municipality()
//{
//    Id = 540378,
//    Name = "General Alvear",
//    FullName = "Municipality General Alvear",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -55.1800539155612,
//    Latitude = -27.4190588795893,
//},
//new Municipality()
//{
//    Id = 309120,
//    Name = "General Alvear",
//    FullName = "Junta General Alvear",
//    Source = "IGN",
//    Category = "Junta",
//    Longitude = -60.6509483185012,
//    Latitude = -31.95148005865,
//},
//new Municipality()
//{
//    Id = 500014,
//    Name = "General Alvear",
//    FullName = "Municipality General Alvear",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -67.0805882231577,
//    Latitude = -35.2188457965288,
//},
//new Municipality()
//{
//    Id = 60294,
//    Name = "General Arenales",
//    FullName = "Municipality General Arenales",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -61.2833812257466,
//    Latitude = -34.2379020431365,
//},
//new Municipality()
//{
//    Id = 140532,
//    Name = "General Baldissera",
//    FullName = "Municipality General Baldissera",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -62.3006086559546,
//    Latitude = -33.1235893332125,
//},
//new Municipality()
//{
//    Id = 660140,
//    Name = "General Ballivián",
//    FullName = "Municipality General Ballivián",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -63.6214982074011,
//    Latitude = -22.8977530146056,
//},
//new Municipality()
//{
//    Id = 460063,
//    Name = "General Belgrano",
//    FullName = "Municipality General Belgrano",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -65.9324739935621,
//    Latitude = -30.5778081167579,
//},
//new Municipality()
//{
//    Id = 60301,
//    Name = "General Belgrano",
//    FullName = "Municipality General Belgrano",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -58.6980799686583,
//    Latitude = -35.8346623469789,
//},
//new Municipality()
//{
//    Id = 140413,
//    Name = "General Cabrera",
//    FullName = "Municipality General Cabrera",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -63.8707446907222,
//    Latitude = -32.8126298411653,
//},
//new Municipality()
//{
//    Id = 420140,
//    Name = "General Campos",
//    FullName = "Municipality General Campos",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -63.5353230853907,
//    Latitude = -37.4115020042705,
//},
//new Municipality()
//{
//    Id = 300378,
//    Name = "General Campos",
//    FullName = "Municipality General Campos",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -58.4149538824891,
//    Latitude = -31.5368478566654,
//},
//new Municipality()
//{
//    Id = 220098,
//    Name = "General Capdevila",
//    FullName = "Municipality General Capdevila",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -61.4674455631469,
//    Latitude = -27.4102672071315,
//},
//new Municipality()
//{
//    Id = 620084,
//    Name = "General Conesa",
//    FullName = "Municipality General Conesa",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -64.3728014154198,
//    Latitude = -40.1194171831846,
//},
//new Municipality()
//{
//    Id = 140420,
//    Name = "General Deheza",
//    FullName = "Municipality General Deheza",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -63.7924284582828,
//    Latitude = -32.7619158521806,
//},
//new Municipality()
//{
//    Id = 620147,
//    Name = "General Enrique Godoy",
//    FullName = "Municipality General Enrique Godoy",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -67.1569934098058,
//    Latitude = -38.8781175110666,
//},
//new Municipality()
//{
//    Id = 460028,
//    Name = "General Felipe Varela",
//    FullName = "Municipality General Felipe Varela",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -68.328556647524,
//    Latitude = -29.4499054722466,
//},
//new Municipality()
//{
//    Id = 620154,
//    Name = "General Fernández Oro",
//    FullName = "Municipality General Fernández Oro",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -67.9242508553038,
//    Latitude = -38.9633117827911,
//},
//new Municipality()
//{
//    Id = 143141,
//    Name = "General Fotheringham",
//    FullName = "Comuna General Fotheringham",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -63.8678208637172,
//    Latitude = -32.3218044631245,
//},
//new Municipality()
//{
//    Id = 300168,
//    Name = "General Galarza",
//    FullName = "Municipality General Galarza",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -59.397516666182,
//    Latitude = -32.7135903966627,
//},
//new Municipality()
//{
//    Id = 822448,
//    Name = "General Gelly",
//    FullName = "Comuna General Gelly",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -60.5642157861658,
//    Latitude = -33.6037490465368,
//},
//new Municipality()
//{
//    Id = 660119,
//    Name = "General Güemes",
//    FullName = "Municipality General Güemes",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -64.9077106136932,
//    Latitude = -24.8005154356973,
//},
//new Municipality()
//{
//    Id = 60308,
//    Name = "General Guido",
//    FullName = "Municipality General Guido",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -57.9957365951939,
//    Latitude = -36.6660345415726,
//},
//new Municipality()
//{
//    Id = 460070,
//    Name = "General Juan Facundo Quiroga",
//    FullName = "Municipality General Juan Facundo Quiroga",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -66.8678571954155,
//    Latitude = -30.8006382527121,
//},
//new Municipality()
//{
//    Id = 60315,
//    Name = "General Juan Madariaga",
//    FullName = "Municipality General Juan Madariaga",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -57.2306605949345,
//    Latitude = -37.1535157186092,
//},
//new Municipality()
//{
//    Id = 60322,
//    Name = "General La Madrid",
//    FullName = "Municipality General La Madrid",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -61.3441308948947,
//    Latitude = -37.3561277769078,
//},
//new Municipality()
//{
//    Id = 823407,
//    Name = "General Lagos",
//    FullName = "Comuna General Lagos",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -60.5763483049383,
//    Latitude = -33.1153795045791,
//},
//new Municipality()
//{
//    Id = 460077,
//    Name = "General Lamadrid",
//    FullName = "Municipality General Lamadrid",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -68.6975444932209,
//    Latitude = -28.7904386774185,
//},
//new Municipality()
//{
//    Id = 60329,
//    Name = "General Las Heras",
//    FullName = "Municipality General Las Heras",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -58.9954466211925,
//    Latitude = -34.9094243780878,
//},
//new Municipality()
//{
//    Id = 60336,
//    Name = "General Lavalle",
//    FullName = "Municipality General Lavalle",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -56.9410029895211,
//    Latitude = -36.6507503772361,
//},
//new Municipality()
//{
//    Id = 140616,
//    Name = "General Levalle",
//    FullName = "Municipality General Levalle",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -63.9268210537681,
//    Latitude = -34.0132450114982,
//},
//new Municipality()
//{
//    Id = 340049,
//    Name = "General Lucio Victorio Mansilla",
//    FullName = "Municipality General Lucio Victorio Mansilla",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -58.6341764154325,
//    Latitude = -26.6536726752957,
//},
//new Municipality()
//{
//    Id = 340112,
//    Name = "General Manuel Belgrano",
//    FullName = "Municipality General Manuel Belgrano",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -59.0191697358227,
//    Latitude = -24.9409528971948,
//},
//new Municipality()
//{
//    Id = 660147,
//    Name = "General Mosconi",
//    FullName = "Municipality General Mosconi",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -63.9781339092105,
//    Latitude = -22.6055468570728,
//},
//new Municipality()
//{
//    Id = 460084,
//    Name = "General Ortiz de Ocampo",
//    FullName = "Municipality General Ortiz de Ocampo",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -66.0589849393941,
//    Latitude = -31.0067607492179,
//},
//new Municipality()
//{
//    Id = 60343,
//    Name = "General Paz",
//    FullName = "Municipality General Paz",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -58.389651959253,
//    Latitude = -35.466183010272,
//},
//new Municipality()
//{
//    Id = 420147,
//    Name = "General Pico",
//    FullName = "Municipality General Pico",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -63.6162726702493,
//    Latitude = -35.5797743389588,
//},
//new Municipality()
//{
//    Id = 220105,
//    Name = "General Pinedo",
//    FullName = "Municipality General Pinedo",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -61.3683203564515,
//    Latitude = -27.2744712190591,
//},
//new Municipality()
//{
//    Id = 60351,
//    Name = "General Pinto",
//    FullName = "Municipality General Pinto",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -62.0398533933194,
//    Latitude = -34.6696217964602,
//},
//new Municipality()
//{
//    Id = 660021,
//    Name = "General Pizarro",
//    FullName = "Municipality General Pizarro",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -63.8533990814412,
//    Latitude = -24.2794490405293,
//},
//new Municipality()
//{
//    Id = 60357,
//    Name = "General Pueyrredón",
//    FullName = "Municipality General Pueyrredón",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -57.743028347632,
//    Latitude = -37.9656831422558,
//},
//new Municipality()
//{
//    Id = 300091,
//    Name = "General Ramírez",
//    FullName = "Municipality General Ramírez",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -60.21792742744,
//    Latitude = -32.1803463085729,
//},
//new Municipality()
//{
//    Id = 620161,
//    Name = "General Roca",
//    FullName = "Municipality General Roca",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -67.6183270840903,
//    Latitude = -39.0105827929634,
//},
//new Municipality()
//{
//    Id = 302077,
//    Name = "General Roca",
//    FullName = "Junta General Roca",
//    Source = "IGN",
//    Category = "Junta",
//    Longitude = -58.1080822652008,
//    Latitude = -31.3234779427234,
//},
//new Municipality()
//{
//    Id = 140539,
//    Name = "General Roca",
//    FullName = "Municipality General Roca",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -61.9145008159753,
//    Latitude = -32.7275119390043,
//},
//new Municipality()
//{
//    Id = 60364,
//    Name = "General Rodríguez",
//    FullName = "Municipality General Rodríguez",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -58.9878467982619,
//    Latitude = -34.6506156900802,
//},
//new Municipality()
//{
//    Id = 60371,
//    Name = "General San Martín",
//    FullName = "Municipality General San Martín",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -58.5643041474744,
//    Latitude = -34.5527540154453,
//},
//new Municipality()
//{
//    Id = 220259,
//    Name = "General San Martín",
//    FullName = "Municipality General San Martín",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -59.275280608901,
//    Latitude = -26.521335933866,
//},
//new Municipality()
//{
//    Id = 420154,
//    Name = "General San Martín",
//    FullName = "Municipality General San Martín",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -63.7483607116557,
//    Latitude = -38.2823959989311,
//},
//new Municipality()
//{
//    Id = 460091,
//    Name = "General San Martín",
//    FullName = "Municipality General San Martín",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -66.145816269493,
//    Latitude = -31.6414651718004,
//},
//new Municipality()
//{
//    Id = 540434,
//    Name = "General Urquiza",
//    FullName = "Municipality General Urquiza",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -55.3936187774349,
//    Latitude = -27.0500317840478,
//},
//new Municipality()
//{
//    Id = 220035,
//    Name = "General Vedia",
//    FullName = "Municipality General Vedia",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -58.7283703133992,
//    Latitude = -26.8222090445507,
//},
//new Municipality()
//{
//    Id = 60385,
//    Name = "General Viamonte",
//    FullName = "Municipality General Viamonte",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -61.0496572343537,
//    Latitude = -34.9977788912536,
//},
//new Municipality()
//{
//    Id = 60392,
//    Name = "General Villegas",
//    FullName = "Municipality General Villegas",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -62.9541986992421,
//    Latitude = -34.7702605184284,
//},
//new Municipality()
//{
//    Id = 823785,
//    Name = "Gessler",
//    FullName = "Comuna Gessler",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -61.1281732028067,
//    Latitude = -31.8890862846465,
//},
//new Municipality()
//{
//    Id = 300185,
//    Name = "Gilbert",
//    FullName = "Municipality Gilbert",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -58.9233490472985,
//    Latitude = -32.5409420780764,
//},
//new Municipality()
//{
//    Id = 260147,
//    Name = "Gobernador Costa",
//    FullName = "Municipality Gobernador Costa",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -70.779037266098,
//    Latitude = -44.2822426068909,
//},
//new Municipality()
//{
//    Id = 823890,
//    Name = "Gobernador Crespo",
//    FullName = "Comuna Gobernador Crespo",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -60.3853188155488,
//    Latitude = -30.3421799750288,
//},
//new Municipality()
//{
//    Id = 420158,
//    Name = "Gobernador Duval",
//    FullName = "Municipality Gobernador Duval",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -65.857132773132,
//    Latitude = -38.5453996263779,
//},
//new Municipality()
//{
//    Id = 303098,
//    Name = "Gobernador Echagüe",
//    FullName = "Junta Gobernador Echagüe",
//    Source = "IGN",
//    Category = "Junta",
//    Longitude = -59.2735754337633,
//    Latitude = -32.3912645804557,
//},
//new Municipality()
//{
//    Id = 302948,
//    Name = "Gobernador Etchevehere",
//    FullName = "Junta Gobernador Etchevehere",
//    Source = "IGN",
//    Category = "Junta",
//    Longitude = -60.4125187050992,
//    Latitude = -31.932598066661,
//},
//new Municipality()
//{
//    Id = 540273,
//    Name = "Gobernador López",
//    FullName = "Municipality Gobernador López",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -55.211979676415,
//    Latitude = -27.63903776492,
//},
//new Municipality()
//{
//    Id = 300392,
//    Name = "Gobernador Mansilla",
//    FullName = "Municipality Gobernador Mansilla",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -59.3397439490119,
//    Latitude = -32.5538855049738,
//},
//new Municipality()
//{
//    Id = 180196,
//    Name = "Gobernador Martínez",
//    FullName = "Municipality Gobernador Martínez",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -58.9110935350202,
//    Latitude = -28.9078640614298,
//},
//new Municipality()
//{
//    Id = 908049,
//    Name = "Gobernador Piedrabuena",
//    FullName = "Comuna Gobernador Piedrabuena",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -64.7179566417696,
//    Latitude = -26.7456886250955,
//},
//new Municipality()
//{
//    Id = 302161,
//    Name = "Gobernador Racedo",
//    FullName = "Comuna Gobernador Racedo",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -60.3922364543603,
//    Latitude = -31.9802745984856,
//},
//new Municipality()
//{
//    Id = 540441,
//    Name = "Gobernador Roca",
//    FullName = "Municipality Gobernador Roca",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -55.3680383093309,
//    Latitude = -27.2531807829927,
//},
//new Municipality()
//{
//    Id = 303112,
//    Name = "Gobernador Sola",
//    FullName = "Junta Gobernador Sola",
//    Source = "IGN",
//    Category = "Junta",
//    Longitude = -59.4066253742469,
//    Latitude = -32.3356579694532,
//},
//new Municipality()
//{
//    Id = 180434,
//    Name = "Gobernador Virasoro",
//    FullName = "Municipality Gobernador Virasoro",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -56.1463621575802,
//    Latitude = -28.0253708190995,
//},
//new Municipality()
//{
//    Id = 822070,
//    Name = "Gödeken",
//    FullName = "Comuna Gödeken",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -61.8824837014953,
//    Latitude = -33.4139112700317,
//},
//new Municipality()
//{
//    Id = 822455,
//    Name = "Godoy",
//    FullName = "Comuna Godoy",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -60.4724900719621,
//    Latitude = -33.4158260386807,
//},
//new Municipality()
//{
//    Id = 500021,
//    Name = "Godoy Cruz",
//    FullName = "Municipality Godoy Cruz",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -68.9141362247952,
//    Latitude = -32.9320744395304,
//},
//new Municipality()
//{
//    Id = 824163,
//    Name = "Golondrina",
//    FullName = "Comuna Golondrina",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -60.4419380258318,
//    Latitude = -28.4585818932208,
//},
//new Municipality()
//{
//    Id = 309300,
//    Name = "González Calderón",
//    FullName = "Junta González Calderón",
//    Source = "IGN",
//    Category = "Junta",
//    Longitude = -59.517521180551,
//    Latitude = -32.924754172721,
//},
//new Municipality()
//{
//    Id = 180140,
//    Name = "Goya",
//    FullName = "Municipality Goya",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -59.1806630189571,
//    Latitude = -29.3382777310459,
//},
//new Municipality()
//{
//    Id = 345021,
//    Name = "Gran Guardia",
//    FullName = "Comisión Gran Guardia",
//    Source = "IGN",
//    Category = "Comisión",
//    Longitude = -58.8869102543172,
//    Latitude = -25.8624689502625,
//},
//new Municipality()
//{
//    Id = 820196,
//    Name = "Granadero Baigorria",
//    FullName = "Municipality Granadero Baigorria",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -60.7040059949528,
//    Latitude = -32.8513187423658,
//},
//new Municipality()
//{
//    Id = 900049,
//    Name = "Graneros",
//    FullName = "Municipality Graneros",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -65.4261191058465,
//    Latitude = -27.6458809000617,
//},
//new Municipality()
//{
//    Id = 823295,
//    Name = "Gregoria Pérez de Denis",
//    FullName = "Comuna Gregoria Pérez de Denis",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -61.559906626784,
//    Latitude = -28.1274204761568,
//},
//new Municipality()
//{
//    Id = 823085,
//    Name = "Grutly",
//    FullName = "Comuna Grutly",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -61.0940311148996,
//    Latitude = -31.2376882388851,
//},
//new Municipality()
//{
//    Id = 660168,
//    Name = "Guachipas",
//    FullName = "Municipality Guachipas",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -65.4445405596262,
//    Latitude = -25.7029583632806,
//},
//new Municipality()
//{
//    Id = 822805,
//    Name = "Guadalupe Norte",
//    FullName = "Comuna Guadalupe Norte",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -59.4143676322971,
//    Latitude = -28.9633631141105,
//},
//new Municipality()
//{
//    Id = 300175,
//    Name = "Gualeguay",
//    FullName = "Municipality Gualeguay",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -59.3288465070784,
//    Latitude = -33.1479006388336,
//},
//new Municipality()
//{
//    Id = 309150,
//    Name = "Gualeguaycito",
//    FullName = "Junta Gualeguaycito",
//    Source = "IGN",
//    Category = "Junta",
//    Longitude = -58.1317802897372,
//    Latitude = -31.0443420635272,
//},
//new Municipality()
//{
//    Id = 265007,
//    Name = "Gualjaina",
//    FullName = "Comisión Gualjaina",
//    Source = "IGN",
//    Category = "Comisión",
//    Longitude = -70.5385061881655,
//    Latitude = -42.7142084594083,
//},
//new Municipality()
//{
//    Id = 60399,
//    Name = "Guaminí",
//    FullName = "Municipality Guaminí",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -62.4185310608437,
//    Latitude = -36.8906755108645,
//},
//new Municipality()
//{
//    Id = 142161,
//    Name = "Guanaco Muerto",
//    FullName = "Comuna Guanaco Muerto",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -65.0659885087751,
//    Latitude = -30.4602024394627,
//},
//new Municipality()
//{
//    Id = 585077,
//    Name = "Guañacos",
//    FullName = "Comisión Guañacos",
//    Source = "IGN",
//    Category = "Comisión",
//    Longitude = -70.9329776975664,
//    Latitude = -37.2863480276932,
//},
//new Municipality()
//{
//    Id = 540385,
//    Name = "Guaraní",
//    FullName = "Municipality Guaraní",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -55.1766194604072,
//    Latitude = -27.5607188356085,
//},
//new Municipality()
//{
//    Id = 303119,
//    Name = "Guardamonte",
//    FullName = "Junta Guardamonte",
//    Source = "IGN",
//    Category = "Junta",
//    Longitude = -59.3190840039593,
//    Latitude = -32.0899214520537,
//},
//new Municipality()
//{
//    Id = 620007,
//    Name = "Guardia Mitre",
//    FullName = "Municipality Guardia Mitre",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -63.7075414437428,
//    Latitude = -40.4394526389603,
//},
//new Municipality()
//{
//    Id = 142378,
//    Name = "Guasapampa",
//    FullName = "Comuna Guasapampa",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -65.3098829147869,
//    Latitude = -31.134641078071,
//},
//new Municipality()
//{
//    Id = 140546,
//    Name = "Guatimozín",
//    FullName = "Municipality Guatimozín",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -62.433942915908,
//    Latitude = -33.4605679567117,
//},
//new Municipality()
//{
//    Id = 420161,
//    Name = "Guatraché",
//    FullName = "Municipality Guatraché",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -63.6735437889992,
//    Latitude = -37.6771750177854,
//},
//new Municipality()
//{
//    Id = 180364,
//    Name = "Guaviraví",
//    FullName = "Municipality Guaviraví",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -56.820106168151,
//    Latitude = -29.3247154996118,
//},
//new Municipality()
//{
//    Id = 500028,
//    Name = "Guaymallén",
//    FullName = "Municipality Guaymallén",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -68.7333034931406,
//    Latitude = -32.8929748154748,
//},
//new Municipality()
//{
//    Id = 142756,
//    Name = "Gutemberg",
//    FullName = "Comuna Gutemberg",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -63.5504574858833,
//    Latitude = -29.703741548894,
//},
//new Municipality()
//{
//    Id = 309010,
//    Name = "Hambis",
//    FullName = "Junta Hambis",
//    Source = "IGN",
//    Category = "Junta",
//    Longitude = -58.5174095948463,
//    Latitude = -31.9214715304382,
//},
//new Municipality()
//{
//    Id = 300308,
//    Name = "Hasenkamp",
//    FullName = "Municipality Hasenkamp",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -59.8309253548512,
//    Latitude = -31.5225939490781,
//},
//new Municipality()
//{
//    Id = 822553,
//    Name = "Helvecia",
//    FullName = "Comuna Helvecia",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -60.1186164444891,
//    Latitude = -31.0642525452088,
//},
//new Municipality()
//{
//    Id = 180343,
//    Name = "Herlitzka",
//    FullName = "Municipality Herlitzka",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -58.3350071890102,
//    Latitude = -27.6171762731461,
//},
//new Municipality()
//{
//    Id = 220112,
//    Name = "Hermoso Campo",
//    FullName = "Municipality Hermoso Campo",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -61.3289519563851,
//    Latitude = -27.6198551557064,
//},
//new Municipality()
//{
//    Id = 300315,
//    Name = "Hernandarias",
//    FullName = "Municipality Hernandarias",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -59.9965689567101,
//    Latitude = -31.265789068938,
//},
//new Municipality()
//{
//    Id = 141449,
//    Name = "Hernando",
//    FullName = "Municipality Hernando",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -63.731976625652,
//    Latitude = -32.4298361512603,
//},
//new Municipality()
//{
//    Id = 340056,
//    Name = "Herradura",
//    FullName = "Municipality Herradura",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -58.2991974832003,
//    Latitude = -26.4861755594849,
//},
//new Municipality()
//{
//    Id = 300434,
//    Name = "Herrera",
//    FullName = "Municipality Herrera",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -58.6100445386218,
//    Latitude = -32.4425423626583,
//},
//new Municipality()
//{
//    Id = 823547,
//    Name = "Hersilia",
//    FullName = "Comuna Hersilia",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -61.8291481639901,
//    Latitude = -29.9757556247055,
//},
//new Municipality()
//{
//    Id = 309890,
//    Name = "Hinojal",
//    FullName = "Junta Hinojal",
//    Source = "IGN",
//    Category = "Junta",
//    Longitude = -60.1179663653391,
//    Latitude = -32.342071441541,
//},
//new Municipality()
//{
//    Id = 823092,
//    Name = "Hipatía",
//    FullName = "Comuna Hipatía",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -61.0746609329514,
//    Latitude = -31.0997692458585,
//},
//new Municipality()
//{
//    Id = 60406,
//    Name = "Hipólito Yrigoyen",
//    FullName = "Municipality Hipólito Yrigoyen",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -61.6601876260417,
//    Latitude = -36.2591890205933,
//},
//new Municipality()
//{
//    Id = 540448,
//    Name = "Hipólito Yrigoyen",
//    FullName = "Municipality Hipólito Yrigoyen",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -55.3071982572211,
//    Latitude = -27.1001832638378,
//},
//new Municipality()
//{
//    Id = 386056,
//    Name = "Hipólito Yrigoyen",
//    FullName = "Comisión Hipólito Yrigoyen",
//    Source = "IGN",
//    Category = "Comisión",
//    Longitude = -65.3457278451854,
//    Latitude = -22.8748044630677,
//},
//new Municipality()
//{
//    Id = 660301,
//    Name = "Hipólito Yrigoyen",
//    FullName = "Municipality Hipólito Yrigoyen",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -64.2926304175666,
//    Latitude = -23.2763122724961,
//},
//new Municipality()
//{
//    Id = 309015,
//    Name = "Hocker",
//    FullName = "Junta Hocker",
//    Source = "IGN",
//    Category = "Junta",
//    Longitude = -58.2936821856629,
//    Latitude = -32.0503147090551,
//},
//new Municipality()
//{
//    Id = 386175,
//    Name = "Huacalera",
//    FullName = "Comisión Huacalera",
//    Source = "IGN",
//    Category = "Comisión",
//    Longitude = -65.3954644066553,
//    Latitude = -23.3971482761292,
//},
//new Municipality()
//{
//    Id = 100077,
//    Name = "Hualfin",
//    FullName = "Municipality Hualfin",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -66.6859075037001,
//    Latitude = -27.2352617684014,
//},
//new Municipality()
//{
//    Id = 140427,
//    Name = "Huanchilla",
//    FullName = "Municipality Huanchilla",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -63.6351900273338,
//    Latitude = -33.6666603550782,
//},
//new Municipality()
//{
//    Id = 823554,
//    Name = "Huanqueros",
//    FullName = "Comuna Huanqueros",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -61.1090715369664,
//    Latitude = -29.8578882238907,
//},
//new Municipality()
//{
//    Id = 908238,
//    Name = "Huasa Pampa",
//    FullName = "Comuna Huasa Pampa",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -65.6230134006141,
//    Latitude = -27.8646662686296,
//},
//new Municipality()
//{
//    Id = 140686,
//    Name = "Huerta Grande",
//    FullName = "Municipality Huerta Grande",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -64.4965933938749,
//    Latitude = -31.072010551809,
//},
//new Municipality()
//{
//    Id = 822266,
//    Name = "Hugentobler",
//    FullName = "Comuna Hugentobler",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -61.757243928205,
//    Latitude = -30.9141614845637,
//},
//new Municipality()
//{
//    Id = 822651,
//    Name = "Hughes",
//    FullName = "Comuna Hughes",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -61.3698198632529,
//    Latitude = -33.8289201098464,
//},
//new Municipality()
//{
//    Id = 100133,
//    Name = "Huillapima",
//    FullName = "Municipality Huillapima",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -65.9147502502591,
//    Latitude = -28.6566201868416,
//},
//new Municipality()
//{
//    Id = 140224,
//    Name = "Huinca Renancó",
//    FullName = "Municipality Huinca Renancó",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -64.3759223052139,
//    Latitude = -34.8375108995881,
//},
//new Municipality()
//{
//    Id = 580147,
//    Name = "Huinganco",
//    FullName = "Municipality Huinganco",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -70.5999829263709,
//    Latitude = -37.0638452103236,
//},
//new Municipality()
//{
//    Id = 380105,
//    Name = "Humahuaca",
//    FullName = "Municipality Humahuaca",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -65.3723515309601,
//    Latitude = -23.1728766584537,
//},
//new Municipality()
//{
//    Id = 822273,
//    Name = "Humberto Primo",
//    FullName = "Comuna Humberto Primo",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -61.3471968909725,
//    Latitude = -30.868882352834,
//},
//new Municipality()
//{
//    Id = 823099,
//    Name = "Humboldt",
//    FullName = "Comuna Humboldt",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -61.1185199212056,
//    Latitude = -31.4018426247073,
//},
//new Municipality()
//{
//    Id = 60408,
//    Name = "Hurlingham",
//    FullName = "Municipality Hurlingham",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -58.6495253867325,
//    Latitude = -34.5992830551805,
//},
//new Municipality()
//{
//    Id = 823414,
//    Name = "Ibarlucea",
//    FullName = "Comuna Ibarlucea",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -60.8055572417326,
//    Latitude = -32.8521392232883,
//},
//new Municipality()
//{
//    Id = 340126,
//    Name = "Ibarreta",
//    FullName = "Municipality Ibarreta",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -59.8647594063699,
//    Latitude = -25.2135553298222,
//},
//new Municipality()
//{
//    Id = 300217,
//    Name = "Ibicuy",
//    FullName = "Municipality Ibicuy",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -59.1183515219628,
//    Latitude = -33.7191005686568,
//},
//new Municipality()
//{
//    Id = 100168,
//    Name = "Icaño",
//    FullName = "Municipality Icaño",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -65.15077323013,
//    Latitude = -28.8623770243273,
//},
//new Municipality()
//{
//    Id = 141652,
//    Name = "Idiazábal",
//    FullName = "Municipality Idiazábal",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -63.0314306796415,
//    Latitude = -32.8118251859657,
//},
//new Municipality()
//{
//    Id = 700049,
//    Name = "Iglesia",
//    FullName = "Municipality Iglesia",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -69.4387201063957,
//    Latitude = -29.6011907018106,
//},
//new Municipality()
//{
//    Id = 142812,
//    Name = "Impira",
//    FullName = "Comuna Impira",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -63.6502998161586,
//    Latitude = -31.7968283637742,
//},
//new Municipality()
//{
//    Id = 460105,
//    Name = "Independencia",
//    FullName = "Municipality Independencia",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -67.3355098029609,
//    Latitude = -30.1144556416957,
//},
//new Municipality()
//{
//    Id = 822812,
//    Name = "Ingeniero Chanourdie",
//    FullName = "Comuna Ingeniero Chanourdie",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -59.662924599085,
//    Latitude = -28.6798978864095,
//},
//new Municipality()
//{
//    Id = 340077,
//    Name = "Ingeniero Guillermo Nicasio Juárez",
//    FullName = "Municipality Ingeniero Guillermo Nicasio Juárez",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -61.8551751958784,
//    Latitude = -23.8985673230417,
//},
//new Municipality()
//{
//    Id = 620168,
//    Name = "Ingeniero Huergo",
//    FullName = "Municipality Ingeniero Huergo",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -67.233005890215,
//    Latitude = -38.8372914270477,
//},
//new Municipality()
//{
//    Id = 620252,
//    Name = "Ingeniero Jacobacci",
//    FullName = "Municipality Ingeniero Jacobacci",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -69.5516517422989,
//    Latitude = -41.33140800619,
//},
//new Municipality()
//{
//    Id = 420168,
//    Name = "Ingeniero Luiggi",
//    FullName = "Municipality Ingeniero Luiggi",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -64.6342119572077,
//    Latitude = -35.3868979248615,
//},
//new Municipality()
//{
//    Id = 303273,
//    Name = "Ingeniero Sajaroff",
//    FullName = "Junta Ingeniero Sajaroff",
//    Source = "IGN",
//    Category = "Junta",
//    Longitude = -58.8638037727869,
//    Latitude = -31.9141139490735,
//},
//new Municipality()
//{
//    Id = 140553,
//    Name = "Inriville",
//    FullName = "Municipality Inriville",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -62.2232305915593,
//    Latitude = -32.9444827064459,
//},
//new Municipality()
//{
//    Id = 420175,
//    Name = "Intendente Alvear",
//    FullName = "Municipality Intendente Alvear",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -63.5507872244856,
//    Latitude = -35.2731196395592,
//},
//new Municipality()
//{
//    Id = 824170,
//    Name = "Intiyaco",
//    FullName = "Comuna Intiyaco",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -60.3442851023737,
//    Latitude = -28.6594190058826,
//},
//new Municipality()
//{
//    Id = 302526,
//    Name = "Irazusta",
//    FullName = "Junta Irazusta",
//    Source = "IGN",
//    Category = "Junta",
//    Longitude = -58.9620301316905,
//    Latitude = -32.9398792555378,
//},
//new Municipality()
//{
//    Id = 823792,
//    Name = "Irigoyen",
//    FullName = "Comuna Irigoyen",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -61.0972685546721,
//    Latitude = -32.1612356127734,
//},
//new Municipality()
//{
//    Id = 660175,
//    Name = "Iruya",
//    FullName = "Municipality Iruya",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -65.0304388391872,
//    Latitude = -22.7868447304234,
//},
//new Municipality()
//{
//    Id = 660182,
//    Name = "Isla de Cañas",
//    FullName = "Municipality Isla de Cañas",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -64.6762706024264,
//    Latitude = -22.8786709567467,
//},
//new Municipality()
//{
//    Id = 220042,
//    Name = "Isla del Cerrito",
//    FullName = "Municipality Isla del Cerrito",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -58.6804397158308,
//    Latitude = -27.3041529234823,
//},
//new Municipality()
//{
//    Id = 140560,
//    Name = "Isla Verde",
//    FullName = "Municipality Isla Verde",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -62.4029817048294,
//    Latitude = -33.2384139955947,
//},
//new Municipality()
//{
//    Id = 309125,
//    Name = "Isletas",
//    FullName = "Junta Isletas",
//    Source = "IGN",
//    Category = "Junta",
//    Longitude = -60.329712897135,
//    Latitude = -32.2038848658462,
//},
//new Municipality()
//{
//    Id = 180119,
//    Name = "Itá Ibaté",
//    FullName = "Municipality Itá Ibaté",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -57.3645813618204,
//    Latitude = -27.5323131425268,
//},
//new Municipality()
//{
//    Id = 540483,
//    Name = "Itacaruaré",
//    FullName = "Municipality Itacaruaré",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -55.2793085458625,
//    Latitude = -27.8358055259238,
//},
//new Municipality()
//{
//    Id = 140231,
//    Name = "Italó",
//    FullName = "Municipality Italó",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -63.7809993095979,
//    Latitude = -34.7873745654291,
//},
//new Municipality()
//{
//    Id = 180147,
//    Name = "Itatí",
//    FullName = "Municipality Itatí",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -58.0491341931277,
//    Latitude = -27.3434649989571,
//},
//new Municipality()
//{
//    Id = 60410,
//    Name = "Ituzaingó",
//    FullName = "Municipality Ituzaingó",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -58.6887595155803,
//    Latitude = -34.6360716118623,
//},
//new Municipality()
//{
//    Id = 823106,
//    Name = "Ituzaingó",
//    FullName = "Comuna Ituzaingó",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -61.1425699546719,
//    Latitude = -30.8148965134766,
//},
//new Municipality()
//{
//    Id = 180168,
//    Name = "Ituzaingó",
//    FullName = "Municipality Ituzaingó",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -56.9163018400039,
//    Latitude = -27.9663984461898,
//},
//new Municipality()
//{
//    Id = 700056,
//    Name = "Jáchal",
//    FullName = "Municipality Jáchal",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -68.4399965840683,
//    Latitude = -30.3546413571104,
//},
//new Municipality()
//{
//    Id = 420182,
//    Name = "Jacinto Aráuz",
//    FullName = "Municipality Jacinto Aráuz",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -63.4812408346653,
//    Latitude = -38.2691572049509,
//},
//new Municipality()
//{
//    Id = 823113,
//    Name = "Jacinto L. Aráuz",
//    FullName = "Comuna Jacinto L. Aráuz",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -60.9560890780112,
//    Latitude = -30.7206002392745,
//},
//new Municipality()
//{
//    Id = 141456,
//    Name = "James Craik",
//    FullName = "Municipality James Craik",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -63.461439214356,
//    Latitude = -32.1653801707883,
//},
//new Municipality()
//{
//    Id = 540455,
//    Name = "Jardín América",
//    FullName = "Municipality Jardín América",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -55.1946087591163,
//    Latitude = -27.0873118890522,
//},
//new Municipality()
//{
//    Id = 140112,
//    Name = "Jesús María",
//    FullName = "Municipality Jesús María",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -64.1282788824923,
//    Latitude = -30.9830362297075,
//},
//new Municipality()
//{
//    Id = 660028,
//    Name = "Joaquín V. González",
//    FullName = "Municipality Joaquín V. González",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -63.6496151507013,
//    Latitude = -24.7915475546047,
//},
//new Municipality()
//{
//    Id = 60412,
//    Name = "José C. Paz",
//    FullName = "Municipality José C. Paz",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -58.7776345982889,
//    Latitude = -34.5118531627172,
//},
//new Municipality()
//{
//    Id = 260154,
//    Name = "José de San Martín",
//    FullName = "Municipality José de San Martín",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -70.4638843298773,
//    Latitude = -44.0515049815561,
//},
//new Municipality()
//{
//    Id = 822280,
//    Name = "Josefina",
//    FullName = "Comuna Josefina",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -61.9788204139716,
//    Latitude = -31.3918994594214,
//},
//new Municipality()
//{
//    Id = 140238,
//    Name = "Jovita",
//    FullName = "Municipality Jovita",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -63.9431016058546,
//    Latitude = -34.5175313443449,
//},
//new Municipality()
//{
//    Id = 822462,
//    Name = "Juan B. Molina",
//    FullName = "Comuna Juan B. Molina",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -60.4981054656878,
//    Latitude = -33.5271112512195,
//},
//new Municipality()
//{
//    Id = 900056,
//    Name = "Juan Bautista Alberdi",
//    FullName = "Municipality Juan Bautista Alberdi",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -65.6157046440368,
//    Latitude = -27.5899482222786,
//},
//new Municipality()
//{
//    Id = 823302,
//    Name = "Juan de Garay",
//    FullName = "Comuna Juan de Garay",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -61.6631398799138,
//    Latitude = -29.6658869843342,
//},
//new Municipality()
//{
//    Id = 746119,
//    Name = "Juan Jorba",
//    FullName = "Comisión Juan Jorba",
//    Source = "IGN",
//    Category = "Comisión",
//    Longitude = -65.2726607834124,
//    Latitude = -33.6151941989638,
//},
//new Municipality()
//{
//    Id = 220182,
//    Name = "Juan José Castelli",
//    FullName = "Municipality Juan José Castelli",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -60.6630315203762,
//    Latitude = -25.915687365485,
//},
//new Municipality()
//{
//    Id = 746126,
//    Name = "Juan Llerena",
//    FullName = "Comisión Juan Llerena",
//    Source = "IGN",
//    Category = "Comisión",
//    Longitude = -65.6483449571395,
//    Latitude = -33.2835609428093,
//},
//new Municipality()
//{
//    Id = 180259,
//    Name = "Juan Pujol",
//    FullName = "Municipality Juan Pujol",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -57.8888953460569,
//    Latitude = -30.3777465204621,
//},
//new Municipality()
//{
//    Id = 740119,
//    Name = "Juana Koslay",
//    FullName = "Municipality Juana Koslay",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -66.2274958446994,
//    Latitude = -33.2951079845633,
//},
//new Municipality()
//{
//    Id = 303280,
//    Name = "Jubileo",
//    FullName = "Junta Jubileo",
//    Source = "IGN",
//    Category = "Junta",
//    Longitude = -58.675287738351,
//    Latitude = -31.7123642725059,
//},
//new Municipality()
//{
//    Id = 822469,
//    Name = "Juncal",
//    FullName = "Comuna Juncal",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -61.0936092496205,
//    Latitude = -33.7135284224069,
//},
//new Municipality()
//{
//    Id = 60413,
//    Name = "Junín",
//    FullName = "Municipality Junín",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -61.0052501278321,
//    Latitude = -34.5464751322691,
//},
//new Municipality()
//{
//    Id = 500035,
//    Name = "Junín",
//    FullName = "Municipality Junín",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -68.4973606539186,
//    Latitude = -33.1503940875751,
//},
//new Municipality()
//{
//    Id = 580112,
//    Name = "Junín de los Andes",
//    FullName = "Municipality Junín de los Andes",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -71.0997656206416,
//    Latitude = -39.921096992678,
//},
//new Municipality()
//{
//    Id = 141659,
//    Name = "Justiniano Posse",
//    FullName = "Municipality Justiniano Posse",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -62.6803137738942,
//    Latitude = -32.885115618459,
//},
//new Municipality()
//{
//    Id = 740070,
//    Name = "Justo Daract",
//    FullName = "Municipality Justo Daract",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -65.1869760029056,
//    Latitude = -33.8586458145149,
//},
//new Municipality()
//{
//    Id = 309560,
//    Name = "Justo José de Urquiza",
//    FullName = "Junta Justo José de Urquiza",
//    Source = "IGN",
//    Category = "Junta",
//    Longitude = -59.6498448114523,
//    Latitude = -31.9789113704588,
//},
//new Municipality()
//{
//    Id = 142672,
//    Name = "Kilómetro 658",
//    FullName = "Comuna Kilómetro 658",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -63.5309336677359,
//    Latitude = -31.3696370548369,
//},
//new Municipality()
//{
//    Id = 420189,
//    Name = "La Adela",
//    FullName = "Municipality La Adela",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -64.1117433389794,
//    Latitude = -38.7835577384197,
//},
//new Municipality()
//{
//    Id = 142168,
//    Name = "La Batea",
//    FullName = "Comuna La Batea",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -65.2680800032816,
//    Latitude = -30.4282384273219,
//},
//new Municipality()
//{
//    Id = 823708,
//    Name = "La Brava",
//    FullName = "Comuna La Brava",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -60.1771434159992,
//    Latitude = -30.4026152229379,
//},
//new Municipality()
//{
//    Id = 823561,
//    Name = "La Cabral",
//    FullName = "Comuna La Cabral",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -61.2028509551793,
//    Latitude = -30.0987794685869,
//},
//new Municipality()
//{
//    Id = 660189,
//    Name = "La Caldera",
//    FullName = "Municipality La Caldera",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -65.3791644391737,
//    Latitude = -24.5586992331039,
//},
//new Municipality()
//{
//    Id = 746014,
//    Name = "La Calera",
//    FullName = "Comisión La Calera",
//    Source = "IGN",
//    Category = "Comisión",
//    Longitude = -66.8428577544769,
//    Latitude = -32.8772165561097,
//},
//new Municipality()
//{
//    Id = 140119,
//    Name = "La Calera",
//    FullName = "Municipality La Calera",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -64.3737475435929,
//    Latitude = -31.3267269835167,
//},
//new Municipality()
//{
//    Id = 823897,
//    Name = "La Camila",
//    FullName = "Comuna La Camila",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -60.6203124847363,
//    Latitude = -30.0720725812193,
//},
//new Municipality()
//{
//    Id = 660217,
//    Name = "La Candelaria",
//    FullName = "Municipality La Candelaria",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -65.0294629555227,
//    Latitude = -26.1401212841927,
//},
//new Municipality()
//{
//    Id = 140434,
//    Name = "La Carlota",
//    FullName = "Municipality La Carlota",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -63.2963774632446,
//    Latitude = -33.4137059352071,
//},
//new Municipality()
//{
//    Id = 746035,
//    Name = "La Carolina",
//    FullName = "Comisión La Carolina",
//    Source = "IGN",
//    Category = "Comisión",
//    Longitude = -66.1002883078118,
//    Latitude = -32.8230037708011,
//},
//new Municipality()
//{
//    Id = 142560,
//    Name = "La Carolina El Potosí",
//    FullName = "Comuna La Carolina El Potosí",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -64.7267491840149,
//    Latitude = -33.1890811194128,
//},
//new Municipality()
//{
//    Id = 140826,
//    Name = "La Cautiva",
//    FullName = "Municipality La Cautiva",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -64.0855019234335,
//    Latitude = -33.9820493176756,
//},
//new Municipality()
//{
//    Id = 140623,
//    Name = "La Cesira",
//    FullName = "Municipality La Cesira",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -62.9759295184544,
//    Latitude = -33.9522414433712,
//},
//new Municipality()
//{
//    Id = 822658,
//    Name = "La Chispa",
//    FullName = "Comuna La Chispa",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -61.9638069432804,
//    Latitude = -33.5419367442364,
//},
//new Municipality()
//{
//    Id = 302035,
//    Name = "La Clarita",
//    FullName = "Junta La Clarita",
//    Source = "IGN",
//    Category = "Junta",
//    Longitude = -58.393296649552,
//    Latitude = -31.976186011253,
//},
//new Municipality()
//{
//    Id = 220336,
//    Name = "La Clotilde",
//    FullName = "Municipality La Clotilde",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -60.6802256792709,
//    Latitude = -27.1658292757784,
//},
//new Municipality()
//{
//    Id = 900063,
//    Name = "La Cocha",
//    FullName = "Municipality La Cocha",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -65.585525605092,
//    Latitude = -27.7920684691818,
//},
//new Municipality()
//{
//    Id = 60420,
//    Name = "La Costa",
//    FullName = "Municipality La Costa",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -56.7159402751907,
//    Latitude = -36.6971678213725,
//},
//new Municipality()
//{
//    Id = 300056,
//    Name = "La Criolla",
//    FullName = "Municipality La Criolla",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -58.112785151113,
//    Latitude = -31.2643303818445,
//},
//new Municipality()
//{
//    Id = 823904,
//    Name = "La Criolla",
//    FullName = "Comuna La Criolla",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -60.5141584434956,
//    Latitude = -30.2005196599287,
//},
//new Municipality()
//{
//    Id = 140014,
//    Name = "La Cruz",
//    FullName = "Municipality La Cruz",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -64.4805613408891,
//    Latitude = -32.310375157798,
//},
//new Municipality()
//{
//    Id = 180371,
//    Name = "La Cruz",
//    FullName = "Municipality La Cruz",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -56.9211621373659,
//    Latitude = -28.9102505511505,
//},
//new Municipality()
//{
//    Id = 140693,
//    Name = "La Cumbre",
//    FullName = "Municipality La Cumbre",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -64.5043560840515,
//    Latitude = -30.974262162703,
//},
//new Municipality()
//{
//    Id = 143015,
//    Name = "La Cumbrecita",
//    FullName = "Comuna La Cumbrecita",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -64.7864838705015,
//    Latitude = -31.8983867614231,
//},
//new Municipality()
//{
//    Id = 220266,
//    Name = "La Eduvigis",
//    FullName = "Municipality La Eduvigis",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -58.9359733143233,
//    Latitude = -26.73058120004,
//},
//new Municipality()
//{
//    Id = 220140,
//    Name = "La Escondida",
//    FullName = "Municipality La Escondida",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -59.4859379890962,
//    Latitude = -27.0950254893784,
//},
//new Municipality()
//{
//    Id = 309235,
//    Name = "La Esmeralda",
//    FullName = "Junta La Esmeralda",
//    Source = "IGN",
//    Category = "Junta",
//    Longitude = -58.5595721803424,
//    Latitude = -30.2313450684016,
//},
//new Municipality()
//{
//    Id = 908609,
//    Name = "La Esperanza",
//    FullName = "Comuna La Esperanza",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -65.2961129057995,
//    Latitude = -26.6643448728868,
//},
//new Municipality()
//{
//    Id = 380196,
//    Name = "La Esperanza",
//    FullName = "Municipality La Esperanza",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -64.7718153250282,
//    Latitude = -24.2042010107726,
//},
//new Municipality()
//{
//    Id = 140700,
//    Name = "La Falda",
//    FullName = "Municipality La Falda",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -64.5246847485076,
//    Latitude = -31.103775091991,
//},
//new Municipality()
//{
//    Id = 309155,
//    Name = "La Florida",
//    FullName = "Junta La Florida",
//    Source = "IGN",
//    Category = "Junta",
//    Longitude = -58.0440522378242,
//    Latitude = -30.6594396825302,
//},
//new Municipality()
//{
//    Id = 908105,
//    Name = "La Florida y Luisiana",
//    FullName = "Comuna La Florida y Luisiana",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -65.0493432284054,
//    Latitude = -26.811076053031,
//},
//new Municipality()
//{
//    Id = 141260,
//    Name = "La Francia",
//    FullName = "Municipality La Francia",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -62.6361489012367,
//    Latitude = -31.4046082891522,
//},
//new Municipality()
//{
//    Id = 309160,
//    Name = "La Fraternidad y Santa Juana",
//    FullName = "Junta La Fraternidad y Santa Juana",
//    Source = "IGN",
//    Category = "Junta",
//    Longitude = -58.1465494800677,
//    Latitude = -30.6428295203502,
//},
//new Municipality()
//{
//    Id = 824177,
//    Name = "La Gallareta",
//    FullName = "Comuna La Gallareta",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -60.7347043825231,
//    Latitude = -29.5313278795587,
//},
//new Municipality()
//{
//    Id = 140126,
//    Name = "La Granja",
//    FullName = "Municipality La Granja",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -64.2753880428572,
//    Latitude = -31.0000989884361,
//},
//new Municipality()
//{
//    Id = 309240,
//    Name = "La Hierra",
//    FullName = "Junta La Hierra",
//    Source = "IGN",
//    Category = "Junta",
//    Longitude = -58.4857763275131,
//    Latitude = -30.3866645083645,
//},
//new Municipality()
//{
//    Id = 142175,
//    Name = "La Higuera",
//    FullName = "Comuna La Higuera",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -65.1033033166373,
//    Latitude = -31.0154711500821,
//},
//new Municipality()
//{
//    Id = 420196,
//    Name = "La Humada",
//    FullName = "Municipality La Humada",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -67.9732522712345,
//    Latitude = -36.394146792797,
//},
//new Municipality()
//{
//    Id = 140301,
//    Name = "La Laguna",
//    FullName = "Municipality La Laguna",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -63.2462465865663,
//    Latitude = -32.8019955201198,
//},
//new Municipality()
//{
//    Id = 220049,
//    Name = "La Leonesa",
//    FullName = "Municipality La Leonesa",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -58.8469498855372,
//    Latitude = -26.9909472567457,
//},
//new Municipality()
//{
//    Id = 823575,
//    Name = "La Lucila",
//    FullName = "Comuna La Lucila",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -61.0007033082148,
//    Latitude = -30.3822950763987,
//},
//new Municipality()
//{
//    Id = 420210,
//    Name = "La Maruja",
//    FullName = "Municipality La Maruja",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -64.9958636208591,
//    Latitude = -35.614718049449,
//},
//new Municipality()
//{
//    Id = 60427,
//    Name = "La Matanza",
//    FullName = "Municipality La Matanza",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -58.6253776153662,
//    Latitude = -34.7702975343898,
//},
//new Municipality()
//{
//    Id = 380203,
//    Name = "La Mendieta",
//    FullName = "Municipality La Mendieta",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -65.0074554523481,
//    Latitude = -24.2955854751221,
//},
//new Municipality()
//{
//    Id = 660084,
//    Name = "La Merced",
//    FullName = "Municipality La Merced",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -65.3876365282091,
//    Latitude = -25.0359501291038,
//},
//new Municipality()
//{
//    Id = 309820,
//    Name = "La Ollita",
//    FullName = "Junta La Ollita",
//    Source = "IGN",
//    Category = "Junta",
//    Longitude = -59.1567112595442,
//    Latitude = -32.3975400884251,
//},
//new Municipality()
//{
//    Id = 143022,
//    Name = "La Paisanita",
//    FullName = "Comuna La Paisanita",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -64.4786608714555,
//    Latitude = -31.6984186695999,
//},
//new Municipality()
//{
//    Id = 140308,
//    Name = "La Palestina",
//    FullName = "Municipality La Palestina",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -63.4099507025161,
//    Latitude = -32.6146851668886,
//},
//new Municipality()
//{
//    Id = 143183,
//    Name = "La Pampa",
//    FullName = "Comuna La Pampa",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -64.2677377006742,
//    Latitude = -30.9460219423756,
//},
//new Municipality()
//{
//    Id = 141267,
//    Name = "La Paquita",
//    FullName = "Municipality La Paquita",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -62.215044195689,
//    Latitude = -30.9068096845912,
//},
//new Municipality()
//{
//    Id = 140903,
//    Name = "La Para",
//    FullName = "Municipality La Para",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -62.9963436324944,
//    Latitude = -30.8971059705626,
//},
//new Municipality()
//{
//    Id = 141127,
//    Name = "La Paz",
//    FullName = "Municipality La Paz",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -65.0938188358122,
//    Latitude = -32.2567777411618,
//},
//new Municipality()
//{
//    Id = 500042,
//    Name = "La Paz",
//    FullName = "Municipality La Paz",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -67.2497237114701,
//    Latitude = -33.7012852960329,
//},
//new Municipality()
//{
//    Id = 300245,
//    Name = "La Paz",
//    FullName = "Municipality La Paz",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -59.6025832377778,
//    Latitude = -30.7532931275127,
//},
//new Municipality()
//{
//    Id = 823120,
//    Name = "La Pelada",
//    FullName = "Comuna La Pelada",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -60.9334996980229,
//    Latitude = -30.8628913365548,
//},
//new Municipality()
//{
//    Id = 823911,
//    Name = "La Penca y Caraguatá",
//    FullName = "Comuna La Penca y Caraguatá",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -60.5682573680029,
//    Latitude = -30.3232009328547,
//},
//new Municipality()
//{
//    Id = 302955,
//    Name = "La Picada",
//    FullName = "Junta La Picada",
//    Source = "IGN",
//    Category = "Junta",
//    Longitude = -60.2815689794519,
//    Latitude = -31.745290686379,
//},
//new Municipality()
//{
//    Id = 60441,
//    Name = "La Plata",
//    FullName = "Municipality La Plata",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -58.0177777886065,
//    Latitude = -35.0038470156373,
//},
//new Municipality()
//{
//    Id = 142385,
//    Name = "La Playa",
//    FullName = "Comuna La Playa",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -65.3481568252418,
//    Latitude = -30.9491510500791,
//},
//new Municipality()
//{
//    Id = 140315,
//    Name = "La Playosa",
//    FullName = "Municipality La Playosa",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -63.0325027208143,
//    Latitude = -32.0989683198623,
//},
//new Municipality()
//{
//    Id = 142896,
//    Name = "La Población",
//    FullName = "Comuna La Población",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -64.9970015775698,
//    Latitude = -32.0779893261514,
//},
//new Municipality()
//{
//    Id = 660224,
//    Name = "La Poma",
//    FullName = "Municipality La Poma",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -66.2072973644748,
//    Latitude = -24.146976523836,
//},
//new Municipality()
//{
//    Id = 142679,
//    Name = "La Posta",
//    FullName = "Comuna La Posta",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -63.5150983800264,
//    Latitude = -30.5684483421589,
//},
//new Municipality()
//{
//    Id = 309465,
//    Name = "La Providencia",
//    FullName = "Junta La Providencia",
//    Source = "IGN",
//    Category = "Junta",
//    Longitude = -59.7627972601449,
//    Latitude = -31.2708284755754,
//},
//new Municipality()
//{
//    Id = 100014,
//    Name = "La Puerta",
//    FullName = "Municipality La Puerta",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -65.8056038399514,
//    Latitude = -28.160161655638,
//},
//new Municipality()
//{
//    Id = 140910,
//    Name = "La Puerta",
//    FullName = "Municipality La Puerta",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -63.2544937671194,
//    Latitude = -30.8889405990295,
//},
//new Municipality()
//{
//    Id = 746133,
//    Name = "La Punilla",
//    FullName = "Comisión La Punilla",
//    Source = "IGN",
//    Category = "Comisión",
//    Longitude = -65.1122701842079,
//    Latitude = -33.1260541635009,
//},
//new Municipality()
//{
//    Id = 740126,
//    Name = "La Punta",
//    FullName = "Municipality La Punta",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -66.358380782384,
//    Latitude = -33.1753715269299,
//},
//new Municipality()
//{
//    Id = 380406,
//    Name = "La Quiaca",
//    FullName = "Municipality La Quiaca",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -65.6541600845108,
//    Latitude = -22.1459176974769,
//},
//new Municipality()
//{
//    Id = 142686,
//    Name = "La Quinta",
//    FullName = "Comuna La Quinta",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -63.1503504553572,
//    Latitude = -31.0758714912754,
//},
//new Municipality()
//{
//    Id = 908056,
//    Name = "La Ramada y La Cruz",
//    FullName = "Comuna La Ramada y La Cruz",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -64.9033399969563,
//    Latitude = -26.6769926843144,
//},
//new Municipality()
//{
//    Id = 143029,
//    Name = "La Rancherita",
//    FullName = "Comuna La Rancherita",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -64.4614102717181,
//    Latitude = -31.755784835336,
//},
//new Municipality()
//{
//    Id = 425077,
//    Name = "La Reforma",
//    FullName = "Comisión La Reforma",
//    Source = "IGN",
//    Category = "Comisión",
//    Longitude = -66.2286938602655,
//    Latitude = -37.4347070443131,
//},
//new Municipality()
//{
//    Id = 142763,
//    Name = "La Rinconada",
//    FullName = "Comuna La Rinconada",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -62.933483718142,
//    Latitude = -30.1602808580713,
//},
//new Municipality()
//{
//    Id = 460014,
//    Name = "La Rioja",
//    FullName = "Municipality La Rioja",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -66.3526000995183,
//    Latitude = -29.4605896480157,
//},
//new Municipality()
//{
//    Id = 823582,
//    Name = "La Rubia",
//    FullName = "Comuna La Rubia",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -61.7593031348437,
//    Latitude = -30.0973769833224,
//},
//new Municipality()
//{
//    Id = 822819,
//    Name = "La Sarita",
//    FullName = "Comuna La Sarita",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -59.8866792707342,
//    Latitude = -28.9623862901012,
//},
//new Municipality()
//{
//    Id = 143036,
//    Name = "La Serranita",
//    FullName = "Comuna La Serranita",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -64.4617824313022,
//    Latitude = -31.7411366811169,
//},
//new Municipality()
//{
//    Id = 220343,
//    Name = "La Tigra",
//    FullName = "Municipality La Tigra",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -60.6153478638106,
//    Latitude = -27.0827551544955,
//},
//new Municipality()
//{
//    Id = 740042,
//    Name = "La Toma",
//    FullName = "Municipality La Toma",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -65.6356268284853,
//    Latitude = -33.0466532273873,
//},
//new Municipality()
//{
//    Id = 141274,
//    Name = "La Tordilla",
//    FullName = "Municipality La Tordilla",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -63.0622120893958,
//    Latitude = -31.2431510613549,
//},
//new Municipality()
//{
//    Id = 908189,
//    Name = "La Trinidad",
//    FullName = "Comuna La Trinidad",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -65.4991645345618,
//    Latitude = -27.4026217317087,
//},
//new Municipality()
//{
//    Id = 822476,
//    Name = "La Vanguardia",
//    FullName = "Comuna La Vanguardia",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -60.705062877763,
//    Latitude = -33.3649961070004,
//},
//new Municipality()
//{
//    Id = 309245,
//    Name = "La Verbena",
//    FullName = "Junta La Verbena",
//    Source = "IGN",
//    Category = "Junta",
//    Longitude = -58.5977687990201,
//    Latitude = -30.4588868162872,
//},
//new Municipality()
//{
//    Id = 220154,
//    Name = "La Verde",
//    FullName = "Municipality La Verde",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -59.3266785410591,
//    Latitude = -27.0715118008793,
//},
//new Municipality()
//{
//    Id = 746287,
//    Name = "La Vertiente",
//    FullName = "Comisión La Vertiente",
//    Source = "IGN",
//    Category = "Comisión",
//    Longitude = -65.7509326074213,
//    Latitude = -32.7905137798617,
//},
//new Municipality()
//{
//    Id = 660238,
//    Name = "La Viña",
//    FullName = "Municipality La Viña",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -65.6768038700482,
//    Latitude = -25.5361614596718,
//},
//new Municipality()
//{
//    Id = 141666,
//    Name = "Laborde",
//    FullName = "Municipality Laborde",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -62.8591932549994,
//    Latitude = -33.1508319281254,
//},
//new Municipality()
//{
//    Id = 822665,
//    Name = "Labordeboy",
//    FullName = "Comuna Labordeboy",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -61.2931820872879,
//    Latitude = -33.7187441454918,
//},
//new Municipality()
//{
//    Id = 140630,
//    Name = "Laboulaye",
//    FullName = "Municipality Laboulaye",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -63.3878358370211,
//    Latitude = -34.1281097677491,
//},
//new Municipality()
//{
//    Id = 746210,
//    Name = "Lafinur",
//    FullName = "Comisión Lafinur",
//    Source = "IGN",
//    Category = "Comisión",
//    Longitude = -65.3501312851382,
//    Latitude = -32.095831409637,
//},
//new Municipality()
//{
//    Id = 268112,
//    Name = "Lago Blanco",
//    FullName = "Comuna Lago Blanco",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -71.2821431559325,
//    Latitude = -45.9334874892864,
//},
//new Municipality()
//{
//    Id = 260042,
//    Name = "Lago Puelo",
//    FullName = "Municipality Lago Puelo",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -71.5667357454704,
//    Latitude = -42.0304764900034,
//},
//new Municipality()
//{
//    Id = 309250,
//    Name = "Laguna Benítez",
//    FullName = "Junta Laguna Benítez",
//    Source = "IGN",
//    Category = "Junta",
//    Longitude = -58.7284136409844,
//    Latitude = -30.5802564421807,
//},
//new Municipality()
//{
//    Id = 340196,
//    Name = "Laguna Blanca",
//    FullName = "Municipality Laguna Blanca",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -58.2696808211019,
//    Latitude = -25.1115621017047,
//},
//new Municipality()
//{
//    Id = 220238,
//    Name = "Laguna Blanca",
//    FullName = "Municipality Laguna Blanca",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -59.1908904474417,
//    Latitude = -27.2258500691526,
//},
//new Municipality()
//{
//    Id = 309895,
//    Name = "Laguna del Pescado",
//    FullName = "Junta Laguna del Pescado",
//    Source = "IGN",
//    Category = "Junta",
//    Longitude = -60.0313556044714,
//    Latitude = -32.675715224394,
//},
//new Municipality()
//{
//    Id = 141015,
//    Name = "Laguna Larga",
//    FullName = "Municipality Laguna Larga",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -63.7859839452442,
//    Latitude = -31.7757220077539,
//},
//new Municipality()
//{
//    Id = 220273,
//    Name = "Laguna Limpia",
//    FullName = "Municipality Laguna Limpia",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -59.6824364755342,
//    Latitude = -26.4160562775136,
//},
//new Municipality()
//{
//    Id = 340203,
//    Name = "Laguna Naick Neck",
//    FullName = "Municipality Laguna Naick Neck",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -58.1204495394708,
//    Latitude = -25.2202162074097,
//},
//new Municipality()
//{
//    Id = 820140,
//    Name = "Laguna Paiva",
//    FullName = "Municipality Laguna Paiva",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -60.6655561130065,
//    Latitude = -31.3039882761946,
//},
//new Municipality()
//{
//    Id = 340007,
//    Name = "Laguna Yema",
//    FullName = "Municipality Laguna Yema",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -61.2514099326116,
//    Latitude = -24.2842405514154,
//},
//new Municipality()
//{
//    Id = 268042,
//    Name = "Lagunita Salada",
//    FullName = "Comuna Lagunita Salada",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -69.1757884059083,
//    Latitude = -42.7651335003203,
//},
//new Municipality()
//{
//    Id = 908203,
//    Name = "Lamadrid",
//    FullName = "Comuna Lamadrid",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -65.1851244708632,
//    Latitude = -27.6581370698459,
//},
//new Municipality()
//{
//    Id = 620049,
//    Name = "Lamarque",
//    FullName = "Municipality Lamarque",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -65.6760547582226,
//    Latitude = -39.4033765613691,
//},
//new Municipality()
//{
//    Id = 824086,
//    Name = "Landeta",
//    FullName = "Comuna Landeta",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -62.070387272098,
//    Latitude = -32.0123964935093,
//},
//new Municipality()
//{
//    Id = 822826,
//    Name = "Lanteri",
//    FullName = "Comuna Lanteri",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -59.6773729365579,
//    Latitude = -28.8470500548159,
//},
//new Municipality()
//{
//    Id = 60434,
//    Name = "Lanús",
//    FullName = "Municipality Lanús",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -58.3947105032598,
//    Latitude = -34.7056418367328,
//},
//new Municipality()
//{
//    Id = 220147,
//    Name = "Lapachito",
//    FullName = "Municipality Lapachito",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -59.4677352222072,
//    Latitude = -27.2599448749127,
//},
//new Municipality()
//{
//    Id = 60448,
//    Name = "Laprida",
//    FullName = "Municipality Laprida",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -60.7681481810459,
//    Latitude = -37.5165055849882,
//},
//new Municipality()
//{
//    Id = 823799,
//    Name = "Larrechea",
//    FullName = "Comuna Larrechea",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -61.0603813968283,
//    Latitude = -31.9329952644909,
//},
//new Municipality()
//{
//    Id = 300196,
//    Name = "Larroque",
//    FullName = "Municipality Larroque",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -58.9955181856351,
//    Latitude = -33.0346764616383,
//},
//new Municipality()
//{
//    Id = 140833,
//    Name = "Las Acequias",
//    FullName = "Municipality Las Acequias",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -63.9782972324101,
//    Latitude = -33.280100079492,
//},
//new Municipality()
//{
//    Id = 746294,
//    Name = "Las Aguadas",
//    FullName = "Comisión Las Aguadas",
//    Source = "IGN",
//    Category = "Comisión",
//    Longitude = -65.5009524526764,
//    Latitude = -32.3754702752369,
//},
//new Municipality()
//{
//    Id = 142567,
//    Name = "Las Albahacas",
//    FullName = "Comuna Las Albahacas",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -64.8169079716602,
//    Latitude = -32.8970347535302,
//},
//new Municipality()
//{
//    Id = 141547,
//    Name = "Las Arrias",
//    FullName = "Municipality Las Arrias",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -63.5849095072048,
//    Latitude = -30.3900762225366,
//},
//new Municipality()
//{
//    Id = 823589,
//    Name = "Las Avispas",
//    FullName = "Comuna Las Avispas",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -61.2758383362012,
//    Latitude = -29.7766332416166,
//},
//new Municipality()
//{
//    Id = 142028,
//    Name = "Las Bajadas",
//    FullName = "Comuna Las Bajadas",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -64.3402635611921,
//    Latitude = -32.0921713040564,
//},
//new Municipality()
//{
//    Id = 824093,
//    Name = "Las Bandurrias",
//    FullName = "Comuna Las Bandurrias",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -61.4387670818942,
//    Latitude = -32.1422877428097,
//},
//new Municipality()
//{
//    Id = 220329,
//    Name = "Las Breñas",
//    FullName = "Municipality Las Breñas",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -61.2646116362921,
//    Latitude = -26.943638662125,
//},
//new Municipality()
//{
//    Id = 142035,
//    Name = "Las Caleras",
//    FullName = "Comuna Las Caleras",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -64.5188920061475,
//    Latitude = -32.4017331649058,
//},
//new Municipality()
//{
//    Id = 142847,
//    Name = "Las Calles",
//    FullName = "Comuna Las Calles",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -64.9288940917183,
//    Latitude = -31.8359492935492,
//},
//new Municipality()
//{
//    Id = 142182,
//    Name = "Las Cañadas",
//    FullName = "Comuna Las Cañadas",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -64.7644259351174,
//    Latitude = -30.9742278112653,
//},
//new Municipality()
//{
//    Id = 908112,
//    Name = "Las Cejas",
//    FullName = "Comuna Las Cejas",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -64.7960006339375,
//    Latitude = -26.9193145794504,
//},
//new Municipality()
//{
//    Id = 746301,
//    Name = "Las Chacras",
//    FullName = "Comisión Las Chacras",
//    Source = "IGN",
//    Category = "Comisión",
//    Longitude = -65.779605522607,
//    Latitude = -32.5633795921197,
//},
//new Municipality()
//{
//    Id = 580028,
//    Name = "Las Coloradas",
//    FullName = "Municipality Las Coloradas",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -70.5825186548328,
//    Latitude = -39.6076912117397,
//},
//new Municipality()
//{
//    Id = 302175,
//    Name = "Las Cuevas",
//    FullName = "Junta Las Cuevas",
//    Source = "IGN",
//    Category = "Junta",
//    Longitude = -60.4592442964654,
//    Latitude = -32.3450004140142,
//},
//new Municipality()
//{
//    Id = 60455,
//    Name = "Las Flores",
//    FullName = "Municipality Las Flores",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -59.1764609497077,
//    Latitude = -36.0158266570221,
//},
//new Municipality()
//{
//    Id = 220455,
//    Name = "Las Garcitas",
//    FullName = "Municipality Las Garcitas",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -59.7785379063377,
//    Latitude = -26.6211011991676,
//},
//new Municipality()
//{
//    Id = 822833,
//    Name = "Las Garzas",
//    FullName = "Comuna Las Garzas",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -59.3466108834064,
//    Latitude = -28.8485702161662,
//},
//new Municipality()
//{
//    Id = 302962,
//    Name = "Las Garzas",
//    FullName = "Junta Las Garzas",
//    Source = "IGN",
//    Category = "Junta",
//    Longitude = -59.7108860339776,
//    Latitude = -31.4752285347867,
//},
//new Municipality()
//{
//    Id = 142693,
//    Name = "Las Gramillas",
//    FullName = "Comuna Las Gramillas",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -63.2282512384188,
//    Latitude = -31.1327058377192,
//},
//new Municipality()
//{
//    Id = 309825,
//    Name = "Las Guachas",
//    FullName = "Junta Las Guachas",
//    Source = "IGN",
//    Category = "Junta",
//    Longitude = -59.1734064019042,
//    Latitude = -32.4937929449511,
//},
//new Municipality()
//{
//    Id = 500049,
//    Name = "Las Heras",
//    FullName = "Municipality Las Heras",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -69.2679038914995,
//    Latitude = -32.5246207474454,
//},
//new Municipality()
//{
//    Id = 140840,
//    Name = "Las Higueras",
//    FullName = "Municipality Las Higueras",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -64.2944375380398,
//    Latitude = -33.1041248833881,
//},
//new Municipality()
//{
//    Id = 143148,
//    Name = "Las Isletillas",
//    FullName = "Comuna Las Isletillas",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -63.9294208789592,
//    Latitude = -32.5081704675122,
//},
//new Municipality()
//{
//    Id = 100021,
//    Name = "Las Juntas",
//    FullName = "Municipality Las Juntas",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -65.9678796676309,
//    Latitude = -28.0538508564145,
//},
//new Municipality()
//{
//    Id = 141022,
//    Name = "Las Junturas",
//    FullName = "Municipality Las Junturas",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -63.4501240234635,
//    Latitude = -31.829574096629,
//},
//new Municipality()
//{
//    Id = 746308,
//    Name = "Las Lagunas",
//    FullName = "Comisión Las Lagunas",
//    Source = "IGN",
//    Category = "Comisión",
//    Longitude = -65.547997771078,
//    Latitude = -32.6286670748447,
//},
//new Municipality()
//{
//    Id = 580231,
//    Name = "Las Lajas",
//    FullName = "Municipality Las Lajas",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -70.306416622519,
//    Latitude = -38.5447244406416,
//},
//new Municipality()
//{
//    Id = 660035,
//    Name = "Las Lajitas",
//    FullName = "Municipality Las Lajitas",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -64.5741530957639,
//    Latitude = -24.9072007809319,
//},
//new Municipality()
//{
//    Id = 340133,
//    Name = "Las Lomitas",
//    FullName = "Municipality Las Lomitas",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -60.5982877565359,
//    Latitude = -24.7102155246855,
//},
//new Municipality()
//{
//    Id = 309375,
//    Name = "Las Mercedes",
//    FullName = "Junta Las Mercedes",
//    Source = "IGN",
//    Category = "Junta",
//    Longitude = -58.8801340836797,
//    Latitude = -33.175907011726,
//},
//new Municipality()
//{
//    Id = 303161,
//    Name = "Las Moscas",
//    FullName = "Junta Las Moscas",
//    Source = "IGN",
//    Category = "Junta",
//    Longitude = -58.9839717540225,
//    Latitude = -32.0987070067703,
//},
//new Municipality()
//{
//    Id = 309255,
//    Name = "Las Mulitas",
//    FullName = "Junta de gobierno Las Mulitas",
//    Source = "IGN",
//    Category = "Junta de gobierno",
//    Longitude = -59.086841935286,
//    Latitude = -30.3711212558518,
//},
//new Municipality()
//{
//    Id = 580154,
//    Name = "Las Ovejas",
//    FullName = "Municipality Las Ovejas",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -70.9180526317303,
//    Latitude = -36.8419567973675,
//},
//new Municipality()
//{
//    Id = 220056,
//    Name = "Las Palmas",
//    FullName = "Municipality Las Palmas",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -58.6763815603584,
//    Latitude = -27.124685477353,
//},
//new Municipality()
//{
//    Id = 142413,
//    Name = "Las Palmas",
//    FullName = "Comuna Las Palmas",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -65.3329790750063,
//    Latitude = -31.3748540741686,
//},
//new Municipality()
//{
//    Id = 823596,
//    Name = "Las Palmeras",
//    FullName = "Comuna Las Palmeras",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -61.6225654624814,
//    Latitude = -30.6283200044766,
//},
//new Municipality()
//{
//    Id = 820014,
//    Name = "Las Parejas",
//    FullName = "Municipality Las Parejas",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -61.5805144134389,
//    Latitude = -32.6475570583935,
//},
//new Municipality()
//{
//    Id = 141519,
//    Name = "Las Peñas",
//    FullName = "Municipality Las Peñas",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -64.0024875130835,
//    Latitude = -30.5554859462905,
//},
//new Municipality()
//{
//    Id = 142574,
//    Name = "Las Peñas Sud",
//    FullName = "Comuna Las Peñas Sud",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -64.1083139877237,
//    Latitude = -32.5334055082122,
//},
//new Municipality()
//{
//    Id = 141463,
//    Name = "Las Perdices",
//    FullName = "Municipality Las Perdices",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -63.7067140964449,
//    Latitude = -32.6989898366796,
//},
//new Municipality()
//{
//    Id = 824100,
//    Name = "Las Petacas",
//    FullName = "Comuna Las Petacas",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -62.1476801202299,
//    Latitude = -31.8169548466987,
//},
//new Municipality()
//{
//    Id = 142189,
//    Name = "Las Playas",
//    FullName = "Comuna Las Playas",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -64.8512005429178,
//    Latitude = -30.7125399415491,
//},
//new Municipality()
//{
//    Id = 268077,
//    Name = "Las Plumas",
//    FullName = "Comuna Las Plumas",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -67.2925930651808,
//    Latitude = -43.7137219194695,
//},
//new Municipality()
//{
//    Id = 142854,
//    Name = "Las Rabonas",
//    FullName = "Comuna Las Rabonas",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -64.9489427851782,
//    Latitude = -31.8709623753987,
//},
//new Municipality()
//{
//    Id = 820021,
//    Name = "Las Rosas",
//    FullName = "Municipality Las Rosas",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -61.6293536644863,
//    Latitude = -32.4624669043021,
//},
//new Municipality()
//{
//    Id = 142700,
//    Name = "Las Saladas",
//    FullName = "Comuna Las Saladas",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -63.2043193813076,
//    Latitude = -30.7601509435353,
//},
//new Municipality()
//{
//    Id = 908301,
//    Name = "Las Talas",
//    FullName = "Comuna Las Talas",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -65.2797502926443,
//    Latitude = -27.0029623254109,
//},
//new Municipality()
//{
//    Id = 900112,
//    Name = "Las Talitas",
//    FullName = "Municipality Las Talitas",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -65.1861111989092,
//    Latitude = -26.7624336434667,
//},
//new Municipality()
//{
//    Id = 141130,
//    Name = "Las Tapias",
//    FullName = "Municipality Las Tapias",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -65.1083345433213,
//    Latitude = -31.943940912657,
//},
//new Municipality()
//{
//    Id = 820098,
//    Name = "Las Toscas",
//    FullName = "Municipality Las Toscas",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -59.2487181016802,
//    Latitude = -28.3336988041574,
//},
//new Municipality()
//{
//    Id = 309470,
//    Name = "Las Toscas",
//    FullName = "Junta Las Toscas",
//    Source = "IGN",
//    Category = "Junta",
//    Longitude = -59.1210255500654,
//    Latitude = -30.4317071008309,
//},
//new Municipality()
//{
//    Id = 823127,
//    Name = "Las Tunas",
//    FullName = "Comuna Las Tunas",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -61.0124260255542,
//    Latitude = -31.5694628868887,
//},
//new Municipality()
//{
//    Id = 141281,
//    Name = "Las Varas",
//    FullName = "Municipality Las Varas",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -62.6189189981065,
//    Latitude = -31.8037220327542,
//},
//new Municipality()
//{
//    Id = 141288,
//    Name = "Las Varillas",
//    FullName = "Municipality Las Varillas",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -62.7085088077584,
//    Latitude = -31.8753386744317,
//},
//new Municipality()
//{
//    Id = 140847,
//    Name = "Las Vertientes",
//    FullName = "Municipality Las Vertientes",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -64.5798008584753,
//    Latitude = -33.2821528731581,
//},
//new Municipality()
//{
//    Id = 309565,
//    Name = "Laurencena",
//    FullName = "Junta Laurencena",
//    Source = "IGN",
//    Category = "Junta",
//    Longitude = -59.6944687394183,
//    Latitude = -32.2689628128414,
//},
//new Municipality()
//{
//    Id = 746140,
//    Name = "Lavaisse",
//    FullName = "Comisión Lavaisse",
//    Source = "IGN",
//    Category = "Comisión",
//    Longitude = -65.4243757203362,
//    Latitude = -33.8228631592664,
//},
//new Municipality()
//{
//    Id = 180203,
//    Name = "Lavalle",
//    FullName = "Municipality Lavalle",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -59.1722782939172,
//    Latitude = -29.0283430245188,
//},
//new Municipality()
//{
//    Id = 500056,
//    Name = "Lavalle",
//    FullName = "Municipality Lavalle",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -67.8966919931656,
//    Latitude = -32.5754671939909,
//},
//new Municipality()
//{
//    Id = 822672,
//    Name = "Lazzarino",
//    FullName = "Comuna Lazzarino",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -62.4179437231131,
//    Latitude = -34.2381337496838,
//},
//new Municipality()
//{
//    Id = 60462,
//    Name = "Leandro N. Alem",
//    FullName = "Municipality Leandro N. Alem",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -61.6125874743488,
//    Latitude = -34.4985652798188,
//},
//new Municipality()
//{
//    Id = 540280,
//    Name = "Leandro N. Alem",
//    FullName = "Municipality Leandro N. Alem",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -55.3300134626806,
//    Latitude = -27.6166283094126,
//},
//new Municipality()
//{
//    Id = 746007,
//    Name = "Leandro N. Alem",
//    FullName = "Comisión Leandro N. Alem",
//    Source = "IGN",
//    Category = "Comisión",
//    Longitude = -66.0526110100645,
//    Latitude = -32.4861654411152,
//},
//new Municipality()
//{
//    Id = 142448,
//    Name = "Leguizamón",
//    FullName = "Comuna Leguizamón",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -62.9791788265996,
//    Latitude = -34.20479128376,
//},
//new Municipality()
//{
//    Id = 822287,
//    Name = "Lehmann",
//    FullName = "Comuna Lehmann",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -61.4334542945861,
//    Latitude = -31.1262157668969,
//},
//new Municipality()
//{
//    Id = 908406,
//    Name = "León Rouges y Santa Rosa",
//    FullName = "Comuna León Rouges y Santa Rosa",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -65.5046906941239,
//    Latitude = -27.2212240216977,
//},
//new Municipality()
//{
//    Id = 140567,
//    Name = "Leones",
//    FullName = "Municipality Leones",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -62.2977757843412,
//    Latitude = -32.6533880566012,
//},
//new Municipality()
//{
//    Id = 60466,
//    Name = "Lezama",
//    FullName = "Municipality Lezama",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -57.8948443895462,
//    Latitude = -35.8492083919954,
//},
//new Municipality()
//{
//    Id = 303168,
//    Name = "Líbaros",
//    FullName = "Junta Líbaros",
//    Source = "IGN",
//    Category = "Junta",
//    Longitude = -58.9048939873632,
//    Latitude = -32.2618781431272,
//},
//new Municipality()
//{
//    Id = 540224,
//    Name = "Libertad",
//    FullName = "Municipality Libertad",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -54.4206259685457,
//    Latitude = -25.8492622245066,
//},
//new Municipality()
//{
//    Id = 380140,
//    Name = "Libertador General San Martín",
//    FullName = "Municipality Libertador General San Martín",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -64.8514791152124,
//    Latitude = -23.8317078549776,
//},
//new Municipality()
//{
//    Id = 425084,
//    Name = "Limay Mahuida",
//    FullName = "Comisión Limay Mahuida",
//    Source = "IGN",
//    Category = "Comisión",
//    Longitude = -66.6447934381325,
//    Latitude = -37.1076410505104,
//},
//new Municipality()
//{
//    Id = 60469,
//    Name = "Lincoln",
//    FullName = "Municipality Lincoln",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -61.6824583851322,
//    Latitude = -35.0704479695503,
//},
//new Municipality()
//{
//    Id = 822994,
//    Name = "Llambí Campbell",
//    FullName = "Comuna Llambí Campbell",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -60.6962038548304,
//    Latitude = -31.1753913273787,
//},
//new Municipality()
//{
//    Id = 60476,
//    Name = "Lobería",
//    FullName = "Municipality Lobería",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -58.6935497786696,
//    Latitude = -38.090052818611,
//},
//new Municipality()
//{
//    Id = 60483,
//    Name = "Lobos",
//    FullName = "Municipality Lobos",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -59.1457418827425,
//    Latitude = -35.2195857860094,
//},
//new Municipality()
//{
//    Id = 823309,
//    Name = "Logroño",
//    FullName = "Comuna Logroño",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -61.6819425892724,
//    Latitude = -29.4703614886803,
//},
//new Municipality()
//{
//    Id = 823806,
//    Name = "Loma Alta",
//    FullName = "Comuna Loma Alta",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -61.1810300098937,
//    Latitude = -31.9474768920799,
//},
//new Municipality()
//{
//    Id = 309210,
//    Name = "Loma Limpia",
//    FullName = "Junta Loma Limpia",
//    Source = "IGN",
//    Category = "Junta",
//    Longitude = -59.0183336451132,
//    Latitude = -30.7542062864678,
//},
//new Municipality()
//{
//    Id = 180126,
//    Name = "Lomas de Vallejos",
//    FullName = "Municipality Lomas de Vallejos",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -58.0297782561038,
//    Latitude = -27.7458870349293,
//},
//new Municipality()
//{
//    Id = 60490,
//    Name = "Lomas de Zamora",
//    FullName = "Municipality Lomas de Zamora",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -58.4240931304426,
//    Latitude = -34.7549716277843,
//},
//new Municipality()
//{
//    Id = 580126,
//    Name = "Loncopué",
//    FullName = "Municipality Loncopué",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -70.6070114096582,
//    Latitude = -38.130763669743,
//},
//new Municipality()
//{
//    Id = 100084,
//    Name = "Londres",
//    FullName = "Municipality Londres",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -67.1520653802147,
//    Latitude = -27.8560673320983,
//},
//new Municipality()
//{
//    Id = 420217,
//    Name = "Lonquimay",
//    FullName = "Municipality Lonquimay",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -63.6376677251408,
//    Latitude = -36.4918397041369,
//},
//new Municipality()
//{
//    Id = 823813,
//    Name = "López",
//    FullName = "Comuna López",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -61.2823619602637,
//    Latitude = -31.8789098537231,
//},
//new Municipality()
//{
//    Id = 180385,
//    Name = "Loreto",
//    FullName = "Municipality Loreto",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -57.2389121199914,
//    Latitude = -27.6650440663999,
//},
//new Municipality()
//{
//    Id = 540077,
//    Name = "Loreto",
//    FullName = "Municipality Loreto",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -55.5127073353509,
//    Latitude = -27.3567760317155,
//},
//new Municipality()
//{
//    Id = 268084,
//    Name = "Los Altares",
//    FullName = "Comuna Los Altares",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -68.439661239644,
//    Latitude = -43.8915368579323,
//},
//new Municipality()
//{
//    Id = 100213,
//    Name = "Los Altos",
//    FullName = "Municipality Los Altos",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -65.4509855599,
//    Latitude = -28.0403361802283,
//},
//new Municipality()
//{
//    Id = 824184,
//    Name = "Los Amores",
//    FullName = "Comuna Los Amores",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -60.2375987826809,
//    Latitude = -28.1224112693003,
//},
//new Municipality()
//{
//    Id = 908119,
//    Name = "Los Bulacio y Los Villagra",
//    FullName = "Comuna Los Bulacio y Los Villagra",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -65.2082894359798,
//    Latitude = -26.9804713238909,
//},
//new Municipality()
//{
//    Id = 824107,
//    Name = "Los Cardos",
//    FullName = "Comuna Los Cardos",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -61.6082113534931,
//    Latitude = -32.3164649856363,
//},
//new Municipality()
//{
//    Id = 585140,
//    Name = "Los Catutos",
//    FullName = "Comisión Los Catutos",
//    Source = "IGN",
//    Category = "Comisión",
//    Longitude = -70.1262364173104,
//    Latitude = -38.8289996373284,
//},
//new Municipality()
//{
//    Id = 143043,
//    Name = "Los Cedros",
//    FullName = "Comuna Los Cedros",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -64.2883373164957,
//    Latitude = -31.5311757876478,
//},
//new Municipality()
//{
//    Id = 141132,
//    Name = "Los Cerrillos",
//    FullName = "Municipality Los Cerrillos",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -65.4011673298715,
//    Latitude = -31.9507811857004,
//},
//new Municipality()
//{
//    Id = 142819,
//    Name = "Los Chañaritos",
//    FullName = "Comuna Los Chañaritos",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -63.3341908709153,
//    Latitude = -31.4014391052477,
//},
//new Municipality()
//{
//    Id = 142196,
//    Name = "Los Chañaritos",
//    FullName = "Comuna Los Chañaritos",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -64.9612218739101,
//    Latitude = -30.5735504194676,
//},
//new Municipality()
//{
//    Id = 300063,
//    Name = "Los Charrúas",
//    FullName = "Municipality Los Charrúas",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -58.1943068511944,
//    Latitude = -31.2080565218356,
//},
//new Municipality()
//{
//    Id = 585021,
//    Name = "Los Chihuidos",
//    FullName = "Comisión Los Chihuidos",
//    Source = "IGN",
//    Category = "Comisión",
//    Longitude = -69.533845122429,
//    Latitude = -38.0504241883974,
//},
//new Municipality()
//{
//    Id = 345007,
//    Name = "Los Chiriguanos",
//    FullName = "Comisión Los Chiriguanos",
//    Source = "IGN",
//    Category = "Comisión",
//    Longitude = -61.4734537946232,
//    Latitude = -24.1062577356372,
//},
//new Municipality()
//{
//    Id = 140441,
//    Name = "Los Cisnes",
//    FullName = "Municipality Los Cisnes",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -63.4708798480833,
//    Latitude = -33.3762768113126,
//},
//new Municipality()
//{
//    Id = 140707,
//    Name = "Los Cocos",
//    FullName = "Municipality Los Cocos",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -64.5025995185387,
//    Latitude = -30.9267368087353,
//},
//new Municipality()
//{
//    Id = 140021,
//    Name = "Los Cóndores",
//    FullName = "Municipality Los Cóndores",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -64.2631745779719,
//    Latitude = -32.2941267137132,
//},
//new Municipality()
//{
//    Id = 300115,
//    Name = "Los Conquistadores",
//    FullName = "Municipality Los Conquistadores",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -58.4380865127355,
//    Latitude = -30.5979488208928,
//},
//new Municipality()
//{
//    Id = 220014,
//    Name = "Los Frentones",
//    FullName = "Municipality Los Frentones",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -61.4745317163605,
//    Latitude = -26.0355674233695,
//},
//new Municipality()
//{
//    Id = 908308,
//    Name = "Los Gómez",
//    FullName = "Comuna Los Gómez",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -65.1916387595096,
//    Latitude = -27.3059495636582,
//},
//new Municipality()
//{
//    Id = 540392,
//    Name = "Los Helechos",
//    FullName = "Municipality Los Helechos",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -55.0593874594698,
//    Latitude = -27.570657037766,
//},
//new Municipality()
//{
//    Id = 142917,
//    Name = "Los Hornillos",
//    FullName = "Comuna Los Hornillos",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -64.9874489446816,
//    Latitude = -31.8985332121067,
//},
//new Municipality()
//{
//    Id = 142770,
//    Name = "Los Hoyos",
//    FullName = "Comuna Los Hoyos",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -63.6266756739874,
//    Latitude = -29.7848497549882,
//},
//new Municipality()
//{
//    Id = 822840,
//    Name = "Los Laureles",
//    FullName = "Comuna Los Laureles",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -59.6869269518808,
//    Latitude = -29.3713409435461,
//},
//new Municipality()
//{
//    Id = 740035,
//    Name = "Los Manantiales",
//    FullName = "Municipality Los Manantiales",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -66.4507834261469,
//    Latitude = -32.6659194099238,
//},
//new Municipality()
//{
//    Id = 620259,
//    Name = "Los Menucos",
//    FullName = "Municipality Los Menucos",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -68.0872678793282,
//    Latitude = -40.8278353998143,
//},
//new Municipality()
//{
//    Id = 580161,
//    Name = "Los Miches",
//    FullName = "Municipality Los Miches",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -70.9641429516687,
//    Latitude = -37.147205626003,
//},
//new Municipality()
//{
//    Id = 143190,
//    Name = "Los Mistoles",
//    FullName = "Comuna Los Mistoles",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -63.8831334918174,
//    Latitude = -30.6263459398011,
//},
//new Municipality()
//{
//    Id = 822077,
//    Name = "Los Molinos",
//    FullName = "Comuna Los Molinos",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -61.3515661128622,
//    Latitude = -33.0630760180735,
//},
//new Municipality()
//{
//    Id = 142042,
//    Name = "Los Molinos",
//    FullName = "Comuna Los Molinos",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -64.3791077709758,
//    Latitude = -31.8565529914328,
//},
//new Municipality()
//{
//    Id = 746217,
//    Name = "Los Molles",
//    FullName = "Comisión Los Molles",
//    Source = "IGN",
//    Category = "Comisión",
//    Longitude = -64.999142511124,
//    Latitude = -32.4541663402329,
//},
//new Municipality()
//{
//    Id = 908616,
//    Name = "Los Nogales",
//    FullName = "Comuna Los Nogales",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -65.2072325200763,
//    Latitude = -26.6961550493858,
//},
//new Municipality()
//{
//    Id = 908126,
//    Name = "Los Pereyra",
//    FullName = "Comuna Los Pereyra",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -64.8560265808396,
//    Latitude = -27.0068551919257,
//},
//new Municipality()
//{
//    Id = 908133,
//    Name = "Los Pérez",
//    FullName = "Comuna Los Pérez",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -64.9083987407237,
//    Latitude = -26.8256098125205,
//},
//new Municipality()
//{
//    Id = 142287,
//    Name = "Los Pozos",
//    FullName = "Comuna Los Pozos",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -64.2649072102661,
//    Latitude = -30.5184524098874,
//},
//new Municipality()
//{
//    Id = 908315,
//    Name = "Los Puestos",
//    FullName = "Comuna Los Puestos",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -65.0370198977147,
//    Latitude = -27.3072691020917,
//},
//new Municipality()
//{
//    Id = 822084,
//    Name = "Los Quirquinchos",
//    FullName = "Comuna Los Quirquinchos",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -61.715753522792,
//    Latitude = -33.3121265052355,
//},
//new Municipality()
//{
//    Id = 908140,
//    Name = "Los Ralos",
//    FullName = "Comuna Los Ralos",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -64.9494845475381,
//    Latitude = -26.9077273561348,
//},
//new Municipality()
//{
//    Id = 142049,
//    Name = "Los Reartes",
//    FullName = "Comuna Los Reartes",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -64.589835261387,
//    Latitude = -31.9153125303581,
//},
//new Municipality()
//{
//    Id = 908469,
//    Name = "Los Sarmiento y La Tipa",
//    FullName = "Comuna Los Sarmiento y La Tipa",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -65.7026761989795,
//    Latitude = -27.408030917413,
//},
//new Municipality()
//{
//    Id = 908413,
//    Name = "Los Sosa",
//    FullName = "Comuna Los Sosa",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -65.604183198127,
//    Latitude = -27.0513671257296,
//},
//new Municipality()
//{
//    Id = 140574,
//    Name = "Los Surgentes",
//    FullName = "Municipality Los Surgentes",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -62.0146845594701,
//    Latitude = -32.9743449135051,
//},
//new Municipality()
//{
//    Id = 824188,
//    Name = "Los Tábanos",
//    FullName = "Comuna Los Tábanos",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -59.9317805290953,
//    Latitude = -28.4506433034348,
//},
//new Municipality()
//{
//    Id = 142420,
//    Name = "Los Talares",
//    FullName = "Comuna Los Talares",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -65.0582614556418,
//    Latitude = -31.4025933534643,
//},
//new Municipality()
//{
//    Id = 660399,
//    Name = "Los Toldos",
//    FullName = "Municipality Los Toldos",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -64.6676918069089,
//    Latitude = -22.4668481031179,
//},
//new Municipality()
//{
//    Id = 100028,
//    Name = "Los Varela",
//    FullName = "Municipality Los Varela",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -65.9250907140015,
//    Latitude = -27.8560627521808,
//},
//new Municipality()
//{
//    Id = 141470,
//    Name = "Los Zorros",
//    FullName = "Municipality Los Zorros",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -63.206390478408,
//    Latitude = -32.0450607623549,
//},
//new Municipality()
//{
//    Id = 425091,
//    Name = "Loventué",
//    FullName = "Comisión Loventué",
//    Source = "IGN",
//    Category = "Comisión",
//    Longitude = -65.2509072183928,
//    Latitude = -36.1714156293294,
//},
//new Municipality()
//{
//    Id = 141386,
//    Name = "Lozada",
//    FullName = "Municipality Lozada",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -64.093711769734,
//    Latitude = -31.6546099199272,
//},
//new Municipality()
//{
//    Id = 420224,
//    Name = "Luan Toro",
//    FullName = "Municipality Luan Toro",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -65.0238355387474,
//    Latitude = -36.2206007718157,
//},
//new Municipality()
//{
//    Id = 140322,
//    Name = "Luca",
//    FullName = "Municipality Luca",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -63.4773914681507,
//    Latitude = -32.5401247632302,
//},
//new Municipality()
//{
//    Id = 300280,
//    Name = "Lucas González",
//    FullName = "Municipality Lucas González",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -59.5267056463499,
//    Latitude = -32.4038064612784,
//},
//new Municipality()
//{
//    Id = 309935,
//    Name = "Lucas Norte",
//    FullName = "Junta Lucas Norte",
//    Source = "IGN",
//    Category = "Junta",
//    Longitude = -58.9062673649645,
//    Latitude = -31.3780947788113,
//},
//new Municipality()
//{
//    Id = 309940,
//    Name = "Lucas Sur Primero",
//    FullName = "Junta Lucas Sur Primero",
//    Source = "IGN",
//    Category = "Junta",
//    Longitude = -59.0304590706128,
//    Latitude = -31.7064046347178,
//},
//new Municipality()
//{
//    Id = 309945,
//    Name = "Lucas Sur Segundo",
//    FullName = "Junta Lucas Sur Segundo",
//    Source = "IGN",
//    Category = "Junta",
//    Longitude = -58.7635503252718,
//    Latitude = -31.5313645518093,
//},
//new Municipality()
//{
//    Id = 822910,
//    Name = "Lucio V. López",
//    FullName = "Comuna Lucio V. López",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -61.0737388987405,
//    Latitude = -32.7559630469021,
//},
//new Municipality()
//{
//    Id = 141554,
//    Name = "Lucio Victorio Mansilla",
//    FullName = "Municipality Lucio Victorio Mansilla",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -64.6680541082337,
//    Latitude = -29.7949326862785,
//},
//new Municipality()
//{
//    Id = 620056,
//    Name = "Luis Beltrán",
//    FullName = "Municipality Luis Beltrán",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -65.7884034239856,
//    Latitude = -39.3123503068971,
//},
//new Municipality()
//{
//    Id = 824002,
//    Name = "Luis Palacios",
//    FullName = "Comuna Luis Palacios",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -60.957583783976,
//    Latitude = -32.7771413141728,
//},
//new Municipality()
//{
//    Id = 740014,
//    Name = "Luján",
//    FullName = "Municipality Luján",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -65.9357732041203,
//    Latitude = -32.3650001808655,
//},
//new Municipality()
//{
//    Id = 60497,
//    Name = "Luján",
//    FullName = "Municipality Luján",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -59.1584564399662,
//    Latitude = -34.5673224195589,
//},
//new Municipality()
//{
//    Id = 500063,
//    Name = "Luján de Cuyo",
//    FullName = "Municipality Luján de Cuyo",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -69.4516850524047,
//    Latitude = -33.0384947617688,
//},
//new Municipality()
//{
//    Id = 141029,
//    Name = "Luque",
//    FullName = "Municipality Luque",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -63.3411184061502,
//    Latitude = -31.6466335826392,
//},
//new Municipality()
//{
//    Id = 142056,
//    Name = "Lutti",
//    FullName = "Comuna Lutti",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -64.7377888610502,
//    Latitude = -32.3065734326697,
//},
//new Municipality()
//{
//    Id = 142924,
//    Name = "Luyaba",
//    FullName = "Comuna Luyaba",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -65.0741168663064,
//    Latitude = -32.1482687509277,
//},
//new Municipality()
//{
//    Id = 420231,
//    Name = "Macachín",
//    FullName = "Municipality Macachín",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -63.6943937231595,
//    Latitude = -37.1229550530721,
//},
//new Municipality()
//{
//    Id = 220476,
//    Name = "Machagai",
//    FullName = "Municipality Machagai",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -60.0209562221562,
//    Latitude = -26.8187751129695,
//},
//new Municipality()
//{
//    Id = 300399,
//    Name = "Maciá",
//    FullName = "Municipality Maciá",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -59.389511194692,
//    Latitude = -32.1686704478073,
//},
//new Municipality()
//{
//    Id = 823820,
//    Name = "Maciel",
//    FullName = "Comuna Maciel",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -60.9354621768375,
//    Latitude = -32.4308360057941,
//},
//new Municipality()
//{
//    Id = 60505,
//    Name = "Magdalena",
//    FullName = "Municipality Magdalena",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -57.6861279818118,
//    Latitude = -35.1851030703307,
//},
//new Municipality()
//{
//    Id = 822679,
//    Name = "Maggiolo",
//    FullName = "Comuna Maggiolo",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -62.2598354811198,
//    Latitude = -33.7395576933421,
//},
//new Municipality()
//{
//    Id = 380322,
//    Name = "Maimará",
//    FullName = "Municipality Maimará",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -65.4383186260968,
//    Latitude = -23.6406895812876,
//},
//new Municipality()
//{
//    Id = 620175,
//    Name = "Mainqué",
//    FullName = "Municipality Mainqué",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -67.319140513453,
//    Latitude = -38.8398793735933,
//},
//new Municipality()
//{
//    Id = 500070,
//    Name = "Maipú",
//    FullName = "Municipality Maipú",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -68.6563133629426,
//    Latitude = -32.9797495635853,
//},
//new Municipality()
//{
//    Id = 60511,
//    Name = "Maipú",
//    FullName = "Municipality Maipú",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -57.5861191040426,
//    Latitude = -36.886933208213,
//},
//new Municipality()
//{
//    Id = 425098,
//    Name = "Maisonave",
//    FullName = "Comisión Maisonave",
//    Source = "IGN",
//    Category = "Comisión",
//    Longitude = -64.4002298158983,
//    Latitude = -35.0504261797882,
//},
//new Municipality()
//{
//    Id = 220161,
//    Name = "Makallé",
//    FullName = "Municipality Makallé",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -59.2311898844205,
//    Latitude = -27.1115658242819,
//},
//new Municipality()
//{
//    Id = 820105,
//    Name = "Malabrigo",
//    FullName = "Municipality Malabrigo",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -59.9197683450242,
//    Latitude = -29.3304443851242,
//},
//new Municipality()
//{
//    Id = 141393,
//    Name = "Malagueño",
//    FullName = "Municipality Malagueño",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -64.3967893605307,
//    Latitude = -31.4598780400571,
//},
//new Municipality()
//{
//    Id = 500077,
//    Name = "Malargüe",
//    FullName = "Municipality Malargüe",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -69.3130810458162,
//    Latitude = -36.158940029833,
//},
//new Municipality()
//{
//    Id = 142581,
//    Name = "Malena",
//    FullName = "Comuna Malena",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -64.4317442961675,
//    Latitude = -33.4904506753776,
//},
//new Municipality()
//{
//    Id = 60515,
//    Name = "Malvinas Argentinas",
//    FullName = "Municipality Malvinas Argentinas",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -58.712137241603,
//    Latitude = -34.4873113444584,
//},
//new Municipality()
//{
//    Id = 140133,
//    Name = "Malvinas Argentinas",
//    FullName = "Municipality Malvinas Argentinas",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -64.010456668808,
//    Latitude = -31.3908457180367,
//},
//new Municipality()
//{
//    Id = 141036,
//    Name = "Manfredi",
//    FullName = "Municipality Manfredi",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -63.7430657929285,
//    Latitude = -31.8442770336696,
//},
//new Municipality()
//{
//    Id = 908322,
//    Name = "Manuel García Fernández",
//    FullName = "Comuna Manuel García Fernández",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -65.2814054870016,
//    Latitude = -26.9597092624779,
//},
//new Municipality()
//{
//    Id = 908511,
//    Name = "Manuela Pedraza",
//    FullName = "Comuna Manuela Pedraza",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -65.3304642434151,
//    Latitude = -27.2416094724734,
//},
//new Municipality()
//{
//    Id = 585084,
//    Name = "Manzano Amargo",
//    FullName = "Comisión Manzano Amargo",
//    Source = "IGN",
//    Category = "Comisión",
//    Longitude = -70.8071507874495,
//    Latitude = -36.6887545268325,
//},
//new Municipality()
//{
//    Id = 620266,
//    Name = "Maquinchao",
//    FullName = "Municipality Maquinchao",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -68.6876220050646,
//    Latitude = -41.2429059136969,
//},
//new Municipality()
//{
//    Id = 142707,
//    Name = "Maquinista Gallini",
//    FullName = "Comuna Maquinista Gallini",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -63.5346280358156,
//    Latitude = -30.9181978256885,
//},
//new Municipality()
//{
//    Id = 60518,
//    Name = "Mar Chiquita",
//    FullName = "Municipality Mar Chiquita",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -57.6432660560012,
//    Latitude = -37.4986405981689,
//},
//new Municipality()
//{
//    Id = 823918,
//    Name = "Marcelino Escalada",
//    FullName = "Comuna Marcelino Escalada",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -60.4264245992667,
//    Latitude = -30.6080397945185,
//},
//new Municipality()
//{
//    Id = 140581,
//    Name = "Marcos Juárez",
//    FullName = "Municipality Marcos Juárez",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -62.1053184551731,
//    Latitude = -32.683463469915,
//},
//new Municipality()
//{
//    Id = 60525,
//    Name = "Marcos Paz",
//    FullName = "Municipality Marcos Paz",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -58.8478312046572,
//    Latitude = -34.8140029646158,
//},
//new Municipality()
//{
//    Id = 824191,
//    Name = "Margarita",
//    FullName = "Comuna Margarita",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -60.1474618870496,
//    Latitude = -29.7499448234733,
//},
//new Municipality()
//{
//    Id = 220371,
//    Name = "Margarita Belén",
//    FullName = "Municipality Margarita Belén",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -59.0185669247617,
//    Latitude = -27.0874154291452,
//},
//new Municipality()
//{
//    Id = 300322,
//    Name = "María Grande",
//    FullName = "Municipality María Grande",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -59.8928362166889,
//    Latitude = -31.6631641137874,
//},
//new Municipality()
//{
//    Id = 309705,
//    Name = "María Grande 2º",
//    FullName = "Junta María Grande 2º",
//    Source = "IGN",
//    Category = "Junta",
//    Longitude = -59.6239432643462,
//    Latitude = -31.6615980230006,
//},
//new Municipality()
//{
//    Id = 822294,
//    Name = "María Juana",
//    FullName = "Comuna María Juana",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -61.7508020504514,
//    Latitude = -31.6755447810496,
//},
//new Municipality()
//{
//    Id = 309580,
//    Name = "Maria Luisa",
//    FullName = "Municipality Maria Luisa",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -60.3896403160832,
//    Latitude = -31.8817986790547,
//},
//new Municipality()
//{
//    Id = 823134,
//    Name = "María Luisa",
//    FullName = "Comuna María Luisa",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -60.8916036083609,
//    Latitude = -31.0187839006473,
//},
//new Municipality()
//{
//    Id = 824114,
//    Name = "María Susana",
//    FullName = "Comuna María Susana",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -61.9243002539783,
//    Latitude = -32.2566608255675,
//},
//new Municipality()
//{
//    Id = 822686,
//    Name = "María Teresa",
//    FullName = "Comuna María Teresa",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -61.9128668122658,
//    Latitude = -34.0395665841678,
//},
//new Municipality()
//{
//    Id = 180238,
//    Name = "Mariano I. Loza",
//    FullName = "Municipality Mariano I. Loza",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -58.1655432344099,
//    Latitude = -29.3427679928704,
//},
//new Municipality()
//{
//    Id = 580238,
//    Name = "Mariano Moreno",
//    FullName = "Municipality Mariano Moreno",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -70.0160273047412,
//    Latitude = -38.768792734218,
//},
//new Municipality()
//{
//    Id = 540084,
//    Name = "Mártires",
//    FullName = "Municipality Mártires",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -55.3818728044907,
//    Latitude = -27.4192743725195,
//},
//new Municipality()
//{
//    Id = 141295,
//    Name = "Marull",
//    FullName = "Municipality Marull",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -62.8244615926655,
//    Latitude = -30.9962750605161,
//},
//new Municipality()
//{
//    Id = 823141,
//    Name = "Matilde",
//    FullName = "Comuna Matilde",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -61.0206835645734,
//    Latitude = -31.7909169859048,
//},
//new Municipality()
//{
//    Id = 141043,
//    Name = "Matorrales",
//    FullName = "Municipality Matorrales",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -63.5124530187689,
//    Latitude = -31.7149605696137,
//},
//new Municipality()
//{
//    Id = 140245,
//    Name = "Mattaldi",
//    FullName = "Municipality Mattaldi",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -64.1779147615067,
//    Latitude = -34.4853031976435,
//},
//new Municipality()
//{
//    Id = 420238,
//    Name = "Mauricio Mayer",
//    FullName = "Municipality Mauricio Mayer",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -64.068811027861,
//    Latitude = -36.2357896412003,
//},
//new Municipality()
//{
//    Id = 822483,
//    Name = "Máximo Paz",
//    FullName = "Comuna Máximo Paz",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -60.9633428047038,
//    Latitude = -33.5043850537653,
//},
//new Municipality()
//{
//    Id = 340231,
//    Name = "Mayor Villafañe",
//    FullName = "Municipality Mayor Villafañe",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -59.0807489037343,
//    Latitude = -26.2043809484768,
//},
//new Municipality()
//{
//    Id = 142504,
//    Name = "Mayu Sumaj",
//    FullName = "Comuna Mayu Sumaj",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -64.549632214915,
//    Latitude = -31.4660174565973,
//},
//new Municipality()
//{
//    Id = 180224,
//    Name = "Mburucuyá",
//    FullName = "Municipality Mburucuyá",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -58.1855639983094,
//    Latitude = -28.0163838980407,
//},
//new Municipality()
//{
//    Id = 309405,
//    Name = "Médanos",
//    FullName = "Junta Médanos",
//    Source = "IGN",
//    Category = "Junta",
//    Longitude = -59.0688251876226,
//    Latitude = -33.4357059490256,
//},
//new Municipality()
//{
//    Id = 142203,
//    Name = "Media Naranja",
//    FullName = "Comuna Media Naranja",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -64.9392510631274,
//    Latitude = -30.6312650658571,
//},
//new Municipality()
//{
//    Id = 908196,
//    Name = "Medina",
//    FullName = "Comuna Medina",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -65.5446200982361,
//    Latitude = -27.389637485998,
//},
//new Municipality()
//{
//    Id = 822693,
//    Name = "Melincué",
//    FullName = "Comuna Melincué",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -61.4800391615747,
//    Latitude = -33.6716299274232,
//},
//new Municipality()
//{
//    Id = 140637,
//    Name = "Melo",
//    FullName = "Municipality Melo",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -63.4365776529174,
//    Latitude = -34.3493518732702,
//},
//new Municipality()
//{
//    Id = 140140,
//    Name = "Mendiolaza",
//    FullName = "Municipality Mendiolaza",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -64.2848467061892,
//    Latitude = -31.2585432498765,
//},
//new Municipality()
//{
//    Id = 500007,
//    Name = "Mendoza",
//    FullName = "Municipality Mendoza",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -68.8936488018201,
//    Latitude = -32.8828960440429,
//},
//new Municipality()
//{
//    Id = 60532,
//    Name = "Mercedes",
//    FullName = "Municipality Mercedes",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -59.4204811393568,
//    Latitude = -34.6973213261429,
//},
//new Municipality()
//{
//    Id = 180245,
//    Name = "Mercedes",
//    FullName = "Municipality Mercedes",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -57.7596421804937,
//    Latitude = -29.0543582301235,
//},
//new Municipality()
//{
//    Id = 60539,
//    Name = "Merlo",
//    FullName = "Municipality Merlo",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -58.7419584139763,
//    Latitude = -34.7110032783081,
//},
//new Municipality()
//{
//    Id = 420245,
//    Name = "Metileo",
//    FullName = "Municipality Metileo",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -63.9455158938857,
//    Latitude = -35.8187533133228,
//},
//new Municipality()
//{
//    Id = 140143,
//    Name = "Mi Granja",
//    FullName = "Municipality Mi Granja",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -63.9790002860559,
//    Latitude = -31.3275574708938,
//},
//new Municipality()
//{
//    Id = 420252,
//    Name = "Miguel Cané",
//    FullName = "Municipality Miguel Cané",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -63.5209610057199,
//    Latitude = -36.1708822456872,
//},
//new Municipality()
//{
//    Id = 420259,
//    Name = "Miguel Riglos",
//    FullName = "Municipality Miguel Riglos",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -63.7976877061259,
//    Latitude = -36.8320346409295,
//},
//new Municipality()
//{
//    Id = 822700,
//    Name = "Miguel Torres",
//    FullName = "Comuna Miguel Torres",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -61.4455173944841,
//    Latitude = -33.535830247457,
//},
//new Municipality()
//{
//    Id = 141092,
//    Name = "Mina Clavero",
//    FullName = "Municipality Mina Clavero",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -64.9145503162389,
//    Latitude = -31.6760818624495,
//},
//new Municipality()
//{
//    Id = 386070,
//    Name = "Mina Pirquitas",
//    FullName = "Comisión Mina Pirquitas",
//    Source = "IGN",
//    Category = "Comisión",
//    Longitude = -66.6333146524099,
//    Latitude = -22.718377915777,
//},
//new Municipality()
//{
//    Id = 620189,
//    Name = "Ministro Ramos Mexía",
//    FullName = "Municipality Ministro Ramos Mexía",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -67.2559665168024,
//    Latitude = -40.5009574204683,
//},
//new Municipality()
//{
//    Id = 220189,
//    Name = "Miraflores",
//    FullName = "Municipality Miraflores",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -61.0366219170952,
//    Latitude = -25.4779569965069,
//},
//new Municipality()
//{
//    Id = 141302,
//    Name = "Miramar de Ansenuza",
//    FullName = "Municipality Miramar de Ansenuza",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -62.6691619837422,
//    Latitude = -30.9171637587504,
//},
//new Municipality()
//{
//    Id = 220196,
//    Name = "Misión Nueva Pompeya",
//    FullName = "Municipality Misión Nueva Pompeya",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -61.5529901499384,
//    Latitude = -24.9918396458714,
//},
//new Municipality()
//{
//    Id = 340063,
//    Name = "Misión San Francisco de Laishi",
//    FullName = "Municipality Misión San Francisco de Laishi",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -58.6312572039416,
//    Latitude = -26.2415655637698,
//},
//new Municipality()
//{
//    Id = 340175,
//    Name = "Misión Tacaaglé",
//    FullName = "Municipality Misión Tacaaglé",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -58.8239429494864,
//    Latitude = -24.9729365739169,
//},
//new Municipality()
//{
//    Id = 180266,
//    Name = "Mocoretá",
//    FullName = "Municipality Mocoretá",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -57.9577187222857,
//    Latitude = -30.5487362972903,
//},
//new Municipality()
//{
//    Id = 823603,
//    Name = "Moisés Ville",
//    FullName = "Comuna Moisés Ville",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -61.4705123255217,
//    Latitude = -30.6313833495721,
//},
//new Municipality()
//{
//    Id = 540490,
//    Name = "Mojón Grande",
//    FullName = "Municipality Mojón Grande",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -55.1202260917293,
//    Latitude = -27.7257081241578,
//},
//new Municipality()
//{
//    Id = 309950,
//    Name = "Mojones Norte",
//    FullName = "Junta Mojones Norte",
//    Source = "IGN",
//    Category = "Junta",
//    Longitude = -59.1923396320979,
//    Latitude = -31.4376990451358,
//},
//new Municipality()
//{
//    Id = 309955,
//    Name = "Mojones Sur",
//    FullName = "Junta Mojones Sur",
//    Source = "IGN",
//    Category = "Junta",
//    Longitude = -59.2504623092929,
//    Latitude = -31.6225312083365,
//},
//new Municipality()
//{
//    Id = 309900,
//    Name = "Molino Doll",
//    FullName = "Junta Molino Doll",
//    Source = "IGN",
//    Category = "Junta",
//    Longitude = -60.4175525556772,
//    Latitude = -32.3079494098503,
//},
//new Municipality()
//{
//    Id = 660273,
//    Name = "Molinos",
//    FullName = "Municipality Molinos",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -66.493578128033,
//    Latitude = -25.6746713330788,
//},
//new Municipality()
//{
//    Id = 823610,
//    Name = "Monigotes",
//    FullName = "Comuna Monigotes",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -61.6110098359563,
//    Latitude = -30.5069495186875,
//},
//new Municipality()
//{
//    Id = 823827,
//    Name = "Monje",
//    FullName = "Comuna Monje",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -60.8606974316756,
//    Latitude = -32.330549025794,
//},
//new Municipality()
//{
//    Id = 60547,
//    Name = "Monte",
//    FullName = "Municipality Monte",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -58.767235838229,
//    Latitude = -35.5098267581847,
//},
//new Municipality()
//{
//    Id = 908476,
//    Name = "Monte Bello",
//    FullName = "Comuna Monte Bello",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -65.8621665950609,
//    Latitude = -27.4152129785497,
//},
//new Municipality()
//{
//    Id = 140588,
//    Name = "Monte Buey",
//    FullName = "Municipality Monte Buey",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -62.4531499125634,
//    Latitude = -32.9169889907274,
//},
//new Municipality()
//{
//    Id = 180273,
//    Name = "Monte Caseros",
//    FullName = "Municipality Monte Caseros",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -57.8245099000309,
//    Latitude = -30.181629569789,
//},
//new Municipality()
//{
//    Id = 140854,
//    Name = "Monte de los Gauchos",
//    FullName = "Municipality Monte de los Gauchos",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -63.9021542907733,
//    Latitude = -33.6360402332081,
//},
//new Municipality()
//{
//    Id = 60553,
//    Name = "Monte Hermoso",
//    FullName = "Municipality Monte Hermoso",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -61.2921466954973,
//    Latitude = -38.9616237886799,
//},
//new Municipality()
//{
//    Id = 141673,
//    Name = "Monte Leña",
//    FullName = "Municipality Monte Leña",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -62.5887953092074,
//    Latitude = -32.6073407618879,
//},
//new Municipality()
//{
//    Id = 141680,
//    Name = "Monte Maíz",
//    FullName = "Municipality Monte Maíz",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -62.6035104209721,
//    Latitude = -33.2059969112394,
//},
//new Municipality()
//{
//    Id = 420266,
//    Name = "Monte Nievas",
//    FullName = "Municipality Monte Nievas",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -64.1173404837496,
//    Latitude = -35.8739584851847,
//},
//new Municipality()
//{
//    Id = 823617,
//    Name = "Monte Oscuridad",
//    FullName = "Comuna Monte Oscuridad",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -62.0529968799857,
//    Latitude = -30.4621970412471,
//},
//new Municipality()
//{
//    Id = 141400,
//    Name = "Monte Ralo",
//    FullName = "Municipality Monte Ralo",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -64.2355903371878,
//    Latitude = -31.9160854413818,
//},
//new Municipality()
//{
//    Id = 309305,
//    Name = "Monte Redondo",
//    FullName = "Junta Monte Redondo",
//    Source = "IGN",
//    Category = "Junta",
//    Longitude = -59.8213463646919,
//    Latitude = -32.8957021272041,
//},
//new Municipality()
//{
//    Id = 823001,
//    Name = "Monte Vera",
//    FullName = "Comuna Monte Vera",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -60.6571879491945,
//    Latitude = -31.521606263408,
//},
//new Municipality()
//{
//    Id = 908518,
//    Name = "Monteagudo",
//    FullName = "Comuna Monteagudo",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -65.1749126555873,
//    Latitude = -27.4867072147836,
//},
//new Municipality()
//{
//    Id = 540343,
//    Name = "Montecarlo",
//    FullName = "Municipality Montecarlo",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -54.5625759116942,
//    Latitude = -26.6397797294372,
//},
//new Municipality()
//{
//    Id = 140917,
//    Name = "Montecristo",
//    FullName = "Municipality Montecristo",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -63.9009959978295,
//    Latitude = -31.314550167378,
//},
//new Municipality()
//{
//    Id = 823316,
//    Name = "Montefiore",
//    FullName = "Comuna Montefiore",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -61.8790495190411,
//    Latitude = -29.6239757651859,
//},
//new Municipality()
//{
//    Id = 900084,
//    Name = "Monteros",
//    FullName = "Municipality Monteros",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -65.4729583477812,
//    Latitude = -27.1804891520878,
//},
//new Municipality()
//{
//    Id = 380063,
//    Name = "Monterrico",
//    FullName = "Municipality Monterrico",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -65.1352241873094,
//    Latitude = -24.4593053596977,
//},
//new Municipality()
//{
//    Id = 822014,
//    Name = "Montes de Oca",
//    FullName = "Comuna Montes de Oca",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -61.7899322201182,
//    Latitude = -32.6303718987846,
//},
//new Municipality()
//{
//    Id = 309905,
//    Name = "Montoya",
//    FullName = "Junta Montoya",
//    Source = "IGN",
//    Category = "Junta",
//    Longitude = -59.8542718806859,
//    Latitude = -32.5809513492076,
//},
//new Municipality()
//{
//    Id = 60560,
//    Name = "Moreno",
//    FullName = "Municipality Moreno",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -58.8108985084533,
//    Latitude = -34.6106807864957,
//},
//new Municipality()
//{
//    Id = 60568,
//    Name = "Morón",
//    FullName = "Municipality Morón",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -58.6198317111492,
//    Latitude = -34.6493861631091,
//},
//new Municipality()
//{
//    Id = 141687,
//    Name = "Morrison",
//    FullName = "Municipality Morrison",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -62.8337927569311,
//    Latitude = -32.592916342672,
//},
//new Municipality()
//{
//    Id = 141309,
//    Name = "Morteros",
//    FullName = "Municipality Morteros",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -62.0091537289314,
//    Latitude = -30.7117689159368,
//},
//new Municipality()
//{
//    Id = 309260,
//    Name = "Mulas Grandes",
//    FullName = "Junta Mulas Grandes",
//    Source = "IGN",
//    Category = "Junta",
//    Longitude = -59.0259234387371,
//    Latitude = -30.3397054471504,
//},
//new Municipality()
//{
//    Id = 822707,
//    Name = "Murphy",
//    FullName = "Comuna Murphy",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -61.8493297977916,
//    Latitude = -33.5651286316929,
//},
//new Municipality()
//{
//    Id = 100185,
//    Name = "Mutquin",
//    FullName = "Municipality Mutquin",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -66.1482155126699,
//    Latitude = -28.3103105886582,
//},
//new Municipality()
//{
//    Id = 740073,
//    Name = "Nación Ranquel",
//    FullName = "Municipality Nación Ranquel",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -65.9653785506033,
//    Latitude = -34.5620777515827,
//},
//new Municipality()
//{
//    Id = 220224,
//    Name = "Napenay",
//    FullName = "Municipality Napenay",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -60.6304337465891,
//    Latitude = -26.678742908464,
//},
//new Municipality()
//{
//    Id = 823925,
//    Name = "Naré",
//    FullName = "Comuna Naré",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -60.4468906702702,
//    Latitude = -30.9770832773005,
//},
//new Municipality()
//{
//    Id = 740056,
//    Name = "Naschel",
//    FullName = "Municipality Naschel",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -65.3862894779729,
//    Latitude = -32.8995705014187,
//},
//new Municipality()
//{
//    Id = 60574,
//    Name = "Navarro",
//    FullName = "Municipality Navarro",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -59.4293585541158,
//    Latitude = -35.0304844816238,
//},
//new Municipality()
//{
//    Id = 746189,
//    Name = "Navia",
//    FullName = "Comisión Navia",
//    Source = "IGN",
//    Category = "Comisión",
//    Longitude = -66.5655634245819,
//    Latitude = -34.752779504882,
//},
//new Municipality()
//{
//    Id = 660406,
//    Name = "Nazareno",
//    FullName = "Municipality Nazareno",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -65.0725452244665,
//    Latitude = -22.4852950603151,
//},
//new Municipality()
//{
//    Id = 60581,
//    Name = "Necochea",
//    FullName = "Municipality Necochea",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -59.1673869468897,
//    Latitude = -38.2554110045679,
//},
//new Municipality()
//{
//    Id = 823008,
//    Name = "Nelson",
//    FullName = "Comuna Nelson",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -60.8134512895744,
//    Latitude = -31.2949655515129,
//},
//new Municipality()
//{
//    Id = 580056,
//    Name = "Neuquén",
//    FullName = "Municipality Neuquén",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -68.103829401365,
//    Latitude = -38.9420814031729,
//},
//new Municipality()
//{
//    Id = 822847,
//    Name = "Nicanor Molinas",
//    FullName = "Comuna Nicanor Molinas",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -59.8239493225464,
//    Latitude = -29.1516621451376,
//},
//new Municipality()
//{
//    Id = 142224,
//    Name = "Nicolás Bruzzone",
//    FullName = "Comuna Nicolás Bruzzone",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -64.3382488459279,
//    Latitude = -34.4416086343239,
//},
//new Municipality()
//{
//    Id = 141694,
//    Name = "Noetinger",
//    FullName = "Municipality Noetinger",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -62.3132776257758,
//    Latitude = -32.3608072067664,
//},
//new Municipality()
//{
//    Id = 746021,
//    Name = "Nogolí",
//    FullName = "Comisión Nogolí",
//    Source = "IGN",
//    Category = "Comisión",
//    Longitude = -66.3260298327171,
//    Latitude = -32.9144404088905,
//},
//new Municipality()
//{
//    Id = 300287,
//    Name = "Nogoyá",
//    FullName = "Municipality Nogoyá",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -59.8200664380282,
//    Latitude = -32.3876995169004,
//},
//new Municipality()
//{
//    Id = 141099,
//    Name = "Nono",
//    FullName = "Municipality Nono",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -65.0089907185432,
//    Latitude = -31.8047247773119,
//},
//new Municipality()
//{
//    Id = 302084,
//    Name = "Nueva Escocia",
//    FullName = "Junta Nueva Escocia",
//    Source = "IGN",
//    Category = "Junta",
//    Longitude = -58.0642564654726,
//    Latitude = -31.6650704649576,
//},
//new Municipality()
//{
//    Id = 746196,
//    Name = "Nueva Galia",
//    FullName = "Comisión Nueva Galia",
//    Source = "IGN",
//    Category = "Comisión",
//    Longitude = -65.253859414507,
//    Latitude = -35.1153083584885,
//},
//new Municipality()
//{
//    Id = 302308,
//    Name = "Nueva Vizcaya",
//    FullName = "Junta Nueva Vizcaya",
//    Source = "IGN",
//    Category = "Junta",
//    Longitude = -58.6127220007957,
//    Latitude = -30.9670410460346,
//},
//new Municipality()
//{
//    Id = 823148,
//    Name = "Nuevo Torino",
//    FullName = "Comuna Nuevo Torino",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -61.2599535857301,
//    Latitude = -31.3321781238899,
//},
//new Municipality()
//{
//    Id = 309410,
//    Name = "Ñancay",
//    FullName = "Junta de Gobierno Ñancay",
//    Source = "IGN",
//    Category = "Junta de Gobierno",
//    Longitude = -58.6775064792266,
//    Latitude = -33.4548923747681,
//},
//new Municipality()
//{
//    Id = 823624,
//    Name = "Ñanducita",
//    FullName = "Comuna Ñanducita",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -61.1338175338174,
//    Latitude = -30.3688178800785,
//},
//new Municipality()
//{
//    Id = 620203,
//    Name = "Ñorquinco",
//    FullName = "Municipality Ñorquinco",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -70.8948567402324,
//    Latitude = -41.8420451704216,
//},
//new Municipality()
//{
//    Id = 540399,
//    Name = "Oberá",
//    FullName = "Municipality Oberá",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -55.1176353030078,
//    Latitude = -27.4524533915088,
//},
//new Municipality()
//{
//    Id = 140924,
//    Name = "Obispo Trejo",
//    FullName = "Municipality Obispo Trejo",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -63.4166185018715,
//    Latitude = -30.7769384027746,
//},
//new Municipality()
//{
//    Id = 585105,
//    Name = "Octavio Pico",
//    FullName = "Comisión Octavio Pico",
//    Source = "IGN",
//    Category = "Comisión",
//    Longitude = -68.3613045245104,
//    Latitude = -37.6309139434645,
//},
//new Municipality()
//{
//    Id = 140448,
//    Name = "Olaeta",
//    FullName = "Municipality Olaeta",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -63.9100511143704,
//    Latitude = -33.0441850270044,
//},
//new Municipality()
//{
//    Id = 60595,
//    Name = "Olavarría",
//    FullName = "Municipality Olavarría",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -60.670205401306,
//    Latitude = -36.8576340464591,
//},
//new Municipality()
//{
//    Id = 540287,
//    Name = "Olegario V. Andrade",
//    FullName = "Municipality Olegario V. Andrade",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -55.4966780173815,
//    Latitude = -27.5656210880351,
//},
//new Municipality()
//{
//    Id = 141477,
//    Name = "Oliva",
//    FullName = "Municipality Oliva",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -63.5570228461855,
//    Latitude = -32.0485978880871,
//},
//new Municipality()
//{
//    Id = 142294,
//    Name = "Olivares de San Nicolás",
//    FullName = "Comuna Olivares de San Nicolás",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -64.8787665872454,
//    Latitude = -30.5460582497509,
//},
//new Municipality()
//{
//    Id = 822917,
//    Name = "Oliveros",
//    FullName = "Comuna Oliveros",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -60.8984798896377,
//    Latitude = -32.5308038570536,
//},
//new Municipality()
//{
//    Id = 302666,
//    Name = "Ombú",
//    FullName = "Junta Ombú",
//    Source = "IGN",
//    Category = "Junta",
//    Longitude = -59.2369967887823,
//    Latitude = -30.4643690818496,
//},
//new Municipality()
//{
//    Id = 142231,
//    Name = "Onagoity",
//    FullName = "Comuna Onagoity",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -63.6717128404408,
//    Latitude = -34.7699095275567,
//},
//new Municipality()
//{
//    Id = 141050,
//    Name = "Oncativo",
//    FullName = "Municipality Oncativo",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -63.6760024082064,
//    Latitude = -31.9151263882847,
//},
//new Municipality()
//{
//    Id = 141701,
//    Name = "Ordóñez",
//    FullName = "Municipality Ordóñez",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -62.864507904134,
//    Latitude = -32.8406260509867,
//},
//new Municipality()
//{
//    Id = 300329,
//    Name = "Oro Verde",
//    FullName = "Municipality Oro Verde",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -60.5162878952553,
//    Latitude = -31.8186856281242,
//},
//new Municipality()
//{
//    Id = 142322,
//    Name = "Pacheco de Melo",
//    FullName = "Comuna Pacheco de Melo",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -63.4894551789837,
//    Latitude = -33.7577742616375,
//},
//new Municipality()
//{
//    Id = 100182,
//    Name = "Paclín",
//    FullName = "Municipality Paclín",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -65.6743203627727,
//    Latitude = -28.1103140673494,
//},
//new Municipality()
//{
//    Id = 180318,
//    Name = "Pago de los Deseos",
//    FullName = "Municipality Pago de los Deseos",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -58.4548422648252,
//    Latitude = -28.1275511176043,
//},
//new Municipality()
//{
//    Id = 823631,
//    Name = "Palacios",
//    FullName = "Comuna Palacios",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -61.6505670678955,
//    Latitude = -30.714494329535,
//},
//new Municipality()
//{
//    Id = 386060,
//    Name = "Palca de Aparzo",
//    FullName = "Comision Palca de Aparzo",
//    Source = "IGN",
//    Category = "Comision",
//    Longitude = -65.1542805703608,
//    Latitude = -23.1306733752237,
//},
//new Municipality()
//{
//    Id = 380245,
//    Name = "Palma Sola",
//    FullName = "Municipality Palma Sola",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -64.3067471866774,
//    Latitude = -24.0724208464573,
//},
//new Municipality()
//{
//    Id = 180133,
//    Name = "Palmar Grande",
//    FullName = "Municipality Palmar Grande",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -57.9146198303954,
//    Latitude = -27.9229988814425,
//},
//new Municipality()
//{
//    Id = 340238,
//    Name = "Palo Santo",
//    FullName = "Municipality Palo Santo",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -59.3429453709135,
//    Latitude = -25.565422338409,
//},
//new Municipality()
//{
//    Id = 380154,
//    Name = "Palpalá",
//    FullName = "Municipality Palpalá",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -65.1264498098014,
//    Latitude = -24.1949225159114,
//},
//new Municipality()
//{
//    Id = 220280,
//    Name = "Pampa Almirón",
//    FullName = "Municipality Pampa Almirón",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -59.043672129719,
//    Latitude = -26.642939938477,
//},
//new Municipality()
//{
//    Id = 380070,
//    Name = "Pampa Blanca",
//    FullName = "Municipality Pampa Blanca",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -65.039296629162,
//    Latitude = -24.5391137000999,
//},
//new Municipality()
//{
//    Id = 220287,
//    Name = "Pampa del Indio",
//    FullName = "Municipality Pampa del Indio",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -59.9710494200596,
//    Latitude = -26.0202615003472,
//},
//new Municipality()
//{
//    Id = 220021,
//    Name = "Pampa del Infierno",
//    FullName = "Municipality Pampa del Infierno",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -61.1412101663586,
//    Latitude = -26.3977663514457,
//},
//new Municipality()
//{
//    Id = 908525,
//    Name = "Pampa Mayo",
//    FullName = "Comuna Pampa Mayo",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -65.2910821234256,
//    Latitude = -27.3165516168643,
//},
//new Municipality()
//{
//    Id = 143155,
//    Name = "Pampayasta Norte",
//    FullName = "Comuna Pampayasta Norte",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -63.6569925653938,
//    Latitude = -32.237995663096,
//},
//new Municipality()
//{
//    Id = 141484,
//    Name = "Pampayasta Sud",
//    FullName = "Municipality Pampayasta Sud",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -63.6532371104856,
//    Latitude = -32.2615771632819,
//},
//new Municipality()
//{
//    Id = 386217,
//    Name = "Pampichuela",
//    FullName = "Comisión Pampichuela",
//    Source = "IGN",
//    Category = "Comisión",
//    Longitude = -65.0481637240387,
//    Latitude = -23.5581244378801,
//},
//new Municipality()
//{
//    Id = 142861,
//    Name = "Panaholma",
//    FullName = "Comuna Panaholma",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -65.0686397589944,
//    Latitude = -31.6204775594034,
//},
//new Municipality()
//{
//    Id = 540406,
//    Name = "Panambí",
//    FullName = "Municipality Panambí",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -54.9694390877512,
//    Latitude = -27.6772283780235,
//},
//new Municipality()
//{
//    Id = 746077,
//    Name = "Papagayos",
//    FullName = "Comisión Papagayos",
//    Source = "IGN",
//    Category = "Comisión",
//    Longitude = -64.9959873871696,
//    Latitude = -32.6889846249879,
//},
//new Municipality()
//{
//    Id = 180287,
//    Name = "Parada Pucheta",
//    FullName = "Municipality Parada Pucheta",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -57.5860872211956,
//    Latitude = -29.8319332050051,
//},
//new Municipality()
//{
//    Id = 309165,
//    Name = "Paraje Guayaquil",
//    FullName = "Junta Paraje Guayaquil",
//    Source = "IGN",
//    Category = "Junta",
//    Longitude = -58.0930637266209,
//    Latitude = -30.9747614017917,
//},
//new Municipality()
//{
//    Id = 302976,
//    Name = "Paraje Las Tunas",
//    FullName = "Junta Paraje Las Tunas",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -59.721828253478,
//    Latitude = -31.856972229211,
//},
//new Municipality()
//{
//    Id = 309957,
//    Name = "Paraje Los Algarrobos",
//    FullName = "Junta Paraje Los Algarrobos",
//    Source = "IGN",
//    Category = "Junta",
//    Longitude = -59.4640347977988,
//    Latitude = -31.5367824361702,
//},
//new Municipality()
//{
//    Id = 300336,
//    Name = "Paraná",
//    FullName = "Municipality Paraná",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -60.5012038041556,
//    Latitude = -31.7493555782411,
//},
//new Municipality()
//{
//    Id = 420273,
//    Name = "Parera",
//    FullName = "Municipality Parera",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -64.4993137530934,
//    Latitude = -35.1852121663134,
//},
//new Municipality()
//{
//    Id = 142014,
//    Name = "Parque Calmayo",
//    FullName = "Comuna Parque Calmayo",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -64.4583493455315,
//    Latitude = -32.0456338882203,
//},
//new Municipality()
//{
//    Id = 141708,
//    Name = "Pascanas",
//    FullName = "Municipality Pascanas",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -63.0411760442871,
//    Latitude = -33.1262394371826,
//},
//new Municipality()
//{
//    Id = 140329,
//    Name = "Pasco",
//    FullName = "Municipality Pasco",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -63.3402135333334,
//    Latitude = -32.7453423023259,
//},
//new Municipality()
//{
//    Id = 585119,
//    Name = "Paso Aguerre",
//    FullName = "Comisión Paso Aguerre",
//    Source = "IGN",
//    Category = "Comisión",
//    Longitude = -69.7956444882818,
//    Latitude = -39.3365722197045,
//},
//new Municipality()
//{
//    Id = 265021,
//    Name = "Paso de Indios",
//    FullName = "Comisión Paso de Indios",
//    Source = "IGN",
//    Category = "Comisión",
//    Longitude = -69.0483419273241,
//    Latitude = -43.8683992681332,
//},
//new Municipality()
//{
//    Id = 309710,
//    Name = "Paso de la Arena",
//    FullName = "Junta Paso de la Arena",
//    Source = "IGN",
//    Category = "Junta",
//    Longitude = -60.0930682893188,
//    Latitude = -31.7890399253004,
//},
//new Municipality()
//{
//    Id = 303329,
//    Name = "Paso de La Laguna",
//    FullName = "Junta Paso de La Laguna",
//    Source = "IGN",
//    Category = "Junta",
//    Longitude = -59.2500827095278,
//    Latitude = -31.7850250065581,
//},
//new Municipality()
//{
//    Id = 180322,
//    Name = "Paso de la Patria",
//    FullName = "Municipality Paso de la Patria",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -58.5795656508837,
//    Latitude = -27.3448444187707,
//},
//new Municipality()
//{
//    Id = 309715,
//    Name = "Paso de las Piedras",
//    FullName = "Junta Paso de las Piedras",
//    Source = "IGN",
//    Category = "Junta",
//    Longitude = -60.1204647681215,
//    Latitude = -31.695517838499,
//},
//new Municipality()
//{
//    Id = 180294,
//    Name = "Paso de los Libres",
//    FullName = "Municipality Paso de los Libres",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -57.3046337798737,
//    Latitude = -29.5103897056698,
//},
//new Municipality()
//{
//    Id = 142329,
//    Name = "Paso del Durazno",
//    FullName = "Comuna Paso del Durazno",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -64.0214096373409,
//    Latitude = -33.1488459038526,
//},
//new Municipality()
//{
//    Id = 268070,
//    Name = "Paso del Sapo",
//    FullName = "Comuna Paso del Sapo",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -69.5836276706305,
//    Latitude = -42.7463204230383,
//},
//new Municipality()
//{
//    Id = 309220,
//    Name = "Paso Duarte",
//    FullName = "Junta Paso Duarte",
//    Source = "IGN",
//    Category = "Junta",
//    Longitude = -58.6495032951198,
//    Latitude = -31.1887966487214,
//},
//new Municipality()
//{
//    Id = 746315,
//    Name = "Paso Grande",
//    FullName = "Comisión Paso Grande",
//    Source = "IGN",
//    Category = "Comisión",
//    Longitude = -65.6452060352997,
//    Latitude = -32.8695786119975,
//},
//new Municipality()
//{
//    Id = 142210,
//    Name = "Paso Viejo",
//    FullName = "Comuna Paso Viejo",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -65.1910942537931,
//    Latitude = -30.7663464619765,
//},
//new Municipality()
//{
//    Id = 309380,
//    Name = "Pastor Britos",
//    FullName = "Junta Pastor Britos",
//    Source = "IGN",
//    Category = "Junta",
//    Longitude = -58.8320011437297,
//    Latitude = -32.7440986487744,
//},
//new Municipality()
//{
//    Id = 60602,
//    Name = "Patagones",
//    FullName = "Municipality Patagones",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -62.8508044468126,
//    Latitude = -40.1963845980486,
//},
//new Municipality()
//{
//    Id = 822490,
//    Name = "Pavón",
//    FullName = "Comuna Pavón",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -60.412478499259,
//    Latitude = -33.2423832202118,
//},
//new Municipality()
//{
//    Id = 822497,
//    Name = "Pavón Arriba",
//    FullName = "Comuna Pavón Arriba",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -60.8687429180138,
//    Latitude = -33.3409315515591,
//},
//new Municipality()
//{
//    Id = 660049,
//    Name = "Payogasta",
//    FullName = "Municipality Payogasta",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -66.0047304486052,
//    Latitude = -24.9795907475623,
//},
//new Municipality()
//{
//    Id = 302091,
//    Name = "Pedernal",
//    FullName = "Junta Pedernal",
//    Source = "IGN",
//    Category = "Junta",
//    Longitude = -58.1998547826065,
//    Latitude = -31.6818980493273,
//},
//new Municipality()
//{
//    Id = 823932,
//    Name = "Pedro Gómez Cello",
//    FullName = "Comuna Pedro Gómez Cello",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -60.4742838674325,
//    Latitude = -30.0051967599308,
//},
//new Municipality()
//{
//    Id = 180406,
//    Name = "Pedro R. Fernández",
//    FullName = "Municipality Pedro R. Fernández",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -58.654018179986,
//    Latitude = -28.7748772076671,
//},
//new Municipality()
//{
//    Id = 60609,
//    Name = "Pehuajó",
//    FullName = "Municipality Pehuajó",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -61.9281257343992,
//    Latitude = -35.8836208341734,
//},
//new Municipality()
//{
//    Id = 60616,
//    Name = "Pellegrini",
//    FullName = "Municipality Pellegrini",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -63.225752112342,
//    Latitude = -36.2711917055884,
//},
//new Municipality()
//{
//    Id = 309385,
//    Name = "Perdices",
//    FullName = "Junta Perdices",
//    Source = "IGN",
//    Category = "Junta",
//    Longitude = -58.706741540808,
//    Latitude = -33.1931230702018,
//},
//new Municipality()
//{
//    Id = 820203,
//    Name = "Pérez",
//    FullName = "Municipality Pérez",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -60.7969296352688,
//    Latitude = -32.9982620628378,
//},
//new Municipality()
//{
//    Id = 60623,
//    Name = "Pergamino",
//    FullName = "Municipality Pergamino",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -60.5447827847012,
//    Latitude = -33.8360667305047,
//},
//new Municipality()
//{
//    Id = 380077,
//    Name = "Perico",
//    FullName = "Municipality Perico",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -65.0853479728595,
//    Latitude = -24.3899464201256,
//},
//new Municipality()
//{
//    Id = 425105,
//    Name = "Perú",
//    FullName = "Comisión Perú",
//    Source = "IGN",
//    Category = "Comisión",
//    Longitude = -64.0516815451907,
//    Latitude = -37.6579811945705,
//},
//new Municipality()
//{
//    Id = 180070,
//    Name = "Perugorría",
//    FullName = "Municipality Perugorría",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -58.512588429016,
//    Latitude = -29.2938936468304,
//},
//new Municipality()
//{
//    Id = 822504,
//    Name = "Peyrano",
//    FullName = "Comuna Peyrano",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -60.7831371404894,
//    Latitude = -33.5150746028771,
//},
//new Municipality()
//{
//    Id = 824121,
//    Name = "Piamonte",
//    FullName = "Comuna Piamonte",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -62.0257071277097,
//    Latitude = -32.1525973375576,
//},
//new Municipality()
//{
//    Id = 309480,
//    Name = "Picada Berón",
//    FullName = "Junta Picada Berón",
//    Source = "IGN",
//    Category = "Junta",
//    Longitude = -59.3459114502768,
//    Latitude = -30.8912795148526,
//},
//new Municipality()
//{
//    Id = 660308,
//    Name = "Pichanal",
//    FullName = "Municipality Pichanal",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -63.8504451942546,
//    Latitude = -23.7285406015686,
//},
//new Municipality()
//{
//    Id = 425112,
//    Name = "Pichi Huinca",
//    FullName = "Comisión Pichi Huinca",
//    Source = "IGN",
//    Category = "Comisión",
//    Longitude = -64.7947455489901,
//    Latitude = -35.6486769518494,
//},
//new Municipality()
//{
//    Id = 580217,
//    Name = "Picún Leufú",
//    FullName = "Municipality Picún Leufú",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -69.3041340199497,
//    Latitude = -39.5272959346432,
//},
//new Municipality()
//{
//    Id = 580035,
//    Name = "Piedra del Águila",
//    FullName = "Municipality Piedra del Águila",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -70.0814261575418,
//    Latitude = -40.0556599804311,
//},
//new Municipality()
//{
//    Id = 300252,
//    Name = "Piedras Blancas",
//    FullName = "Municipality Piedras Blancas",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -59.8884435804018,
//    Latitude = -31.1953540410117,
//},
//new Municipality()
//{
//    Id = 60630,
//    Name = "Pila",
//    FullName = "Municipality Pila",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -58.3404430507343,
//    Latitude = -36.2029842240013,
//},
//new Municipality()
//{
//    Id = 823155,
//    Name = "Pilar",
//    FullName = "Comuna Pilar",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -61.2815859592823,
//    Latitude = -31.4251194069278,
//},
//new Municipality()
//{
//    Id = 141057,
//    Name = "Pilar",
//    FullName = "Municipality Pilar",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -63.8821893916396,
//    Latitude = -31.6802864251569,
//},
//new Municipality()
//{
//    Id = 60638,
//    Name = "Pilar",
//    FullName = "Municipality Pilar",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -58.9033327303779,
//    Latitude = -34.448164005306,
//},
//new Municipality()
//{
//    Id = 620224,
//    Name = "Pilcaniyeu",
//    FullName = "Municipality Pilcaniyeu",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -70.7850574590832,
//    Latitude = -41.0871512228335,
//},
//new Municipality()
//{
//    Id = 585028,
//    Name = "Pilo Lil",
//    FullName = "Comisión Pilo Lil",
//    Source = "IGN",
//    Category = "Comisión",
//    Longitude = -70.8980298318547,
//    Latitude = -39.6260254162078,
//},
//new Municipality()
//{
//    Id = 60644,
//    Name = "Pinamar",
//    FullName = "Municipality Pinamar",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -56.8702834122219,
//    Latitude = -37.1110742904919,
//},
//new Municipality()
//{
//    Id = 142238,
//    Name = "Pincén",
//    FullName = "Comuna Pincén",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -63.9175546184509,
//    Latitude = -34.8383140184064,
//},
//new Municipality()
//{
//    Id = 823421,
//    Name = "Piñero",
//    FullName = "Comuna Piñero",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -60.7611100951985,
//    Latitude = -33.0903529206549,
//},
//new Municipality()
//{
//    Id = 140931,
//    Name = "Piquillín",
//    FullName = "Municipality Piquillín",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -63.7592227132231,
//    Latitude = -31.3014822797673,
//},
//new Municipality()
//{
//    Id = 340245,
//    Name = "Pirané",
//    FullName = "Municipality Pirané",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -59.1208484121174,
//    Latitude = -25.7484130694872,
//},
//new Municipality()
//{
//    Id = 822308,
//    Name = "Plaza Clucellas",
//    FullName = "Comuna Plaza Clucellas",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -61.7223649583064,
//    Latitude = -31.4377060312836,
//},
//new Municipality()
//{
//    Id = 142714,
//    Name = "Plaza de Mercedes",
//    FullName = "Comuna Plaza de Mercedes",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -63.2611760527181,
//    Latitude = -30.977225049207,
//},
//new Municipality()
//{
//    Id = 580063,
//    Name = "Plaza Huincul",
//    FullName = "Municipality Plaza Huincul",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -69.1598555722786,
//    Latitude = -38.9406582608027,
//},
//new Municipality()
//{
//    Id = 142966,
//    Name = "Plaza Luxardo",
//    FullName = "Comuna Plaza Luxardo",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -62.1458650159189,
//    Latitude = -31.3075262309917,
//},
//new Municipality()
//{
//    Id = 580070,
//    Name = "Plottier",
//    FullName = "Municipality Plottier",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -68.2773560021318,
//    Latitude = -38.9485618927944,
//},
//new Municipality()
//{
//    Id = 700070,
//    Name = "Pocito",
//    FullName = "Municipality Pocito",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -68.5846798192063,
//    Latitude = -31.7472539046839,
//},
//new Municipality()
//{
//    Id = 100189,
//    Name = "Pomán",
//    FullName = "Municipality Pomán",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -66.429606095292,
//    Latitude = -28.4137424995776,
//},
//new Municipality()
//{
//    Id = 620063,
//    Name = "Pomona",
//    FullName = "Municipality Pomona",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -65.6617494335227,
//    Latitude = -39.5259391877271,
//},
//new Municipality()
//{
//    Id = 141316,
//    Name = "Porteña",
//    FullName = "Municipality Porteña",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -62.063204317245,
//    Latitude = -30.9889513794182,
//},
//new Municipality()
//{
//    Id = 349105,
//    Name = "Portón Negro",
//    FullName = "Junta Portón Negro",
//    Source = "IGN",
//    Category = "Junta",
//    Longitude = -58.7419037802063,
//    Latitude = -24.9655172869136,
//},
//new Municipality()
//{
//    Id = 823638,
//    Name = "Portugalete",
//    FullName = "Comuna Portugalete",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -61.3603180374439,
//    Latitude = -30.2375293533564,
//},
//new Municipality()
//{
//    Id = 540119,
//    Name = "Posadas",
//    FullName = "Municipality Posadas",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -55.9587065430058,
//    Latitude = -27.433529189378,
//},
//new Municipality()
//{
//    Id = 143050,
//    Name = "Potrero de Garay",
//    FullName = "Comuna Potrero de Garay",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -64.5891432550363,
//    Latitude = -31.801158645662,
//},
//new Municipality()
//{
//    Id = 740130,
//    Name = "Potrero de los Funes",
//    FullName = "Municipality Potrero de los Funes",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -66.2316846446291,
//    Latitude = -33.210106792676,
//},
//new Municipality()
//{
//    Id = 540501,
//    Name = "Pozo Azul",
//    FullName = "Municipality Pozo Azul",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -54.0387989281068,
//    Latitude = -26.3467137743214,
//},
//new Municipality()
//{
//    Id = 823323,
//    Name = "Pozo Borrado",
//    FullName = "Comuna Pozo Borrado",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -61.3860267330697,
//    Latitude = -28.9395693845648,
//},
//new Municipality()
//{
//    Id = 100091,
//    Name = "Pozo de Piedra",
//    FullName = "Municipality Pozo de Piedra",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -67.1713170613025,
//    Latitude = -27.5480667590129,
//},
//new Municipality()
//{
//    Id = 141064,
//    Name = "Pozo del Molle",
//    FullName = "Municipality Pozo del Molle",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -62.9178333970772,
//    Latitude = -32.0191752758653,
//},
//new Municipality()
//{
//    Id = 340140,
//    Name = "Pozo del Tigre",
//    FullName = "Municipality Pozo del Tigre",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -60.3165832567289,
//    Latitude = -24.8852024120505,
//},
//new Municipality()
//{
//    Id = 143134,
//    Name = "Pozo Nuevo",
//    FullName = "Comuna Pozo Nuevo",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -64.1248945764177,
//    Latitude = -29.5752928863074,
//},
//new Municipality()
//{
//    Id = 220357,
//    Name = "Presidencia de la Plaza",
//    FullName = "Municipality Presidencia de la Plaza",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -59.7745640420019,
//    Latitude = -27.0446247369189,
//},
//new Municipality()
//{
//    Id = 220294,
//    Name = "Presidencia Roca",
//    FullName = "Municipality Presidencia Roca",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -59.6841446207415,
//    Latitude = -26.1770146181931,
//},
//new Municipality()
//{
//    Id = 220077,
//    Name = "Presidencia Roque Sáenz Peña",
//    FullName = "Municipality Presidencia Roque Sáenz Peña",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -60.4612869070189,
//    Latitude = -26.7853900358339,
//},
//new Municipality()
//{
//    Id = 60648,
//    Name = "Presidente Perón",
//    FullName = "Municipality Presidente Perón",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -58.3980842106611,
//    Latitude = -34.9298478405731,
//},
//new Municipality()
//{
//    Id = 822315,
//    Name = "Presidente Roca",
//    FullName = "Comuna Presidente Roca",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -61.6208017366654,
//    Latitude = -31.2146434131101,
//},
//new Municipality()
//{
//    Id = 660154,
//    Name = "Profesor Salvador Mazza",
//    FullName = "Municipality Profesor Salvador Mazza",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -63.6727542374832,
//    Latitude = -22.081311153409,
//},
//new Municipality()
//{
//    Id = 540091,
//    Name = "Profundidad",
//    FullName = "Municipality Profundidad",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -55.7184718854412,
//    Latitude = -27.5596067954411,
//},
//new Municipality()
//{
//    Id = 823162,
//    Name = "Progreso",
//    FullName = "Comuna Progreso",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -60.9900262574151,
//    Latitude = -31.145023716001,
//},
//new Municipality()
//{
//    Id = 300441,
//    Name = "Pronunciamiento",
//    FullName = "Municipality Pronunciamiento",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -58.4548417910312,
//    Latitude = -32.3401592725779,
//},
//new Municipality()
//{
//    Id = 823169,
//    Name = "Providencia",
//    FullName = "Comuna Providencia",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -61.0284594470813,
//    Latitude = -30.979416703563,
//},
//new Municipality()
//{
//    Id = 60651,
//    Name = "Puán",
//    FullName = "Municipality Puán",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -63.0574326099062,
//    Latitude = -38.0760763207352,
//},
//new Municipality()
//{
//    Id = 822924,
//    Name = "Pueblo Andino",
//    FullName = "Comuna Pueblo Andino",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -60.8950897190626,
//    Latitude = -32.656257573116,
//},
//new Municipality()
//{
//    Id = 309720,
//    Name = "Pueblo Brugo",
//    FullName = "Municipality Pueblo Brugo",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -60.025113121362,
//    Latitude = -31.3585371197818,
//},
//new Municipality()
//{
//    Id = 302042,
//    Name = "Pueblo Cazes",
//    FullName = "Junta Pueblo Cazes",
//    Source = "IGN",
//    Category = "Junta",
//    Longitude = -58.5150374863014,
//    Latitude = -32.0065769845586,
//},
//new Municipality()
//{
//    Id = 820207,
//    Name = "Pueblo Esther",
//    FullName = "Municipality Pueblo Esther",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -60.5719619730141,
//    Latitude = -33.0799042595501,
//},
//new Municipality()
//{
//    Id = 300199,
//    Name = "Pueblo General Belgrano",
//    FullName = "Municipality Pueblo General Belgrano",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -58.4317988331123,
//    Latitude = -32.9969490581565,
//},
//new Municipality()
//{
//    Id = 141715,
//    Name = "Pueblo Italiano",
//    FullName = "Municipality Pueblo Italiano",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -62.8419046433383,
//    Latitude = -33.8797412508908,
//},
//new Municipality()
//{
//    Id = 180091,
//    Name = "Pueblo Libertador",
//    FullName = "Municipality Pueblo Libertador",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -59.3189767511884,
//    Latitude = -30.2564840693514,
//},
//new Municipality()
//{
//    Id = 309030,
//    Name = "Pueblo Liebig",
//    FullName = "Municipality Pueblo Liebig",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -58.2418442808336,
//    Latitude = -32.1312510224031,
//},
//new Municipality()
//{
//    Id = 822322,
//    Name = "Pueblo Marini",
//    FullName = "Comuna Pueblo Marini",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -61.8824342439785,
//    Latitude = -31.0204131813703,
//},
//new Municipality()
//{
//    Id = 823435,
//    Name = "Pueblo Muñoz",
//    FullName = "Comuna Pueblo Muñoz",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -60.9052927841008,
//    Latitude = -33.1752792379334,
//},
//new Municipality()
//{
//    Id = 420280,
//    Name = "Puelches",
//    FullName = "Municipality Puelches",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -66.0568431795264,
//    Latitude = -38.0312653577366,
//},
//new Municipality()
//{
//    Id = 420287,
//    Name = "Puelén",
//    FullName = "Municipality Puelén",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -67.6691382555978,
//    Latitude = -37.1505387632358,
//},
//new Municipality()
//{
//    Id = 100098,
//    Name = "Puerta de Corral Quemado",
//    FullName = "Municipality Puerta de Corral Quemado",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -67.1406560925936,
//    Latitude = -27.2621985443052,
//},
//new Municipality()
//{
//    Id = 100105,
//    Name = "Puerta de San José",
//    FullName = "Municipality Puerta de San José",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -66.9467603768191,
//    Latitude = -27.4358236360703,
//},
//new Municipality()
//{
//    Id = 309485,
//    Name = "Puerto Algarrobo",
//    FullName = "Junta Puerto Algarrobo",
//    Source = "IGN",
//    Category = "Junta",
//    Longitude = -59.819994484452,
//    Latitude = -31.1473622596779,
//},
//new Municipality()
//{
//    Id = 220063,
//    Name = "Puerto Bermejo",
//    FullName = "Municipality Puerto Bermejo",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -58.521823607602,
//    Latitude = -26.8874730387988,
//},
//new Municipality()
//{
//    Id = 302999,
//    Name = "Puerto Curtiembre",
//    FullName = "Junta Puerto Curtiembre",
//    Source = "IGN",
//    Category = "Junta",
//    Longitude = -60.1549127828303,
//    Latitude = -31.5156467186163,
//},
//new Municipality()
//{
//    Id = 540210,
//    Name = "Puerto Esperanza",
//    FullName = "Municipality Puerto Esperanza",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -54.4721723500869,
//    Latitude = -26.0812488812499,
//},
//new Municipality()
//{
//    Id = 220070,
//    Name = "Puerto Eva Perón",
//    FullName = "Municipality Puerto Eva Perón",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -58.6372211686714,
//    Latitude = -26.7118768027859,
//},
//new Municipality()
//{
//    Id = 820287,
//    Name = "Puerto General San Martín",
//    FullName = "Municipality Puerto General San Martín",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -60.7505144595784,
//    Latitude = -32.682163952774,
//},
//new Municipality()
//{
//    Id = 540217,
//    Name = "Puerto Iguazú",
//    FullName = "Municipality Puerto Iguazú",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -54.375751064313,
//    Latitude = -25.6745733701993,
//},
//new Municipality()
//{
//    Id = 540315,
//    Name = "Puerto Leoni",
//    FullName = "Municipality Puerto Leoni",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -55.138075296955,
//    Latitude = -26.9961973488732,
//},
//new Municipality()
//{
//    Id = 260007,
//    Name = "Puerto Madryn",
//    FullName = "Municipality Puerto Madryn",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -65.048337730345,
//    Latitude = -42.731476695997,
//},
//new Municipality()
//{
//    Id = 265028,
//    Name = "Puerto Pirámides",
//    FullName = "Comisión Puerto Pirámides",
//    Source = "IGN",
//    Category = "Comisión",
//    Longitude = -64.2705125209026,
//    Latitude = -42.5486838276858,
//},
//new Municipality()
//{
//    Id = 540350,
//    Name = "Puerto Piray",
//    FullName = "Municipality Puerto Piray",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -54.4261810355107,
//    Latitude = -26.5386325780667,
//},
//new Municipality()
//{
//    Id = 540322,
//    Name = "Puerto Rico",
//    FullName = "Municipality Puerto Rico",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -55.0464276632575,
//    Latitude = -26.8443109667319,
//},
//new Municipality()
//{
//    Id = 220245,
//    Name = "Puerto Tirol",
//    FullName = "Municipality Puerto Tirol",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -59.2976335508473,
//    Latitude = -27.3795824603487,
//},
//new Municipality()
//{
//    Id = 220406,
//    Name = "Puerto Vilelas",
//    FullName = "Municipality Puerto Vilelas",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -58.9105019634339,
//    Latitude = -27.7053948261427,
//},
//new Municipality()
//{
//    Id = 300070,
//    Name = "Puerto Yeruá",
//    FullName = "Municipality Puerto Yeruá",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -58.0593408177714,
//    Latitude = -31.5534185179903,
//},
//new Municipality()
//{
//    Id = 142777,
//    Name = "Puesto de Castro",
//    FullName = "Comuna Puesto de Castro",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -63.4025697484862,
//    Latitude = -30.1936675658152,
//},
//new Municipality()
//{
//    Id = 386021,
//    Name = "Puesto del Marquez",
//    FullName = "Comisión Puesto del Marquez",
//    Source = "IGN",
//    Category = "Comisión",
//    Longitude = -65.6031411211675,
//    Latitude = -22.5922128060613,
//},
//new Municipality()
//{
//    Id = 380074,
//    Name = "Puesto Viejo",
//    FullName = "Municipality Puesto Viejo",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -64.9633135258659,
//    Latitude = -24.4714700054238,
//},
//new Municipality()
//{
//    Id = 824009,
//    Name = "Pujato",
//    FullName = "Comuna Pujato",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -61.0482263923623,
//    Latitude = -32.9970194609294,
//},
//new Municipality()
//{
//    Id = 823176,
//    Name = "Pujato Norte",
//    FullName = "Comuna Pujato Norte",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -60.9497533401639,
//    Latitude = -31.5161672425739,
//},
//new Municipality()
//{
//    Id = 386266,
//    Name = "Pumahuasi",
//    FullName = "Comisión Pumahuasi",
//    Source = "IGN",
//    Category = "Comisión",
//    Longitude = -65.7805540370442,
//    Latitude = -22.3188892704334,
//},
//new Municipality()
//{
//    Id = 143162,
//    Name = "Punta del Agua",
//    FullName = "Comuna Punta del Agua",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -63.8111899638921,
//    Latitude = -32.5765144963957,
//},
//new Municipality()
//{
//    Id = 309310,
//    Name = "Punta del Monte",
//    FullName = "Junta Punta del Monte",
//    Source = "IGN",
//    Category = "Junta",
//    Longitude = -59.6567261024934,
//    Latitude = -33.167644628841,
//},
//new Municipality()
//{
//    Id = 60655,
//    Name = "Punta Indio",
//    FullName = "Municipality Punta Indio",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -57.3992340402061,
//    Latitude = -35.4260558765566,
//},
//new Municipality()
//{
//    Id = 386189,
//    Name = "Purmamarca",
//    FullName = "Comisión Purmamarca",
//    Source = "IGN",
//    Category = "Comisión",
//    Longitude = -65.6009203590775,
//    Latitude = -23.7064366600781,
//},
//new Municipality()
//{
//    Id = 309730,
//    Name = "Quebracho",
//    FullName = "Junta Quebracho",
//    Source = "IGN",
//    Category = "Junta",
//    Longitude = -60.1536264597953,
//    Latitude = -31.8267603318679,
//},
//new Municipality()
//{
//    Id = 141323,
//    Name = "Quebracho Herrado",
//    FullName = "Municipality Quebracho Herrado",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -62.2270479672393,
//    Latitude = -31.5498828557019,
//},
//new Municipality()
//{
//    Id = 420294,
//    Name = "Quehué",
//    FullName = "Municipality Quehué",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -64.7100455299834,
//    Latitude = -37.1049269830217,
//},
//new Municipality()
//{
//    Id = 420301,
//    Name = "Quemú Quemú",
//    FullName = "Municipality Quemú Quemú",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -63.5963395092039,
//    Latitude = -35.9899242762307,
//},
//new Municipality()
//{
//    Id = 425119,
//    Name = "Quetrequén",
//    FullName = "Comisión Quetrequén",
//    Source = "IGN",
//    Category = "Comisión",
//    Longitude = -64.5366889485509,
//    Latitude = -35.050795910293,
//},
//new Municipality()
//{
//    Id = 585126,
//    Name = "Quili Malal",
//    FullName = "Comisión Quili Malal",
//    Source = "IGN",
//    Category = "Comisión",
//    Longitude = -69.7503175388208,
//    Latitude = -38.4119393426764,
//},
//new Municipality()
//{
//    Id = 140378,
//    Name = "Quilino",
//    FullName = "Municipality Quilino",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -64.4778221580427,
//    Latitude = -30.2204887910493,
//},
//new Municipality()
//{
//    Id = 60658,
//    Name = "Quilmes",
//    FullName = "Municipality Quilmes",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -58.2768580209942,
//    Latitude = -34.7349707991152,
//},
//new Municipality()
//{
//    Id = 908329,
//    Name = "Quilmes y Los Sueldos",
//    FullName = "Comuna Quilmes y Los Sueldos",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -65.2353581812994,
//    Latitude = -27.0764554672128,
//},
//new Municipality()
//{
//    Id = 740021,
//    Name = "Quines",
//    FullName = "Municipality Quines",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -65.813224325789,
//    Latitude = -32.22978164448,
//},
//new Municipality()
//{
//    Id = 220378,
//    Name = "Quitilipi",
//    FullName = "Municipality Quitilipi",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -60.1718118880352,
//    Latitude = -26.6609040150069,
//},
//new Municipality()
//{
//    Id = 908588,
//    Name = "Raco",
//    FullName = "Comuna Raco",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -65.4527602296137,
//    Latitude = -26.6885600373211,
//},
//new Municipality()
//{
//    Id = 260056,
//    Name = "Rada Tilly",
//    FullName = "Municipality Rada Tilly",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -67.5779616622662,
//    Latitude = -45.9332659920253,
//},
//new Municipality()
//{
//    Id = 143057,
//    Name = "Rafael García",
//    FullName = "Comuna Rafael García",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -64.2614633616075,
//    Latitude = -31.6484813084361,
//},
//new Municipality()
//{
//    Id = 820042,
//    Name = "Rafaela",
//    FullName = "Municipality Rafaela",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -61.4875615908817,
//    Latitude = -31.2423283955577,
//},
//new Municipality()
//{
//    Id = 309965,
//    Name = "Raíces Oeste",
//    FullName = "Junta Raíces Oeste",
//    Source = "IGN",
//    Category = "Junta",
//    Longitude = -59.4654736098259,
//    Latitude = -31.8036162102887,
//},
//new Municipality()
//{
//    Id = 180154,
//    Name = "Ramada Paso",
//    FullName = "Municipality Ramada Paso",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -58.2998077380605,
//    Latitude = -27.3669357365437,
//},
//new Municipality()
//{
//    Id = 60665,
//    Name = "Ramallo",
//    FullName = "Municipality Ramallo",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -60.0575075532631,
//    Latitude = -33.5871865441211,
//},
//new Municipality()
//{
//    Id = 823939,
//    Name = "Ramayón",
//    FullName = "Comuna Ramayón",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -60.5619618649315,
//    Latitude = -30.6120352132328,
//},
//new Municipality()
//{
//    Id = 585147,
//    Name = "Ramón M. Castro",
//    FullName = "Comisión Ramón M. Castro",
//    Source = "IGN",
//    Category = "Comisión",
//    Longitude = -69.7563648428793,
//    Latitude = -38.9693906408624,
//},
//new Municipality()
//{
//    Id = 822329,
//    Name = "Ramona",
//    FullName = "Comuna Ramona",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -61.9053715719843,
//    Latitude = -31.1014569397072,
//},
//new Municipality()
//{
//    Id = 908147,
//    Name = "Ranchillos y San Miguel",
//    FullName = "Comuna Ranchillos y San Miguel",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -65.0319419848573,
//    Latitude = -26.964925552867,
//},
//new Municipality()
//{
//    Id = 420308,
//    Name = "Rancul",
//    FullName = "Municipality Rancul",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -64.8650747825192,
//    Latitude = -35.1632454157811,
//},
//new Municipality()
//{
//    Id = 142245,
//    Name = "Ranqueles",
//    FullName = "Comuna Ranqueles",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -64.0999800172126,
//    Latitude = -34.8429525115099,
//},
//new Municipality()
//{
//    Id = 60672,
//    Name = "Rauch",
//    FullName = "Municipality Rauch",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -58.9441413666156,
//    Latitude = -36.5721944489313,
//},
//new Municipality()
//{
//    Id = 260112,
//    Name = "Rawson",
//    FullName = "Municipality Rawson",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -65.0886233411269,
//    Latitude = -43.2585661871389,
//},
//new Municipality()
//{
//    Id = 700077,
//    Name = "Rawson",
//    FullName = "Municipality Rawson",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -68.4675945970348,
//    Latitude = -31.6866317967417,
//},
//new Municipality()
//{
//    Id = 142784,
//    Name = "Rayo Cortado",
//    FullName = "Comuna Rayo Cortado",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -63.828433136014,
//    Latitude = -30.0719376972619,
//},
//new Municipality()
//{
//    Id = 420315,
//    Name = "Realicó",
//    FullName = "Municipality Realicó",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -64.2428585936785,
//    Latitude = -35.110450698324,
//},
//new Municipality()
//{
//    Id = 820112,
//    Name = "Reconquista",
//    FullName = "Municipality Reconquista",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -59.6145182689185,
//    Latitude = -29.2273963709805,
//},
//new Municipality()
//{
//    Id = 820142,
//    Name = "Recreo",
//    FullName = "Municipality Recreo",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -60.7360555109775,
//    Latitude = -31.4934750129207,
//},
//new Municipality()
//{
//    Id = 100175,
//    Name = "Recreo",
//    FullName = "Municipality Recreo",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -65.2021591427143,
//    Latitude = -29.5263427455583,
//},
//new Municipality()
//{
//    Id = 140455,
//    Name = "Reducción",
//    FullName = "Municipality Reducción",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -63.8627303675096,
//    Latitude = -33.2028095475754,
//},
//new Municipality()
//{
//    Id = 425126,
//    Name = "Relmo",
//    FullName = "Comisión Relmo",
//    Source = "IGN",
//    Category = "Comisión",
//    Longitude = -63.4979493256412,
//    Latitude = -36.2436588452208,
//},
//new Municipality()
//{
//    Id = 746084,
//    Name = "Renca",
//    FullName = "Comisión Renca",
//    Source = "IGN",
//    Category = "Comisión",
//    Longitude = -65.3742752787487,
//    Latitude = -32.7777931018667,
//},
//new Municipality()
//{
//    Id = 220413,
//    Name = "Resistencia",
//    FullName = "Municipality Resistencia",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -59.1441039972337,
//    Latitude = -27.5946217493311,
//},
//new Municipality()
//{
//    Id = 340210,
//    Name = "Riacho He He",
//    FullName = "Municipality Riacho He He",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -58.2718820640382,
//    Latitude = -25.362490161423,
//},
//new Municipality()
//{
//    Id = 180028,
//    Name = "Riachuelo",
//    FullName = "Municipality Riachuelo",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -58.7432047142722,
//    Latitude = -27.5877888880851,
//},
//new Municipality()
//{
//    Id = 824016,
//    Name = "Ricardone",
//    FullName = "Comuna Ricardone",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -60.805921768591,
//    Latitude = -32.7891891714592,
//},
//new Municipality()
//{
//    Id = 142826,
//    Name = "Rincón",
//    FullName = "Comuna Rincón",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -63.6262147970324,
//    Latitude = -31.5941777031772,
//},
//new Municipality()
//{
//    Id = 580210,
//    Name = "Rincón de los Sauces",
//    FullName = "Municipality Rincón de los Sauces",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -68.9053403884952,
//    Latitude = -37.4280539287636,
//},
//new Municipality()
//{
//    Id = 303245,
//    Name = "Rincón de Nogoyá",
//    FullName = "Junta Rincón de Nogoyá",
//    Source = "IGN",
//    Category = "Junta",
//    Longitude = -59.9096300485896,
//    Latitude = -32.7803508725771,
//},
//new Municipality()
//{
//    Id = 309395,
//    Name = "Rincón del Cinto",
//    FullName = "Junta Rincón del Cinto",
//    Source = "IGN",
//    Category = "Junta",
//    Longitude = -58.5965110459256,
//    Latitude = -32.5944636470538,
//},
//new Municipality()
//{
//    Id = 303252,
//    Name = "Rincón del Doll",
//    FullName = "Junta Rincón del Doll",
//    Source = "IGN",
//    Category = "Junta",
//    Longitude = -60.3677913102595,
//    Latitude = -32.4045125002877,
//},
//new Municipality()
//{
//    Id = 309400,
//    Name = "Rincón del Gato",
//    FullName = "Junta Rincón del Gato",
//    Source = "IGN",
//    Category = "Junta",
//    Longitude = -58.5612848465004,
//    Latitude = -32.722816325486,
//},
//new Municipality()
//{
//    Id = 386077,
//    Name = "Rinconada",
//    FullName = "Comisión Rinconada",
//    Source = "IGN",
//    Category = "Comisión",
//    Longitude = -66.1143343908221,
//    Latitude = -22.4695252873648,
//},
//new Municipality()
//{
//    Id = 142455,
//    Name = "Río Bamba",
//    FullName = "Comuna Río Bamba",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -63.7340063162336,
//    Latitude = -34.0601407054622,
//},
//new Municipality()
//{
//    Id = 140147,
//    Name = "Río Ceballos",
//    FullName = "Municipality Río Ceballos",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -64.3191044520627,
//    Latitude = -31.1729826636356,
//},
//new Municipality()
//{
//    Id = 908532,
//    Name = "Río Chico y Nueva Trinidad",
//    FullName = "Comuna Río Chico y Nueva Trinidad",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -65.3191045690204,
//    Latitude = -27.5183937043774,
//},
//new Municipality()
//{
//    Id = 620210,
//    Name = "Río Colorado",
//    FullName = "Municipality Río Colorado",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -64.2488257752932,
//    Latitude = -39.024461218919,
//},
//new Municipality()
//{
//    Id = 908336,
//    Name = "Río Colorado",
//    FullName = "Comuna Río Colorado",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -65.3585085868697,
//    Latitude = -27.1425461371826,
//},
//new Municipality()
//{
//    Id = 140861,
//    Name = "Río Cuarto",
//    FullName = "Municipality Río Cuarto",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -64.3570883812807,
//    Latitude = -33.115558002371,
//},
//new Municipality()
//{
//    Id = 140028,
//    Name = "Río de los Sauces",
//    FullName = "Municipality Río de los Sauces",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -64.7120255667143,
//    Latitude = -32.5008389950701,
//},
//new Municipality()
//{
//    Id = 940007,
//    Name = "Río Grande",
//    FullName = "Municipality Río Grande",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -67.7984341202214,
//    Latitude = -53.8589019358364,
//},
//new Municipality()
//{
//    Id = 260133,
//    Name = "Río Mayo",
//    FullName = "Municipality Río Mayo",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -70.2675090217995,
//    Latitude = -45.700601256143,
//},
//new Municipality()
//{
//    Id = 260161,
//    Name = "Río Pico",
//    FullName = "Municipality Río Pico",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -71.3431136360952,
//    Latitude = -44.18134203414,
//},
//new Municipality()
//{
//    Id = 660280,
//    Name = "Río Piedras",
//    FullName = "Municipality Río Piedras",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -65.0408394774568,
//    Latitude = -25.2725330993152,
//},
//new Municipality()
//{
//    Id = 140938,
//    Name = "Río Primero",
//    FullName = "Municipality Río Primero",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -63.6234759919454,
//    Latitude = -31.3296360408912,
//},
//new Municipality()
//{
//    Id = 908420,
//    Name = "Río Seco",
//    FullName = "Comuna Río Seco",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -65.5732307382783,
//    Latitude = -27.2631502166152,
//},
//new Municipality()
//{
//    Id = 141071,
//    Name = "Río Segundo",
//    FullName = "Municipality Río Segundo",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -63.900994561655,
//    Latitude = -31.6440157915068,
//},
//new Municipality()
//{
//    Id = 141491,
//    Name = "Río Tercero",
//    FullName = "Municipality Río Tercero",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -64.1027089405291,
//    Latitude = -32.1683934801576,
//},
//new Municipality()
//{
//    Id = 60679,
//    Name = "Rivadavia",
//    FullName = "Municipality Rivadavia",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -63.0947611588419,
//    Latitude = -35.5810567049068,
//},
//new Municipality()
//{
//    Id = 500084,
//    Name = "Rivadavia",
//    FullName = "Municipality Rivadavia",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -68.6049732994365,
//    Latitude = -33.4170768899779,
//},
//new Municipality()
//{
//    Id = 823183,
//    Name = "Rivadavia",
//    FullName = "Comuna Rivadavia",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -61.0299506997885,
//    Latitude = -31.3073642314224,
//},
//new Municipality()
//{
//    Id = 700084,
//    Name = "Rivadavia",
//    FullName = "Municipality Rivadavia",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -68.6416232535729,
//    Latitude = -31.5542325394282,
//},
//new Municipality()
//{
//    Id = 660329,
//    Name = "Rivadavia Banda Norte",
//    FullName = "Municipality Rivadavia Banda Norte",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -62.7564403820803,
//    Latitude = -23.3870194842401,
//},
//new Municipality()
//{
//    Id = 660336,
//    Name = "Rivadavia Banda Sur",
//    FullName = "Municipality Rivadavia Banda Sur",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -62.9424278925363,
//    Latitude = -24.3049285905889,
//},
//new Municipality()
//{
//    Id = 303175,
//    Name = "Rocamora",
//    FullName = "Junta Rocamora",
//    Source = "IGN",
//    Category = "Junta",
//    Longitude = -59.0027390788753,
//    Latitude = -32.3947870154388,
//},
//new Municipality()
//{
//    Id = 386105,
//    Name = "Rodeito",
//    FullName = "Comisión Rodeito",
//    Source = "IGN",
//    Category = "Comisión",
//    Longitude = -64.7980266691572,
//    Latitude = -24.308431207754,
//},
//new Municipality()
//{
//    Id = 60686,
//    Name = "Rojas",
//    FullName = "Municipality Rojas",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -60.7880234647747,
//    Latitude = -34.1928173894529,
//},
//new Municipality()
//{
//    Id = 820294,
//    Name = "Roldán",
//    FullName = "Municipality Roldán",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -60.9187521819417,
//    Latitude = -32.8957783490815,
//},
//new Municipality()
//{
//    Id = 420322,
//    Name = "Rolón",
//    FullName = "Municipality Rolón",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -63.4667590912956,
//    Latitude = -37.1405643438626,
//},
//new Municipality()
//{
//    Id = 820237,
//    Name = "Romang",
//    FullName = "Municipality Romang",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -59.8198334756825,
//    Latitude = -29.4901219916197,
//},
//new Municipality()
//{
//    Id = 60693,
//    Name = "Roque Pérez",
//    FullName = "Municipality Roque Pérez",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -59.3575118159756,
//    Latitude = -35.481635701192,
//},
//new Municipality()
//{
//    Id = 140644,
//    Name = "Rosales",
//    FullName = "Municipality Rosales",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -63.1529797656943,
//    Latitude = -34.1747592562317,
//},
//new Municipality()
//{
//    Id = 820210,
//    Name = "Rosario",
//    FullName = "Municipality Rosario",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -60.6980842962309,
//    Latitude = -32.9489590048173,
//},
//new Municipality()
//{
//    Id = 660357,
//    Name = "Rosario de la Frontera",
//    FullName = "Municipality Rosario de la Frontera",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -64.9968286308421,
//    Latitude = -25.8176082047066,
//},
//new Municipality()
//{
//    Id = 660371,
//    Name = "Rosario de Lerma",
//    FullName = "Municipality Rosario de Lerma",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -65.7169194909588,
//    Latitude = -25.004235046084,
//},
//new Municipality()
//{
//    Id = 386112,
//    Name = "Rosario de Río Grande",
//    FullName = "Comisión Rosario de Río Grande",
//    Source = "IGN",
//    Category = "Comisión",
//    Longitude = -64.9045982171711,
//    Latitude = -24.3673345893659,
//},
//new Municipality()
//{
//    Id = 143218,
//    Name = "Rosario del Saladillo",
//    FullName = "Comuna Rosario del Saladillo",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -63.3904225264015,
//    Latitude = -30.3653429545009,
//},
//new Municipality()
//{
//    Id = 300406,
//    Name = "Rosario del Tala",
//    FullName = "Municipality Rosario del Tala",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -59.1388741254652,
//    Latitude = -32.3007264419016,
//},
//new Municipality()
//{
//    Id = 460112,
//    Name = "Rosario Vera Peñaloza",
//    FullName = "Municipality Rosario Vera Peñaloza",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -66.6741641296595,
//    Latitude = -31.4229834527921,
//},
//new Municipality()
//{
//    Id = 425133,
//    Name = "Rucanelo",
//    FullName = "Comisión Rucanelo",
//    Source = "IGN",
//    Category = "Comisión",
//    Longitude = -64.8436035724972,
//    Latitude = -36.0143907426614,
//},
//new Municipality()
//{
//    Id = 822511,
//    Name = "Rueda",
//    FullName = "Comuna Rueda",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -60.4259439177118,
//    Latitude = -33.3590364165659,
//},
//new Municipality()
//{
//    Id = 820070,
//    Name = "Rufino",
//    FullName = "Municipality Rufino",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -62.6436039136634,
//    Latitude = -34.242427368044,
//},
//new Municipality()
//{
//    Id = 540329,
//    Name = "Ruiz de Montoya",
//    FullName = "Municipality Ruiz de Montoya",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -55.0415996015149,
//    Latitude = -27.013722717051,
//},
//new Municipality()
//{
//    Id = 908245,
//    Name = "Rumi Punco",
//    FullName = "Comuna Rumi Punco",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -65.5974885027643,
//    Latitude = -27.9519686147094,
//},
//new Municipality()
//{
//    Id = 823190,
//    Name = "Sa Pereyra",
//    FullName = "Comuna Sa Pereyra",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -61.3468277202869,
//    Latitude = -31.5971313084421,
//},
//new Municipality()
//{
//    Id = 60700,
//    Name = "Saavedra",
//    FullName = "Municipality Saavedra",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -62.4343829136668,
//    Latitude = -37.7706381329585,
//},
//new Municipality()
//{
//    Id = 141330,
//    Name = "Sacanta",
//    FullName = "Municipality Sacanta",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -63.0467526382412,
//    Latitude = -31.6643044888969,
//},
//new Municipality()
//{
//    Id = 142721,
//    Name = "Sagrada Familia",
//    FullName = "Comuna Sagrada Familia",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -63.4453892518836,
//    Latitude = -31.2879311408046,
//},
//new Municipality()
//{
//    Id = 822336,
//    Name = "Saguier",
//    FullName = "Comuna Saguier",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -61.6895604627233,
//    Latitude = -31.3372278156435,
//},
//new Municipality()
//{
//    Id = 140595,
//    Name = "Saira",
//    FullName = "Municipality Saira",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -62.1010565233928,
//    Latitude = -32.4083063626491,
//},
//new Municipality()
//{
//    Id = 180308,
//    Name = "Saladas",
//    FullName = "Municipality Saladas",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -58.6240065423874,
//    Latitude = -28.3038069264731,
//},
//new Municipality()
//{
//    Id = 822560,
//    Name = "Saladero Mariano Cabal",
//    FullName = "Comuna Saladero Mariano Cabal",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -60.0480533139803,
//    Latitude = -30.9263607618729,
//},
//new Municipality()
//{
//    Id = 142343,
//    Name = "Saladillo",
//    FullName = "Comuna Saladillo",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -62.3430346300725,
//    Latitude = -32.9330379413915,
//},
//new Municipality()
//{
//    Id = 746063,
//    Name = "Saladillo",
//    FullName = "Comisión Saladillo",
//    Source = "IGN",
//    Category = "Comisión",
//    Longitude = -65.8559267176371,
//    Latitude = -33.2022523817984,
//},
//new Municipality()
//{
//    Id = 60707,
//    Name = "Saladillo",
//    FullName = "Municipality Saladillo",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -59.7026607444532,
//    Latitude = -35.6768064519233,
//},
//new Municipality()
//{
//    Id = 140154,
//    Name = "Saldán",
//    FullName = "Municipality Saldán",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -64.310894608001,
//    Latitude = -31.3147407781026,
//},
//new Municipality()
//{
//    Id = 60721,
//    Name = "Salliqueló",
//    FullName = "Municipality Salliqueló",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -63.0479735266054,
//    Latitude = -36.6717775352133,
//},
//new Municipality()
//{
//    Id = 140609,
//    Name = "Salsacate",
//    FullName = "Municipality Salsacate",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -65.128217238107,
//    Latitude = -31.33937667094,
//},
//new Municipality()
//{
//    Id = 140161,
//    Name = "Salsipuedes",
//    FullName = "Municipality Salsipuedes",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -64.3006220024868,
//    Latitude = -31.1248166526693,
//},
//new Municipality()
//{
//    Id = 660063,
//    Name = "Salta",
//    FullName = "Municipality Salta",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -65.2351342457008,
//    Latitude = -24.9088854363328,
//},
//new Municipality()
//{
//    Id = 60714,
//    Name = "Salto",
//    FullName = "Municipality Salto",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -60.3052878686821,
//    Latitude = -34.2710777868374,
//},
//new Municipality()
//{
//    Id = 822931,
//    Name = "Salto Grande",
//    FullName = "Comuna Salto Grande",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -61.1174499429479,
//    Latitude = -32.6908912128988,
//},
//new Municipality()
//{
//    Id = 140868,
//    Name = "Sampacho",
//    FullName = "Municipality Sampacho",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -64.7081087013993,
//    Latitude = -33.3725117758152,
//},
//new Municipality()
//{
//    Id = 220420,
//    Name = "Samuhú",
//    FullName = "Municipality Samuhú",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -60.3520137530967,
//    Latitude = -27.6085245697304,
//},
//new Municipality()
//{
//    Id = 823197,
//    Name = "San Agustín",
//    FullName = "Comuna San Agustín",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -60.9606129125863,
//    Latitude = -31.6805506670124,
//},
//new Municipality()
//{
//    Id = 140056,
//    Name = "San Agustín",
//    FullName = "Municipality San Agustín",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -64.3764401661818,
//    Latitude = -31.9727259844158,
//},
//new Municipality()
//{
//    Id = 908154,
//    Name = "San Andrés",
//    FullName = "Comuna San Andrés",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -65.1817320423116,
//    Latitude = -26.9199135404059,
//},
//new Municipality()
//{
//    Id = 60728,
//    Name = "San Andrés de Giles",
//    FullName = "Municipality San Andrés de Giles",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -59.4731985919912,
//    Latitude = -34.4377314279751,
//},
//new Municipality()
//{
//    Id = 822343,
//    Name = "San Antonio",
//    FullName = "Comuna San Antonio",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -61.7611781065705,
//    Latitude = -31.25096985834,
//},
//new Municipality()
//{
//    Id = 380161,
//    Name = "San Antonio",
//    FullName = "Municipality San Antonio",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -65.4465062655081,
//    Latitude = -24.34666187727,
//},
//new Municipality()
//{
//    Id = 540189,
//    Name = "San Antonio",
//    FullName = "Municipality San Antonio",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -53.9385338265928,
//    Latitude = -25.9963679675535,
//},
//new Municipality()
//{
//    Id = 60735,
//    Name = "San Antonio de Areco",
//    FullName = "Municipality San Antonio de Areco",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -59.5194433183219,
//    Latitude = -34.2207573810574,
//},
//new Municipality()
//{
//    Id = 140710,
//    Name = "San Antonio de Arredondo",
//    FullName = "Municipality San Antonio de Arredondo",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -64.5441084517609,
//    Latitude = -31.5250380107688,
//},
//new Municipality()
//{
//    Id = 180014,
//    Name = "San Antonio de Itatí",
//    FullName = "Municipality San Antonio de Itatí",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -57.6120140515951,
//    Latitude = -27.4773522001999,
//},
//new Municipality()
//{
//    Id = 141722,
//    Name = "San Antonio de Litín",
//    FullName = "Municipality San Antonio de Litín",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -62.6331396610771,
//    Latitude = -32.2154566164449,
//},
//new Municipality()
//{
//    Id = 660245,
//    Name = "San Antonio de los Cobres",
//    FullName = "Municipality San Antonio de los Cobres",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -66.8173486625798,
//    Latitude = -24.573597508995,
//},
//new Municipality()
//{
//    Id = 822854,
//    Name = "San Antonio de Obligado",
//    FullName = "Comuna San Antonio de Obligado",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -59.3146559426892,
//    Latitude = -28.3868266481118,
//},
//new Municipality()
//{
//    Id = 180175,
//    Name = "San Antonio Isla Apipé Grande",
//    FullName = "Municipality San Antonio Isla Apipé Grande",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -56.8666243830177,
//    Latitude = -27.5087963952463,
//},
//new Municipality()
//{
//    Id = 620231,
//    Name = "San Antonio Oeste",
//    FullName = "Municipality San Antonio Oeste",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -65.3353738201607,
//    Latitude = -40.6987182412496,
//},
//new Municipality()
//{
//    Id = 140875,
//    Name = "San Basilio",
//    FullName = "Municipality San Basilio",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -64.3154562518364,
//    Latitude = -33.4975395266719,
//},
//new Municipality()
//{
//    Id = 300343,
//    Name = "San Benito",
//    FullName = "Municipality San Benito",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -60.4177010287131,
//    Latitude = -31.8026479704812,
//},
//new Municipality()
//{
//    Id = 220350,
//    Name = "San Bernardo",
//    FullName = "Municipality San Bernardo",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -60.7005904346434,
//    Latitude = -27.3367482270114,
//},
//new Municipality()
//{
//    Id = 823946,
//    Name = "San Bernardo",
//    FullName = "Comuna San Bernardo",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -60.5572731688325,
//    Latitude = -30.8743272113348,
//},
//new Municipality()
//{
//    Id = 823330,
//    Name = "San Bernardo",
//    FullName = "Comuna San Bernardo",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -61.2427589341907,
//    Latitude = -28.6804992323525,
//},
//new Municipality()
//{
//    Id = 460119,
//    Name = "San Blas de Los Sauces",
//    FullName = "Municipality San Blas de Los Sauces",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -67.1581352967934,
//    Latitude = -28.5432938438196,
//},
//new Municipality()
//{
//    Id = 660392,
//    Name = "San Carlos",
//    FullName = "Municipality San Carlos",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -65.9437919037794,
//    Latitude = -25.6471054404286,
//},
//new Municipality()
//{
//    Id = 180182,
//    Name = "San Carlos",
//    FullName = "Municipality San Carlos",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -56.027415901209,
//    Latitude = -27.6404238053557,
//},
//new Municipality()
//{
//    Id = 500091,
//    Name = "San Carlos",
//    FullName = "Municipality San Carlos",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -69.0973102105926,
//    Latitude = -34.0755241605452,
//},
//new Municipality()
//{
//    Id = 820168,
//    Name = "San Carlos Centro",
//    FullName = "Municipality San Carlos Centro",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -61.1371667633434,
//    Latitude = -31.7036916909091,
//},
//new Municipality()
//{
//    Id = 620077,
//    Name = "San Carlos de Bariloche",
//    FullName = "Municipality San Carlos de Bariloche",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -71.4559580663114,
//    Latitude = -41.1027302002542,
//},
//new Municipality()
//{
//    Id = 140602,
//    Name = "San Carlos Minas",
//    FullName = "Municipality San Carlos Minas",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -65.0830995264974,
//    Latitude = -31.1637575063997,
//},
//new Municipality()
//{
//    Id = 823204,
//    Name = "San Carlos Norte",
//    FullName = "Comuna San Carlos Norte",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -61.0756716878772,
//    Latitude = -31.6460399066645,
//},
//new Municipality()
//{
//    Id = 823211,
//    Name = "San Carlos Sud",
//    FullName = "Comuna San Carlos Sud",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -61.1115762777436,
//    Latitude = -31.7938277427496,
//},
//new Municipality()
//{
//    Id = 60742,
//    Name = "San Cayetano",
//    FullName = "Municipality San Cayetano",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -59.5863264400361,
//    Latitude = -38.3890731972485,
//},
//new Municipality()
//{
//    Id = 303182,
//    Name = "San Cipriano",
//    FullName = "Junta San Cipriano",
//    Source = "IGN",
//    Category = "Junta",
//    Longitude = -58.3292808026978,
//    Latitude = -32.3486651546852,
//},
//new Municipality()
//{
//    Id = 143064,
//    Name = "San Clemente",
//    FullName = "Comuna San Clemente",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -64.6344801875041,
//    Latitude = -31.7222791861731,
//},
//new Municipality()
//{
//    Id = 180329,
//    Name = "San Cosme",
//    FullName = "Municipality San Cosme",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -58.4474165515507,
//    Latitude = -27.3712891587554,
//},
//new Municipality()
//{
//    Id = 820231,
//    Name = "San Cristóbal",
//    FullName = "Municipality San Cristóbal",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -61.0979078285953,
//    Latitude = -30.2369464342856,
//},
//new Municipality()
//{
//    Id = 822714,
//    Name = "San Eduardo",
//    FullName = "Comuna San Eduardo",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -62.1203702108474,
//    Latitude = -33.9052421066899,
//},
//new Municipality()
//{
//    Id = 309780,
//    Name = "San Ernesto",
//    FullName = "Junta San Ernesto",
//    Source = "IGN",
//    Category = "Junta",
//    Longitude = -58.6302183198757,
//    Latitude = -31.8381308489442,
//},
//new Municipality()
//{
//    Id = 140714,
//    Name = "San Esteban",
//    FullName = "Municipality San Esteban",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -64.531631091885,
//    Latitude = -30.9214339905767,
//},
//new Municipality()
//{
//    Id = 823834,
//    Name = "San Eugenio",
//    FullName = "Comuna San Eugenio",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -61.0968257934086,
//    Latitude = -32.0796414115587,
//},
//new Municipality()
//{
//    Id = 823841,
//    Name = "San Fabián",
//    FullName = "Comuna San Fabián",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -60.8750417147834,
//    Latitude = -32.1678528108491,
//},
//new Municipality()
//{
//    Id = 908364,
//    Name = "San Felipe y Santa Bárbara",
//    FullName = "Comuna San Felipe y Santa Bárbara",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -65.2453352119827,
//    Latitude = -26.9263107502072,
//},
//new Municipality()
//{
//    Id = 60749,
//    Name = "San Fernando",
//    FullName = "Municipality San Fernando",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -58.5345816568901,
//    Latitude = -34.1558361119161,
//},
//new Municipality()
//{
//    Id = 100112,
//    Name = "San Fernando",
//    FullName = "Municipality San Fernando",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -66.8569354572956,
//    Latitude = -27.3101180161602,
//},
//new Municipality()
//{
//    Id = 100140,
//    Name = "San Fernando del Valle de Catamarca",
//    FullName = "Municipality San Fernando del Valle de Catamarca",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -65.8367262657193,
//    Latitude = -28.411789018229,
//},
//new Municipality()
//{
//    Id = 386224,
//    Name = "San Francisco",
//    FullName = "Comisión San Francisco",
//    Source = "IGN",
//    Category = "Comisión",
//    Longitude = -64.9246811458032,
//    Latitude = -23.6271181991213,
//},
//new Municipality()
//{
//    Id = 141337,
//    Name = "San Francisco",
//    FullName = "Municipality San Francisco",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -62.1085063918832,
//    Latitude = -31.429051535066,
//},
//new Municipality()
//{
//    Id = 740028,
//    Name = "San Francisco",
//    FullName = "Municipality San Francisco",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -66.1262207070673,
//    Latitude = -32.5944806738646,
//},
//new Municipality()
//{
//    Id = 822721,
//    Name = "San Francisco de Santa Fe",
//    FullName = "Comuna San Francisco de Santa Fe",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -62.1412542257073,
//    Latitude = -33.5986886569119,
//},
//new Municipality()
//{
//    Id = 141414,
//    Name = "San Francisco del Chañar",
//    FullName = "Municipality San Francisco del Chañar",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -63.9388834433455,
//    Latitude = -29.8335821929824,
//},
//new Municipality()
//{
//    Id = 820256,
//    Name = "San Genaro",
//    FullName = "Municipality San Genaro",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -61.2663151312985,
//    Latitude = -32.3579824330353,
//},
//new Municipality()
//{
//    Id = 142427,
//    Name = "San Gerónimo",
//    FullName = "Comuna San Gerónimo",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -64.9294145436855,
//    Latitude = -31.3559936707815,
//},
//new Municipality()
//{
//    Id = 822728,
//    Name = "San Gregorio",
//    FullName = "Comuna San Gregorio",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -61.8922281198948,
//    Latitude = -34.266797125974,
//},
//new Municipality()
//{
//    Id = 820233,
//    Name = "San Guillermo",
//    FullName = "Municipality San Guillermo",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -61.8778467201676,
//    Latitude = -30.3863721375294,
//},
//new Municipality()
//{
//    Id = 300255,
//    Name = "San Gustavo",
//    FullName = "Municipality San Gustavo",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -59.4442638082132,
//    Latitude = -30.6908036119355,
//},
//new Municipality()
//{
//    Id = 345028,
//    Name = "San Hilario",
//    FullName = "Comisión San Hilario",
//    Source = "IGN",
//    Category = "Comisión",
//    Longitude = -58.6471275416652,
//    Latitude = -26.0259038272531,
//},
//new Municipality()
//{
//    Id = 540462,
//    Name = "San Ignacio",
//    FullName = "Municipality San Ignacio",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -55.4592623959533,
//    Latitude = -27.293347351924,
//},
//new Municipality()
//{
//    Id = 908252,
//    Name = "San Ignacio",
//    FullName = "Comuna San Ignacio",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -65.6422403052397,
//    Latitude = -27.7630583479046,
//},
//new Municipality()
//{
//    Id = 142063,
//    Name = "San Ignacio",
//    FullName = "Comuna San Ignacio",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -64.5469099126919,
//    Latitude = -32.1516825639597,
//},
//new Municipality()
//{
//    Id = 60756,
//    Name = "San Isidro",
//    FullName = "Municipality San Isidro",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -58.5372090766753,
//    Latitude = -34.4868929544338,
//},
//new Municipality()
//{
//    Id = 180143,
//    Name = "San Isidro",
//    FullName = "Municipality San Isidro",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -59.4184430701309,
//    Latitude = -29.7037574908881,
//},
//new Municipality()
//{
//    Id = 900077,
//    Name = "San Isidro de Lules",
//    FullName = "Municipality San Isidro de Lules",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -65.3408685804841,
//    Latitude = -26.9539510133894,
//},
//new Municipality()
//{
//    Id = 300119,
//    Name = "San Jaime de la Frontera",
//    FullName = "Municipality San Jaime de la Frontera",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -58.3012243966122,
//    Latitude = -30.3362598190165,
//},
//new Municipality()
//{
//    Id = 540497,
//    Name = "San Javier",
//    FullName = "Municipality San Javier",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -55.1540444944028,
//    Latitude = -27.8093657582261,
//},
//new Municipality()
//{
//    Id = 820238,
//    Name = "San Javier",
//    FullName = "Municipality San Javier",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -59.8905516741484,
//    Latitude = -30.4558826910545,
//},
//new Municipality()
//{
//    Id = 908651,
//    Name = "San Javier",
//    FullName = "Comuna San Javier",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -65.390594672862,
//    Latitude = -26.7866671612729,
//},
//new Municipality()
//{
//    Id = 141134,
//    Name = "San Javier y Yacanto",
//    FullName = "Municipality San Javier y Yacanto",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -65.035648976824,
//    Latitude = -32.0189945410788,
//},
//new Municipality()
//{
//    Id = 746273,
//    Name = "San Jerónimo",
//    FullName = "Comisión San Jerónimo",
//    Source = "IGN",
//    Category = "Comisión",
//    Longitude = -66.5094866217744,
//    Latitude = -33.1617646920988,
//},
//new Municipality()
//{
//    Id = 823218,
//    Name = "San Jerónimo del Sauce",
//    FullName = "Comuna San Jerónimo del Sauce",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -61.1716574428882,
//    Latitude = -31.608230507384,
//},
//new Municipality()
//{
//    Id = 820171,
//    Name = "San Jerónimo Norte",
//    FullName = "Municipality San Jerónimo Norte",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -61.0736376747312,
//    Latitude = -31.5258534091477,
//},
//new Municipality()
//{
//    Id = 824023,
//    Name = "San Jerónimo Sud",
//    FullName = "Comuna San Jerónimo Sud",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -61.0297454250279,
//    Latitude = -32.8779609603952,
//},
//new Municipality()
//{
//    Id = 142462,
//    Name = "San Joaquín",
//    FullName = "Comuna San Joaquín",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -63.7131847442,
//    Latitude = -34.510881493493,
//},
//new Municipality()
//{
//    Id = 820315,
//    Name = "San Jorge",
//    FullName = "Municipality San Jorge",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -61.8805263599439,
//    Latitude = -31.9116126709522,
//},
//new Municipality()
//{
//    Id = 100203,
//    Name = "San José",
//    FullName = "Municipality San José",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -66.2956726548183,
//    Latitude = -26.8797639020989,
//},
//new Municipality()
//{
//    Id = 540021,
//    Name = "San José",
//    FullName = "Municipality San José",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -55.6689161209503,
//    Latitude = -27.77542950746,
//},
//new Municipality()
//{
//    Id = 823043,
//    Name = "San José",
//    FullName = "Comuna San José",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -60.8614530918881,
//    Latitude = -31.6223065299939,
//},
//new Municipality()
//{
//    Id = 141141,
//    Name = "San José",
//    FullName = "Municipality San José",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -65.3168685501844,
//    Latitude = -31.9821680415163,
//},
//new Municipality()
//{
//    Id = 300014,
//    Name = "San José",
//    FullName = "Municipality San José",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -58.2675523379923,
//    Latitude = -32.2067666987758,
//},
//new Municipality()
//{
//    Id = 300161,
//    Name = "San José de Feliciano",
//    FullName = "Municipality San José de Feliciano",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -58.7539653363578,
//    Latitude = -30.3734758234181,
//},
//new Municipality()
//{
//    Id = 300189,
//    Name = "San José de Gualeguaychú",
//    FullName = "Municipality San José de Gualeguaychú",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -58.4207607775612,
//    Latitude = -33.027644483541,
//},
//new Municipality()
//{
//    Id = 908259,
//    Name = "San José de la Cocha",
//    FullName = "Comuna San José de la Cocha",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -65.5637818950499,
//    Latitude = -27.7311386048212,
//},
//new Municipality()
//{
//    Id = 141561,
//    Name = "San José de la Dormida",
//    FullName = "Municipality San José de la Dormida",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -63.947567595877,
//    Latitude = -30.3571542328118,
//},
//new Municipality()
//{
//    Id = 822091,
//    Name = "San José de la Esquina",
//    FullName = "Comuna San José de la Esquina",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -61.6885050572039,
//    Latitude = -33.1572759334948,
//},
//new Municipality()
//{
//    Id = 141568,
//    Name = "San José de las Salinas",
//    FullName = "Municipality San José de las Salinas",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -64.5964266269363,
//    Latitude = -30.0065939301358,
//},
//new Municipality()
//{
//    Id = 660077,
//    Name = "San José de los Cerrillos",
//    FullName = "Municipality San José de los Cerrillos",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -65.4306031558944,
//    Latitude = -24.9100578527467,
//},
//new Municipality()
//{
//    Id = 660266,
//    Name = "San José de Metán",
//    FullName = "Municipality San José de Metán",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -64.9693171527675,
//    Latitude = -25.5207103517335,
//},
//new Municipality()
//{
//    Id = 746112,
//    Name = "San José del Morro",
//    FullName = "Comisión San José del Morro",
//    Source = "IGN",
//    Category = "Comisión",
//    Longitude = -65.4909903747159,
//    Latitude = -33.2125308103617,
//},
//new Municipality()
//{
//    Id = 820143,
//    Name = "San José del Rincón",
//    FullName = "Municipality San José del Rincón",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -60.5161613567644,
//    Latitude = -31.6105210974876,
//},
//new Municipality()
//{
//    Id = 700028,
//    Name = "San Juan",
//    FullName = "Municipality San Juan",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -68.5342856277502,
//    Latitude = -31.5330748483671,
//},
//new Municipality()
//{
//    Id = 309070,
//    Name = "San Justo",
//    FullName = "Junta San Justo",
//    Source = "IGN",
//    Category = "Junta",
//    Longitude = -58.1486020941943,
//    Latitude = -31.1172176373154,
//},
//new Municipality()
//{
//    Id = 820259,
//    Name = "San Justo",
//    FullName = "Municipality San Justo",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -60.4224495725886,
//    Latitude = -30.8046074901211,
//},
//new Municipality()
//{
//    Id = 300448,
//    Name = "San Justo",
//    FullName = "Municipality San Justo",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -58.4476511184679,
//    Latitude = -32.4309131859175,
//},
//new Municipality()
//{
//    Id = 820301,
//    Name = "San Lorenzo",
//    FullName = "Municipality San Lorenzo",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -60.7520288999314,
//    Latitude = -32.7444112324135,
//},
//new Municipality()
//{
//    Id = 660070,
//    Name = "San Lorenzo",
//    FullName = "Municipality San Lorenzo",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -65.5346994848768,
//    Latitude = -24.750854332749,
//},
//new Municipality()
//{
//    Id = 142868,
//    Name = "San Lorenzo",
//    FullName = "Comuna San Lorenzo",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -65.0051014087656,
//    Latitude = -31.6586437934171,
//},
//new Municipality()
//{
//    Id = 180315,
//    Name = "San Lorenzo",
//    FullName = "Municipality San Lorenzo",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -58.7720032022699,
//    Latitude = -28.1625077346294,
//},
//new Municipality()
//{
//    Id = 740133,
//    Name = "San Luis",
//    FullName = "Municipality San Luis",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -66.3434777445641,
//    Latitude = -33.3035158233766,
//},
//new Municipality()
//{
//    Id = 180350,
//    Name = "San Luis del Palmar",
//    FullName = "Municipality San Luis del Palmar",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -58.2608321387977,
//    Latitude = -27.6003471873645,
//},
//new Municipality()
//{
//    Id = 303189,
//    Name = "San Marcial",
//    FullName = "Junta San Marcial",
//    Source = "IGN",
//    Category = "Junta",
//    Longitude = -58.9888814833282,
//    Latitude = -32.1966657282425,
//},
//new Municipality()
//{
//    Id = 140189,
//    Name = "San Marcos Sierra",
//    FullName = "Municipality San Marcos Sierra",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -64.6511803149359,
//    Latitude = -30.7673188311433,
//},
//new Municipality()
//{
//    Id = 141729,
//    Name = "San Marcos Sud",
//    FullName = "Municipality San Marcos Sud",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -62.4804580153733,
//    Latitude = -32.6262603360861,
//},
//new Municipality()
//{
//    Id = 823232,
//    Name = "San Mariano",
//    FullName = "Comuna San Mariano",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -61.407434231416,
//    Latitude = -31.6830923583522,
//},
//new Municipality()
//{
//    Id = 540413,
//    Name = "San Martín",
//    FullName = "Municipality San Martín",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -55.2627853004396,
//    Latitude = -27.4727250630159,
//},
//new Municipality()
//{
//    Id = 740140,
//    Name = "San Martín",
//    FullName = "Municipality San Martín",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -65.6758808215233,
//    Latitude = -32.4101296285628,
//},
//new Municipality()
//{
//    Id = 500098,
//    Name = "San Martín",
//    FullName = "Municipality San Martín",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -68.2888458647488,
//    Latitude = -32.9140381657571,
//},
//new Municipality()
//{
//    Id = 700091,
//    Name = "San Martín",
//    FullName = "Municipality San Martín",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -68.2072669737409,
//    Latitude = -31.5285457556283,
//},
//new Municipality()
//{
//    Id = 824128,
//    Name = "San Martín de las Escobas",
//    FullName = "Comuna San Martín de las Escobas",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -61.6059946109849,
//    Latitude = -31.8394537015055,
//},
//new Municipality()
//{
//    Id = 580119,
//    Name = "San Martín de los Andes",
//    FullName = "Municipality San Martín de los Andes",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -71.3015414173334,
//    Latitude = -40.1347992136446,
//},
//new Municipality()
//{
//    Id = 340147,
//    Name = "San Martín Dos",
//    FullName = "Municipality San Martín Dos",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -59.6447340181648,
//    Latitude = -24.4373909208269,
//},
//new Municipality()
//{
//    Id = 823953,
//    Name = "San Martín Norte",
//    FullName = "Comuna San Martín Norte",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -60.2447290870983,
//    Latitude = -30.2699724952808,
//},
//new Municipality()
//{
//    Id = 180392,
//    Name = "San Miguel",
//    FullName = "Municipality San Miguel",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -57.5417406026873,
//    Latitude = -28.0380979416734,
//},
//new Municipality()
//{
//    Id = 309005,
//    Name = "San Miguel",
//    FullName = "Junta de Gobierno San Miguel",
//    Source = "IGN",
//    Category = "Junta de Gobierno",
//    Longitude = -58.6015795234014,
//    Latitude = -32.0753910021365,
//},
//new Municipality()
//{
//    Id = 60760,
//    Name = "San Miguel",
//    FullName = "Municipality San Miguel",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -58.6917835230055,
//    Latitude = -34.552134348678,
//},
//new Municipality()
//{
//    Id = 900014,
//    Name = "San Miguel de Tucumán",
//    FullName = "Municipality San Miguel de Tucumán",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -65.2177164528872,
//    Latitude = -26.8339982188674,
//},
//new Municipality()
//{
//    Id = 60763,
//    Name = "San Nicolás",
//    FullName = "Municipality San Nicolás",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -60.2931485555259,
//    Latitude = -33.4829870528588,
//},
//new Municipality()
//{
//    Id = 746091,
//    Name = "San Pablo",
//    FullName = "Comisión San Pablo",
//    Source = "IGN",
//    Category = "Comisión",
//    Longitude = -65.3092306502765,
//    Latitude = -32.6522518781734,
//},
//new Municipality()
//{
//    Id = 908371,
//    Name = "San Pablo y Villa Nougués",
//    FullName = "Comuna San Pablo y Villa Nougués",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -65.4884038664015,
//    Latitude = -26.822490071284,
//},
//new Municipality()
//{
//    Id = 580021,
//    Name = "San Patricio del Chañar",
//    FullName = "Municipality San Patricio del Chañar",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -68.3509221847303,
//    Latitude = -38.5937309139497,
//},
//new Municipality()
//{
//    Id = 60770,
//    Name = "San Pedro",
//    FullName = "Municipality San Pedro",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -59.7826256983281,
//    Latitude = -33.7809855832464,
//},
//new Municipality()
//{
//    Id = 540504,
//    Name = "San Pedro",
//    FullName = "Municipality San Pedro",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -53.941229126445,
//    Latitude = -26.7112090354563,
//},
//new Municipality()
//{
//    Id = 141106,
//    Name = "San Pedro",
//    FullName = "Municipality San Pedro",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -65.2450584935875,
//    Latitude = -31.8743510646115,
//},
//new Municipality()
//{
//    Id = 309175,
//    Name = "San Pedro",
//    FullName = "Junta San Pedro",
//    Source = "IGN",
//    Category = "Junta",
//    Longitude = -58.1201573180469,
//    Latitude = -30.7247928486638,
//},
//new Municipality()
//{
//    Id = 908630,
//    Name = "San Pedro de Colalao",
//    FullName = "Comuna San Pedro de Colalao",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -65.5295906883249,
//    Latitude = -26.2418388987449,
//},
//new Municipality()
//{
//    Id = 380224,
//    Name = "San Pedro de Jujuy",
//    FullName = "Municipality San Pedro de Jujuy",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -64.7901524914261,
//    Latitude = -24.3119114550013,
//},
//new Municipality()
//{
//    Id = 141575,
//    Name = "San Pedro Norte",
//    FullName = "Municipality San Pedro Norte",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -64.2146114629845,
//    Latitude = -30.2554577373608,
//},
//new Municipality()
//{
//    Id = 908539,
//    Name = "San Pedro y San Antonio",
//    FullName = "Comuna San Pedro y San Antonio",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -65.3733266923869,
//    Latitude = -27.3642260982927,
//},
//new Municipality()
//{
//    Id = 500105,
//    Name = "San Rafael",
//    FullName = "Municipality San Rafael",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -68.3842396526737,
//    Latitude = -34.9454490172465,
//},
//new Municipality()
//{
//    Id = 309495,
//    Name = "San Ramírez",
//    FullName = "Junta San Ramírez",
//    Source = "IGN",
//    Category = "Junta",
//    Longitude = -59.3615161672059,
//    Latitude = -30.4284924517921,
//},
//new Municipality()
//{
//    Id = 309180,
//    Name = "San Ramón",
//    FullName = "Junta San Ramón",
//    Source = "IGN",
//    Category = "Junta",
//    Longitude = -58.1937041371603,
//    Latitude = -30.8492211735609,
//},
//new Municipality()
//{
//    Id = 660315,
//    Name = "San Ramón de la Nueva Orán",
//    FullName = "Municipality San Ramón de la Nueva Orán",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -64.606923057702,
//    Latitude = -23.0924553136159,
//},
//new Municipality()
//{
//    Id = 142518,
//    Name = "San Roque",
//    FullName = "Comuna San Roque",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -64.4504675476083,
//    Latitude = -31.3514245506133,
//},
//new Municipality()
//{
//    Id = 309185,
//    Name = "San Roque",
//    FullName = "Junta San Roque",
//    Source = "IGN",
//    Category = "Junta",
//    Longitude = -57.8985272803699,
//    Latitude = -30.6923097012987,
//},
//new Municipality()
//{
//    Id = 180420,
//    Name = "San Roque",
//    FullName = "Municipality San Roque",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -58.7691720349558,
//    Latitude = -28.6711361787973,
//},
//new Municipality()
//{
//    Id = 300385,
//    Name = "San Salvador",
//    FullName = "Municipality San Salvador",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -58.5011063374224,
//    Latitude = -31.6177993569508,
//},
//new Municipality()
//{
//    Id = 380035,
//    Name = "San Salvador de Jujuy",
//    FullName = "Municipality San Salvador de Jujuy",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -65.418750170421,
//    Latitude = -24.1943328109466,
//},
//new Municipality()
//{
//    Id = 60778,
//    Name = "San Vicente",
//    FullName = "Municipality San Vicente",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -58.4318120603266,
//    Latitude = -35.0715087168304,
//},
//new Municipality()
//{
//    Id = 820045,
//    Name = "San Vicente",
//    FullName = "Comuna San Vicente",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -61.5648309204331,
//    Latitude = -31.6841527257645,
//},
//new Municipality()
//{
//    Id = 142875,
//    Name = "San Vicente",
//    FullName = "Comuna San Vicente",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -65.5312562828786,
//    Latitude = -31.8368038813299,
//},
//new Municipality()
//{
//    Id = 540203,
//    Name = "San Vicente",
//    FullName = "Municipality San Vicente",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -54.4040745753691,
//    Latitude = -26.9628189892924,
//},
//new Municipality()
//{
//    Id = 302376,
//    Name = "San Víctor",
//    FullName = "Junta San Víctor",
//    Source = "IGN",
//    Category = "Junta",
//    Longitude = -58.9277232142906,
//    Latitude = -30.4464621778368,
//},
//new Municipality()
//{
//    Id = 460126,
//    Name = "Sanagasta",
//    FullName = "Municipality Sanagasta",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -67.0658836337284,
//    Latitude = -29.1585269700836,
//},
//new Municipality()
//{
//    Id = 822735,
//    Name = "Sancti Spiritu",
//    FullName = "Comuna Sancti Spiritu",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -62.2915880914815,
//    Latitude = -33.9893758172117,
//},
//new Municipality()
//{
//    Id = 822098,
//    Name = "Sanford",
//    FullName = "Comuna Sanford",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -61.2332294502134,
//    Latitude = -33.1857451821469,
//},
//new Municipality()
//{
//    Id = 540098,
//    Name = "Santa Ana",
//    FullName = "Municipality Santa Ana",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -55.5975181317372,
//    Latitude = -27.4093121831294,
//},
//new Municipality()
//{
//    Id = 386231,
//    Name = "Santa Ana",
//    FullName = "Comisión Santa Ana",
//    Source = "IGN",
//    Category = "Comisión",
//    Longitude = -64.9623501355363,
//    Latitude = -23.3563984909111,
//},
//new Municipality()
//{
//    Id = 908483,
//    Name = "Santa Ana",
//    FullName = "Comuna Santa Ana",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -65.7520100798646,
//    Latitude = -27.4800235123475,
//},
//new Municipality()
//{
//    Id = 300126,
//    Name = "Santa Ana",
//    FullName = "Municipality Santa Ana",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -57.9259701779828,
//    Latitude = -30.8660058038159,
//},
//new Municipality()
//{
//    Id = 180336,
//    Name = "Santa Ana de los Guácaras",
//    FullName = "Municipality Santa Ana de los Guácaras",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -58.6118511814974,
//    Latitude = -27.4449945411465,
//},
//new Municipality()
//{
//    Id = 300455,
//    Name = "Santa Anita",
//    FullName = "Municipality Santa Anita",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -58.7743843033161,
//    Latitude = -32.1683665095126,
//},
//new Municipality()
//{
//    Id = 386147,
//    Name = "Santa Catalina",
//    FullName = "Comisión Santa Catalina",
//    Source = "IGN",
//    Category = "Comisión",
//    Longitude = -66.1832319160816,
//    Latitude = -22.0755534429827,
//},
//new Municipality()
//{
//    Id = 140882,
//    Name = "Santa Catalina Holmberg",
//    FullName = "Municipality Santa Catalina Holmberg",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -64.4262539399712,
//    Latitude = -33.2024080778911,
//},
//new Municipality()
//{
//    Id = 380252,
//    Name = "Santa Clara",
//    FullName = "Municipality Santa Clara",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -64.6095289074146,
//    Latitude = -24.2734471838741,
//},
//new Municipality()
//{
//    Id = 823239,
//    Name = "Santa Clara de Buena Vista",
//    FullName = "Comuna Santa Clara de Buena Vista",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -61.3441354182791,
//    Latitude = -31.7853071266113,
//},
//new Municipality()
//{
//    Id = 822357,
//    Name = "Santa Clara de Saguier",
//    FullName = "Comuna Santa Clara de Saguier",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -61.8191081325282,
//    Latitude = -31.3362205253631,
//},
//new Municipality()
//{
//    Id = 908546,
//    Name = "Santa Cruz y La Tuna",
//    FullName = "Comuna Santa Cruz y La Tuna",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -65.4449612662474,
//    Latitude = -27.3473564763703,
//},
//new Municipality()
//{
//    Id = 300259,
//    Name = "Santa Elena",
//    FullName = "Municipality Santa Elena",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -59.7408875681467,
//    Latitude = -30.9392871402284,
//},
//new Municipality()
//{
//    Id = 142791,
//    Name = "Santa Elena",
//    FullName = "Comuna Santa Elena",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -63.8587957359428,
//    Latitude = -30.1147826428953,
//},
//new Municipality()
//{
//    Id = 140462,
//    Name = "Santa Eufemia",
//    FullName = "Municipality Santa Eufemia",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -63.2841258885037,
//    Latitude = -33.1935446312946,
//},
//new Municipality()
//{
//    Id = 820147,
//    Name = "Santa Fe",
//    FullName = "Municipality Santa Fe",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -60.6387714502483,
//    Latitude = -31.6551557198768,
//},
//new Municipality()
//{
//    Id = 420329,
//    Name = "Santa Isabel",
//    FullName = "Municipality Santa Isabel",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -66.6046679816098,
//    Latitude = -36.4244126017848,
//},
//new Municipality()
//{
//    Id = 822742,
//    Name = "Santa Isabel",
//    FullName = "Comuna Santa Isabel",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -61.7327604188632,
//    Latitude = -33.8999932608857,
//},
//new Municipality()
//{
//    Id = 700098,
//    Name = "Santa Lucía",
//    FullName = "Municipality Santa Lucía",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -68.4634100474193,
//    Latitude = -31.5327197592087,
//},
//new Municipality()
//{
//    Id = 180210,
//    Name = "Santa Lucía",
//    FullName = "Municipality Santa Lucía",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -59.0626195611438,
//    Latitude = -29.0048671965957,
//},
//new Municipality()
//{
//    Id = 908427,
//    Name = "Santa Lucía",
//    FullName = "Comuna Santa Lucía",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -65.5535879465645,
//    Latitude = -27.0276412636331,
//},
//new Municipality()
//{
//    Id = 309225,
//    Name = "Santa Lucía",
//    FullName = "Junta Santa Lucía",
//    Source = "IGN",
//    Category = "Junta",
//    Longitude = -58.6481373218283,
//    Latitude = -30.7877436203993,
//},
//new Municipality()
//{
//    Id = 309735,
//    Name = "Santa Luisa",
//    FullName = "Junta Santa Luisa",
//    Source = "IGN",
//    Category = "Junta",
//    Longitude = -59.7088738016013,
//    Latitude = -31.7537680957868,
//},
//new Municipality()
//{
//    Id = 823337,
//    Name = "Santa Margarita",
//    FullName = "Comuna Santa Margarita",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -61.4561821788296,
//    Latitude = -28.3394066057759,
//},
//new Municipality()
//{
//    Id = 100210,
//    Name = "Santa María",
//    FullName = "Municipality Santa María",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -66.1496005410426,
//    Latitude = -26.4930756131123,
//},
//new Municipality()
//{
//    Id = 540133,
//    Name = "Santa María",
//    FullName = "Municipality Santa María",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -55.425277712281,
//    Latitude = -27.8747754649681,
//},
//new Municipality()
//{
//    Id = 823246,
//    Name = "Santa María Centro",
//    FullName = "Comuna Santa María Centro",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -61.3075023174292,
//    Latitude = -31.5144936539925,
//},
//new Municipality()
//{
//    Id = 140721,
//    Name = "Santa María de Punilla",
//    FullName = "Municipality Santa María de Punilla",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -64.5162902701792,
//    Latitude = -31.2670502905155,
//},
//new Municipality()
//{
//    Id = 823253,
//    Name = "Santa María Norte",
//    FullName = "Comuna Santa María Norte",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -61.1733958940775,
//    Latitude = -31.5131510016903,
//},
//new Municipality()
//{
//    Id = 420336,
//    Name = "Santa Rosa",
//    FullName = "Municipality Santa Rosa",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -64.4089343089223,
//    Latitude = -36.5322365145464,
//},
//new Municipality()
//{
//    Id = 500112,
//    Name = "Santa Rosa",
//    FullName = "Municipality Santa Rosa",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -67.9638561142682,
//    Latitude = -33.6169989146657,
//},
//new Municipality()
//{
//    Id = 740098,
//    Name = "Santa Rosa",
//    FullName = "Municipality Santa Rosa",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -65.2145231019568,
//    Latitude = -32.3515891902023,
//},
//new Municipality()
//{
//    Id = 100217,
//    Name = "Santa Rosa",
//    FullName = "Municipality Santa Rosa",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -65.2410133434195,
//    Latitude = -28.1160106413598,
//},
//new Municipality()
//{
//    Id = 140035,
//    Name = "Santa Rosa de Calamuchita",
//    FullName = "Municipality Santa Rosa de Calamuchita",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -64.5467001962975,
//    Latitude = -32.075302961898,
//},
//new Municipality()
//{
//    Id = 822567,
//    Name = "Santa Rosa de Calchines",
//    FullName = "Comuna Santa Rosa de Calchines",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -60.3232768370311,
//    Latitude = -31.405091105105,
//},
//new Municipality()
//{
//    Id = 908343,
//    Name = "Santa Rosa de Leales y Laguna Blanca",
//    FullName = "Comuna Santa Rosa de Leales y Laguna Blanca",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -65.1993040427973,
//    Latitude = -27.1347105867868,
//},
//new Municipality()
//{
//    Id = 220126,
//    Name = "Santa Sylvina",
//    FullName = "Municipality Santa Sylvina",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -61.1222078941922,
//    Latitude = -27.8539151200485,
//},
//new Municipality()
//{
//    Id = 822518,
//    Name = "Santa Teresa",
//    FullName = "Comuna Santa Teresa",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -60.8200483661573,
//    Latitude = -33.4122172296588,
//},
//new Municipality()
//{
//    Id = 660343,
//    Name = "Santa Victoria Este",
//    FullName = "Municipality Santa Victoria Este",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -62.7948170146615,
//    Latitude = -22.4510004077596,
//},
//new Municipality()
//{
//    Id = 660413,
//    Name = "Santa Victoria Oeste",
//    FullName = "Municipality Santa Victoria Oeste",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -65.0148161873153,
//    Latitude = -22.2513265092521,
//},
//new Municipality()
//{
//    Id = 540168,
//    Name = "Santiago de Liniers",
//    FullName = "Municipality Santiago de Liniers",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -54.3574983184178,
//    Latitude = -26.4059052818483,
//},
//new Municipality()
//{
//    Id = 141078,
//    Name = "Santiago Temple",
//    FullName = "Municipality Santiago Temple",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -63.4185697040229,
//    Latitude = -31.389999537335,
//},
//new Municipality()
//{
//    Id = 823260,
//    Name = "Santo Domingo",
//    FullName = "Comuna Santo Domingo",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -60.8802849962377,
//    Latitude = -31.1119041612955,
//},
//new Municipality()
//{
//    Id = 540469,
//    Name = "Santo Pipó",
//    FullName = "Municipality Santo Pipó",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -55.279570775354,
//    Latitude = -27.2063287787764,
//},
//new Municipality()
//{
//    Id = 585035,
//    Name = "Santo Tomás",
//    FullName = "Comisión Santo Tomás",
//    Source = "IGN",
//    Category = "Comisión",
//    Longitude = -70.0938182756884,
//    Latitude = -39.8409265275249,
//},
//new Municipality()
//{
//    Id = 820154,
//    Name = "Santo Tomé",
//    FullName = "Municipality Santo Tomé",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -60.7890247854132,
//    Latitude = -31.6486515852153,
//},
//new Municipality()
//{
//    Id = 180448,
//    Name = "Santo Tomé",
//    FullName = "Municipality Santo Tomé",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -56.3086133677585,
//    Latitude = -28.3306976310629,
//},
//new Municipality()
//{
//    Id = 823652,
//    Name = "Santurce",
//    FullName = "Comuna Santurce",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -61.1598892205566,
//    Latitude = -30.1612690129714,
//},
//new Municipality()
//{
//    Id = 425140,
//    Name = "Sarah",
//    FullName = "Comisión Sarah",
//    Source = "IGN",
//    Category = "Comisión",
//    Longitude = -63.6872675666461,
//    Latitude = -35.0717291970744,
//},
//new Municipality()
//{
//    Id = 822525,
//    Name = "Sargento Cabral",
//    FullName = "Comuna Sargento Cabral",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -60.6628323941405,
//    Latitude = -33.4566719887247,
//},
//new Municipality()
//{
//    Id = 908434,
//    Name = "Sargento Moya",
//    FullName = "Comuna Sargento Moya",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -65.7991842893128,
//    Latitude = -27.1530096458867,
//},
//new Municipality()
//{
//    Id = 260140,
//    Name = "Sarmiento",
//    FullName = "Municipality Sarmiento",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -69.0158940631978,
//    Latitude = -45.6405207802239,
//},
//new Municipality()
//{
//    Id = 823267,
//    Name = "Sarmiento",
//    FullName = "Comuna Sarmiento",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -61.2013457069007,
//    Latitude = -31.0788740540928,
//},
//new Municipality()
//{
//    Id = 141526,
//    Name = "Sarmiento",
//    FullName = "Municipality Sarmiento",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -64.1199257245959,
//    Latitude = -30.7749694403236,
//},
//new Municipality()
//{
//    Id = 700105,
//    Name = "Sarmiento",
//    FullName = "Municipality Sarmiento",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -68.6872247810764,
//    Latitude = -32.0760779225813,
//},
//new Municipality()
//{
//    Id = 820322,
//    Name = "Sastre y Ortiz",
//    FullName = "Municipality Sastre y Ortiz",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -61.8336440235561,
//    Latitude = -31.7712797112134,
//},
//new Municipality()
//{
//    Id = 141344,
//    Name = "Saturnino María Laspiur",
//    FullName = "Municipality Saturnino María Laspiur",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -62.4833254315984,
//    Latitude = -31.703457733837,
//},
//new Municipality()
//{
//    Id = 180455,
//    Name = "Sauce",
//    FullName = "Municipality Sauce",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -58.7949971294761,
//    Latitude = -29.999503261976,
//},
//new Municipality()
//{
//    Id = 142882,
//    Name = "Sauce Arriba",
//    FullName = "Comuna Sauce Arriba",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -65.1625479518655,
//    Latitude = -31.9111884773377,
//},
//new Municipality()
//{
//    Id = 300154,
//    Name = "Sauce de Luna",
//    FullName = "Municipality Sauce de Luna",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -59.2341438332987,
//    Latitude = -31.2458546276128,
//},
//new Municipality()
//{
//    Id = 303020,
//    Name = "Sauce Montrull",
//    FullName = "Junta Sauce Montrull",
//    Source = "IGN",
//    Category = "Junta",
//    Longitude = -60.3501063456133,
//    Latitude = -31.7567257533363,
//},
//new Municipality()
//{
//    Id = 303027,
//    Name = "Sauce Pinto",
//    FullName = "Junta Sauce Pinto",
//    Source = "IGN",
//    Category = "Junta",
//    Longitude = -60.3599462122175,
//    Latitude = -31.8319071426756,
//},
//new Municipality()
//{
//    Id = 309830,
//    Name = "Sauce Sur",
//    FullName = "Junta Sauce Sur",
//    Source = "IGN",
//    Category = "Junta",
//    Longitude = -59.2357525600161,
//    Latitude = -32.6123815874981,
//},
//new Municipality()
//{
//    Id = 820158,
//    Name = "Sauce Viejo",
//    FullName = "Comuna Sauce Viejo",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -60.7838996542608,
//    Latitude = -31.7939549883865,
//},
//new Municipality()
//{
//    Id = 309497,
//    Name = "Saucecito",
//    FullName = "Junta Saucecito",
//    Source = "IGN",
//    Category = "Junta",
//    Longitude = -59.2503570736476,
//    Latitude = -30.6865801551668,
//},
//new Municipality()
//{
//    Id = 100196,
//    Name = "Saujil",
//    FullName = "Municipality Saujil",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -66.3685254422647,
//    Latitude = -28.0813024525777,
//},
//new Municipality()
//{
//    Id = 585042,
//    Name = "Sauzal Bonito",
//    FullName = "Comisión Sauzal Bonito",
//    Source = "IGN",
//    Category = "Comisión",
//    Longitude = -69.0134118188096,
//    Latitude = -38.5629265459378,
//},
//new Municipality()
//{
//    Id = 140959,
//    Name = "Sebastián Elcano",
//    FullName = "Municipality Sebastián Elcano",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -63.5927415022822,
//    Latitude = -30.1594216007113,
//},
//new Municipality()
//{
//    Id = 660287,
//    Name = "Seclantás",
//    FullName = "Municipality Seclantás",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -66.34978671033,
//    Latitude = -25.2647010898053,
//},
//new Municipality()
//{
//    Id = 141351,
//    Name = "Seeber",
//    FullName = "Municipality Seeber",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -62.0196850759194,
//    Latitude = -30.9253280210718,
//},
//new Municipality()
//{
//    Id = 300350,
//    Name = "Seguí",
//    FullName = "Municipality Seguí",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -60.1312550359504,
//    Latitude = -31.9483290799263,
//},
//new Municipality()
//{
//    Id = 142070,
//    Name = "Segunda Usina",
//    FullName = "Comuna Segunda Usina",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -64.3726926526339,
//    Latitude = -32.175259843518,
//},
//new Municipality()
//{
//    Id = 580077,
//    Name = "Senillosa",
//    FullName = "Municipality Senillosa",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -68.6774624245043,
//    Latitude = -38.9116607400204,
//},
//new Municipality()
//{
//    Id = 822938,
//    Name = "Serodino",
//    FullName = "Comuna Serodino",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -60.9650705458428,
//    Latitude = -32.6127878713444,
//},
//new Municipality()
//{
//    Id = 140651,
//    Name = "Serrano",
//    FullName = "Municipality Serrano",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -63.5333659644618,
//    Latitude = -34.4755850792197,
//},
//new Municipality()
//{
//    Id = 140196,
//    Name = "Serrezuela",
//    FullName = "Municipality Serrezuela",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -65.3514532144564,
//    Latitude = -30.5673524944777,
//},
//new Municipality()
//{
//    Id = 620196,
//    Name = "Sierra Colorada",
//    FullName = "Municipality Sierra Colorada",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -67.7018601105221,
//    Latitude = -40.5960017141018,
//},
//new Municipality()
//{
//    Id = 620238,
//    Name = "Sierra Grande",
//    FullName = "Municipality Sierra Grande",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -65.3928205210857,
//    Latitude = -41.6203446693528,
//},
//new Municipality()
//{
//    Id = 345070,
//    Name = "Siete Palmas",
//    FullName = "Comisión Siete Palmas",
//    Source = "IGN",
//    Category = "Comisión",
//    Longitude = -58.3290230085759,
//    Latitude = -25.2016238617924,
//},
//new Municipality()
//{
//    Id = 823960,
//    Name = "Silva",
//    FullName = "Comuna Silva",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -60.4736436610298,
//    Latitude = -30.4504542236647,
//},
//new Municipality()
//{
//    Id = 140336,
//    Name = "Silvio Pellico",
//    FullName = "Municipality Silvio Pellico",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -62.9325509169843,
//    Latitude = -32.2511789287088,
//},
//new Municipality()
//{
//    Id = 143197,
//    Name = "Simbolar",
//    FullName = "Comuna Simbolar",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -63.9848922540196,
//    Latitude = -30.4759380124873,
//},
//new Municipality()
//{
//    Id = 900098,
//    Name = "Simoca",
//    FullName = "Municipality Simoca",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -65.3619549438074,
//    Latitude = -27.2583551857274,
//},
//new Municipality()
//{
//    Id = 141533,
//    Name = "Sinsacate",
//    FullName = "Municipality Sinsacate",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -64.0806973417363,
//    Latitude = -30.942271363662,
//},
//new Municipality()
//{
//    Id = 309500,
//    Name = "Sir Leonard",
//    FullName = "Junta Sir Leonard",
//    Source = "IGN",
//    Category = "Junta",
//    Longitude = -59.5055013126896,
//    Latitude = -31.4026169200004,
//},
//new Municipality()
//{
//    Id = 908441,
//    Name = "Soldado Maldonado",
//    FullName = "Comuna Soldado Maldonado",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -65.6660164509927,
//    Latitude = -27.0713461899311,
//},
//new Municipality()
//{
//    Id = 823442,
//    Name = "Soldini",
//    FullName = "Comuna Soldini",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -60.7846806052724,
//    Latitude = -33.0446925470285,
//},
//new Municipality()
//{
//    Id = 823659,
//    Name = "Soledad",
//    FullName = "Comuna Soledad",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -60.8488658482609,
//    Latitude = -30.6545005432418,
//},
//new Municipality()
//{
//    Id = 823274,
//    Name = "Soutomayor",
//    FullName = "Comuna Soutomayor",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -61.175785357018,
//    Latitude = -30.9363666742081,
//},
//new Municipality()
//{
//    Id = 425147,
//    Name = "Speluzzi",
//    FullName = "Comisión Speluzzi",
//    Source = "IGN",
//    Category = "Comisión",
//    Longitude = -63.8703933569322,
//    Latitude = -35.5333472823629,
//},
//new Municipality()
//{
//    Id = 820235,
//    Name = "Suardi",
//    FullName = "Municipality Suardi",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -61.8619817413271,
//    Latitude = -30.5246644553626,
//},
//new Municipality()
//{
//    Id = 345049,
//    Name = "Subteniente Perín",
//    FullName = "Comisión Subteniente Perín",
//    Source = "IGN",
//    Category = "Comisión",
//    Longitude = -60.0174675213043,
//    Latitude = -25.5318689368593,
//},
//new Municipality()
//{
//    Id = 142588,
//    Name = "Suco",
//    FullName = "Comuna Suco",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -64.8290466867185,
//    Latitude = -33.4414356242941,
//},
//new Municipality()
//{
//    Id = 60784,
//    Name = "Suipacha",
//    FullName = "Municipality Suipacha",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -59.7033860485774,
//    Latitude = -34.7485741352292,
//},
//new Municipality()
//{
//    Id = 820049,
//    Name = "Sunchales",
//    FullName = "Municipality Sunchales",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -61.5830166844307,
//    Latitude = -30.9512953414673,
//},
//new Municipality()
//{
//    Id = 822364,
//    Name = "Susana",
//    FullName = "Comuna Susana",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -61.5304778599988,
//    Latitude = -31.3721186116187,
//},
//new Municipality()
//{
//    Id = 386168,
//    Name = "Susques",
//    FullName = "Comisión Susques",
//    Source = "IGN",
//    Category = "Comisión",
//    Longitude = -66.5590483444139,
//    Latitude = -23.7059179873005,
//},
//new Municipality()
//{
//    Id = 180049,
//    Name = "Tabay",
//    FullName = "Municipality Tabay",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -58.2873879595525,
//    Latitude = -28.2855003434524,
//},
//new Municipality()
//{
//    Id = 300357,
//    Name = "Tabossi",
//    FullName = "Municipality Tabossi",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -59.9073988335456,
//    Latitude = -31.8039962354584,
//},
//new Municipality()
//{
//    Id = 220028,
//    Name = "Taco Pozo",
//    FullName = "Municipality Taco Pozo",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -62.5829394876599,
//    Latitude = -25.3289897838972,
//},
//new Municipality()
//{
//    Id = 908210,
//    Name = "Taco Ralo",
//    FullName = "Comuna Taco Ralo",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -65.1995055884365,
//    Latitude = -27.8166828263346,
//},
//new Municipality()
//{
//    Id = 822861,
//    Name = "Tacuarendi",
//    FullName = "Comuna Tacuarendi",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -59.2907991786097,
//    Latitude = -28.4231273428115,
//},
//new Municipality()
//{
//    Id = 822371,
//    Name = "Tacural",
//    FullName = "Comuna Tacural",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -61.6144506254401,
//    Latitude = -30.8033974735319,
//},
//new Municipality()
//{
//    Id = 822378,
//    Name = "Tacurales",
//    FullName = "Comuna Tacurales",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -61.7563292917984,
//    Latitude = -30.8160782752087,
//},
//new Municipality()
//{
//    Id = 900105,
//    Name = "Tafí del Valle",
//    FullName = "Municipality Tafí del Valle",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -65.7691630982428,
//    Latitude = -26.8032857263554,
//},
//new Municipality()
//{
//    Id = 900119,
//    Name = "Tafí Viejo",
//    FullName = "Municipality Tafí Viejo",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -65.2771387160372,
//    Latitude = -26.7417096919622,
//},
//new Municipality()
//{
//    Id = 142434,
//    Name = "Tala Cañada",
//    FullName = "Comuna Tala Cañada",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -64.9982605967787,
//    Latitude = -31.3589576276437,
//},
//new Municipality()
//{
//    Id = 142525,
//    Name = "Tala Huasi",
//    FullName = "Comuna Tala Huasi",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -64.57278414827,
//    Latitude = -31.4670111937151,
//},
//new Municipality()
//{
//    Id = 142392,
//    Name = "Talaini",
//    FullName = "Comuna Talaini",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -65.1738445718196,
//    Latitude = -31.2400441687017,
//},
//new Municipality()
//{
//    Id = 746224,
//    Name = "Talita",
//    FullName = "Comisión Talita",
//    Source = "IGN",
//    Category = "Comisión",
//    Longitude = -65.5745389834303,
//    Latitude = -32.2253766754651,
//},
//new Municipality()
//{
//    Id = 141498,
//    Name = "Tancacha",
//    FullName = "Municipality Tancacha",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -63.9792575326275,
//    Latitude = -32.2395132273512,
//},
//new Municipality()
//{
//    Id = 60791,
//    Name = "Tandil",
//    FullName = "Municipality Tandil",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -59.1819827896264,
//    Latitude = -37.3364293166475,
//},
//new Municipality()
//{
//    Id = 140728,
//    Name = "Tanti",
//    FullName = "Municipality Tanti",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -64.5694692159225,
//    Latitude = -31.3619877806075,
//},
//new Municipality()
//{
//    Id = 60798,
//    Name = "Tapalqué",
//    FullName = "Municipality Tapalqué",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -60.1310650281832,
//    Latitude = -36.3471436403097,
//},
//new Municipality()
//{
//    Id = 180301,
//    Name = "Tapebicuá",
//    FullName = "Municipality Tapebicuá",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -56.9944948960458,
//    Latitude = -29.3825745409466,
//},
//new Municipality()
//{
//    Id = 908637,
//    Name = "Tapia",
//    FullName = "Comuna Tapia",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -65.3481716083954,
//    Latitude = -26.5511038075207,
//},
//new Municipality()
//{
//    Id = 100154,
//    Name = "Tapso",
//    FullName = "Municipality Tapso",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -65.2000386194552,
//    Latitude = -28.4479997040389,
//},
//new Municipality()
//{
//    Id = 580189,
//    Name = "Taquimilán",
//    FullName = "Municipality Taquimilán",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -70.3458343954121,
//    Latitude = -37.5910001035078,
//},
//new Municipality()
//{
//    Id = 824198,
//    Name = "Tartagal",
//    FullName = "Comuna Tartagal",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -59.8640442542436,
//    Latitude = -28.6814695752956,
//},
//new Municipality()
//{
//    Id = 660161,
//    Name = "Tartagal",
//    FullName = "Municipality Tartagal",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -63.4519568723809,
//    Latitude = -22.5201118880573,
//},
//new Municipality()
//{
//    Id = 180056,
//    Name = "Tatacuá",
//    FullName = "Municipality Tatacuá",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -58.3050818032848,
//    Latitude = -28.3787081771491,
//},
//new Municipality()
//{
//    Id = 260105,
//    Name = "Tecka",
//    FullName = "Municipality Tecka",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -70.8303282871378,
//    Latitude = -43.5131646424365,
//},
//new Municipality()
//{
//    Id = 420350,
//    Name = "Telén",
//    FullName = "Municipality Telén",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -65.7900333947794,
//    Latitude = -36.5134528460904,
//},
//new Municipality()
//{
//    Id = 268133,
//    Name = "Telsen",
//    FullName = "Comuna Telsen",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -66.9530756416637,
//    Latitude = -42.4225080787712,
//},
//new Municipality()
//{
//    Id = 908448,
//    Name = "Teniente Berdina",
//    FullName = "Comuna Teniente Berdina",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -65.5164860030071,
//    Latitude = -27.0211940763511,
//},
//new Municipality()
//{
//    Id = 822749,
//    Name = "Teodelina",
//    FullName = "Comuna Teodelina",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -61.6059846703472,
//    Latitude = -34.193523782402,
//},
//new Municipality()
//{
//    Id = 303034,
//    Name = "Tezanos Pinto",
//    FullName = "Junta Tezanos Pinto",
//    Source = "IGN",
//    Category = "Junta",
//    Longitude = -60.4901596774441,
//    Latitude = -31.8598345688788,
//},
//new Municipality()
//{
//    Id = 822532,
//    Name = "Theobald",
//    FullName = "Comuna Theobald",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -60.3483567982878,
//    Latitude = -33.3294559925573,
//},
//new Municipality()
//{
//    Id = 140343,
//    Name = "Ticino",
//    FullName = "Municipality Ticino",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -63.4350474292111,
//    Latitude = -32.6948787489748,
//},
//new Municipality()
//{
//    Id = 60805,
//    Name = "Tigre",
//    FullName = "Municipality Tigre",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -58.588173872575,
//    Latitude = -34.382019908002,
//},
//new Municipality()
//{
//    Id = 380329,
//    Name = "Tilcara",
//    FullName = "Municipality Tilcara",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -65.2744933940424,
//    Latitude = -23.6180442952126,
//},
//new Municipality()
//{
//    Id = 740063,
//    Name = "Tilisarao",
//    FullName = "Municipality Tilisarao",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -65.2768445006967,
//    Latitude = -32.7369590822116,
//},
//new Municipality()
//{
//    Id = 824030,
//    Name = "Timbúes",
//    FullName = "Comuna Timbúes",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -60.8022116396642,
//    Latitude = -32.5742948649227,
//},
//new Municipality()
//{
//    Id = 142728,
//    Name = "Tinoco",
//    FullName = "Comuna Tinoco",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -63.9052535777096,
//    Latitude = -31.10453159992,
//},
//new Municipality()
//{
//    Id = 100231,
//    Name = "Tinogasta",
//    FullName = "Municipality Tinogasta",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -67.5386029396789,
//    Latitude = -28.0811834735847,
//},
//new Municipality()
//{
//    Id = 140350,
//    Name = "Tío Pujio",
//    FullName = "Municipality Tío Pujio",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -63.35177573013,
//    Latitude = -32.2799480172569,
//},
//new Municipality()
//{
//    Id = 420357,
//    Name = "Toay",
//    FullName = "Municipality Toay",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -64.7196040508733,
//    Latitude = -36.6824756333498,
//},
//new Municipality()
//{
//    Id = 824205,
//    Name = "Toba",
//    FullName = "Comuna Toba",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -60.1706890559263,
//    Latitude = -29.228224031944,
//},
//new Municipality()
//{
//    Id = 660252,
//    Name = "Tolar Grande",
//    FullName = "Municipality Tolar Grande",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -67.7458006418463,
//    Latitude = -24.6952661330217,
//},
//new Municipality()
//{
//    Id = 141407,
//    Name = "Toledo",
//    FullName = "Municipality Toledo",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -64.0108138150317,
//    Latitude = -31.5526503925746,
//},
//new Municipality()
//{
//    Id = 940021,
//    Name = "Tolhuin",
//    FullName = "Municipality Tolhuin",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -67.1957989971612,
//    Latitude = -54.5767288121226,
//},
//new Municipality()
//{
//    Id = 420364,
//    Name = "Tomás M. Anchorena",
//    FullName = "Municipality Tomás M. Anchorena",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -63.4977774255982,
//    Latitude = -36.8296822294223,
//},
//new Municipality()
//{
//    Id = 60812,
//    Name = "Tordillo",
//    FullName = "Municipality Tordillo",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -57.2738116449804,
//    Latitude = -36.3905151218837,
//},
//new Municipality()
//{
//    Id = 60819,
//    Name = "Tornquist",
//    FullName = "Municipality Tornquist",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -62.2905659977265,
//    Latitude = -38.2576421634877,
//},
//new Municipality()
//{
//    Id = 142973,
//    Name = "Toro Pujio",
//    FullName = "Comuna Toro Pujio",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -62.9975127683943,
//    Latitude = -31.1056273512034,
//},
//new Municipality()
//{
//    Id = 822021,
//    Name = "Tortugas",
//    FullName = "Comuna Tortugas",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -61.7396027179291,
//    Latitude = -32.8226035733663,
//},
//new Municipality()
//{
//    Id = 142399,
//    Name = "Tosno",
//    FullName = "Comuna Tosno",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -65.2828381577687,
//    Latitude = -30.9455846794062,
//},
//new Municipality()
//{
//    Id = 140889,
//    Name = "Tosquita",
//    FullName = "Municipality Tosquita",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -64.4611155218709,
//    Latitude = -33.8214399062638,
//},
//new Municipality()
//{
//    Id = 820175,
//    Name = "Tostado",
//    FullName = "Municipality Tostado",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -61.4447053907698,
//    Latitude = -29.2390268010686,
//},
//new Municipality()
//{
//    Id = 820133,
//    Name = "Totoras",
//    FullName = "Municipality Totoras",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -61.220619529934,
//    Latitude = -32.5834468055119,
//},
//new Municipality()
//{
//    Id = 824135,
//    Name = "Traill",
//    FullName = "Comuna Traill",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -61.6890101267832,
//    Latitude = -31.9307594351273,
//},
//new Municipality()
//{
//    Id = 900126,
//    Name = "Trancas",
//    FullName = "Municipality Trancas",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -65.2502636969216,
//    Latitude = -26.2732587229168,
//},
//new Municipality()
//{
//    Id = 141358,
//    Name = "Tránsito",
//    FullName = "Municipality Tránsito",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -63.194737738705,
//    Latitude = -31.4313249034113,
//},
//new Municipality()
//{
//    Id = 260119,
//    Name = "Trelew",
//    FullName = "Municipality Trelew",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -65.3181167767533,
//    Latitude = -43.248944421861,
//},
//new Municipality()
//{
//    Id = 420371,
//    Name = "Trenel",
//    FullName = "Municipality Trenel",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -64.1226949157601,
//    Latitude = -35.6413010468387,
//},
//new Municipality()
//{
//    Id = 60826,
//    Name = "Trenque Lauquen",
//    FullName = "Municipality Trenque Lauquen",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -62.635079783239,
//    Latitude = -36.0567662720747,
//},
//new Municipality()
//{
//    Id = 60833,
//    Name = "Tres Arroyos",
//    FullName = "Municipality Tres Arroyos",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -60.2374173247083,
//    Latitude = -38.5118142752577,
//},
//new Municipality()
//{
//    Id = 540028,
//    Name = "Tres Capones",
//    FullName = "Municipality Tres Capones",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -55.6141377080559,
//    Latitude = -27.9918146633245,
//},
//new Municipality()
//{
//    Id = 386063,
//    Name = "Tres Cruces",
//    FullName = "Comisión Tres Cruces",
//    Source = "IGN",
//    Category = "Comisión",
//    Longitude = -65.5441394136325,
//    Latitude = -22.9301234763836,
//},
//new Municipality()
//{
//    Id = 180010,
//    Name = "Tres de Abril",
//    FullName = "Municipality Tres de Abril",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -58.9263314652298,
//    Latitude = -28.3607941964066,
//},
//new Municipality()
//{
//    Id = 60840,
//    Name = "Tres de Febrero",
//    FullName = "Municipality Tres de Febrero",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -58.5791687873004,
//    Latitude = -34.5960620390683,
//},
//new Municipality()
//{
//    Id = 220301,
//    Name = "Tres Isletas",
//    FullName = "Municipality Tres Isletas",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -60.4546439783309,
//    Latitude = -26.3190099893669,
//},
//new Municipality()
//{
//    Id = 345063,
//    Name = "Tres Lagunas",
//    FullName = "Comisión Tres Lagunas",
//    Source = "IGN",
//    Category = "Comisión",
//    Longitude = -58.5114565747576,
//    Latitude = -25.2141176287373,
//},
//new Municipality()
//{
//    Id = 60847,
//    Name = "Tres Lomas",
//    FullName = "Municipality Tres Lomas",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -62.8639077725213,
//    Latitude = -36.4971002162064,
//},
//new Municipality()
//{
//    Id = 260084,
//    Name = "Trevelin",
//    FullName = "Municipality Trevelin",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -71.4504295400345,
//    Latitude = -43.1975385432271,
//},
//new Municipality()
//{
//    Id = 580105,
//    Name = "Tricao Malal",
//    FullName = "Municipality Tricao Malal",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -70.3654033463117,
//    Latitude = -37.0444304664012,
//},
//new Municipality()
//{
//    Id = 142217,
//    Name = "Tuclame",
//    FullName = "Comuna Tuclame",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -65.2357340089556,
//    Latitude = -30.7468404971543,
//},
//new Municipality()
//{
//    Id = 386196,
//    Name = "Tumbaya",
//    FullName = "Comisión Tumbaya",
//    Source = "IGN",
//    Category = "Comisión",
//    Longitude = -65.4801421786977,
//    Latitude = -23.8210675531291,
//},
//new Municipality()
//{
//    Id = 500119,
//    Name = "Tunuyán",
//    FullName = "Municipality Tunuyán",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -69.5092971441841,
//    Latitude = -33.622885151722,
//},
//new Municipality()
//{
//    Id = 500126,
//    Name = "Tupungato",
//    FullName = "Municipality Tupungato",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -69.2962859030556,
//    Latitude = -33.2934009869539,
//},
//new Municipality()
//{
//    Id = 300021,
//    Name = "Ubajay",
//    FullName = "Municipality Ubajay",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -58.2672866110297,
//    Latitude = -31.7717741612799,
//},
//new Municipality()
//{
//    Id = 140469,
//    Name = "Ucacha",
//    FullName = "Municipality Ucacha",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -63.507135543766,
//    Latitude = -33.0317994602079,
//},
//new Municipality()
//{
//    Id = 700112,
//    Name = "Ullum",
//    FullName = "Municipality Ullum",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -68.8823909182994,
//    Latitude = -31.0852853750751,
//},
//new Municipality()
//{
//    Id = 425154,
//    Name = "Unanué",
//    FullName = "Comisión Unanué",
//    Source = "IGN",
//    Category = "Comisión",
//    Longitude = -64.3643426957512,
//    Latitude = -37.6124085825303,
//},
//new Municipality()
//{
//    Id = 740091,
//    Name = "Unión",
//    FullName = "Municipality Unión",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -65.9454868164707,
//    Latitude = -35.1539097288901,
//},
//new Municipality()
//{
//    Id = 140168,
//    Name = "Unquillo",
//    FullName = "Municipality Unquillo",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -64.3345156620741,
//    Latitude = -31.2192351356384,
//},
//new Municipality()
//{
//    Id = 386067,
//    Name = "Uquia",
//    FullName = "Comision Uquia",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -65.3939882431242,
//    Latitude = -23.3182371354244,
//},
//new Municipality()
//{
//    Id = 823449,
//    Name = "Uranga",
//    FullName = "Comuna Uranga",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -60.7175504486684,
//    Latitude = -33.2732069574327,
//},
//new Municipality()
//{
//    Id = 300203,
//    Name = "Urdinarrain",
//    FullName = "Municipality Urdinarrain",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -58.883229143931,
//    Latitude = -32.6875263735847,
//},
//new Municipality()
//{
//    Id = 420378,
//    Name = "Uriburu",
//    FullName = "Municipality Uriburu",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -63.8303238811755,
//    Latitude = -36.5083737163003,
//},
//new Municipality()
//{
//    Id = 660322,
//    Name = "Urundel",
//    FullName = "Municipality Urundel",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -64.5780599129714,
//    Latitude = -23.4580441804595,
//},
//new Municipality()
//{
//    Id = 940014,
//    Name = "Ushuaia",
//    FullName = "Municipality Ushuaia",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -68.3532508598109,
//    Latitude = -54.8039562488595,
//},
//new Municipality()
//{
//    Id = 620245,
//    Name = "Valcheta",
//    FullName = "Municipality Valcheta",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -66.1634385204858,
//    Latitude = -40.6732643456764,
//},
//new Municipality()
//{
//    Id = 143071,
//    Name = "Valle de Anisacate",
//    FullName = "Comuna Valle de Anisacate",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -64.4192206419266,
//    Latitude = -31.7350762329001,
//},
//new Municipality()
//{
//    Id = 700119,
//    Name = "Valle Fértil",
//    FullName = "Municipality Valle Fértil",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -67.5276736877017,
//    Latitude = -30.7168856695105,
//},
//new Municipality()
//{
//    Id = 386238,
//    Name = "Valle Grande",
//    FullName = "Comisión Valle Grande",
//    Source = "IGN",
//    Category = "Comisión",
//    Longitude = -64.9411018364812,
//    Latitude = -23.4898336958266,
//},
//new Municipality()
//{
//    Id = 140735,
//    Name = "Valle Hermoso",
//    FullName = "Municipality Valle Hermoso",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -64.4920990495934,
//    Latitude = -31.1323725662877,
//},
//new Municipality()
//{
//    Id = 100238,
//    Name = "Valle Viejo",
//    FullName = "Municipality Valle Viejo",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -65.7079324164837,
//    Latitude = -28.6000684837485,
//},
//new Municipality()
//{
//    Id = 660196,
//    Name = "Vaqueros",
//    FullName = "Municipality Vaqueros",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -65.5497282976315,
//    Latitude = -24.5713387519093,
//},
//new Municipality()
//{
//    Id = 585091,
//    Name = "Varvarco - Invernada Vieja",
//    FullName = "Comisión Varvarco - Invernada Vieja",
//    Source = "IGN",
//    Category = "Comisión",
//    Longitude = -70.5962736544366,
//    Latitude = -36.7933760258586,
//},
//new Municipality()
//{
//    Id = 820077,
//    Name = "Venado Tuerto",
//    FullName = "Municipality Venado Tuerto",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -61.9744594399441,
//    Latitude = -33.7518202806305,
//},
//new Municipality()
//{
//    Id = 820336,
//    Name = "Vera",
//    FullName = "Municipality Vera",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -60.3749387660542,
//    Latitude = -29.4127008749248,
//},
//new Municipality()
//{
//    Id = 823967,
//    Name = "Vera y Pintado",
//    FullName = "Comuna Vera y Pintado",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -60.3434992621709,
//    Latitude = -30.1288305510759,
//},
//new Municipality()
//{
//    Id = 420392,
//    Name = "Vértiz",
//    FullName = "Municipality Vértiz",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -63.903575910836,
//    Latitude = -35.4203277421508,
//},
//new Municipality()
//{
//    Id = 300364,
//    Name = "Viale",
//    FullName = "Municipality Viale",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -59.9683515856316,
//    Latitude = -31.8624579952246,
//},
//new Municipality()
//{
//    Id = 141736,
//    Name = "Viamonte",
//    FullName = "Municipality Viamonte",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -63.0994810512003,
//    Latitude = -33.7473048096682,
//},
//new Municipality()
//{
//    Id = 60861,
//    Name = "Vicente López",
//    FullName = "Municipality Vicente López",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -58.5044096281714,
//    Latitude = -34.5265545192105,
//},
//new Municipality()
//{
//    Id = 300469,
//    Name = "Victoria",
//    FullName = "Municipality Victoria",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -60.2693361389851,
//    Latitude = -32.8962118124264,
//},
//new Municipality()
//{
//    Id = 420399,
//    Name = "Victorica",
//    FullName = "Municipality Victorica",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -65.8427740126532,
//    Latitude = -36.0950447958336,
//},
//new Municipality()
//{
//    Id = 140896,
//    Name = "Vicuña Mackenna",
//    FullName = "Municipality Vicuña Mackenna",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -64.4072934720761,
//    Latitude = -33.9288149320525,
//},
//new Municipality()
//{
//    Id = 823974,
//    Name = "Videla",
//    FullName = "Comuna Videla",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -60.7055499014793,
//    Latitude = -30.9734119058337,
//},
//new Municipality()
//{
//    Id = 620014,
//    Name = "Viedma",
//    FullName = "Municipality Viedma",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -63.3267607269368,
//    Latitude = -41.0292614690091,
//},
//new Municipality()
//{
//    Id = 822385,
//    Name = "Vila",
//    FullName = "Comuna Vila",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -61.8328200400665,
//    Latitude = -31.190388017158,
//},
//new Municipality()
//{
//    Id = 140175,
//    Name = "Villa Allende",
//    FullName = "Municipality Villa Allende",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -64.3361456913797,
//    Latitude = -31.2723301734049,
//},
//new Municipality()
//{
//    Id = 142077,
//    Name = "Villa Amancay",
//    FullName = "Comuna Villa Amancay",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -64.580560197772,
//    Latitude = -32.2182599982267,
//},
//new Municipality()
//{
//    Id = 823456,
//    Name = "Villa Amelia",
//    FullName = "Comuna Villa Amelia",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -60.6704349346796,
//    Latitude = -33.1570171302267,
//},
//new Municipality()
//{
//    Id = 822868,
//    Name = "Villa Ana",
//    FullName = "Comuna Villa Ana",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -59.6366616081569,
//    Latitude = -28.4145736812958,
//},
//new Municipality()
//{
//    Id = 220322,
//    Name = "Villa Ángela",
//    FullName = "Municipality Villa Ángela",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -60.7562871349144,
//    Latitude = -27.676039458744,
//},
//new Municipality()
//{
//    Id = 300266,
//    Name = "Villa Aranguren",
//    FullName = "Municipality Villa Aranguren",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -60.1187867607635,
//    Latitude = -32.2064657232078,
//},
//new Municipality()
//{
//    Id = 141505,
//    Name = "Villa Ascasubi",
//    FullName = "Municipality Villa Ascasubi",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -63.8898773171194,
//    Latitude = -32.1694820041982,
//},
//new Municipality()
//{
//    Id = 908224,
//    Name = "Villa Belgrano",
//    FullName = "Comuna Villa Belgrano",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -65.5963032513067,
//    Latitude = -27.5394886860488,
//},
//new Municipality()
//{
//    Id = 220427,
//    Name = "Villa Berthet",
//    FullName = "Municipality Villa Berthet",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -60.3707650051061,
//    Latitude = -27.2641925148028,
//},
//new Municipality()
//{
//    Id = 142798,
//    Name = "Villa Candelaria Norte",
//    FullName = "Comuna Villa Candelaria Norte",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -63.3428315124572,
//    Latitude = -29.8240610680011,
//},
//new Municipality()
//{
//    Id = 820084,
//    Name = "Villa Cañás",
//    FullName = "Municipality Villa Cañás",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -61.6054429048331,
//    Latitude = -34.0190906471635,
//},
//new Municipality()
//{
//    Id = 140742,
//    Name = "Villa Carlos Paz",
//    FullName = "Municipality Villa Carlos Paz",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -64.5088844540428,
//    Latitude = -31.4206918540754,
//},
//new Municipality()
//{
//    Id = 142126,
//    Name = "Villa Cerro Azul",
//    FullName = "Comuna Villa Cerro Azul",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -64.3300094289341,
//    Latitude = -31.0717050283997,
//},
//new Municipality()
//{
//    Id = 908553,
//    Name = "Villa Chicligasta",
//    FullName = "Comuna Villa Chicligasta",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -65.1703099604411,
//    Latitude = -27.4113772991287,
//},
//new Municipality()
//{
//    Id = 143078,
//    Name = "Villa Ciudad de América",
//    FullName = "Comuna Villa Ciudad de América",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -64.5155267786964,
//    Latitude = -31.7670921868236,
//},
//new Municipality()
//{
//    Id = 142084,
//    Name = "Villa Ciudad Parque Los Reartes",
//    FullName = "Comuna Villa Ciudad Parque Los Reartes",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -64.5215690562305,
//    Latitude = -31.8897835664196,
//},
//new Municipality()
//{
//    Id = 300476,
//    Name = "Villa Clara",
//    FullName = "Municipality Villa Clara",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -58.8269128011972,
//    Latitude = -31.8072635748132,
//},
//new Municipality()
//{
//    Id = 141365,
//    Name = "Villa Concepción del Tío",
//    FullName = "Municipality Villa Concepción del Tío",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -62.812206116271,
//    Latitude = -31.3297975420494,
//},
//new Municipality()
//{
//    Id = 820056,
//    Name = "Villa Constitución",
//    FullName = "Municipality Villa Constitución",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -60.3181194542301,
//    Latitude = -33.2427899318912,
//},
//new Municipality()
//{
//    Id = 141113,
//    Name = "Villa Cura Brochero",
//    FullName = "Municipality Villa Cura Brochero",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -65.0155388613377,
//    Latitude = -31.709906354572,
//},
//new Municipality()
//{
//    Id = 585056,
//    Name = "Villa Curi Leuvú",
//    FullName = "Comisión Villa Curi Leuvú",
//    Source = "IGN",
//    Category = "Comisión",
//    Longitude = -70.4296686921956,
//    Latitude = -37.1709436645892,
//},
//new Municipality()
//{
//    Id = 746028,
//    Name = "Villa de la Quebrada",
//    FullName = "Comisión Villa de la Quebrada",
//    Source = "IGN",
//    Category = "Comisión",
//    Longitude = -66.291666796126,
//    Latitude = -33.0210961731302,
//},
//new Municipality()
//{
//    Id = 141148,
//    Name = "Villa de las Rosas",
//    FullName = "Municipality Villa de las Rosas",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -65.0365731183009,
//    Latitude = -31.9394491625255,
//},
//new Municipality()
//{
//    Id = 908350,
//    Name = "Villa de Leales",
//    FullName = "Comuna Villa de Leales",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -65.2308899100058,
//    Latitude = -27.2210020625174,
//},
//new Municipality()
//{
//    Id = 140966,
//    Name = "Villa de María",
//    FullName = "Municipality Villa de María",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -63.7251634049096,
//    Latitude = -29.8941782214697,
//},
//new Municipality()
//{
//    Id = 740105,
//    Name = "Villa de Merlo",
//    FullName = "Municipality Villa de Merlo",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -65.0077611257424,
//    Latitude = -32.3526869049109,
//},
//new Municipality()
//{
//    Id = 142441,
//    Name = "Villa de Pocho",
//    FullName = "Comuna Villa de Pocho",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -65.2841808159514,
//    Latitude = -31.4730827915556,
//},
//new Municipality()
//{
//    Id = 746322,
//    Name = "Villa de Praga",
//    FullName = "Comisión Villa de Praga",
//    Source = "IGN",
//    Category = "Comisión",
//    Longitude = -65.6438203657218,
//    Latitude = -32.5330352260902,
//},
//new Municipality()
//{
//    Id = 140203,
//    Name = "Villa de Soto",
//    FullName = "Municipality Villa de Soto",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -65.0073977623671,
//    Latitude = -30.8690814087168,
//},
//new Municipality()
//{
//    Id = 746098,
//    Name = "Villa del Carmen",
//    FullName = "Comisión Villa del Carmen",
//    Source = "IGN",
//    Category = "Comisión",
//    Longitude = -65.047059249476,
//    Latitude = -32.9175856151061,
//},
//new Municipality()
//{
//    Id = 140042,
//    Name = "Villa del Dique",
//    FullName = "Municipality Villa del Dique",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -64.433126958511,
//    Latitude = -32.1348568466503,
//},
//new Municipality()
//{
//    Id = 585098,
//    Name = "Villa del Nahueve",
//    FullName = "Comisión Villa del Nahueve",
//    Source = "IGN",
//    Category = "Comisión",
//    Longitude = -70.9189491616615,
//    Latitude = -37.0165690501283,
//},
//new Municipality()
//{
//    Id = 143085,
//    Name = "Villa del Prado",
//    FullName = "Comuna Villa del Prado",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -64.3917917466749,
//    Latitude = -31.6204677227677,
//},
//new Municipality()
//{
//    Id = 141085,
//    Name = "Villa del Rosario",
//    FullName = "Municipality Villa del Rosario",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -63.5340745893101,
//    Latitude = -31.5570088932439,
//},
//new Municipality()
//{
//    Id = 300133,
//    Name = "Villa del Rosario",
//    FullName = "Municipality Villa del Rosario",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -57.8762380396922,
//    Latitude = -30.793499010998,
//},
//new Municipality()
//{
//    Id = 141540,
//    Name = "Villa del Totoral",
//    FullName = "Municipality Villa del Totoral",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -64.0569454757472,
//    Latitude = -30.7095120032809,
//},
//new Municipality()
//{
//    Id = 141155,
//    Name = "Villa Dolores",
//    FullName = "Municipality Villa Dolores",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -65.2015130754264,
//    Latitude = -31.9771247818176,
//},
//new Municipality()
//{
//    Id = 300483,
//    Name = "Villa Domínguez",
//    FullName = "Municipality Villa Domínguez",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -58.9318783692867,
//    Latitude = -31.9700096614069,
//},
//new Municipality()
//{
//    Id = 340252,
//    Name = "Villa Dos Trece",
//    FullName = "Municipality Villa Dos Trece",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -59.3642106776359,
//    Latitude = -26.184603792573,
//},
//new Municipality()
//{
//    Id = 142595,
//    Name = "Villa El Chacay",
//    FullName = "Comuna Villa El Chacay",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -64.8658820184979,
//    Latitude = -32.894408635154,
//},
//new Municipality()
//{
//    Id = 580084,
//    Name = "Villa El Chocón",
//    FullName = "Municipality Villa El Chocón",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -68.8408718852903,
//    Latitude = -39.2563688848301,
//},
//new Municipality()
//{
//    Id = 142350,
//    Name = "Villa Elisa",
//    FullName = "Comuna Villa Elisa",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -62.2950011450932,
//    Latitude = -32.8338792756203,
//},
//new Municipality()
//{
//    Id = 300028,
//    Name = "Villa Elisa",
//    FullName = "Municipality Villa Elisa",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -58.4090489555759,
//    Latitude = -32.1385260770031,
//},
//new Municipality()
//{
//    Id = 822945,
//    Name = "Villa Eloísa",
//    FullName = "Comuna Villa Eloísa",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -61.5854778266405,
//    Latitude = -32.9790976473576,
//},
//new Municipality()
//{
//    Id = 340070,
//    Name = "Villa Escolar",
//    FullName = "Municipality Villa Escolar",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -58.6687220064221,
//    Latitude = -26.6313768550404,
//},
//new Municipality()
//{
//    Id = 303041,
//    Name = "Villa Fontana",
//    FullName = "Junta Villa Fontana",
//    Source = "IGN",
//    Category = "Junta",
//    Longitude = -60.4707773737723,
//    Latitude = -31.9028275998945,
//},
//new Municipality()
//{
//    Id = 140952,
//    Name = "Villa Fontana",
//    FullName = "Municipality Villa Fontana",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -63.1154326746593,
//    Latitude = -30.8951889539233,
//},
//new Municipality()
//{
//    Id = 140049,
//    Name = "Villa General Belgrano",
//    FullName = "Municipality Villa General Belgrano",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -64.5854153620909,
//    Latitude = -31.9843739756545,
//},
//new Municipality()
//{
//    Id = 340119,
//    Name = "Villa General Güemes",
//    FullName = "Municipality Villa General Güemes",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -59.4860182346937,
//    Latitude = -24.7572918582755,
//},
//new Municipality()
//{
//    Id = 60868,
//    Name = "Villa Gesell",
//    FullName = "Municipality Villa Gesell",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -57.0633978822493,
//    Latitude = -37.3670719558785,
//},
//new Municipality()
//{
//    Id = 140749,
//    Name = "Villa Giardino",
//    FullName = "Municipality Villa Giardino",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -64.5134379250355,
//    Latitude = -31.0401293203871,
//},
//new Municipality()
//{
//    Id = 820217,
//    Name = "Villa Gobernador Gálvez",
//    FullName = "Municipality Villa Gobernador Gálvez",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -60.6266965814293,
//    Latitude = -33.0286859947632,
//},
//new Municipality()
//{
//    Id = 822875,
//    Name = "Villa Guillermina",
//    FullName = "Comuna Villa Guillermina",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -59.6013721803907,
//    Latitude = -28.1387833977836,
//},
//new Municipality()
//{
//    Id = 142301,
//    Name = "Villa Gutiérrez",
//    FullName = "Comuna Villa Gutiérrez",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -64.1911110471417,
//    Latitude = -30.6956206838969,
//},
//new Municipality()
//{
//    Id = 140252,
//    Name = "Villa Huidobro",
//    FullName = "Municipality Villa Huidobro",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -64.5822038824256,
//    Latitude = -34.8396563912,
//},
//new Municipality()
//{
//    Id = 580133,
//    Name = "Villa La Angostura",
//    FullName = "Municipality Villa La Angostura",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -71.6236786667742,
//    Latitude = -40.7808534834305,
//},
//new Municipality()
//{
//    Id = 143092,
//    Name = "Villa La Bolsa",
//    FullName = "Comuna Villa La Bolsa",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -64.4294772612582,
//    Latitude = -31.7320720279432,
//},
//new Municipality()
//{
//    Id = 746105,
//    Name = "Villa Larca",
//    FullName = "Comisión Villa Larca",
//    Source = "IGN",
//    Category = "Comisión",
//    Longitude = -64.9872112934589,
//    Latitude = -32.6050751482545,
//},
//new Municipality()
//{
//    Id = 300098,
//    Name = "Villa Libertador San Martín",
//    FullName = "Municipality Villa Libertador San Martín",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -60.4710042663413,
//    Latitude = -32.0879029494773,
//},
//new Municipality()
//{
//    Id = 143099,
//    Name = "Villa Los Aromos",
//    FullName = "Comuna Villa Los Aromos",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -64.43835645444,
//    Latitude = -31.7198998965797,
//},
//new Municipality()
//{
//    Id = 143246,
//    Name = "Villa Los Patos",
//    FullName = "Comuna Villa Los Patos",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -62.7274983332989,
//    Latitude = -32.7675652636145,
//},
//new Municipality()
//{
//    Id = 300462,
//    Name = "Villa Mantero",
//    FullName = "Municipality Villa Mantero",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -58.7715832409376,
//    Latitude = -32.383847969167,
//},
//new Municipality()
//{
//    Id = 140357,
//    Name = "Villa María",
//    FullName = "Municipality Villa María",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -63.2366303163218,
//    Latitude = -32.4031012852999,
//},
//new Municipality()
//{
//    Id = 740077,
//    Name = "Villa Mercedes",
//    FullName = "Municipality Villa Mercedes",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -65.473922647412,
//    Latitude = -33.667693601946,
//},
//new Municipality()
//{
//    Id = 823344,
//    Name = "Villa Minetti",
//    FullName = "Comuna Villa Minetti",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -61.665114962826,
//    Latitude = -28.599845381729,
//},
//new Municipality()
//{
//    Id = 420406,
//    Name = "Villa Mirasol",
//    FullName = "Municipality Villa Mirasol",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -63.9307226012966,
//    Latitude = -36.0084630949918,
//},
//new Municipality()
//{
//    Id = 824037,
//    Name = "Villa Mugueta",
//    FullName = "Comuna Villa Mugueta",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -61.04468219722,
//    Latitude = -33.3210672731069,
//},
//new Municipality()
//{
//    Id = 140364,
//    Name = "Villa Nueva",
//    FullName = "Municipality Villa Nueva",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -63.2624459627598,
//    Latitude = -32.4348778297543,
//},
//new Municipality()
//{
//    Id = 820119,
//    Name = "Villa Ocampo",
//    FullName = "Municipality Villa Ocampo",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -59.2813301197138,
//    Latitude = -28.4942619198234,
//},
//new Municipality()
//{
//    Id = 180186,
//    Name = "Villa Olivari",
//    FullName = "Municipality Villa Olivari",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -56.9450426308656,
//    Latitude = -27.6294834203572,
//},
//new Municipality()
//{
//    Id = 908070,
//    Name = "Villa Padre Monti",
//    FullName = "Comuna Villa Padre Monti",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -64.9834851755064,
//    Latitude = -26.410457708461,
//},
//new Municipality()
//{
//    Id = 300224,
//    Name = "Villa Paranacito",
//    FullName = "Municipality Villa Paranacito",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -58.6611165082906,
//    Latitude = -33.8044702940384,
//},
//new Municipality()
//{
//    Id = 141410,
//    Name = "Villa Parque Santa Ana",
//    FullName = "Municipality Villa Parque Santa Ana",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -64.3471770630551,
//    Latitude = -31.5902804153487,
//},
//new Municipality()
//{
//    Id = 142532,
//    Name = "Villa Parque Síquiman",
//    FullName = "Comuna Villa Parque Síquiman",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -64.4926944882209,
//    Latitude = -31.3521525399098,
//},
//new Municipality()
//{
//    Id = 580252,
//    Name = "Villa Pehuenia",
//    FullName = "Municipality Villa Pehuenia",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -71.1785013313546,
//    Latitude = -38.9071357687159,
//},
//new Municipality()
//{
//    Id = 585154,
//    Name = "Villa Puente Picún Leufú",
//    FullName = "Comisión Villa Puente Picún Leufú",
//    Source = "IGN",
//    Category = "Comisión",
//    Longitude = -70.0822342331816,
//    Latitude = -39.2076088818031,
//},
//new Municipality()
//{
//    Id = 142091,
//    Name = "Villa Quillinzo",
//    FullName = "Comuna Villa Quillinzo",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -64.5299853713352,
//    Latitude = -32.2419722789317,
//},
//new Municipality()
//{
//    Id = 908455,
//    Name = "Villa Quinteros",
//    FullName = "Comuna Villa Quinteros",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -65.795376440252,
//    Latitude = -27.1087782657103,
//},
//new Municipality()
//{
//    Id = 620182,
//    Name = "Villa Regina",
//    FullName = "Municipality Villa Regina",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -67.0685739031772,
//    Latitude = -38.939856257769,
//},
//new Municipality()
//{
//    Id = 220203,
//    Name = "Villa Río Bermejito",
//    FullName = "Municipality Villa Río Bermejito",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -60.512369432311,
//    Latitude = -25.4574957536452,
//},
//new Municipality()
//{
//    Id = 140752,
//    Name = "Villa Río Icho Cruz",
//    FullName = "Municipality Villa Río Icho Cruz",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -64.5618964195508,
//    Latitude = -31.486607973038,
//},
//new Municipality()
//{
//    Id = 140658,
//    Name = "Villa Rossi",
//    FullName = "Municipality Villa Rossi",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -63.2704154896919,
//    Latitude = -34.29760379345,
//},
//new Municipality()
//{
//    Id = 140063,
//    Name = "Villa Rumipal",
//    FullName = "Municipality Villa Rumipal",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -64.4858600100433,
//    Latitude = -32.162560843929,
//},
//new Municipality()
//{
//    Id = 300273,
//    Name = "Villa Sabá Z. Hernández",
//    FullName = "Municipality Villa Sabá Z. Hernández",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -60.0258918519528,
//    Latitude = -32.3193817232215,
//},
//new Municipality()
//{
//    Id = 142980,
//    Name = "Villa San Esteban",
//    FullName = "Comuna Villa San Esteban",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -62.9033357626936,
//    Latitude = -31.6455668750732,
//},
//new Municipality()
//{
//    Id = 143113,
//    Name = "Villa San Isidro",
//    FullName = "Comuna Villa San Isidro",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -64.4161559166849,
//    Latitude = -31.8046885378687,
//},
//new Municipality()
//{
//    Id = 822392,
//    Name = "Villa San José",
//    FullName = "Comuna Villa San José",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -61.6167311160057,
//    Latitude = -31.3398681543485,
//},
//new Municipality()
//{
//    Id = 140754,
//    Name = "Villa Santa Cruz del Lago",
//    FullName = "Municipality Villa Santa Cruz del Lago",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -64.5104902375029,
//    Latitude = -31.3705588269763,
//},
//new Municipality()
//{
//    Id = 140945,
//    Name = "Villa Santa Rosa",
//    FullName = "Municipality Villa Santa Rosa",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -63.4030104122575,
//    Latitude = -31.1533189906775,
//},
//new Municipality()
//{
//    Id = 823673,
//    Name = "Villa Saralegui",
//    FullName = "Comuna Villa Saralegui",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -60.7712567256074,
//    Latitude = -30.4455258044118,
//},
//new Municipality()
//{
//    Id = 141120,
//    Name = "Villa Sarmiento",
//    FullName = "Municipality Villa Sarmiento",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -65.1928848099679,
//    Latitude = -31.9200351680031,
//},
//new Municipality()
//{
//    Id = 142252,
//    Name = "Villa Sarmiento",
//    FullName = "Comuna Villa Sarmiento",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -64.7361886687515,
//    Latitude = -34.1512198444081,
//},
//new Municipality()
//{
//    Id = 585070,
//    Name = "Villa Traful",
//    FullName = "Comisión Villa Traful",
//    Source = "IGN",
//    Category = "Comisión",
//    Longitude = -71.3996881542153,
//    Latitude = -40.6716922374758,
//},
//new Municipality()
//{
//    Id = 823680,
//    Name = "Villa Trinidad",
//    FullName = "Comuna Villa Trinidad",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -61.9263979382998,
//    Latitude = -30.2258166066169,
//},
//new Municipality()
//{
//    Id = 141582,
//    Name = "Villa Tulumba",
//    FullName = "Municipality Villa Tulumba",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -64.1206106410778,
//    Latitude = -30.3958819067891,
//},
//new Municipality()
//{
//    Id = 300371,
//    Name = "Villa Urquiza",
//    FullName = "Municipality Villa Urquiza",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -60.3172445683509,
//    Latitude = -31.6709308467484,
//},
//new Municipality()
//{
//    Id = 140259,
//    Name = "Villa Valeria",
//    FullName = "Municipality Villa Valeria",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -64.9192025001429,
//    Latitude = -34.3414551616036,
//},
//new Municipality()
//{
//    Id = 100119,
//    Name = "Villa Vil",
//    FullName = "Municipality Villa Vil",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -66.8066673019227,
//    Latitude = -26.5509350909479,
//},
//new Municipality()
//{
//    Id = 140070,
//    Name = "Villa Yacanto",
//    FullName = "Municipality Villa Yacanto",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -64.7855875348447,
//    Latitude = -32.122539446147,
//},
//new Municipality()
//{
//    Id = 822105,
//    Name = "Villada",
//    FullName = "Comuna Villada",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -61.4954681918107,
//    Latitude = -33.3390518480427,
//},
//new Municipality()
//{
//    Id = 300490,
//    Name = "Villaguay",
//    FullName = "Municipality Villaguay",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -59.0301405888196,
//    Latitude = -31.8357592945197,
//},
//new Municipality()
//{
//    Id = 60875,
//    Name = "Villarino",
//    FullName = "Municipality Villarino",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -62.7245989548872,
//    Latitude = -39.1285652325854,
//},
//new Municipality()
//{
//    Id = 386126,
//    Name = "Vinalito",
//    FullName = "Comisión Vinalito",
//    Source = "IGN",
//    Category = "Comisión",
//    Longitude = -64.3561446826511,
//    Latitude = -23.7298172538167,
//},
//new Municipality()
//{
//    Id = 460098,
//    Name = "Vinchina",
//    FullName = "Municipality Vinchina",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -68.5252932633173,
//    Latitude = -28.3166968176469,
//},
//new Municipality()
//{
//    Id = 822399,
//    Name = "Virginia",
//    FullName = "Comuna Virginia",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -61.3669141688829,
//    Latitude = -30.7574324549713,
//},
//new Municipality()
//{
//    Id = 580091,
//    Name = "Vista Alegre",
//    FullName = "Municipality Vista Alegre",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -68.2002445909251,
//    Latitude = -38.7688280807851,
//},
//new Municipality()
//{
//    Id = 386203,
//    Name = "Volcán",
//    FullName = "Comisión Volcán",
//    Source = "IGN",
//    Category = "Comisión",
//    Longitude = -65.4634492371713,
//    Latitude = -23.9238275052706,
//},
//new Municipality()
//{
//    Id = 309785,
//    Name = "Walter Moss",
//    FullName = "Junta Walter Moss",
//    Source = "IGN",
//    Category = "Junta",
//    Longitude = -58.5372230475338,
//    Latitude = -31.3494402987767,
//},
//new Municipality()
//{
//    Id = 142602,
//    Name = "Washington",
//    FullName = "Comuna Washington",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -64.6907512956001,
//    Latitude = -33.8748130316447,
//},
//new Municipality()
//{
//    Id = 141743,
//    Name = "Wenceslao Escalante",
//    FullName = "Municipality Wenceslao Escalante",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -62.7704160998211,
//    Latitude = -33.1716374700178,
//},
//new Municipality()
//{
//    Id = 822756,
//    Name = "Wheelwright",
//    FullName = "Comuna Wheelwright",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -61.2510944935396,
//    Latitude = -33.867358708721,
//},
//new Municipality()
//{
//    Id = 420413,
//    Name = "Winifreda",
//    FullName = "Municipality Winifreda",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -64.4552441731376,
//    Latitude = -36.2611820101032,
//},
//new Municipality()
//{
//    Id = 302808,
//    Name = "XX de Septiembre",
//    FullName = "Junta XX de Septiembre",
//    Source = "IGN",
//    Category = "Junta",
//    Longitude = -59.6702849410918,
//    Latitude = -32.3716400786029,
//},
//new Municipality()
//{
//    Id = 309505,
//    Name = "Yacaré",
//    FullName = "Junta Yacaré",
//    Source = "IGN",
//    Category = "Junta",
//    Longitude = -59.4947546569307,
//    Latitude = -30.5401534581415,
//},
//new Municipality()
//{
//    Id = 380042,
//    Name = "Yala",
//    FullName = "Municipality Yala",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -65.4641972021306,
//    Latitude = -24.0301722847921,
//},
//new Municipality()
//{
//    Id = 908266,
//    Name = "Yánima y El Corralito",
//    FullName = "Comuna Yánima y El Corralito",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -65.7197300664493,
//    Latitude = -27.6422694130306,
//},
//new Municipality()
//{
//    Id = 180378,
//    Name = "Yapeyú",
//    FullName = "Municipality Yapeyú",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -56.7895837854719,
//    Latitude = -29.3892370817004,
//},
//new Municipality()
//{
//    Id = 180217,
//    Name = "Yatay Ti Calle",
//    FullName = "Municipality Yatay Ti Calle",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -58.79744597162,
//    Latitude = -29.0601711930275,
//},
//new Municipality()
//{
//    Id = 386273,
//    Name = "Yavi",
//    FullName = "Comisión Yavi",
//    Source = "IGN",
//    Category = "Comisión",
//    Longitude = -65.3349528858579,
//    Latitude = -22.193901431537,
//},
//new Municipality()
//{
//    Id = 900133,
//    Name = "Yerba Buena",
//    FullName = "Municipality Yerba Buena",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -65.3052924010355,
//    Latitude = -26.8078337687848,
//},
//new Municipality()
//{
//    Id = 908560,
//    Name = "Yerba Buena",
//    FullName = "Comuna Yerba Buena",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -65.4103122818742,
//    Latitude = -27.2330298528978,
//},
//new Municipality()
//{
//    Id = 309510,
//    Name = "Yeso Oeste",
//    FullName = "Junta Yeso Oeste",
//    Source = "IGN",
//    Category = "Junta",
//    Longitude = -59.4501193132399,
//    Latitude = -30.992782315357,
//},
//new Municipality()
//{
//    Id = 380147,
//    Name = "Yuto",
//    FullName = "Municipality Yuto",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -64.6176370398462,
//    Latitude = -23.5653516067448,
//},
//new Municipality()
//{
//    Id = 746280,
//    Name = "Zanjitas",
//    FullName = "Comisión Zanjitas",
//    Source = "IGN",
//    Category = "Comisión",
//    Longitude = -66.4148690167957,
//    Latitude = -33.8049276377293,
//},
//new Municipality()
//{
//    Id = 580245,
//    Name = "Zapala",
//    FullName = "Municipality Zapala",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -70.1432085906337,
//    Latitude = -38.9328385901725,
//},
//new Municipality()
//{
//    Id = 60882,
//    Name = "Zárate",
//    FullName = "Municipality Zárate",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -59.1282178761959,
//    Latitude = -33.9970875495819,
//},
//new Municipality()
//{
//    Id = 823463,
//    Name = "Zavalla",
//    FullName = "Comuna Zavalla",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -60.9123585667831,
//    Latitude = -33.0171717856695,
//},
//new Municipality()
//{
//    Id = 822406,
//    Name = "Zenón Pereyra",
//    FullName = "Comuna Zenón Pereyra",
//    Source = "IGN",
//    Category = "Comuna",
//    Longitude = -61.9607529584595,
//    Latitude = -31.5489744082375,
//},
//new Municipality()
//{
//    Id = 700133,
//    Name = "Zonda",
//    FullName = "Municipality Zonda",
//    Source = "IGN",
//    Category = "Municipality",
//    Longitude = -68.9548418805416,
//    Latitude = -31.6417783563664,
//}
//);
//        }
//    }
//}
