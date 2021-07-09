using PasswordValidation.Rules;
using Xunit;

namespace PasswordValidation.Test.Rules
{
    public class PasswordLowerCaseRuleTest
    {
        [Fact]
        public void ShouldReturnTrueWhenPasswordHasAtLeastOneLowerCaseLetter()
        {
            const string input = "aRWEYEW";

            var actual = new PasswordLowerCaseRule().Evaluate(input);
            
            Assert.True(actual);
        }
    }
}