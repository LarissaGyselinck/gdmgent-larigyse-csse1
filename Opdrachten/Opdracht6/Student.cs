using System;    
    
namespace Opdracht6
{
    public class Student : Gebruiker
    {
        public Student (string voornaam, string familienaam, char geslacht) : base(voornaam, familienaam, geslacht){
            LogOutput();
            base.wachtwoord = GenereerWachtwoord();
            base.gebruikersnaam = GenereerGebruikersnaam();
            base.login = GenereerLogin();
        }

        // Methoden
        public override void GenereerWachtwoord()
        {
            string ww = "wachtwoordS";
			Console.WriteLine(String.Format("Wachtwoord: {0}", ww));
			this.wachtwoord = GetHashString(ww);
        }

        private string GenereerGebruikersnaam()
        {
			string gebruikersnaam = "";
			string kortvoornaam = GetStartOfString(voornaam, 4);
            string kortfamilienaam = GetStartOfString(familienaam, 4); 
			gebruikersnaam = kortvoornaam.ToLower() + kortfamilienaam.ToLower();       
		}

        private string GenereerLogin()
        {
			string login = "";
			string kloginvoornaam = GetStartOfString(voornaam, 4);
			string kloginfamilienaam = GetStartOfString(familienaam, 4);
			login = kloginvoornaam.ToLower() + kloginfamilienaam.ToLower() + "@student.arteveldehs.be";
        }
    }
}