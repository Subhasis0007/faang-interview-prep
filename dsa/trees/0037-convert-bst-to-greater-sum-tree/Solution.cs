public class Solution
{
    private int _sum;

    public TreeNode BstToGst(TreeNode root)
    {
        _sum = 0;
        RevInorder(root);
        return root;
    }

    private void RevInorder(TreeNode node)
    {
        if (node == null) return;
        RevInorder(node.right);
        _sum += node.val;
        node.val = _sum;
        RevInorder(node.left);
    }
}
