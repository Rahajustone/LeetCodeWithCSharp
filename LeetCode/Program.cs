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
            var nums = new int[] { 0, 0, 0, 0, 0, 0 };

            var res = new ThreeSomeSolution();
            var result = res.ThreeSum(nums);

            foreach (var item in result)
            {
                foreach (var i in item)
                {
                    Console.Write(i);

                }

                Console.WriteLine();
            }



        }
    }
}
