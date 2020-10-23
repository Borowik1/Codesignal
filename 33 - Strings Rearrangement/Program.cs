using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _33___Strings_Rearrangement
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputArray = new string[] { "abc", "bef", "bcc", "bec", "bbc", "bdc" };
            Console.WriteLine(stringsRearrangement(inputArray));
            Console.Read();
        }

        static bool stringsRearrangement(string[] inputArray)
        {
            string[] temp = new string[inputArray.Length];
            for (int i = 0; i < inputArray.Length; i++)
            {
                temp = BuildNewArray(inputArray, i);
                if (temp != null) return true;
            }
            return false;
        }

        private static string[] BuildNewArray(string[] array, int v)
        {
            string[] inputArray = new string[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                inputArray[i] = array[i];
            }            
            string[] resultArray = new string[inputArray.Length];
            resultArray[0] = inputArray[v];
            inputArray[v] = null;
            for (int i = 0; i < resultArray.Length - 1; i++)
            {
                for (int j = 0; j < inputArray.Length; j++)
                {
                    int diff = 0;
                    if (inputArray[j] != null)
                    {
                        for (int k = 0; k < resultArray[0].Length; k++)
                        {
                            if (resultArray[i][k] != inputArray[j][k]) diff++;
                        }
                    }
                    if (diff == 1 && inputArray[j] != null)
                    {
                        resultArray[i + 1] = inputArray[j];
                        inputArray[j] = null;
                        break;
                    }
                    if (j == inputArray.Length - 1) return null;
                }
            }
            return resultArray;
        }
    }
}
