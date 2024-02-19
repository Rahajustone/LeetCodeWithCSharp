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
        static void Main(string[] args)
        {
            var arr1 = new int[] { 1,3 };
            var arr2 = new int[] {2};
            var res = MedianOfTwoSortedArraysSolutionWithPointers.FindMedianSortedArraysWith(arr1, arr2);
            Console.WriteLine(res);
        }
    }
}
