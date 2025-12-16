using System;
using System.Globalization;

namespace _02_RaioDoCirculo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double pi = 3.14159;
            Console.WriteLine("Digite o valor do raio:");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double area = pi * raio * raio;

            Console.WriteLine("A= " + area.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}
