using System;

namespace Oefening1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            object o = null;
            try
            {
                int i = (int)o;     // error
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine("NRE: " + e.Message);
            }
            catch (InvalidCastException e)
            {
                Console.Write("ICE: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("E: " + e.StackTrace);
            }
            finally
            {
                Console.WriteLine("Finally");
            }
        }
    }
}
