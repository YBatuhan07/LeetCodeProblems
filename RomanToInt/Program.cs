namespace RomanToInt
{
    internal class Program
    {
        public int RomanToInt(string s)
        {
            var answer = 0;
            int num = 0;

            for (int i = s.Length - 1; i >= 0; i--)
            {
                switch (s[i])
                {
                    case 'I':
                        num = 1;
                        break;

                    case 'V':
                        num = 5;
                        break;

                    case 'X':
                        num = 10;
                        break;

                    case 'L':
                        num = 50;
                        break;

                    case 'C':
                        num = 100;
                        break;

                    case 'D':
                        num = 500;
                        break;

                    case 'M':
                        num = 1000;
                        break;
                }
                if(4*num < answer)
                {
                    answer -= num;
                }
                else
                {
                    answer += num;
                }
            }

            return answer;
        }

        private static void Main(string[] args)
        {
            Program p1 = new Program();
            var result = p1.RomanToInt("III");
            Console.WriteLine("III: " + result);
            result = p1.RomanToInt("IIX");
            Console.WriteLine("IIX: " + result);
            result = p1.RomanToInt("LVII");
            Console.WriteLine("LVII: " + result);
            result = p1.RomanToInt("MCMXCIV");
            Console.WriteLine("MCMXCIV: " + result);
            result = p1.RomanToInt("CM");
            Console.WriteLine("CM: " + result);
            result = p1.RomanToInt("X");
            Console.WriteLine("X: " + result);
        }
    }
}