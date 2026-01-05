# Binary Tree Maximum Path Sum

    **Pattern:** Postorder DFS with global best

    ## Question (in my own words)
    Return the maximum path sum in a binary tree. A path can start and end at any nodes but must go downwards via parent-child connections (can turn once).

    ## Best approach
    Postorder DFS returns the maximum gain from node to parent: node.val + max(0, leftGain, rightGain). For each node, the best path passing through it is node.val + max(0,leftGain) + max(0,rightGain). Track a global maximum.

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
