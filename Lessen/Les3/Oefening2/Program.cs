using System;

namespace Oefening2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Oefening A: Tafel 5
            */

            Console.WriteLine("Deel A");

            int tafel = 5;
            // int i = 5; 

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("" + i + " x " + tafel + " = " + i*tafel);
            }

            /*
                Oefening B: Alle tafels van 1 tot 10
            */

            Console.WriteLine("Deel B");

            for (int i = 0; i <= 10; i++)
            {
                for (int j = 0; j <= 10; j++)
                {
                    Console.WriteLine("" + j + " x " + i + " = " + i*tafel);
                }
            }

            /*
                Oefening C: Geef een getal in
            */

            Console.WriteLine("Deel C");
            Console.WriteLine("Geef een getal in waarvan je de vermenigvuldigingstafel wilt zien: ");

            int specifiekeTafel = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("" + i + " x " + specifiekeTafel + " = " + i*specifiekeTafel);
            }

        }
    }
}
