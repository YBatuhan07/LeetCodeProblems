namespace Sqrt
{
    internal class Program
    {
        public static int MySqrt(int x)
        {
            long a = 0;
            while (a * a<= x)
            {
                if((a+1) * (a+1) > x)
                {
                    return (int)a;
                }
                a++;
            }
            return 0;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Answer: 4, Result: " + Program.MySqrt(16));
            Console.WriteLine("Answer: 4, Result: " + Program.MySqrt(20));
            Console.WriteLine("Answer: 3, Result: " + Program.MySqrt(9));
            Console.WriteLine("Answer: 3, Result: " + Program.MySqrt(15));
            Console.WriteLine("Answer: 5, Result: " + Program.MySqrt(30));
        }
    }
}
