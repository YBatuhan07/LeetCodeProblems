namespace MergeSortedArray
{
    internal class Program
    {
        public static int[] Merge(int[] nums1, int m, int[] nums2, int n)
        {
            for (int i = 0; i < n; i++)
            {
                nums1[m + i] = nums2[i];
            }
            Array.Sort(nums1);
            return nums1;
        }

        private static void Main(string[] args)
        {
            Console.WriteLine("Result: 1,2,2,3,5,6 " + " Answer: " +
                              string.Join(",", Merge(new int[] { 1, 2, 3, 0, 0, 0 }, 3, new int[] { 2, 5, 6 }, 3)));

            Console.WriteLine("Result: 1,1,2,5 " + " Answer: " +
                              string.Join(",", Merge(new int[] { 1, 2, 5,7 }, 3, new int[] { 1 ,2}, 1)));
        }
    }
}