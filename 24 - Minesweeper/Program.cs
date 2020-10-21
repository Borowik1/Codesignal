using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24___Minesweeper
{
    class Program
    {
        static void Main(string[] args)
        {
            bool[][] field = new bool[3][];
            field[0] = new bool[] { true, true, true };
            field[1] = new bool[] { true, true, true };
            field[2] = new bool[] { true, true, true };
            int[][] result = minesweeper(field);
            Console.Read();

        }

        static int[][] minesweeper(bool[][] matrix)
        {
            int heightOfResult = matrix.Length;
            int widthOfResult = matrix[0].Length;
            int[][] result = new int[heightOfResult][];

            for (int z = 0; z < heightOfResult; z++)
            {
                result[z] = new int[widthOfResult];
            }

            for (int i = 0; i < result.Length; i++)
            {
                for (int j = 0; j < result[0].Length; j++)
                {
                    int vs = 0;
                    for (int k = 0; k < 3; k++)
                    {
                        for (int m = 0; m < 3; m++)
                        {
                            if (i + k - 1 >= 0 && j + m - 1 >= 0 && i + k - 1 < result.Length && j + m - 1 < result[0].Length)
                            {
                                if (!(k == 1 && m == 1))
                                {
                                    if (matrix[i + k - 1][j + m - 1])
                                    {
                                        vs++;
                                    }
                                }
                            }
                        }                        
                    }
                    result[i][j] = vs;
                }
            }
            return result;
        }
    }
}