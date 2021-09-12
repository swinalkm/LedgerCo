using FluentAssertions;
using geektrust_family_demo;
using System;
using Xunit;

namespace LedgerCo.Tests
{
    public class ParserTest
    {
        [Fact]
        public void ParseInt_WithValidInput_Should_Return_Int()
        {
            string[] input = { "11.25", "52" };
            var output = Parser.ParseInt(input, 1);
            output.Should().NotBe(0);
            output.Should().Be(52);
        }
        [Fact]
        public void ParseInt_WithInValidInput_Should_ThrowException()
        {
            string[] input = { "11.25", "abc" };
            Assert.Throws<Exception>(() => Parser.ParseInt(input, 1));
        }
        [Fact]
        public void ParseDecimal_WithValidInput_Should_Return_Int()
        {
            string[] input = { "11.25", "52.26" };
            var output = Parser.ParseDecimal(input, 1);
            output.Should().NotBe(0);
            output.Should().Be(52.26M);
        }
        [Fact]
        public void ParseDecimal_WithInValidInput_Should_ThrowException()
        {
            string[] input = { "11.25", "abc" };
            Assert.Throws<Exception>(() => Parser.ParseDecimal(input, 1));
        }
    }
}
