using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _44___Find_Email_Domain
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(findEmailDomain("fully-qualified-domain@codesignal.com"));
            Console.ReadLine();
        }
        static string findEmailDomain(string address)
        {
            Regex regex = new Regex(@"[^@]*[@]");
            return regex.Replace(address, "");
        }

    }
}
