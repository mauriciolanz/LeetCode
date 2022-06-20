using System;

/// <summary>
/// Day 1 - Prefix Sum
/// https://leetcode.com/study-plan/leetcode-75
/// 724. Find Pivot Index
/// https://leetcode.com/problems/find-pivot-index/
/// </summary>
namespace FindPivotIndex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Input
            int[] nums = { 1,7,3,6,5,6 };

            // Run
            int result = PivotIndex(nums);

            // Output
            Console.WriteLine("Expected output: 3"); ;
            Console.WriteLine("Real output: {0}", result); ;
            Console.ReadLine();
        }
        public static int PivotIndex(int[] nums)
        {
            int total = 0;
            int leftSum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                total += nums[i];
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (leftSum == (total - leftSum - nums[i]))
                    return i;

                leftSum += nums[i];
            }

            return -1;
        }
    }
}