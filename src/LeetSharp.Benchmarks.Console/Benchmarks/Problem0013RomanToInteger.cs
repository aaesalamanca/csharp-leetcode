using BenchmarkDotNet.Attributes;
using Solution = LeetSharp.Solutions.Library.Implementations.Problem0013RomanToInteger;

namespace LeetSharp.Benchmarks.Console.Benchmarks;

[MemoryDiagnoser]
public class Problem0013RomanToInteger
{
    private readonly Solution _problem0013RomanToInteger = new();

    // Uncomment the data set to run the benchmark against.
    public IEnumerable<string> Data()
    {
        yield return "III";
        // yield return "LVIII";
        // yield return "MCMXCIV";
    }

    [Benchmark]
    [ArgumentsSource(nameof(Data))]
    public int Solution(string s) => _problem0013RomanToInteger.RomanToInt(s);
}
