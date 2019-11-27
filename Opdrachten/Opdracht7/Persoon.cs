using System;

namespace Opdracht7
{
    class Persoon : Logging
    {
        // Velden
        public string voornaam;
        private char geslacht;

        // Properties
        
        public char Geslacht
        {
           get 
           { 
               return geslacht; 
           }
           set 
           { 
               geslacht = value;
            }
        }
        
        public string Naam
        {
            get;
            set;
        }

        // Constructors
        public Persoon()
        {

        }
        public Persoon(string voornaam, string naam)
        {

        }
        public Persoon(string voornaam, string naam, char geslacht)
        {
            Naam = naam;
            this.voornaam = voornaam;
            Geslacht = geslacht;
        }

        public void LogOutput() {
            Console.WriteLine(String.Format("Output: voornaam: {0}, achternaam: {1}, geslacht: {2}, gebruikersnaam: {3}, login: {4}, paswoord: {5}", this.voornaam, Geslacht));
        }
    }
}