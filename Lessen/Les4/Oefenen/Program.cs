using System;

namespace Oefenen
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
                Fahrenheit
            */

            // 5.0 en 9.0 moet met double, als met int wilt dan gewoon 5 en 9
            double fahr = 100;
            double cels = (fahr - 32) * (5.0 / 9.0);

            Console.WriteLine(cels);

            /*
                Boolean
            */

            Console.WriteLine(sizeof(System.Boolean).ToString());
            Console.WriteLine(sizeof(System.Int32).ToString());
            Console.WriteLine(sizeof(System.Int64).ToString());
            Console.WriteLine(System.Runtime.InteropServices.Marshal.SizeOf(new System.Boolean()));

            /*
                Char
                Met deze regel code:
                    Maak je een char variabele met de naam a (declareren)
                    Ken je de waarde c toe aan de variabele a (initialiseren)
                De waarde c van een char variabele a, wordt altijd tussen enkele aanhalingstekens geschreven!
            */

            // char a = 'c';
            // a = 'b';
            
            // Deze regel wijzigt de waarde van de variabele a naar de letter b

            /*
                String
            */

            string mijnString = "Dit is mijn eerste regel tekst...";
            Console.WriteLine(mijnString);
            string mijnString2 ="Dit is mijn eerst\nregel tekst...";
            Console.WriteLine(mijnString2);

            // Declareer en initialiseer een string
            string mijnString3 = "hallo";
            string mijnString4 = "Iedereen";
            // Samenvoegingen van de string met een spatie tussen ...
            string mijnString5 = mijnString3 + " " + mijnString4;
            // Het resultaat weergeven...
            Console.WriteLine(mijnString5);

            /*
                Decimale waarden
            */

            //const double Interest = 0.80;

            // Voorbeelden met decimal waarden
            int x = 14;
            int y = 8;
            int result1 = x + y; // Result1 = 22
            int result2 = x - y; // Result2 = 6
            int result3 = x * y; // result3 = 112
            int result4 = x / y; // result4 = 1

            decimal c = 8.5m;
            decimal b = 3.4m;
            decimal result11 = c + b; // Result11 = 11.9
            Console.WriteLine("c + b: " + result11);
            decimal result12 = c - b; // Result12 = 5.1

            // Voorbeelden met char waarden
            char letter1 = 'C';
            char letter2 = ++letter1;
            Console.WriteLine("letter1: " + letter1.ToString());        }
    }
}
