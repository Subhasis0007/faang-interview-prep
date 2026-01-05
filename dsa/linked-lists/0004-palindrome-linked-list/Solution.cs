public class Solution
{
    public bool IsPalindrome(ListNode head)
    {
        if (head == null || head.next == null) return true;

        // 1) find middle (slow)
        var slow = head;
        var fast = head;
        while (fast != null && fast.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;
        }

        // For odd length, slow is at the middle; start reversing from slow
        var second = Reverse(slow);

        // 2) compare halves
        var p1 = head;
        var p2 = second;
        bool ok = true;
        while (p2 != null)
        {
            if (p1.val != p2.val) { ok = false; break; }
            p1 = p1.next;
            p2 = p2.next;
        }

        // 3) optional restore
        Reverse(second);

        return ok;
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
