using Problem0009.PalindromeNumber.Library.Interfaces;

namespace Problem0009.PalindromeNumber.Library.Implementations;

public class IntsArray : ISolution
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

        List<int> components = new();
        ComposeListFromInt(components, x);

        return IsPalindrome(components.ToArray());
    }

    private void ComposeListFromInt(List<int> components, int x)
    {
        if (x / 10 > 0)
        {
            ComposeListFromInt(components, x / 10);
            components.Add(x % 10);
        }
        else
        {
            components.Add(x);
        }
    }

    private bool IsPalindrome(int[] components)
    {
        for (int i = 0, j = components.Length - 1; i < components.Length / 2; i++, j--)
        {
            if (components[i] != components[j])
            {
                return false;
            }
        }

        return true;
    }
}
