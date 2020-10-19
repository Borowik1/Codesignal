using System;

namespace _11___Is_Lucky
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 1230;
            Console.WriteLine(isLucky(n));
        }

        static bool isLucky(int n)
        {
            int[] array = IntegerToArray(n);
            int summOfFirstHalf = 0;
            int summOfSecondHalf = 0;

            for (int i = 0; i < (array.Length / 2); i++)
            {
                summOfFirstHalf += array[i];
                summOfSecondHalf += array[(array.Length / 2) + i];
            }

            if (summOfFirstHalf == summOfSecondHalf)
            {
                return true;
            }

            return false;
        }

        static int[] IntegerToArray(int number)
        {
            int numberOfDecimalPlaces = NumberOfDecimalPlaces(number);
            int[] array = new int[numberOfDecimalPlaces];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = (number / ((int)Math.Pow(10, numberOfDecimalPlaces - 1 - i)));
                number = (number % ((int)Math.Pow(10, numberOfDecimalPlaces - 1 - i)));
            }

            return array;
        }

        private static int NumberOfDecimalPlaces(int number)
        {
            int decimalPlaces = 7;
            for (int i = 1000000; i > 2; i = i / 10)
            {
                if (number / i >= 1)
                {
                    return decimalPlaces;
                }
                decimalPlaces--;
            }

            return 0;
        }
    }
}
