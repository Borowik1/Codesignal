using System;

namespace _20___Array_Maximal_Adjacent_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = new int[] { -14, 15, -15 };
            Console.WriteLine(arrayMaximalAdjacentDifference(inputArray));
        }

        static int arrayMaximalAdjacentDifference(int[] inputArray)
        {
            int maxDifference = 0;

            for (int i = 0; i < inputArray.Length - 1; i++)
            {
                int dif = Math.Abs(inputArray[i] - inputArray[i+1]);

                if (dif > maxDifference)
                {
                    maxDifference = dif;
                }
            }

            return maxDifference;
        }

    }
}
