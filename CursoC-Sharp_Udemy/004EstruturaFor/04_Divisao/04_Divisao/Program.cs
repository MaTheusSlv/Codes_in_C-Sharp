using System;
using System.Globalization;

namespace _04_Divisao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o número de pares:");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite os pares [Ex= a b]:");

            for (int i = 0; i < num; i++)
            {
                string[] par = Console.ReadLine().Split(" ");
                double fir = double.Parse(par[0]);
                int sec = int.Parse(par[1]);

                if (sec == 0)
                {
                    Console.WriteLine("Divisão Impossível, Denominador = 0");
                }
                else
                {
                    double divisao = fir / sec;
                    Console.WriteLine(divisao.ToString("F1", CultureInfo.InvariantCulture));
                }
            }
        }
    }
}
