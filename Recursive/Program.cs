using System;

namespace Recursion
{
    class Recursion
    {
        public static void Main()
        {
            Console.WriteLine(SumRec(5));
        }

        public static int SumRec(int sum)
        {
            if (sum == 0) return 0;

            return sum+ SumRec(sum-1);
        }
    }
}