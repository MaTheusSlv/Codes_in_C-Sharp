using System;
using System.Globalization;

namespace _05_Fatorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //pede o número para fazer o fatorial dele
            Console.WriteLine("Digite um número para obter o fatorial:");
            int num = int.Parse(Console.ReadLine());

            double fatorial = 1;

            //faz a fatoração apresentando o resultado
            for (int i = 1; i <= num; i++)
            {
                fatorial = fatorial * i;
            }

            Console.WriteLine(fatorial);
        }
    }
}
