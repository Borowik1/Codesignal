using System;
using System.Collections;

namespace _16___Are_Similar
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[10] { 832, 998, 148, 570, 533, 561, 894, 147, 455, 279 };
            int[] b = new int[10] { 832, 570, 148, 998, 533, 561, 455, 147, 894, 279 };
            Console.WriteLine(areSimilar(a, b));
        }

        static bool areSimilar(int[] a, int[] b)
        {
            ArrayList difPairs = new ArrayList();

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != b[i])
                {
                    difPairs.Add(i);
                }
            }

            if (difPairs.Count == 0)
            {
                return true;
            }
            else if (difPairs.Count == 1 || difPairs.Count > 2)
            {
                return false;
            }

            if (a[(int)difPairs[0]] == b[(int)difPairs[1]] && a[(int)difPairs[1]] == b[(int)difPairs[0]])
            {
                return true;
            }

            return false;
        }

    }
}
