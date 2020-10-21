using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25___Array_Replace
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = new int[] { 1, 2, 3, 4, 5 };
            int elemToReplace = 3;
            int substitutionElem = 0;

            foreach (int item in arrayReplace(inputArray,elemToReplace,substitutionElem))
            {
                Console.Write(item + " ");
            }
            Console.Write("\n");
            Console.Read();
        }
        static int[] arrayReplace(int[] inputArray, int elemToReplace, int substitutionElem)
        {
            for (int i = 0; i <inputArray.Length; i++)
            {
                if(inputArray[i] == elemToReplace)
                {
                    inputArray[i] = substitutionElem;
                }
            }
            return inputArray;
        }
    }
}
