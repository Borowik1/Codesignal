using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _36____Different_Symbols_Naive
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString = "";
            Console.WriteLine(differentSymbolsNaive(inputString));
        }

        static int differentSymbolsNaive(string s)
        {
            int counter = 0;
            for (int i = 97; i < 123; i++)
            {
                if (s.Contains((char)i)) counter++;                    
            }    
            return counter;
        }

    }
}
