using System;

public class Solution
{
    public bool IsBalanced(TreeNode root)
    {
        return Height(root) != -1;
    }

    private int Height(TreeNode node)
    {
        if (node == null) return 0;

        int lh = Height(node.left);
        if (lh == -1) return -1;

        int rh = Height(node.right);
        if (rh == -1) return -1;

        if (Math.Abs(lh - rh) > 1) return -1;
        return 1 + Math.Max(lh, rh);
    }
}
