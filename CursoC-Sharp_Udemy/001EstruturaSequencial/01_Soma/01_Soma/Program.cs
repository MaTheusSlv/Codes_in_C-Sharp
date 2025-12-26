using System;

namespace _01_Soma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declarando variáveis de mesmo tipo
            int a, b, soma;
            
            //pega os números digitados
            Console.WriteLine("Digite o primeiro número");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número");
            b = int.Parse(Console.ReadLine());

            //fazendo a soma
            soma = a + b;

            //mostrando o resultado
            Console.WriteLine("SOMA = " + soma);
        }
    }
}
