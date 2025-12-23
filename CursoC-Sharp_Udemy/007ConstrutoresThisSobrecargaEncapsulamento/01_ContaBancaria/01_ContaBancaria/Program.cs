using System;
using System.Globalization;

namespace _01_ContaBancaria
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Conta conta;

            Console.Write("Entre com o número da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Haverá depósito inicial (s/n)? ");
            char resposta = char.Parse(Console.ReadLine());
            
            if (resposta == 's' || resposta == 'S')
            {
                Console.Write("Entre com o valor de depósito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new Conta(numero, nome, depositoInicial);
            }
            else
            {
                conta = new Conta(numero, nome);
            }

            Console.WriteLine("\nDados da conta: " + conta);

            Console.Write("\nEntre um valor para depósito: ");
            double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(deposito);
            Console.WriteLine("Dados da conta atualizados: " + conta);

            Console.Write("\nEntre um valor para saque: ");
            double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(saque);
            Console.WriteLine("Dados da conta atualizados: " + conta);
        }
    }
}
