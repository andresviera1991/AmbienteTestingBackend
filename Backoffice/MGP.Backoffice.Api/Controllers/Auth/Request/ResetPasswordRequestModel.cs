using Swashbuckle.AspNetCore.Annotations;

namespace MGP.Backoffice.Api.Controllers.Auth.Request
{
    public class ResetPasswordRequestModel
    {
        /// <example>882536</example>
        [SwaggerSchema("Employee Number")]
        public string EmployeeNumber { get; set; }
    }
}
