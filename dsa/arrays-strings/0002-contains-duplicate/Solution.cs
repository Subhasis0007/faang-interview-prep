using System.Collections.Generic;

public class Solution
{
    public bool ContainsDuplicate(int[] nums)
    {
        var set = new HashSet<int>();
        foreach (var x in nums)
            if (!set.Add(x)) return true;
        return false;
    }
}
