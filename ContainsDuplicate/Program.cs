namespace ContainsDuplicate;

public class Program
{
    private static void Main(string[] args)
    {
        int[] arr1 = { 1, 2, 3, 4 };
        int[] arr2 = { 1, 2, 2, 3 };
        int[] arr3 = { 1, 2, 2 };
        int[] arr4 = { 1, 2 };
        int[] arr5 = { 1, 5 };

        ShowResult(arr1, false);
        ShowResult(arr2, true);
        ShowResult(arr3, true);
        ShowResult(arr4, false);
        ShowResult(arr5, false);
    }

    public static bool ContainsDuplicate(int[] nums)
    {
        HashSet<int> set = new(nums);

        return nums.Length != set.Count;
    }

    public static void ShowResult(int[] arr, bool result)
    {
        Console.WriteLine("Answer = " + result + ", Result = " + ContainsDuplicate(arr));
    }
}