using Swashbuckle.AspNetCore.Annotations;

namespace MGP.Location.API.Controllers.V1.Street.Request
{
    public class GetStreetsByNameRequestModel
    {
        /// <example>6357110</example>
        [SwaggerSchema("ID de localidad")]
        public long LocalityId { get; set; }

        /// <example>JUAN B JUSTO</example>
        [SwaggerSchema("Nombre de la calle")]
        public string Name { get; set; }
    }
}
