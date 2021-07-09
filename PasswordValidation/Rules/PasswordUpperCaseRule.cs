using System.Linq;

namespace PasswordValidation.Rules
{
    public class PasswordUpperCaseRule : IRule
    {
        public bool Evaluate(string input)
        {
            return input.Any(char.IsUpper);
        }
    }
}