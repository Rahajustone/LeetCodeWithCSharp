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
        var head = new RotateRightSolution.ListNode(1);
        head.next = new RotateRightSolution.ListNode(2);
        head.next.next = new RotateRightSolution.ListNode(3);
        head.next.next.next = new RotateRightSolution.ListNode(4);
        head.next.next.next.next = new RotateRightSolution.ListNode(5);

        RotateRightSolution linkedRotate = new RotateRightSolution();
        linkedRotate.RotateRight(head, 2);

        // head = [1,2,3,4,5], k = 2
        // int[] newInt = new int[] { 1, 0, -1, 0, -2, 2 };
        // var res = FourSumSolution.FourSum(newInt, 0);
        // Console.WriteLine(res);

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
