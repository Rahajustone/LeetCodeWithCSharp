using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Easy
{

  // Definition for singly-linked list.
    public class ListNode {
        public int val;
        public ListNode next;
        public ListNode(int val=0, ListNode next=null) {
            this.val = val;
            this.next = next;
        }
    }
 
    public class MergeTwoSortedListsSolution
    {
        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {

            ListNode res = null;
            while (l1 != null || l2 != null)
            {
                if (l1 != null && l2 != null)
                {
                    if (l1.val < l2.val)
                    {
                        res = new ListNode(l1.val, new ListNode());
                        l1 = l1.next;
                    }
                    else
                    {
                        res = new ListNode(l2.val, new ListNode());
                        l2 = l2.next;
                    }
                }
                else if (l1 != null && l2 == null)
                {
                    res = new ListNode(l1.val, new ListNode());
                    l1 = l1.next;
                }
                else if (l1 == null && l2 != null)
                {
                    res = new ListNode(l2.val, new ListNode());
                    l2 = l2.next;
                }
            }

            return res;
        }
    }
}
