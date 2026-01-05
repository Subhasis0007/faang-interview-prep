using System.Collections.Generic;

public class Solution
{
    public IList<IList<int>> PathSum(TreeNode root, int targetSum)
    {
        var res = new List<IList<int>>();
        var path = new List<int>();
        Dfs(root, targetSum, path, res);
        return res;
    }

    private void Dfs(TreeNode node, int remain, List<int> path, List<IList<int>> res)
    {
        if (node == null) return;

        path.Add(node.val);

        if (node.left == null && node.right == null)
        {
            if (remain == node.val)
                res.Add(new List<int>(path));
        }
        else
        {
            int next = remain - node.val;
            Dfs(node.left, next, path, res);
            Dfs(node.right, next, path, res);
        }

        path.RemoveAt(path.Count - 1);
    }
}
