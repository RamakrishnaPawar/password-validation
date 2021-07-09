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
        
        [Fact]
        public void ShouldReturnTrueWhenPasswordHasNumber()
        {
            const string input = "14343Abs";
            
            var actual = new PasswordNumberRule().Evaluate(input);
            
            Assert.True(actual);
        }
        
        [Fact]
        public void ShouldReturnFalseWhenPasswordDoesNotHaveNumber()
        {
            const string input = "aAbs";
            
            var actual = new PasswordNumberRule().Evaluate(input);
            
            Assert.False(actual);
        }
    }
}