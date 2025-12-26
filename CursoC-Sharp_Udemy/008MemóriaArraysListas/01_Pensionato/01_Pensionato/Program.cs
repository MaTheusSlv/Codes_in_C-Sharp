using System;
using System.Globalization;

namespace _01_Pensionato
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //pede a qtd de quartos a serem alugados
            Console.WriteLine("Quantos quartos serão alugados? ");
            int qtd_quartos = int.Parse(Console.ReadLine());

            //cria os quartos a serem alugados
            Estudante[] quartos = new Estudante[10];

            //pede as informações de cada estudante para realizar o aluguel
            for (int i = 1; i <= qtd_quartos; i++)
            {
                Console.WriteLine("\nAluguel #" + i);
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());

                quartos[quarto] = new Estudante(nome, email); //realiza o aluguel do quarto pelo Estudante
            }

            //mostra os quartos que não estão alugados
            Console.WriteLine("\nQuartos ocupados:");
            for (int i = 0; i < 10; i++)
            {
                if (quartos[i] != null)
                {
                    Console.WriteLine(i + ": " + quartos[i]);
                }
            }
        }
    }
}
