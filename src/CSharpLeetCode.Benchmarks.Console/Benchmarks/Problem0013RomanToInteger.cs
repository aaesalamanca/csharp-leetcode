using BenchmarkDotNet.Attributes;
using Solution = CSharpLeetCode.Solutions.Library.Implementations.Problem0013RomanToInteger;

namespace CSharpLeetCode.Benchmarks.Console.Benchmarks;

[MemoryDiagnoser]
public class Problem0013RomanToInteger
{
    private readonly Solution _problem0013RomanToInteger = new();

    // Uncomment the data set to run the benchmark against.
    public IEnumerable<object[]> Data()
    {
        yield return new object[] { "III" };
        // yield return new object[] { "LVIII" };
        // yield return new object[] { "MCMXCIV" };
    }

    [Benchmark]
    [ArgumentsSource(nameof(Data))]
    public int Solution(string s) => _problem0013RomanToInteger.RomanToInt(s);
}
