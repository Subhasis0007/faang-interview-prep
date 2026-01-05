using System;
using System.Collections.Generic;

public class Solution
{
    public IList<IList<string>> GroupAnagrams(string[] strs)
    {
        var map = new Dictionary<string, List<string>>();

        foreach (var s in strs)
        {
            var chars = s.ToCharArray();
            Array.Sort(chars);
            var key = new string(chars);

            if (!map.TryGetValue(key, out var list))
            {
                list = new List<string>();
                map[key] = list;
            }
            list.Add(s);
        }

        var res = new List<IList<string>>(map.Count);
        foreach (var kv in map)
            res.Add(kv.Value);
        return res;
    }
}
