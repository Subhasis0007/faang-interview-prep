using System;

public class Solution
{
    public string MinWindow(string s, string t)
    {
        if (string.IsNullOrEmpty(t) || string.IsNullOrEmpty(s) || t.Length > s.Length)
            return string.Empty;

        // ASCII counts. For Unicode, use Dictionary<char,int>.
        int[] need = new int[128];
        int required = 0;
        foreach (char c in t)
        {
            if (need[c] == 0) required++;
            need[c]++;
        }

        int[] window = new int[128];
        int formed = 0;

        int bestLen = int.MaxValue;
        int bestL = 0;

        int l = 0;
        for (int r = 0; r < s.Length; r++)
        {
            char c = s[r];
            if (c < 128)
            {
                window[c]++;
                if (need[c] > 0 && window[c] == need[c])
                    formed++;
            }
            else
            {
                // Non-ASCII char: degrade gracefully by treating as not-needed
                // (LeetCode inputs are typically ASCII)
            }

            while (formed == required && l <= r)
            {
                int len = r - l + 1;
                if (len < bestLen)
                {
                    bestLen = len;
                    bestL = l;
                }

                char leftChar = s[l];
                if (leftChar < 128)
                {
                    window[leftChar]--;
                    if (need[leftChar] > 0 && window[leftChar] < need[leftChar])
                        formed--;
                }
                l++;
            }
        }

        return bestLen == int.MaxValue ? string.Empty : s.Substring(bestL, bestLen);
    }
}
