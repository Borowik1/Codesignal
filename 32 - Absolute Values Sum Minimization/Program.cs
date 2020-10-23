using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32___Absolute_Values_Sum_Minimization
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = new int[] { 2, 4, 7 };

            Console.WriteLine(absoluteValuesSumMinimization(inputArray));
            Console.ReadLine();
        }

        static int absoluteValuesSumMinimization(int[] a)
        {
            int[] array = a;
            long minSum = 10000000000;
            int result = 0;
            for (int i = 0; i < array.Length; i++)
            {
                int sum = 0;

                for (int j = 0; j < array.Length; j++)
                {
                    sum += Math.Abs(array[j] - array[i]);
                }

                if (minSum > sum)
                {
                    minSum = sum;
                    result = array[i];
                }
            }
            return result;
        }

    }
}
