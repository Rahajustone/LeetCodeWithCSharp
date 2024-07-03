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

namespace LeetCode;
public class Program
{
    static void Main(string[] args)
    {
        int[] newInt = new int[] { 0, 1, 1, 1, 0, 0 };
        var res = MinOperationsSolution.MinOperations(newInt);
        Console.WriteLine(res);

        //MyCircularDeque myCircularDeque = new MyCircularDeque(3);
        //Console.WriteLine(myCircularDeque.InsertLast(1));  // return True
        //myCircularDeque.InsertLast(2);  // return True
        //myCircularDeque.InsertFront(3); // return True
        //myCircularDeque.InsertFront(4); // return False, the queue is full.
        //myCircularDeque.GetRear();      // return 2
        //myCircularDeque.IsFull();       // return True
        //myCircularDeque.DeleteLast();   // return True
        //myCircularDeque.InsertFront(4); // return True
        //myCircularDeque.GetFront();     // return 4

    }
}
