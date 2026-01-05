using System.Collections.Generic;

public class Solution
{
    public IList<IList<int>> VerticalOrder(TreeNode root)
    {
        var res = new List<IList<int>>();
        if (root == null) return res;

        var map = new Dictionary<int, List<int>>();
        int minCol = 0, maxCol = 0;

        var q = new Queue<(TreeNode node, int col)>();
        q.Enqueue((root, 0));

        while (q.Count > 0)
        {
            var (node, col) = q.Dequeue();
            if (!map.TryGetValue(col, out var list))
            {
                list = new List<int>();
                map[col] = list;
            }
            list.Add(node.val);

            if (node.left != null)
            {
                q.Enqueue((node.left, col - 1));
                if (col - 1 < minCol) minCol = col - 1;
            }
            if (node.right != null)
            {
                q.Enqueue((node.right, col + 1));
                if (col + 1 > maxCol) maxCol = col + 1;
            }
        }

        for (int c = minCol; c <= maxCol; c++)
            res.Add(map[c]);

        return res;
    }
}
