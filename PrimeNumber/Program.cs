namespace PrimeNumber
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsPrime(37));
        }
        public static int Prime(int num, int prime =2)
        {
            if (num < 2 || num % prime == 0||num<0) return 0;
            if (num == prime) return num;
        
            return Prime(num, prime + 1);
        }

        public static bool IsPrime(int num)
        {
           return num == Prime(num);
        }
    }
}
