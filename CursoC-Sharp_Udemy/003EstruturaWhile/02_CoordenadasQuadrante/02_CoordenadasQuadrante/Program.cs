using System;
using System.Globalization;

namespace _02_CoordenadasQuadrante
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite as coordenadas [Ex= XX.XX YY.YY]:");
            string[] coor = Console.ReadLine().Split(' ');
            double x = double.Parse(coor[0], CultureInfo.InvariantCulture);
            double y = double.Parse(coor[1], CultureInfo.InvariantCulture);

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

                coor = Console.ReadLine().Split(' ');
                x = double.Parse(coor[0], CultureInfo.InvariantCulture);
                y = double.Parse(coor[1], CultureInfo.InvariantCulture);
            }
        }
    }
}
