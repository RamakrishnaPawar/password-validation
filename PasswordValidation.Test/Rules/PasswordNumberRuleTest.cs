using PasswordValidation.Rules;
using Xunit;

namespace PasswordValidation.Test.Rules
{
    public class PasswordNumberRuleTest
    {
        [Fact]
        public void ShouldReturnTrueWhenPasswordHasAtLeastOneNumber()
        {
            const string input = "1Abs";
            
            var actual = new PasswordNumberRule().Evaluate(input);
            
            Assert.True(actual);
        }
    }
}