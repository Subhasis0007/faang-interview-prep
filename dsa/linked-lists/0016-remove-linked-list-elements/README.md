# Remove Linked List Elements

    **Pattern:** Dummy head + skip nodes

    ## Question (in my own words)
    Remove all nodes with value val and return new head.

    ## Best approach
    Use dummy head to simplify deletions including head. Iterate with prev pointer and skip nodes with matching value.

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
