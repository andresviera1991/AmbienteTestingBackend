using Swashbuckle.AspNetCore.Annotations;

namespace MGP.Authentication.API.Controllers.Swagger.Authentication.DeleteUser
{
    public class DeleteUserResponseModalExample
    {
        /// <summary>
        /// Example Code
        /// </summary>
        /// <example>200</example>
        [SwaggerSchema("Response Code")]
        public int Code { get; set; }

        public DeleteUserResponseModel Data { get; set; }

        /// <summary>
        /// List of error messages
        /// </summary>
        /// <example>null</example>
        [SwaggerSchema("List of error messages, if any")]
        public string Message { get; set; }
    }
}
