namespace SearchInsertPosition
{
    internal class Program
    {
        public static int SearchInsert(int[] nums, int target)
        {
            for(int i = 0; i < nums.Length; i++)
            {
                if(nums[i] >= target)
                {
                    return i;
                }
            }
                return nums.Length;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Answer: 2, Result: " + Program.SearchInsert([1, 3, 5, 6], 5));
            Console.WriteLine("Answer: 1, Result: " + Program.SearchInsert([1, 3, 5, 6], 2));
            Console.WriteLine("Answer: 4, Result: " + Program.SearchInsert([1, 3, 5, 6], 7));
            Console.WriteLine("Answer: 3, Result: " + Program.SearchInsert([1,3,4,7,9], 6));
        }
    }
}
