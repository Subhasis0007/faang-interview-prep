using System.Collections.Generic;

public class Solution
{
    public int KthSmallest(TreeNode root, int k)
    {
        var st = new Stack<TreeNode>();
        var cur = root;

        while (cur != null || st.Count > 0)
        {
            while (cur != null)
            {
                st.Push(cur);
                cur = cur.left;
            }

            cur = st.Pop();
            k--;
            if (k == 0) return cur.val;
            cur = cur.right;
        }

        return -1;
    }
}
