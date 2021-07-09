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
        
        [Fact]
        public void ShouldReturnTrueWhenPasswordHasLowerCaseLetter()
        {
            const string input = "asdRWEYEW";

            var actual = new PasswordLowerCaseRule().Evaluate(input);
            
            Assert.True(actual);
        }
        
            
        [Fact]
        public void ShouldReturnTrueWhenPasswordDoesNotHaveLowerCaseLetter()
        {
            const string input = "RWEYEW";

            var actual = new PasswordLowerCaseRule().Evaluate(input);
            
            Assert.False(actual);
        }
    }
}