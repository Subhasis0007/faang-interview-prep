# Binary Tree Right Side View (Revisit)

    **Pattern:** BFS level-order (rightmost per level)

    ## Question (in my own words)
    Return the values visible from the right side of the tree (one per level).

    ## Best approach
    Do BFS by levels. The last node processed in each level is visible from the right. Add its value to result.

    ## Complexity
    - Time: O(n)
    - Space: O(n)

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
