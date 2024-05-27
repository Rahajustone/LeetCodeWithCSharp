using System;
namespace LeetCode.Medium
{
 
	public class MaximumTwinSumOfALinkedList
	{
		public MaximumTwinSumOfALinkedList()
		{
		}

        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }

        public int PairSum(ListNode head)
        {
			var slow = head;
			var fast = head;
			Stack<int> first = new Stack<int>();
            int max = int.MinValue;

			while (fast != null && fast.next != null)
			{
                first.Push(slow.val);
                fast = fast.next.next;
                slow = slow.next;
			}

            while(slow != null)
            {
                var tempMin = slow.val + first.Pop();
                if (tempMin > max) max = tempMin;
                slow = slow.next;
            }

            return max;
        }
    }
}

