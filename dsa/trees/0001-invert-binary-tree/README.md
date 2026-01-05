# Invert Binary Tree

    **Pattern:** DFS recursion / swap children

    ## Question (in my own words)
    Invert a binary tree: for every node, swap its left and right child.

    ## Best approach
    Traverse the tree (DFS). At each node, swap left/right pointers, then invert the children. Return the root.

    ## Complexity
    - Time: O(n)
    - Space: O(h) recursion stack

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
