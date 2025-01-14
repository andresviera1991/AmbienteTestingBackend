using FluentValidation.Results;
using System;
using System.Collections.Generic;

namespace MGP.Audit.CrossCutting.Excepciones
{
    public class ParameterNotProviderException : Exception
    {
        public List<ValidationFailure> Errors { get; set; }
        public ParameterNotProviderException()
        {

        }

        public ParameterNotProviderException(List<ValidationFailure> errors) : base()
        {
            Errors = errors;
        }
    }
}
