# Symmetric Tree

    **Pattern:** Mirror DFS

    ## Question (in my own words)
    Return true if a binary tree is symmetric (mirror of itself).

    ## Best approach
    Two-pointer recursion: check if left subtree is a mirror of right subtree. Compare values and cross-children (left.left with right.right, left.right with right.left).

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
