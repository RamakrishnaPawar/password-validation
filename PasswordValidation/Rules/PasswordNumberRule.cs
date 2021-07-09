using System.Linq;

namespace PasswordValidation.Rules
{
    public class PasswordNumberRule : IRule
    {
        public bool Evaluate(string input)
        {
            return input.Any(char.IsNumber);
        }
    }
}