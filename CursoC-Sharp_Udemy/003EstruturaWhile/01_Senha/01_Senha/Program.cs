using System;

namespace _01_Senha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //pede a senha
            Console.WriteLine("Digite a senha numérica válida:"); //Senha correta 2002 ;)

            int senha = int.Parse(Console.ReadLine());

            //enquanto a senha for incorreta, pedir novamente
            while (senha != 2002)
            {
                Console.WriteLine("Senha Inválida!");
                senha = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Acesso Permitido!");
        }
    }
}
