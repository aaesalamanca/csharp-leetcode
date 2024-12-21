using Problem0001.TwoSum.Library.Interfaces;

namespace Problem0001.TwoSum.Library.Implementations;

public class OnePassDictionary : ISolution
{
    public int[] TwoSum(int[] nums, int target)
    {
        var indexes = new Dictionary<int, int>(nums.Length);

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

        return [];
    }
}
