using System;

namespace Les___Cijfers_ingeven
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[9];

            for(int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"Geef getal {i+1}/9");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Welk getal wil je zien");
            int nummer = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(numbers[nummer - 1]);
            Console.Read();
        }
    }
}
