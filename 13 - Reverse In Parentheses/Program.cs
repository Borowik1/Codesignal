using System;
using System.Linq;
using System.Text;

namespace _13___Reverse_In_Parentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString = "(abc)d(efg)";
            Console.WriteLine(reverseInParentheses(inputString));
        }


        static String reverseInParentheses(String inputString)
        {
            while (inputString.Contains("("))
            {
                int lastOpen = inputString.LastIndexOf("(");
                int firstClose = lastOpen + inputString.Substring(lastOpen).IndexOf(")");
                if ((firstClose - lastOpen) != 1)
                {
                    string tempString = inputString.Substring(lastOpen + 1, (firstClose - lastOpen) - 1);
                    string reversedString = ReverseString(tempString);
                    inputString = inputString.Replace(tempString, reversedString);
                }
                inputString = inputString.Remove(firstClose, 1);
                inputString = inputString.Remove(lastOpen, 1);

            }
            return inputString;
        }

        private static string ReverseString(string tempString)
        {
            char temp;
            string result = "";
            char[] arrayToRevers = tempString.ToCharArray();

            for (int i = 0; i < (arrayToRevers.Length / 2); i++)
            {
                temp = arrayToRevers[i];
                arrayToRevers[i] = arrayToRevers[arrayToRevers.Length - 1 - i];
                arrayToRevers[arrayToRevers.Length - 1 - i] = temp;
            }
            foreach (char item in arrayToRevers)
            {
                result = result + item;
            }

            return result;
        }

    }
}
