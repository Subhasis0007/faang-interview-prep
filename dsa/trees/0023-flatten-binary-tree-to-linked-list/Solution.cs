using System.Collections.Generic;

public class Solution
{
    public void Flatten(TreeNode root)
    {
        if (root == null) return;

        var st = new Stack<TreeNode>();
        st.Push(root);
        TreeNode prev = null;

        while (st.Count > 0)
        {
            var cur = st.Pop();

            if (prev != null)
            {
                prev.left = null;
                prev.right = cur;
            }

            // push right first so left is processed first
            if (cur.right != null) st.Push(cur.right);
            if (cur.left != null) st.Push(cur.left);

            prev = cur;
        }
    }
}
