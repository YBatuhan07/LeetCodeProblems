namespace FindTheIndex
{
    internal class Program
    {
        //public static int StrStr(string haystack, string needle)
        //{
        //    return haystack.IndexOf(needle);
        //}

        public static int StrStr(string haystack, string needle)
        {
            for (int i = 0; i <= haystack.Length - needle.Length; ++i)
            {
                if (haystack.Substring(i, needle.Length) == needle)
                {
                    return i;
                }
            }
            return -1;
        }


        static void Main(string[] args)
        {
            Console.WriteLine("0 ," + Program.StrStr("sadbutsad", "sad"));
            Console.WriteLine("-1 ," + Program.StrStr("leetcode", "leeto"));
            Console.WriteLine("4, " + Program.StrStr("leetcode", "code"));
            Console.WriteLine("3, " + Program.StrStr("sadbutsad", "but"));
            



        }

    }
}
