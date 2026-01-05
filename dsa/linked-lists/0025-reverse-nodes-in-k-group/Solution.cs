public class Solution
{
    public ListNode ReverseKGroup(ListNode head, int k)
    {
        if (head == null || k <= 1) return head;

        var dummy = new ListNode(0, head);
        var groupPrev = dummy;

        while (true)
        {
            // 1) Find kth node from groupPrev
            var kth = GetKth(groupPrev, k);
            if (kth == null) break;

            var groupNext = kth.next;

            // 2) Reverse group
            ListNode prev = groupNext;
            var cur = groupPrev.next;
            while (cur != groupNext)
            {
                var tmp = cur.next;
                cur.next = prev;
                prev = cur;
                cur = tmp;
            }

            // 3) Reconnect
            var oldGroupStart = groupPrev.next;
            groupPrev.next = kth;
            groupPrev = oldGroupStart;
        }

        return dummy.next;
    }

    private ListNode GetKth(ListNode start, int k)
    {
        var cur = start;
        for (int i = 0; i < k; i++)
        {
            cur = cur.next;
            if (cur == null) return null;
        }
        return cur;
    }
}
