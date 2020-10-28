using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _47___Is_MAC48_Address
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(isMAC48Address("02-03-04-05-06A-07"));
            Console.Read();
        }

        static bool isMAC48Address(string inputString)
        {
            Regex regex = new Regex(@"^([0-9, A-F]{2}[-]){5}[0-9, A-F]{2}$");
            if (regex.IsMatch(inputString))
                return true;
            else
                return false;
        }

    }
}
