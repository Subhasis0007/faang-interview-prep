using System;

public class Solution
{
    public int ClosestValue(TreeNode root, double target)
    {
        int closest = root.val;
        var cur = root;

        while (cur != null)
        {
            if (Math.Abs(cur.val - target) < Math.Abs(closest - target))
                closest = cur.val;

            cur = target < cur.val ? cur.left : cur.right;
        }

        return closest;
    }
}
