using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _48___Is_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(isDigit('e'));
            Console.Read();
        }

        static bool isDigit(char symbol)
        {
            if (symbol >= 48 && symbol <= 57)
                return true;
            else
                return false;
        }

    }
}
