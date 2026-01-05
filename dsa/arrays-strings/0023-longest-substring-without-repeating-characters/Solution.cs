using System.Collections.Generic;

public class Solution
{
    public int LengthOfLongestSubstring(string s)
    {
        var last = new Dictionary<char, int>();
        int left = 0;
        int best = 0;

        for (int right = 0; right < s.Length; right++)
        {
            char c = s[right];
            if (last.TryGetValue(c, out int prev) && prev >= left)
                left = prev + 1;

            last[c] = right;
            int len = right - left + 1;
            if (len > best) best = len;
        }

        return best;
    }
}
