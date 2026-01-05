# Kth Smallest Element in a BST

    **Pattern:** Iterative inorder traversal

    ## Question (in my own words)
    Return the k-th smallest element in a BST.

    ## Best approach
    Inorder traversal gives sorted order. Use a stack, push left chain, pop, decrement k; when k==0 return node.val. Then move to right subtree.

    ## Complexity
    - Time: O(h + k)
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
