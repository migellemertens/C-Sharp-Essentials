using System;

namespace SomGeheleGetallen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Maak de som van 5 ingevoerde gehele getallen");

            int som = 0;

            for(int i = 1; i <=5; i++)
            {
                Console.Write($"geef getal {i}: ");
                Console.WriteLine();

                som += Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"--> som voorgaande getallen: {som}");
                Console.WriteLine();
                Console.WriteLine();
            }
        }
    }
}
