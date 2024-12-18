namespace LengthOfLastWord
{
    internal class Program
    {
        public static int LengthOfLastWord(string s)
        {
            int count = 0;
            int lastCount = 0;
            foreach (var item in s)
            {
                if (item != ' ')
                {
                    count++;
                    lastCount = count;
                }
                else
                {
                    count = 0;
                }
            }

            if (count == 0)
            {
                return lastCount;
            }
            return count;
        }

        public static int LengthOfLastWord2(string s)
        {
            var result = s.Split(new[]{ ' ', '\t'}, StringSplitOptions.RemoveEmptyEntries);

            return result[^1].Length;
        }

        private static void Main(string[] args)
        {
            Console.WriteLine("************Çözüm 1************\n");
            Console.WriteLine("Answer: 5 , Result: " + Program.LengthOfLastWord("Hello World"));
            Console.WriteLine("Answer: 4 , Result: " + Program.LengthOfLastWord("   fly me   to   the moon  "));
            Console.WriteLine("Answer: 6 , Result: " + Program.LengthOfLastWord("luffy is still joyboy"));
            Console.WriteLine("Answer: 6 , Result: " + Program.LengthOfLastWord("Hayat kısa kuşlar uçuyor"));
            Console.WriteLine("Answer: 8 , Result: " + Program.LengthOfLastWord("Artık demir almak günü gelmişse zamandan"));

            Console.WriteLine("\n\n************Çözüm 2************\n");
            Console.WriteLine("Answer: 5 , Result: " + Program.LengthOfLastWord2("Hello World"));
            Console.WriteLine("Answer: 4 , Result: " + Program.LengthOfLastWord2("   fly me   to   the moon  "));
            Console.WriteLine("Answer: 6 , Result: " + Program.LengthOfLastWord2("luffy is still joyboy"));
            Console.WriteLine("Answer: 6 , Result: " + Program.LengthOfLastWord2("Hayat kısa kuşlar uçuyor"));
            Console.WriteLine("Answer: 8 , Result: " + Program.LengthOfLastWord2("Artık demir almak günü gelmişse zamandan"));
        }
    }
}