using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {

            // Fibonacci

            int i;
            int getal;
            int getal1 = 0;
            int getal2 = 1;
            int getal3;

            Console.WriteLine("Geef een getal in: ");

            getal = Convert.ToInt32(Console.ReadLine()); 

            Console.WriteLine(getal1 + " " + getal2 + " ");

            for(i = 2; i < getal; ++i)
            {    
                getal3 = getal1 + getal2;    
                Console.WriteLine(getal3 + " ");    
                getal1 = getal2;    
                getal2 = getal3;            
            }
        }
    }
}
