using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace _21___Is_IPv4_Address
{
    class Program
    {
        static void Main(string[] args)
        {
            string address = "172.16.254.1";
            Console.WriteLine(isIPv4Address(address));
            Console.Read();
        }

        static bool isIPv4Address(string inputString)
        {
            if (!Regex.IsMatch(inputString, @"^([0-9]{1,3}['.']){3}[0-9]{1,3}$"))
            {
                return false;
            }
            if (Regex.IsMatch(inputString, @"[0]{1,3}\d"))
            {
                return false;
            }

            string[] splittedAddress = inputString.Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string item in splittedAddress)
            {
                if (item == "00")
                {
                    return false;
                }
                else
                {
                    int b = int.Parse(item);
                    if (b < 0 || b > 255)
                    {
                        return false;
                    }
                }
            }

            return true; ;
        }
    }
}
