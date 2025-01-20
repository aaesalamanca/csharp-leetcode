using CSharpLeetCode.Solutions.Library.Interfaces;
using Solution = CSharpLeetCode.Solutions.Library.Implementations.Problem0020ValidParentheses;

namespace CSharpLeetCode.Solutions.Library.UnitTest;

public class Problem0020ValidParentheses
{
    [Theory]
    [InlineData("()", true)]
    [InlineData("()[]{}", true)]
    [InlineData("(]", false)]
    [InlineData("([])", true)]
    public void ValidParentheses_ReturnsTarget(string s, bool expected)
    {
        // Arrange.
        IProblem0020ValidParentheses sut = new Solution();

        // Act.
        var actual = sut.IsValid(s);

        // Assert.
        Assert.Equal(expected, actual);
    }
}
