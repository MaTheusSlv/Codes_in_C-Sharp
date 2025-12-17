using System;

namespace _01_VerificaNegativo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número para ser verificado:");
            int num = int.Parse(Console.ReadLine());

            if (num >= 0)
            {
                Console.WriteLine("NAO NEGATIVO");
            }
            else
            {
                Console.WriteLine("NEGATIVO");
            }

        }
    }
}
