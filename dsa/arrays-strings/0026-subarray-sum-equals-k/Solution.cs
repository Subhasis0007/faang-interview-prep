using System.Collections.Generic;

public class Solution
{
    public int SubarraySum(int[] nums, int k)
    {
        var freq = new Dictionary<int, int>();
        freq[0] = 1;

        int sum = 0;
        int count = 0;

        foreach (var x in nums)
        {
            sum += x;
            int need = sum - k;
            if (freq.TryGetValue(need, out int f))
                count += f;

            freq[sum] = freq.TryGetValue(sum, out int cur) ? cur + 1 : 1;
        }

        return count;
    }
}
