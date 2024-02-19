using BenchmarkDotNet.Attributes;
using Problem0009.PalindromeNumber.Library.Implementations;

namespace Benchmarks.Console.Benchmarks;

[MemoryDiagnoser]
public class Problem0009PalindromeNumber
{
    private readonly WithString _withString = new();
    private readonly IntsArray _intsArray = new();
    private readonly WithDivision _withDivision = new();

    // Uncomment the data set to run the benchmark against.
    public IEnumerable<object[]> Data()
    {
        // yield return new object[] { 121 };
        // yield return new object[] { 1000000000 };
        yield return new object[] { 1000000001 };
    }

    [Benchmark(Baseline = true)]
    [ArgumentsSource(nameof(Data))]
    public bool WithString(int x) => _withString.IsPalindrome(x);

    [Benchmark]
    [ArgumentsSource(nameof(Data))]
    public bool IntsArray(int x) => _intsArray.IsPalindrome(x);

    [Benchmark]
    [ArgumentsSource(nameof(Data))]
    public bool WithDivision(int x) => _withDivision.IsPalindrome(x);
}
