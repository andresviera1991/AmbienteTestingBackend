using Swashbuckle.AspNetCore.Annotations;

namespace MGP.Backoffice.Api.Controllers.Auth.Response
{
    public class RegisterResponseModel
    {
        /// <example>true</example>
        [SwaggerSchema("Exito")]
        public bool Success { get; set; }
    }
}
