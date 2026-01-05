# Remove Nth Node From End of List

    **Pattern:** Two pointers with dummy

    ## Question (in my own words)
    Remove the n-th node from the end of the list and return the head.

    ## Best approach
    Use dummy before head. Move fast n steps ahead, then move slow and fast together until fast reaches end. Remove slow.next.

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
