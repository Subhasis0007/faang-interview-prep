using System.Collections.Generic;

public class BSTIterator
{
    private readonly Stack<TreeNode> _st = new Stack<TreeNode>();

    public BSTIterator(TreeNode root)
    {
        PushLeft(root);
    }

    public int Next()
    {
        var node = _st.Pop();
        if (node.right != null) PushLeft(node.right);
        return node.val;
    }

    public bool HasNext()
    {
        return _st.Count > 0;
    }

    private void PushLeft(TreeNode node)
    {
        while (node != null)
        {
            _st.Push(node);
            node = node.left;
        }
    }
}
