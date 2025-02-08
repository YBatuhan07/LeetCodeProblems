namespace RevealCardsInIncreasingOrder;

public class Program
{
    public static int[] DeckRevealedIncreasing(int[] deck)
    {
        Array.Sort(deck);
        LinkedList<int> list = new LinkedList<int>();
        // 1 8 2 7 5
        for (int i = deck.Length - 1; i >= 0; i--)
        {
            if (list.Count > 0)
            {
                int lastCard = list.Last.Value;
                list.RemoveLast();
                list.AddFirst(lastCard);
            }
            list.AddFirst(deck[i]);
        }
        return list.ToArray();
    }

    public static void PrintList(int[] deck)
    {
        Console.WriteLine(string.Join(" ", deck));
    }

    private static void Main(string[] args)
    {
        Console.Write("Answer: 1 8 2 7 5 , Result: ");
        PrintList(DeckRevealedIncreasing([1, 5, 2, 7, 8]));
        Console.Write("Answer: 2 13 3 11 5 17 7 , Result: ");
        PrintList(DeckRevealedIncreasing([17, 13, 11, 2, 3, 5, 7]));
        Console.Write("Answer: 0 4 2 8 3 5 , Result: ");
        PrintList(DeckRevealedIncreasing([4, 8, 2, 0, 5, 3]));
    }
}