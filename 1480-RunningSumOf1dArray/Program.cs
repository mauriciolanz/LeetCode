using System;

/// <summary>
/// Day 1 - Prefix Sum
/// https://leetcode.com/study-plan/leetcode-75
/// 1480. Running Sum of 1d Array
/// https://leetcode.com/problems/running-sum-of-1d-array/
/// </summary>
namespace RunningSumOfArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Input
            var input = new int[] { 1, 2, 3, 4 };

            // Run
            var result = RunningSum(input);

            // Output
            Console.WriteLine($"Expected output: [1,3,6,10]");

            string output = "";
            for (int i = 0; i < result.Length; i++)
                output += (result[i] + " ");

            Console.WriteLine("Real output: {0}", output);
            Console.ReadLine();
        }

        public static int[] RunningSum(int[] nums)
        {
            int[] sums = new int[nums.Length];
            int total = 0;

            for(int index = 0; index < nums.Length; index++)
            {
                total += nums[index];
                sums[index] = total;
            }

            return sums;
        }
    }
}