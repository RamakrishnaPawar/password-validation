using PasswordValidation.Exceptions;
using PasswordValidation.Rules;
using Xunit;


namespace PasswordValidation.Test.Rules
{
    public class PasswordLengthRuleTest
    {
        [Fact]
        public void ShouldReturnTrueWhenPasswordLengthMatchesToRequiredLength()
        {
            const string input = "c123Asd23";

            var actual = new PasswordLengthRule().Evaluate(input);

            Assert.True(actual);
        }
        
        [Fact]
        public void ShouldReturnTrueWhenPasswordLengthIsGreaterThanToRequiredLength()
        {
            const string input = "Abc123Asd23";

            var actual = new PasswordLengthRule().Evaluate(input);

            Assert.True(actual);
        }
        
        [Fact]
        public void ShouldThrowErrorWhenPasswordLengthIsLessThanToRequiredLength()
        {
            const string input = "Abc123";
            
            Assert.Throws<PasswordLengthRuleException>(() => new PasswordLengthRule().Evaluate(input));
        }
    }
}