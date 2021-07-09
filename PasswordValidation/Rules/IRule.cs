namespace PasswordValidation.Rules
{
    public interface IRule
    {
        bool Evaluate(string input);
    }
}