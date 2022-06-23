using System;

/// <summary>
/// Day 5 - Greedy
/// https://leetcode.com/study-plan/leetcode-75
/// 121. Best Time to Buy and Sell Stock
/// https://leetcode.com/problems/best-time-to-buy-and-sell-stock/
/// </summary>
namespace BestTimeToBuyAndSellStock
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Input
            //var input = new int[] { 7, 1, 5, 3, 6, 4 }; // case 1
            var input = new int[] { 7, 6, 4, 3, 1 }; // case 2

            // Run
            var result = MaxProfit(input);

            // Output
            //Console.WriteLine($"Expected output: 5"); // case 1
            Console.WriteLine($"Expected output: 0"); // case 2
            Console.WriteLine("Real output: {0}", result);

            Console.ReadLine();
        }

        public static int MaxProfit(int[] prices)
        {
            int iMinPrice = 0;
            int biggestProfit = 0;

            for (int i = 0; i < prices.Length; i++)
            {
                if (prices[i] < prices[iMinPrice])
                {
                    iMinPrice = i;
                }
                else
                {
                    int profit = prices[i] - prices[iMinPrice];
                    if (iMinPrice < i && profit > biggestProfit)
                        biggestProfit = profit;
                }
            }

            return biggestProfit;
        }
    }
}