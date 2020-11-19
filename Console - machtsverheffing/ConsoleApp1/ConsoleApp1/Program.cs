using Microsoft.VisualBasic.CompilerServices;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            ulong macht;

            Console.Write("Geef een grondtal kleiner dan 85: ");
            int grondtal = int.Parse(Console.ReadLine());

            if(grondtal < 85)
            {
                Console.WriteLine();
                for(int i = 1; i <= 10; i++)
                {
                    macht = (ulong)Math.Pow(grondtal, i);

                    Console.WriteLine($"de macht {i,2} van {grondtal} = {macht:n0}");
                }
            }
            else
            {
                Console.WriteLine("\n\n Geef getal groter dan 85!");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Druk op enter om af te sluiten...");
            Console.ReadKey();
        }
    }
}
