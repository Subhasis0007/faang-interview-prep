# Count Good Nodes in Binary Tree

    **Pattern:** DFS with max-so-far

    ## Question (in my own words)
    A node X is good if on the path from root to X, no node has a value greater than X. Return number of good nodes.

    ## Best approach
    DFS passing the maximum value seen so far. Node is good if node.val >= maxSoFar. Update max and recurse.

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
