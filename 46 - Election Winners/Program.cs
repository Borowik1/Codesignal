using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _46___Election_Winners
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(electionsWinners(new int[] { 1, 1, 1, 1 }, 1));
            Console.Read();
        }

        static int electionsWinners(int[] votes, int k)
        {
            int result = 0;
            int i = 0;
            votes = Sort(votes);
            if (votes[0] == votes[1]&&k==0)
            {
                return 0;
            }

            if (k == 0)
                return 1;

            while (votes[i] + k > votes[0])
            {
                result++;
                i++;
                if (i==votes.Length)
                {
                    return result;
                }
            }
            return result;
        }


        private static int[] Sort(int[] array)
        {
            int temp;
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] < array[j])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
            return array;
        }


    }
}
