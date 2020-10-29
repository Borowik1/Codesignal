using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _53___Valid_Time
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(validTime("23:59"));
            Console.Read();
        }

        static bool validTime(string time)
        {
            string[] vs = time.Split(':');
            int hours = Convert.ToInt32(vs[0]);
            int minutes = Convert.ToInt32(vs[1]);
            if (hours < 24 && minutes < 60)
            {
                return true;
            }
            return false;
        }

    }
}
