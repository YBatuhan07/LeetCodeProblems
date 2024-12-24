namespace RemoveDuplicateFromSortedList;

public class ListNode
{
    public int val;
    public ListNode next;

    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }

    public ListNode DeleteDuplicates(ListNode head)
    {
        if (head == null) return null;

        ListNode result = head;

        while (head.next != null)
        {
            if (head.val == head.next.val)
                head.next = head.next.next;
            else
                head = head.next;
        }

        return result;
    }
    public void WriteNodeList(ListNode node)
    {

        ListNode newNode = new ListNode();
        Console.Write(node.val + ",");
        while (node.next != null)
        {
            if (node.next.next != null)
                Console.Write(node.next.val + ",");

            else
                Console.Write(node.next.val);

            node = node.next;
        }
        Console.WriteLine();
    }

    public static void Main(string[] args)
    {
        ListNode p1 = new ListNode();

        ListNode node1 = new ListNode(2, new ListNode(3, new ListNode(3, new ListNode(4, null))));
        ListNode node2 = new ListNode(2, new ListNode(2, new ListNode(2, new ListNode(5, null))));
        ListNode node3 = new ListNode(1, new ListNode(1, null));
        ListNode node4 = new ListNode(2, new ListNode(3, new ListNode(3, new ListNode(4, new ListNode(5, null)))));

        var newNode1 = p1.DeleteDuplicates(node1);
        var newNode2 = p1.DeleteDuplicates(node2);
        var newNode3 = p1.DeleteDuplicates(node3);
        var newNode4 = p1.DeleteDuplicates(node4);

        Console.Write("Answer: 2,3,4    Result: ");
        p1.WriteNodeList(newNode1);
        Console.Write("Answer: 2,5      Result: ");
        p1.WriteNodeList(newNode2);
        Console.Write("Answer: 1        Result: ");
        p1.WriteNodeList(newNode3);
        Console.Write("Answer: 2,3,4,5  Result: ");
        p1.WriteNodeList(newNode4);
    }

    
}