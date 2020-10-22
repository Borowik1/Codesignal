using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29___Chess_Board_Cell_Color
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "A1";
            string s2 = "H3";
            Console.WriteLine(chessBoardCellColor(s1, s2));
            Console.Read();
        }

        static bool chessBoardCellColor(string cell1, string cell2)
        {
            Dictionary<string, bool> chessBoard = FillChessBoard();
            chessBoard.TryGetValue(cell1, out bool value1);
            chessBoard.TryGetValue(cell2, out bool value2);
            if (value1 == value2)
                return true;
            else
                return false;
        }

        private static Dictionary<string, bool> FillChessBoard()
        {
            Dictionary<string, bool> result = new Dictionary<string, bool>();
            bool isDark = true;
            for (int i = 1; i <= 8; i++)
            {
                for (int j = 1; j <= 8; j++)
                {
                    result.Add( (char)(i+64)+j.ToString(), isDark);
                    if (j==8) isDark = !isDark;
                    isDark = !isDark;
                }
            }
            return result;
        }
    }
}
