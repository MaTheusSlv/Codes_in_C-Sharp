using System;

namespace _07_ListandoQuadradoECubo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número para obter uma lista com o mesmo número de itens e com os valores X² e X³:");
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                int quadrado = i * i;
                int cubo = i * i * i;
                Console.WriteLine(i + " " + quadrado + " " + cubo);
            }
        }
    }
}
