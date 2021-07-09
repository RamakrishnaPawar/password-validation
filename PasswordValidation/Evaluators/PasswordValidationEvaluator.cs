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
            _passwordValidationRuleProvider.ProvideRules()
                .ForEach(rule =>
                {
                    try
                    {
                        rule.Evaluate(input);
                    }
                    catch (Exception ex)
                    {
                        exception.Add(ex);
                    }
                });
            if (exception.Count > 0)
                throw new AggregateException("Exceptions", exception);
            return true;
        }
    }
}