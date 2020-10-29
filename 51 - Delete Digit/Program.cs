using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _51___Delete_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(deleteDigit(15237));
            Console.Read();
        }

        static int deleteDigit(int n)
        {
            int max = 0;
            int i = 10;
            while (n / i >= 1)
            {
                int withoutDigit = n;
                withoutDigit = n / i;
                withoutDigit *= (i / 10);
                withoutDigit += n % (i / 10);
                if (max < withoutDigit)
                {
                    max = withoutDigit;
                }
                i *= 10;
            }
            if (max < n % (i / 10))
                return n % (i / 10);
            return max;
        }

    }
}
