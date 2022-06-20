using System;

/// <summary>
/// Day 2 - String
/// https://leetcode.com/study-plan/leetcode-75
/// 205. Isomorphic Strings
/// https://leetcode.com/problems/isomorphic-strings/
/// </summary>
namespace IsomorphicStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Input
            string s = "paper";
            string t = "title";
            bool expectedResult = true;

            // Run
            bool result = IsIsomorphic(s, t);

            // Output
            Console.WriteLine("Expected result: {0}", expectedResult);
            Console.WriteLine("Real result:     {0}", result);
            Console.ReadLine();
        }

        public static bool IsIsomorphic(string s, string t)
        {
            if (s.Length == t.Length)
            {
                var mapping = new Dictionary<char, char>();

                for (int i = 0; i < s.Length; i++)
                {
                    if(mapping.ContainsKey(s[i]))
                    {
                        if (mapping[s[i]] != t[i])
                            return false;
                    }
                    else if(mapping.ContainsValue(t[i]))
                    {
                        // Contains the value, but it isn't isomorphic since it doesn't contain the key
                        return false;
                    }
                    else
                    {
                        mapping.Add(s[i], t[i]);
                    }
                }

                return true;
            }

            return false;
        }
    }
}
