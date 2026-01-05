public class Solution
{
    private int _best;

    public int DiameterOfBinaryTree(TreeNode root)
    {
        _best = 0;
        Height(root);
        return _best;
    }

    private int Height(TreeNode node)
    {
        if (node == null) return 0;
        int lh = Height(node.left);
        int rh = Height(node.right);
        int path = lh + rh;
        if (path > _best) _best = path;
        return 1 + (lh > rh ? lh : rh);
    }
}
