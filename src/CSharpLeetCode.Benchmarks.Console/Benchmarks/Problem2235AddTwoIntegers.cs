using BenchmarkDotNet.Attributes;
using Solution = CSharpLeetCode.Solutions.Library.Implementations.Problem2235AddTwoIntegers;

namespace CSharpLeetCode.Benchmarks.Console.Benchmarks;

[MemoryDiagnoser]
public class Problem2235AddTwoIntegers
{
    private readonly Solution _problem2235AddTwoIntegers = new();

    // Uncomment the data set to run the benchmark against.
    public IEnumerable<object[]> Data()
    {
        yield return new object[] { 12, 5 };
        // yield return new object[] { -10, 4 };
    }

    [Benchmark]
    [ArgumentsSource(nameof(Data))]
    public int Solution(int num1, int num2) => _problem2235AddTwoIntegers.Sum(num1, num2);
}
