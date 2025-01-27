namespace MergeTwoSortedList
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

        public static ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            ListNode dumpyList = new();
            var testList = dumpyList;

            var newList1 = list1;
            var newList2 = list2;

            while (newList1 != null && newList2 != null)
            {
                if(newList1.val < newList2.val)
                {
                    testList.next = newList1;
                    newList1 = newList1.next;
                }
                else
                {
                    testList.next = newList2;
                    newList2 = newList2.next;
                }
                testList = testList.next;
            }

            testList.next = newList1 ?? newList2;
            return dumpyList.next;
        }
        static void PrintList(ListNode node)
        {
            Console.Write("Liste: ");
            while (node != null)
            {
                Console.Write(node.val);
                node = node.next;
                if(node != null)
                    Console.Write(" -> ");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            ListNode list1 = new ListNode(1,new ListNode(2,new ListNode(4)));
            ListNode list2 = new ListNode(1,new ListNode(3,new ListNode(4)));

            ListNode list3 = new ListNode(2, new ListNode(5, new ListNode(9)));
            ListNode list4 = new ListNode(3, new ListNode(22, new ListNode(44)));

            var result = Program.MergeTwoLists(list1,list2);
            var result2 = Program.MergeTwoLists(list3,list4);

            PrintList(result);
            PrintList(result2);

            ListNode listExpected = new ListNode(1,new ListNode(1,new ListNode(2,new ListNode(3,new ListNode(4,new ListNode(4))))));

        }
    }
}
