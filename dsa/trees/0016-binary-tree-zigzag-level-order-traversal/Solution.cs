using System.Collections.Generic;

public class Solution
{
    public IList<IList<int>> ZigzagLevelOrder(TreeNode root)
    {
        var res = new List<IList<int>>();
        if (root == null) return res;

        var q = new Queue<TreeNode>();
        q.Enqueue(root);
        bool leftToRight = true;

        while (q.Count > 0)
        {
            int size = q.Count;
            var level = new int[size];

            for (int i = 0; i < size; i++)
            {
                var node = q.Dequeue();
                int idx = leftToRight ? i : (size - 1 - i);
                level[idx] = node.val;

                if (node.left != null) q.Enqueue(node.left);
                if (node.right != null) q.Enqueue(node.right);
            }

            res.Add(new List<int>(level));
            leftToRight = !leftToRight;
        }

        return res;
    }
}
