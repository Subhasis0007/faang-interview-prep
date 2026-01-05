public class Solution
{
    public bool SearchMatrix(int[][] matrix, int target)
    {
        int m = matrix.Length;
        int n = matrix[0].Length;

        int r = 0;
        int c = n - 1;
        while (r < m && c >= 0)
        {
            int val = matrix[r][c];
            if (val == target) return true;
            if (val > target) c--;
            else r++;
        }

        return false;
    }
}
