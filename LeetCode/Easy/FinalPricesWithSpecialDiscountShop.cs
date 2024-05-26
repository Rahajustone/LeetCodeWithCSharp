using System;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Diagnostics;
using System.Reflection;
namespace LeetCode.Easy
{
	public class FinalPricesWithSpecialDiscountShop
    {
        // You are given an integer array prices where prices[i] is the price of the ith item in a shop.
        // There is a special discount for items in the shop. If you buy the ith item,
        // then you will receive a discount equivalent to prices[j] where j is the minimum index such that j > i and prices[j] <= prices[i].
        // Otherwise, you will not receive any discount at all.

        // Return an integer array answer where answer[i] is the final price you will pay for the ith item of the shop, considering the special discount.

        // [8,4,6,2,3]
        // [8,14,6,2,3]
        // [0,1,2,3,4]
        public int[] FinalPrices(int[] prices)
        {
            var l = prices.Length;
            var s = new Stack<int>(l);

            for (int i = 0; i < l; i++)
            {
                while (s.Count > 0 && prices[s.Peek()] >= prices[i])
                {
                    prices[s.Pop()] -= prices[i];
                }
                s.Push(i);
            }

            return prices;


        }

        public int[] FinalPricesBruteForce(int[] prices)
        {
            Stack<int> stackPrices = new Stack<int>();
            int[] result = new int[prices.Length];

            for (int i = 0; i < prices.Length; i++)
            {

                result[i] = NextSmallerElement(i, prices);
            }

            return result;  
        }

        public int NextSmallerElement(int index, int[] prices)
        {
            for (int i = (index+1); i < prices.Length; i++)
            {
                if (prices[index] >= prices[i]) return prices[index]-prices[i];
            }

            return prices[index];
        }
    }
}

