using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _35___First_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString = "0q2q33333-q";
            Console.WriteLine(firstDigit(inputString));
            Console.Read();
        }

        static char firstDigit(string inputString)
        {
            for (int i = 0; i < inputString.Length; i++)
            {
                if (inputString[i] >= 48 && inputString[i] <= 57)
                {
                    return inputString[i];
                }
            }

            return 'a';
        }

    }
}
