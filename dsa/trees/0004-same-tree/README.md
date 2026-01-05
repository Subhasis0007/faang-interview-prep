# Same Tree

    **Pattern:** DFS recursion

    ## Question (in my own words)
    Given two binary trees, return true if they are structurally identical and all node values are equal.

    ## Best approach
    Recursively compare nodes: if both null => true; if one null => false; else values equal and left/right subtrees are same.

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
