using System;
using System.Collections.Generic;

namespace MGP.Authentication.CrossCutting.Exceptions
{
    public class ParameterNotProviderException : Exception
    {
        public List<string> Errors { get; set; }

        public ParameterNotProviderException()
        {
            
        }
        public ParameterNotProviderException(List<string> errors) : base()
        {
            Errors = errors;
        }
    }
}
