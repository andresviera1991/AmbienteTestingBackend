using Microsoft.AspNetCore.Identity;

namespace MGP.Backoffice.CrossCutting.Exceptions;

public class ChangePasswordException : Exception
{
    public List<string> ErrorMessages { get; }

    public ChangePasswordException(IEnumerable<IdentityError> errors)
    {
        ErrorMessages = errors.Select(e => e.Description).ToList();
    }
}
