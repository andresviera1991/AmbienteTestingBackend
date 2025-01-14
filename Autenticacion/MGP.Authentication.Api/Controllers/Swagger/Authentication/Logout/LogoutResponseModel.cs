using Swashbuckle.AspNetCore.Annotations;

namespace MGP.Authentication.API.Controllers.Swagger.Authentication.Logout
{
    public class LogoutResponseModel
    {
        /// <example>true</example>
        [SwaggerSchema("Deslogueo exitoso")]
        public bool Success { get; set; }
    }
}
