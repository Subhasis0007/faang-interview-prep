# Sum of Left Leaves

    **Pattern:** DFS recursion with flag

    ## Question (in my own words)
    Return the sum of all left leaves in the binary tree.

    ## Best approach
    Traverse DFS. When moving to a left child, mark it as left. If a node is a leaf and marked left, add its value.

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
