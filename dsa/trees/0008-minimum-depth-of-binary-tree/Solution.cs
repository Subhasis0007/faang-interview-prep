using System.Collections.Generic;

public class Solution
{
    public int MinDepth(TreeNode root)
    {
        if (root == null) return 0;

        var q = new Queue<(TreeNode node, int depth)>();
        q.Enqueue((root, 1));

        while (q.Count > 0)
        {
            var (node, d) = q.Dequeue();
            if (node.left == null && node.right == null) return d;

            if (node.left != null) q.Enqueue((node.left, d + 1));
            if (node.right != null) q.Enqueue((node.right, d + 1));
        }

        return 0;
    }
}
