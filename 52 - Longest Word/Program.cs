using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _52___Longest_Word
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(longestWord("A!! AA[]z"));
            Console.ReadLine();
        }

        static string longestWord(string text)
        {
            string[] words = text.Split(new char[] { '?', '!', '{', '}', '(', ')', '[', ']', ' ', ',', '.', '@', '#', '$', '%', '^', '&', '*', '-', '_' }, StringSplitOptions.RemoveEmptyEntries);
            string longestString = "";
            foreach (string word in words)
            {
                if (longestString.Length < word.Length)
                    longestString = word;
            }
            return longestString;
        }

    }
}
