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
            string[] arr = new string[] { "5", "2", "C", "D", "+" };

            var a = new BaseballGameSolution();
            var res = a.CalPoints(arr);

            Console.WriteLine(res);


        }
    }
}
