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
            var res = new ImplementStackUsingQueues();
            res.Push(1);
            res.Push(2);
            res.Push(3);
            res.Push(4);

            Console.WriteLine(res.Pop());
            Console.WriteLine(res.Pop());
            Console.WriteLine(res.Top());


        }
    }
}
