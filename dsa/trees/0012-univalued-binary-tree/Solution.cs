public class Solution
{
    public bool IsUnivalTree(TreeNode root)
    {
        if (root == null) return true;
        int v = root.val;
        return Check(root, v);
    }

    private bool Check(TreeNode node, int v)
    {
        if (node == null) return true;
        if (node.val != v) return false;
        return Check(node.left, v) && Check(node.right, v);
    }
}
