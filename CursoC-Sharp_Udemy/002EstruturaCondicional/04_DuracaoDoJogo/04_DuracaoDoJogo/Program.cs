using System;

namespace _04_DuracaoDoJogo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //pedindo hora de início e fim do jogo
            Console.WriteLine("Digite a hora de Inicio e de Fim [Ex= II FF]:");
            string[] hr = Console.ReadLine().Split(' ');

            int ini = int.Parse(hr[0]);
            int fim = int.Parse(hr[1]);

            //calculando a duração do jogo
            if(ini < fim)
            {
                int dur = fim - ini;
                Console.WriteLine("O JOGO DUROU " + dur + " HORA(S)");
            }
            else
            {
                int dur = 24 - ini + fim;
                Console.WriteLine("O JOGO DUROU " + dur + " HORA(S)");
            }
        }
    }
}
