using System;

public class Solution
{
    public int GoodNodes(TreeNode root)
    {
        return Dfs(root, int.MinValue);
    }

    private int Dfs(TreeNode node, int maxSoFar)
    {
        if (node == null) return 0;
        int good = node.val >= maxSoFar ? 1 : 0;
        int nextMax = Math.Max(maxSoFar, node.val);
        return good + Dfs(node.left, nextMax) + Dfs(node.right, nextMax);
    }
}
