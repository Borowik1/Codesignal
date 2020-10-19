using System;

namespace _12___Sort_by_Height
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[8] { -1, 150, 190, 170, -1, -1, 160, 180 };
            foreach (int item in sortByHeight(a))
            {
                Console.WriteLine(item);
            }

        }

        static int[] sortByHeight(int[] inputArray)
        {
            int[] outputArray = new int[inputArray.Length];
            int[] treesPosition = NumberOfTrees(inputArray);
            int[] arrayWithoutTrees = RemoveTrees(inputArray, treesPosition);
            arrayWithoutTrees = Sort(arrayWithoutTrees);
            outputArray = ReturnTrees(arrayWithoutTrees, treesPosition);
            return outputArray;
        }

        private static int[] ReturnTrees(int[] arrayWithoutTrees, int[] treesPosition)
        {
            int[] outputArray = new int[arrayWithoutTrees.Length + treesPosition.Length];
            int counter = 0;
            for (int i = 0; i < outputArray.Length; i++)
            {
                if (IsTree(i, treesPosition))
                {
                    outputArray[i] = -1;
                    counter++;
                }
                else
                {
                    outputArray[i] = arrayWithoutTrees[i - counter];
                }
            }
            return outputArray;
        }

        private static int[] Sort(int[] array)
        {
            int temp;
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
            return array;
        }

        private static int[] RemoveTrees(int[] inputArray, int[] treesPosition)
        {
            int[] outputArray = new int[inputArray.Length - treesPosition.Length];
            int counter = 0;

            for (int i = 0; i < inputArray.Length; i++)
            {

                if (IsTree(i, treesPosition))
                {
                    counter++;
                }
                else
                {
                    outputArray[i - counter] = inputArray[i];
                }
            }

            return outputArray;
        }

        private static bool IsTree(int item, int[] inputArray)
        {
            foreach (int i in inputArray)
            {
                if (i == item)
                {
                    return true;
                }
            }
            return false;
        }

        private static int[] NumberOfTrees(int[] inputArray)
        {
            int counter = 0;
            foreach (int item in inputArray)
            {
                if (item == -1)
                {
                    counter++;
                }
            }
            int[] trees = new int[counter];
            counter = 0;
            for (int i = 0; i < inputArray.Length; i++)
            {
                if (inputArray[i] == -1)
                {
                    trees[i - counter] = i;

                }
                else
                {
                    counter++;
                }
            }

            return trees;
        }
    }
}
