using LeetCode.Easy;
using LeetCode.Hard;
using LeetCode.Medium;
using LeetCode.Others;
using System;
using System.Collections.Generic;

namespace LeetCode
{
    record Test
    {
        public int Age { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RemoveElementSolution.RemoveElement(new int[] { 3, 2, 2, 3 }, 3));


            //var t = new Test()
            //{
            //    Age =17
            //};
            //t.Age = 20;

            //var a = t with { Age = 15};

            //Console.WriteLine(t.Age);
            //Console.WriteLine(a.Age);
            //Console.WriteLine("tets");

            //var arr1 = new int[] { 1,3 };
            //var arr2 = new int[] {2};
            //var res = MedianOfTwoSortedArraysSolutionWithPointers.FindMedianSortedArraysWith(arr1, arr2);
            //Console.WriteLine(res);
        }
    }
}
