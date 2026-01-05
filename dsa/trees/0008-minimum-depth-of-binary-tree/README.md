# Minimum Depth of Binary Tree

    **Pattern:** BFS level-order

    ## Question (in my own words)
    Return the minimum depth from root to the nearest leaf node.

    ## Best approach
    Use BFS. The first time you encounter a leaf (no children), return its level. BFS guarantees minimum depth.

    ## Complexity
    - Time: O(n)
    - Space: O(n) (queue)

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
