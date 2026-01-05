using System;

public class Solution
{
    public int CountNodes(TreeNode root)
    {
        if (root == null) return 0;

        int h = Height(root);
        if (h == 0) return 1;

        int upperCount = (1 << h) - 1; // nodes above last level

        int l = 0, r = (1 << h) - 1; // indices on last level
        while (l <= r)
        {
            int mid = l + (r - l) / 2;
            if (Exists(mid, h, root))
                l = mid + 1;
            else
                r = mid - 1;
        }

        // l is count of existing nodes on last level
        return upperCount + l;
    }

    private int Height(TreeNode node)
    {
        int h = 0;
        while (node.left != null)
        {
            h++;
            node = node.left;
        }
        return h;
    }

    private bool Exists(int idx, int h, TreeNode node)
    {
        int l = 0, r = (1 << h) - 1;
        for (int level = 0; level < h; level++)
        {
            int mid = l + (r - l) / 2;
            if (idx <= mid)
            {
                node = node.left;
                r = mid;
            }
            else
            {
                node = node.right;
                l = mid + 1;
            }
            if (node == null) return false;
        }
        return true;
    }
}
