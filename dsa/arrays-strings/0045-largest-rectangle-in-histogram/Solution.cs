using System.Collections.Generic;

public class Solution
{
    public int LargestRectangleArea(int[] heights)
    {
        var st = new Stack<int>();
        int best = 0;

        for (int i = 0; i <= heights.Length; i++)
        {
            int cur = (i == heights.Length) ? 0 : heights[i];

            while (st.Count > 0 && cur < heights[st.Peek()])
            {
                int h = heights[st.Pop()];
                int left = st.Count == 0 ? -1 : st.Peek();
                int width = i - left - 1;
                int area = h * width;
                if (area > best) best = area;
            }

            st.Push(i);
        }

        return best;
    }
}
