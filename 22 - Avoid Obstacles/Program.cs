using System;
using System.Linq;

namespace _22___Avoid_Obstacles
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = new int[] { 5, 8, 9, 13, 14 };
            Console.WriteLine(avoidObstacles(inputArray));
        }

        private static int avoidObstacles(int[] inputArray)
        {            
            int maxElement = findMax(inputArray);

            for (int i = 1; true; i++)
            {
                for (int j = 1; j <= maxElement; j++)
                {
                    if (inputArray.Contains(j * i))
                    {
                        break;
                    }
                    else if ((j * i) > maxElement)
                    {
                        return i;
                    }
                }
            }
        }

        private static int findMax(int[] inputArray)
        {
            int max = 0;
            foreach (int item in inputArray)
            {
                if (item > max) { max = item; }
            }
            return max;
        }
    }
}
