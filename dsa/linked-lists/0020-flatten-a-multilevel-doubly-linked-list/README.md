# Flatten a Multilevel Doubly Linked List

    **Pattern:** DFS with stack / iterative flatten

    ## Question (in my own words)
    Flatten a multilevel doubly linked list so all nodes appear in a single-level doubly list.

    ## Best approach
    Iterate with stack: when node has child, push current.next to stack, splice child as next (set prev pointers), null child. When reach end and stack not empty, pop and continue.

    ## Complexity
    - Time: O(n)
    - Space: O(n) stack worst-case

    > **Note (LeetCode):** For "Flatten a Multilevel Doubly Linked List", LeetCode provides:
> ```csharp
> public class Node {
>     public int val;
>     public Node prev;
>     public Node next;
>     public Node child;
> }
> ```

    ## C# Solution (LeetCode signature)
    See `Solution.cs`.
