using System;

namespace Recursion
{
    class Recursion
    {
        public static void Main()
        {
            Console.WriteLine(PowRec(5,2));
        }

        public static int PowRec(int basse, int power)
        {
            if (power == 0) return 1;

            return basse * PowRec(basse,power - 1);
        }
    }
}