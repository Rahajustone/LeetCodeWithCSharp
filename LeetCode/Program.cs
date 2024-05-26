using LeetCode.Easy;
using LeetCode.Hard;
using LeetCode.Medium;
using LeetCode.Others;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Net.NetworkInformation;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LeetCode
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine( "hellow");
            var test = new RemoveOutermostParentheses();
            string chars = "((()))";

            var result = test.RemoveOuterParentheses(chars);

            Console.WriteLine(result);

        }
    }
}
