using System;

namespace _03_VerificaMultiplos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite 2 números no formato X Y:");
            string[] numeros = Console.ReadLine().Split(' ');

            int num1 = int.Parse(numeros[0]);
            int num2 = int.Parse(numeros[1]);

            if (num1 % num2 == 0 || num2 % num1 == 0)
            {
                Console.WriteLine("SÃO MULTIPLOS");
            }
            else
            {
                Console.WriteLine("NÃO SÃO MULTIPLOS");
            }
        }
    }
}
