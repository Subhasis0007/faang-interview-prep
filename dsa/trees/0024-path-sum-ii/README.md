# Path Sum II

    **Pattern:** DFS backtracking

    ## Question (in my own words)
    Return all root-to-leaf paths where the sum of node values equals targetSum.

    ## Best approach
    DFS with backtracking: maintain current path list and remaining sum. When reaching a leaf with remaining == node.val, add a copy of path to results. Backtrack by removing last element.

    ## Complexity
    - Time: O(n) nodes visited, output can be large
    - Space: O(h) path + recursion

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
