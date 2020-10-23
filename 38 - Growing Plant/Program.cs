using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _38___Growing_Plant
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        int growingPlant(int upSpeed, int downSpeed, int desiredHeight)
        {
            int height = 0;
            int days = 0;
            while (true)
            {
                days++;
                height += upSpeed;
                if (height >= desiredHeight) return days;
                height -= downSpeed;

            }
        }

    }
}
