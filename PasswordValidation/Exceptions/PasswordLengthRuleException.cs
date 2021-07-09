using System;

namespace PasswordValidation.Exceptions
{
    public class PasswordLengthRuleException : Exception
    {
        public PasswordLengthRuleException(string message) : base(message)
        {
        }
    }
}