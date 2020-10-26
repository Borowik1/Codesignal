using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _43___Is_Beautiful_String
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(isBeautifulString("zaa"));
            Console.Read();
        }

        static bool isBeautifulString(string inputString)
        {
            var temp = inputString.ToList<char>();
            temp.Sort();
            int maxPrevChar = 10000000;
            int maxOfOneChar = 1;
            char prevItem = '0';
            foreach (char item in temp)
            {
                if(prevItem == '0')
                {
                    if (item != 'a') return false;
                    prevItem = item;
                    continue;
                }
                else if (prevItem == item)
                {
                    maxOfOneChar++;
                }
                else if (prevItem != item)
                {
                    if (maxPrevChar < maxOfOneChar) return false;                   
                    maxPrevChar = maxOfOneChar;
                    maxOfOneChar = 1;
                    prevItem = item;
                }
            }
            if (maxPrevChar < maxOfOneChar) return false;
            return true;
        }

    }

}
