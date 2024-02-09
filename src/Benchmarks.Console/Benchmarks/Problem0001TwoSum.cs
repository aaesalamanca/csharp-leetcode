using BenchmarkDotNet.Attributes;
using Problem0001.TwoSum.Library.Implementations;

namespace Benchmarks.Console.Benchmarks;

public class Problem0001TwoSum
{
    private readonly BruteForce _bruteForce = new();
    private readonly TwoPassDictionary _twoPassDictionary = new();
    private readonly OnePassDictionary _onePassDictionary = new();

    public IEnumerable<object[]> Data()
    {
        yield return new object[] { new int[] { 3, 2, 4 }, 6 };
        yield return new object[]
        {
            new int[] { 1 }
                .Concat(Enumerable.Range(2, 500))
                .Concat([1])
                .ToArray(),
            2
        };
    }

    [Benchmark(Baseline = true)]
    [ArgumentsSource(nameof(Data))]
    public int[] BruteForce(int[] nums, int target) => _bruteForce.TwoSum(nums, target);

    [Benchmark]
    [ArgumentsSource(nameof(Data))]
    public int[] TwoPassDictionary(int[] nums, int target) =>
        _twoPassDictionary.TwoSum(nums, target);

    [Benchmark]
    [ArgumentsSource(nameof(Data))]
    public int[] OnePassDictionary(int[] nums, int target) =>
        _onePassDictionary.TwoSum(nums, target);
}
