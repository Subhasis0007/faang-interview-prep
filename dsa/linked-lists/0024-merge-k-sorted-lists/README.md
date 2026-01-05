# Merge k Sorted Lists

    **Pattern:** Min-heap / priority queue

    ## Question (in my own words)
    Given an array of k sorted linked lists, merge them into one sorted linked list and return it.

    ## Best approach
    Push each list head into a min-heap keyed by node value. Repeatedly pop the smallest node, append it to result, and push its next node. This is optimal: O(N log k) where N is total nodes.

    ## Complexity
    - Time: O(N log k)
    - Space: O(k)

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
