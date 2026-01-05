using System.Collections.Generic;

public class Solution
{
    private int _postIdx;
    private int[] _post;
    private Dictionary<int, int> _inPos;

    public TreeNode BuildTree(int[] inorder, int[] postorder)
    {
        _post = postorder;
        _postIdx = postorder.Length - 1;

        _inPos = new Dictionary<int, int>(inorder.Length);
        for (int i = 0; i < inorder.Length; i++)
            _inPos[inorder[i]] = i;

        return Build(0, inorder.Length - 1);
    }

    private TreeNode Build(int inL, int inR)
    {
        if (inL > inR) return null;

        int rootVal = _post[_postIdx--];
        var root = new TreeNode(rootVal);
        int mid = _inPos[rootVal];

        // build right first because we're consuming postorder from the end
        root.right = Build(mid + 1, inR);
        root.left = Build(inL, mid - 1);

        return root;
    }
}
