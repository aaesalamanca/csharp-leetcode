using LeetSharp.Solutions.Library.Interfaces;

namespace LeetSharp.Solutions.Library.Implementations.Problem0001TwoSum;

public class OnePassDictionary : IProblem0001TwoSum
{
    public int[] TwoSum(int[] nums, int target)
    {
        var indexes = new Dictionary<int, int>(nums.Length);

        int complement;
        for (int i = 0; i < nums.Length; i++)
        {
            complement = target - nums[i];
            if (indexes.TryGetValue(complement, out var index))
            {
                return [index, i];
            }

            indexes[nums[i]] = i;
        }

        return [];
    }
}
