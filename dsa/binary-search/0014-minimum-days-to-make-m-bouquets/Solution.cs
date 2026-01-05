using System;

public class Solution
{
    public int MinDays(int[] bloomDay, int m, int k)
    {
        long need = (long)m * k;
        if (need > bloomDay.Length) return -1;

        int lo = int.MaxValue;
        int hi = int.MinValue;
        foreach (var d in bloomDay)
        {
            lo = Math.Min(lo, d);
            hi = Math.Max(hi, d);
        }

        while (lo < hi)
        {
            int mid = lo + (hi - lo) / 2;
            if (CanMake(bloomDay, m, k, mid)) hi = mid;
            else lo = mid + 1;
        }

        return lo;
    }

    private bool CanMake(int[] bloomDay, int m, int k, int day)
    {
        int bouquets = 0;
        int run = 0;
        foreach (var d in bloomDay)
        {
            if (d <= day)
            {
                run++;
                if (run == k)
                {
                    bouquets++;
                    if (bouquets >= m) return true;
                    run = 0;
                }
            }
            else
            {
                run = 0;
            }
        }
        return bouquets >= m;
    }
}
