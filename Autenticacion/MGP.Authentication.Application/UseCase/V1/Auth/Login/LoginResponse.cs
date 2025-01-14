
namespace MGP.Authentication.Application.UseCase.V1.Authentication.Login
{
    public class LoginResponse
    {
        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }
    }
}
