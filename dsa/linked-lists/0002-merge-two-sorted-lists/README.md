# Merge Two Sorted Lists

    **Pattern:** Two pointers + dummy head

    ## Question (in my own words)
    Merge two sorted linked lists and return the merged sorted list.

    ## Best approach
    Use a dummy head and tail pointer. Repeatedly pick the smaller head from the two lists, attach it, and advance. Append remainder at end.

    ## Complexity
    - Time: O(m+n)
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
