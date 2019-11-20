using System;    
    
namespace Opdracht6
{
    public class Docent : Gebruiker
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
    }
}