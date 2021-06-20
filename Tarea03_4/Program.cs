using System;

namespace Tarea03_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 10;

            Console.WriteLine("Valor inicial de N = {0}", N);
            Console.WriteLine("N + 77 = {0}", N += 77);
            Console.WriteLine("N - 3 = {0}", N -= 3);
            Console.WriteLine("N * 2 = {0}", N *= 2);


            Console.ReadKey();
        }
    }
}
