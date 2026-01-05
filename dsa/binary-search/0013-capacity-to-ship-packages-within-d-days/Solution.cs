public class Solution
{
    public int ShipWithinDays(int[] weights, int days)
    {
        int lo = 0;
        int hi = 0;
        foreach (var w in weights)
        {
            if (w > lo) lo = w;
            hi += w;
        }

        while (lo < hi)
        {
            int mid = lo + (hi - lo) / 2;
            if (CanShip(weights, days, mid)) hi = mid;
            else lo = mid + 1;
        }

        return lo;
    }

    private bool CanShip(int[] weights, int days, int cap)
    {
        int d = 1;
        int cur = 0;
        foreach (var w in weights)
        {
            if (cur + w > cap)
            {
                d++;
                cur = 0;
                if (d > days) return false;
            }
            cur += w;
        }
        return true;
    }
}
