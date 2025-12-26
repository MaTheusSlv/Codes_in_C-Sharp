using System;
using System.Globalization;

namespace _02_CoordenadasQuadrante
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //pede as coordenadas do ponto
            Console.WriteLine("Digite as coordenadas [Ex= XX.XX YY.YY]:");
            string[] coor = Console.ReadLine().Split(' ');
            double x = double.Parse(coor[0], CultureInfo.InvariantCulture);
            double y = double.Parse(coor[1], CultureInfo.InvariantCulture);

            //verifica o quadrante enquanto ele for diferente de 0 para X e Y
            while (x != 0.00 && y != 0.00)
            {
                if (x > 0.00 && y > 0.00)
                {
                    Console.WriteLine("Primeiro");
                }
                else if (x < 0.00 && y > 0.00)
                {
                    Console.WriteLine("Segundo");
                }
                else if (x < 0.00 && y < 0.00)
                {
                    Console.WriteLine("Terceiro");
                }
                else
                {
                    Console.WriteLine("Quarto");
                }

                //pede novas coordenadas caso for igual a 0 para X ou Y
                coor = Console.ReadLine().Split(' ');
                x = double.Parse(coor[0], CultureInfo.InvariantCulture);
                y = double.Parse(coor[1], CultureInfo.InvariantCulture);
            }
        }
    }
}
