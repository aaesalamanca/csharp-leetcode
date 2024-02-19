using Problem0009.PalindromeNumber.Library.Interfaces;

namespace Problem0009.PalindromeNumber.Library.Implementations;

public class WithString : ISolution
{
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

        return x.ToString() == new string(x.ToString().Reverse().ToArray());
    }
}
