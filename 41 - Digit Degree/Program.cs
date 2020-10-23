using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _41___Digit_Degree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(digitDegree(777773));
            Console.Read();
        }

        static int digitDegree(int n)
        {
            int counter = 0;
            int[] digits = NumberToDigitArray(n);
            while (digits.Length > 1)
            {
                int summ = 0;
                counter++;
                foreach (int item in digits)
                {
                    summ += item;
                }
                digits = NumberToDigitArray(summ);
            }
                return counter;
        }

        static int[] NumberToDigitArray(int inputNumber)
        {
            int[] result = new int[] { };
            while (inputNumber > 0)
            {
                result = AddElement(inputNumber % 10, result);
                inputNumber /= 10;
            }
            return result;
        }

        private static int[] AddElement(int v, int[] inputArray)
        {
            int[] resultArray = new int[inputArray.Length + 1];
            for (int i = 0; i < inputArray.Length; i++)
            {
                resultArray[i] = inputArray[i];
            }
            resultArray[inputArray.Length] = v;
            return resultArray;
        }
    }
}
