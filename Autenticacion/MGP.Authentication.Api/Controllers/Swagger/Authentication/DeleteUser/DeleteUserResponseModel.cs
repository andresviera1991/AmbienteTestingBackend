using Swashbuckle.AspNetCore.Annotations;
using System;

namespace MGP.Authentication.API.Controllers.Swagger.Authentication.DeleteUser
{
    public class DeleteUserResponseModel
    {
        /// <example>a7328606-0fbc-4bac-ab1d-8224fadb1ccb</example>
        [SwaggerSchema("Id de usuario")]
        public Guid Id { get; set; }
    }
}
