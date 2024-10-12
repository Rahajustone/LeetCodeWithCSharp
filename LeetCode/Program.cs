using LeetCode.Medium.RotateList;


namespace LeetCode;
public class Program
{
    static void Main(string[] args)
    {
        var listNode = new ListNode(1);
        listNode.next = new ListNode(2);
        listNode.next.next = new ListNode(3);
        listNode.next.next.next = new ListNode(4);
        listNode.next.next.next.next = new ListNode(5);
        // listNode.next.next.next.next.next = new ListNode(6);

        var solution = new RotateListSolution();
        solution.RotateRight(listNode, 4);


    }
}
