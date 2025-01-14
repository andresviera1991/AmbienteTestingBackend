using System;
using Swashbuckle.AspNetCore.Annotations;

namespace MGP.Authentication.API.Controllers.Swagger.Authentication.GetUser
{
    public class GetUserPersonResponseModel
    {
        /// <example>44413552</example>
        [SwaggerSchema("Numero de documento")]
        public string DocumentNumber { get; set; }

        /// <example>Cristian</example>
        [SwaggerSchema("Nombre")]
        public string Name { get; set; }

        /// <example>Fernandez</example>
        [SwaggerSchema("Apellido")]
        public string LastName { get; set; }

        /// <example>1998-05-07T00:00:00</example>
        [SwaggerSchema("Dia de nacimiento")]
        public DateTime BirthDate { get; set; }

        /// <example>1</example>
        [SwaggerSchema("Genero.\n\n" +
            "Los posibles valores son:\n" +
            "1 - Masculino\n" +
            "2 - Femenico\n" +
            "3 - X")]
        public int GenderId { get; set; }

        /// <example>true</example>
        [SwaggerSchema("User is Resident")]
        public bool Resident { get; set; }

        public GetUserPersonAddressResponseModel Address { get; set; }
        public GetUserPersonPhoneNumberResponseModel PhoneNumber { get; set; }
    }
}
