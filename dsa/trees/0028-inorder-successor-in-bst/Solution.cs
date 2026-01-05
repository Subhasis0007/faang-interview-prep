public class Solution
{
    public TreeNode InorderSuccessor(TreeNode root, TreeNode p)
    {
        TreeNode succ = null;
        var cur = root;

        while (cur != null)
        {
            if (p.val < cur.val)
            {
                succ = cur;
                cur = cur.left;
            }
            else
            {
                cur = cur.right;
            }
        }

        return succ;
    }
}
