# Binary Tree Tilt

    **Pattern:** Postorder sum + accumulate tilt

    ## Question (in my own words)
    The tilt of a node is |sum(left) - sum(right)|. Return the sum of all node tilts.

    ## Best approach
    Postorder DFS returns subtree sum. At each node compute tilt using leftSum/rightSum and add to global accumulator.

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
