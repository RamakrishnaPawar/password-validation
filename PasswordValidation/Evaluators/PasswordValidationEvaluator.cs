using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
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
            var exception = new List<Exception>();
            var numberOfRulesPassed = 0;
            _passwordValidationRuleProvider.ProvideRules()
                .ForEach(rule =>
                {
                    try
                    {
                        numberOfRulesPassed += rule.Evaluate(input) ? 1 : 0;
                    }
                    catch (Exception ex)
                    {
                        exception.Add(ex);
                    }
                });
            if (numberOfRulesPassed > 2)
                return true;
            throw new AggregateException("Exceptions", exception);
        }
    }
}