using System;    
    
namespace oefening1
{
    public class Student : Gebruiker
    {
        // Velden

        // Properties

        // Constructors
        public Student (string voornaam, string familienaam, char geslacht) : base(voornaam, familienaam, geslacht){
            LogOutput();
            // Genereer Wachtwoord
            base.wachtwoord = GenereerWachtwoord();
            base.gebruikersnaam = GenereerGebruikersnaam();
            base.login = GenereerLogin();
        }

        
        // Methoden
        private string GenereerWachtwoord()
        {
            return "StudentGW";
        }

        private string GenereerGebruikersnaam()
        {
            return "StudentGN";
        }

        private string GenereerLogin()
        {
            return "StudentL";
        }

        public void LogOutput()
        {
            Console.WriteLine(String.Format("Output: Voornaam: {0}, Familienaam: {1}, Geslacht: {2}, geslacht: {3}, Gebruikersnaam: {4}, Login: {5}, Wachtwoord: {6}", this.voornaam, Naam, Geslacht, this.geslacht, Gebruikersnaam, Login, Wachtwoord));
        }
    }
}