# Path Sum

    **Pattern:** DFS recursion

    ## Question (in my own words)
    Return true if the tree has a root-to-leaf path such that adding up all the values equals targetSum.

    ## Best approach
    DFS subtracting node.val from remaining sum. If at leaf, check remaining == node.val (or remaining after subtract == 0).

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
