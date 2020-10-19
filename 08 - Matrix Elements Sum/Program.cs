using System;

namespace _08___Matrix_Elements_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] matrix = new int[3][];
            matrix[0] = new int[4] { 0, 1, 1, 2 };
            matrix[1] = new int[4] { 0, 5, 0, 0 };
            matrix[2] = new int[4] { 2, 0, 3, 3 };
            Console.WriteLine(matrixElementsSum(matrix));
        }
        static int matrixElementsSum(int[][] matrix)
        {
            int result = 0;

            for (int i = 0; i < matrix[0].Length; i++)
            {
                for (int j = 0; j < matrix.Length; j++)
                {
                    if (matrix[j][i] > 0)
                    {
                        result += matrix[j][i];
                    }
                    else
                    {
                        j = matrix.Length;
                    }
                }
            }
            return result;
        }
    }
}
