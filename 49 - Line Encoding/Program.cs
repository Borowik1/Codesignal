using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _49___Line_Encoding
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(lineEncoding("abbbcc"));
            Console.Read();
        }

        static string lineEncoding(string s)
        {
            string res = "";
            int counter = 1;
            for (int i = 1; i < s.Length; i++)
            {
                if (s[i - 1] == s[i])
                {
                    counter++;
                }
                else
                {
                    if (counter == 1)
                    {
                        res += s[i - 1];
                    }
                    else
                    {
                        res += counter.ToString() + s[i - 1];
                    }
                    counter = 1;
                }
            }
            if (counter == 1)
            {
                res += s[s.Length - 1];
            }
            else
            {
                res += counter.ToString() + s[s.Length - 1];
            }
            return res;
        }
    }
}
