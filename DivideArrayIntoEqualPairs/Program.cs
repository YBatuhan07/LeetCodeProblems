namespace DivideArrayIntoEqualPairs;

internal class Program
{
    public static bool DivideArray(int[] nums)
    {
        int[] count = new int[501];

        foreach (int num in nums)
        {
            count[num]++;
        }

        foreach (int c in count)
        {
            if (c % 2 == 1) return false;
        }

        return true;
    }

    private static void Main(string[] args)
    {
        Console.WriteLine("Answer: True, Result: " + DivideArray([1, 2, 2, 1]));
        Console.WriteLine("Answer: False, Result: " + DivideArray([1,2,3,2,3]));
        Console.WriteLine("Answer: False, Result: " + DivideArray([4,4,4,1]));
        Console.WriteLine("Answer: True, Result: " + DivideArray([2,2,1,3,1,5,3,5]));

    }
}