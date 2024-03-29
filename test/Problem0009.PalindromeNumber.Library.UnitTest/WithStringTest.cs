namespace Problem0009.PalindromeNumber.Library.UnitTest;

using Problem0009.PalindromeNumber.Library.Implementations;
using Problem0009.PalindromeNumber.Library.Interfaces;

public class WithStringTest
{
    [Theory]
    [InlineData(121, true)]
    [InlineData(-121, false)]
    [InlineData(10, false)]
    public void IsPalindrome_ReturnsIfIsPalindrome(int x, bool expected)
    {
        // Arrange.
        ISolution solution = new WithString();

        // Act.
        bool actual = solution.IsPalindrome(x);

        // Assert.
        Assert.Equal(expected, actual);
    }
}
