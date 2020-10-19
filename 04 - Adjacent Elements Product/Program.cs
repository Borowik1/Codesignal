using System;

namespace _04___Adjacent_Elements_Product
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = new int[] { 3, 6, -2, -5, 7, 3 };
            Console.WriteLine(adjacentElementsProduct(inputArray));
        }
        static int adjacentElementsProduct(int[] inputArray)
        {
            int prod;
            int prodMax = -1000;
            for (int i = 0; i < (inputArray.Length - 1); i++)
            {
                prod = inputArray[i] * inputArray[i + 1];
                if (prod > prodMax)
                {
                    prodMax = prod;
                }
            }
            return prodMax;
        }
    }

}
