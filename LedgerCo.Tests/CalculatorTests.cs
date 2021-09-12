using geektrust_family_demo;
using LedgerCo.Tests.Mock;
using Xunit;

namespace LedgerCo.Tests
{
    public class CalculatorTests
    {
        [Fact]
        public void CalculateBalance_WithValidInput_Should_BeSuccessful()
        {
            var input = DataMock.GetInput();
            var result = Calculator.CalculateBalance(input);
            Assert.True(result);
        }
        [Fact]
        public void CalculateBalance_WithInValidInput_Should_ThrowExceptionAndReturnFalse()
        {
            var input = DataMock.GetNegativeInput();
            var result = Calculator.CalculateBalance(input);
            Assert.False(result);
        }
    }
}
