using Problem0009.PalindromeNumber.Library.Implementations;
using Problem0009.PalindromeNumber.Library.Interfaces;

namespace Problem0009.PalindromeNumber.Library.UnitTest;

public class IntsArrayTest
{
    [Theory]
    [InlineData(121, true)]
    [InlineData(-121, false)]
    [InlineData(10, false)]
    public void IsPalindrome_ReturnsIfIsPalindrome(int x, bool expected)
    {
        // Arrange.
        ISolution solution = new IntsArray();

        // Act.
        bool actual = solution.IsPalindrome(x);

        // Assert.
        Assert.Equal(expected, actual);
    }
}
