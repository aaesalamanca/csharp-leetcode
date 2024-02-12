using Problem0001.TwoSum.Library.Interfaces;

namespace Problem0001.TwoSum.Library.Implementations;

public class BruteForce : ISolution
{
    // Time complexity: O(nˆ2) - Space complexity: O(1)
    public int[] TwoSum(int[] nums, int target)
    {
        int complement;
        for (int i = 0; i < nums.Length - 1; i++)
        {
            complement = target - nums[i];
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[j] == complement)
                {
                    return [i, j];
                }
            }
        }

        return Array.Empty<int>();
    }
}
