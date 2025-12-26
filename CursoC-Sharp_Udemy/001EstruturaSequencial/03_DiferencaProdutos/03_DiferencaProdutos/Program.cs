using System;

namespace _03_DiferencaProdutos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declarando variaveis do mesmo tipo
            int a, b, c, d;

            //pedindo cada uma
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            d = int.Parse(Console.ReadLine());

            //calculando a diferenca
            int dif = (a * b - c * d);

            //mostrando o resultado
            Console.WriteLine("DIFERENCA = " + dif);
        }
    }
}
