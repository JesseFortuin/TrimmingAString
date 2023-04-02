using TrimmingAString.BL;

namespace TrimmingAString.Test
{
    public class StringLengthCheckerTest
    {
        [Theory]
        [InlineData("Creating kata is fun", 14, "Creating ka...")]
        [InlineData("Code Wars is pretty rad", 50, "Code Wars is pretty rad")]
        [InlineData("He", 1, "H...")]
        public void TrimStringTest(string input, int limit, string expected)
        {
            //arrange
            IStringLengthChecker checker = new StringLengthChecker();

            //act
            string actual = checker.TrimString(input, limit);

            //assert
            Assert.Equal(expected, actual);
        }
    }
}