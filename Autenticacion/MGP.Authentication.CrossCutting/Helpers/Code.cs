namespace MGP.Authentication.CrossCutting.Helpers
{
    public enum Code
    {
        Success = 200,
        Created = 201,
        BadRequest = 400,
        Unauthorized = 401,
        Forbidden = 403,
        NotFound = 404,
        MethodNotAllowed = 405,
        Conflict = 409,
        Locked = 423,
        InternalServerError = 500,
        ServiceUnavailable = 503
    }
}
