namespace ToeplitzMatrix
{
    internal class Program
    {
        public bool IsToeplitzMatrix(int[][] matrix)
        {
            for (int i = 1; i < matrix.Length; i++)
            {
                for (int j = 1; j < matrix[i].Length; j++)
                {
                    if (matrix[i][j] != matrix[i - 1][j - 1])
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private static void Main(string[] args)
        {
            Program program = new Program();
            int[][] matrix1 = new int[][]
            {
                [1, 2, 3],
                [4, 1, 2],
                [5, 4, 1]
            };

            int[][] matrix2 =
            [
                [1, 2, 3],
                [4, 1, 9],
                [5, 4, 1]
            ];

            bool result1 = program.IsToeplitzMatrix(matrix1);
            bool result2 = program.IsToeplitzMatrix(matrix2);

            Console.WriteLine("Answer: True , Result:  " + result1);
            Console.WriteLine("Answer: False , Result:  " + result2);
        }
    }
}