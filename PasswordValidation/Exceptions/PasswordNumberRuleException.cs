using System;

namespace PasswordValidation.Exceptions
{
    public class PasswordNumberRuleException : Exception
    {
        public PasswordNumberRuleException(string message) : base(message)
        {
        }
    }
}