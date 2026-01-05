# All Nodes Distance K in Binary Tree

    **Pattern:** Parent map + BFS from target

    ## Question (in my own words)
    Given a tree, a target node, and integer k, return all node values with distance k from target.

    ## Best approach
    Record parent pointers by DFS. Then BFS from target as an undirected graph (left, right, parent). After k layers, collect queue values.

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

> Note: This also appears earlier as medium/hard duplicate; included here as Hard #43.

    ## C# Solution (LeetCode signature)
    See `Solution.cs`.
