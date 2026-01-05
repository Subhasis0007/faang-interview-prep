public class Solution
{
    public TreeNode SubtreeWithAllDeepest(TreeNode root)
    {
        return Dfs(root).node;
    }

    private (int depth, TreeNode node) Dfs(TreeNode cur)
    {
        if (cur == null) return (0, null);

        var left = Dfs(cur.left);
        var right = Dfs(cur.right);

        if (left.depth == right.depth)
            return (left.depth + 1, cur);

        return left.depth > right.depth
            ? (left.depth + 1, left.node)
            : (right.depth + 1, right.node);
    }
}
