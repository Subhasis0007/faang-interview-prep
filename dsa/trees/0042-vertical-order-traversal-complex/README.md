# Vertical Order Traversal (Complex)

    **Pattern:** DFS collect + sort by (col,row,val)

    ## Question (in my own words)
    Return vertical traversal: columns from left to right. Within a column, nodes sorted by row (top to bottom), and if same row, by value.

    ## Best approach
    Traverse and record tuples (col,row,val). Sort by col asc, row asc, val asc. Group into columns.

    ## Complexity
    - Time: O(n log n)
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

> This corresponds to LeetCode 987 (Vertical Order Traversal of a Binary Tree).

    ## C# Solution (LeetCode signature)
    See `Solution.cs`.
