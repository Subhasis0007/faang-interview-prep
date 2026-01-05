public class Solution
{
    public ListNode RemoveElements(ListNode head, int val)
    {
        var dummy = new ListNode(0, head);
        var prev = dummy;

        while (prev.next != null)
        {
            if (prev.next.val == val)
                prev.next = prev.next.next;
            else
                prev = prev.next;
        }

        return dummy.next;
    }
}
