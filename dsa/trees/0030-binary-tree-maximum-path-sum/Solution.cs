using System;

public class Solution
{
    private int _best;

    public int MaxPathSum(TreeNode root)
    {
        _best = int.MinValue;
        Gain(root);
        return _best;
    }

    private int Gain(TreeNode node)
    {
        if (node == null) return 0;

        int left = Math.Max(0, Gain(node.left));
        int right = Math.Max(0, Gain(node.right));

        int through = node.val + left + right;
        if (through > _best) _best = through;

        return node.val + Math.Max(left, right);
    }
}
