using System;

namespace _01___Add
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            a = 2;
            b = 5;
            Console.WriteLine(add(a, b));
        }

        static int add(int param1, int param2)
        {
            return param1 + param2;
        }
    }
}
