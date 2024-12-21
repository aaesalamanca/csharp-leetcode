using Problem0001.TwoSum.Library.Interfaces;

namespace Problem0001.TwoSum.Library.Implementations;

public class BruteForce : ISolution
{
    public int[] TwoSum(int[] nums, int target)
    {
        int complement;

        for (int i = 0; i < nums.Length - 1; i++)
        {
            complement = target - nums[i];
            for (int j = i + i; i < nums.Length; j++)
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
