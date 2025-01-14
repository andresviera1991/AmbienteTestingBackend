using Swashbuckle.AspNetCore.Annotations;

namespace MGP.Backoffice.Api.Controllers.Auth.Request
{
    [SwaggerSchema("Data structure containing request details for authenticate user",
        Required = new string[] { "UserName", "Pasword" })]
    public class LoginRequestModel
    {
        /// <example>41139455</example>
        [SwaggerSchema("User's username")]
        public string UserName { get; set; }

        /// <example>Guid_Email</example>
        [SwaggerSchema("User's password")]
        public string Password { get; set; }
    }
}

