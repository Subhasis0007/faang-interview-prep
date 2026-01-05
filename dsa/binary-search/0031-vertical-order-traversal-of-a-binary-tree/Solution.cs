using System.Collections.Generic;

public class Solution
{
    public IList<IList<int>> VerticalTraversal(TreeNode root)
    {
        var list = new List<(int col, int row, int val)>();
        Dfs(root, 0, 0, list);

        list.Sort((a, b) =>
        {
            int c = a.col.CompareTo(b.col);
            if (c != 0) return c;
            c = a.row.CompareTo(b.row);
            if (c != 0) return c;
            return a.val.CompareTo(b.val);
        });

        var res = new List<IList<int>>();
        int i = 0;
        while (i < list.Count)
        {
            int col = list[i].col;
            var colList = new List<int>();
            while (i < list.Count && list[i].col == col)
            {
                colList.Add(list[i].val);
                i++;
            }
            res.Add(colList);
        }
        return res;
    }

    private void Dfs(TreeNode node, int row, int col, List<(int col, int row, int val)> list)
    {
        if (node == null) return;
        list.Add((col, row, node.val));
        Dfs(node.left, row + 1, col - 1, list);
        Dfs(node.right, row + 1, col + 1, list);
    }
}
