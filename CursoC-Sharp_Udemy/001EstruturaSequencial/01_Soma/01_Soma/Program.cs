using System;

namespace _01_Soma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, soma;
            
            Console.WriteLine("Digite o primeiro número");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número");
            b = int.Parse(Console.ReadLine());

            soma = a + b;

            Console.WriteLine("SOMA = " + soma);
        }
    }
}
