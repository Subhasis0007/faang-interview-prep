# Serialize and Deserialize Binary Tree

    **Pattern:** Preorder DFS with null markers

    ## Question (in my own words)
    Design an algorithm to serialize a binary tree to a string and deserialize it back.

    ## Best approach
    Serialize using preorder traversal and a sentinel for null (e.g., "#"). Join tokens with commas. Deserialize by reading tokens in order and rebuilding recursively: if token is "#", return null; else create node and build left then right.

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

> **Note:** LeetCode expects a `Codec` class with `serialize` and `deserialize` methods.

    ## C# Solution (LeetCode signature)
    See `Solution.cs`.
