using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _40___Longest_Digits_Prefix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(longestDigitsPrefix("0123456789"));
            Console.ReadLine();
        }

        static string longestDigitsPrefix(string inputString)
        {
            string result = "";
            foreach (char item in inputString)
            {
                if ((int)item >= 48 && (int)item <= 57)
                {
                    result += item.ToString();
                }
                else
                {
                    return result;
                }
            }
            return result;
        }

    }
}
