# Middle of the Linked List

    **Pattern:** Fast/slow pointers

    ## Question (in my own words)
    Return the middle node of a linked list. If even length, return the second middle.

    ## Best approach
    Use slow and fast pointers; slow moves 1 step, fast moves 2. When fast reaches end, slow is at the middle (second middle for even).

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
