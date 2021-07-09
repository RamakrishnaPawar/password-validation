using System.Collections.Generic;
using PasswordValidation.Rules;

namespace PasswordValidation.Providers
{
    public interface IPasswordValidationRuleProvider
    {
        List<IRule> ProvideRules();
    }
}