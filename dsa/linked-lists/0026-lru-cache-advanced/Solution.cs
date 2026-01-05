using System.Collections.Generic;

public class LRUCache
{
    private class Node
    {
        public int Key;
        public int Val;
        public Node Prev;
        public Node Next;

        public Node(int key, int val)
        {
            Key = key;
            Val = val;
        }
    }

    private readonly int _cap;
    private readonly Dictionary<int, Node> _map;
    private readonly Node _head; // sentinel (MRU side)
    private readonly Node _tail; // sentinel (LRU side)

    public LRUCache(int capacity)
    {
        _cap = capacity;
        _map = new Dictionary<int, Node>(capacity);
        _head = new Node(0, 0);
        _tail = new Node(0, 0);
        _head.Next = _tail;
        _tail.Prev = _head;
    }

    public int Get(int key)
    {
        if (!_map.TryGetValue(key, out var node)) return -1;
        MoveToFront(node);
        return node.Val;
    }

    public void Put(int key, int value)
    {
        if (_map.TryGetValue(key, out var node))
        {
            node.Val = value;
            MoveToFront(node);
            return;
        }

        var n = new Node(key, value);
        _map[key] = n;
        AddToFront(n);

        if (_map.Count > _cap)
        {
            var lru = _tail.Prev;
            Remove(lru);
            _map.Remove(lru.Key);
        }
    }

    private void MoveToFront(Node node)
    {
        Remove(node);
        AddToFront(node);
    }

    private void AddToFront(Node node)
    {
        node.Prev = _head;
        node.Next = _head.Next;
        _head.Next.Prev = node;
        _head.Next = node;
    }

    private void Remove(Node node)
    {
        node.Prev.Next = node.Next;
        node.Next.Prev = node.Prev;
        node.Prev = null;
        node.Next = null;
    }
}
