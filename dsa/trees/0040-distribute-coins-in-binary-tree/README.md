# Distribute Coins in Binary Tree

    **Pattern:** Postorder DFS (balance flow)

    ## Question (in my own words)
    You have n nodes and n coins total in a binary tree. In one move, you can move one coin between a node and its parent. Return the minimum number of moves to make every node have exactly one coin.

    ## Best approach
    Postorder DFS returns the balance of coins to pass to parent: balance = node.val + leftBalance + rightBalance - 1. Positive means extra coins to send up; negative means coins needed from parent. Moves accumulate as |leftBalance| + |rightBalance| at each node.

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
