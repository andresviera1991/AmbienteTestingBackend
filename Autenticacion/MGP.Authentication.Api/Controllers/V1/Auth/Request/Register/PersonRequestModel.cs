using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Text.Json.Serialization;
namespace MGP.Authentication.API.Controllers.V1.Auth.Request.Register;

[SwaggerSchema("Data structure containing request details for creating a user", Required = ["DocumentNumber", "Name", "LastName", "BirthDate", "GenderId", "Resident"])]
public class PersonRequestModel
{
    /// <example>44413552</example>
    [SwaggerSchema("Document Number")]
    [JsonRequired]
    public string DocumentNumber { get; set; }

    /// <example>Cristian</example>
    [SwaggerSchema("User's first name")]
    [JsonRequired]
    public string Name { get; set; }

    /// <example>Fernandez</example>
    [SwaggerSchema("User's last name")]
    [JsonRequired]
    public string LastName { get; set; }

    /// <example>1998-05-07</example>
    [SwaggerSchema("User's Birthdate")]
    [JsonRequired]
    public DateTime BirthDate { get; set; }

    /// <example>1</example>
    [SwaggerSchema("User's gender id")]
    [JsonRequired]
    public int GenderId { get; set; }

    /// <example>true</example>
    [SwaggerSchema("User is Resident")]
    [JsonRequired]
    public bool Resident { get; set; }

    public AddressRequestModel Address { get; set; }

    public PhoneNumberRequestModel PhoneNumber { get; set; }

    public ParentRequestModel Parent { get; set; }

}
