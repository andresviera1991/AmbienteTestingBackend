using Swashbuckle.AspNetCore.Annotations;

namespace MGP.Backoffice.Api.Controllers.Auth.Response
{
    public class LogoutResponseModel
    {
        /// <example>true</example>
        [SwaggerSchema("Deslogueo exitoso")]
        public bool Success { get; set; }
    }
}
