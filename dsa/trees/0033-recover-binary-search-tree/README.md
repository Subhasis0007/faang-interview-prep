# Recover Binary Search Tree

    **Pattern:** Inorder traversal detect swapped nodes

    ## Question (in my own words)
    A BST has exactly two nodes swapped by mistake. Recover the tree without changing its structure.

    ## Best approach
    Inorder traversal of BST should be sorted. Track previous node. When prev.val > cur.val, we found an inversion. First inversion sets `first=prev`, `second=cur`. Second inversion updates `second=cur`. After traversal, swap values of first and second.

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
