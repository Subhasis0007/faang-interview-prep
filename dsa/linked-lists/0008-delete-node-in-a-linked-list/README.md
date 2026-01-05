# Delete Node in a Linked List

    **Pattern:** Copy next node's data

    ## Question (in my own words)
    Delete a node in a singly linked list given only that node (it is not the tail).

    ## Best approach
    Copy the next node's value into current node and bypass the next node: node.val = node.next.val; node.next = node.next.next.

    ## Complexity
    - Time: O(1)
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
