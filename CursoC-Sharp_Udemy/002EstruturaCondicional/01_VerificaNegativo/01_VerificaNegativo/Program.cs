using System;

namespace _01_VerificaNegativo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //pedindo o número a ser verificado
            Console.WriteLine("Digite um número para ser verificado:");
            int num = int.Parse(Console.ReadLine());

            //verificando se o número é negativo
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
