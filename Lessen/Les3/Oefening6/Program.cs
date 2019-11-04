using System;

namespace Oefening6
{
    class Program
    {
        static void Main(string[] args)
        {

            /* Overloop alle karakters van een opgegeven zin en druk deze karakter per karakter af in de Console. */

            String zin = "Dit is een zin...";
            foreach (char ch in zin.ToCharArray())
            {
                Console.WriteLine(ch);
            }
        }
    }
}
