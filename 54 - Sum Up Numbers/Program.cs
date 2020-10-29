using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _54___Sum_Up_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(sumUpNumbers("123450"));
            Console.Read();
        }

        static int sumUpNumbers(string inputString)
        {
            List<string> numbers = new List<string>();
            for (int i = 0; i < inputString.Length; i++)
            {
                if((int)inputString[i]<=57 && (int)inputString[i] >= 48)
                {
                    string number = "";
                    while ((int)inputString[i] <= 57 && (int)inputString[i] >= 48)
                    {
                        number += inputString[i];
                        i++;
                        if (i >= inputString.Length)
                            break;
                    }
                    numbers.Add(number);
                }
            }
            int sum = 0;
            foreach (string item in numbers)
            {
                int result = 0;
                if (Int32.TryParse(item, out result))
                    sum += result;
            }
            return sum;
        }

    }
}
