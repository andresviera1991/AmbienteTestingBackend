using MGP.Authentication.Persistance.Data.Tables.Base;
using Microsoft.AspNetCore.Identity;
using System;

namespace MGP.Authentication.Persistance.Data.Tables
{
    public class Role : IdentityRole, IEntityBase
    {
        public DateTime CreationDate { get ; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
