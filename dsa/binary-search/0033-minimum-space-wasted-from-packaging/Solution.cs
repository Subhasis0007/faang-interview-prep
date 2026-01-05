using System;

public class Solution
{
    public int MinWastedSpace(int[] packages, int[][] boxes)
    {
        const int MOD = 1_000_000_007;
        Array.Sort(packages);
        int n = packages.Length;

        long[] prefix = new long[n + 1];
        for (int i = 0; i < n; i++) prefix[i + 1] = prefix[i] + packages[i];

        long best = long.MaxValue;

        foreach (var supplier in boxes)
        {
            Array.Sort(supplier);
            if (supplier[^1] < packages[^1]) continue;

            long waste = 0;
            int idx = 0;

            foreach (var b in supplier)
            {
                if (idx >= n) break;
                // find rightmost package <= b
                int next = UpperBound(packages, b, idx);
                if (next > idx)
                {
                    long sumPack = prefix[next] - prefix[idx];
                    waste += (long)b * (next - idx) - sumPack;
                    if (waste >= best) break; // pruning
                    idx = next;
                }
            }

            if (idx == n) best = Math.Min(best, waste);
        }

        return best == long.MaxValue ? -1 : (int)(best % MOD);
    }

    // first index > value, searching in [start..]
    private int UpperBound(int[] a, int value, int start)
    {
        int l = start, r = a.Length;
        while (l < r)
        {
            int mid = l + (r - l) / 2;
            if (a[mid] <= value) l = mid + 1;
            else r = mid;
        }
        return l;
    }
}
