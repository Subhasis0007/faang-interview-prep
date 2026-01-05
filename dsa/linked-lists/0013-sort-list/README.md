# Sort List

    **Pattern:** Merge sort on linked list

    ## Question (in my own words)
    Sort a linked list in O(n log n) time and O(1) space (ignoring recursion stack).

    ## Best approach
    Use merge sort: split list into halves using slow/fast, recursively sort halves, then merge two sorted lists.

    ## Complexity
    - Time: O(n log n)
    - Space: O(log n) recursion stack

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
