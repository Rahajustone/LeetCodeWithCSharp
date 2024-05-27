using System;
namespace LeetCode.Easy
{
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
    public class PalindromeLinkedList
	{
		public PalindromeLinkedList()
		{
		}

        public bool IsPalindromeTwoStack(ListNode head)
        {
            if (head != null || head.next == null) return true;

            ListNode slow = head;
            ListNode fast = head;

            Stack<int> holdFirstPartData = new Stack<int>();

            while (fast != null && fast.next != null)
            {
                holdFirstPartData.Push(slow.val);
                fast = fast.next.next;
                slow = slow.next;
            }

            // Handle odd number of nodes by moving slow pointer one step forward
            if (fast != null)
            {
                slow = slow.next;
            }

            while (slow != null && slow.next != null ) {
                if (holdFirstPartData.Pop() != slow.val) return false;
                slow = slow.next;
            }

            return true;
        }


        public bool IsPalindrome(ListNode head)
        {
            if (head == null) return false;

            Stack<int> holdData = new Stack<int>();
            var current = head;
            while (current != null)
            {
                holdData.Push(current.val);
                current = current.next;
            }

            while (head != null)
            {
                if (holdData.Pop() != head.val) return false;
                head = head.next;
            }

            return true;
        }
    }
}

