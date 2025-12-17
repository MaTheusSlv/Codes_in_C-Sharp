using System;
using System.Globalization;

namespace _07_QuadrantePlanoCartesiano
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite as coordenadas [Ex= XX.XX YY.YY]:");
            string[] coor = Console.ReadLine().Split(' ');
            double x = double.Parse(coor[0], CultureInfo.InvariantCulture);
            double y = double.Parse(coor[1], CultureInfo.InvariantCulture);

            if (x == 0.00 && y == 0.00)
            {
                Console.WriteLine("Origem");
            }
            else if (y == 0.00)
            {
                Console.WriteLine("Eixo X");
            }
            else if (x == 0.00)
            {
                Console.WriteLine("Eixo Y");
            }
            else if (x > 0.00 && y > 0.00)
            {
                Console.WriteLine("Q1");
            }
            else if (x < 0.00 && y > 0.00)
            {
                Console.WriteLine("Q2");
            }
            else if (x < 0.00 && y < 0.00)
            {
                Console.WriteLine("Q3");
            }
            else
            {
                Console.WriteLine("Q4");
            }
        }
    }
}
