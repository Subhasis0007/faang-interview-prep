using System.Collections.Generic;

public class Solution
{
    public IList<int> RightSideView(TreeNode root)
    {
        var res = new List<int>();
        if (root == null) return res;

        var q = new Queue<TreeNode>();
        q.Enqueue(root);

        while (q.Count > 0)
        {
            int size = q.Count;
            for (int i = 0; i < size; i++)
            {
                var node = q.Dequeue();
                if (node.left != null) q.Enqueue(node.left);
                if (node.right != null) q.Enqueue(node.right);

                if (i == size - 1) res.Add(node.val);
            }
        }

        return res;
    }
}
