public class Solution
{
    public bool IsPalindrome(int x)
    {
        if (x < 0) return false;
        if (x % 10 == 0 && x != 0) return false;

        int reversedHalf = 0;
        while (x > reversedHalf)
        {
            int digit = x % 10;
            reversedHalf = reversedHalf * 10 + digit;
            x /= 10;
        }

        // For odd digit count, drop the middle digit from reversedHalf
        return x == reversedHalf || x == reversedHalf / 10;
    }
}
