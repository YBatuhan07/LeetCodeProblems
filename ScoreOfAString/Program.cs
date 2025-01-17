namespace ScoreOfAString
{
    internal class Program
    {
        public static int ScoreOfString(string s)
        {
            var result = 0;
            for (int i = 0; i < s.Length-1; i++)
            {
                result += Math.Abs(s[i] - s[i+1]);
            }

            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Answer:13 , Result: " + ScoreOfString("hello"));
            Console.WriteLine("Answer:50 , Result: " + ScoreOfString("zaz"));
            Console.WriteLine("Answer:54 , Result: " + ScoreOfString("batuhan"));
            Console.WriteLine("Answer:22 , Result: " + ScoreOfString("sueda"));
        }
    }
}
