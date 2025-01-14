using Swashbuckle.AspNetCore.Annotations;

namespace MGP.Authentication.API.Controllers.Swagger.Authentication.GetUser
{
    public class GetUserPersonPhoneNumberResponseModel
    {
        /// <example>22334565476</example>
        [SwaggerSchema("Numero de teléfono")]
        public string Number { get; set; }
    }
}
