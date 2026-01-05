public class Solution
{
    public TreeNode SufficientSubset(TreeNode root, int limit)
    {
        return Prune(root, 0, limit);
    }

    private TreeNode Prune(TreeNode node, int sum, int limit)
    {
        if (node == null) return null;

        sum += node.val;
        if (node.left == null && node.right == null)
        {
            return sum < limit ? null : node;
        }

        node.left = Prune(node.left, sum, limit);
        node.right = Prune(node.right, sum, limit);

        // if both children were pruned, this node becomes leaf
        if (node.left == null && node.right == null)
            return sum < limit ? null : node;

        return node;
    }
}
