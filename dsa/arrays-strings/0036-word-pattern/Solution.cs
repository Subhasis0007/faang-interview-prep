using System.Collections.Generic;

public class Solution
{
    public bool WordPattern(string pattern, string s)
    {
        var words = s.Split(' ');
        if (pattern.Length != words.Length) return false;

        var p2w = new Dictionary<char, string>();
        var w2p = new Dictionary<string, char>();

        for (int i = 0; i < pattern.Length; i++)
        {
            char p = pattern[i];
            string w = words[i];

            if (p2w.TryGetValue(p, out var mappedWord))
            {
                if (mappedWord != w) return false;
            }
            else
            {
                if (w2p.ContainsKey(w)) return false;
                p2w[p] = w;
                w2p[w] = p;
            }
        }

        return true;
    }
}
