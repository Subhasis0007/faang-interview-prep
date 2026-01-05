# Maximum Depth of Binary Tree

    **Pattern:** DFS recursion

    ## Question (in my own words)
    Return the maximum depth (height) of a binary tree.

    ## Best approach
    Depth of a node = 1 + max(depth(left), depth(right)). Base case: null => 0.

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
