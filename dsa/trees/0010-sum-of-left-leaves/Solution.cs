public class Solution
{
    public int SumOfLeftLeaves(TreeNode root)
    {
        return Dfs(root, false);
    }

    private int Dfs(TreeNode node, bool isLeft)
    {
        if (node == null) return 0;
        if (node.left == null && node.right == null)
            return isLeft ? node.val : 0;

        return Dfs(node.left, true) + Dfs(node.right, false);
    }
}
