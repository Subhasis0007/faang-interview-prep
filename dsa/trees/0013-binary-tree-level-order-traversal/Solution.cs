using System.Collections.Generic;

public class Solution
{
    public IList<IList<int>> LevelOrder(TreeNode root)
    {
        var res = new List<IList<int>>();
        if (root == null) return res;

        var q = new Queue<TreeNode>();
        q.Enqueue(root);

        while (q.Count > 0)
        {
            int size = q.Count;
            var level = new List<int>(size);

            for (int i = 0; i < size; i++)
            {
                var node = q.Dequeue();
                level.Add(node.val);
                if (node.left != null) q.Enqueue(node.left);
                if (node.right != null) q.Enqueue(node.right);
            }

            res.Add(level);
        }

        return res;
    }
}
