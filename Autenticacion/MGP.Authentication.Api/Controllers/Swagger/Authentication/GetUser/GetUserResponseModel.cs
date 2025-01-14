using Swashbuckle.AspNetCore.Annotations;

namespace MGP.Authentication.API.Controllers.Swagger.Authentication.GetUser
{
    public class GetUserResponseModel
    {
        public GetUserPersonResponseModel Person { get; set; }

        /// <example>example@gmail.com</example>
        [SwaggerSchema("Email")]
        public string Email { get; set; }
    }
}
