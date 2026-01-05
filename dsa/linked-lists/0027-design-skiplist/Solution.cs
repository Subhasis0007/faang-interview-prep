using System;

public class Skiplist
{
    private const int MaxLevel = 16;
    private const double P = 0.5;

    private class Node
    {
        public int Val;
        public Node[] Next;
        public Node(int val, int level)
        {
            Val = val;
            Next = new Node[level];
        }
    }

    private readonly Node _head;
    private int _level;
    private readonly Random _rng;

    public Skiplist()
    {
        _head = new Node(int.MinValue, MaxLevel);
        _level = 1;
        _rng = new Random();
    }

    public bool Search(int target)
    {
        var cur = _head;
        for (int i = _level - 1; i >= 0; i--)
        {
            while (cur.Next[i] != null && cur.Next[i].Val < target)
                cur = cur.Next[i];
        }
        cur = cur.Next[0];
        return cur != null && cur.Val == target;
    }

    public void Add(int num)
    {
        var update = new Node[MaxLevel];
        var cur = _head;

        for (int i = _level - 1; i >= 0; i--)
        {
            while (cur.Next[i] != null && cur.Next[i].Val < num)
                cur = cur.Next[i];
            update[i] = cur;
        }

        int lvl = RandomLevel();
        if (lvl > _level)
        {
            for (int i = _level; i < lvl; i++)
                update[i] = _head;
            _level = lvl;
        }

        var node = new Node(num, lvl);
        for (int i = 0; i < lvl; i++)
        {
            node.Next[i] = update[i].Next[i];
            update[i].Next[i] = node;
        }
    }

    public bool Erase(int num)
    {
        var update = new Node[MaxLevel];
        var cur = _head;

        for (int i = _level - 1; i >= 0; i--)
        {
            while (cur.Next[i] != null && cur.Next[i].Val < num)
                cur = cur.Next[i];
            update[i] = cur;
        }

        cur = cur.Next[0];
        if (cur == null || cur.Val != num) return false;

        for (int i = 0; i < _level; i++)
        {
            if (update[i].Next[i] != cur) break;
            update[i].Next[i] = cur.Next[i];
        }

        while (_level > 1 && _head.Next[_level - 1] == null)
            _level--;

        return true;
    }

    private int RandomLevel()
    {
        int lvl = 1;
        while (lvl < MaxLevel && _rng.NextDouble() < P)
            lvl++;
        return lvl;
    }
}
