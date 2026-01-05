public class Solution
{
    public int MySqrt(int x)
    {
        if (x < 2) return x;
        long l = 1, r = x / 2;
        int ans = 1;

        while (l <= r)
        {
            long mid = l + (r - l) / 2;
            long sq = mid * mid;
            if (sq == x) return (int)mid;
            if (sq < x)
            {
                ans = (int)mid;
                l = mid + 1;
            }
            else
            {
                r = mid - 1;
            }
        }

        return ans;
    }
}
