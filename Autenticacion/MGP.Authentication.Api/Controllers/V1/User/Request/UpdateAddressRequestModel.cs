using Swashbuckle.AspNetCore.Annotations;

namespace MGP.Authentication.API.Controllers.V1.User.Request;

public class UpdateAddressRequestModel
{
    /// <example>Salta</example>
    [SwaggerSchema("User's Street")]
    public string Street { get; set; }

    /// <example>2525</example>
    [SwaggerSchema("User's Street Number")]
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
    public int LocalityId { get; set; }
}
