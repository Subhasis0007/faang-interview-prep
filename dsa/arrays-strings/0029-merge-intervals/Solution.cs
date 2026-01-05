using System;
using System.Collections.Generic;

public class Solution
{
    public int[][] Merge(int[][] intervals)
    {
        Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]));

        var merged = new List<int[]>();
        int[] cur = intervals[0];
        merged.Add(cur);

        for (int i = 1; i < intervals.Length; i++)
        {
            var next = intervals[i];
            if (next[0] <= cur[1])
            {
                // overlap
                cur[1] = Math.Max(cur[1], next[1]);
            }
            else
            {
                cur = next;
                merged.Add(cur);
            }
        }

        return merged.ToArray();
    }
}
