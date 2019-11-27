using System;    
    
namespace Opdracht7
{
    class Docent : Gebruiker
    {
        // Constructors
        public Docent (string voornaam, string familienaam, char geslacht) : base(voornaam, familienaam, geslacht){
            this.LogOutput();
            base.wachtwoord = GenereerWachtwoord();
            base.gebruikersnaam = GenereerGebruikersnaam();
            base.login = GenereerLogin();
            this.LogOutput(); 
        }

        // Methoden
        public override void GenereerWachtwoord()
        {
            string ww = "wachtwoordD";
			Console.WriteLine(String.Format("Wachtwoord: {0}", ww));
			this.wachtwoord = GetHashString(ww);
        }

        private string GenereerGebruikersnaam()
        {
			string gebruikersnaam = "";
			string kortvoornaam = GetStartOfString(voornaam, 4);
            string kortfamilienaam = GetStartOfString(familienaam, 2); 
			gebruikersnaam = kortvoornaam.ToLower() + kortfamilienaam.ToLower();       
		}

        private string GenereerLogin()
        {
			string login = "";
			string kloginvoornaam = GetStartOfString(voornaam, 4);
			string kloginfamilienaam = GetStartOfString(familienaam, 2);
			login = kloginvoornaam.ToLower() + kloginfamilienaam.ToLower() + "@arteveldehs.be";
        }

        public override void LogOutput() {
            Console.WriteLine(String.Format("Output: voornaam: {0}, achternaam: {1}, geslacht: {2}, gebruikersnaam: {3}, login: {4}, paswoord: {5}", this.firstname, Lastname, Gender, Username, Login, Password));
        }
    }
}