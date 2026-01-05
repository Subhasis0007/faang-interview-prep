# Inorder Successor in BST

    **Pattern:** BST property traversal

    ## Question (in my own words)
    Given the root of a BST and a node p, return its inorder successor (smallest node greater than p). If none, return null.

    ## Best approach
    Traverse from root. If p.val < root.val, root is a candidate successor; go left. Else go right. This finds the lowest ancestor greater than p. (If p has right subtree, this still works by moving right then going left as needed.)

    ## Complexity
    - Time: O(h)
    - Space: O(1)

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

> **Note:** LeetCode 285 is premium; signature typically `TreeNode InorderSuccessor(TreeNode root, TreeNode p)`.

    ## C# Solution (LeetCode signature)
    See `Solution.cs`.
