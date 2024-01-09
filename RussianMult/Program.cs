using System;

namespace Recursion
{
    class Recursion
    {
        public static void Main()
        {
            Console.WriteLine(RussianMult(12,12));
            Console.WriteLine(RussianMultIterative(12, 12));
        }
        public static int RussianMultIterative(int num, int secondNum)
        {
            int result = 0;
            for (int i = num; i >=1; i/=2) 
            {
                if (i % 2 == 1) result += secondNum;
                secondNum*=2;
            }
            return result;
        }
        public static int RussianMult(int num, int secondNum)
        {
            if (num==1) return secondNum;
            if (num % 2 == 1) return secondNum + RussianMult(num / 2, secondNum * 2);
            return RussianMult(num/2,secondNum*2);
        }
    }
}