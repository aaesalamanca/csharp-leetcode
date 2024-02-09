using Problem0001.TwoSum.Library.Interfaces;

namespace Problem0001.TwoSum.Library.Implementations;

public class BruteForce : ISolution
{
    // Time complexity: O(nˆ2) - Space complexity: O(1)
    public int[] TwoSum(int[] nums, int target)
    {
        for (int i = 0; i < nums.Length - 1; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (target - nums[i] == nums[j])
                {
                    return [i, j];
                }
            }
        }

        return Array.Empty<int>();
    }
}
