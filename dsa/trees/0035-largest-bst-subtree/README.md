# Largest BST Subtree

    **Pattern:** Postorder DP returning BST info

    ## Question (in my own words)
    Return the size (number of nodes) of the largest subtree of a binary tree that is a BST.

    ## Best approach
    Postorder returns for each node: whether subtree is BST, its size, and its min/max values. A node forms BST if left and right are BST and left.max < node.val < right.min. Track global best size.

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

> **Note:** This is LeetCode 333 (premium). Signature typically `int LargestBSTSubtree(TreeNode root)`.

    ## C# Solution (LeetCode signature)
    See `Solution.cs`.
