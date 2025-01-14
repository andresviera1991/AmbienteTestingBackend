using Swashbuckle.AspNetCore.Annotations;
using System.Text.Json.Serialization;
namespace MGP.Authentication.API.Controllers.V1.Auth.Request.Register;

[SwaggerSchema(Required = ["Street", "StreetNumber", "LocalityId"])]
public class AddressRequestModel
{
    /// <example>Salta</example>
    [SwaggerSchema("User's Street")]
    [JsonRequired]
    public string Street { get; set; }

    /// <example>2525</example>
    [SwaggerSchema("User's Street Number")]
    [JsonRequired]
    public string StreetNumber { get; set; }

    /// <example>PB</example>
    [SwaggerSchema("User's Street")]
    public string Floor { get; set; }

    /// <example>A</example>
    [SwaggerSchema("User's Apartment")]
    public string Apartment { get; set; }

    /// <example>Gascón</example>
    [SwaggerSchema("User's BetweenStreetOne")]
    public string BetweenStreetOne { get; set; }

    /// <example>Alberti</example>
    [SwaggerSchema("User's BetweenStreetTwo")]
    public string BetweenStreetTwo { get; set; }

    /// <example>6357110</example>
    [SwaggerSchema("User's LocalityId")]
    [JsonRequired]
    public int? LocalityId { get; set; }
}
