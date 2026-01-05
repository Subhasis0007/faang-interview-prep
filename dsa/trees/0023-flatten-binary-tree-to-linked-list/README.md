# Flatten Binary Tree to Linked List

    **Pattern:** Iterative DFS (stack) / rewiring

    ## Question (in my own words)
    Flatten the tree to a linked list in-place following preorder traversal (right pointers as next).

    ## Best approach
    Iterative preorder using a stack. Keep prev pointer. Pop node, connect prev.right=node and prev.left=null. Push right then left so left processed first. In-place rewiring.

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
