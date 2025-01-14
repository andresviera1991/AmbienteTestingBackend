using Swashbuckle.AspNetCore.Annotations;

namespace MGP.Authentication.Application.UseCase.V1.Authentication.ValidateUser
{
    public class ValidateRegisterResponse
    {
        /// <summary>
        /// Example Code
        /// </summary>
        /// <example>True</example>
        [SwaggerSchema("Success")]
        public bool Success { get; set; }
    }
}
