using System;

namespace SomTienGetallen
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] resultaten = new int[5];
            int getal1, getal2;
            int counterResultaat = 0;
            int counterGetal = 1;

            Console.Write("Maak som van 10 getallen");
            Console.WriteLine();

            for (int i = 1; i <= 5; i++)
            {
                

                Console.Write($"Getal {counterGetal}: ");
                getal1 = Convert.ToInt32(Console.ReadLine());
                counterGetal++;
                Console.Write($"Getal {counterGetal}: ");
                getal2 = Convert.ToInt32(Console.ReadLine());
                counterGetal++;

                
                resultaten[counterResultaat] = getal1 + getal2;
                counterResultaat++;
            }

            Console.WriteLine();
            Console.WriteLine("--------------------");
            Console.WriteLine();

            int resultatenIndex = 1;

            foreach (int n in resultaten)
            {
                Console.Write($"Oplossing som {resultatenIndex} = {n}\n");
                resultatenIndex++;
            }
        }
    }
}
