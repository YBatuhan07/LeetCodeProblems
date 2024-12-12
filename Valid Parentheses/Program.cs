namespace Valid_Parentheses
{
    internal class Program
    {

        public static bool IsValid(string s)
        {
            while (s.Contains("()") || s.Contains("{}") || s.Contains("[]"))
            {
                s= s.Replace("()", "").Replace("{}", "").Replace("[]", "");
            }
            return s.Length == 0;
        }


        static void Main(string[] args)
        {
            Console.WriteLine("true: "+Program.IsValid("()"));
            Console.WriteLine("true: "+Program.IsValid("()[]{}"));
            Console.WriteLine("false: "+Program.IsValid("(]"));
            Console.WriteLine("true: "+Program.IsValid("([])"));
        }
    }
}
