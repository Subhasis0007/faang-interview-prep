public class Solution
{
    public bool IsSubtree(TreeNode root, TreeNode subRoot)
    {
        if (subRoot == null) return true;
        if (root == null) return false;

        if (Same(root, subRoot)) return true;
        return IsSubtree(root.left, subRoot) || IsSubtree(root.right, subRoot);
    }

    private bool Same(TreeNode a, TreeNode b)
    {
        if (a == null && b == null) return true;
        if (a == null || b == null) return false;
        if (a.val != b.val) return false;
        return Same(a.left, b.left) && Same(a.right, b.right);
    }
}
