namespace MaximumNumberofWordsYouCanType;

internal class Program
{
    public static int CanBeTypedWords(string text, string brokenLetters)
    {
        string[] words = text.ToLower().Split(' ');
        string[] str = brokenLetters.Split();
        int writeable = words.Length;

        foreach (var word in words)
        {
            foreach (char c in brokenLetters)
            {
                if (word.Contains(c))
                {
                    writeable--;
                    break;
                }
            }
        }
        return writeable;
    }

    private static void Main(string[] args)
    {
        Console.WriteLine("Answer: 0 , Result:" + CanBeTypedWords("hello world", "eo"));
        Console.WriteLine("Answer: 1 , Result:" + CanBeTypedWords("hello world", "ad"));
        Console.WriteLine("Answer: 2 , Result:" + CanBeTypedWords("hello world", "fjğqc"));
        Console.WriteLine("Answer: 4 , Result:" + CanBeTypedWords("Yus uf Bat uhan Kes Kin", "abcd"));
    }
}