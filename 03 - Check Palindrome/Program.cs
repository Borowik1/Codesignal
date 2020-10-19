using System;

namespace _03___Check_Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString = "aabaa";
            Console.WriteLine(checkPalindrome(inputString));
        }

        static bool checkPalindrome(string inputString)
        {
            int len = inputString.Length;
            for (int i = 0; i < (len / 2); i++)
            {
                if (inputString[i] != inputString[len - 1 - i])
                {

                    return false;
                }
            }
            return true;
        }

    }
}
