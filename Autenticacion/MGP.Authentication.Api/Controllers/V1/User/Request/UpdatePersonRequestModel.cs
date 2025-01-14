using MGP.Authentication.API.Controllers.V1.Auth.Request.Register;
using Swashbuckle.AspNetCore.Annotations;
using System;

namespace MGP.Authentication.API.Controllers.V1.User.Request;

public class UpdatePersonRequestModel
{
    /// <example>44413552</example>
    [SwaggerSchema("Document Number")]
    public string DocumentNumber { get; set; }

    /// <example>Marcos</example>
    [SwaggerSchema("User's First name")]
    public string Name { get; set; }

    /// <example>Lopéz</example>
    [SwaggerSchema("User's Last name")]
    public string LastName { get; set; }

    /// <example>1990-03-20</example>
    [SwaggerSchema("User's Birthdate")]
    public DateTime? BirthDate { get; set; }

    /// <example>1</example>
    [SwaggerSchema("User's Gender id")]
    public int? GenderId { get; set; }

    /// <example>true</example>
    [SwaggerSchema("User is Resident")]
    public bool? Resident { get; set; }

    public AddressRequestModel Address { get; set; }
    public PhoneNumberRequestModel PhoneNumber { get; set; }
    public ParentRequestModel Parent { get; set; }

}
