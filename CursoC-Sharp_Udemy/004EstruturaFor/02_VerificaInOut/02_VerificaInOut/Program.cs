using System;
using System.Diagnostics;

namespace _02_VerificaInOut
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //pede a qtd de números a serem digitados
            Console.WriteLine("Digite a quantidade de números que irá digitar:");
            int qtd = int.Parse(Console.ReadLine());

            //pede os números
            Console.WriteLine("Agora digite os números:");

            int dentro = 0;
            int fora = 0;

            //verifica se os números estão dentro ou fora do intervalo
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
            //mostra o resultado
            Console.WriteLine("\n" + dentro + " in\n" + fora + " out");
        }
    }
}
