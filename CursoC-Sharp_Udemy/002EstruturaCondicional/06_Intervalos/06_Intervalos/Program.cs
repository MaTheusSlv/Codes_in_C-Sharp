using System;
using System.Globalization;

namespace _06_Intervalos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //pedindo um número para verificar qual é seu intervalo
            Console.WriteLine("Digite um número pra verificar seu intervalo [Ex= X.XX]:");
            double num = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //verificando intervalo
            if (num < 0.00 || num > 100.00)
            {
                Console.WriteLine("Fora de Intervalo");
            }
            else if (num <= 25.00)
            {
                Console.WriteLine("Intervalo [0, 25]");
            }
            else if (num <= 50.00)
            {
                Console.WriteLine("Intervalo [25, 50]");
            }
            else if (num <= 75.00)
            {
                Console.WriteLine("Intervalo [50, 75]");
            }
            else
            {
                Console.WriteLine("Intervalo [75, 100]");
            }
        }
    }
}
