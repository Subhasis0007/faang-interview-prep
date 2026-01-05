# Swap Nodes in Pairs

    **Pattern:** Iterative pointer manipulation with dummy

    ## Question (in my own words)
    Swap every two adjacent nodes and return head (do not swap values).

    ## Best approach
    Use dummy before head. For each pair (a,b), rewire: prev->b, a->b.next, b->a. Move prev=a.

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
