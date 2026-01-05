# Binary Tree Zigzag Level Order Traversal

    **Pattern:** BFS + direction toggle

    ## Question (in my own words)
    Return zigzag level order traversal: level 0 left->right, level 1 right->left, and so on.

    ## Best approach
    BFS by level. Collect values in a list; if direction is right-to-left, fill list from end or reverse after collecting. Toggle direction each level.

    ## Complexity
    - Time: O(n)
    - Space: O(n)

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
