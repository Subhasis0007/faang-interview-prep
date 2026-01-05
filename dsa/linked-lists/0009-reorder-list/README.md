# Reorder List

    **Pattern:** Find middle + reverse second half + merge

    ## Question (in my own words)
    Reorder list L0→L1→…→Ln into L0→Ln→L1→Ln-1→… in-place.

    ## Best approach
    Find middle with fast/slow, split. Reverse second half. Merge alternating nodes from first and reversed second half.

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
