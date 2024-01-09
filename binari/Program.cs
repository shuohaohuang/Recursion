using System;

namespace Recursion
{
    class Recursion
    {
        public static void Main()
        {
            Console.WriteLine(BinariRec(5));
        }

        public static int BinariRec(int num)
        {
            if (num == 0) return 0;
            if (num == 1) return 1;
            return num%2+BinariRec(num/2)*10;

        }
    }
}