# Odd Even Linked List

    **Pattern:** Re-link odd and even chains

    ## Question (in my own words)
    Group all odd index nodes followed by even index nodes (1-indexed), preserving relative order.

    ## Best approach
    Maintain odd and even pointers. Rewire odd.next = even.next and even.next = odd.next accordingly. Finally connect odd tail to even head.

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
