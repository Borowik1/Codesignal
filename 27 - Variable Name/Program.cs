using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _27___Variable_Name
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "11var_1__Int";
            Console.WriteLine(variableName(name));
            Console.Read();
        }

        static bool variableName(string name)
        {
            return Regex.IsMatch(name, @"^[a-zA-Z_]{1}([a-zA-Z_0-9])*$");
        }

    }
}
