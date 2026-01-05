public class Solution
{
    public bool IsHappy(int n)
    {
        int slow = n;
        int fast = Next(n);

        while (fast != 1 && slow != fast)
        {
            slow = Next(slow);
            fast = Next(Next(fast));
        }
        return fast == 1;
    }

    private int Next(int x)
    {
        int sum = 0;
        while (x > 0)
        {
            int d = x % 10;
            sum += d * d;
            x /= 10;
        }
        return sum;
    }
}
