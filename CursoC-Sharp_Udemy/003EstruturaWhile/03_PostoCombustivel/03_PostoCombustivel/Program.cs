using System;

namespace _03_PostoCombustivel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //pede o código do tipo de combustível
            Console.WriteLine("Informe o código do tipo do Combustível\n1.Álcool; 2.Gasolina; 3.Diesel\n4.Fim da lista:");
            int informado = int.Parse(Console.ReadLine());

            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;

            //faz a contagem do que foi informado
            while (informado != 4)
            {
                if (informado == 1)
                {
                    alcool++;
                }
                else if (informado == 2)
                {
                    gasolina++;
                }
                else if (informado == 3)
                {
                    diesel++;
                }

                informado = int.Parse(Console.ReadLine());
            }
            //mostra o resultado final
            Console.WriteLine("MUITO OBRIGADO!");
            Console.WriteLine("Álcool: " + alcool);
            Console.WriteLine("Gasolina: " + gasolina);
            Console.WriteLine("Diesel: " + diesel);
        }
    }
}
