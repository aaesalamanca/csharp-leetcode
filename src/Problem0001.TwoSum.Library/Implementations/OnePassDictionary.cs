using Problem0001.TwoSum.Library.Interfaces;

namespace Problem0001.TwoSum.Library.Implementations;

public class OnePassDictionary : ISolution
{
    // Time complexity: O(n) - Space complexity: O(n)
    public int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> indexes = new();

        int complement;
        for (int i = 0; i < nums.Length; i++)
        {
            complement = target - nums[i];
            if (indexes.ContainsKey(complement))
            {
                return [indexes[complement], i];
            }

            indexes[nums[i]] = i;
        }

        return Array.Empty<int>();
    }
}
