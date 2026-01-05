using System.Collections.Generic;

public class Solution
{
    public Node CopyRandomList(Node head)
    {
        if (head == null) return null;

        var map = new Dictionary<Node, Node>();
        var cur = head;
        while (cur != null)
        {
            map[cur] = new Node(cur.val);
            cur = cur.next;
        }

        cur = head;
        while (cur != null)
        {
            var clone = map[cur];
            clone.next = cur.next != null ? map[cur.next] : null;
            clone.random = cur.random != null ? map[cur.random] : null;
            cur = cur.next;
        }

        return map[head];
    }
}
