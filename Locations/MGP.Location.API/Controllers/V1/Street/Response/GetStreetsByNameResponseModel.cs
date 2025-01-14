using Swashbuckle.AspNetCore.Annotations;

namespace MGP.Location.API.Controllers.V1.Street.Response
{
    [SwaggerSchema("Respuesta a una solicitud para obtener todas las calles de una localidad")]
    public class GetStreetsByNameResponseModel
    {
        /// <example>635711001605</example>
        [SwaggerSchema("ID de la calle")]
        public int Id { get; set; }

        /// <example>C 216 - JUAN DE DIOS FILIBERTO</example>
        [SwaggerSchema("Nombre de la calle")]
        public string Name { get; set; }

        /// <example>C 216 - JUAN DE DIOS FILIBERTO, Buenos Aires, General Pueyrredón</example>
        [SwaggerSchema("Nombre completo con provincia y departamento de la calle")]
        public string FullName { get; set; }

        /// <example>INDEC</example>
        [SwaggerSchema("Fuente de informacion")]
        public string Source { get; set; }

        /// <example>CALLE</example>
        [SwaggerSchema("Categoria de la calle.\n\n" +
            "Los posibles valores son:\n" +
            "- CALLE\n" +
            "- AV")]
        public string Category { get; set; }

        /// <example>1899</example>
        [SwaggerSchema("Ultimo numero de altura a la derecha")]
        public int EndHeightRight { get; set; }

        /// <example>1898</example>
        [SwaggerSchema("Ultimo numero de altura a la izquierda")]
        public int EndHeightLeft { get; set; }

        /// <example>1101</example>
        [SwaggerSchema("Primer numero de altura a la derecha")]
        public int StartHeightRight { get; set; }

        /// <example>1100</example>
        [SwaggerSchema("Primer numero de altura a la derecha")]
        public int StartHeightLeft { get; set; }
    }
}
