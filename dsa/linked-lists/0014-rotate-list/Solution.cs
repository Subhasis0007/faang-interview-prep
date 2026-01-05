public class Solution
{
    public ListNode RotateRight(ListNode head, int k)
    {
        if (head == null || head.next == null || k == 0) return head;

        // get length and tail
        int len = 1;
        var tail = head;
        while (tail.next != null)
        {
            tail = tail.next;
            len++;
        }

        k %= len;
        if (k == 0) return head;

        // make circular
        tail.next = head;

        int stepsToNewTail = len - k;
        var newTail = head;
        for (int i = 1; i < stepsToNewTail; i++)
            newTail = newTail.next;

        var newHead = newTail.next;
        newTail.next = null;
        return newHead;
    }
}
