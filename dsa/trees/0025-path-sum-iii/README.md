# Path Sum III

    **Pattern:** Prefix sum + hashmap

    ## Question (in my own words)
    Count the number of paths where the sum of values equals targetSum. Paths can start and end anywhere but must go downward.

    ## Best approach
    DFS while maintaining running prefix sum. For current sum S, number of earlier prefixes with value S-targetSum gives number of paths ending here with target sum. Maintain dictionary prefixSum->count; update before/after recursion (backtrack).

    ## Complexity
    - Time: O(n)
    - Space: O(n) worst-case (map)

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
