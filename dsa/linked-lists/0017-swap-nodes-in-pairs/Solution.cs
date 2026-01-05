public class Solution
{
    public ListNode SwapPairs(ListNode head)
    {
        var dummy = new ListNode(0, head);
        var prev = dummy;

        while (prev.next != null && prev.next.next != null)
        {
            var a = prev.next;
            var b = a.next;

            // swap
            prev.next = b;
            a.next = b.next;
            b.next = a;

            prev = a;
        }

        return dummy.next;
    }
}
