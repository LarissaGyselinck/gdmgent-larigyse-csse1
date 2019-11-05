using System;
using System.Threading;

namespace Opdracht5
{
    class Program
    {
        static void Main(string[] args)
        {
            SchrijfLog(Som(5, 6));
            SchrijfLog(Verschil(8, 5));
            SchrijfLog(Quotient(8, 4));
            SchrijfLog(Product(5, 3));
            SchrijfLog(Modulo(9, 2));
            SchrijfLog(Verhogen(7));
            SchrijfLog(Verlagen(8));

            SchrijfLog(GenereerWillekeurigGetal());
            SchrijfLog(GenereerWillekeurigGetal(0, 80));

            SchrijfLog(Lotto());
            LottoTrekking();

            Euromillions();
            EuromillionsTrekking();

            SchrijfLog(GenereerAccount("student", "larissa", "gyselinck")); 

            SchrijfLog(ValideerIBAN("BE58 9730 7305 5279"));

            Faculteit(5);
            Fibonacci(0, 1);
        }

        static void SchrijfLog(string output) => Console.WriteLine(output);
        static void SchrijfLog(int output) => Console.WriteLine(output.ToString());
        static int Som(int getal1, int getal2){
            SchrijfLog("Som...");
            return getal1 + getal2;
        }
        static int Verschil(int getal1, int getal2){
            SchrijfLog("Verschil...");
            return getal1 - getal2;
        }
        static int Quotient(int getal1, int getal2){
            SchrijfLog("Quotient...");
            return getal1 / getal2;
        }
        static int Product(int getal1, int getal2){
            SchrijfLog("Product...");
            return getal1 * getal2;
        }
        static int Modulo(int getal1, int getal2){
            SchrijfLog("Modulo...");
            return getal1%getal2;
        }
        static int Verhogen(int getal){
            SchrijfLog("Verhogen...");
            return ++getal;
        }
        static int Verlagen(int getal){
            SchrijfLog("Verlagen...");
            return --getal;
        }
        static int GenereerWillekeurigGetal(){
            SchrijfLog("Willekeurig getal...");
            Random r = new Random();
            return r.Next();
        }
        static int GenereerWillekeurigGetal(int min, int max){
            SchrijfLog("Willekeurig getal tussen " + min + " en " + max);
            Random r = new Random();
            return r.Next(min, max);
        }
        static int GenereerWillekeurigeGetallen(int min, int max){
            Random r = new Random();
            return r.Next(min, max);
        }
        static string Lotto(){
            SchrijfLog("Lotto...");
            string output = "";
            for(int i = 0; i < 6; i++){
                output += " " + GenereerWillekeurigeGetallen(1,45);
            }
            return output;
        }
        static void LottoTrekking(){
            SchrijfLog("Lottotrekking...");
            for(int i = 0; i < 6; i++){
                SchrijfLog(GenereerWillekeurigeGetallen(1,45));
                Thread.Sleep(5000);
            }
        }
        static void Euromillions(){
            SchrijfLog("Euromillions...");
            SchrijfLog("De nummers: ");
            for(int j = 0; j < 5; j++){
                SchrijfLog(GenereerWillekeurigeGetallen(1,50));
            }
            SchrijfLog("De sterren: ");
            for(int k = 0; k < 2; k++){
                SchrijfLog(GenereerWillekeurigeGetallen(1,12));
            }
        }
        static void EuromillionsTrekking(){
            SchrijfLog("Euromillions-trekking");
            SchrijfLog("De nummers: ");
            for(int j = 0; j < 5; j++){
                SchrijfLog(GenereerWillekeurigeGetallen(1,50));
                Thread.Sleep(2000);
            }
            SchrijfLog("De sterren: ");
            for(int k = 0; k < 2; k++){
                SchrijfLog(GenereerWillekeurigeGetallen(1,12));
                Thread.Sleep(2000);
            }
        }
        static string GenereerString(string input, int lengte){
            return input.Substring(0, lengte);
        }
        // voor docent voornaam 4, familienaam 2, voor student voornaam 4, familienaam 4
        static string GenereerAccount(string type, string voornaam, string familienaam){
            SchrijfLog("Genereer account...");
            string account = "";
            if(type.ToLower() == "docent"){
                string kortvoornaam = GenereerString(voornaam, 4);
                string kortfamilienaam = GenereerString(familienaam, 2);
                account = kortvoornaam.ToLower() + kortfamilienaam.ToLower() + "@arteveldehs.be";
            } else if(type.ToLower() == "student"){
                string kortvoornaam = GenereerString(voornaam, 4);
                string kortfamilienaam = GenereerString(familienaam, 4);
                account = kortvoornaam.ToLower() + kortfamilienaam.ToLower() + "@student.arteveldehs.be";
            }
            return account;
        }
        static string ValideerIBAN(string IBAN){
            IBAN = IBAN.Replace(" ", "");
            string land = GenereerString(IBAN, 2).ToLower();
            int controleGetal = Int32.Parse(IBAN.Substring(2, 2));
            string temp = "";
            foreach(char c in land){
                temp += (int) c - 87;
            }
            temp += IBAN.Substring(2, 2);
            long temp2 = Convert.ToInt64(IBAN.Substring(4, IBAN.Length-4) + temp);
            if(IBAN.Length != 16 || land != "be" || controleGetal < 2 || controleGetal > 98 || temp2%97 != 1){
                return IBAN + " is geen geldig IBAN-nummer.";
            } else {
                return IBAN + " is een geldig IBAN-nummer";
            }
        }
        static void Faculteit(int faculteit){
            Console.WriteLine("Faculteit...");
            int getal;
            Console.WriteLine("Geef een getal in: ");
            getal = Convert.ToInt32(Console.ReadLine());
            for(int i = 1; i <= getal; i++){      
                faculteit = faculteit * i;      
            }
            Console.WriteLine("Faculteit van " + getal + " is: " + faculteit);
        }
        static void Fibonacci(int getal1, int getal2){
            Console.WriteLine("Fibonacci...");
            int getal;
            int getal3;
            Console.WriteLine("Geef een getal in: ");
            getal = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine(getal1 + " " + getal2 + " ");
            for(int i = 2; i < getal; ++i)
            {    
                getal3 = getal1 + getal2;    
                Console.WriteLine(getal3 + " ");    
                getal1 = getal2;    
                getal2 = getal3;            
            }
        }
    }
}
