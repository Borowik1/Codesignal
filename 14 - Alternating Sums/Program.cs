using System;

namespace _14___Alternating_Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] peopleWeight = new int[5] { 50, 60, 60, 45, 70 };
            int[] result = new int[2];
            result = alternatingSums(peopleWeight);

            foreach (int item in result)
            {
                Console.WriteLine(item);
            }           
        }

        static int[] alternatingSums(int[] a)
        {
            int[] result = new int[2];
            bool b = true;
            foreach (int item in a)
            {
                if (b)
                {
                    result[0] += item;
                    b = false;
                }
                else
                {
                    result[1] += item;
                    b = true;
                }
            }
            return result;
        }

    }
}
