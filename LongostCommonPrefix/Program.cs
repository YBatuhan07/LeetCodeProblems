using System.Text;

namespace LongostCommonPrefix
{
    internal class Program
    {
        public string longestCommonPrefix(string[] strs)
        {

            string shortest = strs.OrderBy(str => str.Length).First();
            int index = 0;
            StringBuilder stringBuilder = new StringBuilder();
            foreach (char s in shortest)
            {
                if (!strs.All(p => p[index] == s))
                    break;

                stringBuilder.Append(s);
                index++;
            }
            return stringBuilder.ToString();
        }

        private static void Main(string[] args)
        {
            Program p1 = new Program();

            var result = p1.longestCommonPrefix(["flower", "flow", "flight"]);
            Console.WriteLine(result);

            result = p1.longestCommonPrefix(["dog", "racecar", "car"]);
            Console.WriteLine(result);

            result = p1.longestCommonPrefix(["sensizlik", "senlilik", "senimsilik"]);
            Console.WriteLine(result);
        }
    }
}