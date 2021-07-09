using PasswordValidation.Exceptions;
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
        public void ShouldThrowErrorWhenPasswordDoesNotHaveNumber()
        {
            const string input = "aAbs";
            
            Assert.Throws<PasswordNumberRuleException>( () => new PasswordNumberRule().Evaluate(input));
        }
    }
}