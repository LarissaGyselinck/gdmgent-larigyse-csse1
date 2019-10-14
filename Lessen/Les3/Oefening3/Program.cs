using System;

namespace Oefening3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Oefening A: Tafel 5 met while loop
            */

            Console.WriteLine("Deel A met while loop");

            int tafel = 5;
            int i = 0;

            while(i <= 10)
            {
                Console.WriteLine("" + i + " x " + tafel + " = " + i*tafel);
                i++;
            }

            /*
                Oefening B: Alle tafels van 1 tot 10 met while loop
            */

            Console.WriteLine("Deel B met while loop");

            int j = 0;

            while(i <= 10)
            {
                while(j <= 10)
                {
                    Console.WriteLine("" + j + " x " + i + " = " + i*tafel);   
                }
            }

            /*
                Oefening C: Geef een getal in met while loop
            */

            Console.WriteLine("Deel C met while");
            Console.WriteLine("Geef een getal in waarvan je de vermenigvuldigingstafel wilt zien: ");

            int specifiekeTafel = Convert.ToInt32(Console.ReadLine());

            while(i <= 10)
            {
                Console.WriteLine("" + i + " x " + specifiekeTafel + " = " + i*specifiekeTafel);
            }

        }
    }
}
