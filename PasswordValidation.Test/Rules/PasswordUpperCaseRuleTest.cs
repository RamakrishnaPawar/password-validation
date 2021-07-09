using PasswordValidation.Rules;
using Xunit;

namespace PasswordValidation.Test.Rules
{
    public class PasswordUpperCaseRuleTest
    {
        [Fact]
        public void ShouldReturnTrueWhenPasswordHasAtLeastOneUpperCaseLetter()
        {
            const string input = "adsUU";

            var actual = new PasswordUpperCaseRule().Evaluate(input);
            
            Assert.True(actual);
        }
    }
}