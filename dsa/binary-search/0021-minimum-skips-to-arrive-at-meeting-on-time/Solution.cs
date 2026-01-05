using System;

public class Solution
{
    public int MinSkips(int[] dist, int speed, int hoursBefore)
    {
        int n = dist.Length;
        long INF = (long)1e18;
        long[] dp = new long[n + 1];
        for (int j = 0; j <= n; j++) dp[j] = INF;
        dp[0] = 0;

        for (int i = 0; i < n; i++)
        {
            long[] ndp = new long[n + 1];
            for (int j = 0; j <= n; j++) ndp[j] = INF;

            for (int skips = 0; skips <= i; skips++)
            {
                if (dp[skips] >= INF) continue;

                // Option 1: don't skip after this road (round up), only if not last road
                long t1 = dp[skips] + dist[i];
                if (i != n - 1)
                {
                    // round up to next multiple of speed
                    long rem = t1 % speed;
                    if (rem != 0) t1 += (speed - rem);
                }
                ndp[skips] = Math.Min(ndp[skips], t1);

                // Option 2: skip waiting after this road (no rounding)
                long t2 = dp[skips] + dist[i];
                ndp[skips + 1] = Math.Min(ndp[skips + 1], t2);
            }

            dp = ndp;
        }

        long limit = (long)hoursBefore * speed;
        for (int skips = 0; skips <= n; skips++)
        {
            if (dp[skips] <= limit) return skips;
        }
        return -1;
    }
}
