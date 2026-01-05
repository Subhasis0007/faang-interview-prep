using System;
using System.Collections.Generic;

public class Solution
{
    public int LongestPath(int[] parent, string s)
    {
        int n = parent.Length;
        var children = new List<int>[n];
        for (int i = 0; i < n; i++) children[i] = new List<int>();
        for (int i = 1; i < n; i++) children[parent[i]].Add(i);

        int best = 1;

        int Dfs(int u)
        {
            int best1 = 0, best2 = 0; // top two child chains usable

            foreach (int v in children[u])
            {
                int len = Dfs(v);
                if (s[v] == s[u]) continue;

                if (len > best1)
                {
                    best2 = best1;
                    best1 = len;
                }
                else if (len > best2)
                {
                    best2 = len;
                }
            }

            best = Math.Max(best, 1 + best1 + best2);
            return 1 + best1;
        }

        Dfs(0);
        return best;
    }
}
