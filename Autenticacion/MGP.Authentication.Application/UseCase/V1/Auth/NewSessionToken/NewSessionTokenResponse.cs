
namespace MGP.Authentication.Application.UseCase.V1.Authentication.RefreshSessionToken
{
    public class NewSessionTokenResponse
    {
        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }
    }
}
