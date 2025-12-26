using System;

namespace _02_ParOuImpar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //pedindo o número para verificar
            Console.WriteLine("Digite um número:");
            int num = int.Parse(Console.ReadLine());

            //verificando se é par ou impar
            if (num % 2 == 0)
            {
                Console.WriteLine("PAR");
            }
            else
            {
                Console.WriteLine("IMPAR");
            }
        }
    }
}
