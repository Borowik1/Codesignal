using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _39___Knapsack_Light
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        static int knapsackLight(int value1, int weight1, int value2, int weight2, int maxW)
        {
            if ((weight1 + weight2) <= maxW) return value1 + value2;
            if (weight1 > maxW && weight2 > maxW) return 0;
            if (weight1 == weight2)
            {
                if (value1 > value2)
                    return value1;
                else
                    return value2;
            }
            if (weight1 > maxW) return value2;
            if (weight2 > maxW) return value1;
            if (value1 > value2)
                return value1;
            else
                return value2;
        }


    }
}
