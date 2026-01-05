# Construct Binary Tree from Preorder and Inorder Traversal

    **Pattern:** Recursion + index map

    ## Question (in my own words)
    Given preorder and inorder traversal arrays of a binary tree, reconstruct and return the tree.

    ## Best approach
    Preorder gives root first. Use a dictionary to map inorder value->index for O(1). Recurse on inorder slices: left subtree size determines how to split preorder. Use a moving preorder index for efficiency.

    ## Complexity
    - Time: O(n)
    - Space: O(n) (map + recursion)

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
