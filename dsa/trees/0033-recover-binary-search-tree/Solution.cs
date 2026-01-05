public class Solution
{
    private TreeNode _first;
    private TreeNode _second;
    private TreeNode _prev;

    public void RecoverTree(TreeNode root)
    {
        _first = _second = _prev = null;
        Inorder(root);

        if (_first != null && _second != null)
        {
            int tmp = _first.val;
            _first.val = _second.val;
            _second.val = tmp;
        }
    }

    private void Inorder(TreeNode node)
    {
        if (node == null) return;

        Inorder(node.left);

        if (_prev != null && _prev.val > node.val)
        {
            if (_first == null) _first = _prev;
            _second = node;
        }
        _prev = node;

        Inorder(node.right);
    }
}
