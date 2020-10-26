using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _42___Bishop_and_Pawn
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(bishopAndPawn("a1", "c3"));
            Console.Read();
        }

        static bool bishopAndPawn(string bishop, string pawn)
        {
            for (int i = 1; i < 9; i++)
            {
                char bishop1 = (char)(bishop[0] + i);
                char bishop2 = (char)(bishop[1] + i);
                string newBishop = null;
                newBishop += bishop1;
                newBishop += bishop2;
                if (newBishop == pawn)
                {
                    return true;
                }
                bishop1 = (char)(bishop[0] - i);
                bishop2 = (char)(bishop[1] + i);
                newBishop = null;
                newBishop += bishop1;
                newBishop += bishop2;
                if (newBishop == pawn)
                {
                    return true;
                }
                bishop1 = (char)(bishop[0] + i);
                bishop2 = (char)(bishop[1] - i);
                newBishop = null;
                newBishop += bishop1;
                newBishop += bishop2;
                if (newBishop == pawn)
                {
                    return true;
                }
                bishop1 = (char)(bishop[0] - i);
                bishop2 = (char)(bishop[1] - i);
                newBishop = null;
                newBishop += bishop1;
                newBishop += bishop2;
                if (newBishop == pawn)
                {
                    return true;
                }
            }
            return false;
        }

    }
}
