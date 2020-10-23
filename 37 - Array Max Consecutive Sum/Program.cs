using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _37___Array_Max_Consecutive_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 3, 2, 4 };
            int k = 3;
            Console.WriteLine(arrayMaxConsecutiveSum(array, k));
            Console.ReadLine();
        }

        static int arrayMaxConsecutiveSum(int[] inputArray, int k)
        {
            int maxSumm = 0;
            for (int i = 0; i < (inputArray.Length - k + 1); i++)
            {
                int summ = 0;
                for (int j = 0; j < k; j++)
                {
                    summ += inputArray[i + j];
                }
                if (summ > maxSumm) maxSumm = summ;
            }
            return maxSumm;
        }
    }
}
