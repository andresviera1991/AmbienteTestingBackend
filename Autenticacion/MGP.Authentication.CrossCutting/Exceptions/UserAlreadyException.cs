using System;
namespace MGP.Authentication.CrossCutting.Exceptions;

public class UserAlreadyException : Exception
{
    public Guid Id { get; }

    public UserAlreadyException()
    {
            
    }
    public UserAlreadyException(Guid id)
    {
        Id = id;
    }

}
