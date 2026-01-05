# Binary Tree Level Order Traversal

    **Pattern:** BFS (queue)

    ## Question (in my own words)
    Return the level-order traversal of a binary tree (nodes by level, left to right).

    ## Best approach
    Use a queue. For each level, read current queue size, dequeue that many nodes, append values, and enqueue children. Add each level list to result.

    ## Complexity
    - Time: O(n)
    - Space: O(n) (queue)

    > **Note (LeetCode):** `TreeNode` is provided by the platform.
> Typical definition:
> ```csharp
> public class TreeNode {
>     public int val;
>     public TreeNode left;
>     public TreeNode right;
>     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
>         this.val = val;
>         this.left = left;
>         this.right = right;
>     }
> }
> ```

    ## C# Solution (LeetCode signature)
    See `Solution.cs`.
