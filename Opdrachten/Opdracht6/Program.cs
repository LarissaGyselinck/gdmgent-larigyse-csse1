using System;

namespace Opdracht6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Persoon--");
            Persoon p = new Persoon("Larissa", "Gyselinck", "V");
            p.LogOutput();
            Console.WriteLine("--Gebruiker--");
            Gebruiker g = new Gebruiker("Larissa", "Gyselinck", "V");
            g.LogOutput();
            Console.WriteLine("--Docent--");
            Docent d = new Docent("Larissa", "Gyselinck", "V");
            d.LogOutput();
            Console.WriteLine("--Student--");
            Student s = new Student("Larissa", "Gyselinck", "V");
            s.LogOutput();
        }
    }
}
