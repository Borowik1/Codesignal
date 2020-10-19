using System;
using System.Text;

namespace _15___Add_Border
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] picture = new string[1] { "a" };
            
            foreach (string item in addBorder(picture))
            {
                Console.WriteLine(item);
            }
        }

        static string[] addBorder(string[] picture)
        {
            string[] result = new string[picture.Length + 2];            
            StringBuilder bor = new StringBuilder();
            string border = bor.Append('*', picture[0].Length + 2).ToString();

            for (int i = 0; i < picture.Length; i++)
            {
                picture[i] = picture[i].PadLeft(picture[i].Length + 1, '*');
                picture[i] = picture[i].PadRight(picture[i].Length + 1, '*');
            }

            for (int i = 0; i < (picture.Length + 2); i++)
            {
                if (i == 0 || i == picture.Length + 1)
                {
                    result[i] = border;
                }
                else
                {
                    result[i] = picture[i - 1];
                }
            }

            return result;
        }

    }
}
