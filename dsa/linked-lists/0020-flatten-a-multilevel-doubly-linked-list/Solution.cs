using System.Collections.Generic;

public class Solution
{
    public Node Flatten(Node head)
    {
        if (head == null) return null;

        var stack = new Stack<Node>();
        var cur = head;

        while (cur != null)
        {
            if (cur.child != null)
            {
                if (cur.next != null) stack.Push(cur.next);

                // splice child
                cur.next = cur.child;
                cur.child.prev = cur;
                cur.child = null;
            }

            if (cur.next == null && stack.Count > 0)
            {
                var nxt = stack.Pop();
                cur.next = nxt;
                nxt.prev = cur;
            }

            cur = cur.next;
        }

        return head;
    }
}
