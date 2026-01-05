using System;

public class Solution
{
    public int MaxValue(int n, int index, int maxSum)
    {
        int l = 1, r = maxSum;
        while (l < r)
        {
            int mid = l + (r - l + 1) / 2; // upper mid
            if (RequiredSum(n, index, mid) <= maxSum) l = mid;
            else r = mid - 1;
        }
        return l;
    }

    private long RequiredSum(int n, int index, int peak)
    {
        int leftLen = index;
        int rightLen = n - index - 1;

        long sum = peak;
        sum += SideSum(peak - 1, leftLen);
        sum += SideSum(peak - 1, rightLen);
        return sum;
    }

    // Sum of length len descending from start down to >=1, then pad with 1s
    private long SideSum(int start, int len)
    {
        if (len <= 0) return 0;
        if (start >= len)
        {
            // start + (start-1) + ... + (start-len+1)
            long a = start;
            long b = start - len + 1;
            return (a + b) * len / 2;
        }
        else
        {
            // start + ... + 1 plus remaining ones
            long sumDec = (long)(start + 1) * start / 2;
            long ones = len - start;
            return sumDec + ones;
        }
    }
}
