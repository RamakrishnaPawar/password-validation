namespace PasswordValidation.Rules
{
    public class PasswordLengthRule : IRule
    {
        private const int MinimumLength = 9;

        public bool Evaluate(string input)
        {
            return input != null && input.Length >= MinimumLength;
        }
    }
}