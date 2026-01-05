using System;

public class Solution
{
    public string MinWindow(string s1, string s2)
    {
        int n = s1.Length;
        int m = s2.Length;
        if (m == 0) return string.Empty;

        // dp[j] = start index of a window ending at current i that matches s2[0..j]
        int[] dp = new int[m];
        Array.Fill(dp, -1);

        int bestLen = int.MaxValue;
        int bestStart = -1;

        for (int i = 0; i < n; i++)
        {
            // update backwards to not overwrite dp[j-1] needed for this i
            for (int j = m - 1; j >= 0; j--)
            {
                if (s1[i] == s2[j])
                {
                    if (j == 0)
                        dp[0] = i;
                    else if (dp[j - 1] != -1)
                        dp[j] = dp[j - 1];
                }
            }

            if (dp[m - 1] != -1)
            {
                int start = dp[m - 1];
                int len = i - start + 1;
                if (len < bestLen)
                {
                    bestLen = len;
                    bestStart = start;
                }
            }
        }

        return bestStart == -1 ? string.Empty : s1.Substring(bestStart, bestLen);
    }
}
