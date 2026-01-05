# Insufficient Nodes in Root to Leaf Paths

    **Pattern:** DFS prune (postorder)

    ## Question (in my own words)
    Given a tree and limit, remove all insufficient nodes: a node is insufficient if every root-to-leaf path through it has sum < limit. Return pruned tree root.

    ## Best approach
    DFS with running sum. Recurse to children; after pruning, if a node becomes a leaf and pathSum < limit, return null. Otherwise keep node with possibly pruned children.

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
