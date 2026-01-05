# Kth Smallest Element in a BST

    **Pattern:** Inorder traversal (iterative)

    ## Question (in my own words)
    Return the k-th smallest value in a BST.

    ## Best approach
    Inorder traversal yields sorted order. Use an explicit stack to traverse iteratively and decrement k each time you visit a node. When k==0 return node.val.

    ## Complexity
    - Time: O(h+k) up to O(n)
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
