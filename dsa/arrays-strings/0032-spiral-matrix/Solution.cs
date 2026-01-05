using System.Collections.Generic;

public class Solution
{
    public IList<int> SpiralOrder(int[][] matrix)
    {
        int m = matrix.Length;
        int n = matrix[0].Length;
        var res = new List<int>(m * n);

        int top = 0, bottom = m - 1;
        int left = 0, right = n - 1;

        while (top <= bottom && left <= right)
        {
            for (int j = left; j <= right; j++) res.Add(matrix[top][j]);
            top++;

            for (int i = top; i <= bottom; i++) res.Add(matrix[i][right]);
            right--;

            if (top <= bottom)
            {
                for (int j = right; j >= left; j--) res.Add(matrix[bottom][j]);
                bottom--;
            }

            if (left <= right)
            {
                for (int i = bottom; i >= top; i--) res.Add(matrix[i][left]);
                left++;
            }
        }

        return res;
    }
}
