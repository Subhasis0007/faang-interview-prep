# Partition List

    **Pattern:** Two lists (before/after) + concatenate

    ## Question (in my own words)
    Partition list so that nodes < x come before nodes >= x, preserving relative order.

    ## Best approach
    Build two lists using dummy heads: one for < x and one for >= x. Append nodes accordingly and connect beforeTail.next=afterHead; terminate afterTail.next=null.

    ## Complexity
    - Time: O(n)
    - Space: O(1) extra

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
