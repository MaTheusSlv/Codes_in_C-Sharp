using System;

namespace _01_Senha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a senha numérica válida:"); //Senha correta 2002 ;)

            int senha = int.Parse(Console.ReadLine());

            while (senha != 2002)
            {
                Console.WriteLine("Senha Inválida!");
                senha = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Acesso Permitido!");
        }
    }
}
