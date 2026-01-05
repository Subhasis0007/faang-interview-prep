# Binary Tree Right Side View

    **Pattern:** BFS level-order (take last node each level)

    ## Question (in my own words)
    Return the values of the nodes you can see when looking at the binary tree from the right side.

    ## Best approach
    BFS by levels. For each level, the last node dequeued (or first if traverse right-first) is visible. Append it to result.

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

    ## C# Solution (LeetCode signature)
    See `Solution.cs`.
