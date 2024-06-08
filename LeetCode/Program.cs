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
            int[] integers = new int[] {1,2,3,4,5,6};
            Queue<int> ints = new Queue<int>(integers);

            Console.WriteLine(ints.Dequeue());
            Console.WriteLine(ints.Dequeue());
            Console.WriteLine(ints.Dequeue());
            Console.WriteLine(ints.Dequeue());
            Console.WriteLine(ints.Dequeue());
            ints.Enqueue(1);
            ints.Enqueue(2);
            Console.WriteLine($"count: {ints.Count}, {ints.Peek()}");


        }
    }
}
