using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _55___Different_Squares
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] s = new int[][] { new int[]{ 2, 5, 3, 4, 3, 1, 3, 2 },
                                      new int[]{ 4, 5, 4, 1, 2, 4, 1, 3 },
                                      new int[]{ 1, 1, 2, 1, 4, 1, 1, 5 },
                                      new int[]{ 1, 3, 4, 2, 3, 4, 2, 4 },
                                      new int[]{ 1, 5, 5, 2, 1, 3, 1, 1 },
                                      new int[]{ 1, 2, 3, 3, 5, 1, 2, 4 },
                                      new int[]{ 3, 1, 4, 4, 4, 1, 5, 5 },
                                      new int[]{ 5, 1, 3, 3, 1, 5, 3, 5 },
                                      new int[]{ 5, 4, 4, 3, 5, 4, 4, 4 } };

            Console.WriteLine(differentSquares(s));
            Console.ReadLine();
        }
        static int differentSquares(int[][] matrix)
        {
            if (matrix.Length < 2 && matrix[0].Length < 2)
                return 0;
            List<string> strings = new List<string>();
            for (int i = 0; i < matrix.Length - 1; i++)
            {
                for (int j = 0; j < matrix[0].Length - 1; j++)
                {
                    string matrixString = "";
                    matrixString += matrix[i][j].ToString() + matrix[i][j + 1].ToString() + matrix[i + 1][j].ToString() + matrix[i + 1][j + 1].ToString();
                    strings.Add(matrixString);
                }
            }
            int count = strings.Count;
            while (strings.Count>0)
            {
                string temp = strings[0];
                strings.Remove(temp);
                while (strings.Remove(temp))
                {
                    count--;
                }
            }
            return count;
        }

    }
}
