using BenchmarkDotNet.Attributes;
using Solution = LeetSharp.Solutions.Library.Implementations.Problem0020ValidParentheses;

namespace LeetSharp.Benchmarks.Console.Benchmarks;

[MemoryDiagnoser]
public class Problem0020ValidParentheses
{
    private readonly Solution _problem0020ValidParentheses = new();

    // Uncomment the data set to run the benchmark against.
    public IEnumerable<string> Data()
    {
        // yield return "()";
        yield return "()[]{}";
        // yield return "(]";
        // yield return "([])";
        // yield return "]";
        // yield return "){";
        // yield return "(])";
    }

    [Benchmark]
    [ArgumentsSource(nameof(Data))]
    public bool Solution(string s) => _problem0020ValidParentheses.IsValid(s);
}
