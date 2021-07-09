using PasswordValidation.Exceptions;

namespace PasswordValidation.Rules
{
    public class PasswordLengthRule : IRule
    {
        private const int MinimumLength = 9;

        public bool Evaluate(string input)
        {
            if (input != null && input.Length >= MinimumLength)
            {
                return true;
            }

            throw new PasswordLengthRuleException($"Minimum required password length:{MinimumLength}");
        }
    }
}