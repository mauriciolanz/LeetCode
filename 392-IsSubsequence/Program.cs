using System;

/// <summary>
/// Day 2 - String
/// https://leetcode.com/study-plan/leetcode-75
/// 392. Is Subsequence
/// https://leetcode.com/problems/is-subsequence/
/// </summary>
namespace IsSubsequence
{ 
    internal class Program
    {
        static void Main(string[] args)
        {
            // Input
            string s = "abc";
            string t = "ahbgdc";
            bool expectedResult = true;

            // Run
            bool result = IsSubsequence(s, t);

            // Output
            Console.WriteLine("Expected result: {0}", expectedResult);
            Console.WriteLine("Real result:     {0}", result);
            Console.ReadLine();
        }

        public static bool IsSubsequence(string s, string t)
        {
            if (s.Length == 0) return true;
            if (t.Length == 0) return false;

            int i = 0;

            for (int j = 0; j < t.Length; j++)
            {
                if(s[i] == t[j])
                {
                    i++;

                    if(s.Length == i)
                        return true;
                }
                else
                {
                    if (s.Length == i)
                        return false;
                }
            }

            return false;
        }
    }
}