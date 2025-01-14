using System;

namespace MGP.Authentication.Persistance.DTOs
{
    public class ChangePasswordData
    {
        public Guid UserId { get; set; }
        public string CurrentPassword { get; set; }
        public string NewPassword { get; set; }
    }
}
