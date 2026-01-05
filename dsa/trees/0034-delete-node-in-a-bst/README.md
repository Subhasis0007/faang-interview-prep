# Delete Node in a BST

    **Pattern:** BST recursion (delete & reconnect)

    ## Question (in my own words)
    Given BST root and key, delete the node with that key and return the new root.

    ## Best approach
    Search recursively. When found: if one child is null, return the other. If both exist, replace node value with inorder successor (min of right subtree), then delete that successor from right subtree.

    ## Complexity
    - Time: O(h)
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
