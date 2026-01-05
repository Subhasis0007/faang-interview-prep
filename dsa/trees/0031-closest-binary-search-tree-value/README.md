# Closest Binary Search Tree Value

    **Pattern:** BST iterative search

    ## Question (in my own words)
    Given a BST and a target (double), return the value in the BST that is closest to target.

    ## Best approach
    Iterate down the BST. Keep the closest value seen. If target < node.val go left else go right. This works due to BST ordering.

    ## Complexity
    - Time: O(h)
    - Space: O(1)

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

> **Note:** This is LeetCode 270 (premium). Signature typically `int ClosestValue(TreeNode root, double target)`.

    ## C# Solution (LeetCode signature)
    See `Solution.cs`.
