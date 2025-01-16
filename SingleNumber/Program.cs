namespace SingleNumber;

internal class Program
{
    public static int SingleNumber(int[] nums)
    {
        return nums.GroupBy(x => x)
            .Where(g => g.Count() == 1)
            .Select(x => x.Key)
            .First();
    }

    public static int SingleNumber2(int[] nums)
    {
        return nums.Aggregate((x, i) => x ^ i);
    }
    private static void Main(string[] args)
    {
        Console.WriteLine("Solution 1");
        Console.WriteLine("Answer: 1 , Result: " + SingleNumber(new int[] { 2, 2, 1 }));
        Console.WriteLine("Answer: 4 , Result: " + SingleNumber(new int[] { 4, 1, 2, 1, 2 }));
        Console.WriteLine("Answer: 1 , Result: " + SingleNumber(new int[] { 1 }));

        Console.WriteLine("\nSolution 2");
        Console.WriteLine("Answer: 1 , Result: " + SingleNumber2(new int[] { 2, 2, 1 }));
        Console.WriteLine("Answer: 4 , Result: " + SingleNumber2(new int[] { 4, 1, 2, 1, 2 }));
        Console.WriteLine("Answer: 1 , Result: " + SingleNumber2(new int[] { 1 }));

    }
}