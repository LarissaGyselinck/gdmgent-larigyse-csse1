using System;    
    
namespace oefening1
{
    public class Docent : Gebruiker
    {
        // Velden

        // Properties

        // Constructors
        public Docent (string voornaam, string familienaam, char geslacht) : base(voornaam, familienaam, geslacht){
            this.LogOutput();
            // Genereer Wachtwoord
            base.wachtwoord = GenereerWachtwoord();
            base.gebruikersnaam = GenereerGebruikersnaam();
            base.login = GenereerLogin();
            this.LogOutput();
        }
        
        // Methoden
        private string GenereerWachtwoord()
        {
            return "DocentGW";
        }

        private string GenereerGebruikersnaam()
        {
            return "DocentGN";
        }

        private string GenereerLogin()
        {
            return "DocentL";
        }

        public void LogOutput()
        {
            Console.WriteLine(String.Format("Output: Voornaam: {0}, Familienaam: {1}, Geslacht: {2}, geslacht: {3}, Gebruikersnaam: {4}, Login: {5}, Wachtwoord: {6}", this.voornaam, Naam, Geslacht, this.geslacht, Gebruikersnaam, Login, Wachtwoord));
        }
    }
}