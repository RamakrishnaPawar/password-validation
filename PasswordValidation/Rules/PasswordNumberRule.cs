using System.Linq;
using PasswordValidation.Exceptions;

namespace PasswordValidation.Rules
{
    public class PasswordNumberRule : IRule
    {
        public bool Evaluate(string input)
        {
            if (input.Any(char.IsNumber))
                return true;
            throw new PasswordNumberRuleException($"Minimum 1 character required to number");
        }
    }
}