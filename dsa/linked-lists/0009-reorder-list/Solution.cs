public class Solution
{
    public void ReorderList(ListNode head)
    {
        if (head == null || head.next == null) return;

        // 1) Find middle
        ListNode slow = head, fast = head;
        while (fast != null && fast.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;
        }

        // 2) Reverse second half
        ListNode second = Reverse(slow);

        // 3) Merge two halves
        ListNode first = head;
        while (second != null && first != null && first != second)
        {
            var t1 = first.next;
            var t2 = second.next;

            first.next = second;
            // If we are about to create a cycle at the end, stop.
            if (t1 == null) break;
            second.next = t1;

            first = t1;
            second = t2;
        }

        // Ensure tail terminates
        if (first != null) first.next = null;
    }

    private ListNode Reverse(ListNode head)
    {
        ListNode prev = null;
        var cur = head;
        while (cur != null)
        {
            var next = cur.next;
            cur.next = prev;
            prev = cur;
            cur = next;
        }
        return prev;
    }
}
