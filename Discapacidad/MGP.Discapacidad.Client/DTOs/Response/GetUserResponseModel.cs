using Newtonsoft.Json;
using System.Collections.Generic;

namespace MGP.Discapacidad.Client.DTOs.Response;
public class GetUserResponseModel
{
    public List<string> Message { get; set; }
    public int Code { get; set; }
    public UserData Data { get; set; }
}

public class UserData
{
    [JsonProperty("person")]
    public PersonData Person { get; set; }

    [JsonProperty("email")]
    public string Email { get; set; }
}