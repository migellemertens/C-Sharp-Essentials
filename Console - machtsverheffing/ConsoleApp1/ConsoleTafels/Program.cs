using System;

namespace ConsoleTafels
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("De tafels van vermenigvuldiging tot 12:");
            Console.WriteLine();

            for(int i = 1; i <= 12; i++)
            {
                Console.WriteLine($"\nDruk op enter voor tafel van {i}");
                Console.ReadLine();

                for(int j = 1; j <=10; j++)
                {
                    Console.WriteLine($"{i} * {j} = {i * j}");
                }
            }

            Console.WriteLine("druk enter om af te sluiten");
            Console.ReadLine();
        }

  
    }
}
