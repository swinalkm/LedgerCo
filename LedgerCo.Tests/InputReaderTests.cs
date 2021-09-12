using geektrust_family_demo;
using System.IO;
using Xunit;

namespace LedgerCo.Tests
{
    public class InputReaderTests
    {
        [Fact]
        public void ReadData_WithValidInput_Should_Return_SuccessfulData()
        {
            var filePath = Path.GetFullPath("Mock/ValidTest.txt");
            var output = InputReader.ReadData(filePath);
            Assert.NotNull(output);
            Assert.NotNull(output.Loans);
            Assert.NotNull(output.Payments);
            Assert.NotNull(output.Balances);
        }
        [Fact]
        public void ReadData_WithInValidInput_Should_ThrowException()
        {
            var filePath = Path.GetFullPath("Mock/InValidTest.txt");
            var output = InputReader.ReadData(filePath);
            Assert.Null(output);
        }
        [Fact]
        public void ReadData_WithInValidPath_Should_ThrowException()
        {
            var filePath = Path.GetFullPath("InValidPath.txt");
            var output = InputReader.ReadData(filePath);
            Assert.Null(output);
        }
    }
}
