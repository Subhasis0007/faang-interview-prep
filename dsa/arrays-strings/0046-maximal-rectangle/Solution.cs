using System.Collections.Generic;

public class Solution
{
    public int MaximalRectangle(char[][] matrix)
    {
        if (matrix == null || matrix.Length == 0 || matrix[0].Length == 0)
            return 0;

        int rows = matrix.Length;
        int cols = matrix[0].Length;
        int[] heights = new int[cols];
        int best = 0;

        for (int r = 0; r < rows; r++)
        {
            for (int c = 0; c < cols; c++)
            {
                heights[c] = matrix[r][c] == '1' ? heights[c] + 1 : 0;
            }
            best = System.Math.Max(best, LargestRectangleArea(heights));
        }

        return best;
    }

    private int LargestRectangleArea(int[] heights)
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
