using System.Collections.Generic;

public class Solution
{
    public IList<int> DistanceK(TreeNode root, TreeNode target, int k)
    {
        var parent = new Dictionary<TreeNode, TreeNode>();
        Build(root, null, parent);

        var q = new Queue<TreeNode>();
        var seen = new HashSet<TreeNode>();
        q.Enqueue(target);
        seen.Add(target);

        int dist = 0;
        while (q.Count > 0)
        {
            int size = q.Count;
            if (dist == k)
            {
                var res = new List<int>(size);
                while (q.Count > 0) res.Add(q.Dequeue().val);
                return res;
            }

            for (int i = 0; i < size; i++)
            {
                var node = q.Dequeue();
                if (node.left != null && seen.Add(node.left)) q.Enqueue(node.left);
                if (node.right != null && seen.Add(node.right)) q.Enqueue(node.right);
                if (parent.TryGetValue(node, out var p) && p != null && seen.Add(p)) q.Enqueue(p);
            }
            dist++;
        }

        return new List<int>();
    }

    private void Build(TreeNode node, TreeNode par, Dictionary<TreeNode, TreeNode> parent)
    {
        if (node == null) return;
        parent[node] = par;
        Build(node.left, node, parent);
        Build(node.right, node, parent);
    }
}
