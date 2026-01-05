# Balanced Binary Tree

    **Pattern:** DFS postorder with early exit

    ## Question (in my own words)
    Return true if a binary tree is height-balanced: for every node, heights of subtrees differ by at most 1.

    ## Best approach
    Postorder DFS returns height; if a subtree is unbalanced, return -1 as a signal to stop. Tree is balanced iff helper(root) != -1.

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
