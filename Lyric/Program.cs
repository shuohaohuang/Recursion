using System;

namespace Recursion
{
    class Recursion
    {
        public static void Main()
        {
            const string Lyrics = "{0} pometes té el pomer,\r\nde {0} una, de {0} una," +
                "\r\n{0} pometes té el pomer," +
                "\r\nde {0} una en caigué." +
                "\r\n" +
                "\r\nSi mireu el vent d’on vé" +
                "\r\nveureu el pomer com dansa," +
                "\r\nsi mireu el vent d’on vé" +
                "\r\nveureu com dansa el pomer.";
            //apples=pometes,apple=pometes
            int input=Convert.ToInt32(Console.ReadLine());
            LyricsRec(Lyrics,input);
        }

        public static void LyricsRec(string lyric,int num)
        {
            Console.WriteLine(lyric,num);
            if (num == 1) return;
            LyricsRec(lyric,num-1);

        }
    }
}