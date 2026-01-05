# Add Two Numbers

    **Pattern:** Simulation with carry

    ## Question (in my own words)
    Add two numbers represented by reversed linked lists and return sum as a linked list.

    ## Best approach
    Iterate both lists, sum digits with carry, create new nodes for result. Continue while nodes remain or carry > 0.

    ## Complexity
    - Time: O(max(m,n))
    - Space: O(max(m,n)) for output

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
