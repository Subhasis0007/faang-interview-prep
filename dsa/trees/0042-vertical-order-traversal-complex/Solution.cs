using System.Collections.Generic;

public class Solution
{
    public IList<IList<int>> VerticalTraversal(TreeNode root)
    {
        var nodes = new List<(int col, int row, int val)>();
        Dfs(root, 0, 0, nodes);

        nodes.Sort((a, b) =>
        {
            int c = a.col.CompareTo(b.col);
            if (c != 0) return c;
            c = a.row.CompareTo(b.row);
            if (c != 0) return c;
            return a.val.CompareTo(b.val);
        });

        var res = new List<IList<int>>();
        int i = 0;
        while (i < nodes.Count)
        {
            int col = nodes[i].col;
            var colList = new List<int>();
            while (i < nodes.Count && nodes[i].col == col)
            {
                colList.Add(nodes[i].val);
                i++;
            }
            res.Add(colList);
        }

        return res;
    }

    private void Dfs(TreeNode node, int row, int col, List<(int col, int row, int val)> nodes)
    {
        if (node == null) return;
        nodes.Add((col, row, node.val));
        Dfs(node.left, row + 1, col - 1, nodes);
        Dfs(node.right, row + 1, col + 1, nodes);
    }
}
