# Convert BST to Greater Sum Tree

    **Pattern:** Reverse inorder traversal (right-root-left)

    ## Question (in my own words)
    Given a BST, transform it so that each node’s value becomes the sum of all values greater than or equal to it (Greater Sum Tree). Return the root.

    ## Best approach
    Do reverse inorder traversal (visit larger values first). Maintain a running sum. For each node: sum += node.val; node.val = sum. This preserves BST order and updates in-place.

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

> This corresponds to LeetCode 538 (Convert BST to Greater Tree) / 1038 (BST to Greater Sum Tree).

    ## C# Solution (LeetCode signature)
    See `Solution.cs`.
