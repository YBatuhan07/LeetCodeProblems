namespace Numberof1Bits
{
    internal class Program
    {
        public static int HammingWeight(int n)
        {
            n = Convert.ToString(n, 2).Count(x => x == '1');
            return n;
        }

        public static int HammingWeight2(int n)
        {
            List<int> list = new List<int>();
            var result = 0;
            while (n > 0)
            {
                result = n % 2;
                n /= 2;
                list.Add(result);
            }

            return list.Count(x => x == 1);
        }

        private static void Main(string[] args)
        {
            Console.WriteLine("Answer: 3, Result: " + HammingWeight(11));
            Console.WriteLine("Answer: 1, Result: " + HammingWeight(128));
            Console.WriteLine("Answer: 30, Result: " + HammingWeight(2147483645));

            Console.WriteLine("Answer: 3, Result: " + HammingWeight2(11));
            Console.WriteLine("Answer: 1, Result: " + HammingWeight2(128));
            Console.WriteLine("Answer: 30, Result: " + HammingWeight2(2147483645));
        }
    }
}