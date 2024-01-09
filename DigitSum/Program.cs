namespace DigitSum
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine(SumDigitRec(123456789));
        }
        public static int SumDigitRec(int num)
        {
            if (num/10<1) return num;
            return num%10+ SumDigitRec(num/10);
        }
    }
}
