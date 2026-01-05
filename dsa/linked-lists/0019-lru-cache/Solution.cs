using System.Collections.Generic;

public class LRUCache
{
    private readonly int _capacity;
    private readonly Dictionary<int, LinkedListNode<(int key, int val)>> _map;
    private readonly LinkedList<(int key, int val)> _list; // front = MRU, back = LRU

    public LRUCache(int capacity)
    {
        _capacity = capacity;
        _map = new Dictionary<int, LinkedListNode<(int key, int val)>>(capacity);
        _list = new LinkedList<(int key, int val)>();
    }

    public int Get(int key)
    {
        if (!_map.TryGetValue(key, out var node)) return -1;

        // move to front
        _list.Remove(node);
        _list.AddFirst(node);
        return node.Value.val;
    }

    public void Put(int key, int value)
    {
        if (_map.TryGetValue(key, out var node))
        {
            // update + move to front
            node.Value = (key, value);
            _list.Remove(node);
            _list.AddFirst(node);
            return;
        }

        // insert new
        var newNode = new LinkedListNode<(int key, int val)>((key, value));
        _list.AddFirst(newNode);
        _map[key] = newNode;

        // evict
        if (_map.Count > _capacity)
        {
            var lru = _list.Last;
            _list.RemoveLast();
            _map.Remove(lru.Value.key);
        }
    }
}
