using System;

namespace _06___Almost_Increasing_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] m =new int[6] { 1, 2, 3, 4, 3, 6 };
            Console.WriteLine(almostIncreasingSequence(m));
            Console.Read();
        }

        static bool almostIncreasingSequence(int[] sequence)
        {

            int[] sequence2 = sequence;
            int elementBeforeDecreasing = CheckSequence(sequence);

            if (CheckSequence(sequence) == -1)
            {
                return true;
            }
            else
            {
                sequence = RemoveElement(sequence, elementBeforeDecreasing);
                sequence2 = RemoveElement(sequence2, (elementBeforeDecreasing + 1));
                
                if (CheckSequence(sequence) == -1 || CheckSequence(sequence2) == -1)
                {
                    return true;
                }               
            }

            return false;
        }
        public static int[] RemoveElement(int[] sequence, int numberOfElementToRemove)
        {
            int[] resultSequence =new int[sequence.Length-1];

            for (int i = 0; i < resultSequence.Length; i++)
            {
                if (i < numberOfElementToRemove)
                {
                    resultSequence[i] = sequence[i];
                }
                else
                {
                    resultSequence[i] = sequence[i + 1];
                }
            }
            return resultSequence;
        }
        public static int CheckSequence(int[] sequence)
        {
            for (int i = 0; i < sequence.Length - 1; i++)
            {
                if (sequence[i] >= sequence[i + 1])
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
