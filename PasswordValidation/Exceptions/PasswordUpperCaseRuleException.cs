using System;

namespace PasswordValidation.Exceptions
{
    public class PasswordUpperCaseRuleException : Exception
    {
        public PasswordUpperCaseRuleException(string message) : base(message)
        {
        }
    }
}