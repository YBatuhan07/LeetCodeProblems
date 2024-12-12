namespace LetcodeProblems
{
    internal class Program
    {
        public bool IsPalindrome(int x)
        {
            if (x < 0) return false;

            int reversed = 0;
            int original = x;

            while (x != 0)
            {
                int digit = x % 10;
                x /= 10;
                reversed = reversed * 10 + digit;
            }

            return (reversed == original);
        }

        static void Main(string[] args)
        {
            Program p1 = new Program();

            var result = p1.IsPalindrome(125);
            result = p1.IsPalindrome(125);
            Console.WriteLine("125: " + result);
            result = p1.IsPalindrome(15);
            Console.WriteLine("15: " + result);
            result = p1.IsPalindrome(121);
            Console.WriteLine("121: " + result);
            result = p1.IsPalindrome(325);
            Console.WriteLine("325: " + result);
            result = p1.IsPalindrome(424);
            Console.WriteLine("424: " + result);
            result = p1.IsPalindrome(111);
            Console.WriteLine("111: " + result);
            result = p1.IsPalindrome(12);
            Console.WriteLine("12: " + result);
        }
    }
}
