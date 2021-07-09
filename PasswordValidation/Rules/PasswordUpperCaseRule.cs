using System.Linq;
using PasswordValidation.Exceptions;

namespace PasswordValidation.Rules
{
    public class PasswordUpperCaseRule : IRule
    {
        public bool Evaluate(string input)
        {
            if (input.Any(char.IsUpper))
                return true;
            throw new PasswordUpperCaseRuleException($"Minimum 1 character required in upper case");
        }
    }
}