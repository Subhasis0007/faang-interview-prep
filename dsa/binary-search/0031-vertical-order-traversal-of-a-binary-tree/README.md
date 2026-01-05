# Vertical Order Traversal of a Binary Tree

    **Pattern:** DFS/BFS + sorting by column,row,value

    ## Question (in my own words)
    Return vertical traversal: group nodes by column (x). Within a column, sort by row (y) then by node value.

    ## Best approach
    Traverse tree and collect tuples (col,row,val). Sort tuples by col asc, row asc, val asc. Group by col.

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

    ## C# Solution (LeetCode signature)
    See `Solution.cs`.
