# Reverse Linked List

    **Pattern:** Pointer reversal (iterative)

    ## Question (in my own words)
    Reverse a singly linked list and return the new head.

    ## Best approach
    Iterate through nodes and reverse pointers: keep `prev`, `cur`, store `next`, set `cur.next = prev`, then advance.

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
