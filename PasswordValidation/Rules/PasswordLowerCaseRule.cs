using System.Linq;

namespace PasswordValidation.Rules
{
    public class PasswordLowerCaseRule : IRule
    {
        public bool Evaluate(string input)
        {
            return input.Any(char.IsLower);
        }
    }
}