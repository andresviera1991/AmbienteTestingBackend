using Swashbuckle.AspNetCore.Annotations;

namespace MGP.Authentication.API.Controllers.Swagger.Authentication.GetUser
{
    public class GetUserPersonAddressResponseModel
    {
        /// <example>Salta</example>
        [SwaggerSchema("Calle")]
        public string Street { get; set; }

        /// <example>2525</example>
        [SwaggerSchema("Numero de calle")]
        public string StreetNumber { get; set; }

        /// <example>PB</example>
        [SwaggerSchema("Piso")]
        public string Floor { get; set; }

        /// <example>A</example>
        [SwaggerSchema("Apartamento")]
        public string Apartment { get; set; }

        /// <example>Gascón</example>
        [SwaggerSchema("Entre calles")]
        public string BetweenStreetOne { get; set; }

        /// <example>example@gmail.com</example>
        [SwaggerSchema("Entre calles")]
        public string BetweenStreetTwo { get; set; }

        /// <example>6357110</example>
        [SwaggerSchema("Id de localidad")]
        public int LocalityId { get; set; }
    }
}
