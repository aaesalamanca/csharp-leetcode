using LeetSharp.Solutions.Library.Interfaces;

namespace LeetSharp.Solutions.Library.Implementations;

public class Problem0013RomanToInteger : IProblem0013RomanToInteger
{
    public int RomanToInt(string s)
    {
        var romanInt = RomanToIntArray(s);
        var sum = 0;
        for (int i = 0; i < romanInt.Length - 1; i++)
        {
            if (romanInt[i] >= romanInt[i + 1])
            {
                sum += romanInt[i];
            }
            else
            {
                sum -= romanInt[i];
            }
        }

        sum += romanInt[^1];

        return sum;
    }

    int[] RomanToIntArray(string s)
    {
        var romanInt = new int[s.Length];
        for (int i = 0; i < s.Length; i++)
        {
            romanInt[i] = s[i] switch
            {
                'I' => 1,
                'V' => 5,
                'X' => 10,
                'L' => 50,
                'C' => 100,
                'D' => 500,
                'M' => 1000,
                _ => 0,
            };
        }

        return romanInt;
    }
}
