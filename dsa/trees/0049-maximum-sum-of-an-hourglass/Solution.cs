using System;

public class Solution
{
    public int MaxSum(int[][] grid)
    {
        int m = grid.Length;
        int n = grid[0].Length;
        int best = int.MinValue;

        for (int i = 0; i + 2 < m; i++)
        {
            for (int j = 0; j + 2 < n; j++)
            {
                int sum = grid[i][j] + grid[i][j + 1] + grid[i][j + 2]
                        + grid[i + 1][j + 1]
                        + grid[i + 2][j] + grid[i + 2][j + 1] + grid[i + 2][j + 2];
                best = Math.Max(best, sum);
            }
        }

        return best;
    }
}
