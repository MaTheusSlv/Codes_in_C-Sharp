using System;
using System.Globalization;

namespace _06_PontosFlutuantes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declarando variáveis do mesmo tipo e o valor de pi
            double a, b, c;
            double pi = 3.14159;

            //solicitando os valores ao usuário na ordem
            Console.WriteLine("Digite 3 valores no formato X.X :");
            string[] num = Console.ReadLine().Split(' ');
            a = double.Parse(num[0], CultureInfo.InvariantCulture);
            b = double.Parse(num[1], CultureInfo.InvariantCulture);
            c = double.Parse(num[2], CultureInfo.InvariantCulture);

            //fazendo os cálculos
            double triangulo = (a * c) / 2;
            double circulo = pi * Math.Pow(c, 2);
            double trapezio = ((a + b) * c) / 2;
            double quadrado = b * b;
            double retangulo = a * b;

            //mostrando os resultados na tela com 3 casas decimais
            Console.WriteLine("TRIANGULO: " + triangulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: " + circulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: " + trapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " + quadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: " + retangulo.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
