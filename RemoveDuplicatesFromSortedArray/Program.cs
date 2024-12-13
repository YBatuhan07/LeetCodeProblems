namespace RemoveDuplicatesFromSortedArray
{
    internal class Program
    {
        public int RemoveDuplicates(int[] nums)
        {
            int k = 1;
            int prev = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] != prev)
                {
                    nums[k] = nums[i];
                    k++;
                }
                prev = nums[i];
            }
            return k;
        }

        private static void Main(string[] args)
        {
            Program p1 = new Program();
            Console.WriteLine("Answer: 2, result: " + p1.RemoveDuplicates([1, 1, 2]));
            Console.WriteLine("Answer: 5, result: " + p1.RemoveDuplicates([0, 0, 1, 1, 1, 2, 2, 3, 3, 4]));
            Console.WriteLine("Answer: 7, result: " + p1.RemoveDuplicates([0, 0, 4, 6, 6, 6, 6, 8, 10,11,11,12]));
            Console.WriteLine("Answer: 4, result: " + p1.RemoveDuplicates([0, 3, 3, 3, 5, 5, 9]));
        }
    }
}