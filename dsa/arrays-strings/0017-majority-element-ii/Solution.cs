using System.Collections.Generic;

public class Solution
{
    public IList<int> MajorityElement(int[] nums)
    {
        int cand1 = 0, cand2 = 1; // initialize differently
        int count1 = 0, count2 = 0;

        foreach (var x in nums)
        {
            if (x == cand1) count1++;
            else if (x == cand2) count2++;
            else if (count1 == 0) { cand1 = x; count1 = 1; }
            else if (count2 == 0) { cand2 = x; count2 = 1; }
            else { count1--; count2--; }
        }

        // verify
        count1 = 0; count2 = 0;
        foreach (var x in nums)
        {
            if (x == cand1) count1++;
            else if (x == cand2) count2++;
        }

        var res = new List<int>(2);
        int threshold = nums.Length / 3;
        if (count1 > threshold) res.Add(cand1);
        if (count2 > threshold) res.Add(cand2);
        return res;
    }
}
