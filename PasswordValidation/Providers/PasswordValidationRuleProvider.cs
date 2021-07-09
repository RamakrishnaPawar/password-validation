using System.Collections.Generic;
using PasswordValidation.Rules;

namespace PasswordValidation.Providers
{
    public class PasswordValidationRuleProvider : IPasswordValidationRuleProvider
    {
        private readonly PasswordNumberRule _passwordNumberRule;
        private readonly PasswordLengthRule _passwordLengthRule;
        private readonly PasswordLowerCaseRule _passwordLowerCaseRule;
        private readonly PasswordUpperCaseRule _passwordUpperCaseRule;

        public PasswordValidationRuleProvider(PasswordNumberRule passwordNumberRule,
            PasswordLengthRule passwordLengthRule, PasswordLowerCaseRule passwordLowerCaseRule,
            PasswordUpperCaseRule passwordUpperCaseRule)
        {
            _passwordNumberRule = passwordNumberRule;
            _passwordLengthRule = passwordLengthRule;
            _passwordLowerCaseRule = passwordLowerCaseRule;
            _passwordUpperCaseRule = passwordUpperCaseRule;
        }

        public List<IRule> ProvideRules()
        {
            return new List<IRule>
            {
                _passwordNumberRule, _passwordLengthRule, _passwordLowerCaseRule,
                _passwordUpperCaseRule
            };
        }
    }
}