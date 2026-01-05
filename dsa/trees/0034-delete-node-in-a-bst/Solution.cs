public class Solution
{
    public TreeNode DeleteNode(TreeNode root, int key)
    {
        if (root == null) return null;

        if (key < root.val)
        {
            root.left = DeleteNode(root.left, key);
        }
        else if (key > root.val)
        {
            root.right = DeleteNode(root.right, key);
        }
        else
        {
            // found
            if (root.left == null) return root.right;
            if (root.right == null) return root.left;

            // two children: replace with successor
            TreeNode succ = Min(root.right);
            root.val = succ.val;
            root.right = DeleteNode(root.right, succ.val);
        }

        return root;
    }

    private TreeNode Min(TreeNode node)
    {
        while (node.left != null) node = node.left;
        return node;
    }
}
