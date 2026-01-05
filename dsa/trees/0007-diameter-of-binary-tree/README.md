# Diameter of Binary Tree

    **Pattern:** DFS postorder computing heights

    ## Question (in my own words)
    Return the diameter (longest path between any two nodes) of a binary tree measured in number of edges.

    ## Best approach
    Postorder DFS returns height of each node. For every node, consider path through it: leftHeight + rightHeight. Track maximum. Return maxDiameter.

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
