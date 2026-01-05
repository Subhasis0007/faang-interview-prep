public class Solution
{
    public bool IsMatch(string s, string p)
    {
        int m = s.Length;
        int n = p.Length;
        bool[,] dp = new bool[m + 1, n + 1];
        dp[0, 0] = true;

        // patterns like a*, a*b*, etc can match empty string
        for (int j = 2; j <= n; j++)
        {
            if (p[j - 1] == '*')
                dp[0, j] = dp[0, j - 2];
        }

        for (int i = 1; i <= m; i++)
        {
            for (int j = 1; j <= n; j++)
            {
                char pc = p[j - 1];
                if (pc == '*')
                {
                    // zero occurrences of the preceding element
                    dp[i, j] = dp[i, j - 2];

                    // one or more occurrences if preceding char matches current s
                    char prev = p[j - 2];
                    if (prev == '.' || prev == s[i - 1])
                        dp[i, j] = dp[i, j] || dp[i - 1, j];
                }
                else if (pc == '.' || pc == s[i - 1])
                {
                    dp[i, j] = dp[i - 1, j - 1];
                }
            }
        }

        return dp[m, n];
    }
}
