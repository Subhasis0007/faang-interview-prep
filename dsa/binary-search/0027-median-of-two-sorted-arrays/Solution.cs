using System;

public class Solution
{
    public double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        if (nums1.Length > nums2.Length)
            return FindMedianSortedArrays(nums2, nums1);

        int m = nums1.Length;
        int n = nums2.Length;
        int totalLeft = (m + n + 1) / 2;

        int lo = 0, hi = m;
        while (lo <= hi)
        {
            int i = lo + (hi - lo) / 2;
            int j = totalLeft - i;

            int aLeft  = (i == 0) ? int.MinValue : nums1[i - 1];
            int aRight = (i == m) ? int.MaxValue : nums1[i];
            int bLeft  = (j == 0) ? int.MinValue : nums2[j - 1];
            int bRight = (j == n) ? int.MaxValue : nums2[j];

            if (aLeft <= bRight && bLeft <= aRight)
            {
                int maxLeft = Math.Max(aLeft, bLeft);
                if (((m + n) & 1) == 1) return maxLeft;

                int minRight = Math.Min(aRight, bRight);
                return (maxLeft + minRight) / 2.0;
            }
            else if (aLeft > bRight)
            {
                hi = i - 1;
            }
            else
            {
                lo = i + 1;
            }
        }

        throw new InvalidOperationException("Invalid input.");
    }
}
