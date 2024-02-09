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
            if (indexes.TryGetValue(complement, out int index) && index != i)
            {
                return [i, index];
            }
        }

        return Array.Empty<int>();
    }
}
