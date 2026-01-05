using System.Collections.Generic;

public class Solution
{
    public bool VerifyPreorder(int[] preorder)
    {
        int low = int.MinValue;
        var st = new Stack<int>();

        foreach (var x in preorder)
        {
            if (x < low) return false;

            while (st.Count > 0 && x > st.Peek())
            {
                low = st.Pop();
            }

            st.Push(x);
        }

        return true;
    }
}
