using Swashbuckle.AspNetCore.Annotations;

namespace MGP.Authentication.API.Controllers.Swagger.Authentication.Validate
{
    public class ValidateRegisterResponseModel
    {
        /// <summary>
        /// Example Code
        /// </summary>
        /// <example>True</example>
        [SwaggerSchema("Success")]
        public bool Success { get; set; }
    }
}
