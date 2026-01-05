# Binary Tree Maximum Path Sum

    **Pattern:** Postorder DFS + global maximum

    ## Question (in my own words)
    Return the maximum path sum in a binary tree. Path may start and end anywhere but must follow parent-child links; it may turn at one node.

    ## Best approach
    Postorder: compute gain from each child = max(0, gain(child)). Best path through node = node.val + leftGain + rightGain. Update global best. Return to parent: node.val + max(leftGain,rightGain).

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

> Note: This also appears in earlier parts of the guide; included here as Hard #41.

    ## C# Solution (LeetCode signature)
    See `Solution.cs`.
