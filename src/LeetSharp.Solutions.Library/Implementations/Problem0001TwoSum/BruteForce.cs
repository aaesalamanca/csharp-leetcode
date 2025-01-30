using LeetSharp.Solutions.Library.Interfaces;

namespace LeetSharp.Solutions.Library.Implementations.Problem0001TwoSum;

public class BruteForce : IProblem0001TwoSum
{
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

        return [];
    }
}
