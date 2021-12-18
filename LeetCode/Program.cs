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
            Console.WriteLine( 1/2);
            //var res = BinarySearchSolution.Search(new int[] { 5 }, 5);
            //Console.WriteLine(res);
        }
    }
}
