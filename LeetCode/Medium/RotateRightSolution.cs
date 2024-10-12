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

public class Solution
{
	public ListNode RotateRight(ListNode head, int k)
	{
		if (head == null) return head;

		ListNode slow = head;
		ListNode fast = head;
		ListNode newNode = new ListNode(fast.val);
		for (int i = 0; i < k; i++)
		{
			fast = fast.next;
			// if (fast == null)
			// 	return head;
			newNode = new ListNode(fast.val, newNode);
		}

		while (fast != null)
		{
			fast = fast.next;
			slow = slow.next;
		}

		fast.next = newNode;

		return fast;
	}
}
