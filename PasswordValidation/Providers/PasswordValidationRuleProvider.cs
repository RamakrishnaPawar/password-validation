using System.Collections.Generic;
using PasswordValidation.Rules;

namespace PasswordValidation.Providers
{
    public class PasswordValidationRuleProvider: IPasswordValidationRuleProvider
    {
        private readonly PasswordNumberRule _passwordNumberRule;

        public PasswordValidationRuleProvider(PasswordNumberRule passwordNumberRule)
        {
            _passwordNumberRule = passwordNumberRule;
        }

        public List<IRule> ProvideRules()
        {
            throw new System.NotImplementedException();
        }
    }
}