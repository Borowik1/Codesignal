using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _45___Build_Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(buildPalindrome("euotmn"));
            Console.Read();
        }

        static string buildPalindrome(string st)
        {
            if (checkPalindrome(st))
                return st;
            int len = st.Length;
            for (int i = 0; i <= len; i++)
            {
                string palindromeString = st;
                for (int j = 0; j <= i; j++)
                {
                    palindromeString += st[i - j];
                }
                if (checkPalindrome(palindromeString))
                    return palindromeString;
            }
            return null;
        }

        static bool checkPalindrome(string inputString)
        {
            int len = inputString.Length;
            for (int i = 0; i < (len / 2); i++)
            {
                if (inputString[i] != inputString[len - 1 - i])
                    return false;
            }
            return true;
        }

    }
}
