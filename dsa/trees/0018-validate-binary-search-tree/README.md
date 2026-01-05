# Validate Binary Search Tree

    **Pattern:** DFS with bounds (min/max)

    ## Question (in my own words)
    Return true if a binary tree is a valid BST: left subtree < node < right subtree for all nodes.

    ## Best approach
    DFS with (low, high) bounds. For each node, value must be strictly within bounds. Recurse left with high=node.val and right with low=node.val. Use long bounds to avoid overflow.

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

    ## C# Solution (LeetCode signature)
    See `Solution.cs`.
