using PasswordValidation.Exceptions;
using PasswordValidation.Rules;
using Xunit;

namespace PasswordValidation.Test.Rules
{
    public class PasswordUpperCaseRuleTest
    {
        [Fact]
        public void ShouldReturnTrueWhenPasswordHasAtLeastOneUpperCaseLetter()
        {
            const string input = "adsU";

            var actual = new PasswordUpperCaseRule().Evaluate(input);

            Assert.True(actual);
        }

        [Fact]
        public void ShouldReturnTrueWhenPasswordHasUpperCaseLetter()
        {
            const string input = "adsAAsdU";

            var actual = new PasswordUpperCaseRule().Evaluate(input);

            Assert.True(actual);
        }

        [Fact]
        public void ShouldThrowErrorWhenPasswordDoesNotHaveUpperCaseLetter()
        {
            const string input = "adsasyrer";

            Assert.Throws<PasswordUpperCaseRuleException>(() => new PasswordUpperCaseRule().Evaluate(input));
        }
    }
}