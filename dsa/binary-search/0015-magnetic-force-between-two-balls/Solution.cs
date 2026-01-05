using System;

public class Solution
{
    public int MaxDistance(int[] position, int m)
    {
        Array.Sort(position);
        int lo = 1;
        int hi = position[^1] - position[0];

        while (lo < hi)
        {
            int mid = lo + (hi - lo + 1) / 2; // upper mid
            if (CanPlace(position, m, mid)) lo = mid;
            else hi = mid - 1;
        }

        return lo;
    }

    private bool CanPlace(int[] pos, int m, int dist)
    {
        int count = 1;
        int last = pos[0];

        for (int i = 1; i < pos.Length && count < m; i++)
        {
            if (pos[i] - last >= dist)
            {
                count++;
                last = pos[i];
            }
        }

        return count >= m;
    }
}
