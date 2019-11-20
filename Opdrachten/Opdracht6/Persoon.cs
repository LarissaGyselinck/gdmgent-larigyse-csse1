using System;

namespace Opdracht6
{
    public class Persoon
    {
        // Velden
        public string voornaam;
        protected char geslacht;

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

        // Methoden
        public void LogOutput()
        {
            Console.WriteLine(String.Format("Output: Voornaam: {0}, Familienaam: {1}, Geslacht: {2}, geslacht: {3}", this.voornaam, Naam, Geslacht, this.geslacht));
        }
    }

}