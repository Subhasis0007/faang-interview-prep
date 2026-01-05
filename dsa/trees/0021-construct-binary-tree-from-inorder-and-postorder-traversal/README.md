# Construct Binary Tree from Inorder and Postorder Traversal

    **Pattern:** Recursion + hashmap index + postorder pointer

    ## Question (in my own words)
    Given inorder and postorder traversal arrays of a binary tree, reconstruct and return the tree.

    ## Best approach
    Postorder gives root last. Use a dictionary to map inorder value->index. Maintain a moving postIndex starting at end. Build right subtree first (because postorder visits left-right-root). Recurse on inorder ranges.

    ## Complexity
    - Time: O(n)
    - Space: O(n) (map + recursion)

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
