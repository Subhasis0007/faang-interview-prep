using System.Collections.Generic;

public class Solution
{
    public int LongestConsecutive(int[] nums)
    {
        var set = new HashSet<int>(nums);
        int best = 0;

        foreach (var x in set)
        {
            if (!set.Contains(x - 1))
            {
                int len = 1;
                int cur = x;
                while (set.Contains(cur + 1))
                {
                    cur++;
                    len++;
                }
                if (len > best) best = len;
            }
        }

        return best;
    }
}
