using Swashbuckle.AspNetCore.Annotations;

namespace MGP.Backoffice.Api.Controllers.Auth.Response
{
    public class LoginResponseModel
    {
        /// <example>eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJJZCI6IjI5ZGU5OWNmLThjY2ItNDM1ZS04ZDE0LTdhMGZmZTUzZDQyZiIsIm5iZiI6MTcyNzE4NzI2OSwiZXhwIjoxNzI3MTg3OTg5LCJpYXQiOjE3MjcxODcyNjksImlzcyI6Ik1BUlBMQURJR0lUQUwiLCJhdWQiOiJNQVJQTEFESUdJVEFMIn0.7cATHXP9xj3d2Pr1hqFnV5GG0oXUTxdK-3P9NWGwzS7</example>
        [SwaggerSchema("Token de acceso")]
        public string AccessToken { get; set; }

        /// <example>eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJJZCI6IjI5ZGU5OWNmLThjY2ItNDM1ZS04ZDE0LTdhMGZmZTUzZDQyZiIsIm5iZiI6MTcyNzE4NzI2OSwiZXhwIjoxNzI3MTg4NzA5LCJpYXQiOjE3MjcxODcyNjksImlzcyI6Ik1BUlBMQURJR0lUQUwiLCJhdWQiOiJNQVJQTEFESUdJVEFMIn0.mhrQ5v-9JJd-symNHlmJxIlPXcM6rbkoKkhVJI_w7ww</example>
        [SwaggerSchema("Token de refresco")]
        public string RefreshToken { get; set; }
    }
}
