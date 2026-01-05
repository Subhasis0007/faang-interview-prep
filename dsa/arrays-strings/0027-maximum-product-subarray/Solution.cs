public class Solution
{
    public int MaxProduct(int[] nums)
    {
        int best = nums[0];
        int maxHere = nums[0];
        int minHere = nums[0];

        for (int i = 1; i < nums.Length; i++)
        {
            int x = nums[i];
            if (x < 0)
            {
                int tmp = maxHere;
                maxHere = minHere;
                minHere = tmp;
            }

            maxHere = System.Math.Max(x, x * maxHere);
            minHere = System.Math.Min(x, x * minHere);
            best = System.Math.Max(best, maxHere);
        }

        return best;
    }
}
