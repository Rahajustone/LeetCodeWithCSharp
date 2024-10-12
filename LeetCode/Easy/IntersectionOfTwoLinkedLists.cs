namespace LEETCODEWITHCSHARP.LeetCode.Easy;
// Definition for singly-linked list.
// public class ListNode
// {
//   public int val;
//   public ListNode next;
//   public ListNode(int x)
//   {
//     val = x;
//     next = null;
//   }
// }
public class IntersectionOfTwoLinkedLists
{
  public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
  {
    if (headA == null && headB == null) return null;

    HashSet<ListNode> uniqueAListNodes = new HashSet<ListNode>();
    HashSet<ListNode> uniqueBListNodes = new HashSet<ListNode>();

    var currentA = headA;
    var currentB = headB;
    while (currentA != null || currentB != null)
    {
      if (currentA != null)
      {
        if (uniqueBListNodes.Contains(currentA))
          return currentA;

        uniqueAListNodes.Add(currentA);
        currentA = currentA.next;
      }

      if (currentB != null)
      {
        if (uniqueAListNodes.Contains(currentB))
          return currentB;

        uniqueBListNodes.Add(currentB);
        currentB = currentB.next;
      }
    }

    return null;
  }
}