using System;
using System.Globalization;

namespace _02_RaioDoCirculo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declarando o valor de pi
            double pi = 3.14159;
            //pedindo o valor do raio
            Console.WriteLine("Digite o valor do raio:");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //calculando a area
            double area = pi * raio * raio;

            //mostrando o resultado
            Console.WriteLine("A= " + area.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}
