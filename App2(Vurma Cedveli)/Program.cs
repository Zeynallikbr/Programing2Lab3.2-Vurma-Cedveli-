using System.Collections.Concurrent;

namespace App2_Vurma_Cedveli_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vurma Cedveli.");
            Console.WriteLine(" 1  2  3  4  5  6  7  8  9  10");
            Console.WriteLine("____________________________________");
            for (int i = 1; i < 11; i++)
            {
                Console.Write($"{i} | ");
                for (int j = 1; j < 11; j++)
                {
                    //Console.WriteLine($"{i}");
                    Console.Write($"{i *  j} ");
                    if (i == 11)
                    {
                        Console.WriteLine("  ");
                    }
                }
                Console.WriteLine(" ");
            }
        }
    }
}
