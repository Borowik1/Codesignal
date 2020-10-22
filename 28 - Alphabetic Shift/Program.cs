using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28___Alphabetic_Shift
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString = "crazy";
            Console.WriteLine(alphabeticShift(inputString));
            Console.Read();
        }

        static string alphabeticShift(string inputString)
        {
            string result = "";
            char[] array = inputString.ToCharArray();
            foreach (char item in array)
            {
                int vs = item;
                if (vs == 122)
                    vs = 97;
                else
                    vs++;

                result += (char)vs;
            }
            return result;
        }

    }
}
