using System.Collections.Generic;
using FluentAssertions;
using Moq;
using PasswordValidation.Providers;
using PasswordValidation.Rules;
using Xunit;

namespace PasswordValidation.Test.Providers
{
    public class PasswordValidationRuleProviderTest
    {
        private readonly IPasswordValidationRuleProvider _provider;
        private readonly IMock<PasswordNumberRule> _passwordNumberRule;
        private readonly IMock<PasswordLengthRule> _passwordLengthRule;
        private readonly IMock<PasswordLowerCaseRule> _passwordLowerCaseRule;
        private readonly IMock<PasswordUpperCaseRule> _passwordUpperCaseRule;

        public PasswordValidationRuleProviderTest()
        {
            _passwordNumberRule = new Mock<PasswordNumberRule>();
            _passwordLengthRule = new Mock<PasswordLengthRule>();
            _passwordLowerCaseRule = new Mock<PasswordLowerCaseRule>();
            _passwordUpperCaseRule = new Mock<PasswordUpperCaseRule>();
            _provider = new PasswordValidationRuleProvider(_passwordNumberRule.Object, _passwordLengthRule.Object,
                _passwordLowerCaseRule.Object, _passwordUpperCaseRule.Object);
        }

        [Fact]
        public void ShouldProvideRules()
        {
            var actual = _provider.ProvideRules();

            var rules = actual.Should().BeOfType<List<IRule>>().Subject;
            rules.Should().HaveCount(4);
            rules[0].Should().BeOfType(_passwordNumberRule.Object.GetType());
            rules[1].Should().BeOfType(_passwordLengthRule.Object.GetType());
            rules[2].Should().BeOfType(_passwordLowerCaseRule.Object.GetType());
            rules[3].Should().BeOfType(_passwordUpperCaseRule.Object.GetType());
        }
    }
}