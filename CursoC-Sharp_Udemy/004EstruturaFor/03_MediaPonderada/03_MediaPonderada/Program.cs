using System;
using System.Globalization;

namespace _03_MediaPonderada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a quantidade de casos:");
            int qtd = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite os casos [Ex: a.a b.b c.c]:");

            for (int i = 0; i < qtd; i++)
            {
                string[] num = Console.ReadLine().Split(' ');

                double a = double.Parse(num[0], CultureInfo.InvariantCulture);
                double b = double.Parse(num[1], CultureInfo.InvariantCulture);
                double c = double.Parse(num[2], CultureInfo.InvariantCulture);

                double media = (a * 2 + b * 3 + c * 5) / 10;

                Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}
