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
            int res = ContainerWithMostWaterSolution.MaxArea(new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 });
            Console.WriteLine(res);
        }
    }
}
