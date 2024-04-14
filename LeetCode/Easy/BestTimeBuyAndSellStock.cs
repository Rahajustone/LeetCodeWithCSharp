using System;
namespace LeetCode.Easy
{
	public class BestTimeBuyAndSellStock
	{
        public int MaxProfitHardCoded(int[] prices)
        {
            int prevProfit = 0;
            int Maxprofit = 0;
            for (int i = 0; i < prices.Length - 1; i++)
            {
                for (int j = i + 1; j < prices.Length; j++)
                    if (prices[i] < prices[j])
                    {
                        prevProfit = prices[j] - prices[i];
                        if (prevProfit > Maxprofit)
                        {
                            Maxprofit = prevProfit;
                        }
                    }
            }

            return Maxprofit;
        }
    }
}

