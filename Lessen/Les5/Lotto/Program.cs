using System;
using System.Threading;

namespace Lotto
{
    class Program
    {
        static void Main(string[] args)
        {
            SchrijfLog(GenereerWillekeurigGetal());
            SchrijfLog(GenereerWillekeurigGetal(1, 45));
            SchrijfLog(GenereerLottoGetallen());
            //LottoTrekking();

            Euromillions();

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
        static string GenereerLottoGetallen(){
            string output = "";
            for(int i = 0; i < 6; i++){
                output += " " + GenereerWillekeurigGetal(1,45);
            }
            return output;
        }
        // static void LottoTrekking(){
        //     SchrijfLog("Lottotrekking");
        //     for(int i = 0; i < 6; i++){
        //         SchrijfLog(GenereerWillekeurigGetal(1,45));
        //         Thread.Sleep(5000);
        //     }
        // }
        static void Euromillions(){
            SchrijfLog("Euromillions");
            SchrijfLog("De nummers: ");
            for(int j = 0; j < 5; j++){
                SchrijfLog(GenereerWillekeurigGetal(1,45));
                Thread.Sleep(2000);
            }
            SchrijfLog("De sterren: ");
            for(int k = 0; k < 2; k++){
                SchrijfLog(GenereerWillekeurigGetal(1,12));
                Thread.Sleep(2000);
            }
        }
    }
}
