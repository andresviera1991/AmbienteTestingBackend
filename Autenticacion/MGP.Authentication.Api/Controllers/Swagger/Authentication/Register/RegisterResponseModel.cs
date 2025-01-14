using Swashbuckle.AspNetCore.Annotations;

namespace MGP.Authentication.API.Controllers.Swagger.Authentication.Register
{
    public class RegisterResponseModel
    {
        /// <example>true</example>
        [SwaggerSchema("Exito")]
        public bool Success { get; set; }
    }
}
