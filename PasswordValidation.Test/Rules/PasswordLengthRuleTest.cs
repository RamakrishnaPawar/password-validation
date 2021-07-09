using PasswordValidation.Rules;
using Xunit;


namespace PasswordValidation.Test.Rules
{
    public class PasswordLengthRuleTest
    {
        [Fact]
        public void ShouldReturnTrueWhenPasswordLengthMatchesToRequiredLength()
        {
            const string input = "Abc123Asd23";

            var actual = new PasswordLengthRule().Evaluate(input);

            Assert.True(actual);
        }
    }
}