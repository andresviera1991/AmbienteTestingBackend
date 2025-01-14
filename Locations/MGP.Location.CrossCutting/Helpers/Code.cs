namespace MGP.Location.CrossCutting.Helpers
{
    public enum Code
    {
        Success = 200,
        BadRequest = 400,
        Unauthorized = 401,
        Forbidden = 403,
        NotFound = 404,
        MethodNotAllowed = 405,
        Conflict = 409,
        InternalServerError = 500,
        ServiceUnavailable = 503
    }
}
