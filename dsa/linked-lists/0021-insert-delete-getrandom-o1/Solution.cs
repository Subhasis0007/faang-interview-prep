using System;
using System.Collections.Generic;

public class RandomizedSet
{
    private readonly Dictionary<int, int> _pos = new Dictionary<int, int>();
    private readonly List<int> _vals = new List<int>();
    private readonly Random _rng = new Random();

    public RandomizedSet() { }

    public bool Insert(int val)
    {
        if (_pos.ContainsKey(val)) return false;
        _pos[val] = _vals.Count;
        _vals.Add(val);
        return true;
    }

    public bool Remove(int val)
    {
        if (!_pos.TryGetValue(val, out int idx)) return false;

        int lastVal = _vals[_vals.Count - 1];
        _vals[idx] = lastVal;
        _pos[lastVal] = idx;

        _vals.RemoveAt(_vals.Count - 1);
        _pos.Remove(val);
        return true;
    }

    public int GetRandom()
    {
        int i = _rng.Next(_vals.Count);
        return _vals[i];
    }
}
