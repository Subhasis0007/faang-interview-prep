# Remove Duplicates from Sorted List

    **Pattern:** Single pass pointer skipping

    ## Question (in my own words)
    Given the head of a sorted linked list, delete all duplicates so each element appears once.

    ## Best approach
    Walk with a pointer `cur`. If `cur.val == cur.next.val`, skip next (`cur.next = cur.next.next`), else advance `cur`.

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
