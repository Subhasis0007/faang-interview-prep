public class Solution
{
    public int SplitArray(int[] nums, int m)
    {
        int lo = 0;
        long hi = 0;
        foreach (var x in nums)
        {
            if (x > lo) lo = x;
            hi += x;
        }

        long l = lo, r = hi;
        while (l < r)
        {
            long mid = l + (r - l) / 2;
            if (CanSplit(nums, m, mid)) r = mid;
            else l = mid + 1;
        }

        return (int)l;
    }

    private bool CanSplit(int[] nums, int m, long maxSum)
    {
        int parts = 1;
        long cur = 0;
        foreach (var x in nums)
        {
            if (cur + x > maxSum)
            {
                parts++;
                cur = 0;
                if (parts > m) return false;
            }
            cur += x;
        }
        return true;
    }
}
