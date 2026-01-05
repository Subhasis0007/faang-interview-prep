public class Solution
{
    public ListNode Partition(ListNode head, int x)
    {
        var beforeDummy = new ListNode(0);
        var afterDummy = new ListNode(0);
        var before = beforeDummy;
        var after = afterDummy;

        var cur = head;
        while (cur != null)
        {
            if (cur.val < x)
            {
                before.next = cur;
                before = before.next;
            }
            else
            {
                after.next = cur;
                after = after.next;
            }
            cur = cur.next;
        }

        after.next = null;
        before.next = afterDummy.next;
        return beforeDummy.next;
    }
}
