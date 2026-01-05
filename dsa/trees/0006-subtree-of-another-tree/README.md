# Subtree of Another Tree

    **Pattern:** DFS + tree equality check

    ## Question (in my own words)
    Return true if subRoot is a subtree of root (same structure and values).

    ## Best approach
    Traverse root. At each node, if trees match (same-tree check) return true; otherwise continue searching in left and right. Base: if subRoot is null => true; if root null => false.

    ## Complexity
    - Time: O(n*m) worst-case
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
