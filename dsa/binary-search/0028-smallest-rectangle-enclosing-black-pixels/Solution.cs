public class Solution
{
    public int MinArea(char[][] image, int x, int y)
    {
        int m = image.Length;
        int n = image[0].Length;

        int left = SearchCols(image, 0, y, true);
        int right = SearchCols(image, y + 1, n, false);
        int top = SearchRows(image, 0, x, true);
        int bottom = SearchRows(image, x + 1, m, false);

        return (right - left) * (bottom - top);
    }

    private int SearchCols(char[][] img, int lo, int hi, bool wantBlack)
    {
        while (lo < hi)
        {
            int mid = lo + (hi - lo) / 2;
            bool has = ColHasBlack(img, mid);
            if (has == wantBlack) hi = mid;
            else lo = mid + 1;
        }
        return lo;
    }

    private int SearchRows(char[][] img, int lo, int hi, bool wantBlack)
    {
        while (lo < hi)
        {
            int mid = lo + (hi - lo) / 2;
            bool has = RowHasBlack(img, mid);
            if (has == wantBlack) hi = mid;
            else lo = mid + 1;
        }
        return lo;
    }

    private bool ColHasBlack(char[][] img, int col)
    {
        for (int i = 0; i < img.Length; i++)
            if (img[i][col] == '1') return true;
        return false;
    }

    private bool RowHasBlack(char[][] img, int row)
    {
        for (int j = 0; j < img[0].Length; j++)
            if (img[row][j] == '1') return true;
        return false;
    }
}
