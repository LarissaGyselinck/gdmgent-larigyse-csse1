using System;

namespace Opdracht4
{
    class Program
    {

        static void Optellen(int getal1, int getal2){
            Console.WriteLine("Optellen");
            int result = getal1 + getal2;
            Console.WriteLine(result);
        }
        static void Aftrekken(int getal1, int getal2){
            Console.WriteLine("Aftrekken");
            int result2 = getal1 - getal2;
            Console.WriteLine(result2);
        }
        static void Vermenigdvuldigen(int getal1, int getal2){
            Console.WriteLine("Vermenigdvuldigen");
            int result3 = getal1 * getal2;
            Console.WriteLine(result3);
        }
        static void Delen(int getal1, int getal2){
            Console.WriteLine("Delen");
            double result4 = (double) getal1 / getal2;
            Console.WriteLine(result4);
        }
        static void Faculteit(int faculteit){
            Console.WriteLine("Faculteit");

            int getal;
            
            Console.WriteLine("Geef een getal in: "); 

            getal = Convert.ToInt32(Console.ReadLine());

            for(int i = 1; i <= getal; i++){      
                faculteit = faculteit * i;      
            }

            Console.WriteLine("Faculteit van " + getal + " is: " + faculteit);
        }
        static void Fibonacci(int getal1, int getal2){
            Console.WriteLine("Fibonacci");

            int getal;
            int getal3;

            Console.WriteLine("Geef een getal in: ");

            getal = Convert.ToInt32(Console.ReadLine()); 

            Console.WriteLine(getal1 + " " + getal2 + " ");

            for(int i = 2; i < getal; ++i)
            {    
                getal3 = getal1 + getal2;    
                Console.WriteLine(getal3 + " ");    
                getal1 = getal2;    
                getal2 = getal3;            
            }
        }
        static void Main(string[] args)
        {

            // Optellen
            Optellen(8, 3);
            // Aftrekken
            Aftrekken(8, 3);
            // Vermenigdvuldigen
            Vermenigdvuldigen(8, 3);
            // Delen
            Delen(8, 3);

            // Faculteit
            Faculteit(1);
            // Fibonacci
            Fibonacci(0, 1);

        }
    }
}
