using System;

public class Solution
{
    public int CountRangeSum(int[] nums, int lower, int upper)
    {
        long[] prefix = new long[nums.Length + 1];
        for (int i = 0; i < nums.Length; i++)
            prefix[i + 1] = prefix[i] + nums[i];

        long[] temp = new long[prefix.Length];
        return (int)SortCount(prefix, temp, 0, prefix.Length, lower, upper);
    }

    private long SortCount(long[] a, long[] temp, int lo, int hi, int lower, int upper)
    {
        if (hi - lo <= 1) return 0;

        int mid = lo + (hi - lo) / 2;
        long count = SortCount(a, temp, lo, mid, lower, upper) + SortCount(a, temp, mid, hi, lower, upper);

        int j = mid, k = mid;
        for (int i = lo; i < mid; i++)
        {
            while (k < hi && a[k] - a[i] < lower) k++;
            while (j < hi && a[j] - a[i] <= upper) j++;
            count += (j - k);
        }

        // merge
        int p = lo, q = mid, t = lo;
        while (p < mid && q < hi)
            temp[t++] = a[p] <= a[q] ? a[p++] : a[q++];
        while (p < mid) temp[t++] = a[p++];
        while (q < hi) temp[t++] = a[q++];
        for (int i = lo; i < hi; i++) a[i] = temp[i];

        return count;
    }
}
