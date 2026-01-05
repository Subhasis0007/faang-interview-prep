public class Solution
{
    public ListNode SortList(ListNode head)
    {
        if (head == null || head.next == null) return head;

        // split
        ListNode prev = null;
        ListNode slow = head, fast = head;
        while (fast != null && fast.next != null)
        {
            prev = slow;
            slow = slow.next;
            fast = fast.next.next;
        }
        prev.next = null;

        var left = SortList(head);
        var right = SortList(slow);

        return Merge(left, right);
    }

    private ListNode Merge(ListNode a, ListNode b)
    {
        var dummy = new ListNode(0);
        var tail = dummy;

        while (a != null && b != null)
        {
            if (a.val <= b.val)
            {
                tail.next = a;
                a = a.next;
            }
            else
            {
                tail.next = b;
                b = b.next;
            }
            tail = tail.next;
        }

        tail.next = a ?? b;
        return dummy.next;
    }
}
