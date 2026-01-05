# Copy List with Random Pointer

    **Pattern:** HashMap old->new (2-pass)

    ## Question (in my own words)
    Deep copy a linked list where each node has next and random pointers.

    ## Best approach
    First pass: create clone node for each original and store mapping. Second pass: wire next and random using mapping. Return clone head.

    ## Complexity
    - Time: O(n)
    - Space: O(n)

    > **Note (LeetCode):** For "Copy List with Random Pointer", LeetCode provides:
> ```csharp
> public class Node {
>     public int val;
>     public Node next;
>     public Node random;
>     public Node(int _val) { val = _val; }
> }
> ```

    ## C# Solution (LeetCode signature)
    See `Solution.cs`.
