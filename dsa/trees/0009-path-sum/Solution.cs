public class Solution
{
    public bool HasPathSum(TreeNode root, int targetSum)
    {
        if (root == null) return false;

        if (root.left == null && root.right == null)
            return targetSum == root.val;

        int rem = targetSum - root.val;
        return HasPathSum(root.left, rem) || HasPathSum(root.right, rem);
    }
}
