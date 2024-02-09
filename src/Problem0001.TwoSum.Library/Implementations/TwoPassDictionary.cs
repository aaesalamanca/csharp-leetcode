using Problem0001.TwoSum.Library.Interfaces;

namespace Problem0001.TwoSum.Library.Implementations;

public class TwoPassDictionary : ISolution
{
    // Time complexity: O(n) - Space complexity: O(n)
    public int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> indexes = new();

        for (int i = 0; i < nums.Length; i++)
        {
            indexes[nums[i]] = i;
        }

        int complement;
        for (int i = 0; i < nums.Length; i++)
        {
            complement = target - nums[i];
            if (indexes.ContainsKey(complement) && indexes[complement] != i)
            {
                return [i, indexes[complement]];
            }
        }

        return Array.Empty<int>();
    }
}
