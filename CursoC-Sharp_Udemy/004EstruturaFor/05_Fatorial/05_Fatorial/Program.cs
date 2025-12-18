using System;
using System.Globalization;

namespace _05_Fatorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número para obter o fatorial:");
            int num = int.Parse(Console.ReadLine());

            double fatorial = 1;

            for (int i = 1; i <= num; i++)
            {
                fatorial = fatorial * i;
            }

            Console.WriteLine(fatorial);
        }
    }
}
