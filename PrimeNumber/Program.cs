namespace PrimeNumber
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Equal(37));
        }
        public static int Prime(int num, int prime =2)
        {
            if (num == prime) return num;
            if (num < 2) return 0;
            if (num % prime == 0)
                return 0;
            return Prime(num, prime + 1);
        }

        public static bool Equal(int num)
        {
           return num == Prime(num);
        }
    }
}
