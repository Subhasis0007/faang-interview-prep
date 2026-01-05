public class Solution
{
    public bool IsValidBST(TreeNode root)
    {
        return Valid(root, long.MinValue, long.MaxValue);
    }

    private bool Valid(TreeNode node, long low, long high)
    {
        if (node == null) return true;
        if (node.val <= low || node.val >= high) return false;
        return Valid(node.left, low, node.val) && Valid(node.right, node.val, high);
    }
}
