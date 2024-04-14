using System;
namespace LeetCode.Easy
{
  //Definition for singly-linked list.
	public class ListNodeTest {
	    public int val;
		public ListNodeTest next;
		public ListNodeTest(int val=0, ListNodeTest next =null) {
          this.val = val;
          this.next = next;
		}
	}

	public class RemoveDuplicatesSortedList
	{
        public ListNodeTest DeleteDuplicates(ListNodeTest head)
        {
            if (head == null) return head;
            ListNodeTest current = head;
            while (current.next != null)
            {
                if (current.val == current.next.val)
                    current.next = current.next.next;
                else
                    current = current.next;
            }
            return head;
        }
    }
}

