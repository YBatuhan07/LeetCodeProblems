namespace IntersectionofTwoArrays
{
    internal class Program
    {
        public static int[] Intersection(int[] nums1, int[] nums2)
        {
            bool add = true;

            List<int> list = new List<int>();
            foreach (int num1 in nums1)
            {
                foreach (int num2 in nums2)
                {
                    if (num1 == num2)
                    {
                        foreach (var item in list)
                        {
                            if(item == num1)
                            {
                                add = false;
                            }
                        }
                        if(add)
                        {
                            list.Add(num1);
                        }
                        add = true;
                    }
                }
            }


            return list.ToArray();
        }

        public static int[] Intersection2(int[] nums1, int[] nums2)
        {
            HashSet<int> set1 = new HashSet<int>(nums1);
            HashSet<int> set2 = new HashSet<int>(nums2);

            set1.IntersectWith(set2);

            return set1.ToArray();
        }

        public static string printArr(int[] arr)
        {
            string str = "";

            foreach (var item in arr)
            {
                str += item + ",";
            }
            return (str.Length > 0) ? str.Substring(0, str.Length - 1) : "";
        } 
        static void Main(string[] args)
        {
            Console.WriteLine("Answer: 2 Result: " + printArr(Intersection([1, 2, 3,], [2, 5, 6, 8])));
            Console.WriteLine("Answer: 2 Result: " + printArr(Intersection2([1, 2, 3,], [2, 5, 6, 8])));

            Console.WriteLine("Answer: 8,9 Result: " + printArr(Intersection([5, 4, 2,8,9], [1, 8,9])));
            Console.WriteLine("Answer: 8,9 Result: " + printArr(Intersection2([5, 4, 2, 8, 9], [1, 8,9])));

            Console.WriteLine("Answer: 0,2,3 Result: " + printArr(Intersection([0,5,2,10,9,3], [0,1,2,3])));
            Console.WriteLine("Answer: 0,2,3 Result: " + printArr(Intersection2([0, 5, 2, 10, 9, 3], [0, 1, 2, 3])));

            Console.WriteLine("Answer:  Result: " + printArr(Intersection([2, 1, 3,7], [])));
            Console.WriteLine("Answer:  Result: " + printArr(Intersection2([2, 1, 3, 7], [])));
        }



    }
}
