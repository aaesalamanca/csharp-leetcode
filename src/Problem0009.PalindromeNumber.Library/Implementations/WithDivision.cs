using Problem0009.PalindromeNumber.Library.Interfaces;

namespace Problem0009.PalindromeNumber.Library.Implementations;

public class WithDivision : ISolution
{
    // Time complexity: O(n) (?) - Space complexity: O(1) (?)
    public bool IsPalindrome(int x)
    {
        if (x < 0)
        {
            return false;
        }

        if (x < 10)
        {
            return true;
        }

        int tempX = x;
        int sum = 0;
        while (tempX > 9)
        {
            sum = (sum + tempX % 10) * 10;

            tempX /= 10;
        }

        return (sum + tempX) == x;
    }
}
