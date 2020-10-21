using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26___Even_Digits_Only
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 100;
            Console.WriteLine(evenDigitsOnly(number));
        }

        static bool evenDigitsOnly(int n)
        {
            bool result = true;
            int i = n;

            while (n > 0)
            {
                i = n % 10;
                if (i % 2 > 0)
                {
                    result = false;
                }
                n /= 10;
            }

            return result;
        }
    }
}
