# Lowest Common Ancestor of a Binary Tree

    **Pattern:** DFS recursion

    ## Question (in my own words)
    Given a binary tree and two nodes p and q, return their lowest common ancestor (deepest node that has both as descendants).

    ## Best approach
    DFS: if current node is null or equals p/q, return it. Recurse left and right. If both sides return non-null, current is LCA. Else return whichever side is non-null.

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
