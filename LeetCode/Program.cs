﻿using LeetCode.Easy;
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
            Queue<int> ints = new Queue<int>();
            ints.Enqueue(1);
            ints.Enqueue(2);
            ints.Enqueue(3);
            Console.WriteLine(ints.Dequeue());

        }
    }
}
