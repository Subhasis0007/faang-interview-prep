# Palindrome Linked List

    **Pattern:** Find middle + reverse second half

    ## Question (in my own words)
    Return true if the linked list is a palindrome.

    ## Best approach
    Find middle using fast/slow. Reverse second half, then compare first half and reversed second half node-by-node. (Optional) restore list by reversing again.

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
