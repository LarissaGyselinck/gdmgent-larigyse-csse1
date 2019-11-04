using System;

namespace Account
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Account generator
            Docenten: 4 letters voornaam & 2 letter familienaam
            Studenten: 4 letters voornaam & 4 letter familienaam
            */

            try{
                SchrijfLog(args.Length);
                SchrijfLog(args[0]);
            } catch (System.IndexOutOfRangeException){
                SchrijfLog("De collectie is ledig.");
            } catch (System.Exception){
                SchrijfLog("Er is een probleem.");
            } 

            Console.WriteLine("Registratie van een student");
            SchrijfLog("Geef de voornaam in voor de student: ");
            string voornaam = Console.ReadLine();
            SchrijfLog("Geef de naam in van de student: ");
            string naam = Console.ReadLine();
            Console.WriteLine("Aanmaak van de account van een student ...");
            SchrijfLog(GenereerAccount(voornaam, naam));
        }
        static void SchrijfLog(string output) => Console.WriteLine(output);
        static void SchrijfLog(int output) => Console.WriteLine(output.ToString());
        static string GenereerAccount(string voornaam, string familienaam){
            return String.Format("De account van {0} {1} is: {2}", voornaam, familienaam, GenereerString(voornaam.ToLower(), 4) + GenereerString(familienaam.ToLower(),4));
        }
        static string GenereerString(string input, int lengte){
            return input.Substring(0, lengte);
        }
    }
}
