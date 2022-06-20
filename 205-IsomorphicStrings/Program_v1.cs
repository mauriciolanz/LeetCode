using System;

/// <summary>
/// Day 2 - String
/// https://leetcode.com/study-plan/leetcode-75
/// 205. Isomorphic Strings
/// https://leetcode.com/problems/isomorphic-strings/
/// </summary>
namespace IsomorphicStrings
{
    internal class Program_v1
    {
        static void Main_v1(string[] args)
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
            if(s.Length == t.Length)
            {
                string substringS = "";
                string substringT = "";

                for (int i = 0; i < s.Length; i++)
                {
                    var positions = new List<int>();
                    bool sHasRepeatedChar = false;
                    bool tHasRepeatedChar = false;

                    if (substringS.Contains(s[i]))
                    {
                        for(int j=0; j < substringS.Length; j++)
                        {
                            if(substringS[j] == s[i])
                            {
                                positions.Add(j);
                            }
                        }

                        sHasRepeatedChar = true;
                    }

                    if (substringT.Contains(t[i]))
                    {
                        tHasRepeatedChar = true;

                        foreach(int j in positions)
                        {
                            if (substringT[j] != t[i])
                                return false;
                        }
                    }

                    if (sHasRepeatedChar != tHasRepeatedChar)
                        return false;

                    substringS += s[i];
                    substringT += t[i];
                }

                return true;
            }

            return false;
        }
    }
}