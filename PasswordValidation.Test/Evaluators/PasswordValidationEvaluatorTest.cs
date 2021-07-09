using System;
using System.Collections.Generic;
using FluentAssertions;
using Moq;
using PasswordValidation.Evaluators;
using PasswordValidation.Providers;
using PasswordValidation.Rules;
using Xunit;

namespace PasswordValidation.Test.Evaluators
{
    public class PasswordValidationEvaluatorTest
    {
        private readonly PasswordValidationEvaluator _passwordValidationEvaluator;
        private readonly Mock<IPasswordValidationRuleProvider> _mockPasswordValidationRuleProvider;
        private readonly Mock<PasswordNumberRule> _mockPasswordNumberRule;
        private readonly Mock<PasswordLengthRule> _mockPasswordLengthRule;
        private readonly Mock<PasswordUpperCaseRule> _mockPasswordUpperCaseRule;
        private readonly Mock<PasswordLowerCaseRule> _mockPasswordLowerCaseRule;

        public PasswordValidationEvaluatorTest()
        {
            _mockPasswordValidationRuleProvider = new Mock<IPasswordValidationRuleProvider>();
            _mockPasswordNumberRule = new Mock<PasswordNumberRule>();
            _mockPasswordLengthRule = new Mock<PasswordLengthRule>();
            _mockPasswordLowerCaseRule = new Mock<PasswordLowerCaseRule>();
            _mockPasswordUpperCaseRule = new Mock<PasswordUpperCaseRule>();
            _passwordValidationEvaluator = new PasswordValidationEvaluator(_mockPasswordValidationRuleProvider.Object);
        }

        [Fact]
        public void ShouldReturnTrueWhenAllRulesPassed()
        {
            const string input = "13ssfaaAvt12";
            _mockPasswordValidationRuleProvider.Setup(m => m.ProvideRules())
                .Returns(GetAllRules());

            var actual = _passwordValidationEvaluator.Evaluate(input);

            Assert.True(actual);
        }

        [Fact]
        public void ShouldReturnFalseWhenAnyOneRuleFails()
        {
            const string input = "QwesssfaaAvt";
            _mockPasswordValidationRuleProvider.Setup(m => m.ProvideRules())
                .Returns(GetAllRules());

            var exceptions = Assert.Throws<AggregateException>(() => _passwordValidationEvaluator.Evaluate(input));
            exceptions.InnerExceptions.Should().HaveCount(1);
            Assert.Equal(
                "Exceptions (Minimum 1 character required to number)",
                exceptions.Message);
        }

        [Fact]
        public void ShouldThrowErrorWhenAllRuleFails()
        {
            const string input = "$";
            _mockPasswordValidationRuleProvider.Setup(m => m.ProvideRules())
                .Returns(GetAllRules());

            var exceptions = Assert.Throws<AggregateException>(() => _passwordValidationEvaluator.Evaluate(input));
            exceptions.InnerExceptions.Should().HaveCount(4);
            Assert.Equal(
                $"Exceptions (Minimum 1 character required to number) (Minimum required password length:9) " +
                $"(Minimum 1 character required in lower case) (Minimum 1 character required in upper case)",
                exceptions.Message);
        }

        private List<IRule> GetAllRules()
        {
            return new List<IRule>
            {
                _mockPasswordNumberRule.Object, _mockPasswordLengthRule.Object, _mockPasswordLowerCaseRule.Object,
                _mockPasswordUpperCaseRule.Object
            };
        }
    }
}