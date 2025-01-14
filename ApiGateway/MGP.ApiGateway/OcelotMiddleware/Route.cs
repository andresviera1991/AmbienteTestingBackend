using Newtonsoft.Json;

namespace MGP.ApiGateway.OcelotMiddleware
{
    public class DownstreamHostAndPort
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Host { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int Port { get; set; }
    }

    public class RateLimitOptions
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool EnableRateLimiting { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Period { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string QuotaExceededMessage { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int Limit { get; set; }
    }

    public class AuthenticationOptions
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string AuthenticationProviderKey { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AllowedScopes { get; set; } = new List<string>();
    }

    public class Route
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string UpstreamPathTemplate { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<string> UpstreamHttpMethod { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string DownstreamPathTemplate { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string DownstreamScheme { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<DownstreamHostAndPort> DownstreamHostAndPorts { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string SwaggerKey { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public AuthenticationOptions AuthenticationOptions { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> RouteClaimsRequirement { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public RateLimitOptions RateLimitOptions { get; set; }
    }
}
