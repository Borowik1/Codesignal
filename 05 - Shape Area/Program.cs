using System;

namespace _05___Shape_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            int shapeDimension = 3;
            Console.WriteLine(shapeArea(shapeDimension));
        }

        static int shapeArea(int n)
        {
            return ((n * n) + ((n - 1) * (n - 1)));
        }

    }
}
