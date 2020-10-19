using System;

namespace _17___Array_Change
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = new int[4] { -1000, 0, -2, 0 };
            Console.WriteLine(arrayChange(inputArray));
        }

        static int arrayChange(int[] inputArray)
        {
            int result = 0;
            for (int i = 1; i < inputArray.Length; i++)
            {
                if (inputArray[i] <= inputArray[i - 1])
                {
                    result += (inputArray[i - 1] - inputArray[i] + 1);
                    inputArray[i] += (inputArray[i - 1] - inputArray[i] + 1);
                }
            }

            return result;
        }

    }
}
