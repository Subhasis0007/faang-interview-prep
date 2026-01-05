public class Solution
{
    public void DeleteNode(ListNode node)
    {
        // node is guaranteed not to be the tail
        node.val = node.next.val;
        node.next = node.next.next;
    }
}
