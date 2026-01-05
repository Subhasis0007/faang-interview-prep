public class Solution
{
    public int MaxProfit(int[] prices)
    {
        int minPrice = int.MaxValue;
        int best = 0;
        foreach (var p in prices)
        {
            if (p < minPrice) minPrice = p;
            else
            {
                int profit = p - minPrice;
                if (profit > best) best = profit;
            }
        }
        return best;
    }
}
