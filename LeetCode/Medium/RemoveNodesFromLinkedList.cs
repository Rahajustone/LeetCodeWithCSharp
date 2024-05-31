using System;
namespace LeetCode.Medium
{
	public class RemoveNodesFromLinkedList
	{
		public RemoveNodesFromLinkedList()
		{
		}

        public ListNode RemoveNodes(ListNode head)
        {

            ListNode newNode = null;
            Stack<int> st = new Stack<int>();

            var current = head;
            while (current != null)
            {

                while (st.Count > 0 && st.Peek() < current.val)
                {
                    st.Pop();
                }
                st.Push(current.val);

                current = current.next;
            }

            while (st.Count > 0)
            {
                if (newNode == null)
                {
                    newNode = new ListNode(st.Pop());
                }
                else
                {
                    var temp = newNode;
                    newNode = new ListNode(st.Pop());
                    newNode.next = temp;
                }
            }
            return newNode;
        }
    }
}

