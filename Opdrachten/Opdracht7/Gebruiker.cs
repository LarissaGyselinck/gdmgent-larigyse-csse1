using System;    
    
namespace Opdracht7
{
    class Gebruiker : Persoon
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
        public Gebruiker (string voornaam, string familienaam, char geslacht)
        {
            this.voornaam = voornaam;
            Naam = familienaam;
            Geslacht = geslacht;
        }

        public Gebruiker (string voornaam, string familienaam, char geslacht, string gebruikersnaam, string wachtwoord, string login) : base(voornaam, familienaam, geslacht){
            this.LogOutput();
            this.wachtwoord = GenereerWachtwoord();
            this.gebruikersnaam = GenereerGebruikersnaam();
            this.login = GenereerLogin();
			this.LogOutput();
        }

        // Methoden
        public virtual void GenereerWachtwoord()
        {
			string ww = "wachtwoord";
			Console.WriteLine(string.Format("Wachtwoord: {0}", ww));
			this.wachtwoord = GetHashString(ww);
        }

        private string GenereerGebruikersnaam()
        {
			string gebruikersnaam = "";
			string kortvoornaam = GetStartOfString(voornaam, 2);
            string kortfamilienaam = GetStartOfString(familienaam, 3); 
			gebruikersnaam = kortvoornaam.ToLower() + kortfamilienaam.ToLower();       
		}

        private string GenereerLogin()
        {
			string login = "";
			string kloginvoornaam = GetStartOfString(voornaam, 2);
			string kloginfamilienaam = GetStartOfString(familienaam, 3);
			login = kloginvoornaam.ToLower() + kloginfamilienaam.ToLower() + "@arteveldehs.be";
        }

		protected string GetStartOfString(string input, int lengte) {
			return input.Substring(0, lengte);
		}

		public static byte[] GetHash(string inputString)
        {
            HashAlgorithm algorithm = SHA256.Create();
            return algorithm.ComputeHash(Encoding.UTF8.GetBytes(inputString));
        }

        public static string GetHashString(string inputString)
        {
            StringBuilder sb = new StringBuilder();
            foreach (byte b in GetHash(inputString))
                sb.Append(b.ToString("X2"));

            return sb.ToString();
        }

        public override void LogOutput() {
            Console.WriteLine(String.Format("Output: voornaam: {0}, achternaam: {1}, geslacht: {2}, gebruikersnaam: {3}, login: {4}, paswoord: {5}", this.firstname, Lastname, Gender, Username, Login, Password));
        }
    }
}