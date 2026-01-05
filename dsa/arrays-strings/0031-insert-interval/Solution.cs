using System;
using System.Collections.Generic;

public class Solution
{
    public int[][] Insert(int[][] intervals, int[] newInterval)
    {
        var res = new List<int[]>();
        int i = 0;

        // add all intervals before newInterval
        while (i < intervals.Length && intervals[i][1] < newInterval[0])
        {
            res.Add(intervals[i]);
            i++;
        }

        // merge overlaps
        int start = newInterval[0];
        int end = newInterval[1];
        while (i < intervals.Length && intervals[i][0] <= end)
        {
            start = Math.Min(start, intervals[i][0]);
            end = Math.Max(end, intervals[i][1]);
            i++;
        }
        res.Add(new[] { start, end });

        // add the rest
        while (i < intervals.Length)
        {
            res.Add(intervals[i]);
            i++;
        }

        return res.ToArray();
    }
}
