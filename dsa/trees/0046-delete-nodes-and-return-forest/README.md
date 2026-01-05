# Delete Nodes And Return Forest

    **Pattern:** DFS + set of deletions

    ## Question (in my own words)
    Given a binary tree root and a list to_delete, delete those nodes and return the forest (list of remaining tree roots).

    ## Best approach
    Use a HashSet for deletions. DFS returns the node after deletions. If current node is deleted, add its non-null children as new roots, and return null to parent. Start with root: if not deleted, include it.

    ## Complexity
    - Time: O(n)
    - Space: O(n) for set + recursion

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

> LeetCode: `IList<TreeNode> DelNodes(TreeNode root, int[] to_delete)` (LC 1110).

    ## C# Solution
    See `Solution.cs`.
