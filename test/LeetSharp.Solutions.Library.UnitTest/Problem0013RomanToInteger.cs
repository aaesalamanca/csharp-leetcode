using LeetSharp.Solutions.Library.Interfaces;
using Solution = LeetSharp.Solutions.Library.Implementations.Problem0013RomanToInteger;

namespace LeetSharp.Solutions.Library.UnitTest;

public class Problem0013RomanToInteger
{
    [Theory]
    [InlineData("III", 3)]
    [InlineData("LVIII", 58)]
    [InlineData("MCMXCIV", 1994)]
    public void RomanToInteger_ReturnsTarget(string s, int expected)
    {
        // Arrange.
        IProblem0013RomanToInteger sut = new Solution();

        // Act.
        var actual = sut.RomanToInt(s);

        // Assert.
        Assert.Equal(expected, actual);
    }
}
