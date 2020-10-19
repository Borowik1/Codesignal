using System;

namespace _09___All_Longest_Strings
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] inputArray = new string[5] { "aba", "aa", "ad", "vcd", "aba" };
            foreach (string element in allLongestStrings(inputArray))
            {
                Console.WriteLine(element);
            }
            
        }
        static string[] allLongestStrings(string[] inputArray)
        {
            string[] outputArray = new string[NumbetOfLongestStrings(inputArray)];
            int counter = 0;

            foreach (string element in inputArray)
            {
                if (element.Length == FindLongestString(inputArray))
                {
                    outputArray[counter] = element;
                    counter++;
                }
            }

            return outputArray;
        }

        static int FindLongestString(string[] array)
        {
            int longestString = 0;
            foreach (string element in array)
            {
                if (element.Length > longestString)
                {
                    longestString = element.Length;
                }
            }
            return longestString;
        }

        static int NumbetOfLongestStrings(string[] array)
        {
            int result = 0;
            int longestString = FindLongestString(array);

            foreach (string element in array)
            {
                if (element.Length == longestString)
                {
                    result++;
                }
            }

            return result;
        }

    }
}
