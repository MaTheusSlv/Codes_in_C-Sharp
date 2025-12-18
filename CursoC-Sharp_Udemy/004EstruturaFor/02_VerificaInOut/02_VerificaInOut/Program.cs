using System;
using System.Diagnostics;

namespace _02_VerificaInOut
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a quantidade de números que irá digitar:");
            int qtd = int.Parse(Console.ReadLine());

            Console.WriteLine("Agora digite os números:");

            int dentro = 0;
            int fora = 0;

            for (int i = 0;  i < qtd; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num >= 10 && num <= 20)
                {
                    dentro++;
                    
                }
                else
                {
                    fora++;
                }
            }
            Console.WriteLine("\n" + dentro + " in\n" + fora + " out");
        }
    }
}
