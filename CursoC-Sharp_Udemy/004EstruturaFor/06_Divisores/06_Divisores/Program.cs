using System;

namespace _06_Divisores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número para obter os divisores:");
            int num = int.Parse(Console.ReadLine());

            for (int i = 1;  i <= num; i++)
            {
                if (num % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
