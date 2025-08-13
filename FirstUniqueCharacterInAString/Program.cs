namespace FirstUniqueCharacterInAString;

public class Program
{
    private static void Main(string[] args)
    {
        string test1 = "batuhan";
        string test2 = "abcdabc";
        string test3 = "aabb";

        Console.WriteLine(FirstUniqChar(test1));
        Console.WriteLine(FirstUniqChar(test2));
        Console.WriteLine(FirstUniqChar(test3));
    }

    public static int FirstUniqChar(string s)
    {
        var charCount = new Dictionary<char, int>();

        foreach (var c in s)
        {
            charCount[c] = charCount.GetValueOrDefault(c) + 1;
        }

        for (int i = 0; i < s.Length; i++)
        {
            if (charCount[s[i]] == 1)
            {
                return i;
            }
        }

        return -1;
    }
}