using MGP.Authentication.API.Controllers.Swagger.Messages;

namespace MGP.Authentication.API.Controllers.Swagger
{
    public class ErrorResponse
    {
        public int Code { get; set; }
        public object Data { get; set; }
        public ErrorMessage ErrorMessage { get; set; }
    }
}
