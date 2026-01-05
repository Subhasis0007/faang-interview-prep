public class Solution
{
    private int _cams;

    public int MinCameraCover(TreeNode root)
    {
        _cams = 0;
        int state = Dfs(root);
        if (state == 0) _cams++; // root needs camera
        return _cams;
    }

    // 0 = needs camera, 1 = has camera, 2 = covered
    private int Dfs(TreeNode node)
    {
        if (node == null) return 2; // null is covered

        int left = Dfs(node.left);
        int right = Dfs(node.right);

        if (left == 0 || right == 0)
        {
            _cams++;
            return 1;
        }

        if (left == 1 || right == 1)
            return 2;

        return 0;
    }
}
