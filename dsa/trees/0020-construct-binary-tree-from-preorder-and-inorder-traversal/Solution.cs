using System.Collections.Generic;

public class Solution
{
    private int _preIdx;
    private int[] _pre;
    private Dictionary<int, int> _inPos;

    public TreeNode BuildTree(int[] preorder, int[] inorder)
    {
        _pre = preorder;
        _preIdx = 0;
        _inPos = new Dictionary<int, int>(inorder.Length);
        for (int i = 0; i < inorder.Length; i++)
            _inPos[inorder[i]] = i;

        return Build(0, inorder.Length - 1);
    }

    private TreeNode Build(int inL, int inR)
    {
        if (inL > inR) return null;

        int rootVal = _pre[_preIdx++];
        var root = new TreeNode(rootVal);
        int mid = _inPos[rootVal];

        root.left = Build(inL, mid - 1);
        root.right = Build(mid + 1, inR);

        return root;
    }
}
