using System.Collections.Generic;

public class TimeMap
{
    private readonly Dictionary<string, List<(int t, string v)>> _map = new();

    public TimeMap() { }

    public void Set(string key, string value, int timestamp)
    {
        if (!_map.TryGetValue(key, out var list))
        {
            list = new List<(int, string)>();
            _map[key] = list;
        }
        // LeetCode guarantees timestamps for the same key are strictly increasing
        list.Add((timestamp, value));
    }

    public string Get(string key, int timestamp)
    {
        if (!_map.TryGetValue(key, out var list)) return string.Empty;

        int l = 0, r = list.Count - 1;
        int ans = -1;
        while (l <= r)
        {
            int mid = l + (r - l) / 2;
            if (list[mid].t <= timestamp)
            {
                ans = mid;
                l = mid + 1;
            }
            else
            {
                r = mid - 1;
            }
        }

        return ans == -1 ? string.Empty : list[ans].v;
    }
}
