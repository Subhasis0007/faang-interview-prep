# Smallest Subtree with all the Deepest Nodes

    **Pattern:** Postorder DFS returning (depth, node)

    ## Question (in my own words)
    Return the smallest subtree containing all the deepest nodes of the binary tree.

    ## Best approach
    Postorder: for each node, compute leftDepth and rightDepth. If equal, this node is LCA of deepest nodes -> return (depth+1, node). If one side deeper, return (depth+1, deeperNode).

    ## Complexity
    - Time: O(n)
    - Space: O(h)

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

> LeetCode: `TreeNode SubtreeWithAllDeepest(TreeNode root)` (LC 865).

    ## C# Solution
    See `Solution.cs`.
