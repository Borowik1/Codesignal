using System;

namespace _10__Common_Character_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "zzzz";
            string s2 = "zzzzzzz";

            Console.WriteLine(commonCharacterCount(s1, s2));
        }

        static int commonCharacterCount(string s1, string s2)
        {
            int result = 0;
            int counter1 = 0;
            int counter2 = 0;
            string commonChars = FindCommonChars(s1, s2);

            foreach (char letter in commonChars)
            {
                foreach (char letter1 in s1)
                {
                    if (letter == letter1)
                    {
                        counter1++;
                    }
                }
                foreach (char letter2 in s2)
                {
                    if (letter == letter2)
                    {
                        counter2++;
                    }
                }
                result += Math.Min(counter1, counter2);
                counter1 = 0;
                counter2 = 0;
            }
            return result;
        }

        private static string FindCommonChars(string s1, string s2)
        {
            string result = "";

            if (s1.Length >= s2.Length)
            {
                foreach (char letter in s1)
                {
                    if (s2.Contains(letter) && !result.Contains(letter))
                    {
                        result += letter;
                    }                
                }
            }
            else
            {
                foreach (char letter in s2)
                {
                    if (s1.Contains(letter) && !result.Contains(letter))
                    {
                        result += letter;
                    }
                }

            }

            return result;
        }
    }
}
