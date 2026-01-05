// LeetCode provides an API: int guess(int num);
//   -1: my guess is higher
//    1: my guess is lower
//    0: correct

public class Solution : GuessGame
{
    public int GuessNumber(int n)
    {
        int l = 1, r = n;
        while (l <= r)
        {
            int mid = l + (r - l) / 2;
            int g = guess(mid);
            if (g == 0) return mid;
            if (g < 0) r = mid - 1;
            else l = mid + 1;
        }
        return -1;
    }
}
