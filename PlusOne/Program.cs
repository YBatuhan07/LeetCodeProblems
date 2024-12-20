namespace PlusOne
{
    internal class Program
    {
        public static int[] PlusOne(int[] digits)
        {
            for (int i = digits.Length - 1; i >= 0; i--)
            {
                if (digits[i] != 9)
                {
                    digits[i]++;
                    return digits;
                }

                digits[i] = 0;
            }
            int[] newArr = new int[digits.Length + 1];
            newArr[0] = 1;
            for (int i = 1; i < newArr.Length; i++)
            {
                newArr[i] = digits[i - 1];
            }
            return newArr;
        }
        public static void List(int[] arr)
        {
            Console.Write(" \tResult: ");

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == arr.Length - 1)
                {
                    Console.Write(arr[i]);
                    break;
                }
                Console.Write(arr[i] + ", ");
            }
            Console.WriteLine();
        }

        private static void Main(string[] args)
        {
            Console.Write("Answer: 1, 0, 0, 0");
            List(PlusOne([9, 9, 9]));

            Console.Write("Answer: 1, 4, 8");
            List(PlusOne([1, 4, 7]));

            Console.Write("Answer: 3, 5, 0");
            List(PlusOne([3, 4, 9]));

            Console.Write("Answer: 0, 0, 1");
            List(PlusOne([0, 0, 0]));
        }

        
    }
}