using CSharpLeetCode.Solutions.Library.Interfaces;

namespace CSharpLeetCode.Solutions.Library.Implementations;

public class Problem0020ValidParentheses : IProblem0020ValidParentheses
{
    public bool IsValid(string s)
    {
        var opens = new Stack<char>();

        foreach (var letter in s)
        {
            if (letter == '(' || letter == '[' || letter == '{')
            {
                opens.Push(letter);
            }
            else if (opens.Count == 0 || GetOpenFromClose(letter) != opens.Pop())
            {
                return false;
            }
        }

        return opens.Count == 0;
    }

    char GetOpenFromClose(char close) =>
        close switch
        {
            ')' => '(',
            ']' => '[',
            '}' => '{',
            _ => '\0',
        };
}
