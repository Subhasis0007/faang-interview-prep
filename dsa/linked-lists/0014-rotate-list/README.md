# Rotate List

    **Pattern:** Make cycle + break

    ## Question (in my own words)
    Rotate the list to the right by k places.

    ## Best approach
    Compute length and tail. Make list circular by tail.next=head. New tail is at (len - k%len - 1) from head; new head is newTail.next. Break the circle.

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
