# Validate Binary Search Tree (Revisit)

    **Pattern:** DFS with bounds (min/max)

    ## Question (in my own words)
    Re-check if a binary tree is a valid BST (strictly increasing inorder / bounds).

    ## Best approach
    Use DFS with (low, high) bounds. A node must satisfy low < node.val < high. Recurse left with high=node.val and right with low=node.val. Use long bounds to avoid overflow.

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

> **Note:** This problem also appeared earlier; this is a duplicate entry in the guide.

    ## C# Solution (LeetCode signature)
    See `Solution.cs`.
