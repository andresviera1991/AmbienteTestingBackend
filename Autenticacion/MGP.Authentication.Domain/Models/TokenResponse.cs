
using System;

namespace MGP.Authentication.Domain.Models
{
    public class TokenResponse
    {
        public Guid UserId { get; set; }

        public string AccessToken { get; set; }

        public string RefreshToken { get; set; }
    }
}
