﻿using Swashbuckle.AspNetCore.Annotations;

namespace MGP.Backoffice.API.Controllers.V1.Auth.Request.NewToken
{
    public class NewTokensRequestModel
    {
        /// <example>eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJJZCI6IjMiLCJBcmVhIjoiRElTQ0FQQUNJREFEIiwiUm9sIjoiQUdFTlRFIiwiRW1haWwiOiJjcmlzdGlhbi5mZXIubWVsQGdtYWlsLmNvbSIsIm5iZiI6MTczMDkyNTU2OSwiZXhwIjoxNzMwOTI3MDA5LCJpYXQiOjE3MzA5MjU1NjksImlzcyI6Ik1BUlBMQURJR0lUQUwiLCJhdWQiOiJNQVJQTEFESUdJVEFMIn0.jsgW21j2tgBo3pl5Zb4wcNNKnoCxeR40zLLmeGf4gWE</example>
        [SwaggerSchema("User's Refresh Token")]
        public string RefreshToken { get; set; }
    }
}
