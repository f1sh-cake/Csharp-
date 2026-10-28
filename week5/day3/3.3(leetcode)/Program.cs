namespace _3._3_leetcode_
{
    public class Solution
    {
        public int MaxProfit(int[] prices)
        {
            if (prices.Length < 2)
            {
                return 0;
            }

            int minPrice = prices[0];
            int maxProfit = 0;

            for (int i = 1; i < prices.Length; i++)
            {
                if (prices[i] < minPrice)
                {
                    minPrice = prices[i];
                }
                else
                { 
                    maxProfit = Math.Max(maxProfit, prices[i] - minPrice);
                }
            }

            return maxProfit;
        }
    }
}
