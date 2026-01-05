# Intersection of Two Linked Lists

    **Pattern:** Two pointers switching heads

    ## Question (in my own words)
    Return the node where two singly linked lists intersect, or null if they do not.

    ## Best approach
    Use two pointers a and b. Traverse each list; when reaching end, switch to the other list's head. They will meet at intersection or both become null.

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
