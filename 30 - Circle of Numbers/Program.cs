using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29___Circle_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(circleOfNumbers(12, 10));
            Console.Read();
        }
        static int circleOfNumbers(int n, int firstNumber)
        {
            if (firstNumber < (n / 2))
                return ((n / 2) + firstNumber);
            else if (firstNumber == (n / 2))
                return 0;
            else
                return firstNumber - n / 2;
        }

    }
}
