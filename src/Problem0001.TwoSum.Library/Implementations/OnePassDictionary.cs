using Problem0001.TwoSum.Library.Interfaces;

namespace Problem0001.TwoSum.Library.Implementations;

public class OnePassDictionary : ISolution
{
    // Time complexity: O(n) - Space complexity: O(n)
    public int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> indexes = new(nums.Length);

        int complement;
        for (int i = 0; i < nums.Length; i++)
        {
            complement = target - nums[i];
            if (indexes.TryGetValue(complement, out int index))
            {
                return [index, i];
            }

            indexes[nums[i]] = i;
        }

        return Array.Empty<int>();
    }
}
