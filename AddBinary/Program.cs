namespace AddBinary
{
    internal class Program
    {
        public static string AddBinary(string a, string b)
        {
            int i = a.Length - 1;
            int j = b.Length - 1;

            int carry = 0;
            string result = "";

            while (i >= 0 || j >= 0)
            {
                int sum = carry;
                if (i >= 0)
                {
                    sum += a[i] - '0';
                    i--;
                }
                if (j >= 0)
                {
                    sum += b[j] - '0';
                    j--;
                }
                carry = sum / 2;
                result = (sum % 2) + result;
            }
            if(carry > 0)
            {
                result = carry + result;
            }
            return result;
        }

        private static void Main(string[] args)
        {
            Console.WriteLine("Answer: 100, Result: " + Program.AddBinary("11", "1"));
            Console.WriteLine("Answer: 10101, Result: " + Program.AddBinary("1010", "1011"));
        }
    }
}