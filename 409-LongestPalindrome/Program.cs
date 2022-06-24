using System;

/// <summary>
/// Day 5 - Greedy
/// https://leetcode.com/study-plan/leetcode-75
/// 409. Longest Palindrome
/// https://leetcode.com/problems/longest-palindrome/
/// </summary>
namespace LongestPalindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Input
            var input = "abccccdd";

            // Run
            var result = LongestPalindrome(input);

            // Output
            Console.WriteLine("Expected output: 7");
            Console.WriteLine("Real output: {0}", result);

            Console.ReadLine();
        }

        public static int LongestPalindrome(string s)
        {
            if (s.Length == 1) return 1;

            // 128 is the number of possible characters
            int[] count = new int[128];

            for(int i = 0; i < s.Length; i++)
                count[s[i]]++;

            int longestPalindrome = 0;
            bool thereIsSingleChar = false;
            foreach(var entry in count)
            {
                if(entry > 0)
                {
                    if (entry == 1 || entry % 2 != 0)
                        thereIsSingleChar = true;

                    if (entry / 2 > 0)
                        longestPalindrome += (entry - (entry % 2));
                }
            }

            if (thereIsSingleChar)
                longestPalindrome++;

            return longestPalindrome;
        }
    }
}