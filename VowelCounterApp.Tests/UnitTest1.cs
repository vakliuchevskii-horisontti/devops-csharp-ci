using Xunit;
using VowelCounterApp;

namespace VowelCounterApp.Tests
{
    public class ProgramTests
    {
        [Theory]
        [InlineData("Earth", 2)]
        [InlineData("Violin", 3)]
        [InlineData("aeIoU", 5)]
        [InlineData("", 0)]
        [InlineData("rhythm", 0)]
        public void CountVowels_ReturnsExpectedCount(
            string input, int expected)
        {
            int result = Program.CountVowels(input);

            Assert.Equal(expected, result);
        }
    }
}