using System;    
    
namespace oefening1
{
    public class Gebruiker : Persoon1
    {
        // Velden
        protected string gebruikersnaam;
        protected string wachtwoord;
        protected string login;

        // Properties
        public string Gebruikersnaam
        {
            get
            {
                return gebruikersnaam;
            }
        }

        public string Wachtwoord
        {
            get
            {
                return wachtwoord;
            }
        }

         public string Login
        {
            get
            {
                return login;
            }
        }



        // Constructors
        public Gebruiker (string voornaam, string familienaam, char geslacht, string test)
        {
            this.voornaam = voornaam;
            Naam = familienaam;
            Geslacht = geslacht;
        }

        public Gebruiker (string voornaam, string familienaam, char geslacht) : base(voornaam, familienaam, geslacht){
            this.LogOutput();
            // Genereer Wachtwoord
            this.wachtwoord = GenereerWachtwoord();
            this.gebruikersnaam = GenereerGebruikersnaam();
            this.login = GenereerLogin();
        }

        


        // Methoden
        private string GenereerWachtwoord()
        {
            return "GebruikerGW";
        }

        private string GenereerGebruikersnaam()
        {
            return "GebruikerGN";
        }

        private string GenereerLogin()
        {
            return "GebruikerL";
        }

        public void LogOutput()
        {
            Console.WriteLine(String.Format("Output : Voornaam: {0}, Familienaam: {1}, Geslacht: {2}, geslacht: {3}, Gebruikersnaam: {4}, Login: {5}, Wachtwoord: {6}", this.voornaam, Naam, Geslacht, this.geslacht, Gebruikersnaam, Login, Wachtwoord));
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}