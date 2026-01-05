# Trim a Binary Search Tree

    **Pattern:** BST recursion using bounds

    ## Question (in my own words)
    Given the root of a BST and bounds low/high, trim the tree so that all nodes values lie in [low, high]. Return the new root.

    ## Best approach
    Use BST property: if node.val < low, discard left and return trim(node.right). If node.val > high, discard right and return trim(node.left). Otherwise trim both children and keep node.

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
