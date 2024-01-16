namespace Checkers
{
    public class Checker
    {
        public static bool Name(string name)
        {

            return Word(name.Length)&&Word(name);
        }

        public static bool Word(int lenght)
        {
            const int Min = 2, Max = 25;
            
            return lenght>Min&&lenght>Max;
        }
        public static bool Word(string word)
        {

            return false;
        }

        public static bool InRange(int value, int min, int max)
        {
            return false;
        }
    }

    public static class Nums
    {
        public static int Split (int value, int divisor)
        {
            const int Zero= 0;
            if (divisor==Zero)
                return 0;
            return value / divisor;
        }
        public static int CountVowel(string word)
        {
            const string Vowel = "aeiou";

            int counter = 0;

            word = word.ToLower();
            foreach (char a in word)
            {
                if(Vowel.Contains(a))
                    counter++;
            }
            return counter;
        }
    }


}
