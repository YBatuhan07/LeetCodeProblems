namespace AddTwoNumbers
{
    internal class Program
    {
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

        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode result = new ListNode();
            ListNode head = result;
            int sum = 0;
            while (l1 != null || l2 != null || sum > 0)
            {
                if (l1 != null)
                {
                    sum += l1.val;
                    l1 = l1.next;
                }
                if (l2 != null)
                {
                    sum += l2.val;
                    l2 = l2.next;
                }
                result.next = new ListNode(sum % 10);
                sum /= 10;
                result = result.next;
            }
            return head.next;
        }

        private static void Main(string[] args)
        {
            Program program = new Program();

            ListNode listnode1 = new ListNode(2, new ListNode(4, new ListNode(3)));
            ListNode listnode2 = new ListNode(5, new ListNode(6, new ListNode(4)));

            Console.Write("Answer: 708, Result: ");
            PrintList(program.AddTwoNumbers(listnode1, listnode2));

        }

        private static void PrintList(ListNode node)
        {
            while (node != null)
            {
                Console.Write(node.val);
                if (node.next != null) Console.Write(" -> ");
                node = node.next;
            }
            Console.WriteLine();
        }
    }
}