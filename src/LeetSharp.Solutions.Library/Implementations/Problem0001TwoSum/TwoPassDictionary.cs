using LeetSharp.Solutions.Library.Interfaces;

namespace LeetSharp.Solutions.Library.Implementations.Problem0001TwoSum;

public class TwoPassDictionary : IProblem0001TwoSum
{
    public int[] TwoSum(int[] nums, int target)
    {
        var indexes = new Dictionary<int, int>(nums.Length);

        for (int i = 0; i < nums.Length; i++)
        {
            indexes[nums[i]] = i;
        }

        int complement;
        for (int i = 0; i < nums.Length; i++)
        {
            complement = target - nums[i];
            if (indexes.TryGetValue(complement, out var index) && index != i)
            {
                return [i, index];
            }
        }

        return [];
    }
}
