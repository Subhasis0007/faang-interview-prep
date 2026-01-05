using System.Collections.Generic;
using System.Text;

public class Solution
{
    public string AlienOrder(string[] words)
    {
        var graph = new Dictionary<char, HashSet<char>>();
        var indeg = new Dictionary<char, int>();

        // initialize nodes
        foreach (var w in words)
        {
            foreach (char ch in w)
            {
                if (!graph.ContainsKey(ch)) graph[ch] = new HashSet<char>();
                if (!indeg.ContainsKey(ch)) indeg[ch] = 0;
            }
        }

        // build edges from adjacent pairs
        for (int i = 0; i < words.Length - 1; i++)
        {
            string a = words[i];
            string b = words[i + 1];

            // invalid: prefix order (e.g., "abc" before "ab")
            if (a.Length > b.Length && a.StartsWith(b)) return string.Empty;

            int len = a.Length < b.Length ? a.Length : b.Length;
            for (int k = 0; k < len; k++)
            {
                if (a[k] != b[k])
                {
                    char u = a[k], v = b[k];
                    if (graph[u].Add(v))
                        indeg[v] = indeg[v] + 1;
                    break;
                }
            }
        }

        // Kahn's BFS
        var q = new Queue<char>();
        foreach (var kv in indeg)
            if (kv.Value == 0) q.Enqueue(kv.Key);

        var sb = new StringBuilder();
        while (q.Count > 0)
        {
            char u = q.Dequeue();
            sb.Append(u);

            foreach (char v in graph[u])
            {
                indeg[v]--;
                if (indeg[v] == 0) q.Enqueue(v);
            }
        }

        return sb.Length == indeg.Count ? sb.ToString() : string.Empty;
    }
}
