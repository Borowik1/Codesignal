using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23___Box_Blur
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] inputImage = new int[4][];
            inputImage[0] = new int[] { 7, 4, 0, 1 };
            inputImage[1] = new int[] { 5, 6, 2, 2 };
            inputImage[2] = new int[] { 6, 10, 7, 8 };
            inputImage[3] = new int[] { 1, 4, 2, 0 };
            int[][] result = boxBlur(inputImage);
            Console.Read();

        }

        static int[][] boxBlur(int[][] image)
        {
            int heightOfResultPicture = image.Length - 2;
            int widthOfResultPicture = image[0].Length - 2;
            int[][] result = new int[heightOfResultPicture][];

            for (int z = 0; z < heightOfResultPicture; z++)
            {
                result[z] = new int[widthOfResultPicture];                
            }

            for (int i = 0; i < result.Length; i++)
            {
                for (int j = 0; j < result[0].Length; j++)
                {
                    int vs = 0;
                    for (int k = 0; k < 3; k++)
                    {
                        for (int m = 0; m < 3; m++)
                        {
                            vs += image[k + i][m + j];
                        }
                    }
                    vs = vs / 9;
                    result[i][j] = vs;
                }
            }
            return result;
        }

    }
}
