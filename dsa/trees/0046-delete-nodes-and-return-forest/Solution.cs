using System.Collections.Generic;

public class Solution
{
    public IList<TreeNode> DelNodes(TreeNode root, int[] to_delete)
    {
        var del = new HashSet<int>(to_delete);
        var res = new List<TreeNode>();

        TreeNode dfs(TreeNode node, bool isRoot)
        {
            if (node == null) return null;

            bool deleted = del.Contains(node.val);
            if (isRoot && !deleted) res.Add(node);

            node.left = dfs(node.left, deleted);
            node.right = dfs(node.right, deleted);

            return deleted ? null : node;
        }

        dfs(root, true);
        return res;
    }
}
