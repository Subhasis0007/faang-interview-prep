using System;

public class Solution
{
    private int _best;

    public int LargestBSTSubtree(TreeNode root)
    {
        _best = 0;
        Dfs(root);
        return _best;
    }

    private (bool isBst, int size, int min, int max) Dfs(TreeNode node)
    {
        if (node == null)
            return (true, 0, int.MaxValue, int.MinValue);

        var left = Dfs(node.left);
        var right = Dfs(node.right);

        if (left.isBst && right.isBst && left.max < node.val && node.val < right.min)
        {
            int size = left.size + right.size + 1;
            _best = Math.Max(_best, size);
            int mn = Math.Min(left.min, node.val);
            int mx = Math.Max(right.max, node.val);
            return (true, size, mn, mx);
        }

        return (false, 0, 0, 0);
    }
}
