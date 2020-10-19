using System;

namespace _06___Make_Array_Consecutive_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] statues = new int[] { 6, 2, 3, 8 };
            Console.WriteLine(makeArrayConsecutive2(statues));
        }

        static int makeArrayConsecutive2(int[] statues)
        {
            int temp;
            int summOfStatues = 0;
            for (int i = 0; i < statues.Length - 1; i++)
            {
                for (int j = i + 1; j < statues.Length; j++)
                {
                    if (statues[i] > statues[j])
                    {
                        temp = statues[i];
                        statues[i] = statues[j];
                        statues[j] = temp;
                    }
                }
            }
            for (int i = 0; i < statues.Length - 1; i++)
            {
                summOfStatues = summOfStatues + (statues[i + 1] - statues[i] - 1);
            }
            return summOfStatues;

        }

    }
}
