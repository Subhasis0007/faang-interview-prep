using System;
using System.Collections.Generic;

public class Solution
{
    public int SwimInWater(int[][] grid)
    {
        int n = grid.Length;
        int lo = Math.Max(grid[0][0], grid[n - 1][n - 1]);
        int hi = lo;
        for (int i = 0; i < n; i++)
            for (int j = 0; j < n; j++)
                hi = Math.Max(hi, grid[i][j]);

        while (lo < hi)
        {
            int mid = lo + (hi - lo) / 2;
            if (CanReach(grid, mid)) hi = mid;
            else lo = mid + 1;
        }
        return lo;
    }

    private bool CanReach(int[][] g, int t)
    {
        int n = g.Length;
        if (g[0][0] > t) return false;

        var seen = new bool[n, n];
        var q = new Queue<(int r, int c)>();
        q.Enqueue((0, 0));
        seen[0, 0] = true;

        int[] dr = { 1, -1, 0, 0 };
        int[] dc = { 0, 0, 1, -1 };

        while (q.Count > 0)
        {
            var (r, c) = q.Dequeue();
            if (r == n - 1 && c == n - 1) return true;

            for (int k = 0; k < 4; k++)
            {
                int nr = r + dr[k];
                int nc = c + dc[k];
                if (nr < 0 || nc < 0 || nr >= n || nc >= n) continue;
                if (seen[nr, nc]) continue;
                if (g[nr][nc] > t) continue;
                seen[nr, nc] = true;
                q.Enqueue((nr, nc));
            }
        }

        return false;
    }
}
