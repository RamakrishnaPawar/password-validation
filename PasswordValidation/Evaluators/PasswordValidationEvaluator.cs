using System;
using PasswordValidation.Providers;

namespace PasswordValidation.Evaluators
{
    public class PasswordValidationEvaluator
    {
        private readonly IPasswordValidationRuleProvider _passwordValidationRuleProvider;

        public PasswordValidationEvaluator(IPasswordValidationRuleProvider passwordValidationRuleProvider)
        {
            _passwordValidationRuleProvider = passwordValidationRuleProvider;
        }

        public bool Evaluate(string input)
        {
            throw new NotImplementedException();
        }
    }
}