using System;

namespace _19___Are_Equally_Strong
{
    class Program
    {
        static void Main(string[] args)
        {
            int yourLeft = 10;
            int yourRight = 15;
            int friendsLeft = 15;
            int friendsRight = 10;
            Console.WriteLine(areEquallyStrong(yourLeft, yourRight, friendsLeft, friendsRight));
        }

        static bool areEquallyStrong(int yourLeft, int yourRight, int friendsLeft, int friendsRight)
        {
            if (yourLeft == friendsLeft && yourRight == friendsRight)
            {
                return true;
            }
            else if (yourLeft == friendsRight && yourRight == friendsLeft)
            {
                return true;
            }
            else
            {
                return false;
            }           
        }

    }
}
