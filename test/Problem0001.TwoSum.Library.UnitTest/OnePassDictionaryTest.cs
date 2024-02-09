using Problem0001.TwoSum.Library.Implementations;
using Problem0001.TwoSum.Library.Interfaces;

namespace Problem0001.TwoSum.Library.UnitTest;

public class OnePassDictionaryTest
{
    [Theory]
    [InlineData(new int[] { 2, 7, 11, 15 }, 9, new int[] { 0, 1 })]
    [InlineData(new int[] { 3, 2, 4 }, 6, new int[] { 1, 2 })]
    [InlineData(new int[] { 3, 3 }, 6, new int[] { 0, 1 })]
    public void TwoSum_ReturnsTarget(int[] nums, int target, int[] expected)
    {
        // Arrange.
        ISolution solution = new OnePassDictionary();

        // Act.
        int[] actual = solution.TwoSum(nums, target);

        // Assert.
        Assert.Equal(expected, actual);
    }
}
