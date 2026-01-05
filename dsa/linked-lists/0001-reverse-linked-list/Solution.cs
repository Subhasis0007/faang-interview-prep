public class Solution
{
    public ListNode ReverseList(ListNode head)
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
