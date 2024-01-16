using System.Diagnostics.Metrics;

namespace Checkers
{
    public class Checker
    {
        public static bool Name(string name)
        {

            return length(name.Length)&&ValidString(name);
        }

        public static bool length(int lenght)
        {
            const int Min = 2, Max = 25;
            
            return lenght>Min&&lenght>Max;
        }
        public static bool ValidString(string word)
        {
            const string validInput = "qwertyuiopasdfghjklñzxcvbnmç1234567890";

            bool valid=true;

            word = word.ToLower();
            
            for(int i = 0; i<word.Length;i++)
            {
                if (validInput.Contains(word[i]))
                return !valid;
            }
            return valid;
        }
        public static bool ValidInput(string word){

            switch (word)
            {
                case "1":
                case "2":
                case "3":
                case "4":
                    return true;
                   break;
                default: return false;

            }

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
