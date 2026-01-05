# Binary Search Tree Iterator

    **Pattern:** Inorder traversal with stack

    ## Question (in my own words)
    Implement BSTIterator that iterates over a BST in ascending order with next() and hasNext() in average O(1).

    ## Best approach
    Maintain a stack of left spine nodes. Constructor pushes all left children from root. next() pops top, then pushes left spine of popped node's right child. hasNext() checks stack non-empty.

    ## Complexity
    - Time: Next/HasNext O(1) amortized
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

> **Note:** LeetCode expects class `BSTIterator(TreeNode root)` with `int Next()` and `bool HasNext()`.

    ## C# Solution (LeetCode signature)
    See `Solution.cs`.
