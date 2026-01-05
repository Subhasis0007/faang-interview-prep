using System;

public class Solution
{
    private int _moves;

    public int DistributeCoins(TreeNode root)
    {
        _moves = 0;
        Dfs(root);
        return _moves;
    }

    private int Dfs(TreeNode node)
    {
        if (node == null) return 0;

        int left = Dfs(node.left);
        int right = Dfs(node.right);

        _moves += Math.Abs(left) + Math.Abs(right);

        // balance to parent
        return node.val + left + right - 1;
    }
}
