using System;

namespace _01_Impares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //pede o número
            Console.WriteLine("Dígite um número:");
            int x = int.Parse(Console.ReadLine());

            //mostra os números ímpares até chegar no número informado
            for (int i = 1; i <= x; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
