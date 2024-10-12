namespace LeetCode.Medium.RotateList;

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

public class RotateListSolution
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
			if (fast == null)
			{
				fast = head;
				newNode = null;
			}
			if (newNode == null)
				newNode = new ListNode(fast.val);
			else
			{
				var temp = newNode;
				while (temp.next != null)
				{
					temp = temp.next;
				}
				temp.next = new ListNode(fast.val);
			}
		}

		if (fast.next == null)
			return newNode;

		ListNode startNode = null;
		while (fast.next != null)
		{
			fast = fast.next;
			slow = slow.next;
			var temp = startNode;
			if (startNode == null)
			{
				startNode = new ListNode(fast.val);
			}
			else
			{
				while (temp.next != null)
				{
					temp = temp.next;
				}
				temp.next = new ListNode(fast.val);
				if (fast.next == null)
				{
					temp.next = newNode;
					break;
				}
			}
		}

		return startNode;
	}
}
