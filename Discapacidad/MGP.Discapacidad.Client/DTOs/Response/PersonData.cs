using Newtonsoft.Json;
namespace MGP.Discapacidad.Client.DTOs.Response;

public class PersonData
{
    [JsonProperty("lastName")]
    public string LastName { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("documentNumber")]
    public string DocumentNumber { get; set; }

    [JsonProperty("userEmail")]
    public string UserEmail { get; set; }
}
