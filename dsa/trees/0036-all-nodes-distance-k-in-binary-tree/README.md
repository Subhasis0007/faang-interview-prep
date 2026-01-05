# All Nodes Distance K in Binary Tree

    **Pattern:** Parent map + BFS from target

    ## Question (in my own words)
    Given a binary tree, a target node, and integer k, return all node values at distance k from target.

    ## Best approach
    Convert tree to an undirected graph by recording parent pointers via DFS/BFS. Then BFS starting from target for k layers, tracking visited nodes. Collect nodes at level k.

    ## Complexity
    - Time: O(n)
    - Space: O(n)

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
