using System;

namespace Labb_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Skapar en instans av tärning
            Tärning minTärning = new Tärning(10);

            //Kör metoden kasta och matar in return värdet i en ny int
            int slumptal = minTärning.Kasta();

            //Skriver ut det tal man fick av tärningskastningen
            Console.WriteLine($"Du fick en {slumptal}a");
        }
    }

    class Tärning
    {  
        //skapar variabler
        int AntalSidor {get; set;}
        Random generator = new Random();

        //Skapar constructor
        public Tärning(int antalSidor)
        {
            AntalSidor = antalSidor;
        }

        /// <summary>
        /// slumpar fram ett tal mellan 1 och det specificerade högsta talet
        /// </summary>
        /// <returns>talet som slumpades fram</returns>
        public int Kasta()
        {
            return generator.Next(1, AntalSidor+1);
        }
    }
}

