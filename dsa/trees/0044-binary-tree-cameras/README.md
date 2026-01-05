# Binary Tree Cameras

    **Pattern:** Greedy postorder with 3 states

    ## Question (in my own words)
    Place cameras on nodes so every node is monitored (camera monitors parent, self, children). Return minimum cameras.

    ## Best approach
    Postorder classify each node state: 0=needs camera, 1=has camera, 2=covered. If any child needs camera => place camera here (state 1). If any child has camera => this node covered (state 2). Else children are covered but no camera => this node needs camera (state 0). After traversal, if root needs camera add one.

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
