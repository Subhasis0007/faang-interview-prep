using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public IList<IList<int>> GetSkyline(int[][] buildings)
    {
        var events = new List<(int x, int h)>();
        foreach (var b in buildings)
        {
            events.Add((b[0], -b[2])); // entering
            events.Add((b[1], b[2]));  // leaving
        }

        events.Sort((a, b) =>
        {
            if (a.x != b.x) return a.x.CompareTo(b.x);
            return a.h.CompareTo(b.h);
        });

        // multiset of heights
        var multiset = new SortedDictionary<int, int>();
        Add(multiset, 0);

        int prevMax = 0;
        var res = new List<IList<int>>();

        foreach (var e in events)
        {
            int x = e.x;
            int h = e.h;

            if (h < 0) Add(multiset, -h);
            else Remove(multiset, h);

            int curMax = multiset.Last().Key;
            if (curMax != prevMax)
            {
                res.Add(new List<int> { x, curMax });
                prevMax = curMax;
            }
        }

        return res;
    }

    private void Add(SortedDictionary<int, int> ms, int h)
    {
        if (ms.TryGetValue(h, out int c)) ms[h] = c + 1;
        else ms[h] = 1;
    }

    private void Remove(SortedDictionary<int, int> ms, int h)
    {
        int c = ms[h];
        if (c == 1) ms.Remove(h);
        else ms[h] = c - 1;
    }
}
