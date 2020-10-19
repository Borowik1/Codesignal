using System;
using System.Collections;

namespace _18___Palindrome_Rearranging
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaabbbccccaaaaaaaaaaaaa";
            Console.WriteLine(palindromeRearranging(inputString));
        }

        static bool palindromeRearranging(string inputString)
        {
            ArrayList list = new ArrayList();
            while (inputString != "")
            {
                int quantity = inputString.Length;
                int difference = 0;
                inputString = RemoveChar(inputString);
                difference = quantity - inputString.Length;
                list.Add(difference);
            }

            int oddQuantity = 0;
            foreach (int item in list)
            {
                if (item % 2 != 0)
                {
                    oddQuantity++;
                }
            }

            if (oddQuantity < 2)
            {
                return true;
            }

            return false;
        }

        private static string RemoveChar(string inputString)
        {
            char element = inputString[0];
            string result = "";
            foreach (char item in inputString)
            {
                if (item != element)
                {
                    result = result + item;
                }
            }

            return result;
        }
    }
}
