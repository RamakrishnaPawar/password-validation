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
        private readonly PasswordValidationRuleProvider _provider;
        private readonly IMock<PasswordNumberRule> _passwordNumberRule;

        public PasswordValidationRuleProviderTest()
        {
            _passwordNumberRule = new Mock<PasswordNumberRule>();
            _provider = new PasswordValidationRuleProvider(_passwordNumberRule.Object);
        }

        [Fact]
        public void ShouldProvideRules()
        {
            var actual = _provider.ProvideRules();

            var rules = actual.Should().BeOfType<List<IRule>>().Subject;
            rules.Should().HaveCount(1);
        }
    }
}