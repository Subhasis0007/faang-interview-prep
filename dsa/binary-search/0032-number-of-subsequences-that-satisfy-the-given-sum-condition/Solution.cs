using System;

public class Solution
{
    public int NumSubseq(int[] nums, int target)
    {
        const int MOD = 1_000_000_007;
        Array.Sort(nums);
        int n = nums.Length;

        int[] pow2 = new int[n + 1];
        pow2[0] = 1;
        for (int i = 1; i <= n; i++)
            pow2[i] = (int)((pow2[i - 1] * 2L) % MOD);

        int l = 0, r = n - 1;
        long ans = 0;
        while (l <= r)
        {
            if (nums[l] + nums[r] <= target)
            {
                ans += pow2[r - l];
                ans %= MOD;
                l++;
            }
            else
            {
                r--;
            }
        }

        return (int)ans;
    }
}
