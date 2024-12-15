namespace RemoveElement;

internal class Program
{
    public int RemoveElement(int[] nums, int val)
    {
        int res = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != val)
            {
                nums[res] = nums[i];
                res++;
            }
        }
        return res;
    }

    static void Main(string[] args)
    {
        Program p1 = new();

        Console.WriteLine("1," + p1.RemoveElement([1, 2, 2], 2));
        Console.WriteLine("7," + p1.RemoveElement([1, 4, 2, 5, 1,2,1,2], 5));
        Console.WriteLine("1," + p1.RemoveElement([3, 3, 3, 1], 3));
        Console.WriteLine("4," + p1.RemoveElement([1, 2, 3, 4, 5], 1));

    }
}
