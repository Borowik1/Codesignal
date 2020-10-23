using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34___Extract_Each_Kth
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int n = 1;
            foreach (int item in extractEachKth(array, n))
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("");
            Console.Read();
        }

        static int[] extractEachKth(int[] inputArray, int k)
        {
            int[] resultArray = new int[] { };
            for (int i = 0; i < inputArray.Length; i++)
            {
                if ((i+1) % k != 0)
                {
                    resultArray = AddElement(inputArray[i], resultArray);
                }
            }
            return resultArray;
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
