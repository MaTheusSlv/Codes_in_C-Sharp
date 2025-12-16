using System;

namespace _03_DiferencaProdutos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d;

            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            d = int.Parse(Console.ReadLine());

            int dif = (a * b - c * d);

            Console.WriteLine("DIFERENCA = " + dif);
        }
    }
}
