using System.Linq;
using PasswordValidation.Exceptions;

namespace PasswordValidation.Rules
{
    public class PasswordLowerCaseRule : IRule
    {
        public bool Evaluate(string input)
        {
            if (input.Any(char.IsLower))
                return true;
            throw new PasswordLowerCaseRuleException($"Minimum 1 character required in lower case");
        }
    }
}