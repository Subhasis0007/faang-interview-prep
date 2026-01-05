using System;

public class Solution
{
    public int MinEatingSpeed(int[] piles, int h)
    {
        int max = 0;
        foreach (var p in piles) if (p > max) max = p;

        int l = 1, r = max;
        while (l < r)
        {
            int mid = l + (r - l) / 2;
            long hours = 0;
            foreach (var p in piles)
            {
                // ceil(p / mid) = (p + mid - 1) / mid
                hours += (p + mid - 1) / mid;
                if (hours > h) break;
            }

            if (hours <= h) r = mid;
            else l = mid + 1;
        }
        return l;
    }
}
