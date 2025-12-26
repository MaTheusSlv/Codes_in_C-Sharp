using System;
using System.Globalization;

namespace _03_MediaPonderada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //pede os casos a serem calculados
            Console.WriteLine("Digite a quantidade de casos:");
            int qtd = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite os casos [Ex: a.a b.b c.c]:");

            //pega cada caso e calcula a média ponderada
            for (int i = 0; i < qtd; i++)
            {
                string[] num = Console.ReadLine().Split(' ');

                double a = double.Parse(num[0], CultureInfo.InvariantCulture); //sempre usar InvariantCulture pra evitar erro de cálculo
                double b = double.Parse(num[1], CultureInfo.InvariantCulture);
                double c = double.Parse(num[2], CultureInfo.InvariantCulture);

                //calcula a média ponderada
                double media = (a * 2 + b * 3 + c * 5) / 10;
                //mostra o resultado
                Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture)); //sempre usar InvariantCulture pra evitar erro de cálculo
            }
        }
    }
}
