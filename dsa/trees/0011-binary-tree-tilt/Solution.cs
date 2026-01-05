using System;

public class Solution
{
    private int _tilt;

    public int FindTilt(TreeNode root)
    {
        _tilt = 0;
        Sum(root);
        return _tilt;
    }

    private int Sum(TreeNode node)
    {
        if (node == null) return 0;
        int left = Sum(node.left);
        int right = Sum(node.right);
        _tilt += Math.Abs(left - right);
        return left + right + node.val;
    }
}
