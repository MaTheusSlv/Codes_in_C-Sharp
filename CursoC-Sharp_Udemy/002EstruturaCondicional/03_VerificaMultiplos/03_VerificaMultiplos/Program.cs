using System;

namespace _03_VerificaMultiplos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //pedindo 2 números para verificar
            Console.WriteLine("Digite 2 números no formato X Y:");
            string[] numeros = Console.ReadLine().Split(' '); //quebrando a string informada com o espaço vazio

            //jogando os números nas variáveis
            int num1 = int.Parse(numeros[0]);
            int num2 = int.Parse(numeros[1]);

            //verificando se são múltiplos
            if (num1 % num2 == 0 || num2 % num1 == 0)
            {
                Console.WriteLine("SÃO MULTIPLOS");
            }
            else
            {
                Console.WriteLine("NÃO SÃO MULTIPLOS");
            }
        }
    }
}
