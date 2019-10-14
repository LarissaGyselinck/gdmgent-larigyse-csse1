using System;

namespace Oefening4_Faculteit
{
    class Program
    {
        static void Main(string[] args)
        {

            // Faculteit

            int faculteit = 1;
            int i;
            int getal;
            
            Console.WriteLine("Geef een getal in: "); 

            getal = Convert.ToInt32(Console.ReadLine());

            for(i = 1; i <= getal; i++){      
                faculteit = faculteit * i;      
            }

            Console.WriteLine("Faculteit van " + getal + " is: " + faculteit); 

        }
    }
}
