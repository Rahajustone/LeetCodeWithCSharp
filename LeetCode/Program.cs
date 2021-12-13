using LeetCode.Easy;
using LeetCode.Hard;
using LeetCode.Medium;
using LeetCode.Others;
using System;
using System.Collections.Generic;

namespace LeetCode
{
    class Program
    {
        public static string ReverseString(string str)
        {
            string res = "";
            for (int i = str.Length - 1; i >= 0; i--)
            {
                res += str[i];
            }

            return res;
        }

        static void Main(string[] args)
        {
            var res = LongestCommonPrefixSolution.LongestCommonPrefix(new string[] { "flower", "flow", "flight" });
            Console.WriteLine(res);
        }
    }
}
