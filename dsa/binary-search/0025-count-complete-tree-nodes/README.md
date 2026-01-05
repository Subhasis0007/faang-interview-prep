# Count Complete Tree Nodes

    **Pattern:** Binary search on last level

    ## Question (in my own words)
    Given a complete binary tree, return the number of nodes.

    ## Best approach
    Compute tree height h (levels-1) by going left. Nodes above last level = 2^h - 1. Binary search how many nodes exist on the last level [0..2^h-1] by checking existence using path bits from root.

    ## Complexity
    - Time: O((log n)^2)
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

    ## C# Solution (LeetCode signature)
    See `Solution.cs`.
