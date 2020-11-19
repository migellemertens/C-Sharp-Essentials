using System;

namespace Fibonaci
{
    class Program
    {
        static void Main(string[] args)
        {
            int getal1 = 0;
            int getal2 = 1;
            int som;

            Console.Write($"{getal1} {getal2} ");

            for(int i = 0; i < 10; i++)
            {
                som = getal1 + getal2;
                Console.Write($"{som} ");
                getal1 = getal2;
                getal2 = som;
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
