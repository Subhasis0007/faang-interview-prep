# Reverse Nodes in k-Group

    **Pattern:** Iterative group reversal

    ## Question (in my own words)
    Given a linked list, reverse the nodes of the list k at a time and return its modified list. Nodes not forming a full group remain as-is.

    ## Best approach
    Use a dummy head. For each group, first check there are k nodes. Then reverse k nodes in-place using pointer reversal and reconnect group boundaries. Repeat.

    ## Complexity
    - Time: O(n)
    - Space: O(1)

    > **Note (LeetCode):** `ListNode` is provided by the platform.
> Typical definition:
> ```csharp
> public class ListNode {
>     public int val;
>     public ListNode next;
>     public ListNode(int val=0, ListNode next=null) {
>         this.val = val;
>         this.next = next;
>     }
> }
> ```

    ## C# Solution (LeetCode signature)
    See `Solution.cs`.
