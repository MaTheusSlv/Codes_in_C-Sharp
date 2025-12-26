using System;
using System.Globalization;

namespace _01_ContaBancaria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //cria a conta do tipo conta na memória
            Conta conta;

            //pede as informações da conta
            Console.Write("Entre com o número da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Haverá depósito inicial (s/n)? ");
            char resposta = char.Parse(Console.ReadLine());
            
            //verifica se vai ter depósito inicial, se sim já pede a quantia
            if (resposta == 's' || resposta == 'S')
            {
                Console.Write("Entre com o valor de depósito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new Conta(numero, nome, depositoInicial); //cria a conta com o depósito
            }
            else
            {
                conta = new Conta(numero, nome); //cria a conta sem depósito
            }

            //mostra os dados da conta criada
            Console.WriteLine("\nDados da conta: " + conta);

            //pede o valor que será depositado
            Console.Write("\nEntre um valor para depósito: ");
            double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(deposito); //faz o depósito
            Console.WriteLine("Dados da conta atualizados: " + conta); //mostra os dados atualizados

            //pede o valor que será sacado
            Console.Write("\nEntre um valor para saque: ");
            double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(saque); //faz o saque
            Console.WriteLine("Dados da conta atualizados: " + conta); //mostra os dados atualizados
        }
    }
}
