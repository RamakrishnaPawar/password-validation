using System;

namespace PasswordValidation.Exceptions
{
    public class PasswordLowerCaseRuleException : Exception
    {
        public PasswordLowerCaseRuleException(string? message) : base(message)
        {
        }
    }
}