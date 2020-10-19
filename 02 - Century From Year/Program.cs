using System;

namespace _02___Century_From_Year
{
    class Program
    {
        static void Main(string[] args)
        {
            int year = 1988;
            Console.WriteLine(centuryFromYear(year));
        }

        static int centuryFromYear(int year)
        {
            if ((year % 100) == 0)
            {
                return (year / 100);
            }
            else
            {
                return ((year / 100) + 1);
            }
        }

    }
}
