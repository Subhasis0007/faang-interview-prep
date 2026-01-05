using System;
using System.Collections.Generic;

public class Solution
{
    public int[] MinInterval(int[][] intervals, int[] queries)
    {
        Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]));

        int qn = queries.Length;
        var qarr = new (int val, int idx)[qn];
        for (int i = 0; i < qn; i++) qarr[i] = (queries[i], i);
        Array.Sort(qarr, (x, y) => x.val.CompareTo(y.val));

        var pq = new PriorityQueue<(int end, int len), int>(); // element=(end,len), priority=len
        int[] ans = new int[qn];
        Array.Fill(ans, -1);

        int iInt = 0;
        for (int qi = 0; qi < qn; qi++)
        {
            int q = qarr[qi].val;

            while (iInt < intervals.Length && intervals[iInt][0] <= q)
            {
                int start = intervals[iInt][0];
                int end = intervals[iInt][1];
                int len = end - start + 1;
                pq.Enqueue((end, len), len);
                iInt++;
            }

            while (pq.Count > 0 && pq.Peek().end < q)
                pq.Dequeue();

            if (pq.Count > 0)
                ans[qarr[qi].idx] = pq.Peek().len;
        }

        return ans;
    }
}
