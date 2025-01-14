using MGP.Authentication.Application.UseCase.V1.User.GetUser.Response;

namespace MGP.Authentication.Application.UseCase.V1.User.GetUser
{
    public class GetUserResponse
    {
        public GetUserPersonResponse Person { get; set; }
        public string Email { get; set; }
    }
}
