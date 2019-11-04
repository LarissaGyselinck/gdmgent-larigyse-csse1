using System;

namespace rekenmachine
{
    class Program
    {
        static void Main(string[] args)
        {
            // SchrijfLog(Convert.ToString(Product(2,3)));
            // SchrijfLog(Convert.ToString(Product(2,3)));
            SchrijfLog(Som(2,3));
            SchrijfLog(Verschil(2,3));
            SchrijfLog(Quotient(2,3));
            SchrijfLog(Product(2,3));
            SchrijfLog(Verhogen(2));
            SchrijfLog(Verlagen(2));

            SchrijfLog(GenereerWillekeurigGetal());
            SchrijfLog(GenereerWillekeurigGetal(1, 45));


        }

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
        static int Verhogen(int getal){
            SchrijfLog("Verhogen...");
            return ++getal;
        }
        static int Verlagen(int getal){
            SchrijfLog("Verlagen...");
            return --getal;
        }

        static void SchrijfLog(string output) => Console.WriteLine(output);

        static void SchrijfLog(int output) => Console.WriteLine(output.ToString());

        static int GenereerWillekeurigGetal(){
            Random r = new Random();
            return r.Next();
        }
        static int GenereerWillekeurigGetal(int min, int max){
            Random r = new Random();
            return r.Next(min, max);
        }

    }
}
