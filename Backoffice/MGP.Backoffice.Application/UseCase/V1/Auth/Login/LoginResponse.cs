namespace MGP.Backoffice.Application.UseCase.V1.Auth.Login
{
    public class LoginResponse
    {
        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }
    }
}
