using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _50___Chess_Knight
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(chessKnight("a1"));
            Console.ReadLine();
        }

        static int chessKnight(string cell)
        {
            int[,] diff = new int[,] { { 1, 2 }, { 2, 1 }, { 2, -1 }, { 1, -2 }, { -1, -2 }, { -2, -1 }, { -2, 1 }, { -1, 2 } };
            int result = 0;
            for (int i = 0; i < 8; i++)
            {
                if (diff[i, 0] + (int)cell[0] >= 97 && diff[i, 0] + (int)cell[0] <= 104
                    && diff[i, 1] + (int)cell[1] >= 49 && diff[i, 1] + (int)cell[1] <= 56)
                {
                    result++;
                }
            }
            return result;
        }

    }
}
