using System.Collections.Generic;

public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        var map = new Dictionary<int, int>(nums.Length);
        for (int i = 0; i < nums.Length; i++)
        {
            int need = target - nums[i];
            if (map.TryGetValue(need, out int j))
                return new[] { j, i };

            // store latest index for nums[i]
            map[nums[i]] = i;
        }
        return System.Array.Empty<int>();
    }
}
