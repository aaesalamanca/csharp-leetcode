namespace Problem0001.TwoSum.Library.UnitTest;

public class TwoSumTest
{
    [Theory]
    [InlineData(new int[] { 2, 7, 11, 15 }, 9, new int[] { 0, 1 })]
    [InlineData(new int[] { 3, 2, 4 }, 6, new int[] { 1, 2 })]
    [InlineData(new int[] { 3, 3 }, 6, new int[] { 0, 1 })]
    public void BruteForce_ReturnsTarget(int[] nums, int target, int[] expected)
    {
        // Arrange.
        ISolution sut = new BruteForce();

        // Act.
        var actual = sut.TwoSum(nums, target);

        // Assert.
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(new int[] { 2, 7, 11, 15 }, 9, new int[] { 0, 1 })]
    [InlineData(new int[] { 3, 2, 4 }, 6, new int[] { 1, 2 })]
    [InlineData(new int[] { 3, 3 }, 6, new int[] { 0, 1 })]
    public void OnePassDictionary_ReturnsTarget(int[] nums, int target, int[] expected)
    {
        // Arrange.
        ISolution sut = new OnePassDictionary();

        // Act.
        var actual = sut.TwoSum(nums, target);

        // Assert.
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(new int[] { 2, 7, 11, 15 }, 9, new int[] { 0, 1 })]
    [InlineData(new int[] { 3, 2, 4 }, 6, new int[] { 1, 2 })]
    [InlineData(new int[] { 3, 3 }, 6, new int[] { 0, 1 })]
    public void TwoPassDictionary_RetutnsTarget(int[] nums, int target, int[] expected)
    {
        // Arrange.
        ISolution sut = new TwoPassDictionary();

        // Act.
        var actual = sut.TwoSum(nums, target);

        // Assert.
        Assert.Equal(expected, actual);
    }
}
