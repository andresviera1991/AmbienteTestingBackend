using Swashbuckle.AspNetCore.Annotations;
using System;

namespace MGP.Authentication.Application.UseCase.V1.Authentication.Register
{
    public class RegisterResponse
    {
        ///<example>11d54bb2-b0f8-430a-a130-c46d31488d2c</example>
        [SwaggerSchema("User Id")]
        public Guid UserId { get; set; }
    }
}
