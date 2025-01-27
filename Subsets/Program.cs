namespace Subsets;

internal class Program
{
    public static IList<IList<int>> Subsets(int[] nums)
    {
        IList<IList<int>> result = new List<IList<int>>();
        result.Add(new List<int>());

        foreach (int num in nums)
        {
            int size = result.Count;
            for (int i = 0; i < size; i++)
            {
                List<int> newSubset = new List<int>(result[i]);
                newSubset.Add(num);
                result.Add(newSubset);
            }
        }

        return result;
    }
    public static void PrintSubsets(IList<IList<int>> subsets)
    {
        Console.Write("[");
        for (int i = 0; i < subsets.Count; i++)
        {
            Console.Write("[");
            Console.Write(string.Join(",", subsets[i]));
            Console.Write("]");
            if (i < subsets.Count - 1)
            {
                Console.Write(",");
            }
        }
        Console.WriteLine("]");
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Answer: [[],[1],[2],[1,2],[3],[1,3],[2,3],[1,2,3]]");
        PrintSubsets(Subsets([1, 2, 3]));
        Console.WriteLine("Answer: [[],[0]]");
        PrintSubsets(Subsets([0]));
    }
}
