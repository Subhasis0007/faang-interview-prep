using System.Collections.Generic;

public class Solution
{
    public ListNode MergeKLists(ListNode[] lists)
    {
        if (lists == null || lists.Length == 0) return null;

        var pq = new PriorityQueue<ListNode, int>();
        foreach (var node in lists)
        {
            if (node != null)
                pq.Enqueue(node, node.val);
        }

        var dummy = new ListNode(0);
        var tail = dummy;

        while (pq.Count > 0)
        {
            var node = pq.Dequeue();
            tail.next = node;
            tail = tail.next;

            if (node.next != null)
                pq.Enqueue(node.next, node.next.val);
        }

        tail.next = null;
        return dummy.next;
    }
}
