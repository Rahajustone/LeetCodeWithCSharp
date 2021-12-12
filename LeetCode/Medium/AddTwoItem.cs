using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Medium
{
    // You are given two non-empty linked lists representing two non-negative integers.
    // The digits are stored in reverse order, and each of their nodes contains a single digit.
    // Add the two numbers and return the sum as a linked list.
    // You may assume the two numbers do not contain any leading zero, except the number 0 itself.


    /**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */

    public class ListNode
    {
        public int val;
        public ListNode next;
         public ListNode(int val = 0, ListNode next = null)
         {
            this.val = val;
            this.next = next;
         }

        public void PrintNode(ListNode node)
        {
            while(node != null)
            {
                Console.WriteLine(node.val);
                node = node.next;
            }
        }
    }

    public class AddTwoItem
    {

        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            var resNode = new ListNode();

            while (l1 != null || l2 != null)
            {
                int tempReminder = 0;
                int res = 0;

                if (l1 != null && l2 != null)
                {
                    res = l1.val + l2.val;

                    if (res > 10)
                        tempReminder = 1;
                    else
                        tempReminder = 0;

                    l1 = l1.next;
                    l2 = l2.next;
                }
                else if (l1 != null && l2 == null)
                {
                    res = l1.val;
                    l1 = l1.next;

                }
                else if (l1 == null && l2 != null)
                {
                    res = l2.val;
                    l2 = l2.next;
                }

                var newNode = new ListNode(((res % 10) + tempReminder));
                
                newNode.next = null;

                if (resNode == null)
                {
                    resNode = newNode;
                }

                newNode.next = null;

                ListNode lastNode = resNode;

                while (lastNode.next != null)
                    lastNode = lastNode.next;

                lastNode.next = newNode;
            }

            return resNode;
        }
    }
}
