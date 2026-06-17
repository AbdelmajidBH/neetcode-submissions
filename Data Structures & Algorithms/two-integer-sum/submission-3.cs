public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        var indices = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];

            if (indices.TryGetValue(complement, out int index))
            {
                return new[] { index, i };
            }

            indices[nums[i]] = i;
        }

        return Array.Empty<int>();
    }
}