using System;
namespace LeetCode.Easy
{
    public class RemoveLinkedListElements
	{
		public static ListNode RemoveElements(ListNode head, int val)
        {
            ListNode temp = new ListNode(0);
            var current = temp;
            temp.next = head;

            while(current.next != null)
            {
                if(current.next.val == val)
                {
                    current.next = current.next.next;
                } else
                {
                    current = current.next;
                }
            }

            return temp.next;
        }
	}
}

