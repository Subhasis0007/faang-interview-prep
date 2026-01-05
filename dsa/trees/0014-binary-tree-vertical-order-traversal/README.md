# Binary Tree Vertical Order Traversal

    **Pattern:** BFS with column index

    ## Question (in my own words)
    Return vertical order traversal of a binary tree: group nodes by column from left to right. Within each column, nodes appear top-to-bottom (BFS order).

    ## Best approach
    Do BFS while tracking column for each node (root at col=0). Use Dictionary<col, List<int>>. Track minCol/maxCol during traversal. Finally output columns from minCol to maxCol.

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

> Note: This is **vertical order** (LeetCode 314), not **vertical traversal** (LeetCode 987).

    ## C# Solution (LeetCode signature)
    See `Solution.cs`.
