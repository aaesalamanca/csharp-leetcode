using BenchmarkDotNet.Attributes;
using Solution = LeetSharp.Solutions.Library.Implementations.Problem2235AddTwoIntegers;

namespace LeetSharp.Benchmarks.Console.Benchmarks;

[MemoryDiagnoser]
public class Problem2235AddTwoIntegers
{
    private readonly Solution _problem2235AddTwoIntegers = new();

    // Uncomment the data set to run the benchmark against.
    public IEnumerable<object[]> Data()
    {
        yield return [12, 5];
        // yield return [-10, 4];
    }

    [Benchmark]
    [ArgumentsSource(nameof(Data))]
    public int Solution(int num1, int num2) => _problem2235AddTwoIntegers.Sum(num1, num2);
}
