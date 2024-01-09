using System;

namespace Recursion
{
    class Recursion
    {
        public static void Main()
        {
            Console.WriteLine(FactRec(6));
        }

        public static int FactRec(int factrial)
        {
            if (factrial == 0|| factrial ==1) return 1;

            return factrial * FactRec(factrial - 1);
        }
    }
}