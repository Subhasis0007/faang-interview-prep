# Linked List Cycle

    **Pattern:** Floyd cycle detection (fast/slow)

    ## Question (in my own words)
    Return true if a linked list has a cycle.

    ## Best approach
    Use two pointers: slow moves 1 step, fast moves 2 steps. If there is a cycle, they will meet. If fast reaches null, no cycle.

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
