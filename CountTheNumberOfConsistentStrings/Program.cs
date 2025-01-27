using System.Linq;

namespace CountTheNumberOfConsistentStrings
{
    internal class Program
    {
        public static int CountConsistentStrings(string allowed, string[] words)
        {
            var hashSet = new HashSet<char>(allowed);

            return words.Count(word => word.All(c => hashSet.Contains(c)));
        }
        public static int CountConsistentStrings2(string allowed, string[] words)
        {
            HashSet<char> allowedChars = new HashSet<char>(allowed);

            int count = 0;

            foreach (string word in words)
            {
                if (word.All(c => allowedChars.Contains(c)))
                {
                    count++;
                }
            }

            return count;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Solution 1");
            Console.WriteLine("Answer: 4 Result: " + CountConsistentStrings("batu", ["ab","c","ahmet","axx","at","ut","ua"]));
            Console.WriteLine("Answer: 3 Result: " + CountConsistentStrings("batu", ["ba","aut","cat","bbbbaaaa","batc"]));
            Console.WriteLine("Answer: 7, Result: " + CountConsistentStrings("hello", new string[] { "he", "ell", "oll", "helo", "hello", "helol", "lo" }));
            Console.WriteLine("Answer: 6, Result: " + CountConsistentStrings("abcd", new string[] { "a", "ab", "dab", "aaa", "bbb", "abcda" }));

            Console.WriteLine("\nSolution 2");
            Console.WriteLine("Answer: 4 Result: " + CountConsistentStrings2("batu", ["ab", "c", "ahmet", "axx", "at", "ut", "ua"]));
            Console.WriteLine("Answer: 3 Result: " + CountConsistentStrings2("batu", ["ba", "aut", "cat", "bbbbaaaa", "batc"]));
            Console.WriteLine("Answer: 7, Result: " + CountConsistentStrings2("hello", new string[] { "he", "ell", "oll", "helo", "hello", "helol", "lo" }));
            Console.WriteLine("Answer: 6, Result: " + CountConsistentStrings2("abcd", new string[] { "a", "ab", "dab", "aaa", "bbb", "abcda" }));
        }
    }
}
