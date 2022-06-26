using System;

/// <summary>
/// Day 7 - Binary Search
/// https://leetcode.com/study-plan/leetcode-75
/// 278. First Bad Version
/// https://leetcode.com/problems/first-bad-version/
/// </summary>
namespace FirstBadVersion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Input
            var input = 9;

            // Run
            int result = FirstBadVersion(input);

            // Output
            Console.WriteLine("Expected result: {0}", 5);
            Console.WriteLine("Real result:     {0}", result.ToString());
            Console.ReadLine();
        }
        public static int FirstBadVersion(int n)
        {
            int left = 1;
            int right = n;

            while(left < right)
            {
                int pivot = left + ((right-left)/2);

                if (IsBadVersion(pivot))
                {
                    right = pivot;
                }
                else
                {
                    left = pivot + 1;
                }
            }

            return left;
        }

        public static bool IsBadVersion(int version)
        {
            if (version >= 5)
                return true;

            return false;
        }
    }
}