using System.Collections.Generic;

public class StreamChecker
{
    private class Node
    {
        public Node[] Next = new Node[26];
        public bool IsEnd;
    }

    private readonly Node _root = new Node();
    private readonly List<char> _stream = new List<char>();
    private readonly int _maxLen;

    public StreamChecker(string[] words)
    {
        int max = 0;
        foreach (var w in words)
        {
            if (w.Length > max) max = w.Length;
            InsertReversed(w);
        }
        _maxLen = max;
    }

    private void InsertReversed(string word)
    {
        var cur = _root;
        for (int i = word.Length - 1; i >= 0; i--)
        {
            int idx = word[i] - 'a';
            cur.Next[idx] ??= new Node();
            cur = cur.Next[idx];
        }
        cur.IsEnd = true;
    }

    public bool Query(char letter)
    {
        _stream.Add(letter);
        if (_stream.Count > _maxLen)
            _stream.RemoveAt(0);

        var cur = _root;
        for (int i = _stream.Count - 1; i >= 0; i--)
        {
            int idx = _stream[i] - 'a';
            cur = cur.Next[idx];
            if (cur == null) return false;
            if (cur.IsEnd) return true;
        }

        return false;
    }
}
