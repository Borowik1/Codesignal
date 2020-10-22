using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31___Deposit_Profit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(depositProfit(100, 20, 170));
            Console.Read();
        }

        static int depositProfit(int deposit, int rate, int threshold)
        {
            double amount = deposit;
            int time = 1;
            while (true)
            {
                amount += (amount * ((double)rate / 100));
                if (amount >= threshold)
                {
                    return time;
                }
                time++;
            }

        }
    }

}

